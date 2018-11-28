Imports pca9468_mp12_fields
Imports PcaConnect
Imports mvc


Public Class FrmMain_mp12

    Private Enum ViewEnum
        ve_Functional
        ve_RegisterMap
    End Enum

    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000
    Private Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004
    Private Const cDelayAfterUSBEnum_ms As Int64 = 500
    Private Const cAardvark_ID As UInt32 = 2
    Private Const cFT232_ID As UInt32 = 5

    Private cSlaBase As Byte = &H55
    

    Private m_scheduleScan As Int64 = 0
    Private m_scheduleConnect As Int64 = 0
    Private m_scheduleStatusRead As Int64 = 0
    Private m_I2Cconnected As Boolean = False
    Private m_USBconnected As Boolean = False
    Private m_statusReadInterval As Int64   'Status registers read interval in ms

    Private Sub UpdateModel()
        If Model.ReadAll() <> Model.pca_result_t.pca_ok Then I2C_connected = False
    End Sub

    Private Property I2C_connected As Boolean
        Get
            Return m_I2Cconnected
        End Get
        Set(value As Boolean)
            If value <> m_I2Cconnected Then
                If value Then
                    m_scheduleConnect = 0
                    tslConnection.Image = My.Resources.plug_connect
                    tslConnection.Text = "Connected"
                    UpdateModel()
                    ScheduleStatusRead()

                Else
                    m_scheduleStatusRead = 0
                    tslConnection.Image = My.Resources.plug_disconnect
                    tslConnection.Text = "Disconnected"
                End If
                m_I2Cconnected = value
            End If
            If m_I2Cconnected = False Then m_scheduleConnect = TimeTicks() + 250
        End Set
    End Property

    Private Property USB_connected As Boolean
        Get
            Return m_USBconnected
        End Get
        Set(value As Boolean)
            If value <> m_USBconnected Then
                m_USBconnected = value
                If value Then
                    tslInterface.Text = " [" & Connection.Info & "]"
                    I2C_Connect()
                Else
                    tslInterface.Text = " No hardware interface present"
                    I2C_connected = False
                End If
            End If
            If value = False Then m_scheduleScan = TimeTicks() + cDelayAfterUSBEnum_ms
        End Set
    End Property

    Private Sub ScanInterfaces()
        If Connection.SelectInterface(cAardvark_ID) <> Connection.pc_result_t.pc_ok Then
            Connection.SelectInterface(cFT232_ID)
        End If
        USB_connected = Connection.Connected
    End Sub

    Private Sub I2C_Connect()
        If USB_connected Then
            Dim con As Boolean = False
            ' try all three addresses *need to revise
            For idx As Integer = 0 To 2
                'scan 0x55, 0x57, 0x5E
                Select Case idx
                    Case 0
                        cSlaBase = &H55
                    Case 1
                        cSlaBase = &H57
                    Case 2
                        cSlaBase = &H5E
                End Select
                Model.SlaveAddress = CByte(cSlaBase)
                con = mvc.Model.ReadRegister(0) = mvc.Model.pca_result_t.pca_ok
                If con Then
                    lblAddr.Text = "0x" & Hex(cSlaBase)
                    Exit For
                End If
            Next
            I2C_connected = con
            '2018.10.26. Clark Kim 
            'Set LIMIT_INCREMENT_EN bit to 0 after connection
            'and disable the selection.
            'Disable LIMIT_INCREMENT_EN of IIN_CTRL
            mvc.Model.WriteRegisterField(pca_data_fields_enum_t.limit_increment_en, &H0)
            'Delete the chopping mode selection.
            'Enable chopping mode'
            'mvc.Model.DbgWriteRegister(&H30, &H5B)
            'mvc.Model.DbgWriteRegister(&H3E, &HA)
        End If
    End Sub

    Private Sub AttachModel()
        Dim v As New View(lblId, pca_data_fields_enum_t.dev_id)
        v = New View(lblRev, pca_data_fields_enum_t.dev_rev)

        'Ctrl View'
        lblSenseR.Text = Model.Caption(pca_data_fields_enum_t.snsres)
        v = New View(cmbSenseR, pca_data_fields_enum_t.snsres)
        lblchgSoftStep.Text = Model.Caption(pca_data_fields_enum_t.ichg_ss)
        v = New View(cmbChgSoftStep, pca_data_fields_enum_t.ichg_ss)
        lblIinSoftStep.Text = Model.Caption(pca_data_fields_enum_t.iin_ss)
        v = New View(cmbIinSoftStep, pca_data_fields_enum_t.iin_ss)
        v = New View(chkCfgEn, pca_data_fields_enum_t.cfg_en)
        v = New View(chkStandbyEn, pca_data_fields_enum_t.standby_en)
        v = New View(chkRevCurrentDet, pca_data_fields_enum_t.rev_iin_det)
        v = New View(chkLimitIncrementEn, pca_data_fields_enum_t.limit_increment_en)

        lblIchgCfg.Text = Model.Caption(pca_data_fields_enum_t.ichg_cfg)
        v = New View(lblIchgCfgVal, pca_data_fields_enum_t.ichg_cfg)
        v = New View(trbIchgCfg, pca_data_fields_enum_t.ichg_cfg)
        lblIinCfg.Text = Model.Caption(pca_data_fields_enum_t.iin_cfg)
        v = New View(lblIinCfgVal, pca_data_fields_enum_t.iin_cfg)
        v = New View(trbIinCfg, pca_data_fields_enum_t.iin_cfg)
        lblSwFreqCfg.Text = Model.Caption(pca_data_fields_enum_t.fsw_cfg)
        v = New View(cmbSwFreqCfg, pca_data_fields_enum_t.fsw_cfg)

        'ADC View'
        v = New View(chkNtcAdcEn, pca_data_fields_enum_t.ntc_adc_en)
        v = New View(chkSysVoltageAdcEn, pca_data_fields_enum_t.sysV_adc_en)
        v = New View(chkDieTempAdcEn, pca_data_fields_enum_t.dietemp_adc_en)
        v = New View(chkChrageCurrentAdcEn, pca_data_fields_enum_t.chgcurrent_adc_en)
        v = New View(chkInputCurrentAdcEn, pca_data_fields_enum_t.iin_adc_en)
        v = New View(chkBatteryVoltageAdcEn, pca_data_fields_enum_t.vbat_adc_en)
        v = New View(chkInputVoltageAdcEn, pca_data_fields_enum_t.vin_adc_en)

        v = New View(txtNtcAdc, pca_data_fields_enum_t.adc_ntcv)
        v = New View(txtSysVoltage, pca_data_fields_enum_t.adc_vout)
        v = New View(txtDieTemp, pca_data_fields_enum_t.adc_dietemp)
        v = New View(txtChargeCurrent, pca_data_fields_enum_t.adc_iout)
        v = New View(txtInputCurrent, pca_data_fields_enum_t.adc_iin)
        v = New View(txtBatteryVoltage, pca_data_fields_enum_t.adc_vbat)
        v = New View(txtInputVoltage, pca_data_fields_enum_t.adc_vin)

        lblForceAdcMode.Text = Model.Caption(pca_data_fields_enum_t.force_adc_mode)
        v = New View(cmbAdcForceMode, pca_data_fields_enum_t.force_adc_mode)
        lblHiberDelay.Text = Model.Caption(pca_data_fields_enum_t.hibernate_delay)
        v = New View(cmbAdcHibDelay, pca_data_fields_enum_t.hibernate_delay)
        v = New View(chkAdcShutDownCfg, pca_data_fields_enum_t.adc_shutdown_cfg)
        lblScClkDitherSR.Text = Model.Caption(pca_data_fields_enum_t.sc_clk_dither_rate)
        v = New View(cmbScClkDitherSR, pca_data_fields_enum_t.sc_clk_dither_rate)
        lblScClkDitherLimit.Text = Model.Caption(pca_data_fields_enum_t.sc_clk_dither_limit)
        v = New View(cmbScClkDitherLimit, pca_data_fields_enum_t.sc_clk_dither_limit)
        v = New View(chkScClkDitherEn, pca_data_fields_enum_t.sc_clk_dither_en)

        'Rasied interrrupt View'
        v = New View(chkVOkInt, pca_data_fields_enum_t.v_ok_int)
        v = New View(chkNTCtempInt, pca_data_fields_enum_t.ntc_temp_int)
        v = New View(chkChgPhaseInt, pca_data_fields_enum_t.chg_phase_int)
        v = New View(chkCtrlLimitInt, pca_data_fields_enum_t.ctrl_limit_int)
        v = New View(chkTempRegInt, pca_data_fields_enum_t.temp_reg_int)
        v = New View(chkADCDoneInt, pca_data_fields_enum_t.adc_done_int)
        v = New View(chkTimerInt, pca_data_fields_enum_t.timer_int)

        'Interrupt View'
        v = New View(chkVOkMask, pca_data_fields_enum_t.v_ok_m)
        v = New View(chkNtcTempMask, pca_data_fields_enum_t.ntc_temp_m)
        v = New View(chkChgPhaseMask, pca_data_fields_enum_t.chg_phase_m)
        v = New View(chkCtrlLimitMask, pca_data_fields_enum_t.ctrl_limit_m)
        v = New View(chkTempRegMask, pca_data_fields_enum_t.temp_reg_m)
        v = New View(chkADCDoneMask, pca_data_fields_enum_t.adc_done_m)
        v = New View(chkTimerMask, pca_data_fields_enum_t.timer_m)
        v = New View(chkVOkSts, pca_data_fields_enum_t.v_ok_sts)
        v = New View(chkNtcTempSts, pca_data_fields_enum_t.ntc_temp_sts)
        v = New View(chkChgPhaseSts, pca_data_fields_enum_t.chg_phase_sts)
        v = New View(chkCtrlLimitSts, pca_data_fields_enum_t.ctrl_limit_sts)
        v = New View(chkTempRegSts, pca_data_fields_enum_t.temp_reg_sts)
        v = New View(chkADCDoneSts, pca_data_fields_enum_t.adc_done_sts)
        v = New View(chkTimerSts, pca_data_fields_enum_t.timer_sts)

        v = New View(txtVOKSts, pca_data_fields_enum_t.v_ok_sts)
        v = New View(txtNtcTempSts, pca_data_fields_enum_t.ntc_temp_sts)
        v = New View(txtChgPhaseSts, pca_data_fields_enum_t.chg_phase_sts)
        v = New View(txtCtrlLimitSts, pca_data_fields_enum_t.ctrl_limit_sts)
        v = New View(txtTempRegSts, pca_data_fields_enum_t.temp_reg_sts)
        v = New View(txtADCDoneSts, pca_data_fields_enum_t.adc_done_sts)
        v = New View(txtTimerSts, pca_data_fields_enum_t.timer_sts)


        'Status View'
        v = New View(chkIinLoopSts, pca_data_fields_enum_t.iin_loop_sts)
        v = New View(chkChgLoopSts, pca_data_fields_enum_t.chg_loop_sts)
        v = New View(chkVFLTLoopSts, pca_data_fields_enum_t.vflt_loop_sts)
        v = New View(chkCFlyShortSts, pca_data_fields_enum_t.cfly_short_sts)
        v = New View(chkVoutUvSts, pca_data_fields_enum_t.vout_uv_sts)
        v = New View(chkVbatOvSts, pca_data_fields_enum_t.vbat_ov_sts)
        v = New View(chkVinOvSts, pca_data_fields_enum_t.vin_ov_sts)
        v = New View(chkVinUvSts, pca_data_fields_enum_t.vin_uv_sts)
        v = New View(chkBatteryMissSts, pca_data_fields_enum_t.batt_miss_sts)
        v = New View(chkOcpFastSts, pca_data_fields_enum_t.ocp_fast_sts)
        v = New View(chkOcpAvgSts, pca_data_fields_enum_t.ocp_avg_sts)
        v = New View(chkActiveStateSts, pca_data_fields_enum_t.active_state_sts)
        v = New View(chkShutDownStateSts, pca_data_fields_enum_t.shutdown_state_sts)
        v = New View(chkStandbyStateSts, pca_data_fields_enum_t.standby_state_sts)
        v = New View(chkChargeTmrSts, pca_data_fields_enum_t.charge_timer_sts)
        v = New View(chkWatchdogTmrSts, pca_data_fields_enum_t.watchdog_timer_sts)
        v = New View(txtIinStatus, pca_data_fields_enum_t.iin_sts)
        v = New View(txtIchgStatus, pca_data_fields_enum_t.ichg_sts)

        v = New View(txtIinLoopSts, pca_data_fields_enum_t.iin_loop_sts)
        v = New View(txtChgLoopSts, pca_data_fields_enum_t.chg_loop_sts)
        v = New View(txtVFLTLoopSts, pca_data_fields_enum_t.vflt_loop_sts)
        v = New View(txtCFlyShortSts, pca_data_fields_enum_t.cfly_short_sts)
        v = New View(txtVoutUvSts, pca_data_fields_enum_t.vout_uv_sts)
        v = New View(txtVbatOvSts, pca_data_fields_enum_t.vbat_ov_sts)
        v = New View(txtVinOvSts, pca_data_fields_enum_t.vin_ov_sts)
        v = New View(txtVinUvSts, pca_data_fields_enum_t.vin_uv_sts)
        v = New View(txtBatteryMissSts, pca_data_fields_enum_t.batt_miss_sts)
        v = New View(txtOcpFastSts, pca_data_fields_enum_t.ocp_fast_sts)
        v = New View(txtOcpAvgSts, pca_data_fields_enum_t.ocp_avg_sts)
        v = New View(txtActiveStateSts, pca_data_fields_enum_t.active_state_sts)
        v = New View(txtShutDownStateSts, pca_data_fields_enum_t.shutdown_state_sts)
        v = New View(txtStandbyStateSts, pca_data_fields_enum_t.standby_state_sts)
        v = New View(txtChargeTmrSts, pca_data_fields_enum_t.charge_timer_sts)
        v = New View(txtWatchdogTmrSts, pca_data_fields_enum_t.watchdog_timer_sts)

        'Protection View'
        lblUVDelta.Text = Model.Caption(pca_data_fields_enum_t.uv_delta)
        v = New View(cmbUVDelta, pca_data_fields_enum_t.uv_delta)
        lblOVDelta.Text = Model.Caption(pca_data_fields_enum_t.ov_delta)
        v = New View(cmbOVDelta, pca_data_fields_enum_t.ov_delta)
        lblWatchdogCfg.Text = Model.Caption(pca_data_fields_enum_t.watchdog_cfg)
        v = New View(cmbWatchdogCfg, pca_data_fields_enum_t.watchdog_cfg)
        lblChargerTimer.Text = Model.Caption(pca_data_fields_enum_t.chg_timer_cfg)
        v = New View(cmbChargerTimer, pca_data_fields_enum_t.chg_timer_cfg)

        lblVFloat.Text = Model.Caption(pca_data_fields_enum_t.v_float)
        v = New View(trbVFloat, pca_data_fields_enum_t.v_float)
        v = New View(lblVFloatVal, pca_data_fields_enum_t.v_float)

        v = New View(chkIinForceIncrementEn, pca_data_fields_enum_t.iin_force_count)
        v = New View(chkMissBatteryDetEn, pca_data_fields_enum_t.bat_miss_det_en)
        v = New View(chkWatchDogEn, pca_data_fields_enum_t.watchdog_en)
        v = New View(chkChargerTimerEn, pca_data_fields_enum_t.chg_timer_en)
        v = New View(chkForceUnplugStandby, pca_data_fields_enum_t.unplug_force_standby)

        'Thermal View'
        lblTempReg.Text = Model.Caption(pca_data_fields_enum_t.temp_reg)
        v = New View(cmbTempReg, pca_data_fields_enum_t.temp_reg)
        lblTempDelta.Text = Model.Caption(pca_data_fields_enum_t.temp_delta)
        v = New View(cmbTempDelta, pca_data_fields_enum_t.temp_delta)
        v = New View(chkTempRegEn, pca_data_fields_enum_t.temp_reg_en)
        v = New View(chkNtcProtectionEn, pca_data_fields_enum_t.ntc_protection_en)
        v = New View(chkTempMaxEn, pca_data_fields_enum_t.temp_max_en)

        lblNTCThreshold.Text = Model.Caption(pca_data_fields_enum_t.ntc_threshold)
        v = New View(trbNTCThreshold, pca_data_fields_enum_t.ntc_threshold)
        v = New View(lblNTCThresholdVal, pca_data_fields_enum_t.ntc_threshold)

    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'BeginInvoke(New MethodInvoker(AddressOf TestConnection))
        'ScanInterfaces()
        m_scheduleScan = TimeTicks() + 100
        tmrWork.Enabled = True
        AttachModel()
        AddInterruptChkHandlers()
        BuildRegisterMap()
        SetView(ViewEnum.ve_Functional)
        ' SetAutoRefresh(My.Settings.Interval)
        SetAutoRefresh(0)

        '2018.10.29. Clark Kim - Delete chopping mode selection
        'chkADCModeSelect.Text = "ADC in Chopping Mode"
        'chkADCModeSelect.Checked = True

        '2018.11.28. Clark Kim
        'Delete Battery Missing Detection CheckBox
        chkMissBatteryDetEn.Enabled = False
        chkMissBatteryDetEn.Visible = False

        '2018.11.28. Clark Kim
        'Delete Charging Current Set, Label and TrackBar
        lblIchgCfg.Visible = False
        lblIchgCfgVal.Visible = False
        trbIchgCfg.Visible = False

#If DEBUG Then
        gbxDebug.Visible = True
            'Write default value'
            cmbADCTestRepeats.SelectedIndex = 0
            cmbADCAccDelay.SelectedIndex = 0
            txtXslFileName.Text = "C:\Users\nxp29394\Desktop\Result_" + DateTime.Now.Date.ToString("MMddyy ") + DateTime.Now.ToString("HH_mm") + ".xlsx"
#Else
        TabControl2.TabPages.Remove(tbpMisc)
        TabControl2.TabPages.Remove(tbpADCTest)
#End If


    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_DEVICECHANGE Then
            If m.WParam.ToInt32 = DBT_DEVICEARRIVAL Or _
                m.WParam.ToInt32 = DBT_DEVICEREMOVECOMPLETE Or _
                 m.WParam.ToInt32 = 7 Then
                ' Scan for hardware interfaces after cDelayAfterUSBEnum_ms milisecond
                m_scheduleScan = TimeTicks() + cDelayAfterUSBEnum_ms
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub AddInterruptChkHandlers()
        For Each chk As CheckBox In grpRaised.Controls.OfType(Of CheckBox)()
            AddHandler chk.CheckedChanged, AddressOf interrupt_checkedChanged
        Next
    End Sub

    Private Sub interrupt_checkedChanged(sender As System.Object, e As System.EventArgs)
        Dim chk As CheckBox = TryCast(sender, CheckBox)
        If chk IsNot Nothing Then
            If chk.Checked Then
                chk.BackColor = Color.Red
                chk.ForeColor = Color.White
                'chk.Tag = TimeTicks() + 1000
            Else
                chk.BackColor = SystemColors.Control
                chk.ForeColor = SystemColors.ControlText
            End If
        End If
    End Sub

    Private Sub ReadStatusRegisters()
        'Beep()
        'Static cRegsToRead As Byte() = {3, 4, 19, 20, 21, 22, 23, 24, 25, 26, 27}
        'ScheduleStatusRead()
        'For idx As Integer = 0 To cRegsToRead.Count - 1
        '    If Model.ReadRegister(cRegsToRead(idx)) <> Model.pca_result_t.pca_ok Then
        '        I2C_connected = False
        '        Exit For
        '    End If
        'Next
        ScheduleStatusRead()

        'this is modified to read MP15 status register 0x02-0x07 6 Status Registers'
        If Model.ReadRegisters(1, 7) = Model.pca_result_t.pca_ok Then
            'this is modified to read MP15 ADC registers 0x08-0x10 9 Status Registers'
            If Model.ReadADCRegisters(8, 9) = Model.pca_result_t.pca_ok Then
                Exit Sub
            End If
        End If
        I2C_connected = False
    End Sub

    Private Sub tmrWork_Tick(sender As System.Object, e As System.EventArgs) Handles tmrWork.Tick
        If m_scheduleScan <> 0 AndAlso TimeTicks() - m_scheduleScan > 0 Then
            m_scheduleScan = 0
            BeginInvoke(New MethodInvoker(AddressOf ScanInterfaces))
        End If
        If m_scheduleConnect <> 0 AndAlso TimeTicks() - m_scheduleConnect > 0 Then
            m_scheduleConnect = 0
            BeginInvoke(New MethodInvoker(AddressOf I2C_Connect))
        End If
        If m_scheduleStatusRead <> 0 AndAlso TimeTicks() - m_scheduleStatusRead > 0 Then
            m_scheduleStatusRead = 0
            BeginInvoke(New MethodInvoker(AddressOf ReadStatusRegisters))
        End If
    End Sub

    Private Sub ScheduleStatusRead()
        If m_statusReadInterval > 0 Then
            m_scheduleStatusRead = TimeTicks() + m_statusReadInterval
        Else
            m_scheduleStatusRead = 0
        End If
    End Sub

    Private Sub tsmInterval0_Click(sender As System.Object, e As System.EventArgs) Handles tsmInterval0.Click
        SetAutoRefresh(0)
    End Sub

    Private Sub tsmInterval1_Click(sender As System.Object, e As System.EventArgs) Handles tsmInterval1.Click
        SetAutoRefresh(1)
    End Sub

    Private Sub tsmInterval2_Click(sender As System.Object, e As System.EventArgs) Handles tsmInterval2.Click
        SetAutoRefresh(2)
    End Sub

    Private Sub tsmInterval4_Click(sender As System.Object, e As System.EventArgs) Handles tsmInterval4.Click
        SetAutoRefresh(4)
    End Sub

    Private Sub SetAutoRefresh(interval As UInteger)
        tsmInterval0.Checked = False
        tsmInterval1.Checked = False
        tsmInterval2.Checked = False
        tsmInterval4.Checked = False
        Select Case interval
            Case 0
                tsmInterval0.Checked = True
                tscRefresh.SelectedIndex = 0
                m_statusReadInterval = 0
            Case 1
                tsmInterval1.Checked = True
                tscRefresh.SelectedIndex = 1
                m_statusReadInterval = 1000
            Case 2
                tsmInterval2.Checked = True
                tscRefresh.SelectedIndex = 2
                m_statusReadInterval = 500
            Case Else
                tsmInterval4.Checked = True
                tscRefresh.SelectedIndex = 3
                m_statusReadInterval = 250
        End Select
        My.Settings.Interval = CUInt(tscRefresh.SelectedIndex)
        My.Settings.Save()
        ScheduleStatusRead()
    End Sub

    Private Sub BuildRegisterMap()
        Const xOffset As Integer = 20
        Const yOffset As Integer = 10
        Dim row As Integer = 0, col As Integer = 0, offset As Integer = 0
        'yy edit for MP12, skip reg 0x11-0x1F (not exist)
        Dim offset2 As Integer = 32
        Dim txt As TextBox, lblRegName As Label
        Dim v As View
        For fld As pca_data_fields_enum_t = pca_data_fields_enum_t.reg_0 To pca_data_fields_enum_t.reg_2A
            lblRegName = New Label With {.Location = New Point(col * 197 + xOffset, 3 + yOffset + 24 * row), .Size = New Size(150, 20)}
            txt = New TextBox With {.Location = New Point(col * 197 + xOffset + 150, yOffset + 24 * row), .Size = New Size(40, 20)}
            v = New View(txt, fld)
            txt.Enabled = Not New mvc.DataField(fld).IsReadOnly
            If offset <= 16 Then
                lblRegName.Text = "0x" & Strings.Right("0" & Hex(offset), 2) & "  " & mvc.Model.Caption(fld)
            Else
                lblRegName.Text = "0x" & Strings.Right("0" & Hex(offset2), 2) & "  " & mvc.Model.Caption(fld)
            End If
            pnlRegisters.Controls.Add(lblRegName)
            pnlRegisters.Controls.Add(txt)
            If offset <= 16 Then
                offset += 1
            Else
                offset2 += 1
            End If
            row += 1
            If yOffset + 24 * row > pnlRegisters.Height - 24 Then
                row = 0
                col += 1
            End If
        Next

    End Sub

    Private Sub SetView(v As ViewEnum)
        pnlFunctions.Visible = v = ViewEnum.ve_Functional
        pnlRegisters.Visible = v <> ViewEnum.ve_Functional
        tsbFunctions.Checked = v = ViewEnum.ve_Functional
        tsmFunctions.Checked = v = ViewEnum.ve_Functional
        tsbRegisters.Checked = v <> ViewEnum.ve_Functional
        tsmRegisters.Checked = v <> ViewEnum.ve_Functional
    End Sub

    Private Sub tsbRegisters_Click(sender As Object, e As EventArgs) Handles tsbRegisters.Click
        SetView(ViewEnum.ve_RegisterMap)
    End Sub

    Private Sub tsbFunctions_Click(sender As Object, e As EventArgs) Handles tsbFunctions.Click
        SetView(ViewEnum.ve_Functional)
    End Sub

    Private Sub tsmFunctions_Click(sender As Object, e As EventArgs) Handles tsmFunctions.Click
        SetView(ViewEnum.ve_Functional)
    End Sub

    Private Sub tsmRegisters_Click(sender As Object, e As EventArgs) Handles tsmRegisters.Click
        SetView(ViewEnum.ve_RegisterMap)
    End Sub

    Private Sub tscRefresh_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tscRefresh.SelectedIndexChanged
        If tscRefresh.SelectedIndex >= 0 Then SetAutoRefresh(CUInt(tscRefresh.SelectedIndex))
    End Sub

    Private Sub WriteAll()
        Model.WriteAll()
        UpdateModel()
    End Sub

    Private Sub ResetDevice()
        UpdateModel()
    End Sub

    Private Sub ReadAll()
        UpdateModel()
    End Sub

    Private Sub btnCurrentADCRead_Click(sender As Object, e As EventArgs) Handles btnCurrentADCRead.Click
        mvc.Model.ReadRegisters(6, 2)       'Read IIN Status and ICHG Status'
        mvc.Model.ReadADCRegisters(8, 9)    'Read ADC 1-9'
    End Sub

    Private Sub btnRaisedIntRead_Click(sender As Object, e As EventArgs) Handles btnRaisedIntRead.Click
        ReadAll()
    End Sub

    Private Sub btnCtlSet_Click(sender As Object, e As EventArgs) Handles btnCtlSet.Click
        Dim RegVal As Integer
        Dim OcpWA As Boolean

        'Check STANDBY_EN bit CheckBox
        If chkStandbyEn.Checked = False And chkCfgEn.Checked = True Then
            'Read START_CTRL register to check the current STANDBY_EN and EN_CFG status
            RegVal = mvc.Model.DbgReadRegister(&H22)
            RegVal = RegVal And &H60
            'Check the current STANDBY_EN and EN_CFG status
            If RegVal <> &H40 Then
                'STANDBY_EN bit is 1 or EN_CFG bit is 0
                'Need OCP workaround
                'Set chopper disable
                '1. Open test register : [0x30] = 0x5B
                mvc.Model.DbgWriteRegister(&H30, &H5B)
                'Write Enable Chop bit to 0 : [0x3D] = [0x3D] & 0xF7
                RegVal = mvc.Model.DbgReadRegister(&H3D)
                RegVal = RegVal And &HF7
                mvc.Model.DbgWriteRegister(&H3D, RegVal)
                OcpWA = True
            End If
        End If

        WriteAll()

        'Check OCP Workaround
        If OcpWA = True Then
            'Wait 50ms
            Threading.Thread.Sleep(50)
            'Chopper Enable : [0x3D] = ([0x3D] & 0xF7) | 0x08
            RegVal = mvc.Model.DbgReadRegister(&H3D)
            RegVal = RegVal Or &H8
            mvc.Model.DbgWriteRegister(&H3D, RegVal)
            'Close test register : [0x30] = 0x00
            mvc.Model.DbgWriteRegister(&H30, &H0)
            OcpWA = False
        End If
    End Sub

    Private Sub btnAdcEnSet_Click(sender As Object, e As EventArgs) Handles btnAdcEnSet.Click
        WriteAll()
    End Sub

    Private Sub btnIntSet_Click(sender As Object, e As EventArgs) Handles btnIntSet.Click
        WriteAll()
    End Sub

    Private Sub btnProtectSet_Click(sender As Object, e As EventArgs) Handles btnProtectSet.Click
        WriteAll()
    End Sub

    Private Sub btnThermalSet_Click(sender As Object, e As EventArgs) Handles btnThermalSet.Click
        WriteAll()
    End Sub

    Private Sub btnThermalRead_Click(sender As Object, e As EventArgs) Handles btnThermalRead.Click
        ReadAll()
    End Sub

    Private Sub btnProtectRead_Click(sender As Object, e As EventArgs) Handles btnProtectRead.Click
        ReadAll()
    End Sub

    Private Sub btnStsRead_Click(sender As Object, e As EventArgs) Handles btnStsRead.Click
        ReadAll()
    End Sub

    Private Sub btnIntRead_Click(sender As Object, e As EventArgs) Handles btnIntRead.Click
        ReadAll()
    End Sub

    Private Sub btnAdcEnRead_Click(sender As Object, e As EventArgs) Handles btnAdcEnRead.Click
        ReadAll()
    End Sub

    Private Sub btnCtlRead_Click(sender As Object, e As EventArgs) Handles btnCtlRead.Click
        ReadAll()
    End Sub

    Private Sub tsbWrite_Click(sender As Object, e As EventArgs) Handles tsbWrite.Click
        WriteAll()
    End Sub

    Private Sub tsbRead_Click(sender As System.Object, e As System.EventArgs) Handles tsbRead.Click
        ReadAll()
    End Sub

    Private Sub btnSpreadSet_Click(sender As Object, e As EventArgs) Handles btnSpreadSet.Click
        WriteAll()
    End Sub

    Private Sub btnSpreadRead_Click(sender As Object, e As EventArgs) Handles btnSpreadRead.Click
        ReadAll()
    End Sub

    Private Sub btnReadADC_Click(sender As Object, e As EventArgs) Handles btnReadADC.Click
        mvc.Model.ReadADCRegisters(8, 9)    'Read ADC 1-9'
    End Sub

    Private Sub tsmAbout_Click(sender As Object, e As EventArgs) Handles tsmAbout.Click
        frmAbout.Show(Me)
    End Sub

    Private Sub tsbReset_Click(sender As Object, e As EventArgs) Handles tsbReset.Click
        ResetDevice()
    End Sub

#If DEBUG Then
    Public Function IsHex(ByVal str As String) As Boolean
        Try
            Dim num As Long = CLng("&H" & str)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub DdgBtnSetRegister(ByVal RegAddrTxt As TextBox, ByVal RegValTxt As TextBox, ByVal RegReadbackTxt As TextBox)
        Dim RegAddr As Integer
        Dim RegVal As Integer
        Dim RegValReadBack As Integer

        If IsHex(RegAddrTxt.Text) And IsHex(RegValTxt.Text) Then
            RegAddr = Convert.ToInt32(RegAddrTxt.Text, 16)
            RegVal = Convert.ToInt32(RegValTxt.Text, 16)
            mvc.Model.DbgWriteRegister(RegAddr, RegVal)
            RegValReadBack = mvc.Model.DbgReadRegister(RegAddr)
            RegReadbackTxt.Text = "0x" + Convert.ToString(Hex(RegValReadBack))
            UpdateModel()
        End If
    End Sub

    Private Sub DgbBtnReadRegister(ByVal RegAddrTxt As TextBox, ByVal RegReadbackTxt As TextBox)
        Dim RegValReadBack As Integer
        Dim RegAddr As Integer

        If IsHex(RegAddrTxt.Text) Then
            RegAddr = Convert.ToInt32(RegAddrTxt.Text, 16)
            RegValReadBack = mvc.Model.DbgReadRegister(RegAddr)
            RegReadbackTxt.Text = "0x" + Convert.ToString(Hex(RegValReadBack))
        End If
    End Sub

    Private Sub btnDbgRegSet1_Click(sender As Object, e As EventArgs) Handles btnDbgRegSet1.Click
        DdgBtnSetRegister(txtDbgRegAddr1, txtDbgRegVal1, txtDbgRegReadBack1)
    End Sub

    Private Sub btnDbgRegRead1_Click(sender As Object, e As EventArgs) Handles btnDbgRegRead1.Click
        DgbBtnReadRegister(txtDbgRegAddr1, txtDbgRegReadBack1)
    End Sub

    Private Sub btnDbgRegSet2_Click(sender As Object, e As EventArgs) Handles btnDbgRegSet2.Click
        DdgBtnSetRegister(txtDbgRegAddr2, txtDbgRegVal2, txtDbgRegReadBack2)
    End Sub

    Private Sub btnDbgRegRead2_Click(sender As Object, e As EventArgs) Handles btnDbgRegRead2.Click
        DgbBtnReadRegister(txtDbgRegAddr2, txtDbgRegReadBack2)
    End Sub

    Private Sub btnDbgRegSet3_Click(sender As Object, e As EventArgs) Handles btnDbgRegSet3.Click
        DdgBtnSetRegister(txtDbgRegAddr3, txtDbgRegVal3, txtDbgRegReadBack3)
    End Sub

    Private Sub btnDbgRegRead3_Click(sender As Object, e As EventArgs) Handles btnDbgRegRead3.Click
        DgbBtnReadRegister(txtDbgRegAddr3, txtDbgRegReadBack3)
    End Sub

    Private Sub btnDbgRegSet4_Click(sender As Object, e As EventArgs) Handles btnDbgRegSet4.Click
        DdgBtnSetRegister(txtDbgRegAddr4, txtDbgRegVal4, txtDbgRegReadBack4)
    End Sub

    Private Sub btnDbgRegRead4_Click(sender As Object, e As EventArgs) Handles btnDbgRegRead4.Click
        DgbBtnReadRegister(txtDbgRegAddr4, txtDbgRegReadBack4)
    End Sub

    Private Sub btnDbgRegSet5_Click(sender As Object, e As EventArgs) Handles btnDbgRegSet5.Click
        DdgBtnSetRegister(txtDbgRegAddr5, txtDbgRegVal5, txtDbgRegReadBack5)
    End Sub

    Private Sub btnDbgRegRead5_Click(sender As Object, e As EventArgs) Handles btnDbgRegRead5.Click
        DgbBtnReadRegister(txtDbgRegAddr5, txtDbgRegReadBack5)
    End Sub

    Private Sub btnDbgRegSet6_Click(sender As Object, e As EventArgs) Handles btnDbgRegSet6.Click
        DdgBtnSetRegister(txtDbgRegAddr6, txtDbgRegVal6, txtDbgRegReadBack6)
    End Sub

    Private Sub btnDbgRegRead6_Click(sender As Object, e As EventArgs) Handles btnDbgRegRead6.Click
        DgbBtnReadRegister(txtDbgRegAddr6, txtDbgRegReadBack6)
    End Sub

    Private numRepeat As Integer
    Private ADCDataMatrix(9, 500) As Integer
    Private ADCValMatrix(7, 500) As Integer
    Private ADCReadDelayCnt As Integer = 1

    Private Sub btnSaveADC_Click(sender As Object, e As EventArgs) Handles btnSaveADC.Click
        Dim xls As Microsoft.Office.Interop.Excel.Application
        Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xls = New Microsoft.Office.Interop.Excel.Application
        xlsWorkBook = xls.Workbooks.Add(misValue)
        xlsWorkSheet = CType(xlsWorkBook.Sheets("sheet1"), Microsoft.Office.Interop.Excel.Worksheet)

        'create the xsl header'
        For xlsCol As Integer = 1 To 9
            xlsWorkSheet.Cells(1, xlsCol) = "ADC" + CStr(xlsCol)
        Next

        For xlsRow As Integer = 1 To numRepeat
            For xlsCol As Integer = 1 To 9
                xlsWorkSheet.Cells(xlsRow + 1, xlsCol) = Hex(ADCDataMatrix(xlsCol, xlsRow))
            Next
        Next

        'summary'
        xlsWorkSheet.Cells(1, 11) = "ADC Channel"
        xlsWorkSheet.Cells(1, 12) = "Max Reading"
        xlsWorkSheet.Cells(1, 13) = "Min Reading"
        xlsWorkSheet.Cells(1, 14) = "Delta Reading"
        xlsWorkSheet.Cells(1, 15) = "Lsb Difference"

        xlsWorkSheet.Cells(1, 11) = "ADC Channel"
        xlsWorkSheet.Cells(2, 11) = "Input Current"
        xlsWorkSheet.Cells(3, 11) = "Output Current"
        xlsWorkSheet.Cells(4, 11) = "Input Voltage"
        xlsWorkSheet.Cells(5, 11) = "Output Voltage"
        xlsWorkSheet.Cells(6, 11) = "Battery Voltage"
        xlsWorkSheet.Cells(7, 11) = "Die Tempearture"
        xlsWorkSheet.Cells(8, 11) = "NTC voltage"

        xlsWorkSheet.Cells(2, 12) = txtADCAccIINMax.Text
        xlsWorkSheet.Cells(3, 12) = txtADCAccIoutMax.Text
        xlsWorkSheet.Cells(4, 12) = txtADCAccVinMax.Text
        xlsWorkSheet.Cells(5, 12) = txtADCAccVoutMax.Text
        xlsWorkSheet.Cells(6, 12) = txtADCAccVbatMax.Text
        xlsWorkSheet.Cells(7, 12) = txtADCAccDieTempMax.Text
        xlsWorkSheet.Cells(8, 12) = txtADCAccNtcMax.Text
        xlsWorkSheet.Cells(2, 13) = txtADCAccIINMin.Text
        xlsWorkSheet.Cells(3, 13) = txtADCAccIoutMin.Text
        xlsWorkSheet.Cells(4, 13) = txtADCAccVinMin.Text
        xlsWorkSheet.Cells(5, 13) = txtADCAccVoutMin.Text
        xlsWorkSheet.Cells(6, 13) = txtADCAccVbatMin.Text
        xlsWorkSheet.Cells(7, 13) = txtADCAccDieTempMin.Text
        xlsWorkSheet.Cells(8, 13) = txtADCAccNTCMin.Text
        xlsWorkSheet.Cells(2, 14) = txtADCAccIINDelta.Text
        xlsWorkSheet.Cells(3, 14) = txtADCAccIoutDelta.Text
        xlsWorkSheet.Cells(4, 14) = txtADCAccVinDelta.Text
        xlsWorkSheet.Cells(5, 14) = txtADCAccVoutDelta.Text
        xlsWorkSheet.Cells(6, 14) = txtADCAccVbatDelta.Text
        xlsWorkSheet.Cells(7, 14) = txtADCAccDieTempDelta.Text
        xlsWorkSheet.Cells(8, 14) = txtADCAccNTCDelta.Text
        xlsWorkSheet.Cells(2, 15) = txtADCAccInputCurrent.Text
        xlsWorkSheet.Cells(3, 15) = txtADCAccOutputCurrent.Text
        xlsWorkSheet.Cells(4, 15) = txtADCAccInputVoltage.Text
        xlsWorkSheet.Cells(5, 15) = txtADCAccOutputVoltage.Text
        xlsWorkSheet.Cells(6, 15) = txtADCAccBattVoltage.Text
        xlsWorkSheet.Cells(7, 15) = txtADCAccDieTemp.Text
        xlsWorkSheet.Cells(8, 15) = txtADCAccNTCVoltage.Text

        '     If String.IsNullOrEmpty(txtXslFileName.Text) Then
        txtXslFileName.Text = "C:\Users\nxp29394\Desktop\Result_" + DateTime.Now.Date.ToString("MMddyy ") + DateTime.Now.ToString("HH_mmss") + ".xlsx"
        xlsWorkBook.SaveAs(txtXslFileName.Text)
        'Else
        'Try
        ' xlsWorkBook.SaveAs(txtXslFileName.Text)
        'Catch ex As Exception
        'xlsWorkBook.Close()
        'xls.Quit()
        'End Try
        'End If
        xlsWorkBook.Close()
        xls.Quit()

    End Sub

    Private Sub btnADCTestStart_Click(sender As Object, e As EventArgs) Handles btnADCTestStart.Click

        numRepeat = CInt(cmbADCTestRepeats.SelectedItem)
        Dim RegValReadBack(7) As Integer
        Dim ADCRegVal(9) As Integer

        ADC_ReadDelay()

        If tmrADCTest.Enabled = True Then
            'processe the subrountine in timer
            Return
        End If
        
        For fld As Integer = 1 To numRepeat
            mvc.Model.ReadADCRegisters(8, 9)
            For adcValCh As Integer = 1 To 7
                RegValReadBack(adcValCh) = mvc.Model.GetRegisterValue(7 + adcValCh)
                ADCValMatrix(adcValCh, fld) = RegValReadBack(adcValCh)
            Next
            'Retrieve ADC RegVal from low level registers'
            ADCRegVal(1) = RegValReadBack(1) And &HFF
            ADCRegVal(2) = RegValReadBack(2) And &HFF
            ADCRegVal(3) = RegValReadBack(3) And &HFF
            ADCRegVal(4) = RegValReadBack(4) And &HFF
            ADCRegVal(5) = (RegValReadBack(4) And &HFF00) >> 8
            ADCRegVal(6) = RegValReadBack(5) And &HFF
            ADCRegVal(7) = RegValReadBack(6) And &HFF
            ADCRegVal(8) = RegValReadBack(7) And &HFF
            ADCRegVal(9) = (RegValReadBack(7) And &HFF00) >> 8
            For adcCh As Integer = 1 To 9
                ADCDataMatrix(adcCh, fld) = ADCRegVal(adcCh)
            Next
            If chkADCEnDis.Checked = True Then
                'Disable/Enable ADC reading everytime before read the ADC'
                mvc.Model.DbgWriteRegister(&H24, &H0)
                mvc.Model.DbgWriteRegister(&H24, &HFF)
            End If
        Next
        ADC_Accuracy_Calcuation()

    End Sub

    Private Sub ADC_ReadDelay()
        If cmbADCAccDelay.SelectedIndex = 0 Then
            tmrADCTest.Enabled = False
            tmrADCTest.Stop()
        ElseIf cmbADCAccDelay.SelectedIndex = 1 Then
            tmrADCTest.Interval = 100
            tmrADCTest.Enabled = True
            tmrADCTest.Start()
        ElseIf cmbADCAccDelay.SelectedIndex = 2 Then
            tmrADCTest.Interval = 200
            tmrADCTest.Enabled = True
            tmrADCTest.Start()
        End If
        btnADCTestStart.Text = "Test"
    End Sub

    Private Sub tmrADCTest_Tick(sender As Object, e As EventArgs) Handles tmrADCTest.Tick
        numRepeat = CInt(cmbADCTestRepeats.SelectedItem)
        Dim RegValReadBack(7) As Integer
        Dim ADCRegVal(9) As Integer

        If ADCReadDelayCnt <= numRepeat Then
            If chkADCEnDis.Checked = True Then
                'Disable ADC reading everytime before read the ADC'
                mvc.Model.DbgWriteRegister(&H24, &H0)
                ' mvc.Model.DbgWriteRegister(&H24, &HFF)
            End If
            mvc.Model.ReadADCRegisters(8, 9)
            If chkADCEnDis.Checked = True Then
                'Enable ADC reading everytime before read the ADC'
                ' mvc.Model.DbgWriteRegister(&H24, &H0)
                mvc.Model.DbgWriteRegister(&H24, &HFF)
            End If
            For adcValCh As Integer = 1 To 7
                RegValReadBack(adcValCh) = mvc.Model.GetRegisterValue(7 + adcValCh)
                ADCValMatrix(adcValCh, ADCReadDelayCnt) = RegValReadBack(adcValCh)
            Next
            'Retrieve ADC RegVal from low level registers'
            ADCRegVal(1) = RegValReadBack(1) And &HFF
            ADCRegVal(2) = RegValReadBack(2) And &HFF
            ADCRegVal(3) = RegValReadBack(3) And &HFF
            ADCRegVal(4) = RegValReadBack(4) And &HFF
            ADCRegVal(5) = (RegValReadBack(4) And &HFF00) >> 8
            ADCRegVal(6) = RegValReadBack(5) And &HFF
            ADCRegVal(7) = RegValReadBack(6) And &HFF
            ADCRegVal(8) = RegValReadBack(7) And &HFF
            ADCRegVal(9) = (RegValReadBack(7) And &HFF00) >> 8
            For adcCh As Integer = 1 To 9
                ADCDataMatrix(adcCh, ADCReadDelayCnt) = ADCRegVal(adcCh)
            Next
            ADCReadDelayCnt = ADCReadDelayCnt + 1
            btnADCTestStart.Text = "Wait..."
        Else
            ADC_Accuracy_Calcuation()
            tmrADCTest.Stop()
            ADCReadDelayCnt = 1
            btnADCTestStart.Text = "Done"
        End If
    End Sub

    Private Sub ADC_Accuracy_Calcuation()
        'T.B.D'  'Have issue here, to be continued'
        Dim IINMax As Integer = 0
        Dim IINMin As Integer = ADCValMatrix(1, 1) And &H3FF
        Dim IoutMax As Integer = 0
        Dim IoutMin As Integer = (ADCValMatrix(2, 1) And &HFFC) >> 2
        Dim VinMax As Integer = 0
        Dim VinMin As Integer = (ADCValMatrix(3, 1) And &H3FF0) >> 4
        Dim VoutMax As Integer = 0
        Dim VoutMin As Integer = (ADCValMatrix(4, 1) And &HFFC0) >> 6
        Dim VbatMax As Integer = 0
        Dim VbatMin As Integer = (ADCValMatrix(5, 1) And &H3FF)
        Dim DieTempMax As Integer = 0
        Dim DieTempMin As Integer = (ADCValMatrix(6, 1) And &HFFC) >> 2
        Dim NTCMax As Integer = 0
        Dim NTCMin As Integer = (ADCValMatrix(7, 1) And &H3FF0) >> 4

        'Find the max and min value for each reading
        For fld As Integer = 1 To numRepeat
            'IIN
            ADCValMatrix(1, fld) = ADCValMatrix(1, fld) And &H3FF
            IINMax = Math.Max(ADCValMatrix(1, fld), IINMax)
            IINMin = Math.Min(IINMin, ADCValMatrix(1, fld))
            'Iout
            ADCValMatrix(2, fld) = (ADCValMatrix(2, fld) And &HFFC) >> 2
            IoutMax = Math.Max(ADCValMatrix(2, fld), IoutMax)
            IoutMin = Math.Min(IoutMin, ADCValMatrix(2, fld))
            'Vin
            ADCValMatrix(3, fld) = (ADCValMatrix(3, fld) And &H3FF0) >> 4
            VinMax = Math.Max(ADCValMatrix(3, fld), VinMax)
            VinMin = Math.Min(VinMin, ADCValMatrix(3, fld))
            'Vout
            ADCValMatrix(4, fld) = (ADCValMatrix(4, fld) And &HFFC0) >> 6
            VoutMax = Math.Max(ADCValMatrix(4, fld), VoutMax)
            VoutMin = Math.Min(VoutMin, ADCValMatrix(4, fld))
            'Vbat
            ADCValMatrix(5, fld) = (ADCValMatrix(5, fld) And &H3FF)
            VbatMax = Math.Max(ADCValMatrix(5, fld), VbatMax)
            VbatMin = Math.Min(VbatMin, ADCValMatrix(5, fld))
            'DieTemp
            ADCValMatrix(6, fld) = (ADCValMatrix(6, fld) And &HFFC) >> 2
            DieTempMax = Math.Max(ADCValMatrix(6, fld), DieTempMax)
            DieTempMin = Math.Min(DieTempMin, ADCValMatrix(6, fld))
            'Ntc
            ADCValMatrix(7, fld) = (ADCValMatrix(7, fld) And &H3FF0) >> 4
            NTCMax = Math.Max(ADCValMatrix(7, fld), NTCMax)
            NTCMin = Math.Min(NTCMin, ADCValMatrix(7, fld))
        Next

        'IIN Max/Min/Delta'
        txtADCAccIINMax.Text = CStr(IINMax * 4.89)
        txtADCAccIINMin.Text = CStr(IINMin * 4.89)
        txtADCAccIINDelta.Text = CStr((IINMax - IINMin) * 4.89)
        txtADCAccInputCurrent.Text = CStr(IINMax - IINMin)
        'Iout'
        txtADCAccIoutMax.Text = CStr(IoutMax * 9.78)
        txtADCAccIoutMin.Text = CStr(IoutMin * 9.78)
        txtADCAccIoutDelta.Text = CStr((IoutMax - IoutMin) * 9.78)
        txtADCAccOutputCurrent.Text = CStr(IoutMax - IoutMin)
        'Vin'
        txtADCAccVinMax.Text = CStr(VinMax * 0.016)
        txtADCAccVinMin.Text = CStr(VinMin * 0.016)
        txtADCAccVinDelta.Text = CStr((VinMax - VinMin) * 0.016)
        txtADCAccInputVoltage.Text = CStr(VinMax - VinMin)
        'Vout'
        txtADCAccVoutMax.Text = CStr(VoutMax * 0.005)
        txtADCAccVoutMin.Text = CStr(VoutMin * 0.005)
        txtADCAccVoutDelta.Text = CStr((VoutMax - VoutMin) * 0.005)
        txtADCAccOutputVoltage.Text = CStr(VoutMax - VoutMin)
        'VBat'
        txtADCAccVbatMax.Text = CStr(VbatMax * 0.005)
        txtADCAccVbatMin.Text = CStr(VbatMin * 0.005)
        txtADCAccVbatDelta.Text = CStr((VbatMax - VbatMin) * 0.005)
        txtADCAccBattVoltage.Text = CStr(VbatMax - VbatMin)
        'DietTemp'
        txtADCAccDieTempMax.Text = CStr((922 - DieTempMin) * 0.52)
        txtADCAccDieTempMin.Text = CStr((922 - DieTempMax) * 0.52)
        txtADCAccDieTempDelta.Text = CStr((DieTempMax - DieTempMin) * 0.52)
        txtADCAccDieTemp.Text = CStr(DieTempMax - DieTempMin)
        'NTC'
        txtADCAccNtcMax.Text = CStr(NTCMax * 2.346)
        txtADCAccNTCMin.Text = CStr(NTCMin * 2.346)
        txtADCAccNTCDelta.Text = CStr((NTCMax - NTCMin) * 2.346)
        txtADCAccNTCVoltage.Text = CStr(NTCMax - NTCMin)

    End Sub

#End If

    Private Sub chkADCModeSelect_CheckedChanged(sender As Object, e As EventArgs) Handles chkADCModeSelect.CheckedChanged
        If chkADCModeSelect.Checked Then
            chkADCModeSelect.Text = "ADC in Chopping Mode"
            'Enable chopping mode'
            mvc.Model.DbgWriteRegister(&H30, &H5B)
            mvc.Model.DbgWriteRegister(&H3E, &HA)
        Else
            chkADCModeSelect.Text = "ADC in Offset Mode"
            'Enable offset mode'
            mvc.Model.DbgWriteRegister(&H30, &H5B)
            mvc.Model.DbgWriteRegister(&H3E, &H2)
        End If

    End Sub


End Class