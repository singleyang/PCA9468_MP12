<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain_mp12
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain_mp12))
        Me.tbpInt = New System.Windows.Forms.TabPage()
        Me.btnIntRead = New System.Windows.Forms.Button()
        Me.btnIntSet = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkVOKSts = New System.Windows.Forms.CheckBox()
        Me.chkNtcTempSts = New System.Windows.Forms.CheckBox()
        Me.chkChgPhaseSts = New System.Windows.Forms.CheckBox()
        Me.chkTimerSts = New System.Windows.Forms.CheckBox()
        Me.chkCtrlLimitSts = New System.Windows.Forms.CheckBox()
        Me.chkADCDoneSts = New System.Windows.Forms.CheckBox()
        Me.chkTempRegSts = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkVOkMask = New System.Windows.Forms.CheckBox()
        Me.chkNtcTempMask = New System.Windows.Forms.CheckBox()
        Me.chkTimerMask = New System.Windows.Forms.CheckBox()
        Me.chkChgPhaseMask = New System.Windows.Forms.CheckBox()
        Me.chkADCDoneMask = New System.Windows.Forms.CheckBox()
        Me.chkTempRegMask = New System.Windows.Forms.CheckBox()
        Me.chkCtrlLimitMask = New System.Windows.Forms.CheckBox()
        Me.lblForceAdcMode = New System.Windows.Forms.Label()
        Me.cmbAdcOscSel = New System.Windows.Forms.ComboBox()
        Me.lblOscSel = New System.Windows.Forms.Label()
        Me.tbpEvents = New System.Windows.Forms.TabPage()
        Me.btnStsRead = New System.Windows.Forms.Button()
        Me.GrpBoxSYSB = New System.Windows.Forms.GroupBox()
        Me.txtWatchdogTmrSts = New System.Windows.Forms.TextBox()
        Me.txtChargeTmrSts = New System.Windows.Forms.TextBox()
        Me.txtStandbyStateSts = New System.Windows.Forms.TextBox()
        Me.txtShutDownStateSts = New System.Windows.Forms.TextBox()
        Me.txtActiveStateSts = New System.Windows.Forms.TextBox()
        Me.txtOcpAvgSts = New System.Windows.Forms.TextBox()
        Me.txtOcpFastSts = New System.Windows.Forms.TextBox()
        Me.txtBatteryMissSts = New System.Windows.Forms.TextBox()
        Me.chkWatchdogTmrSts = New System.Windows.Forms.CheckBox()
        Me.chkStandbyStateSts = New System.Windows.Forms.CheckBox()
        Me.chkChargeTmrSts = New System.Windows.Forms.CheckBox()
        Me.chkBatteryMissSts = New System.Windows.Forms.CheckBox()
        Me.chkOcpFastSts = New System.Windows.Forms.CheckBox()
        Me.chkOcpAvgSts = New System.Windows.Forms.CheckBox()
        Me.chkActiveStateSts = New System.Windows.Forms.CheckBox()
        Me.chkShutDownStateSts = New System.Windows.Forms.CheckBox()
        Me.GrpBoxSTSA = New System.Windows.Forms.GroupBox()
        Me.txtVinUvSts = New System.Windows.Forms.TextBox()
        Me.txtVinOvSts = New System.Windows.Forms.TextBox()
        Me.txtVbatOvSts = New System.Windows.Forms.TextBox()
        Me.txtVoutUvSts = New System.Windows.Forms.TextBox()
        Me.txtVFLTLoopSts = New System.Windows.Forms.TextBox()
        Me.txtChgLoopSts = New System.Windows.Forms.TextBox()
        Me.txtIinLoopSts = New System.Windows.Forms.TextBox()
        Me.chkVinOvSts = New System.Windows.Forms.CheckBox()
        Me.chkVinUvSts = New System.Windows.Forms.CheckBox()
        Me.chkIinLoopSts = New System.Windows.Forms.CheckBox()
        Me.chkChgLoopSts = New System.Windows.Forms.CheckBox()
        Me.chkVFLTLoopSts = New System.Windows.Forms.CheckBox()
        Me.chkVoutUvSts = New System.Windows.Forms.CheckBox()
        Me.chkVbatOvSts = New System.Windows.Forms.CheckBox()
        Me.lblHiberDelay = New System.Windows.Forms.Label()
        Me.cmbAdcForceMode = New System.Windows.Forms.ComboBox()
        Me.cmbAdcOffset = New System.Windows.Forms.ComboBox()
        Me.lblAdcOffset = New System.Windows.Forms.Label()
        Me.chkRevCurrentDet = New System.Windows.Forms.CheckBox()
        Me.chkStandbyEn = New System.Windows.Forms.CheckBox()
        Me.lblSwFreqVal = New System.Windows.Forms.Label()
        Me.trbSwFreqCfg = New System.Windows.Forms.TrackBar()
        Me.lblSwFreqCfg = New System.Windows.Forms.Label()
        Me.lblIinCfgVal = New System.Windows.Forms.Label()
        Me.trbIinCfg = New System.Windows.Forms.TrackBar()
        Me.lblIinCfg = New System.Windows.Forms.Label()
        Me.lblIchgCfgVal = New System.Windows.Forms.Label()
        Me.trbIchgCfg = New System.Windows.Forms.TrackBar()
        Me.lblIchgCfg = New System.Windows.Forms.Label()
        Me.chkAdcEn = New System.Windows.Forms.CheckBox()
        Me.tbpAdc = New System.Windows.Forms.TabPage()
        Me.btnAdcEnRead = New System.Windows.Forms.Button()
        Me.btnAdcEnSet = New System.Windows.Forms.Button()
        Me.cmbAdcHibDelay = New System.Windows.Forms.ComboBox()
        Me.grpDevice = New System.Windows.Forms.GroupBox()
        Me.lblRev = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkChargerTimerEn = New System.Windows.Forms.CheckBox()
        Me.chkWatchDogEn = New System.Windows.Forms.CheckBox()
        Me.chkBattMissShutDownEn = New System.Windows.Forms.CheckBox()
        Me.chkMissBatteryDetEn = New System.Windows.Forms.CheckBox()
        Me.chkIinForceIncrementEn = New System.Windows.Forms.CheckBox()
        Me.cmbOVDelta = New System.Windows.Forms.ComboBox()
        Me.lblOVDelta = New System.Windows.Forms.Label()
        Me.cmbChargerTimer = New System.Windows.Forms.ComboBox()
        Me.cmbWatchdogCfg = New System.Windows.Forms.ComboBox()
        Me.lblWatchdogCfg = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslInterface = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblChargerTimer = New System.Windows.Forms.Label()
        Me.tmrWork = New System.Windows.Forms.Timer(Me.components)
        Me.lblVFloatVal = New System.Windows.Forms.Label()
        Me.trbVFloat = New System.Windows.Forms.TrackBar()
        Me.lblVFloat = New System.Windows.Forms.Label()
        Me.cmbUVDelta = New System.Windows.Forms.ComboBox()
        Me.tbpProt = New System.Windows.Forms.TabPage()
        Me.btnProtectRead = New System.Windows.Forms.Button()
        Me.btnProtectSet = New System.Windows.Forms.Button()
        Me.lblUVDelta = New System.Windows.Forms.Label()
        Me.chkCfgEn = New System.Windows.Forms.CheckBox()
        Me.pnlFunctions = New System.Windows.Forms.Panel()
        Me.btnCurrentADCRead = New System.Windows.Forms.Button()
        Me.GrpBoxSTSD = New System.Windows.Forms.GroupBox()
        Me.txtIchgStatus = New System.Windows.Forms.TextBox()
        Me.grpRaised = New System.Windows.Forms.GroupBox()
        Me.btnRaisedIntRead = New System.Windows.Forms.Button()
        Me.chkTimerInt = New System.Windows.Forms.CheckBox()
        Me.chkADCDoneInt = New System.Windows.Forms.CheckBox()
        Me.chkTempRegInt = New System.Windows.Forms.CheckBox()
        Me.chkCtrlLimitInt = New System.Windows.Forms.CheckBox()
        Me.chkChgPhaseInt = New System.Windows.Forms.CheckBox()
        Me.chkNTCtempInt = New System.Windows.Forms.CheckBox()
        Me.chkVOkInt = New System.Windows.Forms.CheckBox()
        Me.GrpBoxSTSC = New System.Windows.Forms.GroupBox()
        Me.txtIinStatus = New System.Windows.Forms.TextBox()
        Me.grpAdcChannels = New System.Windows.Forms.GroupBox()
        Me.btnReadADC = New System.Windows.Forms.Button()
        Me.txtBatteryVoltage = New System.Windows.Forms.TextBox()
        Me.txtInputVoltage = New System.Windows.Forms.TextBox()
        Me.txtChargeCurrent = New System.Windows.Forms.TextBox()
        Me.txtInputCurrent = New System.Windows.Forms.TextBox()
        Me.txtDieTemp = New System.Windows.Forms.TextBox()
        Me.txtSysVoltage = New System.Windows.Forms.TextBox()
        Me.txtNtcAdc = New System.Windows.Forms.TextBox()
        Me.chkInputVoltageAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkBatteryVoltageAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkInputCurrentAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkChrageCurrentAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkDieTempAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkSysVoltageAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkNtcAdcEn = New System.Windows.Forms.CheckBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tbpControl = New System.Windows.Forms.TabPage()
        Me.btnCtlRead = New System.Windows.Forms.Button()
        Me.btnCtlSet = New System.Windows.Forms.Button()
        Me.chkLimitIncrementEn = New System.Windows.Forms.CheckBox()
        Me.cmbIinSoftStep = New System.Windows.Forms.ComboBox()
        Me.lblIinSoftStep = New System.Windows.Forms.Label()
        Me.cmbChgSoftStep = New System.Windows.Forms.ComboBox()
        Me.lblchgSoftStep = New System.Windows.Forms.Label()
        Me.cmbSenseR = New System.Windows.Forms.ComboBox()
        Me.lblSenseR = New System.Windows.Forms.Label()
        Me.tbpThermal = New System.Windows.Forms.TabPage()
        Me.btnThermalRead = New System.Windows.Forms.Button()
        Me.btnThermalSet = New System.Windows.Forms.Button()
        Me.chkTempMaxEn = New System.Windows.Forms.CheckBox()
        Me.chkNtcProtectionEn = New System.Windows.Forms.CheckBox()
        Me.chkTempRegEn = New System.Windows.Forms.CheckBox()
        Me.cmbTempReg = New System.Windows.Forms.ComboBox()
        Me.lblTempReg = New System.Windows.Forms.Label()
        Me.cmbTempDelta = New System.Windows.Forms.ComboBox()
        Me.lblTempDelta = New System.Windows.Forms.Label()
        Me.lblNTCThresholdVal = New System.Windows.Forms.Label()
        Me.trbNTCThreshold = New System.Windows.Forms.TrackBar()
        Me.lblNTCThreshold = New System.Windows.Forms.Label()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRegisters = New System.Windows.Forms.ToolStripButton()
        Me.tsbFunctions = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbReset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRead = New System.Windows.Forms.ToolStripButton()
        Me.tsbWrite = New System.Windows.Forms.ToolStripButton()
        Me.theToolbar = New System.Windows.Forms.ToolStrip()
        Me.tscRefresh = New System.Windows.Forms.ToolStripComboBox()
        Me.tsmManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInterval4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInterval1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmInterval0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInterval2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmWrite = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRegisters = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFunctions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheMenu = New System.Windows.Forms.MenuStrip()
        Me.pnlRegisters = New System.Windows.Forms.Panel()
        Me.txtTimerSts = New System.Windows.Forms.TextBox()
        Me.txtADCDoneSts = New System.Windows.Forms.TextBox()
        Me.txtTempRegSts = New System.Windows.Forms.TextBox()
        Me.txtCtrlLimitSts = New System.Windows.Forms.TextBox()
        Me.txtChgPhaseSts = New System.Windows.Forms.TextBox()
        Me.txtNtcTempSts = New System.Windows.Forms.TextBox()
        Me.txtVOKSts = New System.Windows.Forms.TextBox()
        Me.tbpInt.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbpEvents.SuspendLayout()
        Me.GrpBoxSYSB.SuspendLayout()
        Me.GrpBoxSTSA.SuspendLayout()
        CType(Me.trbSwFreqCfg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbIinCfg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbIchgCfg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpAdc.SuspendLayout()
        Me.grpDevice.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbVFloat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpProt.SuspendLayout()
        Me.pnlFunctions.SuspendLayout()
        Me.GrpBoxSTSD.SuspendLayout()
        Me.grpRaised.SuspendLayout()
        Me.GrpBoxSTSC.SuspendLayout()
        Me.grpAdcChannels.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tbpControl.SuspendLayout()
        Me.tbpThermal.SuspendLayout()
        CType(Me.trbNTCThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.theToolbar.SuspendLayout()
        Me.TheMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpInt
        '
        Me.tbpInt.BackColor = System.Drawing.SystemColors.Control
        Me.tbpInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpInt.Controls.Add(Me.btnIntRead)
        Me.tbpInt.Controls.Add(Me.btnIntSet)
        Me.tbpInt.Controls.Add(Me.GroupBox2)
        Me.tbpInt.Controls.Add(Me.GroupBox1)
        Me.tbpInt.Location = New System.Drawing.Point(4, 28)
        Me.tbpInt.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpInt.Name = "tbpInt"
        Me.tbpInt.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpInt.Size = New System.Drawing.Size(546, 304)
        Me.tbpInt.TabIndex = 0
        Me.tbpInt.Text = "Interrupts"
        '
        'btnIntRead
        '
        Me.btnIntRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnIntRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntRead.Location = New System.Drawing.Point(462, 269)
        Me.btnIntRead.Name = "btnIntRead"
        Me.btnIntRead.Size = New System.Drawing.Size(76, 26)
        Me.btnIntRead.TabIndex = 59
        Me.btnIntRead.Text = "Read"
        Me.btnIntRead.UseVisualStyleBackColor = False
        '
        'btnIntSet
        '
        Me.btnIntSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntSet.Location = New System.Drawing.Point(379, 269)
        Me.btnIntSet.Name = "btnIntSet"
        Me.btnIntSet.Size = New System.Drawing.Size(76, 26)
        Me.btnIntSet.TabIndex = 58
        Me.btnIntSet.Text = "Set"
        Me.btnIntSet.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTimerSts)
        Me.GroupBox2.Controls.Add(Me.txtADCDoneSts)
        Me.GroupBox2.Controls.Add(Me.txtTempRegSts)
        Me.GroupBox2.Controls.Add(Me.txtCtrlLimitSts)
        Me.GroupBox2.Controls.Add(Me.txtChgPhaseSts)
        Me.GroupBox2.Controls.Add(Me.txtNtcTempSts)
        Me.GroupBox2.Controls.Add(Me.txtVOKSts)
        Me.GroupBox2.Controls.Add(Me.chkVOKSts)
        Me.GroupBox2.Controls.Add(Me.chkNtcTempSts)
        Me.GroupBox2.Controls.Add(Me.chkChgPhaseSts)
        Me.GroupBox2.Controls.Add(Me.chkTimerSts)
        Me.GroupBox2.Controls.Add(Me.chkCtrlLimitSts)
        Me.GroupBox2.Controls.Add(Me.chkADCDoneSts)
        Me.GroupBox2.Controls.Add(Me.chkTempRegSts)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 228)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Interrupt Status"
        '
        'chkVOKSts
        '
        Me.chkVOKSts.AutoSize = True
        Me.chkVOKSts.Location = New System.Drawing.Point(17, 22)
        Me.chkVOKSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVOKSts.Name = "chkVOKSts"
        Me.chkVOKSts.Size = New System.Drawing.Size(95, 21)
        Me.chkVOKSts.TabIndex = 20
        Me.chkVOKSts.Text = "Vbus OVP"
        Me.chkVOKSts.UseVisualStyleBackColor = True
        '
        'chkNtcTempSts
        '
        Me.chkNtcTempSts.AutoSize = True
        Me.chkNtcTempSts.Location = New System.Drawing.Point(17, 50)
        Me.chkNtcTempSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNtcTempSts.Name = "chkNtcTempSts"
        Me.chkNtcTempSts.Size = New System.Drawing.Size(95, 21)
        Me.chkNtcTempSts.TabIndex = 21
        Me.chkNtcTempSts.Text = "Vbus OVP"
        Me.chkNtcTempSts.UseVisualStyleBackColor = True
        '
        'chkChgPhaseSts
        '
        Me.chkChgPhaseSts.AutoSize = True
        Me.chkChgPhaseSts.Location = New System.Drawing.Point(17, 78)
        Me.chkChgPhaseSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChgPhaseSts.Name = "chkChgPhaseSts"
        Me.chkChgPhaseSts.Size = New System.Drawing.Size(95, 21)
        Me.chkChgPhaseSts.TabIndex = 22
        Me.chkChgPhaseSts.Text = "Vbus OVP"
        Me.chkChgPhaseSts.UseVisualStyleBackColor = True
        '
        'chkTimerSts
        '
        Me.chkTimerSts.AutoSize = True
        Me.chkTimerSts.Location = New System.Drawing.Point(17, 190)
        Me.chkTimerSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTimerSts.Name = "chkTimerSts"
        Me.chkTimerSts.Size = New System.Drawing.Size(95, 21)
        Me.chkTimerSts.TabIndex = 26
        Me.chkTimerSts.Text = "Vbus OVP"
        Me.chkTimerSts.UseVisualStyleBackColor = True
        '
        'chkCtrlLimitSts
        '
        Me.chkCtrlLimitSts.AutoSize = True
        Me.chkCtrlLimitSts.Location = New System.Drawing.Point(17, 106)
        Me.chkCtrlLimitSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCtrlLimitSts.Name = "chkCtrlLimitSts"
        Me.chkCtrlLimitSts.Size = New System.Drawing.Size(95, 21)
        Me.chkCtrlLimitSts.TabIndex = 23
        Me.chkCtrlLimitSts.Text = "Vbus OVP"
        Me.chkCtrlLimitSts.UseVisualStyleBackColor = True
        '
        'chkADCDoneSts
        '
        Me.chkADCDoneSts.AutoSize = True
        Me.chkADCDoneSts.Location = New System.Drawing.Point(17, 162)
        Me.chkADCDoneSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkADCDoneSts.Name = "chkADCDoneSts"
        Me.chkADCDoneSts.Size = New System.Drawing.Size(95, 21)
        Me.chkADCDoneSts.TabIndex = 25
        Me.chkADCDoneSts.Text = "Vbus OVP"
        Me.chkADCDoneSts.UseVisualStyleBackColor = True
        '
        'chkTempRegSts
        '
        Me.chkTempRegSts.AutoSize = True
        Me.chkTempRegSts.Location = New System.Drawing.Point(17, 134)
        Me.chkTempRegSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTempRegSts.Name = "chkTempRegSts"
        Me.chkTempRegSts.Size = New System.Drawing.Size(95, 21)
        Me.chkTempRegSts.TabIndex = 24
        Me.chkTempRegSts.Text = "Vbus OVP"
        Me.chkTempRegSts.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkVOkMask)
        Me.GroupBox1.Controls.Add(Me.chkNtcTempMask)
        Me.GroupBox1.Controls.Add(Me.chkTimerMask)
        Me.GroupBox1.Controls.Add(Me.chkChgPhaseMask)
        Me.GroupBox1.Controls.Add(Me.chkADCDoneMask)
        Me.GroupBox1.Controls.Add(Me.chkTempRegMask)
        Me.GroupBox1.Controls.Add(Me.chkCtrlLimitMask)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 228)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interrupt Mask"
        '
        'chkVOkMask
        '
        Me.chkVOkMask.AutoSize = True
        Me.chkVOkMask.Location = New System.Drawing.Point(17, 22)
        Me.chkVOkMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVOkMask.Name = "chkVOkMask"
        Me.chkVOkMask.Size = New System.Drawing.Size(95, 21)
        Me.chkVOkMask.TabIndex = 20
        Me.chkVOkMask.Text = "Vbus OVP"
        Me.chkVOkMask.UseVisualStyleBackColor = True
        '
        'chkNtcTempMask
        '
        Me.chkNtcTempMask.AutoSize = True
        Me.chkNtcTempMask.Location = New System.Drawing.Point(17, 50)
        Me.chkNtcTempMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNtcTempMask.Name = "chkNtcTempMask"
        Me.chkNtcTempMask.Size = New System.Drawing.Size(95, 21)
        Me.chkNtcTempMask.TabIndex = 21
        Me.chkNtcTempMask.Text = "Vbus OVP"
        Me.chkNtcTempMask.UseVisualStyleBackColor = True
        '
        'chkTimerMask
        '
        Me.chkTimerMask.AutoSize = True
        Me.chkTimerMask.Location = New System.Drawing.Point(17, 190)
        Me.chkTimerMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTimerMask.Name = "chkTimerMask"
        Me.chkTimerMask.Size = New System.Drawing.Size(95, 21)
        Me.chkTimerMask.TabIndex = 27
        Me.chkTimerMask.Text = "Vbus OVP"
        Me.chkTimerMask.UseVisualStyleBackColor = True
        '
        'chkChgPhaseMask
        '
        Me.chkChgPhaseMask.AutoSize = True
        Me.chkChgPhaseMask.Location = New System.Drawing.Point(17, 78)
        Me.chkChgPhaseMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChgPhaseMask.Name = "chkChgPhaseMask"
        Me.chkChgPhaseMask.Size = New System.Drawing.Size(95, 21)
        Me.chkChgPhaseMask.TabIndex = 22
        Me.chkChgPhaseMask.Text = "Vbus OVP"
        Me.chkChgPhaseMask.UseVisualStyleBackColor = True
        '
        'chkADCDoneMask
        '
        Me.chkADCDoneMask.AutoSize = True
        Me.chkADCDoneMask.Location = New System.Drawing.Point(17, 162)
        Me.chkADCDoneMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkADCDoneMask.Name = "chkADCDoneMask"
        Me.chkADCDoneMask.Size = New System.Drawing.Size(95, 21)
        Me.chkADCDoneMask.TabIndex = 26
        Me.chkADCDoneMask.Text = "Vbus OVP"
        Me.chkADCDoneMask.UseVisualStyleBackColor = True
        '
        'chkTempRegMask
        '
        Me.chkTempRegMask.AutoSize = True
        Me.chkTempRegMask.Location = New System.Drawing.Point(17, 134)
        Me.chkTempRegMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTempRegMask.Name = "chkTempRegMask"
        Me.chkTempRegMask.Size = New System.Drawing.Size(95, 21)
        Me.chkTempRegMask.TabIndex = 25
        Me.chkTempRegMask.Text = "Vbus OVP"
        Me.chkTempRegMask.UseVisualStyleBackColor = True
        '
        'chkCtrlLimitMask
        '
        Me.chkCtrlLimitMask.AutoSize = True
        Me.chkCtrlLimitMask.Location = New System.Drawing.Point(17, 106)
        Me.chkCtrlLimitMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCtrlLimitMask.Name = "chkCtrlLimitMask"
        Me.chkCtrlLimitMask.Size = New System.Drawing.Size(95, 21)
        Me.chkCtrlLimitMask.TabIndex = 24
        Me.chkCtrlLimitMask.Text = "Vbus OVP"
        Me.chkCtrlLimitMask.UseVisualStyleBackColor = True
        '
        'lblForceAdcMode
        '
        Me.lblForceAdcMode.AutoSize = True
        Me.lblForceAdcMode.Location = New System.Drawing.Point(19, 26)
        Me.lblForceAdcMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForceAdcMode.Name = "lblForceAdcMode"
        Me.lblForceAdcMode.Size = New System.Drawing.Size(115, 17)
        Me.lblForceAdcMode.TabIndex = 21
        Me.lblForceAdcMode.Text = "Force ADC Mode"
        '
        'cmbAdcOscSel
        '
        Me.cmbAdcOscSel.FormattingEnabled = True
        Me.cmbAdcOscSel.Location = New System.Drawing.Point(183, 126)
        Me.cmbAdcOscSel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAdcOscSel.Name = "cmbAdcOscSel"
        Me.cmbAdcOscSel.Size = New System.Drawing.Size(177, 24)
        Me.cmbAdcOscSel.TabIndex = 20
        '
        'lblOscSel
        '
        Me.lblOscSel.AutoSize = True
        Me.lblOscSel.Location = New System.Drawing.Point(19, 129)
        Me.lblOscSel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOscSel.Name = "lblOscSel"
        Me.lblOscSel.Size = New System.Drawing.Size(51, 17)
        Me.lblOscSel.TabIndex = 19
        Me.lblOscSel.Text = "Label1"
        '
        'tbpEvents
        '
        Me.tbpEvents.BackColor = System.Drawing.SystemColors.Control
        Me.tbpEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpEvents.Controls.Add(Me.btnStsRead)
        Me.tbpEvents.Controls.Add(Me.GrpBoxSYSB)
        Me.tbpEvents.Controls.Add(Me.GrpBoxSTSA)
        Me.tbpEvents.Location = New System.Drawing.Point(4, 28)
        Me.tbpEvents.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpEvents.Name = "tbpEvents"
        Me.tbpEvents.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpEvents.Size = New System.Drawing.Size(546, 304)
        Me.tbpEvents.TabIndex = 3
        Me.tbpEvents.Text = "Status"
        '
        'btnStsRead
        '
        Me.btnStsRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnStsRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStsRead.Location = New System.Drawing.Point(462, 269)
        Me.btnStsRead.Name = "btnStsRead"
        Me.btnStsRead.Size = New System.Drawing.Size(76, 26)
        Me.btnStsRead.TabIndex = 59
        Me.btnStsRead.Text = "Read"
        Me.btnStsRead.UseVisualStyleBackColor = False
        '
        'GrpBoxSYSB
        '
        Me.GrpBoxSYSB.Controls.Add(Me.txtWatchdogTmrSts)
        Me.GrpBoxSYSB.Controls.Add(Me.txtChargeTmrSts)
        Me.GrpBoxSYSB.Controls.Add(Me.txtStandbyStateSts)
        Me.GrpBoxSYSB.Controls.Add(Me.txtShutDownStateSts)
        Me.GrpBoxSYSB.Controls.Add(Me.txtActiveStateSts)
        Me.GrpBoxSYSB.Controls.Add(Me.txtOcpAvgSts)
        Me.GrpBoxSYSB.Controls.Add(Me.txtOcpFastSts)
        Me.GrpBoxSYSB.Controls.Add(Me.txtBatteryMissSts)
        Me.GrpBoxSYSB.Controls.Add(Me.chkWatchdogTmrSts)
        Me.GrpBoxSYSB.Controls.Add(Me.chkStandbyStateSts)
        Me.GrpBoxSYSB.Controls.Add(Me.chkChargeTmrSts)
        Me.GrpBoxSYSB.Controls.Add(Me.chkBatteryMissSts)
        Me.GrpBoxSYSB.Controls.Add(Me.chkOcpFastSts)
        Me.GrpBoxSYSB.Controls.Add(Me.chkOcpAvgSts)
        Me.GrpBoxSYSB.Controls.Add(Me.chkActiveStateSts)
        Me.GrpBoxSYSB.Controls.Add(Me.chkShutDownStateSts)
        Me.GrpBoxSYSB.Location = New System.Drawing.Point(263, 22)
        Me.GrpBoxSYSB.Name = "GrpBoxSYSB"
        Me.GrpBoxSYSB.Size = New System.Drawing.Size(234, 244)
        Me.GrpBoxSYSB.TabIndex = 36
        Me.GrpBoxSYSB.TabStop = False
        Me.GrpBoxSYSB.Text = "STS_B"
        '
        'txtWatchdogTmrSts
        '
        Me.txtWatchdogTmrSts.Location = New System.Drawing.Point(38, 217)
        Me.txtWatchdogTmrSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWatchdogTmrSts.Name = "txtWatchdogTmrSts"
        Me.txtWatchdogTmrSts.ReadOnly = True
        Me.txtWatchdogTmrSts.Size = New System.Drawing.Size(178, 22)
        Me.txtWatchdogTmrSts.TabIndex = 44
        '
        'txtChargeTmrSts
        '
        Me.txtChargeTmrSts.Location = New System.Drawing.Point(38, 191)
        Me.txtChargeTmrSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChargeTmrSts.Name = "txtChargeTmrSts"
        Me.txtChargeTmrSts.ReadOnly = True
        Me.txtChargeTmrSts.Size = New System.Drawing.Size(178, 22)
        Me.txtChargeTmrSts.TabIndex = 43
        '
        'txtStandbyStateSts
        '
        Me.txtStandbyStateSts.Location = New System.Drawing.Point(38, 162)
        Me.txtStandbyStateSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStandbyStateSts.Name = "txtStandbyStateSts"
        Me.txtStandbyStateSts.ReadOnly = True
        Me.txtStandbyStateSts.Size = New System.Drawing.Size(178, 22)
        Me.txtStandbyStateSts.TabIndex = 42
        '
        'txtShutDownStateSts
        '
        Me.txtShutDownStateSts.Location = New System.Drawing.Point(38, 134)
        Me.txtShutDownStateSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShutDownStateSts.Name = "txtShutDownStateSts"
        Me.txtShutDownStateSts.ReadOnly = True
        Me.txtShutDownStateSts.Size = New System.Drawing.Size(178, 22)
        Me.txtShutDownStateSts.TabIndex = 41
        '
        'txtActiveStateSts
        '
        Me.txtActiveStateSts.Location = New System.Drawing.Point(38, 104)
        Me.txtActiveStateSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtActiveStateSts.Name = "txtActiveStateSts"
        Me.txtActiveStateSts.ReadOnly = True
        Me.txtActiveStateSts.Size = New System.Drawing.Size(178, 22)
        Me.txtActiveStateSts.TabIndex = 40
        '
        'txtOcpAvgSts
        '
        Me.txtOcpAvgSts.Location = New System.Drawing.Point(38, 78)
        Me.txtOcpAvgSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOcpAvgSts.Name = "txtOcpAvgSts"
        Me.txtOcpAvgSts.ReadOnly = True
        Me.txtOcpAvgSts.Size = New System.Drawing.Size(178, 22)
        Me.txtOcpAvgSts.TabIndex = 39
        '
        'txtOcpFastSts
        '
        Me.txtOcpFastSts.Location = New System.Drawing.Point(38, 48)
        Me.txtOcpFastSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOcpFastSts.Name = "txtOcpFastSts"
        Me.txtOcpFastSts.ReadOnly = True
        Me.txtOcpFastSts.Size = New System.Drawing.Size(178, 22)
        Me.txtOcpFastSts.TabIndex = 38
        '
        'txtBatteryMissSts
        '
        Me.txtBatteryMissSts.Location = New System.Drawing.Point(38, 22)
        Me.txtBatteryMissSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatteryMissSts.Name = "txtBatteryMissSts"
        Me.txtBatteryMissSts.ReadOnly = True
        Me.txtBatteryMissSts.Size = New System.Drawing.Size(178, 22)
        Me.txtBatteryMissSts.TabIndex = 37
        '
        'chkWatchdogTmrSts
        '
        Me.chkWatchdogTmrSts.AutoSize = True
        Me.chkWatchdogTmrSts.Location = New System.Drawing.Point(17, 218)
        Me.chkWatchdogTmrSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkWatchdogTmrSts.Name = "chkWatchdogTmrSts"
        Me.chkWatchdogTmrSts.Size = New System.Drawing.Size(95, 21)
        Me.chkWatchdogTmrSts.TabIndex = 31
        Me.chkWatchdogTmrSts.Text = "Vbus OVP"
        Me.chkWatchdogTmrSts.UseVisualStyleBackColor = True
        '
        'chkStandbyStateSts
        '
        Me.chkStandbyStateSts.AutoSize = True
        Me.chkStandbyStateSts.Location = New System.Drawing.Point(17, 162)
        Me.chkStandbyStateSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkStandbyStateSts.Name = "chkStandbyStateSts"
        Me.chkStandbyStateSts.Size = New System.Drawing.Size(95, 21)
        Me.chkStandbyStateSts.TabIndex = 29
        Me.chkStandbyStateSts.Text = "Vbus OVP"
        Me.chkStandbyStateSts.UseVisualStyleBackColor = True
        '
        'chkChargeTmrSts
        '
        Me.chkChargeTmrSts.AutoSize = True
        Me.chkChargeTmrSts.Location = New System.Drawing.Point(17, 190)
        Me.chkChargeTmrSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChargeTmrSts.Name = "chkChargeTmrSts"
        Me.chkChargeTmrSts.Size = New System.Drawing.Size(95, 21)
        Me.chkChargeTmrSts.TabIndex = 30
        Me.chkChargeTmrSts.Text = "Vbus OVP"
        Me.chkChargeTmrSts.UseVisualStyleBackColor = True
        '
        'chkBatteryMissSts
        '
        Me.chkBatteryMissSts.AutoSize = True
        Me.chkBatteryMissSts.Location = New System.Drawing.Point(17, 22)
        Me.chkBatteryMissSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBatteryMissSts.Name = "chkBatteryMissSts"
        Me.chkBatteryMissSts.Size = New System.Drawing.Size(95, 21)
        Me.chkBatteryMissSts.TabIndex = 24
        Me.chkBatteryMissSts.Text = "Vbus OVP"
        Me.chkBatteryMissSts.UseVisualStyleBackColor = True
        '
        'chkOcpFastSts
        '
        Me.chkOcpFastSts.AutoSize = True
        Me.chkOcpFastSts.Location = New System.Drawing.Point(17, 50)
        Me.chkOcpFastSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOcpFastSts.Name = "chkOcpFastSts"
        Me.chkOcpFastSts.Size = New System.Drawing.Size(95, 21)
        Me.chkOcpFastSts.TabIndex = 25
        Me.chkOcpFastSts.Text = "Vbus OVP"
        Me.chkOcpFastSts.UseVisualStyleBackColor = True
        '
        'chkOcpAvgSts
        '
        Me.chkOcpAvgSts.AutoSize = True
        Me.chkOcpAvgSts.Location = New System.Drawing.Point(17, 78)
        Me.chkOcpAvgSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOcpAvgSts.Name = "chkOcpAvgSts"
        Me.chkOcpAvgSts.Size = New System.Drawing.Size(95, 21)
        Me.chkOcpAvgSts.TabIndex = 26
        Me.chkOcpAvgSts.Text = "Vbus OVP"
        Me.chkOcpAvgSts.UseVisualStyleBackColor = True
        '
        'chkActiveStateSts
        '
        Me.chkActiveStateSts.AutoSize = True
        Me.chkActiveStateSts.Location = New System.Drawing.Point(17, 106)
        Me.chkActiveStateSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActiveStateSts.Name = "chkActiveStateSts"
        Me.chkActiveStateSts.Size = New System.Drawing.Size(95, 21)
        Me.chkActiveStateSts.TabIndex = 27
        Me.chkActiveStateSts.Text = "Vbus OVP"
        Me.chkActiveStateSts.UseVisualStyleBackColor = True
        '
        'chkShutDownStateSts
        '
        Me.chkShutDownStateSts.AutoSize = True
        Me.chkShutDownStateSts.Location = New System.Drawing.Point(17, 134)
        Me.chkShutDownStateSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShutDownStateSts.Name = "chkShutDownStateSts"
        Me.chkShutDownStateSts.Size = New System.Drawing.Size(95, 21)
        Me.chkShutDownStateSts.TabIndex = 28
        Me.chkShutDownStateSts.Text = "Vbus OVP"
        Me.chkShutDownStateSts.UseVisualStyleBackColor = True
        '
        'GrpBoxSTSA
        '
        Me.GrpBoxSTSA.Controls.Add(Me.txtVinUvSts)
        Me.GrpBoxSTSA.Controls.Add(Me.txtVinOvSts)
        Me.GrpBoxSTSA.Controls.Add(Me.txtVbatOvSts)
        Me.GrpBoxSTSA.Controls.Add(Me.txtVoutUvSts)
        Me.GrpBoxSTSA.Controls.Add(Me.txtVFLTLoopSts)
        Me.GrpBoxSTSA.Controls.Add(Me.txtChgLoopSts)
        Me.GrpBoxSTSA.Controls.Add(Me.txtIinLoopSts)
        Me.GrpBoxSTSA.Controls.Add(Me.chkVinOvSts)
        Me.GrpBoxSTSA.Controls.Add(Me.chkVinUvSts)
        Me.GrpBoxSTSA.Controls.Add(Me.chkIinLoopSts)
        Me.GrpBoxSTSA.Controls.Add(Me.chkChgLoopSts)
        Me.GrpBoxSTSA.Controls.Add(Me.chkVFLTLoopSts)
        Me.GrpBoxSTSA.Controls.Add(Me.chkVoutUvSts)
        Me.GrpBoxSTSA.Controls.Add(Me.chkVbatOvSts)
        Me.GrpBoxSTSA.Location = New System.Drawing.Point(15, 22)
        Me.GrpBoxSTSA.Name = "GrpBoxSTSA"
        Me.GrpBoxSTSA.Size = New System.Drawing.Size(224, 244)
        Me.GrpBoxSTSA.TabIndex = 35
        Me.GrpBoxSTSA.TabStop = False
        Me.GrpBoxSTSA.Text = "STS_A"
        '
        'txtVinUvSts
        '
        Me.txtVinUvSts.Location = New System.Drawing.Point(38, 191)
        Me.txtVinUvSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVinUvSts.Name = "txtVinUvSts"
        Me.txtVinUvSts.ReadOnly = True
        Me.txtVinUvSts.Size = New System.Drawing.Size(158, 22)
        Me.txtVinUvSts.TabIndex = 36
        '
        'txtVinOvSts
        '
        Me.txtVinOvSts.Location = New System.Drawing.Point(38, 162)
        Me.txtVinOvSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVinOvSts.Name = "txtVinOvSts"
        Me.txtVinOvSts.ReadOnly = True
        Me.txtVinOvSts.Size = New System.Drawing.Size(158, 22)
        Me.txtVinOvSts.TabIndex = 35
        '
        'txtVbatOvSts
        '
        Me.txtVbatOvSts.Location = New System.Drawing.Point(38, 134)
        Me.txtVbatOvSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVbatOvSts.Name = "txtVbatOvSts"
        Me.txtVbatOvSts.ReadOnly = True
        Me.txtVbatOvSts.Size = New System.Drawing.Size(158, 22)
        Me.txtVbatOvSts.TabIndex = 34
        '
        'txtVoutUvSts
        '
        Me.txtVoutUvSts.Location = New System.Drawing.Point(38, 104)
        Me.txtVoutUvSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVoutUvSts.Name = "txtVoutUvSts"
        Me.txtVoutUvSts.ReadOnly = True
        Me.txtVoutUvSts.Size = New System.Drawing.Size(158, 22)
        Me.txtVoutUvSts.TabIndex = 33
        '
        'txtVFLTLoopSts
        '
        Me.txtVFLTLoopSts.Location = New System.Drawing.Point(38, 78)
        Me.txtVFLTLoopSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVFLTLoopSts.Name = "txtVFLTLoopSts"
        Me.txtVFLTLoopSts.ReadOnly = True
        Me.txtVFLTLoopSts.Size = New System.Drawing.Size(158, 22)
        Me.txtVFLTLoopSts.TabIndex = 32
        '
        'txtChgLoopSts
        '
        Me.txtChgLoopSts.Location = New System.Drawing.Point(38, 48)
        Me.txtChgLoopSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChgLoopSts.Name = "txtChgLoopSts"
        Me.txtChgLoopSts.ReadOnly = True
        Me.txtChgLoopSts.Size = New System.Drawing.Size(158, 22)
        Me.txtChgLoopSts.TabIndex = 31
        '
        'txtIinLoopSts
        '
        Me.txtIinLoopSts.Location = New System.Drawing.Point(38, 22)
        Me.txtIinLoopSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIinLoopSts.Name = "txtIinLoopSts"
        Me.txtIinLoopSts.ReadOnly = True
        Me.txtIinLoopSts.Size = New System.Drawing.Size(158, 22)
        Me.txtIinLoopSts.TabIndex = 28
        '
        'chkVinOvSts
        '
        Me.chkVinOvSts.AutoSize = True
        Me.chkVinOvSts.Location = New System.Drawing.Point(17, 162)
        Me.chkVinOvSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVinOvSts.Name = "chkVinOvSts"
        Me.chkVinOvSts.Size = New System.Drawing.Size(95, 21)
        Me.chkVinOvSts.TabIndex = 29
        Me.chkVinOvSts.Text = "Vbus OVP"
        Me.chkVinOvSts.UseVisualStyleBackColor = True
        '
        'chkVinUvSts
        '
        Me.chkVinUvSts.AutoSize = True
        Me.chkVinUvSts.Location = New System.Drawing.Point(17, 190)
        Me.chkVinUvSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVinUvSts.Name = "chkVinUvSts"
        Me.chkVinUvSts.Size = New System.Drawing.Size(95, 21)
        Me.chkVinUvSts.TabIndex = 30
        Me.chkVinUvSts.Text = "Vbus OVP"
        Me.chkVinUvSts.UseVisualStyleBackColor = True
        '
        'chkIinLoopSts
        '
        Me.chkIinLoopSts.AutoSize = True
        Me.chkIinLoopSts.Location = New System.Drawing.Point(17, 22)
        Me.chkIinLoopSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIinLoopSts.Name = "chkIinLoopSts"
        Me.chkIinLoopSts.Size = New System.Drawing.Size(95, 21)
        Me.chkIinLoopSts.TabIndex = 24
        Me.chkIinLoopSts.Text = "Vbus OVP"
        Me.chkIinLoopSts.UseVisualStyleBackColor = True
        '
        'chkChgLoopSts
        '
        Me.chkChgLoopSts.AutoSize = True
        Me.chkChgLoopSts.Location = New System.Drawing.Point(17, 50)
        Me.chkChgLoopSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChgLoopSts.Name = "chkChgLoopSts"
        Me.chkChgLoopSts.Size = New System.Drawing.Size(95, 21)
        Me.chkChgLoopSts.TabIndex = 25
        Me.chkChgLoopSts.Text = "Vbus OVP"
        Me.chkChgLoopSts.UseVisualStyleBackColor = True
        '
        'chkVFLTLoopSts
        '
        Me.chkVFLTLoopSts.AutoSize = True
        Me.chkVFLTLoopSts.Location = New System.Drawing.Point(17, 78)
        Me.chkVFLTLoopSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVFLTLoopSts.Name = "chkVFLTLoopSts"
        Me.chkVFLTLoopSts.Size = New System.Drawing.Size(95, 21)
        Me.chkVFLTLoopSts.TabIndex = 26
        Me.chkVFLTLoopSts.Text = "Vbus OVP"
        Me.chkVFLTLoopSts.UseVisualStyleBackColor = True
        '
        'chkVoutUvSts
        '
        Me.chkVoutUvSts.AutoSize = True
        Me.chkVoutUvSts.Location = New System.Drawing.Point(17, 106)
        Me.chkVoutUvSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVoutUvSts.Name = "chkVoutUvSts"
        Me.chkVoutUvSts.Size = New System.Drawing.Size(95, 21)
        Me.chkVoutUvSts.TabIndex = 27
        Me.chkVoutUvSts.Text = "Vbus OVP"
        Me.chkVoutUvSts.UseVisualStyleBackColor = True
        '
        'chkVbatOvSts
        '
        Me.chkVbatOvSts.AutoSize = True
        Me.chkVbatOvSts.Location = New System.Drawing.Point(17, 134)
        Me.chkVbatOvSts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbatOvSts.Name = "chkVbatOvSts"
        Me.chkVbatOvSts.Size = New System.Drawing.Size(95, 21)
        Me.chkVbatOvSts.TabIndex = 28
        Me.chkVbatOvSts.Text = "Vbus OVP"
        Me.chkVbatOvSts.UseVisualStyleBackColor = True
        '
        'lblHiberDelay
        '
        Me.lblHiberDelay.AutoSize = True
        Me.lblHiberDelay.Location = New System.Drawing.Point(19, 63)
        Me.lblHiberDelay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHiberDelay.Name = "lblHiberDelay"
        Me.lblHiberDelay.Size = New System.Drawing.Size(110, 17)
        Me.lblHiberDelay.TabIndex = 23
        Me.lblHiberDelay.Text = "Hibernate Delay"
        '
        'cmbAdcForceMode
        '
        Me.cmbAdcForceMode.FormattingEnabled = True
        Me.cmbAdcForceMode.Location = New System.Drawing.Point(183, 24)
        Me.cmbAdcForceMode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAdcForceMode.Name = "cmbAdcForceMode"
        Me.cmbAdcForceMode.Size = New System.Drawing.Size(177, 24)
        Me.cmbAdcForceMode.TabIndex = 22
        '
        'cmbAdcOffset
        '
        Me.cmbAdcOffset.FormattingEnabled = True
        Me.cmbAdcOffset.Location = New System.Drawing.Point(183, 92)
        Me.cmbAdcOffset.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAdcOffset.Name = "cmbAdcOffset"
        Me.cmbAdcOffset.Size = New System.Drawing.Size(177, 24)
        Me.cmbAdcOffset.TabIndex = 18
        '
        'lblAdcOffset
        '
        Me.lblAdcOffset.AutoSize = True
        Me.lblAdcOffset.Location = New System.Drawing.Point(19, 96)
        Me.lblAdcOffset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdcOffset.Name = "lblAdcOffset"
        Me.lblAdcOffset.Size = New System.Drawing.Size(122, 17)
        Me.lblAdcOffset.TabIndex = 17
        Me.lblAdcOffset.Text = "ADC Offset Config"
        '
        'chkRevCurrentDet
        '
        Me.chkRevCurrentDet.AutoSize = True
        Me.chkRevCurrentDet.Location = New System.Drawing.Point(327, 86)
        Me.chkRevCurrentDet.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRevCurrentDet.Name = "chkRevCurrentDet"
        Me.chkRevCurrentDet.Size = New System.Drawing.Size(124, 21)
        Me.chkRevCurrentDet.TabIndex = 54
        Me.chkRevCurrentDet.Text = "RevCurrentDet"
        Me.chkRevCurrentDet.UseVisualStyleBackColor = True
        '
        'chkStandbyEn
        '
        Me.chkStandbyEn.AutoSize = True
        Me.chkStandbyEn.Location = New System.Drawing.Point(327, 56)
        Me.chkStandbyEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkStandbyEn.Name = "chkStandbyEn"
        Me.chkStandbyEn.Size = New System.Drawing.Size(103, 21)
        Me.chkStandbyEn.TabIndex = 53
        Me.chkStandbyEn.Text = "Standby En"
        Me.chkStandbyEn.UseVisualStyleBackColor = True
        '
        'lblSwFreqVal
        '
        Me.lblSwFreqVal.AutoSize = True
        Me.lblSwFreqVal.Location = New System.Drawing.Point(431, 225)
        Me.lblSwFreqVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSwFreqVal.Name = "lblSwFreqVal"
        Me.lblSwFreqVal.Size = New System.Drawing.Size(32, 17)
        Me.lblSwFreqVal.TabIndex = 52
        Me.lblSwFreqVal.Text = "kHz"
        '
        'trbSwFreqCfg
        '
        Me.trbSwFreqCfg.AutoSize = False
        Me.trbSwFreqCfg.Location = New System.Drawing.Point(175, 222)
        Me.trbSwFreqCfg.Margin = New System.Windows.Forms.Padding(4)
        Me.trbSwFreqCfg.Name = "trbSwFreqCfg"
        Me.trbSwFreqCfg.Size = New System.Drawing.Size(252, 31)
        Me.trbSwFreqCfg.TabIndex = 51
        '
        'lblSwFreqCfg
        '
        Me.lblSwFreqCfg.AutoSize = True
        Me.lblSwFreqCfg.Location = New System.Drawing.Point(19, 225)
        Me.lblSwFreqCfg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSwFreqCfg.Name = "lblSwFreqCfg"
        Me.lblSwFreqCfg.Size = New System.Drawing.Size(53, 17)
        Me.lblSwFreqCfg.TabIndex = 50
        Me.lblSwFreqCfg.Text = "swFreq"
        '
        'lblIinCfgVal
        '
        Me.lblIinCfgVal.AutoSize = True
        Me.lblIinCfgVal.Location = New System.Drawing.Point(431, 189)
        Me.lblIinCfgVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIinCfgVal.Name = "lblIinCfgVal"
        Me.lblIinCfgVal.Size = New System.Drawing.Size(28, 17)
        Me.lblIinCfgVal.TabIndex = 49
        Me.lblIinCfgVal.Text = "mA"
        '
        'trbIinCfg
        '
        Me.trbIinCfg.AutoSize = False
        Me.trbIinCfg.Location = New System.Drawing.Point(175, 186)
        Me.trbIinCfg.Margin = New System.Windows.Forms.Padding(4)
        Me.trbIinCfg.Name = "trbIinCfg"
        Me.trbIinCfg.Size = New System.Drawing.Size(252, 31)
        Me.trbIinCfg.TabIndex = 48
        '
        'lblIinCfg
        '
        Me.lblIinCfg.AutoSize = True
        Me.lblIinCfg.Location = New System.Drawing.Point(19, 189)
        Me.lblIinCfg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIinCfg.Name = "lblIinCfg"
        Me.lblIinCfg.Size = New System.Drawing.Size(43, 17)
        Me.lblIinCfg.TabIndex = 47
        Me.lblIinCfg.Text = "IinSet"
        '
        'lblIchgCfgVal
        '
        Me.lblIchgCfgVal.AutoSize = True
        Me.lblIchgCfgVal.Location = New System.Drawing.Point(431, 153)
        Me.lblIchgCfgVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIchgCfgVal.Name = "lblIchgCfgVal"
        Me.lblIchgCfgVal.Size = New System.Drawing.Size(28, 17)
        Me.lblIchgCfgVal.TabIndex = 46
        Me.lblIchgCfgVal.Text = "mA"
        '
        'trbIchgCfg
        '
        Me.trbIchgCfg.AutoSize = False
        Me.trbIchgCfg.Location = New System.Drawing.Point(175, 151)
        Me.trbIchgCfg.Margin = New System.Windows.Forms.Padding(4)
        Me.trbIchgCfg.Name = "trbIchgCfg"
        Me.trbIchgCfg.Size = New System.Drawing.Size(252, 31)
        Me.trbIchgCfg.TabIndex = 45
        '
        'lblIchgCfg
        '
        Me.lblIchgCfg.AutoSize = True
        Me.lblIchgCfg.Location = New System.Drawing.Point(19, 153)
        Me.lblIchgCfg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIchgCfg.Name = "lblIchgCfg"
        Me.lblIchgCfg.Size = New System.Drawing.Size(55, 17)
        Me.lblIchgCfg.TabIndex = 44
        Me.lblIchgCfg.Text = "IchgCfg"
        '
        'chkAdcEn
        '
        Me.chkAdcEn.AutoSize = True
        Me.chkAdcEn.Location = New System.Drawing.Point(19, 165)
        Me.chkAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAdcEn.Name = "chkAdcEn"
        Me.chkAdcEn.Size = New System.Drawing.Size(106, 21)
        Me.chkAdcEn.TabIndex = 15
        Me.chkAdcEn.Text = "ADC Enable"
        Me.chkAdcEn.UseVisualStyleBackColor = True
        '
        'tbpAdc
        '
        Me.tbpAdc.BackColor = System.Drawing.SystemColors.Control
        Me.tbpAdc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpAdc.Controls.Add(Me.btnAdcEnRead)
        Me.tbpAdc.Controls.Add(Me.btnAdcEnSet)
        Me.tbpAdc.Controls.Add(Me.cmbAdcHibDelay)
        Me.tbpAdc.Controls.Add(Me.lblHiberDelay)
        Me.tbpAdc.Controls.Add(Me.cmbAdcForceMode)
        Me.tbpAdc.Controls.Add(Me.lblForceAdcMode)
        Me.tbpAdc.Controls.Add(Me.cmbAdcOscSel)
        Me.tbpAdc.Controls.Add(Me.lblOscSel)
        Me.tbpAdc.Controls.Add(Me.cmbAdcOffset)
        Me.tbpAdc.Controls.Add(Me.lblAdcOffset)
        Me.tbpAdc.Controls.Add(Me.chkAdcEn)
        Me.tbpAdc.Location = New System.Drawing.Point(4, 28)
        Me.tbpAdc.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpAdc.Name = "tbpAdc"
        Me.tbpAdc.Size = New System.Drawing.Size(546, 304)
        Me.tbpAdc.TabIndex = 2
        Me.tbpAdc.Text = "ADC"
        '
        'btnAdcEnRead
        '
        Me.btnAdcEnRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdcEnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdcEnRead.Location = New System.Drawing.Point(462, 269)
        Me.btnAdcEnRead.Name = "btnAdcEnRead"
        Me.btnAdcEnRead.Size = New System.Drawing.Size(76, 26)
        Me.btnAdcEnRead.TabIndex = 59
        Me.btnAdcEnRead.Text = "Read"
        Me.btnAdcEnRead.UseVisualStyleBackColor = False
        '
        'btnAdcEnSet
        '
        Me.btnAdcEnSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdcEnSet.Location = New System.Drawing.Point(379, 269)
        Me.btnAdcEnSet.Name = "btnAdcEnSet"
        Me.btnAdcEnSet.Size = New System.Drawing.Size(76, 26)
        Me.btnAdcEnSet.TabIndex = 58
        Me.btnAdcEnSet.Text = "Set"
        Me.btnAdcEnSet.UseVisualStyleBackColor = False
        '
        'cmbAdcHibDelay
        '
        Me.cmbAdcHibDelay.FormattingEnabled = True
        Me.cmbAdcHibDelay.Location = New System.Drawing.Point(183, 58)
        Me.cmbAdcHibDelay.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAdcHibDelay.Name = "cmbAdcHibDelay"
        Me.cmbAdcHibDelay.Size = New System.Drawing.Size(177, 24)
        Me.cmbAdcHibDelay.TabIndex = 24
        '
        'grpDevice
        '
        Me.grpDevice.Controls.Add(Me.lblRev)
        Me.grpDevice.Controls.Add(Me.lblId)
        Me.grpDevice.Controls.Add(Me.Label5)
        Me.grpDevice.Controls.Add(Me.Label4)
        Me.grpDevice.Controls.Add(Me.lblAddr)
        Me.grpDevice.Controls.Add(Me.Label2)
        Me.grpDevice.Location = New System.Drawing.Point(16, 59)
        Me.grpDevice.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDevice.Name = "grpDevice"
        Me.grpDevice.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDevice.Size = New System.Drawing.Size(439, 59)
        Me.grpDevice.TabIndex = 35
        Me.grpDevice.TabStop = False
        Me.grpDevice.Text = "Device"
        '
        'lblRev
        '
        Me.lblRev.AutoSize = True
        Me.lblRev.Location = New System.Drawing.Point(376, 28)
        Me.lblRev.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRev.Name = "lblRev"
        Me.lblRev.Size = New System.Drawing.Size(18, 17)
        Me.lblRev.TabIndex = 8
        Me.lblRev.Text = "--"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(237, 28)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 17)
        Me.lblId.TabIndex = 7
        Me.lblId.Text = "--"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Revision:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID:"
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Location = New System.Drawing.Point(99, 28)
        Me.lblAddr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(18, 17)
        Me.lblAddr.TabIndex = 4
        Me.lblAddr.Text = "--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address:"
        '
        'chkChargerTimerEn
        '
        Me.chkChargerTimerEn.AutoSize = True
        Me.chkChargerTimerEn.Location = New System.Drawing.Point(327, 146)
        Me.chkChargerTimerEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChargerTimerEn.Name = "chkChargerTimerEn"
        Me.chkChargerTimerEn.Size = New System.Drawing.Size(95, 21)
        Me.chkChargerTimerEn.TabIndex = 55
        Me.chkChargerTimerEn.Text = "Vbus OVP"
        Me.chkChargerTimerEn.UseVisualStyleBackColor = True
        '
        'chkWatchDogEn
        '
        Me.chkWatchDogEn.AutoSize = True
        Me.chkWatchDogEn.Location = New System.Drawing.Point(327, 116)
        Me.chkWatchDogEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkWatchDogEn.Name = "chkWatchDogEn"
        Me.chkWatchDogEn.Size = New System.Drawing.Size(95, 21)
        Me.chkWatchDogEn.TabIndex = 54
        Me.chkWatchDogEn.Text = "Vbus OVP"
        Me.chkWatchDogEn.UseVisualStyleBackColor = True
        '
        'chkBattMissShutDownEn
        '
        Me.chkBattMissShutDownEn.AutoSize = True
        Me.chkBattMissShutDownEn.Location = New System.Drawing.Point(327, 86)
        Me.chkBattMissShutDownEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBattMissShutDownEn.Name = "chkBattMissShutDownEn"
        Me.chkBattMissShutDownEn.Size = New System.Drawing.Size(95, 21)
        Me.chkBattMissShutDownEn.TabIndex = 53
        Me.chkBattMissShutDownEn.Text = "Vbus OVP"
        Me.chkBattMissShutDownEn.UseVisualStyleBackColor = True
        '
        'chkMissBatteryDetEn
        '
        Me.chkMissBatteryDetEn.AutoSize = True
        Me.chkMissBatteryDetEn.Location = New System.Drawing.Point(327, 56)
        Me.chkMissBatteryDetEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMissBatteryDetEn.Name = "chkMissBatteryDetEn"
        Me.chkMissBatteryDetEn.Size = New System.Drawing.Size(95, 21)
        Me.chkMissBatteryDetEn.TabIndex = 52
        Me.chkMissBatteryDetEn.Text = "Vbus OVP"
        Me.chkMissBatteryDetEn.UseVisualStyleBackColor = True
        '
        'chkIinForceIncrementEn
        '
        Me.chkIinForceIncrementEn.AutoSize = True
        Me.chkIinForceIncrementEn.Location = New System.Drawing.Point(327, 26)
        Me.chkIinForceIncrementEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIinForceIncrementEn.Name = "chkIinForceIncrementEn"
        Me.chkIinForceIncrementEn.Size = New System.Drawing.Size(95, 21)
        Me.chkIinForceIncrementEn.TabIndex = 51
        Me.chkIinForceIncrementEn.Text = "Vbus OVP"
        Me.chkIinForceIncrementEn.UseVisualStyleBackColor = True
        '
        'cmbOVDelta
        '
        Me.cmbOVDelta.FormattingEnabled = True
        Me.cmbOVDelta.Location = New System.Drawing.Point(183, 58)
        Me.cmbOVDelta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOVDelta.Name = "cmbOVDelta"
        Me.cmbOVDelta.Size = New System.Drawing.Size(89, 24)
        Me.cmbOVDelta.TabIndex = 49
        '
        'lblOVDelta
        '
        Me.lblOVDelta.AutoSize = True
        Me.lblOVDelta.Location = New System.Drawing.Point(19, 61)
        Me.lblOVDelta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOVDelta.Name = "lblOVDelta"
        Me.lblOVDelta.Size = New System.Drawing.Size(65, 17)
        Me.lblOVDelta.TabIndex = 48
        Me.lblOVDelta.Text = "OV Delta"
        '
        'cmbChargerTimer
        '
        Me.cmbChargerTimer.FormattingEnabled = True
        Me.cmbChargerTimer.Location = New System.Drawing.Point(183, 92)
        Me.cmbChargerTimer.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbChargerTimer.Name = "cmbChargerTimer"
        Me.cmbChargerTimer.Size = New System.Drawing.Size(89, 24)
        Me.cmbChargerTimer.TabIndex = 47
        '
        'cmbWatchdogCfg
        '
        Me.cmbWatchdogCfg.FormattingEnabled = True
        Me.cmbWatchdogCfg.Location = New System.Drawing.Point(183, 126)
        Me.cmbWatchdogCfg.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbWatchdogCfg.Name = "cmbWatchdogCfg"
        Me.cmbWatchdogCfg.Size = New System.Drawing.Size(89, 24)
        Me.cmbWatchdogCfg.TabIndex = 45
        '
        'lblWatchdogCfg
        '
        Me.lblWatchdogCfg.AutoSize = True
        Me.lblWatchdogCfg.Location = New System.Drawing.Point(19, 129)
        Me.lblWatchdogCfg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWatchdogCfg.Name = "lblWatchdogCfg"
        Me.lblWatchdogCfg.Size = New System.Drawing.Size(74, 17)
        Me.lblWatchdogCfg.TabIndex = 44
        Me.lblWatchdogCfg.Text = "WatchDog"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslConnection, Me.tslInterface})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(819, 25)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslConnection
        '
        Me.tslConnection.Image = CType(resources.GetObject("tslConnection.Image"), System.Drawing.Image)
        Me.tslConnection.Name = "tslConnection"
        Me.tslConnection.Size = New System.Drawing.Size(119, 20)
        Me.tslConnection.Text = "Disconnected"
        '
        'tslInterface
        '
        Me.tslInterface.Name = "tslInterface"
        Me.tslInterface.Size = New System.Drawing.Size(680, 20)
        Me.tslInterface.Spring = True
        Me.tslInterface.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCA9468.My.Resources.Resources.NXP_logo_s
        Me.PictureBox1.Location = New System.Drawing.Point(670, 56)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 62)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'lblChargerTimer
        '
        Me.lblChargerTimer.AutoSize = True
        Me.lblChargerTimer.Location = New System.Drawing.Point(19, 95)
        Me.lblChargerTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChargerTimer.Name = "lblChargerTimer"
        Me.lblChargerTimer.Size = New System.Drawing.Size(99, 17)
        Me.lblChargerTimer.TabIndex = 46
        Me.lblChargerTimer.Text = "Charger Timer"
        '
        'tmrWork
        '
        '
        'lblVFloatVal
        '
        Me.lblVFloatVal.AutoSize = True
        Me.lblVFloatVal.Location = New System.Drawing.Point(443, 198)
        Me.lblVFloatVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVFloatVal.Name = "lblVFloatVal"
        Me.lblVFloatVal.Size = New System.Drawing.Size(17, 17)
        Me.lblVFloatVal.TabIndex = 40
        Me.lblVFloatVal.Text = "V"
        '
        'trbVFloat
        '
        Me.trbVFloat.AutoSize = False
        Me.trbVFloat.Location = New System.Drawing.Point(183, 198)
        Me.trbVFloat.Margin = New System.Windows.Forms.Padding(4)
        Me.trbVFloat.Name = "trbVFloat"
        Me.trbVFloat.Size = New System.Drawing.Size(252, 31)
        Me.trbVFloat.TabIndex = 39
        '
        'lblVFloat
        '
        Me.lblVFloat.AutoSize = True
        Me.lblVFloat.Location = New System.Drawing.Point(19, 198)
        Me.lblVFloat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVFloat.Name = "lblVFloat"
        Me.lblVFloat.Size = New System.Drawing.Size(52, 17)
        Me.lblVFloat.TabIndex = 38
        Me.lblVFloat.Text = "V Float"
        '
        'cmbUVDelta
        '
        Me.cmbUVDelta.FormattingEnabled = True
        Me.cmbUVDelta.Location = New System.Drawing.Point(183, 24)
        Me.cmbUVDelta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUVDelta.Name = "cmbUVDelta"
        Me.cmbUVDelta.Size = New System.Drawing.Size(89, 24)
        Me.cmbUVDelta.TabIndex = 28
        '
        'tbpProt
        '
        Me.tbpProt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpProt.Controls.Add(Me.btnProtectRead)
        Me.tbpProt.Controls.Add(Me.btnProtectSet)
        Me.tbpProt.Controls.Add(Me.chkChargerTimerEn)
        Me.tbpProt.Controls.Add(Me.chkWatchDogEn)
        Me.tbpProt.Controls.Add(Me.chkBattMissShutDownEn)
        Me.tbpProt.Controls.Add(Me.chkMissBatteryDetEn)
        Me.tbpProt.Controls.Add(Me.chkIinForceIncrementEn)
        Me.tbpProt.Controls.Add(Me.cmbOVDelta)
        Me.tbpProt.Controls.Add(Me.lblOVDelta)
        Me.tbpProt.Controls.Add(Me.cmbChargerTimer)
        Me.tbpProt.Controls.Add(Me.lblChargerTimer)
        Me.tbpProt.Controls.Add(Me.cmbWatchdogCfg)
        Me.tbpProt.Controls.Add(Me.lblWatchdogCfg)
        Me.tbpProt.Controls.Add(Me.lblVFloatVal)
        Me.tbpProt.Controls.Add(Me.trbVFloat)
        Me.tbpProt.Controls.Add(Me.lblVFloat)
        Me.tbpProt.Controls.Add(Me.cmbUVDelta)
        Me.tbpProt.Controls.Add(Me.lblUVDelta)
        Me.tbpProt.Location = New System.Drawing.Point(4, 28)
        Me.tbpProt.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpProt.Name = "tbpProt"
        Me.tbpProt.Size = New System.Drawing.Size(546, 304)
        Me.tbpProt.TabIndex = 4
        Me.tbpProt.Text = "Protection"
        Me.tbpProt.UseVisualStyleBackColor = True
        '
        'btnProtectRead
        '
        Me.btnProtectRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnProtectRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProtectRead.Location = New System.Drawing.Point(462, 269)
        Me.btnProtectRead.Name = "btnProtectRead"
        Me.btnProtectRead.Size = New System.Drawing.Size(76, 26)
        Me.btnProtectRead.TabIndex = 59
        Me.btnProtectRead.Text = "Read"
        Me.btnProtectRead.UseVisualStyleBackColor = False
        '
        'btnProtectSet
        '
        Me.btnProtectSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProtectSet.Location = New System.Drawing.Point(379, 269)
        Me.btnProtectSet.Name = "btnProtectSet"
        Me.btnProtectSet.Size = New System.Drawing.Size(76, 26)
        Me.btnProtectSet.TabIndex = 58
        Me.btnProtectSet.Text = "Set"
        Me.btnProtectSet.UseVisualStyleBackColor = False
        '
        'lblUVDelta
        '
        Me.lblUVDelta.AutoSize = True
        Me.lblUVDelta.Location = New System.Drawing.Point(19, 26)
        Me.lblUVDelta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUVDelta.Name = "lblUVDelta"
        Me.lblUVDelta.Size = New System.Drawing.Size(60, 17)
        Me.lblUVDelta.TabIndex = 27
        Me.lblUVDelta.Text = "UVDelta"
        '
        'chkCfgEn
        '
        Me.chkCfgEn.AutoSize = True
        Me.chkCfgEn.Location = New System.Drawing.Point(327, 26)
        Me.chkCfgEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCfgEn.Name = "chkCfgEn"
        Me.chkCfgEn.Size = New System.Drawing.Size(66, 21)
        Me.chkCfgEn.TabIndex = 15
        Me.chkCfgEn.Text = "cfgEn"
        Me.chkCfgEn.UseVisualStyleBackColor = True
        '
        'pnlFunctions
        '
        Me.pnlFunctions.Controls.Add(Me.btnCurrentADCRead)
        Me.pnlFunctions.Controls.Add(Me.GrpBoxSTSD)
        Me.pnlFunctions.Controls.Add(Me.grpRaised)
        Me.pnlFunctions.Controls.Add(Me.GrpBoxSTSC)
        Me.pnlFunctions.Controls.Add(Me.grpAdcChannels)
        Me.pnlFunctions.Controls.Add(Me.TabControl2)
        Me.pnlFunctions.Location = New System.Drawing.Point(0, 117)
        Me.pnlFunctions.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFunctions.Name = "pnlFunctions"
        Me.pnlFunctions.Size = New System.Drawing.Size(814, 497)
        Me.pnlFunctions.TabIndex = 34
        '
        'btnCurrentADCRead
        '
        Me.btnCurrentADCRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCurrentADCRead.Location = New System.Drawing.Point(32, 464)
        Me.btnCurrentADCRead.Name = "btnCurrentADCRead"
        Me.btnCurrentADCRead.Size = New System.Drawing.Size(76, 26)
        Me.btnCurrentADCRead.TabIndex = 60
        Me.btnCurrentADCRead.Text = "Read"
        Me.btnCurrentADCRead.UseVisualStyleBackColor = False
        '
        'GrpBoxSTSD
        '
        Me.GrpBoxSTSD.Controls.Add(Me.txtIchgStatus)
        Me.GrpBoxSTSD.Location = New System.Drawing.Point(139, 351)
        Me.GrpBoxSTSD.Name = "GrpBoxSTSD"
        Me.GrpBoxSTSD.Size = New System.Drawing.Size(106, 71)
        Me.GrpBoxSTSD.TabIndex = 38
        Me.GrpBoxSTSD.TabStop = False
        Me.GrpBoxSTSD.Text = "I Charge"
        '
        'txtIchgStatus
        '
        Me.txtIchgStatus.Location = New System.Drawing.Point(7, 35)
        Me.txtIchgStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIchgStatus.Name = "txtIchgStatus"
        Me.txtIchgStatus.ReadOnly = True
        Me.txtIchgStatus.Size = New System.Drawing.Size(90, 22)
        Me.txtIchgStatus.TabIndex = 27
        '
        'grpRaised
        '
        Me.grpRaised.Controls.Add(Me.btnRaisedIntRead)
        Me.grpRaised.Controls.Add(Me.chkTimerInt)
        Me.grpRaised.Controls.Add(Me.chkADCDoneInt)
        Me.grpRaised.Controls.Add(Me.chkTempRegInt)
        Me.grpRaised.Controls.Add(Me.chkCtrlLimitInt)
        Me.grpRaised.Controls.Add(Me.chkChgPhaseInt)
        Me.grpRaised.Controls.Add(Me.chkNTCtempInt)
        Me.grpRaised.Controls.Add(Me.chkVOkInt)
        Me.grpRaised.Location = New System.Drawing.Point(16, 4)
        Me.grpRaised.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRaised.Name = "grpRaised"
        Me.grpRaised.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRaised.Size = New System.Drawing.Size(229, 336)
        Me.grpRaised.TabIndex = 28
        Me.grpRaised.TabStop = False
        Me.grpRaised.Text = "Raised interrupts"
        '
        'btnRaisedIntRead
        '
        Me.btnRaisedIntRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaisedIntRead.Location = New System.Drawing.Point(16, 303)
        Me.btnRaisedIntRead.Name = "btnRaisedIntRead"
        Me.btnRaisedIntRead.Size = New System.Drawing.Size(76, 26)
        Me.btnRaisedIntRead.TabIndex = 59
        Me.btnRaisedIntRead.Text = "Read"
        Me.btnRaisedIntRead.UseVisualStyleBackColor = False
        '
        'chkTimerInt
        '
        Me.chkTimerInt.Location = New System.Drawing.Point(19, 198)
        Me.chkTimerInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkTimerInt.Name = "chkTimerInt"
        Me.chkTimerInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkTimerInt.Size = New System.Drawing.Size(192, 21)
        Me.chkTimerInt.TabIndex = 43
        Me.chkTimerInt.Text = "Vbus OVP"
        Me.chkTimerInt.UseVisualStyleBackColor = True
        '
        'chkADCDoneInt
        '
        Me.chkADCDoneInt.Location = New System.Drawing.Point(19, 170)
        Me.chkADCDoneInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkADCDoneInt.Name = "chkADCDoneInt"
        Me.chkADCDoneInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkADCDoneInt.Size = New System.Drawing.Size(192, 21)
        Me.chkADCDoneInt.TabIndex = 42
        Me.chkADCDoneInt.Text = "Vbus OVP"
        Me.chkADCDoneInt.UseVisualStyleBackColor = True
        '
        'chkTempRegInt
        '
        Me.chkTempRegInt.Location = New System.Drawing.Point(19, 141)
        Me.chkTempRegInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkTempRegInt.Name = "chkTempRegInt"
        Me.chkTempRegInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkTempRegInt.Size = New System.Drawing.Size(192, 21)
        Me.chkTempRegInt.TabIndex = 41
        Me.chkTempRegInt.Text = "Vbus OVP"
        Me.chkTempRegInt.UseVisualStyleBackColor = True
        '
        'chkCtrlLimitInt
        '
        Me.chkCtrlLimitInt.Location = New System.Drawing.Point(19, 113)
        Me.chkCtrlLimitInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkCtrlLimitInt.Name = "chkCtrlLimitInt"
        Me.chkCtrlLimitInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkCtrlLimitInt.Size = New System.Drawing.Size(192, 21)
        Me.chkCtrlLimitInt.TabIndex = 40
        Me.chkCtrlLimitInt.Text = "Vbus OVP"
        Me.chkCtrlLimitInt.UseVisualStyleBackColor = True
        '
        'chkChgPhaseInt
        '
        Me.chkChgPhaseInt.Location = New System.Drawing.Point(19, 87)
        Me.chkChgPhaseInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkChgPhaseInt.Name = "chkChgPhaseInt"
        Me.chkChgPhaseInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkChgPhaseInt.Size = New System.Drawing.Size(192, 21)
        Me.chkChgPhaseInt.TabIndex = 38
        Me.chkChgPhaseInt.Text = "Vbus OVP"
        Me.chkChgPhaseInt.UseVisualStyleBackColor = True
        '
        'chkNTCtempInt
        '
        Me.chkNTCtempInt.Location = New System.Drawing.Point(19, 59)
        Me.chkNTCtempInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkNTCtempInt.Name = "chkNTCtempInt"
        Me.chkNTCtempInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkNTCtempInt.Size = New System.Drawing.Size(192, 21)
        Me.chkNTCtempInt.TabIndex = 37
        Me.chkNTCtempInt.Text = "Vbus OVP"
        Me.chkNTCtempInt.UseVisualStyleBackColor = True
        '
        'chkVOkInt
        '
        Me.chkVOkInt.Location = New System.Drawing.Point(19, 31)
        Me.chkVOkInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVOkInt.Name = "chkVOkInt"
        Me.chkVOkInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVOkInt.Size = New System.Drawing.Size(192, 21)
        Me.chkVOkInt.TabIndex = 36
        Me.chkVOkInt.Text = "V OK Int"
        Me.chkVOkInt.UseVisualStyleBackColor = True
        '
        'GrpBoxSTSC
        '
        Me.GrpBoxSTSC.Controls.Add(Me.txtIinStatus)
        Me.GrpBoxSTSC.Location = New System.Drawing.Point(16, 351)
        Me.GrpBoxSTSC.Name = "GrpBoxSTSC"
        Me.GrpBoxSTSC.Size = New System.Drawing.Size(108, 71)
        Me.GrpBoxSTSC.TabIndex = 37
        Me.GrpBoxSTSC.TabStop = False
        Me.GrpBoxSTSC.Text = "I Input"
        '
        'txtIinStatus
        '
        Me.txtIinStatus.Location = New System.Drawing.Point(16, 35)
        Me.txtIinStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIinStatus.Name = "txtIinStatus"
        Me.txtIinStatus.ReadOnly = True
        Me.txtIinStatus.Size = New System.Drawing.Size(79, 22)
        Me.txtIinStatus.TabIndex = 27
        '
        'grpAdcChannels
        '
        Me.grpAdcChannels.Controls.Add(Me.btnReadADC)
        Me.grpAdcChannels.Controls.Add(Me.txtBatteryVoltage)
        Me.grpAdcChannels.Controls.Add(Me.txtInputVoltage)
        Me.grpAdcChannels.Controls.Add(Me.txtChargeCurrent)
        Me.grpAdcChannels.Controls.Add(Me.txtInputCurrent)
        Me.grpAdcChannels.Controls.Add(Me.txtDieTemp)
        Me.grpAdcChannels.Controls.Add(Me.txtSysVoltage)
        Me.grpAdcChannels.Controls.Add(Me.txtNtcAdc)
        Me.grpAdcChannels.Controls.Add(Me.chkInputVoltageAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkBatteryVoltageAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkInputCurrentAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkChrageCurrentAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkDieTempAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkSysVoltageAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkNtcAdcEn)
        Me.grpAdcChannels.Location = New System.Drawing.Point(257, 352)
        Me.grpAdcChannels.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAdcChannels.Name = "grpAdcChannels"
        Me.grpAdcChannels.Padding = New System.Windows.Forms.Padding(4)
        Me.grpAdcChannels.Size = New System.Drawing.Size(546, 141)
        Me.grpAdcChannels.TabIndex = 30
        Me.grpAdcChannels.TabStop = False
        Me.grpAdcChannels.Text = "ADC channels"
        '
        'btnReadADC
        '
        Me.btnReadADC.BackColor = System.Drawing.SystemColors.Control
        Me.btnReadADC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReadADC.Location = New System.Drawing.Point(463, 113)
        Me.btnReadADC.Name = "btnReadADC"
        Me.btnReadADC.Size = New System.Drawing.Size(76, 26)
        Me.btnReadADC.TabIndex = 58
        Me.btnReadADC.Text = "Read"
        Me.btnReadADC.UseVisualStyleBackColor = False
        '
        'txtBatteryVoltage
        '
        Me.txtBatteryVoltage.Location = New System.Drawing.Point(417, 17)
        Me.txtBatteryVoltage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatteryVoltage.Name = "txtBatteryVoltage"
        Me.txtBatteryVoltage.ReadOnly = True
        Me.txtBatteryVoltage.Size = New System.Drawing.Size(103, 22)
        Me.txtBatteryVoltage.TabIndex = 26
        '
        'txtInputVoltage
        '
        Me.txtInputVoltage.Location = New System.Drawing.Point(417, 49)
        Me.txtInputVoltage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputVoltage.Name = "txtInputVoltage"
        Me.txtInputVoltage.ReadOnly = True
        Me.txtInputVoltage.Size = New System.Drawing.Size(103, 22)
        Me.txtInputVoltage.TabIndex = 26
        '
        'txtChargeCurrent
        '
        Me.txtChargeCurrent.Location = New System.Drawing.Point(163, 113)
        Me.txtChargeCurrent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChargeCurrent.Name = "txtChargeCurrent"
        Me.txtChargeCurrent.ReadOnly = True
        Me.txtChargeCurrent.Size = New System.Drawing.Size(95, 22)
        Me.txtChargeCurrent.TabIndex = 25
        '
        'txtInputCurrent
        '
        Me.txtInputCurrent.Location = New System.Drawing.Point(417, 84)
        Me.txtInputCurrent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInputCurrent.Name = "txtInputCurrent"
        Me.txtInputCurrent.ReadOnly = True
        Me.txtInputCurrent.Size = New System.Drawing.Size(103, 22)
        Me.txtInputCurrent.TabIndex = 25
        '
        'txtDieTemp
        '
        Me.txtDieTemp.Location = New System.Drawing.Point(163, 81)
        Me.txtDieTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDieTemp.Name = "txtDieTemp"
        Me.txtDieTemp.ReadOnly = True
        Me.txtDieTemp.Size = New System.Drawing.Size(95, 22)
        Me.txtDieTemp.TabIndex = 24
        '
        'txtSysVoltage
        '
        Me.txtSysVoltage.Location = New System.Drawing.Point(163, 49)
        Me.txtSysVoltage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSysVoltage.Name = "txtSysVoltage"
        Me.txtSysVoltage.ReadOnly = True
        Me.txtSysVoltage.Size = New System.Drawing.Size(95, 22)
        Me.txtSysVoltage.TabIndex = 23
        '
        'txtNtcAdc
        '
        Me.txtNtcAdc.Location = New System.Drawing.Point(163, 17)
        Me.txtNtcAdc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNtcAdc.Name = "txtNtcAdc"
        Me.txtNtcAdc.ReadOnly = True
        Me.txtNtcAdc.Size = New System.Drawing.Size(95, 22)
        Me.txtNtcAdc.TabIndex = 22
        '
        'chkInputVoltageAdcEn
        '
        Me.chkInputVoltageAdcEn.AutoSize = True
        Me.chkInputVoltageAdcEn.Location = New System.Drawing.Point(286, 49)
        Me.chkInputVoltageAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInputVoltageAdcEn.Name = "chkInputVoltageAdcEn"
        Me.chkInputVoltageAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkInputVoltageAdcEn.TabIndex = 19
        Me.chkInputVoltageAdcEn.Text = "Vbus OVP"
        Me.chkInputVoltageAdcEn.UseVisualStyleBackColor = True
        '
        'chkBatteryVoltageAdcEn
        '
        Me.chkBatteryVoltageAdcEn.AutoSize = True
        Me.chkBatteryVoltageAdcEn.Location = New System.Drawing.Point(286, 17)
        Me.chkBatteryVoltageAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBatteryVoltageAdcEn.Name = "chkBatteryVoltageAdcEn"
        Me.chkBatteryVoltageAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkBatteryVoltageAdcEn.TabIndex = 18
        Me.chkBatteryVoltageAdcEn.Text = "Vbus OVP"
        Me.chkBatteryVoltageAdcEn.UseVisualStyleBackColor = True
        '
        'chkInputCurrentAdcEn
        '
        Me.chkInputCurrentAdcEn.AutoSize = True
        Me.chkInputCurrentAdcEn.Location = New System.Drawing.Point(286, 81)
        Me.chkInputCurrentAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInputCurrentAdcEn.Name = "chkInputCurrentAdcEn"
        Me.chkInputCurrentAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkInputCurrentAdcEn.TabIndex = 17
        Me.chkInputCurrentAdcEn.Text = "Vbus OVP"
        Me.chkInputCurrentAdcEn.UseVisualStyleBackColor = True
        '
        'chkChrageCurrentAdcEn
        '
        Me.chkChrageCurrentAdcEn.AutoSize = True
        Me.chkChrageCurrentAdcEn.Location = New System.Drawing.Point(19, 117)
        Me.chkChrageCurrentAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChrageCurrentAdcEn.Name = "chkChrageCurrentAdcEn"
        Me.chkChrageCurrentAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkChrageCurrentAdcEn.TabIndex = 16
        Me.chkChrageCurrentAdcEn.Text = "Vbus OVP"
        Me.chkChrageCurrentAdcEn.UseVisualStyleBackColor = True
        '
        'chkDieTempAdcEn
        '
        Me.chkDieTempAdcEn.AutoSize = True
        Me.chkDieTempAdcEn.Location = New System.Drawing.Point(19, 85)
        Me.chkDieTempAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDieTempAdcEn.Name = "chkDieTempAdcEn"
        Me.chkDieTempAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkDieTempAdcEn.TabIndex = 15
        Me.chkDieTempAdcEn.Text = "Vbus OVP"
        Me.chkDieTempAdcEn.UseVisualStyleBackColor = True
        '
        'chkSysVoltageAdcEn
        '
        Me.chkSysVoltageAdcEn.AutoSize = True
        Me.chkSysVoltageAdcEn.Location = New System.Drawing.Point(19, 53)
        Me.chkSysVoltageAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSysVoltageAdcEn.Name = "chkSysVoltageAdcEn"
        Me.chkSysVoltageAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkSysVoltageAdcEn.TabIndex = 14
        Me.chkSysVoltageAdcEn.Text = "Vbus OVP"
        Me.chkSysVoltageAdcEn.UseVisualStyleBackColor = True
        '
        'chkNtcAdcEn
        '
        Me.chkNtcAdcEn.AutoSize = True
        Me.chkNtcAdcEn.Location = New System.Drawing.Point(19, 21)
        Me.chkNtcAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNtcAdcEn.Name = "chkNtcAdcEn"
        Me.chkNtcAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkNtcAdcEn.TabIndex = 13
        Me.chkNtcAdcEn.Text = "Vbus OVP"
        Me.chkNtcAdcEn.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.tbpControl)
        Me.TabControl2.Controls.Add(Me.tbpAdc)
        Me.TabControl2.Controls.Add(Me.tbpInt)
        Me.TabControl2.Controls.Add(Me.tbpEvents)
        Me.TabControl2.Controls.Add(Me.tbpProt)
        Me.TabControl2.Controls.Add(Me.tbpThermal)
        Me.TabControl2.Location = New System.Drawing.Point(253, 8)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(554, 336)
        Me.TabControl2.TabIndex = 29
        '
        'tbpControl
        '
        Me.tbpControl.BackColor = System.Drawing.SystemColors.Control
        Me.tbpControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpControl.Controls.Add(Me.btnCtlRead)
        Me.tbpControl.Controls.Add(Me.btnCtlSet)
        Me.tbpControl.Controls.Add(Me.chkLimitIncrementEn)
        Me.tbpControl.Controls.Add(Me.chkRevCurrentDet)
        Me.tbpControl.Controls.Add(Me.chkStandbyEn)
        Me.tbpControl.Controls.Add(Me.lblSwFreqVal)
        Me.tbpControl.Controls.Add(Me.trbSwFreqCfg)
        Me.tbpControl.Controls.Add(Me.lblSwFreqCfg)
        Me.tbpControl.Controls.Add(Me.lblIinCfgVal)
        Me.tbpControl.Controls.Add(Me.trbIinCfg)
        Me.tbpControl.Controls.Add(Me.lblIinCfg)
        Me.tbpControl.Controls.Add(Me.lblIchgCfgVal)
        Me.tbpControl.Controls.Add(Me.trbIchgCfg)
        Me.tbpControl.Controls.Add(Me.lblIchgCfg)
        Me.tbpControl.Controls.Add(Me.chkCfgEn)
        Me.tbpControl.Controls.Add(Me.cmbIinSoftStep)
        Me.tbpControl.Controls.Add(Me.lblIinSoftStep)
        Me.tbpControl.Controls.Add(Me.cmbChgSoftStep)
        Me.tbpControl.Controls.Add(Me.lblchgSoftStep)
        Me.tbpControl.Controls.Add(Me.cmbSenseR)
        Me.tbpControl.Controls.Add(Me.lblSenseR)
        Me.tbpControl.Location = New System.Drawing.Point(4, 28)
        Me.tbpControl.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpControl.Name = "tbpControl"
        Me.tbpControl.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpControl.Size = New System.Drawing.Size(546, 304)
        Me.tbpControl.TabIndex = 1
        Me.tbpControl.Text = "Control"
        '
        'btnCtlRead
        '
        Me.btnCtlRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnCtlRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCtlRead.Location = New System.Drawing.Point(462, 269)
        Me.btnCtlRead.Name = "btnCtlRead"
        Me.btnCtlRead.Size = New System.Drawing.Size(76, 26)
        Me.btnCtlRead.TabIndex = 57
        Me.btnCtlRead.Text = "Read"
        Me.btnCtlRead.UseVisualStyleBackColor = False
        '
        'btnCtlSet
        '
        Me.btnCtlSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCtlSet.Location = New System.Drawing.Point(379, 269)
        Me.btnCtlSet.Name = "btnCtlSet"
        Me.btnCtlSet.Size = New System.Drawing.Size(76, 26)
        Me.btnCtlSet.TabIndex = 56
        Me.btnCtlSet.Text = "Set"
        Me.btnCtlSet.UseVisualStyleBackColor = False
        '
        'chkLimitIncrementEn
        '
        Me.chkLimitIncrementEn.AutoSize = True
        Me.chkLimitIncrementEn.Location = New System.Drawing.Point(327, 116)
        Me.chkLimitIncrementEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLimitIncrementEn.Name = "chkLimitIncrementEn"
        Me.chkLimitIncrementEn.Size = New System.Drawing.Size(181, 21)
        Me.chkLimitIncrementEn.TabIndex = 55
        Me.chkLimitIncrementEn.Text = "Limit Increment Enabled"
        Me.chkLimitIncrementEn.UseVisualStyleBackColor = True
        '
        'cmbIinSoftStep
        '
        Me.cmbIinSoftStep.FormattingEnabled = True
        Me.cmbIinSoftStep.Location = New System.Drawing.Point(183, 92)
        Me.cmbIinSoftStep.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbIinSoftStep.Name = "cmbIinSoftStep"
        Me.cmbIinSoftStep.Size = New System.Drawing.Size(89, 24)
        Me.cmbIinSoftStep.TabIndex = 6
        '
        'lblIinSoftStep
        '
        Me.lblIinSoftStep.AutoSize = True
        Me.lblIinSoftStep.Location = New System.Drawing.Point(19, 95)
        Me.lblIinSoftStep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIinSoftStep.Name = "lblIinSoftStep"
        Me.lblIinSoftStep.Size = New System.Drawing.Size(76, 17)
        Me.lblIinSoftStep.TabIndex = 5
        Me.lblIinSoftStep.Text = "iinSoftStep"
        '
        'cmbChgSoftStep
        '
        Me.cmbChgSoftStep.FormattingEnabled = True
        Me.cmbChgSoftStep.Location = New System.Drawing.Point(183, 58)
        Me.cmbChgSoftStep.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbChgSoftStep.Name = "cmbChgSoftStep"
        Me.cmbChgSoftStep.Size = New System.Drawing.Size(89, 24)
        Me.cmbChgSoftStep.TabIndex = 4
        '
        'lblchgSoftStep
        '
        Me.lblchgSoftStep.AutoSize = True
        Me.lblchgSoftStep.Location = New System.Drawing.Point(19, 61)
        Me.lblchgSoftStep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblchgSoftStep.Name = "lblchgSoftStep"
        Me.lblchgSoftStep.Size = New System.Drawing.Size(85, 17)
        Me.lblchgSoftStep.TabIndex = 3
        Me.lblchgSoftStep.Text = "chgSoftStep"
        '
        'cmbSenseR
        '
        Me.cmbSenseR.FormattingEnabled = True
        Me.cmbSenseR.Location = New System.Drawing.Point(183, 24)
        Me.cmbSenseR.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSenseR.Name = "cmbSenseR"
        Me.cmbSenseR.Size = New System.Drawing.Size(89, 24)
        Me.cmbSenseR.TabIndex = 2
        '
        'lblSenseR
        '
        Me.lblSenseR.AutoSize = True
        Me.lblSenseR.Location = New System.Drawing.Point(19, 26)
        Me.lblSenseR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSenseR.Name = "lblSenseR"
        Me.lblSenseR.Size = New System.Drawing.Size(109, 17)
        Me.lblSenseR.TabIndex = 1
        Me.lblSenseR.Text = "Sensor Resistor"
        '
        'tbpThermal
        '
        Me.tbpThermal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpThermal.Controls.Add(Me.btnThermalRead)
        Me.tbpThermal.Controls.Add(Me.btnThermalSet)
        Me.tbpThermal.Controls.Add(Me.chkTempMaxEn)
        Me.tbpThermal.Controls.Add(Me.chkNtcProtectionEn)
        Me.tbpThermal.Controls.Add(Me.chkTempRegEn)
        Me.tbpThermal.Controls.Add(Me.cmbTempReg)
        Me.tbpThermal.Controls.Add(Me.lblTempReg)
        Me.tbpThermal.Controls.Add(Me.cmbTempDelta)
        Me.tbpThermal.Controls.Add(Me.lblTempDelta)
        Me.tbpThermal.Controls.Add(Me.lblNTCThresholdVal)
        Me.tbpThermal.Controls.Add(Me.trbNTCThreshold)
        Me.tbpThermal.Controls.Add(Me.lblNTCThreshold)
        Me.tbpThermal.Location = New System.Drawing.Point(4, 28)
        Me.tbpThermal.Name = "tbpThermal"
        Me.tbpThermal.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpThermal.Size = New System.Drawing.Size(546, 304)
        Me.tbpThermal.TabIndex = 5
        Me.tbpThermal.Text = "Thermal"
        Me.tbpThermal.UseVisualStyleBackColor = True
        '
        'btnThermalRead
        '
        Me.btnThermalRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnThermalRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnThermalRead.Location = New System.Drawing.Point(462, 269)
        Me.btnThermalRead.Name = "btnThermalRead"
        Me.btnThermalRead.Size = New System.Drawing.Size(76, 26)
        Me.btnThermalRead.TabIndex = 64
        Me.btnThermalRead.Text = "Read"
        Me.btnThermalRead.UseVisualStyleBackColor = False
        '
        'btnThermalSet
        '
        Me.btnThermalSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnThermalSet.Location = New System.Drawing.Point(379, 269)
        Me.btnThermalSet.Name = "btnThermalSet"
        Me.btnThermalSet.Size = New System.Drawing.Size(76, 26)
        Me.btnThermalSet.TabIndex = 63
        Me.btnThermalSet.Text = "Set"
        Me.btnThermalSet.UseVisualStyleBackColor = False
        '
        'chkTempMaxEn
        '
        Me.chkTempMaxEn.AutoSize = True
        Me.chkTempMaxEn.Location = New System.Drawing.Point(327, 86)
        Me.chkTempMaxEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTempMaxEn.Name = "chkTempMaxEn"
        Me.chkTempMaxEn.Size = New System.Drawing.Size(95, 21)
        Me.chkTempMaxEn.TabIndex = 62
        Me.chkTempMaxEn.Text = "Vbus OVP"
        Me.chkTempMaxEn.UseVisualStyleBackColor = True
        '
        'chkNtcProtectionEn
        '
        Me.chkNtcProtectionEn.AutoSize = True
        Me.chkNtcProtectionEn.Location = New System.Drawing.Point(327, 56)
        Me.chkNtcProtectionEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNtcProtectionEn.Name = "chkNtcProtectionEn"
        Me.chkNtcProtectionEn.Size = New System.Drawing.Size(95, 21)
        Me.chkNtcProtectionEn.TabIndex = 61
        Me.chkNtcProtectionEn.Text = "Vbus OVP"
        Me.chkNtcProtectionEn.UseVisualStyleBackColor = True
        '
        'chkTempRegEn
        '
        Me.chkTempRegEn.AutoSize = True
        Me.chkTempRegEn.Location = New System.Drawing.Point(327, 26)
        Me.chkTempRegEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTempRegEn.Name = "chkTempRegEn"
        Me.chkTempRegEn.Size = New System.Drawing.Size(95, 21)
        Me.chkTempRegEn.TabIndex = 60
        Me.chkTempRegEn.Text = "Vbus OVP"
        Me.chkTempRegEn.UseVisualStyleBackColor = True
        '
        'cmbTempReg
        '
        Me.cmbTempReg.FormattingEnabled = True
        Me.cmbTempReg.Location = New System.Drawing.Point(183, 24)
        Me.cmbTempReg.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTempReg.Name = "cmbTempReg"
        Me.cmbTempReg.Size = New System.Drawing.Size(89, 24)
        Me.cmbTempReg.TabIndex = 59
        '
        'lblTempReg
        '
        Me.lblTempReg.AutoSize = True
        Me.lblTempReg.Location = New System.Drawing.Point(19, 26)
        Me.lblTempReg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTempReg.Name = "lblTempReg"
        Me.lblTempReg.Size = New System.Drawing.Size(90, 17)
        Me.lblTempReg.TabIndex = 58
        Me.lblTempReg.Text = "Thermal Reg"
        '
        'cmbTempDelta
        '
        Me.cmbTempDelta.FormattingEnabled = True
        Me.cmbTempDelta.Location = New System.Drawing.Point(183, 58)
        Me.cmbTempDelta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTempDelta.Name = "cmbTempDelta"
        Me.cmbTempDelta.Size = New System.Drawing.Size(89, 24)
        Me.cmbTempDelta.TabIndex = 57
        '
        'lblTempDelta
        '
        Me.lblTempDelta.AutoSize = True
        Me.lblTempDelta.Location = New System.Drawing.Point(19, 61)
        Me.lblTempDelta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTempDelta.Name = "lblTempDelta"
        Me.lblTempDelta.Size = New System.Drawing.Size(81, 17)
        Me.lblTempDelta.TabIndex = 56
        Me.lblTempDelta.Text = "Temp Delta"
        '
        'lblNTCThresholdVal
        '
        Me.lblNTCThresholdVal.AutoSize = True
        Me.lblNTCThresholdVal.Location = New System.Drawing.Point(432, 198)
        Me.lblNTCThresholdVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNTCThresholdVal.Name = "lblNTCThresholdVal"
        Me.lblNTCThresholdVal.Size = New System.Drawing.Size(51, 17)
        Me.lblNTCThresholdVal.TabIndex = 46
        Me.lblNTCThresholdVal.Text = "Label8"
        '
        'trbNTCThreshold
        '
        Me.trbNTCThreshold.AutoSize = False
        Me.trbNTCThreshold.Location = New System.Drawing.Point(183, 198)
        Me.trbNTCThreshold.Margin = New System.Windows.Forms.Padding(4)
        Me.trbNTCThreshold.Name = "trbNTCThreshold"
        Me.trbNTCThreshold.Size = New System.Drawing.Size(252, 31)
        Me.trbNTCThreshold.TabIndex = 45
        '
        'lblNTCThreshold
        '
        Me.lblNTCThreshold.AutoSize = True
        Me.lblNTCThreshold.Location = New System.Drawing.Point(19, 198)
        Me.lblNTCThreshold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNTCThreshold.Name = "lblNTCThreshold"
        Me.lblNTCThreshold.Size = New System.Drawing.Size(66, 17)
        Me.lblNTCThreshold.TabIndex = 44
        Me.lblNTCThreshold.Text = "NtcThres"
        '
        'tsbRefresh
        '
        Me.tsbRefresh.Image = Global.PCA9468.My.Resources.Resources.clock
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(110, 25)
        Me.tsbRefresh.Text = "Auto refresh"
        Me.tsbRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 28)
        '
        'tsbRegisters
        '
        Me.tsbRegisters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRegisters.Image = Global.PCA9468.My.Resources.Resources.table
        Me.tsbRegisters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRegisters.Name = "tsbRegisters"
        Me.tsbRegisters.Size = New System.Drawing.Size(24, 25)
        Me.tsbRegisters.Text = "Register map"
        '
        'tsbFunctions
        '
        Me.tsbFunctions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFunctions.Image = CType(resources.GetObject("tsbFunctions.Image"), System.Drawing.Image)
        Me.tsbFunctions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFunctions.Name = "tsbFunctions"
        Me.tsbFunctions.Size = New System.Drawing.Size(24, 25)
        Me.tsbFunctions.Text = "Functions"
        Me.tsbFunctions.ToolTipText = "Functional view"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 28)
        '
        'tsbReset
        '
        Me.tsbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReset.Image = Global.PCA9468.My.Resources.Resources.counter_reset
        Me.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReset.Name = "tsbReset"
        Me.tsbReset.Size = New System.Drawing.Size(24, 25)
        Me.tsbReset.Text = "Reset device"
        Me.tsbReset.ToolTipText = "Reset PCA949x"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
        '
        'tsbRead
        '
        Me.tsbRead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRead.Image = Global.PCA9468.My.Resources.Resources.spectacle
        Me.tsbRead.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRead.Name = "tsbRead"
        Me.tsbRead.Size = New System.Drawing.Size(24, 25)
        Me.tsbRead.Text = "Read all"
        Me.tsbRead.ToolTipText = "Read all registers"
        '
        'tsbWrite
        '
        Me.tsbWrite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbWrite.Image = Global.PCA9468.My.Resources.Resources.pencil__arrow
        Me.tsbWrite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbWrite.Name = "tsbWrite"
        Me.tsbWrite.Size = New System.Drawing.Size(24, 25)
        Me.tsbWrite.Text = "Write all"
        Me.tsbWrite.ToolTipText = "Write all registers"
        '
        'theToolbar
        '
        Me.theToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.theToolbar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.theToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbWrite, Me.tsbRead, Me.ToolStripSeparator4, Me.tsbReset, Me.ToolStripSeparator5, Me.tsbFunctions, Me.tsbRegisters, Me.ToolStripSeparator6, Me.tsbRefresh, Me.tscRefresh})
        Me.theToolbar.Location = New System.Drawing.Point(0, 28)
        Me.theToolbar.Name = "theToolbar"
        Me.theToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.theToolbar.Size = New System.Drawing.Size(819, 28)
        Me.theToolbar.TabIndex = 33
        Me.theToolbar.Text = "ToolStrip1"
        '
        'tscRefresh
        '
        Me.tscRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscRefresh.Items.AddRange(New Object() {"Disabled", "1 / second", "2 / second", "4 / second"})
        Me.tscRefresh.Name = "tscRefresh"
        Me.tscRefresh.Size = New System.Drawing.Size(160, 28)
        Me.tscRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'tsmManual
        '
        Me.tsmManual.Name = "tsmManual"
        Me.tsmManual.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.tsmManual.Size = New System.Drawing.Size(258, 24)
        Me.tsmManual.Text = "Open the User Manual..."
        Me.tsmManual.ToolTipText = "Open the User Manual with an external PDF viewer"
        '
        'tsmAbout
        '
        Me.tsmAbout.Name = "tsmAbout"
        Me.tsmAbout.ShortcutKeyDisplayString = ""
        Me.tsmAbout.Size = New System.Drawing.Size(258, 24)
        Me.tsmAbout.Text = "About..."
        Me.tsmAbout.ToolTipText = "Version and file information"
        '
        'tsmHelp
        '
        Me.tsmHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAbout, Me.tsmManual})
        Me.tsmHelp.Name = "tsmHelp"
        Me.tsmHelp.Size = New System.Drawing.Size(53, 24)
        Me.tsmHelp.Text = "&Help"
        '
        'tsmInterval4
        '
        Me.tsmInterval4.Name = "tsmInterval4"
        Me.tsmInterval4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.tsmInterval4.Size = New System.Drawing.Size(260, 24)
        Me.tsmInterval4.Text = "&Four times a second"
        Me.tsmInterval4.ToolTipText = "Read ADC and interrupts four times a second"
        '
        'tsmInterval1
        '
        Me.tsmInterval1.Name = "tsmInterval1"
        Me.tsmInterval1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.tsmInterval1.Size = New System.Drawing.Size(260, 24)
        Me.tsmInterval1.Text = "&Once a second"
        Me.tsmInterval1.ToolTipText = "Read ADC and interrupts once a second"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(257, 6)
        '
        'tsmInterval0
        '
        Me.tsmInterval0.Name = "tsmInterval0"
        Me.tsmInterval0.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.tsmInterval0.Size = New System.Drawing.Size(260, 24)
        Me.tsmInterval0.Text = "&Disabled"
        Me.tsmInterval0.ToolTipText = "Registers are read manually"
        '
        'tsmRefresh
        '
        Me.tsmRefresh.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmInterval0, Me.ToolStripSeparator3, Me.tsmInterval1, Me.tsmInterval2, Me.tsmInterval4})
        Me.tsmRefresh.Name = "tsmRefresh"
        Me.tsmRefresh.Size = New System.Drawing.Size(159, 24)
        Me.tsmRefresh.Text = "&Auto refresh"
        Me.tsmRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'tsmInterval2
        '
        Me.tsmInterval2.Name = "tsmInterval2"
        Me.tsmInterval2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.tsmInterval2.Size = New System.Drawing.Size(260, 24)
        Me.tsmInterval2.Text = "&Twice a second"
        Me.tsmInterval2.ToolTipText = "Read ADC and interrupts twice a second"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(156, 6)
        '
        'tsmReset
        '
        Me.tsmReset.Name = "tsmReset"
        Me.tsmReset.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.tsmReset.Size = New System.Drawing.Size(159, 24)
        Me.tsmReset.Text = "Re&set"
        Me.tsmReset.ToolTipText = "Reset PCA949x to defaults"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(156, 6)
        '
        'tsmWrite
        '
        Me.tsmWrite.Name = "tsmWrite"
        Me.tsmWrite.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.tsmWrite.Size = New System.Drawing.Size(159, 24)
        Me.tsmWrite.Text = "&Write all"
        Me.tsmWrite.ToolTipText = "Write all registers"
        '
        'tsmRead
        '
        Me.tsmRead.Name = "tsmRead"
        Me.tsmRead.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.tsmRead.Size = New System.Drawing.Size(159, 24)
        Me.tsmRead.Text = "&Read all"
        Me.tsmRead.ToolTipText = "Read all registers"
        '
        'tsmIO
        '
        Me.tsmIO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmRead, Me.tsmWrite, Me.ToolStripSeparator1, Me.tsmReset, Me.ToolStripSeparator2, Me.tsmRefresh})
        Me.tsmIO.Name = "tsmIO"
        Me.tsmIO.Size = New System.Drawing.Size(36, 24)
        Me.tsmIO.Text = "&IO"
        '
        'tsmRegisters
        '
        Me.tsmRegisters.Name = "tsmRegisters"
        Me.tsmRegisters.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.tsmRegisters.Size = New System.Drawing.Size(190, 24)
        Me.tsmRegisters.Text = "&Register map"
        Me.tsmRegisters.ToolTipText = "Registers values in hexadecimal and binary"
        '
        'tsmFunctions
        '
        Me.tsmFunctions.Name = "tsmFunctions"
        Me.tsmFunctions.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.tsmFunctions.Size = New System.Drawing.Size(190, 24)
        Me.tsmFunctions.Text = "&Functions"
        Me.tsmFunctions.ToolTipText = "Functional view of register map"
        '
        'tsmView
        '
        Me.tsmView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFunctions, Me.tsmRegisters})
        Me.tsmView.Name = "tsmView"
        Me.tsmView.Size = New System.Drawing.Size(53, 24)
        Me.tsmView.Text = "&View"
        '
        'TheMenu
        '
        Me.TheMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TheMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmView, Me.tsmIO, Me.tsmHelp})
        Me.TheMenu.Location = New System.Drawing.Point(0, 0)
        Me.TheMenu.Name = "TheMenu"
        Me.TheMenu.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.TheMenu.Size = New System.Drawing.Size(819, 28)
        Me.TheMenu.TabIndex = 32
        Me.TheMenu.Text = "MenuStrip1"
        '
        'pnlRegisters
        '
        Me.pnlRegisters.Location = New System.Drawing.Point(0, 117)
        Me.pnlRegisters.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlRegisters.Name = "pnlRegisters"
        Me.pnlRegisters.Size = New System.Drawing.Size(814, 497)
        Me.pnlRegisters.TabIndex = 38
        Me.pnlRegisters.Visible = False
        '
        'txtTimerSts
        '
        Me.txtTimerSts.Location = New System.Drawing.Point(38, 191)
        Me.txtTimerSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimerSts.Name = "txtTimerSts"
        Me.txtTimerSts.ReadOnly = True
        Me.txtTimerSts.Size = New System.Drawing.Size(177, 22)
        Me.txtTimerSts.TabIndex = 50
        '
        'txtADCDoneSts
        '
        Me.txtADCDoneSts.Location = New System.Drawing.Point(38, 162)
        Me.txtADCDoneSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtADCDoneSts.Name = "txtADCDoneSts"
        Me.txtADCDoneSts.ReadOnly = True
        Me.txtADCDoneSts.Size = New System.Drawing.Size(177, 22)
        Me.txtADCDoneSts.TabIndex = 49
        '
        'txtTempRegSts
        '
        Me.txtTempRegSts.Location = New System.Drawing.Point(38, 134)
        Me.txtTempRegSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTempRegSts.Name = "txtTempRegSts"
        Me.txtTempRegSts.ReadOnly = True
        Me.txtTempRegSts.Size = New System.Drawing.Size(177, 22)
        Me.txtTempRegSts.TabIndex = 48
        '
        'txtCtrlLimitSts
        '
        Me.txtCtrlLimitSts.Location = New System.Drawing.Point(38, 104)
        Me.txtCtrlLimitSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCtrlLimitSts.Name = "txtCtrlLimitSts"
        Me.txtCtrlLimitSts.ReadOnly = True
        Me.txtCtrlLimitSts.Size = New System.Drawing.Size(177, 22)
        Me.txtCtrlLimitSts.TabIndex = 47
        '
        'txtChgPhaseSts
        '
        Me.txtChgPhaseSts.Location = New System.Drawing.Point(38, 78)
        Me.txtChgPhaseSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChgPhaseSts.Name = "txtChgPhaseSts"
        Me.txtChgPhaseSts.ReadOnly = True
        Me.txtChgPhaseSts.Size = New System.Drawing.Size(177, 22)
        Me.txtChgPhaseSts.TabIndex = 46
        '
        'txtNtcTempSts
        '
        Me.txtNtcTempSts.Location = New System.Drawing.Point(38, 48)
        Me.txtNtcTempSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNtcTempSts.Name = "txtNtcTempSts"
        Me.txtNtcTempSts.ReadOnly = True
        Me.txtNtcTempSts.Size = New System.Drawing.Size(177, 22)
        Me.txtNtcTempSts.TabIndex = 45
        '
        'txtVOKSts
        '
        Me.txtVOKSts.Location = New System.Drawing.Point(38, 22)
        Me.txtVOKSts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVOKSts.Name = "txtVOKSts"
        Me.txtVOKSts.ReadOnly = True
        Me.txtVOKSts.Size = New System.Drawing.Size(177, 22)
        Me.txtVOKSts.TabIndex = 44
        '
        'FrmMain_mp12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 642)
        Me.Controls.Add(Me.pnlFunctions)
        Me.Controls.Add(Me.grpDevice)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.theToolbar)
        Me.Controls.Add(Me.TheMenu)
        Me.Controls.Add(Me.pnlRegisters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.TheMenu
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain_mp12"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PCA9468 (MP12)"
        Me.tbpInt.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbpEvents.ResumeLayout(False)
        Me.GrpBoxSYSB.ResumeLayout(False)
        Me.GrpBoxSYSB.PerformLayout()
        Me.GrpBoxSTSA.ResumeLayout(False)
        Me.GrpBoxSTSA.PerformLayout()
        CType(Me.trbSwFreqCfg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbIinCfg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbIchgCfg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpAdc.ResumeLayout(False)
        Me.tbpAdc.PerformLayout()
        Me.grpDevice.ResumeLayout(False)
        Me.grpDevice.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbVFloat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpProt.ResumeLayout(False)
        Me.tbpProt.PerformLayout()
        Me.pnlFunctions.ResumeLayout(False)
        Me.GrpBoxSTSD.ResumeLayout(False)
        Me.GrpBoxSTSD.PerformLayout()
        Me.grpRaised.ResumeLayout(False)
        Me.GrpBoxSTSC.ResumeLayout(False)
        Me.GrpBoxSTSC.PerformLayout()
        Me.grpAdcChannels.ResumeLayout(False)
        Me.grpAdcChannels.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tbpControl.ResumeLayout(False)
        Me.tbpControl.PerformLayout()
        Me.tbpThermal.ResumeLayout(False)
        Me.tbpThermal.PerformLayout()
        CType(Me.trbNTCThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.theToolbar.ResumeLayout(False)
        Me.theToolbar.PerformLayout()
        Me.TheMenu.ResumeLayout(False)
        Me.TheMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbpInt As System.Windows.Forms.TabPage
    Friend WithEvents chkTimerMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkADCDoneMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkTempRegMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkCtrlLimitMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkChgPhaseMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkNtcTempMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkVOkMask As System.Windows.Forms.CheckBox
    Friend WithEvents lblForceAdcMode As System.Windows.Forms.Label
    Friend WithEvents cmbAdcOscSel As System.Windows.Forms.ComboBox
    Friend WithEvents lblOscSel As System.Windows.Forms.Label
    Friend WithEvents tbpEvents As System.Windows.Forms.TabPage
    Friend WithEvents GrpBoxSTSA As System.Windows.Forms.GroupBox
    Friend WithEvents chkVinOvSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkVinUvSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkIinLoopSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkChgLoopSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkVFLTLoopSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoutUvSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbatOvSts As System.Windows.Forms.CheckBox
    Friend WithEvents lblHiberDelay As System.Windows.Forms.Label
    Friend WithEvents cmbAdcForceMode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAdcOffset As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdcOffset As System.Windows.Forms.Label
    Friend WithEvents chkRevCurrentDet As System.Windows.Forms.CheckBox
    Friend WithEvents chkStandbyEn As System.Windows.Forms.CheckBox
    Friend WithEvents lblSwFreqVal As System.Windows.Forms.Label
    Friend WithEvents trbSwFreqCfg As System.Windows.Forms.TrackBar
    Friend WithEvents lblSwFreqCfg As System.Windows.Forms.Label
    Friend WithEvents lblIinCfgVal As System.Windows.Forms.Label
    Friend WithEvents trbIinCfg As System.Windows.Forms.TrackBar
    Friend WithEvents lblIinCfg As System.Windows.Forms.Label
    Friend WithEvents lblIchgCfgVal As System.Windows.Forms.Label
    Friend WithEvents trbIchgCfg As System.Windows.Forms.TrackBar
    Friend WithEvents lblIchgCfg As System.Windows.Forms.Label
    Friend WithEvents chkAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents tbpAdc As System.Windows.Forms.TabPage
    Friend WithEvents cmbAdcHibDelay As System.Windows.Forms.ComboBox
    Friend WithEvents grpDevice As System.Windows.Forms.GroupBox
    Friend WithEvents lblRev As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAddr As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkChargerTimerEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkWatchDogEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkBattMissShutDownEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkMissBatteryDetEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkIinForceIncrementEn As System.Windows.Forms.CheckBox
    Friend WithEvents cmbOVDelta As System.Windows.Forms.ComboBox
    Friend WithEvents lblOVDelta As System.Windows.Forms.Label
    Friend WithEvents cmbChargerTimer As System.Windows.Forms.ComboBox
    Friend WithEvents cmbWatchdogCfg As System.Windows.Forms.ComboBox
    Friend WithEvents lblWatchdogCfg As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslConnection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslInterface As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblChargerTimer As System.Windows.Forms.Label
    Friend WithEvents tmrWork As System.Windows.Forms.Timer
    Friend WithEvents lblVFloatVal As System.Windows.Forms.Label
    Friend WithEvents trbVFloat As System.Windows.Forms.TrackBar
    Friend WithEvents lblVFloat As System.Windows.Forms.Label
    Friend WithEvents cmbUVDelta As System.Windows.Forms.ComboBox
    Friend WithEvents tbpProt As System.Windows.Forms.TabPage
    Friend WithEvents lblUVDelta As System.Windows.Forms.Label
    Friend WithEvents chkCfgEn As System.Windows.Forms.CheckBox
    Friend WithEvents pnlFunctions As System.Windows.Forms.Panel
    Friend WithEvents grpRaised As System.Windows.Forms.GroupBox
    Friend WithEvents chkTimerInt As System.Windows.Forms.CheckBox
    Friend WithEvents chkADCDoneInt As System.Windows.Forms.CheckBox
    Friend WithEvents chkTempRegInt As System.Windows.Forms.CheckBox
    Friend WithEvents chkCtrlLimitInt As System.Windows.Forms.CheckBox
    Friend WithEvents chkChgPhaseInt As System.Windows.Forms.CheckBox
    Friend WithEvents chkNTCtempInt As System.Windows.Forms.CheckBox
    Friend WithEvents chkVOkInt As System.Windows.Forms.CheckBox
    Friend WithEvents grpAdcChannels As System.Windows.Forms.GroupBox
    Friend WithEvents txtBatteryVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtInputVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtChargeCurrent As System.Windows.Forms.TextBox
    Friend WithEvents txtInputCurrent As System.Windows.Forms.TextBox
    Friend WithEvents txtDieTemp As System.Windows.Forms.TextBox
    Friend WithEvents txtSysVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtNtcAdc As System.Windows.Forms.TextBox
    Friend WithEvents chkInputVoltageAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkBatteryVoltageAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkInputCurrentAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkChrageCurrentAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkDieTempAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkSysVoltageAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkNtcAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tbpControl As System.Windows.Forms.TabPage
    Friend WithEvents cmbIinSoftStep As System.Windows.Forms.ComboBox
    Friend WithEvents lblIinSoftStep As System.Windows.Forms.Label
    Friend WithEvents cmbChgSoftStep As System.Windows.Forms.ComboBox
    Friend WithEvents lblchgSoftStep As System.Windows.Forms.Label
    Friend WithEvents cmbSenseR As System.Windows.Forms.ComboBox
    Friend WithEvents lblSenseR As System.Windows.Forms.Label
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRegisters As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFunctions As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbReset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRead As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbWrite As System.Windows.Forms.ToolStripButton
    Friend WithEvents theToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents tscRefresh As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsmManual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmInterval4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmInterval1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmInterval0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmInterval2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmWrite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRead As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmIO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRegisters As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFunctions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TheMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents chkLimitIncrementEn As System.Windows.Forms.CheckBox
    Friend WithEvents GrpBoxSTSD As System.Windows.Forms.GroupBox
    Friend WithEvents txtIchgStatus As System.Windows.Forms.TextBox
    Friend WithEvents GrpBoxSTSC As System.Windows.Forms.GroupBox
    Friend WithEvents txtIinStatus As System.Windows.Forms.TextBox
    Friend WithEvents GrpBoxSYSB As System.Windows.Forms.GroupBox
    Friend WithEvents chkStandbyStateSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkChargeTmrSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkBatteryMissSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkOcpFastSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkOcpAvgSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkActiveStateSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkShutDownStateSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkWatchdogTmrSts As System.Windows.Forms.CheckBox
    Friend WithEvents tbpThermal As System.Windows.Forms.TabPage
    Friend WithEvents chkTempMaxEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkNtcProtectionEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkTempRegEn As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTempReg As System.Windows.Forms.ComboBox
    Friend WithEvents lblTempReg As System.Windows.Forms.Label
    Friend WithEvents cmbTempDelta As System.Windows.Forms.ComboBox
    Friend WithEvents lblTempDelta As System.Windows.Forms.Label
    Friend WithEvents lblNTCThresholdVal As System.Windows.Forms.Label
    Friend WithEvents trbNTCThreshold As System.Windows.Forms.TrackBar
    Friend WithEvents lblNTCThreshold As System.Windows.Forms.Label
    Friend WithEvents pnlRegisters As System.Windows.Forms.Panel
    Friend WithEvents btnCtlRead As System.Windows.Forms.Button
    Friend WithEvents btnCtlSet As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkVOKSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkNtcTempSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkChgPhaseSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkTimerSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkCtrlLimitSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkADCDoneSts As System.Windows.Forms.CheckBox
    Friend WithEvents chkTempRegSts As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIntRead As System.Windows.Forms.Button
    Friend WithEvents btnIntSet As System.Windows.Forms.Button
    Friend WithEvents btnStsRead As System.Windows.Forms.Button
    Friend WithEvents btnAdcEnRead As System.Windows.Forms.Button
    Friend WithEvents btnAdcEnSet As System.Windows.Forms.Button
    Friend WithEvents btnProtectRead As System.Windows.Forms.Button
    Friend WithEvents btnProtectSet As System.Windows.Forms.Button
    Friend WithEvents btnCurrentADCRead As System.Windows.Forms.Button
    Friend WithEvents btnRaisedIntRead As System.Windows.Forms.Button
    Friend WithEvents btnThermalRead As System.Windows.Forms.Button
    Friend WithEvents btnThermalSet As System.Windows.Forms.Button
    Friend WithEvents btnReadADC As System.Windows.Forms.Button
    Friend WithEvents txtVinUvSts As System.Windows.Forms.TextBox
    Friend WithEvents txtVinOvSts As System.Windows.Forms.TextBox
    Friend WithEvents txtVbatOvSts As System.Windows.Forms.TextBox
    Friend WithEvents txtVoutUvSts As System.Windows.Forms.TextBox
    Friend WithEvents txtVFLTLoopSts As System.Windows.Forms.TextBox
    Friend WithEvents txtChgLoopSts As System.Windows.Forms.TextBox
    Friend WithEvents txtIinLoopSts As System.Windows.Forms.TextBox
    Friend WithEvents txtWatchdogTmrSts As System.Windows.Forms.TextBox
    Friend WithEvents txtChargeTmrSts As System.Windows.Forms.TextBox
    Friend WithEvents txtStandbyStateSts As System.Windows.Forms.TextBox
    Friend WithEvents txtShutDownStateSts As System.Windows.Forms.TextBox
    Friend WithEvents txtActiveStateSts As System.Windows.Forms.TextBox
    Friend WithEvents txtOcpAvgSts As System.Windows.Forms.TextBox
    Friend WithEvents txtOcpFastSts As System.Windows.Forms.TextBox
    Friend WithEvents txtBatteryMissSts As System.Windows.Forms.TextBox
    Friend WithEvents txtTimerSts As System.Windows.Forms.TextBox
    Friend WithEvents txtADCDoneSts As System.Windows.Forms.TextBox
    Friend WithEvents txtTempRegSts As System.Windows.Forms.TextBox
    Friend WithEvents txtCtrlLimitSts As System.Windows.Forms.TextBox
    Friend WithEvents txtChgPhaseSts As System.Windows.Forms.TextBox
    Friend WithEvents txtNtcTempSts As System.Windows.Forms.TextBox
    Friend WithEvents txtVOKSts As System.Windows.Forms.TextBox
End Class
