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
        Me.txtTimerSts = New System.Windows.Forms.TextBox()
        Me.txtADCDoneSts = New System.Windows.Forms.TextBox()
        Me.txtTempRegSts = New System.Windows.Forms.TextBox()
        Me.txtCtrlLimitSts = New System.Windows.Forms.TextBox()
        Me.txtChgPhaseSts = New System.Windows.Forms.TextBox()
        Me.txtNtcTempSts = New System.Windows.Forms.TextBox()
        Me.txtVOKSts = New System.Windows.Forms.TextBox()
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
        Me.txtCFlyShortSts = New System.Windows.Forms.TextBox()
        Me.chkCFlyShortSts = New System.Windows.Forms.CheckBox()
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
        Me.chkRevCurrentDet = New System.Windows.Forms.CheckBox()
        Me.chkStandbyEn = New System.Windows.Forms.CheckBox()
        Me.lblSwFreqCfg = New System.Windows.Forms.Label()
        Me.lblIinCfgVal = New System.Windows.Forms.Label()
        Me.trbIinCfg = New System.Windows.Forms.TrackBar()
        Me.lblIinCfg = New System.Windows.Forms.Label()
        Me.lblIchgCfgVal = New System.Windows.Forms.Label()
        Me.trbIchgCfg = New System.Windows.Forms.TrackBar()
        Me.lblIchgCfg = New System.Windows.Forms.Label()
        Me.tbpAdc = New System.Windows.Forms.TabPage()
        Me.chkADCModeSelect = New System.Windows.Forms.CheckBox()
        Me.chkAdcShutDownCfg = New System.Windows.Forms.CheckBox()
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
        Me.chkForceUnplugStandby = New System.Windows.Forms.CheckBox()
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
        Me.cmbSwFreqCfg = New System.Windows.Forms.ComboBox()
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnSpreadRead = New System.Windows.Forms.Button()
        Me.btnSpreadSet = New System.Windows.Forms.Button()
        Me.chkScClkDitherEn = New System.Windows.Forms.CheckBox()
        Me.cmbScClkDitherLimit = New System.Windows.Forms.ComboBox()
        Me.lblScClkDitherLimit = New System.Windows.Forms.Label()
        Me.cmbScClkDitherSR = New System.Windows.Forms.ComboBox()
        Me.lblScClkDitherSR = New System.Windows.Forms.Label()
        Me.tbpMisc = New System.Windows.Forms.TabPage()
        Me.gbxDebug = New System.Windows.Forms.GroupBox()
        Me.btnDbgRegRead6 = New System.Windows.Forms.Button()
        Me.btnDbgRegSet6 = New System.Windows.Forms.Button()
        Me.txtDbgRegAddr6 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegVal6 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegReadBack6 = New System.Windows.Forms.TextBox()
        Me.btnDbgRegRead5 = New System.Windows.Forms.Button()
        Me.btnDbgRegSet5 = New System.Windows.Forms.Button()
        Me.btnDbgRegRead4 = New System.Windows.Forms.Button()
        Me.btnDbgRegSet4 = New System.Windows.Forms.Button()
        Me.btnDbgRegRead3 = New System.Windows.Forms.Button()
        Me.btnDbgRegSet3 = New System.Windows.Forms.Button()
        Me.btnDbgRegRead2 = New System.Windows.Forms.Button()
        Me.btnDbgRegSet2 = New System.Windows.Forms.Button()
        Me.txtDbgRegAddr5 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegVal5 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegReadBack5 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegAddr3 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegVal3 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegReadBack3 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegAddr4 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegVal4 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegReadBack4 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegAddr2 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegVal2 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegReadBack2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDbgRegRead1 = New System.Windows.Forms.Button()
        Me.btnDbgRegSet1 = New System.Windows.Forms.Button()
        Me.txtDbgRegAddr1 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegVal1 = New System.Windows.Forms.TextBox()
        Me.txtDbgRegReadBack1 = New System.Windows.Forms.TextBox()
        Me.tbpADCTest = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbADCAccDelay = New System.Windows.Forms.ComboBox()
        Me.chkADCEnDis = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtADCAccNTCDelta = New System.Windows.Forms.TextBox()
        Me.txtADCAccDieTempDelta = New System.Windows.Forms.TextBox()
        Me.txtADCAccVbatDelta = New System.Windows.Forms.TextBox()
        Me.txtADCAccVoutDelta = New System.Windows.Forms.TextBox()
        Me.txtADCAccVinDelta = New System.Windows.Forms.TextBox()
        Me.txtADCAccIoutDelta = New System.Windows.Forms.TextBox()
        Me.txtADCAccIINDelta = New System.Windows.Forms.TextBox()
        Me.txtADCAccNTCMin = New System.Windows.Forms.TextBox()
        Me.txtADCAccDieTempMin = New System.Windows.Forms.TextBox()
        Me.txtADCAccVbatMin = New System.Windows.Forms.TextBox()
        Me.txtADCAccVoutMin = New System.Windows.Forms.TextBox()
        Me.txtADCAccVinMin = New System.Windows.Forms.TextBox()
        Me.txtADCAccIoutMin = New System.Windows.Forms.TextBox()
        Me.txtADCAccIINMin = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtADCAccNtcMax = New System.Windows.Forms.TextBox()
        Me.txtADCAccDieTempMax = New System.Windows.Forms.TextBox()
        Me.txtADCAccVbatMax = New System.Windows.Forms.TextBox()
        Me.txtADCAccVoutMax = New System.Windows.Forms.TextBox()
        Me.txtADCAccVinMax = New System.Windows.Forms.TextBox()
        Me.txtADCAccIoutMax = New System.Windows.Forms.TextBox()
        Me.txtADCAccIINMax = New System.Windows.Forms.TextBox()
        Me.txtADCAccNTCVoltage = New System.Windows.Forms.TextBox()
        Me.txtADCAccDieTemp = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtADCAccBattVoltage = New System.Windows.Forms.TextBox()
        Me.txtADCAccOutputVoltage = New System.Windows.Forms.TextBox()
        Me.txtADCAccInputVoltage = New System.Windows.Forms.TextBox()
        Me.txtADCAccOutputCurrent = New System.Windows.Forms.TextBox()
        Me.txtADCAccInputCurrent = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnADCTestStart = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtXslFileName = New System.Windows.Forms.TextBox()
        Me.btnSaveADC = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbADCTestRepeats = New System.Windows.Forms.ComboBox()
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
        Me.tmrADCTest = New System.Windows.Forms.Timer(Me.components)
        Me.tbpInt.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbpEvents.SuspendLayout()
        Me.GrpBoxSYSB.SuspendLayout()
        Me.GrpBoxSTSA.SuspendLayout()
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
        Me.TabPage1.SuspendLayout()
        Me.tbpMisc.SuspendLayout()
        Me.gbxDebug.SuspendLayout()
        Me.tbpADCTest.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.tbpInt.Location = New System.Drawing.Point(4, 25)
        Me.tbpInt.Name = "tbpInt"
        Me.tbpInt.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInt.Size = New System.Drawing.Size(500, 244)
        Me.tbpInt.TabIndex = 0
        Me.tbpInt.Text = "Interrupts"
        '
        'btnIntRead
        '
        Me.btnIntRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnIntRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntRead.Location = New System.Drawing.Point(346, 219)
        Me.btnIntRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIntRead.Name = "btnIntRead"
        Me.btnIntRead.Size = New System.Drawing.Size(57, 21)
        Me.btnIntRead.TabIndex = 59
        Me.btnIntRead.Text = "Read"
        Me.btnIntRead.UseVisualStyleBackColor = False
        '
        'btnIntSet
        '
        Me.btnIntSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIntSet.Location = New System.Drawing.Point(284, 219)
        Me.btnIntSet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIntSet.Name = "btnIntSet"
        Me.btnIntSet.Size = New System.Drawing.Size(57, 21)
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
        Me.GroupBox2.Location = New System.Drawing.Point(197, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(206, 185)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Interrupt Status"
        '
        'txtTimerSts
        '
        Me.txtTimerSts.Location = New System.Drawing.Point(28, 155)
        Me.txtTimerSts.Name = "txtTimerSts"
        Me.txtTimerSts.ReadOnly = True
        Me.txtTimerSts.Size = New System.Drawing.Size(164, 20)
        Me.txtTimerSts.TabIndex = 50
        '
        'txtADCDoneSts
        '
        Me.txtADCDoneSts.Location = New System.Drawing.Point(28, 132)
        Me.txtADCDoneSts.Name = "txtADCDoneSts"
        Me.txtADCDoneSts.ReadOnly = True
        Me.txtADCDoneSts.Size = New System.Drawing.Size(164, 20)
        Me.txtADCDoneSts.TabIndex = 49
        '
        'txtTempRegSts
        '
        Me.txtTempRegSts.Location = New System.Drawing.Point(28, 109)
        Me.txtTempRegSts.Name = "txtTempRegSts"
        Me.txtTempRegSts.ReadOnly = True
        Me.txtTempRegSts.Size = New System.Drawing.Size(164, 20)
        Me.txtTempRegSts.TabIndex = 48
        '
        'txtCtrlLimitSts
        '
        Me.txtCtrlLimitSts.Location = New System.Drawing.Point(28, 84)
        Me.txtCtrlLimitSts.Name = "txtCtrlLimitSts"
        Me.txtCtrlLimitSts.ReadOnly = True
        Me.txtCtrlLimitSts.Size = New System.Drawing.Size(164, 20)
        Me.txtCtrlLimitSts.TabIndex = 47
        '
        'txtChgPhaseSts
        '
        Me.txtChgPhaseSts.Location = New System.Drawing.Point(28, 63)
        Me.txtChgPhaseSts.Name = "txtChgPhaseSts"
        Me.txtChgPhaseSts.ReadOnly = True
        Me.txtChgPhaseSts.Size = New System.Drawing.Size(164, 20)
        Me.txtChgPhaseSts.TabIndex = 46
        '
        'txtNtcTempSts
        '
        Me.txtNtcTempSts.Location = New System.Drawing.Point(28, 39)
        Me.txtNtcTempSts.Name = "txtNtcTempSts"
        Me.txtNtcTempSts.ReadOnly = True
        Me.txtNtcTempSts.Size = New System.Drawing.Size(164, 20)
        Me.txtNtcTempSts.TabIndex = 45
        '
        'txtVOKSts
        '
        Me.txtVOKSts.Location = New System.Drawing.Point(28, 18)
        Me.txtVOKSts.Name = "txtVOKSts"
        Me.txtVOKSts.ReadOnly = True
        Me.txtVOKSts.Size = New System.Drawing.Size(164, 20)
        Me.txtVOKSts.TabIndex = 44
        '
        'chkVOKSts
        '
        Me.chkVOKSts.AutoSize = True
        Me.chkVOKSts.Location = New System.Drawing.Point(13, 18)
        Me.chkVOKSts.Name = "chkVOKSts"
        Me.chkVOKSts.Size = New System.Drawing.Size(75, 17)
        Me.chkVOKSts.TabIndex = 20
        Me.chkVOKSts.Text = "Vbus OVP"
        Me.chkVOKSts.UseVisualStyleBackColor = True
        '
        'chkNtcTempSts
        '
        Me.chkNtcTempSts.AutoSize = True
        Me.chkNtcTempSts.Location = New System.Drawing.Point(13, 41)
        Me.chkNtcTempSts.Name = "chkNtcTempSts"
        Me.chkNtcTempSts.Size = New System.Drawing.Size(75, 17)
        Me.chkNtcTempSts.TabIndex = 21
        Me.chkNtcTempSts.Text = "Vbus OVP"
        Me.chkNtcTempSts.UseVisualStyleBackColor = True
        '
        'chkChgPhaseSts
        '
        Me.chkChgPhaseSts.AutoSize = True
        Me.chkChgPhaseSts.Location = New System.Drawing.Point(13, 63)
        Me.chkChgPhaseSts.Name = "chkChgPhaseSts"
        Me.chkChgPhaseSts.Size = New System.Drawing.Size(75, 17)
        Me.chkChgPhaseSts.TabIndex = 22
        Me.chkChgPhaseSts.Text = "Vbus OVP"
        Me.chkChgPhaseSts.UseVisualStyleBackColor = True
        '
        'chkTimerSts
        '
        Me.chkTimerSts.AutoSize = True
        Me.chkTimerSts.Location = New System.Drawing.Point(13, 154)
        Me.chkTimerSts.Name = "chkTimerSts"
        Me.chkTimerSts.Size = New System.Drawing.Size(75, 17)
        Me.chkTimerSts.TabIndex = 26
        Me.chkTimerSts.Text = "Vbus OVP"
        Me.chkTimerSts.UseVisualStyleBackColor = True
        '
        'chkCtrlLimitSts
        '
        Me.chkCtrlLimitSts.AutoSize = True
        Me.chkCtrlLimitSts.Location = New System.Drawing.Point(13, 86)
        Me.chkCtrlLimitSts.Name = "chkCtrlLimitSts"
        Me.chkCtrlLimitSts.Size = New System.Drawing.Size(75, 17)
        Me.chkCtrlLimitSts.TabIndex = 23
        Me.chkCtrlLimitSts.Text = "Vbus OVP"
        Me.chkCtrlLimitSts.UseVisualStyleBackColor = True
        '
        'chkADCDoneSts
        '
        Me.chkADCDoneSts.AutoSize = True
        Me.chkADCDoneSts.Location = New System.Drawing.Point(13, 132)
        Me.chkADCDoneSts.Name = "chkADCDoneSts"
        Me.chkADCDoneSts.Size = New System.Drawing.Size(75, 17)
        Me.chkADCDoneSts.TabIndex = 25
        Me.chkADCDoneSts.Text = "Vbus OVP"
        Me.chkADCDoneSts.UseVisualStyleBackColor = True
        '
        'chkTempRegSts
        '
        Me.chkTempRegSts.AutoSize = True
        Me.chkTempRegSts.Location = New System.Drawing.Point(13, 109)
        Me.chkTempRegSts.Name = "chkTempRegSts"
        Me.chkTempRegSts.Size = New System.Drawing.Size(75, 17)
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
        Me.GroupBox1.Location = New System.Drawing.Point(11, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(170, 185)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interrupt Mask"
        '
        'chkVOkMask
        '
        Me.chkVOkMask.AutoSize = True
        Me.chkVOkMask.Location = New System.Drawing.Point(13, 18)
        Me.chkVOkMask.Name = "chkVOkMask"
        Me.chkVOkMask.Size = New System.Drawing.Size(75, 17)
        Me.chkVOkMask.TabIndex = 20
        Me.chkVOkMask.Text = "Vbus OVP"
        Me.chkVOkMask.UseVisualStyleBackColor = True
        '
        'chkNtcTempMask
        '
        Me.chkNtcTempMask.AutoSize = True
        Me.chkNtcTempMask.Location = New System.Drawing.Point(13, 41)
        Me.chkNtcTempMask.Name = "chkNtcTempMask"
        Me.chkNtcTempMask.Size = New System.Drawing.Size(75, 17)
        Me.chkNtcTempMask.TabIndex = 21
        Me.chkNtcTempMask.Text = "Vbus OVP"
        Me.chkNtcTempMask.UseVisualStyleBackColor = True
        '
        'chkTimerMask
        '
        Me.chkTimerMask.AutoSize = True
        Me.chkTimerMask.Location = New System.Drawing.Point(13, 154)
        Me.chkTimerMask.Name = "chkTimerMask"
        Me.chkTimerMask.Size = New System.Drawing.Size(75, 17)
        Me.chkTimerMask.TabIndex = 27
        Me.chkTimerMask.Text = "Vbus OVP"
        Me.chkTimerMask.UseVisualStyleBackColor = True
        '
        'chkChgPhaseMask
        '
        Me.chkChgPhaseMask.AutoSize = True
        Me.chkChgPhaseMask.Location = New System.Drawing.Point(13, 63)
        Me.chkChgPhaseMask.Name = "chkChgPhaseMask"
        Me.chkChgPhaseMask.Size = New System.Drawing.Size(75, 17)
        Me.chkChgPhaseMask.TabIndex = 22
        Me.chkChgPhaseMask.Text = "Vbus OVP"
        Me.chkChgPhaseMask.UseVisualStyleBackColor = True
        '
        'chkADCDoneMask
        '
        Me.chkADCDoneMask.AutoSize = True
        Me.chkADCDoneMask.Location = New System.Drawing.Point(13, 132)
        Me.chkADCDoneMask.Name = "chkADCDoneMask"
        Me.chkADCDoneMask.Size = New System.Drawing.Size(75, 17)
        Me.chkADCDoneMask.TabIndex = 26
        Me.chkADCDoneMask.Text = "Vbus OVP"
        Me.chkADCDoneMask.UseVisualStyleBackColor = True
        '
        'chkTempRegMask
        '
        Me.chkTempRegMask.AutoSize = True
        Me.chkTempRegMask.Location = New System.Drawing.Point(13, 109)
        Me.chkTempRegMask.Name = "chkTempRegMask"
        Me.chkTempRegMask.Size = New System.Drawing.Size(75, 17)
        Me.chkTempRegMask.TabIndex = 25
        Me.chkTempRegMask.Text = "Vbus OVP"
        Me.chkTempRegMask.UseVisualStyleBackColor = True
        '
        'chkCtrlLimitMask
        '
        Me.chkCtrlLimitMask.AutoSize = True
        Me.chkCtrlLimitMask.Location = New System.Drawing.Point(13, 86)
        Me.chkCtrlLimitMask.Name = "chkCtrlLimitMask"
        Me.chkCtrlLimitMask.Size = New System.Drawing.Size(75, 17)
        Me.chkCtrlLimitMask.TabIndex = 24
        Me.chkCtrlLimitMask.Text = "Vbus OVP"
        Me.chkCtrlLimitMask.UseVisualStyleBackColor = True
        '
        'lblForceAdcMode
        '
        Me.lblForceAdcMode.AutoSize = True
        Me.lblForceAdcMode.Location = New System.Drawing.Point(14, 21)
        Me.lblForceAdcMode.Name = "lblForceAdcMode"
        Me.lblForceAdcMode.Size = New System.Drawing.Size(89, 13)
        Me.lblForceAdcMode.TabIndex = 21
        Me.lblForceAdcMode.Text = "Force ADC Mode"
        '
        'tbpEvents
        '
        Me.tbpEvents.BackColor = System.Drawing.SystemColors.Control
        Me.tbpEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpEvents.Controls.Add(Me.btnStsRead)
        Me.tbpEvents.Controls.Add(Me.GrpBoxSYSB)
        Me.tbpEvents.Controls.Add(Me.GrpBoxSTSA)
        Me.tbpEvents.Location = New System.Drawing.Point(4, 25)
        Me.tbpEvents.Name = "tbpEvents"
        Me.tbpEvents.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEvents.Size = New System.Drawing.Size(500, 244)
        Me.tbpEvents.TabIndex = 3
        Me.tbpEvents.Text = "Status"
        '
        'btnStsRead
        '
        Me.btnStsRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnStsRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStsRead.Location = New System.Drawing.Point(346, 219)
        Me.btnStsRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStsRead.Name = "btnStsRead"
        Me.btnStsRead.Size = New System.Drawing.Size(57, 21)
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
        Me.GrpBoxSYSB.Location = New System.Drawing.Point(197, 18)
        Me.GrpBoxSYSB.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpBoxSYSB.Name = "GrpBoxSYSB"
        Me.GrpBoxSYSB.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpBoxSYSB.Size = New System.Drawing.Size(176, 198)
        Me.GrpBoxSYSB.TabIndex = 36
        Me.GrpBoxSYSB.TabStop = False
        Me.GrpBoxSYSB.Text = "STS_B"
        '
        'txtWatchdogTmrSts
        '
        Me.txtWatchdogTmrSts.Location = New System.Drawing.Point(28, 176)
        Me.txtWatchdogTmrSts.Name = "txtWatchdogTmrSts"
        Me.txtWatchdogTmrSts.ReadOnly = True
        Me.txtWatchdogTmrSts.Size = New System.Drawing.Size(134, 20)
        Me.txtWatchdogTmrSts.TabIndex = 44
        '
        'txtChargeTmrSts
        '
        Me.txtChargeTmrSts.Location = New System.Drawing.Point(28, 155)
        Me.txtChargeTmrSts.Name = "txtChargeTmrSts"
        Me.txtChargeTmrSts.ReadOnly = True
        Me.txtChargeTmrSts.Size = New System.Drawing.Size(134, 20)
        Me.txtChargeTmrSts.TabIndex = 43
        '
        'txtStandbyStateSts
        '
        Me.txtStandbyStateSts.Location = New System.Drawing.Point(28, 132)
        Me.txtStandbyStateSts.Name = "txtStandbyStateSts"
        Me.txtStandbyStateSts.ReadOnly = True
        Me.txtStandbyStateSts.Size = New System.Drawing.Size(134, 20)
        Me.txtStandbyStateSts.TabIndex = 42
        '
        'txtShutDownStateSts
        '
        Me.txtShutDownStateSts.Location = New System.Drawing.Point(28, 109)
        Me.txtShutDownStateSts.Name = "txtShutDownStateSts"
        Me.txtShutDownStateSts.ReadOnly = True
        Me.txtShutDownStateSts.Size = New System.Drawing.Size(134, 20)
        Me.txtShutDownStateSts.TabIndex = 41
        '
        'txtActiveStateSts
        '
        Me.txtActiveStateSts.Location = New System.Drawing.Point(28, 84)
        Me.txtActiveStateSts.Name = "txtActiveStateSts"
        Me.txtActiveStateSts.ReadOnly = True
        Me.txtActiveStateSts.Size = New System.Drawing.Size(134, 20)
        Me.txtActiveStateSts.TabIndex = 40
        '
        'txtOcpAvgSts
        '
        Me.txtOcpAvgSts.Location = New System.Drawing.Point(28, 63)
        Me.txtOcpAvgSts.Name = "txtOcpAvgSts"
        Me.txtOcpAvgSts.ReadOnly = True
        Me.txtOcpAvgSts.Size = New System.Drawing.Size(134, 20)
        Me.txtOcpAvgSts.TabIndex = 39
        '
        'txtOcpFastSts
        '
        Me.txtOcpFastSts.Location = New System.Drawing.Point(28, 39)
        Me.txtOcpFastSts.Name = "txtOcpFastSts"
        Me.txtOcpFastSts.ReadOnly = True
        Me.txtOcpFastSts.Size = New System.Drawing.Size(134, 20)
        Me.txtOcpFastSts.TabIndex = 38
        '
        'txtBatteryMissSts
        '
        Me.txtBatteryMissSts.Location = New System.Drawing.Point(28, 18)
        Me.txtBatteryMissSts.Name = "txtBatteryMissSts"
        Me.txtBatteryMissSts.ReadOnly = True
        Me.txtBatteryMissSts.Size = New System.Drawing.Size(134, 20)
        Me.txtBatteryMissSts.TabIndex = 37
        '
        'chkWatchdogTmrSts
        '
        Me.chkWatchdogTmrSts.AutoSize = True
        Me.chkWatchdogTmrSts.Location = New System.Drawing.Point(13, 177)
        Me.chkWatchdogTmrSts.Name = "chkWatchdogTmrSts"
        Me.chkWatchdogTmrSts.Size = New System.Drawing.Size(75, 17)
        Me.chkWatchdogTmrSts.TabIndex = 31
        Me.chkWatchdogTmrSts.Text = "Vbus OVP"
        Me.chkWatchdogTmrSts.UseVisualStyleBackColor = True
        '
        'chkStandbyStateSts
        '
        Me.chkStandbyStateSts.AutoSize = True
        Me.chkStandbyStateSts.Location = New System.Drawing.Point(13, 132)
        Me.chkStandbyStateSts.Name = "chkStandbyStateSts"
        Me.chkStandbyStateSts.Size = New System.Drawing.Size(75, 17)
        Me.chkStandbyStateSts.TabIndex = 29
        Me.chkStandbyStateSts.Text = "Vbus OVP"
        Me.chkStandbyStateSts.UseVisualStyleBackColor = True
        '
        'chkChargeTmrSts
        '
        Me.chkChargeTmrSts.AutoSize = True
        Me.chkChargeTmrSts.Location = New System.Drawing.Point(13, 154)
        Me.chkChargeTmrSts.Name = "chkChargeTmrSts"
        Me.chkChargeTmrSts.Size = New System.Drawing.Size(75, 17)
        Me.chkChargeTmrSts.TabIndex = 30
        Me.chkChargeTmrSts.Text = "Vbus OVP"
        Me.chkChargeTmrSts.UseVisualStyleBackColor = True
        '
        'chkBatteryMissSts
        '
        Me.chkBatteryMissSts.AutoSize = True
        Me.chkBatteryMissSts.Location = New System.Drawing.Point(13, 18)
        Me.chkBatteryMissSts.Name = "chkBatteryMissSts"
        Me.chkBatteryMissSts.Size = New System.Drawing.Size(75, 17)
        Me.chkBatteryMissSts.TabIndex = 24
        Me.chkBatteryMissSts.Text = "Vbus OVP"
        Me.chkBatteryMissSts.UseVisualStyleBackColor = True
        '
        'chkOcpFastSts
        '
        Me.chkOcpFastSts.AutoSize = True
        Me.chkOcpFastSts.Location = New System.Drawing.Point(13, 41)
        Me.chkOcpFastSts.Name = "chkOcpFastSts"
        Me.chkOcpFastSts.Size = New System.Drawing.Size(75, 17)
        Me.chkOcpFastSts.TabIndex = 25
        Me.chkOcpFastSts.Text = "Vbus OVP"
        Me.chkOcpFastSts.UseVisualStyleBackColor = True
        '
        'chkOcpAvgSts
        '
        Me.chkOcpAvgSts.AutoSize = True
        Me.chkOcpAvgSts.Location = New System.Drawing.Point(13, 63)
        Me.chkOcpAvgSts.Name = "chkOcpAvgSts"
        Me.chkOcpAvgSts.Size = New System.Drawing.Size(75, 17)
        Me.chkOcpAvgSts.TabIndex = 26
        Me.chkOcpAvgSts.Text = "Vbus OVP"
        Me.chkOcpAvgSts.UseVisualStyleBackColor = True
        '
        'chkActiveStateSts
        '
        Me.chkActiveStateSts.AutoSize = True
        Me.chkActiveStateSts.Location = New System.Drawing.Point(13, 86)
        Me.chkActiveStateSts.Name = "chkActiveStateSts"
        Me.chkActiveStateSts.Size = New System.Drawing.Size(75, 17)
        Me.chkActiveStateSts.TabIndex = 27
        Me.chkActiveStateSts.Text = "Vbus OVP"
        Me.chkActiveStateSts.UseVisualStyleBackColor = True
        '
        'chkShutDownStateSts
        '
        Me.chkShutDownStateSts.AutoSize = True
        Me.chkShutDownStateSts.Location = New System.Drawing.Point(13, 109)
        Me.chkShutDownStateSts.Name = "chkShutDownStateSts"
        Me.chkShutDownStateSts.Size = New System.Drawing.Size(75, 17)
        Me.chkShutDownStateSts.TabIndex = 28
        Me.chkShutDownStateSts.Text = "Vbus OVP"
        Me.chkShutDownStateSts.UseVisualStyleBackColor = True
        '
        'GrpBoxSTSA
        '
        Me.GrpBoxSTSA.Controls.Add(Me.txtCFlyShortSts)
        Me.GrpBoxSTSA.Controls.Add(Me.chkCFlyShortSts)
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
        Me.GrpBoxSTSA.Location = New System.Drawing.Point(11, 18)
        Me.GrpBoxSTSA.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpBoxSTSA.Name = "GrpBoxSTSA"
        Me.GrpBoxSTSA.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpBoxSTSA.Size = New System.Drawing.Size(168, 198)
        Me.GrpBoxSTSA.TabIndex = 35
        Me.GrpBoxSTSA.TabStop = False
        Me.GrpBoxSTSA.Text = "STS_A"
        '
        'txtCFlyShortSts
        '
        Me.txtCFlyShortSts.Location = New System.Drawing.Point(28, 84)
        Me.txtCFlyShortSts.Name = "txtCFlyShortSts"
        Me.txtCFlyShortSts.ReadOnly = True
        Me.txtCFlyShortSts.Size = New System.Drawing.Size(120, 20)
        Me.txtCFlyShortSts.TabIndex = 38
        '
        'chkCFlyShortSts
        '
        Me.chkCFlyShortSts.AutoSize = True
        Me.chkCFlyShortSts.Location = New System.Drawing.Point(13, 85)
        Me.chkCFlyShortSts.Name = "chkCFlyShortSts"
        Me.chkCFlyShortSts.Size = New System.Drawing.Size(75, 17)
        Me.chkCFlyShortSts.TabIndex = 37
        Me.chkCFlyShortSts.Text = "Vbus OVP"
        Me.chkCFlyShortSts.UseVisualStyleBackColor = True
        '
        'txtVinUvSts
        '
        Me.txtVinUvSts.Location = New System.Drawing.Point(28, 177)
        Me.txtVinUvSts.Name = "txtVinUvSts"
        Me.txtVinUvSts.ReadOnly = True
        Me.txtVinUvSts.Size = New System.Drawing.Size(120, 20)
        Me.txtVinUvSts.TabIndex = 36
        '
        'txtVinOvSts
        '
        Me.txtVinOvSts.Location = New System.Drawing.Point(28, 154)
        Me.txtVinOvSts.Name = "txtVinOvSts"
        Me.txtVinOvSts.ReadOnly = True
        Me.txtVinOvSts.Size = New System.Drawing.Size(120, 20)
        Me.txtVinOvSts.TabIndex = 35
        '
        'txtVbatOvSts
        '
        Me.txtVbatOvSts.Location = New System.Drawing.Point(28, 131)
        Me.txtVbatOvSts.Name = "txtVbatOvSts"
        Me.txtVbatOvSts.ReadOnly = True
        Me.txtVbatOvSts.Size = New System.Drawing.Size(120, 20)
        Me.txtVbatOvSts.TabIndex = 34
        '
        'txtVoutUvSts
        '
        Me.txtVoutUvSts.Location = New System.Drawing.Point(28, 106)
        Me.txtVoutUvSts.Name = "txtVoutUvSts"
        Me.txtVoutUvSts.ReadOnly = True
        Me.txtVoutUvSts.Size = New System.Drawing.Size(120, 20)
        Me.txtVoutUvSts.TabIndex = 33
        '
        'txtVFLTLoopSts
        '
        Me.txtVFLTLoopSts.Location = New System.Drawing.Point(28, 63)
        Me.txtVFLTLoopSts.Name = "txtVFLTLoopSts"
        Me.txtVFLTLoopSts.ReadOnly = True
        Me.txtVFLTLoopSts.Size = New System.Drawing.Size(120, 20)
        Me.txtVFLTLoopSts.TabIndex = 32
        '
        'txtChgLoopSts
        '
        Me.txtChgLoopSts.Location = New System.Drawing.Point(28, 39)
        Me.txtChgLoopSts.Name = "txtChgLoopSts"
        Me.txtChgLoopSts.ReadOnly = True
        Me.txtChgLoopSts.Size = New System.Drawing.Size(120, 20)
        Me.txtChgLoopSts.TabIndex = 31
        '
        'txtIinLoopSts
        '
        Me.txtIinLoopSts.Location = New System.Drawing.Point(28, 18)
        Me.txtIinLoopSts.Name = "txtIinLoopSts"
        Me.txtIinLoopSts.ReadOnly = True
        Me.txtIinLoopSts.Size = New System.Drawing.Size(120, 20)
        Me.txtIinLoopSts.TabIndex = 28
        '
        'chkVinOvSts
        '
        Me.chkVinOvSts.AutoSize = True
        Me.chkVinOvSts.Location = New System.Drawing.Point(13, 154)
        Me.chkVinOvSts.Name = "chkVinOvSts"
        Me.chkVinOvSts.Size = New System.Drawing.Size(75, 17)
        Me.chkVinOvSts.TabIndex = 29
        Me.chkVinOvSts.Text = "Vbus OVP"
        Me.chkVinOvSts.UseVisualStyleBackColor = True
        '
        'chkVinUvSts
        '
        Me.chkVinUvSts.AutoSize = True
        Me.chkVinUvSts.Location = New System.Drawing.Point(13, 176)
        Me.chkVinUvSts.Name = "chkVinUvSts"
        Me.chkVinUvSts.Size = New System.Drawing.Size(75, 17)
        Me.chkVinUvSts.TabIndex = 30
        Me.chkVinUvSts.Text = "Vbus OVP"
        Me.chkVinUvSts.UseVisualStyleBackColor = True
        '
        'chkIinLoopSts
        '
        Me.chkIinLoopSts.AutoSize = True
        Me.chkIinLoopSts.Location = New System.Drawing.Point(13, 18)
        Me.chkIinLoopSts.Name = "chkIinLoopSts"
        Me.chkIinLoopSts.Size = New System.Drawing.Size(75, 17)
        Me.chkIinLoopSts.TabIndex = 24
        Me.chkIinLoopSts.Text = "Vbus OVP"
        Me.chkIinLoopSts.UseVisualStyleBackColor = True
        '
        'chkChgLoopSts
        '
        Me.chkChgLoopSts.AutoSize = True
        Me.chkChgLoopSts.Location = New System.Drawing.Point(13, 41)
        Me.chkChgLoopSts.Name = "chkChgLoopSts"
        Me.chkChgLoopSts.Size = New System.Drawing.Size(75, 17)
        Me.chkChgLoopSts.TabIndex = 25
        Me.chkChgLoopSts.Text = "Vbus OVP"
        Me.chkChgLoopSts.UseVisualStyleBackColor = True
        '
        'chkVFLTLoopSts
        '
        Me.chkVFLTLoopSts.AutoSize = True
        Me.chkVFLTLoopSts.Location = New System.Drawing.Point(13, 63)
        Me.chkVFLTLoopSts.Name = "chkVFLTLoopSts"
        Me.chkVFLTLoopSts.Size = New System.Drawing.Size(75, 17)
        Me.chkVFLTLoopSts.TabIndex = 26
        Me.chkVFLTLoopSts.Text = "Vbus OVP"
        Me.chkVFLTLoopSts.UseVisualStyleBackColor = True
        '
        'chkVoutUvSts
        '
        Me.chkVoutUvSts.AutoSize = True
        Me.chkVoutUvSts.Location = New System.Drawing.Point(13, 108)
        Me.chkVoutUvSts.Name = "chkVoutUvSts"
        Me.chkVoutUvSts.Size = New System.Drawing.Size(75, 17)
        Me.chkVoutUvSts.TabIndex = 27
        Me.chkVoutUvSts.Text = "Vbus OVP"
        Me.chkVoutUvSts.UseVisualStyleBackColor = True
        '
        'chkVbatOvSts
        '
        Me.chkVbatOvSts.AutoSize = True
        Me.chkVbatOvSts.Location = New System.Drawing.Point(13, 131)
        Me.chkVbatOvSts.Name = "chkVbatOvSts"
        Me.chkVbatOvSts.Size = New System.Drawing.Size(75, 17)
        Me.chkVbatOvSts.TabIndex = 28
        Me.chkVbatOvSts.Text = "Vbus OVP"
        Me.chkVbatOvSts.UseVisualStyleBackColor = True
        '
        'lblHiberDelay
        '
        Me.lblHiberDelay.AutoSize = True
        Me.lblHiberDelay.Location = New System.Drawing.Point(14, 51)
        Me.lblHiberDelay.Name = "lblHiberDelay"
        Me.lblHiberDelay.Size = New System.Drawing.Size(83, 13)
        Me.lblHiberDelay.TabIndex = 23
        Me.lblHiberDelay.Text = "Hibernate Delay"
        '
        'cmbAdcForceMode
        '
        Me.cmbAdcForceMode.FormattingEnabled = True
        Me.cmbAdcForceMode.Location = New System.Drawing.Point(169, 19)
        Me.cmbAdcForceMode.Name = "cmbAdcForceMode"
        Me.cmbAdcForceMode.Size = New System.Drawing.Size(134, 21)
        Me.cmbAdcForceMode.TabIndex = 22
        '
        'chkRevCurrentDet
        '
        Me.chkRevCurrentDet.AutoSize = True
        Me.chkRevCurrentDet.Location = New System.Drawing.Point(245, 70)
        Me.chkRevCurrentDet.Name = "chkRevCurrentDet"
        Me.chkRevCurrentDet.Size = New System.Drawing.Size(97, 17)
        Me.chkRevCurrentDet.TabIndex = 54
        Me.chkRevCurrentDet.Text = "RevCurrentDet"
        Me.chkRevCurrentDet.UseVisualStyleBackColor = True
        '
        'chkStandbyEn
        '
        Me.chkStandbyEn.AutoSize = True
        Me.chkStandbyEn.Location = New System.Drawing.Point(245, 46)
        Me.chkStandbyEn.Name = "chkStandbyEn"
        Me.chkStandbyEn.Size = New System.Drawing.Size(81, 17)
        Me.chkStandbyEn.TabIndex = 53
        Me.chkStandbyEn.Text = "Standby En"
        Me.chkStandbyEn.UseVisualStyleBackColor = True
        '
        'lblSwFreqCfg
        '
        Me.lblSwFreqCfg.AutoSize = True
        Me.lblSwFreqCfg.Location = New System.Drawing.Point(14, 105)
        Me.lblSwFreqCfg.Name = "lblSwFreqCfg"
        Me.lblSwFreqCfg.Size = New System.Drawing.Size(41, 13)
        Me.lblSwFreqCfg.TabIndex = 50
        Me.lblSwFreqCfg.Text = "swFreq"
        '
        'lblIinCfgVal
        '
        Me.lblIinCfgVal.AutoSize = True
        Me.lblIinCfgVal.Location = New System.Drawing.Point(325, 185)
        Me.lblIinCfgVal.Name = "lblIinCfgVal"
        Me.lblIinCfgVal.Size = New System.Drawing.Size(22, 13)
        Me.lblIinCfgVal.TabIndex = 49
        Me.lblIinCfgVal.Text = "mA"
        '
        'trbIinCfg
        '
        Me.trbIinCfg.AutoSize = False
        Me.trbIinCfg.Location = New System.Drawing.Point(133, 183)
        Me.trbIinCfg.Name = "trbIinCfg"
        Me.trbIinCfg.Size = New System.Drawing.Size(189, 25)
        Me.trbIinCfg.TabIndex = 48
        '
        'lblIinCfg
        '
        Me.lblIinCfg.AutoSize = True
        Me.lblIinCfg.Location = New System.Drawing.Point(16, 185)
        Me.lblIinCfg.Name = "lblIinCfg"
        Me.lblIinCfg.Size = New System.Drawing.Size(34, 13)
        Me.lblIinCfg.TabIndex = 47
        Me.lblIinCfg.Text = "IinSet"
        '
        'lblIchgCfgVal
        '
        Me.lblIchgCfgVal.AutoSize = True
        Me.lblIchgCfgVal.Location = New System.Drawing.Point(325, 156)
        Me.lblIchgCfgVal.Name = "lblIchgCfgVal"
        Me.lblIchgCfgVal.Size = New System.Drawing.Size(22, 13)
        Me.lblIchgCfgVal.TabIndex = 46
        Me.lblIchgCfgVal.Text = "mA"
        '
        'trbIchgCfg
        '
        Me.trbIchgCfg.AutoSize = False
        Me.trbIchgCfg.Location = New System.Drawing.Point(133, 154)
        Me.trbIchgCfg.Name = "trbIchgCfg"
        Me.trbIchgCfg.Size = New System.Drawing.Size(189, 25)
        Me.trbIchgCfg.TabIndex = 45
        '
        'lblIchgCfg
        '
        Me.lblIchgCfg.AutoSize = True
        Me.lblIchgCfg.Location = New System.Drawing.Point(16, 156)
        Me.lblIchgCfg.Name = "lblIchgCfg"
        Me.lblIchgCfg.Size = New System.Drawing.Size(44, 13)
        Me.lblIchgCfg.TabIndex = 44
        Me.lblIchgCfg.Text = "IchgCfg"
        '
        'tbpAdc
        '
        Me.tbpAdc.BackColor = System.Drawing.SystemColors.Control
        Me.tbpAdc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpAdc.Controls.Add(Me.chkADCModeSelect)
        Me.tbpAdc.Controls.Add(Me.chkAdcShutDownCfg)
        Me.tbpAdc.Controls.Add(Me.btnAdcEnRead)
        Me.tbpAdc.Controls.Add(Me.btnAdcEnSet)
        Me.tbpAdc.Controls.Add(Me.cmbAdcHibDelay)
        Me.tbpAdc.Controls.Add(Me.lblHiberDelay)
        Me.tbpAdc.Controls.Add(Me.cmbAdcForceMode)
        Me.tbpAdc.Controls.Add(Me.lblForceAdcMode)
        Me.tbpAdc.Location = New System.Drawing.Point(4, 25)
        Me.tbpAdc.Name = "tbpAdc"
        Me.tbpAdc.Size = New System.Drawing.Size(500, 244)
        Me.tbpAdc.TabIndex = 2
        Me.tbpAdc.Text = "ADC"
        '
        'chkADCModeSelect
        '
        Me.chkADCModeSelect.AutoSize = True
        Me.chkADCModeSelect.Enabled = False
        Me.chkADCModeSelect.Location = New System.Drawing.Point(14, 99)
        Me.chkADCModeSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.chkADCModeSelect.Name = "chkADCModeSelect"
        Me.chkADCModeSelect.Size = New System.Drawing.Size(120, 17)
        Me.chkADCModeSelect.TabIndex = 61
        Me.chkADCModeSelect.Text = "ADC in Offset Mode"
        Me.chkADCModeSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkADCModeSelect.UseVisualStyleBackColor = True
        Me.chkADCModeSelect.Visible = False
        '
        'chkAdcShutDownCfg
        '
        Me.chkAdcShutDownCfg.AutoSize = True
        Me.chkAdcShutDownCfg.Location = New System.Drawing.Point(14, 77)
        Me.chkAdcShutDownCfg.Margin = New System.Windows.Forms.Padding(2)
        Me.chkAdcShutDownCfg.Name = "chkAdcShutDownCfg"
        Me.chkAdcShutDownCfg.Size = New System.Drawing.Size(125, 17)
        Me.chkAdcShutDownCfg.TabIndex = 60
        Me.chkAdcShutDownCfg.Text = "ADC ShutDown CFG"
        Me.chkAdcShutDownCfg.UseVisualStyleBackColor = True
        '
        'btnAdcEnRead
        '
        Me.btnAdcEnRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdcEnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdcEnRead.Location = New System.Drawing.Point(346, 219)
        Me.btnAdcEnRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdcEnRead.Name = "btnAdcEnRead"
        Me.btnAdcEnRead.Size = New System.Drawing.Size(57, 21)
        Me.btnAdcEnRead.TabIndex = 59
        Me.btnAdcEnRead.Text = "Read"
        Me.btnAdcEnRead.UseVisualStyleBackColor = False
        '
        'btnAdcEnSet
        '
        Me.btnAdcEnSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdcEnSet.Location = New System.Drawing.Point(284, 219)
        Me.btnAdcEnSet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdcEnSet.Name = "btnAdcEnSet"
        Me.btnAdcEnSet.Size = New System.Drawing.Size(57, 21)
        Me.btnAdcEnSet.TabIndex = 58
        Me.btnAdcEnSet.Text = "Set"
        Me.btnAdcEnSet.UseVisualStyleBackColor = False
        '
        'cmbAdcHibDelay
        '
        Me.cmbAdcHibDelay.FormattingEnabled = True
        Me.cmbAdcHibDelay.Location = New System.Drawing.Point(169, 46)
        Me.cmbAdcHibDelay.Name = "cmbAdcHibDelay"
        Me.cmbAdcHibDelay.Size = New System.Drawing.Size(134, 21)
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
        Me.grpDevice.Location = New System.Drawing.Point(12, 48)
        Me.grpDevice.Name = "grpDevice"
        Me.grpDevice.Size = New System.Drawing.Size(329, 48)
        Me.grpDevice.TabIndex = 35
        Me.grpDevice.TabStop = False
        Me.grpDevice.Text = "Device"
        '
        'lblRev
        '
        Me.lblRev.AutoSize = True
        Me.lblRev.Location = New System.Drawing.Point(282, 23)
        Me.lblRev.Name = "lblRev"
        Me.lblRev.Size = New System.Drawing.Size(13, 13)
        Me.lblRev.TabIndex = 8
        Me.lblRev.Text = "--"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(178, 23)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(13, 13)
        Me.lblId.TabIndex = 7
        Me.lblId.Text = "--"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Revision:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID:"
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Location = New System.Drawing.Point(74, 23)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(13, 13)
        Me.lblAddr.TabIndex = 4
        Me.lblAddr.Text = "--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address:"
        '
        'chkChargerTimerEn
        '
        Me.chkChargerTimerEn.AutoSize = True
        Me.chkChargerTimerEn.Location = New System.Drawing.Point(245, 95)
        Me.chkChargerTimerEn.Name = "chkChargerTimerEn"
        Me.chkChargerTimerEn.Size = New System.Drawing.Size(75, 17)
        Me.chkChargerTimerEn.TabIndex = 55
        Me.chkChargerTimerEn.Text = "Vbus OVP"
        Me.chkChargerTimerEn.UseVisualStyleBackColor = True
        '
        'chkWatchDogEn
        '
        Me.chkWatchDogEn.AutoSize = True
        Me.chkWatchDogEn.Location = New System.Drawing.Point(245, 70)
        Me.chkWatchDogEn.Name = "chkWatchDogEn"
        Me.chkWatchDogEn.Size = New System.Drawing.Size(75, 17)
        Me.chkWatchDogEn.TabIndex = 54
        Me.chkWatchDogEn.Text = "Vbus OVP"
        Me.chkWatchDogEn.UseVisualStyleBackColor = True
        '
        'chkMissBatteryDetEn
        '
        Me.chkMissBatteryDetEn.AutoSize = True
        Me.chkMissBatteryDetEn.Location = New System.Drawing.Point(245, 46)
        Me.chkMissBatteryDetEn.Name = "chkMissBatteryDetEn"
        Me.chkMissBatteryDetEn.Size = New System.Drawing.Size(75, 17)
        Me.chkMissBatteryDetEn.TabIndex = 52
        Me.chkMissBatteryDetEn.Text = "Vbus OVP"
        Me.chkMissBatteryDetEn.UseVisualStyleBackColor = True
        '
        'chkIinForceIncrementEn
        '
        Me.chkIinForceIncrementEn.AutoSize = True
        Me.chkIinForceIncrementEn.Location = New System.Drawing.Point(245, 21)
        Me.chkIinForceIncrementEn.Name = "chkIinForceIncrementEn"
        Me.chkIinForceIncrementEn.Size = New System.Drawing.Size(75, 17)
        Me.chkIinForceIncrementEn.TabIndex = 51
        Me.chkIinForceIncrementEn.Text = "Vbus OVP"
        Me.chkIinForceIncrementEn.UseVisualStyleBackColor = True
        '
        'cmbOVDelta
        '
        Me.cmbOVDelta.FormattingEnabled = True
        Me.cmbOVDelta.Location = New System.Drawing.Point(137, 47)
        Me.cmbOVDelta.Name = "cmbOVDelta"
        Me.cmbOVDelta.Size = New System.Drawing.Size(68, 21)
        Me.cmbOVDelta.TabIndex = 49
        '
        'lblOVDelta
        '
        Me.lblOVDelta.AutoSize = True
        Me.lblOVDelta.Location = New System.Drawing.Point(14, 50)
        Me.lblOVDelta.Name = "lblOVDelta"
        Me.lblOVDelta.Size = New System.Drawing.Size(50, 13)
        Me.lblOVDelta.TabIndex = 48
        Me.lblOVDelta.Text = "OV Delta"
        '
        'cmbChargerTimer
        '
        Me.cmbChargerTimer.FormattingEnabled = True
        Me.cmbChargerTimer.Location = New System.Drawing.Point(137, 75)
        Me.cmbChargerTimer.Name = "cmbChargerTimer"
        Me.cmbChargerTimer.Size = New System.Drawing.Size(68, 21)
        Me.cmbChargerTimer.TabIndex = 47
        '
        'cmbWatchdogCfg
        '
        Me.cmbWatchdogCfg.FormattingEnabled = True
        Me.cmbWatchdogCfg.Location = New System.Drawing.Point(137, 102)
        Me.cmbWatchdogCfg.Name = "cmbWatchdogCfg"
        Me.cmbWatchdogCfg.Size = New System.Drawing.Size(68, 21)
        Me.cmbWatchdogCfg.TabIndex = 45
        '
        'lblWatchdogCfg
        '
        Me.lblWatchdogCfg.AutoSize = True
        Me.lblWatchdogCfg.Location = New System.Drawing.Point(14, 105)
        Me.lblWatchdogCfg.Name = "lblWatchdogCfg"
        Me.lblWatchdogCfg.Size = New System.Drawing.Size(59, 13)
        Me.lblWatchdogCfg.TabIndex = 44
        Me.lblWatchdogCfg.Text = "WatchDog"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslConnection, Me.tslInterface})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(701, 25)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslConnection
        '
        Me.tslConnection.Image = CType(resources.GetObject("tslConnection.Image"), System.Drawing.Image)
        Me.tslConnection.Name = "tslConnection"
        Me.tslConnection.Size = New System.Drawing.Size(99, 20)
        Me.tslConnection.Text = "Disconnected"
        '
        'tslInterface
        '
        Me.tslInterface.Name = "tslInterface"
        Me.tslInterface.Size = New System.Drawing.Size(587, 20)
        Me.tslInterface.Spring = True
        Me.tslInterface.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCA9468.My.Resources.Resources.NXP_logo_s
        Me.PictureBox1.Location = New System.Drawing.Point(597, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'lblChargerTimer
        '
        Me.lblChargerTimer.AutoSize = True
        Me.lblChargerTimer.Location = New System.Drawing.Point(14, 77)
        Me.lblChargerTimer.Name = "lblChargerTimer"
        Me.lblChargerTimer.Size = New System.Drawing.Size(73, 13)
        Me.lblChargerTimer.TabIndex = 46
        Me.lblChargerTimer.Text = "Charger Timer"
        '
        'tmrWork
        '
        '
        'lblVFloatVal
        '
        Me.lblVFloatVal.AutoSize = True
        Me.lblVFloatVal.Location = New System.Drawing.Point(332, 161)
        Me.lblVFloatVal.Name = "lblVFloatVal"
        Me.lblVFloatVal.Size = New System.Drawing.Size(14, 13)
        Me.lblVFloatVal.TabIndex = 40
        Me.lblVFloatVal.Text = "V"
        '
        'trbVFloat
        '
        Me.trbVFloat.AutoSize = False
        Me.trbVFloat.Location = New System.Drawing.Point(137, 161)
        Me.trbVFloat.Name = "trbVFloat"
        Me.trbVFloat.Size = New System.Drawing.Size(189, 25)
        Me.trbVFloat.TabIndex = 39
        '
        'lblVFloat
        '
        Me.lblVFloat.AutoSize = True
        Me.lblVFloat.Location = New System.Drawing.Point(14, 161)
        Me.lblVFloat.Name = "lblVFloat"
        Me.lblVFloat.Size = New System.Drawing.Size(40, 13)
        Me.lblVFloat.TabIndex = 38
        Me.lblVFloat.Text = "V Float"
        '
        'cmbUVDelta
        '
        Me.cmbUVDelta.FormattingEnabled = True
        Me.cmbUVDelta.Location = New System.Drawing.Point(137, 20)
        Me.cmbUVDelta.Name = "cmbUVDelta"
        Me.cmbUVDelta.Size = New System.Drawing.Size(68, 21)
        Me.cmbUVDelta.TabIndex = 28
        '
        'tbpProt
        '
        Me.tbpProt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpProt.Controls.Add(Me.chkForceUnplugStandby)
        Me.tbpProt.Controls.Add(Me.btnProtectRead)
        Me.tbpProt.Controls.Add(Me.btnProtectSet)
        Me.tbpProt.Controls.Add(Me.chkChargerTimerEn)
        Me.tbpProt.Controls.Add(Me.chkWatchDogEn)
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
        Me.tbpProt.Location = New System.Drawing.Point(4, 25)
        Me.tbpProt.Name = "tbpProt"
        Me.tbpProt.Size = New System.Drawing.Size(500, 244)
        Me.tbpProt.TabIndex = 4
        Me.tbpProt.Text = "Protection"
        Me.tbpProt.UseVisualStyleBackColor = True
        '
        'chkForceUnplugStandby
        '
        Me.chkForceUnplugStandby.AutoSize = True
        Me.chkForceUnplugStandby.Location = New System.Drawing.Point(245, 119)
        Me.chkForceUnplugStandby.Name = "chkForceUnplugStandby"
        Me.chkForceUnplugStandby.Size = New System.Drawing.Size(90, 17)
        Me.chkForceUnplugStandby.TabIndex = 60
        Me.chkForceUnplugStandby.Text = "Force Unplug"
        Me.chkForceUnplugStandby.UseVisualStyleBackColor = True
        '
        'btnProtectRead
        '
        Me.btnProtectRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnProtectRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProtectRead.Location = New System.Drawing.Point(346, 219)
        Me.btnProtectRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProtectRead.Name = "btnProtectRead"
        Me.btnProtectRead.Size = New System.Drawing.Size(57, 21)
        Me.btnProtectRead.TabIndex = 59
        Me.btnProtectRead.Text = "Read"
        Me.btnProtectRead.UseVisualStyleBackColor = False
        '
        'btnProtectSet
        '
        Me.btnProtectSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProtectSet.Location = New System.Drawing.Point(284, 219)
        Me.btnProtectSet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProtectSet.Name = "btnProtectSet"
        Me.btnProtectSet.Size = New System.Drawing.Size(57, 21)
        Me.btnProtectSet.TabIndex = 58
        Me.btnProtectSet.Text = "Set"
        Me.btnProtectSet.UseVisualStyleBackColor = False
        '
        'lblUVDelta
        '
        Me.lblUVDelta.AutoSize = True
        Me.lblUVDelta.Location = New System.Drawing.Point(14, 21)
        Me.lblUVDelta.Name = "lblUVDelta"
        Me.lblUVDelta.Size = New System.Drawing.Size(47, 13)
        Me.lblUVDelta.TabIndex = 27
        Me.lblUVDelta.Text = "UVDelta"
        '
        'chkCfgEn
        '
        Me.chkCfgEn.AutoSize = True
        Me.chkCfgEn.Location = New System.Drawing.Point(245, 21)
        Me.chkCfgEn.Name = "chkCfgEn"
        Me.chkCfgEn.Size = New System.Drawing.Size(54, 17)
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
        Me.pnlFunctions.Location = New System.Drawing.Point(0, 95)
        Me.pnlFunctions.Name = "pnlFunctions"
        Me.pnlFunctions.Size = New System.Drawing.Size(697, 404)
        Me.pnlFunctions.TabIndex = 34
        '
        'btnCurrentADCRead
        '
        Me.btnCurrentADCRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCurrentADCRead.Location = New System.Drawing.Point(24, 377)
        Me.btnCurrentADCRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCurrentADCRead.Name = "btnCurrentADCRead"
        Me.btnCurrentADCRead.Size = New System.Drawing.Size(57, 21)
        Me.btnCurrentADCRead.TabIndex = 60
        Me.btnCurrentADCRead.Text = "Read"
        Me.btnCurrentADCRead.UseVisualStyleBackColor = False
        '
        'GrpBoxSTSD
        '
        Me.GrpBoxSTSD.Controls.Add(Me.txtIchgStatus)
        Me.GrpBoxSTSD.Location = New System.Drawing.Point(104, 285)
        Me.GrpBoxSTSD.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpBoxSTSD.Name = "GrpBoxSTSD"
        Me.GrpBoxSTSD.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpBoxSTSD.Size = New System.Drawing.Size(80, 58)
        Me.GrpBoxSTSD.TabIndex = 38
        Me.GrpBoxSTSD.TabStop = False
        Me.GrpBoxSTSD.Text = "I Charge"
        '
        'txtIchgStatus
        '
        Me.txtIchgStatus.Location = New System.Drawing.Point(5, 28)
        Me.txtIchgStatus.Name = "txtIchgStatus"
        Me.txtIchgStatus.ReadOnly = True
        Me.txtIchgStatus.Size = New System.Drawing.Size(68, 20)
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
        Me.grpRaised.Location = New System.Drawing.Point(12, 3)
        Me.grpRaised.Name = "grpRaised"
        Me.grpRaised.Size = New System.Drawing.Size(172, 273)
        Me.grpRaised.TabIndex = 28
        Me.grpRaised.TabStop = False
        Me.grpRaised.Text = "Raised interrupts"
        '
        'btnRaisedIntRead
        '
        Me.btnRaisedIntRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaisedIntRead.Location = New System.Drawing.Point(12, 246)
        Me.btnRaisedIntRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRaisedIntRead.Name = "btnRaisedIntRead"
        Me.btnRaisedIntRead.Size = New System.Drawing.Size(57, 21)
        Me.btnRaisedIntRead.TabIndex = 59
        Me.btnRaisedIntRead.Text = "Read"
        Me.btnRaisedIntRead.UseVisualStyleBackColor = False
        '
        'chkTimerInt
        '
        Me.chkTimerInt.Location = New System.Drawing.Point(14, 161)
        Me.chkTimerInt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTimerInt.Name = "chkTimerInt"
        Me.chkTimerInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkTimerInt.Size = New System.Drawing.Size(144, 17)
        Me.chkTimerInt.TabIndex = 43
        Me.chkTimerInt.Text = "Vbus OVP"
        Me.chkTimerInt.UseVisualStyleBackColor = True
        '
        'chkADCDoneInt
        '
        Me.chkADCDoneInt.Location = New System.Drawing.Point(14, 138)
        Me.chkADCDoneInt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkADCDoneInt.Name = "chkADCDoneInt"
        Me.chkADCDoneInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkADCDoneInt.Size = New System.Drawing.Size(144, 17)
        Me.chkADCDoneInt.TabIndex = 42
        Me.chkADCDoneInt.Text = "Vbus OVP"
        Me.chkADCDoneInt.UseVisualStyleBackColor = True
        '
        'chkTempRegInt
        '
        Me.chkTempRegInt.Location = New System.Drawing.Point(14, 115)
        Me.chkTempRegInt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTempRegInt.Name = "chkTempRegInt"
        Me.chkTempRegInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkTempRegInt.Size = New System.Drawing.Size(144, 17)
        Me.chkTempRegInt.TabIndex = 41
        Me.chkTempRegInt.Text = "Vbus OVP"
        Me.chkTempRegInt.UseVisualStyleBackColor = True
        '
        'chkCtrlLimitInt
        '
        Me.chkCtrlLimitInt.Location = New System.Drawing.Point(14, 92)
        Me.chkCtrlLimitInt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCtrlLimitInt.Name = "chkCtrlLimitInt"
        Me.chkCtrlLimitInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkCtrlLimitInt.Size = New System.Drawing.Size(144, 17)
        Me.chkCtrlLimitInt.TabIndex = 40
        Me.chkCtrlLimitInt.Text = "Vbus OVP"
        Me.chkCtrlLimitInt.UseVisualStyleBackColor = True
        '
        'chkChgPhaseInt
        '
        Me.chkChgPhaseInt.Location = New System.Drawing.Point(14, 71)
        Me.chkChgPhaseInt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkChgPhaseInt.Name = "chkChgPhaseInt"
        Me.chkChgPhaseInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkChgPhaseInt.Size = New System.Drawing.Size(144, 17)
        Me.chkChgPhaseInt.TabIndex = 38
        Me.chkChgPhaseInt.Text = "Vbus OVP"
        Me.chkChgPhaseInt.UseVisualStyleBackColor = True
        '
        'chkNTCtempInt
        '
        Me.chkNTCtempInt.Location = New System.Drawing.Point(14, 48)
        Me.chkNTCtempInt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNTCtempInt.Name = "chkNTCtempInt"
        Me.chkNTCtempInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkNTCtempInt.Size = New System.Drawing.Size(144, 17)
        Me.chkNTCtempInt.TabIndex = 37
        Me.chkNTCtempInt.Text = "Vbus OVP"
        Me.chkNTCtempInt.UseVisualStyleBackColor = True
        '
        'chkVOkInt
        '
        Me.chkVOkInt.Location = New System.Drawing.Point(14, 25)
        Me.chkVOkInt.Margin = New System.Windows.Forms.Padding(2)
        Me.chkVOkInt.Name = "chkVOkInt"
        Me.chkVOkInt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVOkInt.Size = New System.Drawing.Size(144, 17)
        Me.chkVOkInt.TabIndex = 36
        Me.chkVOkInt.Text = "V OK Int"
        Me.chkVOkInt.UseVisualStyleBackColor = True
        '
        'GrpBoxSTSC
        '
        Me.GrpBoxSTSC.Controls.Add(Me.txtIinStatus)
        Me.GrpBoxSTSC.Location = New System.Drawing.Point(12, 285)
        Me.GrpBoxSTSC.Margin = New System.Windows.Forms.Padding(2)
        Me.GrpBoxSTSC.Name = "GrpBoxSTSC"
        Me.GrpBoxSTSC.Padding = New System.Windows.Forms.Padding(2)
        Me.GrpBoxSTSC.Size = New System.Drawing.Size(81, 58)
        Me.GrpBoxSTSC.TabIndex = 37
        Me.GrpBoxSTSC.TabStop = False
        Me.GrpBoxSTSC.Text = "I Input"
        '
        'txtIinStatus
        '
        Me.txtIinStatus.Location = New System.Drawing.Point(12, 28)
        Me.txtIinStatus.Name = "txtIinStatus"
        Me.txtIinStatus.ReadOnly = True
        Me.txtIinStatus.Size = New System.Drawing.Size(60, 20)
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
        Me.grpAdcChannels.Location = New System.Drawing.Point(193, 286)
        Me.grpAdcChannels.Name = "grpAdcChannels"
        Me.grpAdcChannels.Size = New System.Drawing.Size(502, 115)
        Me.grpAdcChannels.TabIndex = 30
        Me.grpAdcChannels.TabStop = False
        Me.grpAdcChannels.Text = "ADC channels"
        '
        'btnReadADC
        '
        Me.btnReadADC.BackColor = System.Drawing.SystemColors.Control
        Me.btnReadADC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReadADC.Location = New System.Drawing.Point(347, 92)
        Me.btnReadADC.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReadADC.Name = "btnReadADC"
        Me.btnReadADC.Size = New System.Drawing.Size(57, 21)
        Me.btnReadADC.TabIndex = 58
        Me.btnReadADC.Text = "Read"
        Me.btnReadADC.UseVisualStyleBackColor = False
        '
        'txtBatteryVoltage
        '
        Me.txtBatteryVoltage.Location = New System.Drawing.Point(313, 14)
        Me.txtBatteryVoltage.Name = "txtBatteryVoltage"
        Me.txtBatteryVoltage.ReadOnly = True
        Me.txtBatteryVoltage.Size = New System.Drawing.Size(78, 20)
        Me.txtBatteryVoltage.TabIndex = 26
        '
        'txtInputVoltage
        '
        Me.txtInputVoltage.Location = New System.Drawing.Point(313, 40)
        Me.txtInputVoltage.Name = "txtInputVoltage"
        Me.txtInputVoltage.ReadOnly = True
        Me.txtInputVoltage.Size = New System.Drawing.Size(78, 20)
        Me.txtInputVoltage.TabIndex = 26
        '
        'txtChargeCurrent
        '
        Me.txtChargeCurrent.Location = New System.Drawing.Point(122, 92)
        Me.txtChargeCurrent.Name = "txtChargeCurrent"
        Me.txtChargeCurrent.ReadOnly = True
        Me.txtChargeCurrent.Size = New System.Drawing.Size(72, 20)
        Me.txtChargeCurrent.TabIndex = 25
        '
        'txtInputCurrent
        '
        Me.txtInputCurrent.Location = New System.Drawing.Point(313, 68)
        Me.txtInputCurrent.Name = "txtInputCurrent"
        Me.txtInputCurrent.ReadOnly = True
        Me.txtInputCurrent.Size = New System.Drawing.Size(78, 20)
        Me.txtInputCurrent.TabIndex = 25
        '
        'txtDieTemp
        '
        Me.txtDieTemp.Location = New System.Drawing.Point(122, 66)
        Me.txtDieTemp.Name = "txtDieTemp"
        Me.txtDieTemp.ReadOnly = True
        Me.txtDieTemp.Size = New System.Drawing.Size(72, 20)
        Me.txtDieTemp.TabIndex = 24
        '
        'txtSysVoltage
        '
        Me.txtSysVoltage.Location = New System.Drawing.Point(122, 40)
        Me.txtSysVoltage.Name = "txtSysVoltage"
        Me.txtSysVoltage.ReadOnly = True
        Me.txtSysVoltage.Size = New System.Drawing.Size(72, 20)
        Me.txtSysVoltage.TabIndex = 23
        '
        'txtNtcAdc
        '
        Me.txtNtcAdc.Location = New System.Drawing.Point(122, 14)
        Me.txtNtcAdc.Name = "txtNtcAdc"
        Me.txtNtcAdc.ReadOnly = True
        Me.txtNtcAdc.Size = New System.Drawing.Size(72, 20)
        Me.txtNtcAdc.TabIndex = 22
        '
        'chkInputVoltageAdcEn
        '
        Me.chkInputVoltageAdcEn.AutoSize = True
        Me.chkInputVoltageAdcEn.Location = New System.Drawing.Point(214, 40)
        Me.chkInputVoltageAdcEn.Name = "chkInputVoltageAdcEn"
        Me.chkInputVoltageAdcEn.Size = New System.Drawing.Size(75, 17)
        Me.chkInputVoltageAdcEn.TabIndex = 19
        Me.chkInputVoltageAdcEn.Text = "Vbus OVP"
        Me.chkInputVoltageAdcEn.UseVisualStyleBackColor = True
        '
        'chkBatteryVoltageAdcEn
        '
        Me.chkBatteryVoltageAdcEn.AutoSize = True
        Me.chkBatteryVoltageAdcEn.Location = New System.Drawing.Point(214, 14)
        Me.chkBatteryVoltageAdcEn.Name = "chkBatteryVoltageAdcEn"
        Me.chkBatteryVoltageAdcEn.Size = New System.Drawing.Size(75, 17)
        Me.chkBatteryVoltageAdcEn.TabIndex = 18
        Me.chkBatteryVoltageAdcEn.Text = "Vbus OVP"
        Me.chkBatteryVoltageAdcEn.UseVisualStyleBackColor = True
        '
        'chkInputCurrentAdcEn
        '
        Me.chkInputCurrentAdcEn.AutoSize = True
        Me.chkInputCurrentAdcEn.Location = New System.Drawing.Point(214, 66)
        Me.chkInputCurrentAdcEn.Name = "chkInputCurrentAdcEn"
        Me.chkInputCurrentAdcEn.Size = New System.Drawing.Size(75, 17)
        Me.chkInputCurrentAdcEn.TabIndex = 17
        Me.chkInputCurrentAdcEn.Text = "Vbus OVP"
        Me.chkInputCurrentAdcEn.UseVisualStyleBackColor = True
        '
        'chkChrageCurrentAdcEn
        '
        Me.chkChrageCurrentAdcEn.AutoSize = True
        Me.chkChrageCurrentAdcEn.Location = New System.Drawing.Point(14, 95)
        Me.chkChrageCurrentAdcEn.Name = "chkChrageCurrentAdcEn"
        Me.chkChrageCurrentAdcEn.Size = New System.Drawing.Size(75, 17)
        Me.chkChrageCurrentAdcEn.TabIndex = 16
        Me.chkChrageCurrentAdcEn.Text = "Vbus OVP"
        Me.chkChrageCurrentAdcEn.UseVisualStyleBackColor = True
        '
        'chkDieTempAdcEn
        '
        Me.chkDieTempAdcEn.AutoSize = True
        Me.chkDieTempAdcEn.Location = New System.Drawing.Point(14, 69)
        Me.chkDieTempAdcEn.Name = "chkDieTempAdcEn"
        Me.chkDieTempAdcEn.Size = New System.Drawing.Size(75, 17)
        Me.chkDieTempAdcEn.TabIndex = 15
        Me.chkDieTempAdcEn.Text = "Vbus OVP"
        Me.chkDieTempAdcEn.UseVisualStyleBackColor = True
        '
        'chkSysVoltageAdcEn
        '
        Me.chkSysVoltageAdcEn.AutoSize = True
        Me.chkSysVoltageAdcEn.Location = New System.Drawing.Point(14, 43)
        Me.chkSysVoltageAdcEn.Name = "chkSysVoltageAdcEn"
        Me.chkSysVoltageAdcEn.Size = New System.Drawing.Size(75, 17)
        Me.chkSysVoltageAdcEn.TabIndex = 14
        Me.chkSysVoltageAdcEn.Text = "Vbus OVP"
        Me.chkSysVoltageAdcEn.UseVisualStyleBackColor = True
        '
        'chkNtcAdcEn
        '
        Me.chkNtcAdcEn.AutoSize = True
        Me.chkNtcAdcEn.Location = New System.Drawing.Point(14, 17)
        Me.chkNtcAdcEn.Name = "chkNtcAdcEn"
        Me.chkNtcAdcEn.Size = New System.Drawing.Size(75, 17)
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
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.tbpMisc)
        Me.TabControl2.Controls.Add(Me.tbpADCTest)
        Me.TabControl2.Location = New System.Drawing.Point(190, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(508, 273)
        Me.TabControl2.TabIndex = 29
        '
        'tbpControl
        '
        Me.tbpControl.BackColor = System.Drawing.SystemColors.Control
        Me.tbpControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpControl.Controls.Add(Me.cmbSwFreqCfg)
        Me.tbpControl.Controls.Add(Me.btnCtlRead)
        Me.tbpControl.Controls.Add(Me.btnCtlSet)
        Me.tbpControl.Controls.Add(Me.chkLimitIncrementEn)
        Me.tbpControl.Controls.Add(Me.chkRevCurrentDet)
        Me.tbpControl.Controls.Add(Me.chkStandbyEn)
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
        Me.tbpControl.Location = New System.Drawing.Point(4, 25)
        Me.tbpControl.Name = "tbpControl"
        Me.tbpControl.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpControl.Size = New System.Drawing.Size(500, 244)
        Me.tbpControl.TabIndex = 1
        Me.tbpControl.Text = "Control"
        '
        'cmbSwFreqCfg
        '
        Me.cmbSwFreqCfg.FormattingEnabled = True
        Me.cmbSwFreqCfg.Location = New System.Drawing.Point(137, 102)
        Me.cmbSwFreqCfg.Name = "cmbSwFreqCfg"
        Me.cmbSwFreqCfg.Size = New System.Drawing.Size(68, 21)
        Me.cmbSwFreqCfg.TabIndex = 58
        '
        'btnCtlRead
        '
        Me.btnCtlRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnCtlRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCtlRead.Location = New System.Drawing.Point(346, 219)
        Me.btnCtlRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCtlRead.Name = "btnCtlRead"
        Me.btnCtlRead.Size = New System.Drawing.Size(57, 21)
        Me.btnCtlRead.TabIndex = 57
        Me.btnCtlRead.Text = "Read"
        Me.btnCtlRead.UseVisualStyleBackColor = False
        '
        'btnCtlSet
        '
        Me.btnCtlSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCtlSet.Location = New System.Drawing.Point(284, 219)
        Me.btnCtlSet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCtlSet.Name = "btnCtlSet"
        Me.btnCtlSet.Size = New System.Drawing.Size(57, 21)
        Me.btnCtlSet.TabIndex = 56
        Me.btnCtlSet.Text = "Set"
        Me.btnCtlSet.UseVisualStyleBackColor = False
        '
        'chkLimitIncrementEn
        '
        Me.chkLimitIncrementEn.AutoSize = True
        Me.chkLimitIncrementEn.Enabled = False
        Me.chkLimitIncrementEn.Location = New System.Drawing.Point(245, 94)
        Me.chkLimitIncrementEn.Name = "chkLimitIncrementEn"
        Me.chkLimitIncrementEn.Size = New System.Drawing.Size(139, 17)
        Me.chkLimitIncrementEn.TabIndex = 55
        Me.chkLimitIncrementEn.Text = "Limit Increment Enabled"
        Me.chkLimitIncrementEn.UseVisualStyleBackColor = True
        '
        'cmbIinSoftStep
        '
        Me.cmbIinSoftStep.FormattingEnabled = True
        Me.cmbIinSoftStep.Location = New System.Drawing.Point(137, 75)
        Me.cmbIinSoftStep.Name = "cmbIinSoftStep"
        Me.cmbIinSoftStep.Size = New System.Drawing.Size(68, 21)
        Me.cmbIinSoftStep.TabIndex = 6
        '
        'lblIinSoftStep
        '
        Me.lblIinSoftStep.AutoSize = True
        Me.lblIinSoftStep.Location = New System.Drawing.Point(14, 77)
        Me.lblIinSoftStep.Name = "lblIinSoftStep"
        Me.lblIinSoftStep.Size = New System.Drawing.Size(58, 13)
        Me.lblIinSoftStep.TabIndex = 5
        Me.lblIinSoftStep.Text = "iinSoftStep"
        '
        'cmbChgSoftStep
        '
        Me.cmbChgSoftStep.FormattingEnabled = True
        Me.cmbChgSoftStep.Location = New System.Drawing.Point(137, 47)
        Me.cmbChgSoftStep.Name = "cmbChgSoftStep"
        Me.cmbChgSoftStep.Size = New System.Drawing.Size(68, 21)
        Me.cmbChgSoftStep.TabIndex = 4
        '
        'lblchgSoftStep
        '
        Me.lblchgSoftStep.AutoSize = True
        Me.lblchgSoftStep.Location = New System.Drawing.Point(14, 50)
        Me.lblchgSoftStep.Name = "lblchgSoftStep"
        Me.lblchgSoftStep.Size = New System.Drawing.Size(66, 13)
        Me.lblchgSoftStep.TabIndex = 3
        Me.lblchgSoftStep.Text = "chgSoftStep"
        '
        'cmbSenseR
        '
        Me.cmbSenseR.FormattingEnabled = True
        Me.cmbSenseR.Location = New System.Drawing.Point(137, 20)
        Me.cmbSenseR.Name = "cmbSenseR"
        Me.cmbSenseR.Size = New System.Drawing.Size(68, 21)
        Me.cmbSenseR.TabIndex = 2
        '
        'lblSenseR
        '
        Me.lblSenseR.AutoSize = True
        Me.lblSenseR.Location = New System.Drawing.Point(14, 21)
        Me.lblSenseR.Name = "lblSenseR"
        Me.lblSenseR.Size = New System.Drawing.Size(81, 13)
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
        Me.tbpThermal.Location = New System.Drawing.Point(4, 25)
        Me.tbpThermal.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpThermal.Name = "tbpThermal"
        Me.tbpThermal.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpThermal.Size = New System.Drawing.Size(500, 244)
        Me.tbpThermal.TabIndex = 5
        Me.tbpThermal.Text = "Thermal"
        Me.tbpThermal.UseVisualStyleBackColor = True
        '
        'btnThermalRead
        '
        Me.btnThermalRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnThermalRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnThermalRead.Location = New System.Drawing.Point(346, 219)
        Me.btnThermalRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnThermalRead.Name = "btnThermalRead"
        Me.btnThermalRead.Size = New System.Drawing.Size(57, 21)
        Me.btnThermalRead.TabIndex = 64
        Me.btnThermalRead.Text = "Read"
        Me.btnThermalRead.UseVisualStyleBackColor = False
        '
        'btnThermalSet
        '
        Me.btnThermalSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnThermalSet.Location = New System.Drawing.Point(284, 219)
        Me.btnThermalSet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnThermalSet.Name = "btnThermalSet"
        Me.btnThermalSet.Size = New System.Drawing.Size(57, 21)
        Me.btnThermalSet.TabIndex = 63
        Me.btnThermalSet.Text = "Set"
        Me.btnThermalSet.UseVisualStyleBackColor = False
        '
        'chkTempMaxEn
        '
        Me.chkTempMaxEn.AutoSize = True
        Me.chkTempMaxEn.Location = New System.Drawing.Point(245, 70)
        Me.chkTempMaxEn.Name = "chkTempMaxEn"
        Me.chkTempMaxEn.Size = New System.Drawing.Size(75, 17)
        Me.chkTempMaxEn.TabIndex = 62
        Me.chkTempMaxEn.Text = "Vbus OVP"
        Me.chkTempMaxEn.UseVisualStyleBackColor = True
        '
        'chkNtcProtectionEn
        '
        Me.chkNtcProtectionEn.AutoSize = True
        Me.chkNtcProtectionEn.Location = New System.Drawing.Point(245, 46)
        Me.chkNtcProtectionEn.Name = "chkNtcProtectionEn"
        Me.chkNtcProtectionEn.Size = New System.Drawing.Size(75, 17)
        Me.chkNtcProtectionEn.TabIndex = 61
        Me.chkNtcProtectionEn.Text = "Vbus OVP"
        Me.chkNtcProtectionEn.UseVisualStyleBackColor = True
        '
        'chkTempRegEn
        '
        Me.chkTempRegEn.AutoSize = True
        Me.chkTempRegEn.Location = New System.Drawing.Point(245, 21)
        Me.chkTempRegEn.Name = "chkTempRegEn"
        Me.chkTempRegEn.Size = New System.Drawing.Size(75, 17)
        Me.chkTempRegEn.TabIndex = 60
        Me.chkTempRegEn.Text = "Vbus OVP"
        Me.chkTempRegEn.UseVisualStyleBackColor = True
        '
        'cmbTempReg
        '
        Me.cmbTempReg.FormattingEnabled = True
        Me.cmbTempReg.Location = New System.Drawing.Point(137, 20)
        Me.cmbTempReg.Name = "cmbTempReg"
        Me.cmbTempReg.Size = New System.Drawing.Size(68, 21)
        Me.cmbTempReg.TabIndex = 59
        '
        'lblTempReg
        '
        Me.lblTempReg.AutoSize = True
        Me.lblTempReg.Location = New System.Drawing.Point(14, 21)
        Me.lblTempReg.Name = "lblTempReg"
        Me.lblTempReg.Size = New System.Drawing.Size(68, 13)
        Me.lblTempReg.TabIndex = 58
        Me.lblTempReg.Text = "Thermal Reg"
        '
        'cmbTempDelta
        '
        Me.cmbTempDelta.FormattingEnabled = True
        Me.cmbTempDelta.Location = New System.Drawing.Point(137, 47)
        Me.cmbTempDelta.Name = "cmbTempDelta"
        Me.cmbTempDelta.Size = New System.Drawing.Size(68, 21)
        Me.cmbTempDelta.TabIndex = 57
        '
        'lblTempDelta
        '
        Me.lblTempDelta.AutoSize = True
        Me.lblTempDelta.Location = New System.Drawing.Point(14, 50)
        Me.lblTempDelta.Name = "lblTempDelta"
        Me.lblTempDelta.Size = New System.Drawing.Size(62, 13)
        Me.lblTempDelta.TabIndex = 56
        Me.lblTempDelta.Text = "Temp Delta"
        '
        'lblNTCThresholdVal
        '
        Me.lblNTCThresholdVal.AutoSize = True
        Me.lblNTCThresholdVal.Location = New System.Drawing.Point(324, 161)
        Me.lblNTCThresholdVal.Name = "lblNTCThresholdVal"
        Me.lblNTCThresholdVal.Size = New System.Drawing.Size(39, 13)
        Me.lblNTCThresholdVal.TabIndex = 46
        Me.lblNTCThresholdVal.Text = "Label8"
        '
        'trbNTCThreshold
        '
        Me.trbNTCThreshold.AutoSize = False
        Me.trbNTCThreshold.Location = New System.Drawing.Point(137, 161)
        Me.trbNTCThreshold.Name = "trbNTCThreshold"
        Me.trbNTCThreshold.Size = New System.Drawing.Size(189, 25)
        Me.trbNTCThreshold.TabIndex = 45
        '
        'lblNTCThreshold
        '
        Me.lblNTCThreshold.AutoSize = True
        Me.lblNTCThreshold.Location = New System.Drawing.Point(14, 161)
        Me.lblNTCThreshold.Name = "lblNTCThreshold"
        Me.lblNTCThreshold.Size = New System.Drawing.Size(51, 13)
        Me.lblNTCThreshold.TabIndex = 44
        Me.lblNTCThreshold.Text = "NtcThres"
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.btnSpreadRead)
        Me.TabPage1.Controls.Add(Me.btnSpreadSet)
        Me.TabPage1.Controls.Add(Me.chkScClkDitherEn)
        Me.TabPage1.Controls.Add(Me.cmbScClkDitherLimit)
        Me.TabPage1.Controls.Add(Me.lblScClkDitherLimit)
        Me.TabPage1.Controls.Add(Me.cmbScClkDitherSR)
        Me.TabPage1.Controls.Add(Me.lblScClkDitherSR)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(500, 244)
        Me.TabPage1.TabIndex = 8
        Me.TabPage1.Text = "Spread Spectrum"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSpreadRead
        '
        Me.btnSpreadRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnSpreadRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpreadRead.Location = New System.Drawing.Point(346, 219)
        Me.btnSpreadRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpreadRead.Name = "btnSpreadRead"
        Me.btnSpreadRead.Size = New System.Drawing.Size(57, 21)
        Me.btnSpreadRead.TabIndex = 71
        Me.btnSpreadRead.Text = "Read"
        Me.btnSpreadRead.UseVisualStyleBackColor = False
        '
        'btnSpreadSet
        '
        Me.btnSpreadSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpreadSet.Location = New System.Drawing.Point(284, 219)
        Me.btnSpreadSet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpreadSet.Name = "btnSpreadSet"
        Me.btnSpreadSet.Size = New System.Drawing.Size(57, 21)
        Me.btnSpreadSet.TabIndex = 70
        Me.btnSpreadSet.Text = "Set"
        Me.btnSpreadSet.UseVisualStyleBackColor = False
        '
        'chkScClkDitherEn
        '
        Me.chkScClkDitherEn.AutoSize = True
        Me.chkScClkDitherEn.Location = New System.Drawing.Point(23, 89)
        Me.chkScClkDitherEn.Margin = New System.Windows.Forms.Padding(2)
        Me.chkScClkDitherEn.Name = "chkScClkDitherEn"
        Me.chkScClkDitherEn.Size = New System.Drawing.Size(162, 17)
        Me.chkScClkDitherEn.TabIndex = 69
        Me.chkScClkDitherEn.Text = "Spread Spectrum SR Enable"
        Me.chkScClkDitherEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkScClkDitherEn.UseVisualStyleBackColor = True
        '
        'cmbScClkDitherLimit
        '
        Me.cmbScClkDitherLimit.FormattingEnabled = True
        Me.cmbScClkDitherLimit.Location = New System.Drawing.Point(176, 48)
        Me.cmbScClkDitherLimit.Name = "cmbScClkDitherLimit"
        Me.cmbScClkDitherLimit.Size = New System.Drawing.Size(134, 21)
        Me.cmbScClkDitherLimit.TabIndex = 68
        '
        'lblScClkDitherLimit
        '
        Me.lblScClkDitherLimit.AutoSize = True
        Me.lblScClkDitherLimit.Location = New System.Drawing.Point(21, 48)
        Me.lblScClkDitherLimit.Name = "lblScClkDitherLimit"
        Me.lblScClkDitherLimit.Size = New System.Drawing.Size(75, 13)
        Me.lblScClkDitherLimit.TabIndex = 67
        Me.lblScClkDitherLimit.Text = "Max Deviation"
        '
        'cmbScClkDitherSR
        '
        Me.cmbScClkDitherSR.FormattingEnabled = True
        Me.cmbScClkDitherSR.Location = New System.Drawing.Point(176, 20)
        Me.cmbScClkDitherSR.Name = "cmbScClkDitherSR"
        Me.cmbScClkDitherSR.Size = New System.Drawing.Size(134, 21)
        Me.cmbScClkDitherSR.TabIndex = 65
        '
        'lblScClkDitherSR
        '
        Me.lblScClkDitherSR.AutoSize = True
        Me.lblScClkDitherSR.Location = New System.Drawing.Point(21, 22)
        Me.lblScClkDitherSR.Name = "lblScClkDitherSR"
        Me.lblScClkDitherSR.Size = New System.Drawing.Size(107, 13)
        Me.lblScClkDitherSR.TabIndex = 64
        Me.lblScClkDitherSR.Text = "Spread Spectrum SR"
        '
        'tbpMisc
        '
        Me.tbpMisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpMisc.Controls.Add(Me.gbxDebug)
        Me.tbpMisc.Location = New System.Drawing.Point(4, 25)
        Me.tbpMisc.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpMisc.Name = "tbpMisc"
        Me.tbpMisc.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpMisc.Size = New System.Drawing.Size(500, 244)
        Me.tbpMisc.TabIndex = 6
        Me.tbpMisc.Text = "Misc"
        Me.tbpMisc.UseVisualStyleBackColor = True
        '
        'gbxDebug
        '
        Me.gbxDebug.Controls.Add(Me.btnDbgRegRead6)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegSet6)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegAddr6)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegVal6)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegReadBack6)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegRead5)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegSet5)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegRead4)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegSet4)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegRead3)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegSet3)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegRead2)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegSet2)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegAddr5)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegVal5)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegReadBack5)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegAddr3)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegVal3)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegReadBack3)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegAddr4)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegVal4)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegReadBack4)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegAddr2)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegVal2)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegReadBack2)
        Me.gbxDebug.Controls.Add(Me.Label6)
        Me.gbxDebug.Controls.Add(Me.Label3)
        Me.gbxDebug.Controls.Add(Me.Label1)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegRead1)
        Me.gbxDebug.Controls.Add(Me.btnDbgRegSet1)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegAddr1)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegVal1)
        Me.gbxDebug.Controls.Add(Me.txtDbgRegReadBack1)
        Me.gbxDebug.Location = New System.Drawing.Point(14, 13)
        Me.gbxDebug.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxDebug.Name = "gbxDebug"
        Me.gbxDebug.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxDebug.Size = New System.Drawing.Size(376, 207)
        Me.gbxDebug.TabIndex = 31
        Me.gbxDebug.TabStop = False
        Me.gbxDebug.Text = "Debug Registers"
        '
        'btnDbgRegRead6
        '
        Me.btnDbgRegRead6.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegRead6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegRead6.Location = New System.Drawing.Point(298, 154)
        Me.btnDbgRegRead6.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegRead6.Name = "btnDbgRegRead6"
        Me.btnDbgRegRead6.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegRead6.TabIndex = 94
        Me.btnDbgRegRead6.Text = "Read"
        Me.btnDbgRegRead6.UseVisualStyleBackColor = False
        '
        'btnDbgRegSet6
        '
        Me.btnDbgRegSet6.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegSet6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegSet6.Location = New System.Drawing.Point(237, 154)
        Me.btnDbgRegSet6.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegSet6.Name = "btnDbgRegSet6"
        Me.btnDbgRegSet6.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegSet6.TabIndex = 93
        Me.btnDbgRegSet6.Text = "Set"
        Me.btnDbgRegSet6.UseVisualStyleBackColor = False
        '
        'txtDbgRegAddr6
        '
        Me.txtDbgRegAddr6.Location = New System.Drawing.Point(20, 154)
        Me.txtDbgRegAddr6.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegAddr6.MaxLength = 2
        Me.txtDbgRegAddr6.Name = "txtDbgRegAddr6"
        Me.txtDbgRegAddr6.Size = New System.Drawing.Size(52, 20)
        Me.txtDbgRegAddr6.TabIndex = 92
        '
        'txtDbgRegVal6
        '
        Me.txtDbgRegVal6.AutoCompleteCustomSource.AddRange(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "a", "b", "c", "d", "e", "f"})
        Me.txtDbgRegVal6.Location = New System.Drawing.Point(89, 154)
        Me.txtDbgRegVal6.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegVal6.MaxLength = 2
        Me.txtDbgRegVal6.Name = "txtDbgRegVal6"
        Me.txtDbgRegVal6.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegVal6.TabIndex = 91
        '
        'txtDbgRegReadBack6
        '
        Me.txtDbgRegReadBack6.Location = New System.Drawing.Point(159, 154)
        Me.txtDbgRegReadBack6.Name = "txtDbgRegReadBack6"
        Me.txtDbgRegReadBack6.ReadOnly = True
        Me.txtDbgRegReadBack6.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegReadBack6.TabIndex = 90
        '
        'btnDbgRegRead5
        '
        Me.btnDbgRegRead5.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegRead5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegRead5.Location = New System.Drawing.Point(298, 131)
        Me.btnDbgRegRead5.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegRead5.Name = "btnDbgRegRead5"
        Me.btnDbgRegRead5.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegRead5.TabIndex = 89
        Me.btnDbgRegRead5.Text = "Read"
        Me.btnDbgRegRead5.UseVisualStyleBackColor = False
        '
        'btnDbgRegSet5
        '
        Me.btnDbgRegSet5.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegSet5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegSet5.Location = New System.Drawing.Point(237, 131)
        Me.btnDbgRegSet5.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegSet5.Name = "btnDbgRegSet5"
        Me.btnDbgRegSet5.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegSet5.TabIndex = 88
        Me.btnDbgRegSet5.Text = "Set"
        Me.btnDbgRegSet5.UseVisualStyleBackColor = False
        '
        'btnDbgRegRead4
        '
        Me.btnDbgRegRead4.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegRead4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegRead4.Location = New System.Drawing.Point(298, 106)
        Me.btnDbgRegRead4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegRead4.Name = "btnDbgRegRead4"
        Me.btnDbgRegRead4.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegRead4.TabIndex = 87
        Me.btnDbgRegRead4.Text = "Read"
        Me.btnDbgRegRead4.UseVisualStyleBackColor = False
        '
        'btnDbgRegSet4
        '
        Me.btnDbgRegSet4.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegSet4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegSet4.Location = New System.Drawing.Point(237, 106)
        Me.btnDbgRegSet4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegSet4.Name = "btnDbgRegSet4"
        Me.btnDbgRegSet4.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegSet4.TabIndex = 86
        Me.btnDbgRegSet4.Text = "Set"
        Me.btnDbgRegSet4.UseVisualStyleBackColor = False
        '
        'btnDbgRegRead3
        '
        Me.btnDbgRegRead3.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegRead3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegRead3.Location = New System.Drawing.Point(298, 84)
        Me.btnDbgRegRead3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegRead3.Name = "btnDbgRegRead3"
        Me.btnDbgRegRead3.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegRead3.TabIndex = 85
        Me.btnDbgRegRead3.Text = "Read"
        Me.btnDbgRegRead3.UseVisualStyleBackColor = False
        '
        'btnDbgRegSet3
        '
        Me.btnDbgRegSet3.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegSet3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegSet3.Location = New System.Drawing.Point(237, 84)
        Me.btnDbgRegSet3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegSet3.Name = "btnDbgRegSet3"
        Me.btnDbgRegSet3.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegSet3.TabIndex = 84
        Me.btnDbgRegSet3.Text = "Set"
        Me.btnDbgRegSet3.UseVisualStyleBackColor = False
        '
        'btnDbgRegRead2
        '
        Me.btnDbgRegRead2.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegRead2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegRead2.Location = New System.Drawing.Point(298, 61)
        Me.btnDbgRegRead2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegRead2.Name = "btnDbgRegRead2"
        Me.btnDbgRegRead2.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegRead2.TabIndex = 83
        Me.btnDbgRegRead2.Text = "Read"
        Me.btnDbgRegRead2.UseVisualStyleBackColor = False
        '
        'btnDbgRegSet2
        '
        Me.btnDbgRegSet2.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegSet2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegSet2.Location = New System.Drawing.Point(237, 61)
        Me.btnDbgRegSet2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegSet2.Name = "btnDbgRegSet2"
        Me.btnDbgRegSet2.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegSet2.TabIndex = 82
        Me.btnDbgRegSet2.Text = "Set"
        Me.btnDbgRegSet2.UseVisualStyleBackColor = False
        '
        'txtDbgRegAddr5
        '
        Me.txtDbgRegAddr5.Location = New System.Drawing.Point(20, 131)
        Me.txtDbgRegAddr5.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegAddr5.MaxLength = 2
        Me.txtDbgRegAddr5.Name = "txtDbgRegAddr5"
        Me.txtDbgRegAddr5.Size = New System.Drawing.Size(52, 20)
        Me.txtDbgRegAddr5.TabIndex = 81
        '
        'txtDbgRegVal5
        '
        Me.txtDbgRegVal5.AutoCompleteCustomSource.AddRange(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "a", "b", "c", "d", "e", "f"})
        Me.txtDbgRegVal5.Location = New System.Drawing.Point(89, 131)
        Me.txtDbgRegVal5.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegVal5.MaxLength = 2
        Me.txtDbgRegVal5.Name = "txtDbgRegVal5"
        Me.txtDbgRegVal5.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegVal5.TabIndex = 80
        '
        'txtDbgRegReadBack5
        '
        Me.txtDbgRegReadBack5.Location = New System.Drawing.Point(159, 131)
        Me.txtDbgRegReadBack5.Name = "txtDbgRegReadBack5"
        Me.txtDbgRegReadBack5.ReadOnly = True
        Me.txtDbgRegReadBack5.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegReadBack5.TabIndex = 79
        '
        'txtDbgRegAddr3
        '
        Me.txtDbgRegAddr3.Location = New System.Drawing.Point(20, 84)
        Me.txtDbgRegAddr3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegAddr3.MaxLength = 2
        Me.txtDbgRegAddr3.Name = "txtDbgRegAddr3"
        Me.txtDbgRegAddr3.Size = New System.Drawing.Size(52, 20)
        Me.txtDbgRegAddr3.TabIndex = 76
        '
        'txtDbgRegVal3
        '
        Me.txtDbgRegVal3.AutoCompleteCustomSource.AddRange(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "a", "b", "c", "d", "e", "f"})
        Me.txtDbgRegVal3.Location = New System.Drawing.Point(89, 84)
        Me.txtDbgRegVal3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegVal3.MaxLength = 2
        Me.txtDbgRegVal3.Name = "txtDbgRegVal3"
        Me.txtDbgRegVal3.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegVal3.TabIndex = 75
        '
        'txtDbgRegReadBack3
        '
        Me.txtDbgRegReadBack3.Location = New System.Drawing.Point(159, 84)
        Me.txtDbgRegReadBack3.Name = "txtDbgRegReadBack3"
        Me.txtDbgRegReadBack3.ReadOnly = True
        Me.txtDbgRegReadBack3.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegReadBack3.TabIndex = 74
        '
        'txtDbgRegAddr4
        '
        Me.txtDbgRegAddr4.Location = New System.Drawing.Point(20, 106)
        Me.txtDbgRegAddr4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegAddr4.MaxLength = 2
        Me.txtDbgRegAddr4.Name = "txtDbgRegAddr4"
        Me.txtDbgRegAddr4.Size = New System.Drawing.Size(52, 20)
        Me.txtDbgRegAddr4.TabIndex = 71
        '
        'txtDbgRegVal4
        '
        Me.txtDbgRegVal4.AutoCompleteCustomSource.AddRange(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "a", "b", "c", "d", "e", "f"})
        Me.txtDbgRegVal4.Location = New System.Drawing.Point(89, 106)
        Me.txtDbgRegVal4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegVal4.MaxLength = 2
        Me.txtDbgRegVal4.Name = "txtDbgRegVal4"
        Me.txtDbgRegVal4.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegVal4.TabIndex = 70
        '
        'txtDbgRegReadBack4
        '
        Me.txtDbgRegReadBack4.Location = New System.Drawing.Point(159, 106)
        Me.txtDbgRegReadBack4.Name = "txtDbgRegReadBack4"
        Me.txtDbgRegReadBack4.ReadOnly = True
        Me.txtDbgRegReadBack4.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegReadBack4.TabIndex = 69
        '
        'txtDbgRegAddr2
        '
        Me.txtDbgRegAddr2.Location = New System.Drawing.Point(20, 61)
        Me.txtDbgRegAddr2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegAddr2.MaxLength = 2
        Me.txtDbgRegAddr2.Name = "txtDbgRegAddr2"
        Me.txtDbgRegAddr2.Size = New System.Drawing.Size(52, 20)
        Me.txtDbgRegAddr2.TabIndex = 66
        '
        'txtDbgRegVal2
        '
        Me.txtDbgRegVal2.AutoCompleteCustomSource.AddRange(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "a", "b", "c", "d", "e", "f"})
        Me.txtDbgRegVal2.Location = New System.Drawing.Point(89, 61)
        Me.txtDbgRegVal2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegVal2.MaxLength = 2
        Me.txtDbgRegVal2.Name = "txtDbgRegVal2"
        Me.txtDbgRegVal2.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegVal2.TabIndex = 65
        '
        'txtDbgRegReadBack2
        '
        Me.txtDbgRegReadBack2.Location = New System.Drawing.Point(159, 61)
        Me.txtDbgRegReadBack2.Name = "txtDbgRegReadBack2"
        Me.txtDbgRegReadBack2.ReadOnly = True
        Me.txtDbgRegReadBack2.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegReadBack2.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(157, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Read Back"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "RegVal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "RegAddr"
        '
        'btnDbgRegRead1
        '
        Me.btnDbgRegRead1.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegRead1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegRead1.Location = New System.Drawing.Point(298, 38)
        Me.btnDbgRegRead1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegRead1.Name = "btnDbgRegRead1"
        Me.btnDbgRegRead1.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegRead1.TabIndex = 60
        Me.btnDbgRegRead1.Text = "Read"
        Me.btnDbgRegRead1.UseVisualStyleBackColor = False
        '
        'btnDbgRegSet1
        '
        Me.btnDbgRegSet1.BackColor = System.Drawing.SystemColors.Control
        Me.btnDbgRegSet1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDbgRegSet1.Location = New System.Drawing.Point(237, 38)
        Me.btnDbgRegSet1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDbgRegSet1.Name = "btnDbgRegSet1"
        Me.btnDbgRegSet1.Size = New System.Drawing.Size(57, 18)
        Me.btnDbgRegSet1.TabIndex = 59
        Me.btnDbgRegSet1.Text = "Set"
        Me.btnDbgRegSet1.UseVisualStyleBackColor = False
        '
        'txtDbgRegAddr1
        '
        Me.txtDbgRegAddr1.Location = New System.Drawing.Point(20, 38)
        Me.txtDbgRegAddr1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegAddr1.MaxLength = 2
        Me.txtDbgRegAddr1.Name = "txtDbgRegAddr1"
        Me.txtDbgRegAddr1.Size = New System.Drawing.Size(52, 20)
        Me.txtDbgRegAddr1.TabIndex = 30
        '
        'txtDbgRegVal1
        '
        Me.txtDbgRegVal1.AutoCompleteCustomSource.AddRange(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "a", "b", "c", "d", "e", "f"})
        Me.txtDbgRegVal1.Location = New System.Drawing.Point(89, 38)
        Me.txtDbgRegVal1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDbgRegVal1.MaxLength = 2
        Me.txtDbgRegVal1.Name = "txtDbgRegVal1"
        Me.txtDbgRegVal1.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegVal1.TabIndex = 29
        '
        'txtDbgRegReadBack1
        '
        Me.txtDbgRegReadBack1.Location = New System.Drawing.Point(159, 38)
        Me.txtDbgRegReadBack1.Name = "txtDbgRegReadBack1"
        Me.txtDbgRegReadBack1.ReadOnly = True
        Me.txtDbgRegReadBack1.Size = New System.Drawing.Size(54, 20)
        Me.txtDbgRegReadBack1.TabIndex = 28
        '
        'tbpADCTest
        '
        Me.tbpADCTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpADCTest.Controls.Add(Me.Label21)
        Me.tbpADCTest.Controls.Add(Me.cmbADCAccDelay)
        Me.tbpADCTest.Controls.Add(Me.chkADCEnDis)
        Me.tbpADCTest.Controls.Add(Me.GroupBox3)
        Me.tbpADCTest.Controls.Add(Me.btnADCTestStart)
        Me.tbpADCTest.Controls.Add(Me.Label9)
        Me.tbpADCTest.Controls.Add(Me.txtXslFileName)
        Me.tbpADCTest.Controls.Add(Me.btnSaveADC)
        Me.tbpADCTest.Controls.Add(Me.Label7)
        Me.tbpADCTest.Controls.Add(Me.cmbADCTestRepeats)
        Me.tbpADCTest.Location = New System.Drawing.Point(4, 25)
        Me.tbpADCTest.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpADCTest.Name = "tbpADCTest"
        Me.tbpADCTest.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpADCTest.Size = New System.Drawing.Size(500, 244)
        Me.tbpADCTest.TabIndex = 7
        Me.tbpADCTest.Text = "ADC Test"
        Me.tbpADCTest.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(272, 10)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 13)
        Me.Label21.TabIndex = 88
        Me.Label21.Text = "Samples Taking Frequency"
        '
        'cmbADCAccDelay
        '
        Me.cmbADCAccDelay.FormattingEnabled = True
        Me.cmbADCAccDelay.Items.AddRange(New Object() {"Disabled", "100ms", "200ms"})
        Me.cmbADCAccDelay.Location = New System.Drawing.Point(285, 28)
        Me.cmbADCAccDelay.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbADCAccDelay.Name = "cmbADCAccDelay"
        Me.cmbADCAccDelay.Size = New System.Drawing.Size(73, 21)
        Me.cmbADCAccDelay.TabIndex = 87
        '
        'chkADCEnDis
        '
        Me.chkADCEnDis.Location = New System.Drawing.Point(350, 36)
        Me.chkADCEnDis.Margin = New System.Windows.Forms.Padding(2)
        Me.chkADCEnDis.Name = "chkADCEnDis"
        Me.chkADCEnDis.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkADCEnDis.Size = New System.Drawing.Size(62, 64)
        Me.chkADCEnDis.TabIndex = 60
        Me.chkADCEnDis.Text = "ADC AutoEn/Dis"
        Me.chkADCEnDis.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtADCAccNTCDelta)
        Me.GroupBox3.Controls.Add(Me.txtADCAccDieTempDelta)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVbatDelta)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVoutDelta)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVinDelta)
        Me.GroupBox3.Controls.Add(Me.txtADCAccIoutDelta)
        Me.GroupBox3.Controls.Add(Me.txtADCAccIINDelta)
        Me.GroupBox3.Controls.Add(Me.txtADCAccNTCMin)
        Me.GroupBox3.Controls.Add(Me.txtADCAccDieTempMin)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVbatMin)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVoutMin)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVinMin)
        Me.GroupBox3.Controls.Add(Me.txtADCAccIoutMin)
        Me.GroupBox3.Controls.Add(Me.txtADCAccIINMin)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtADCAccNtcMax)
        Me.GroupBox3.Controls.Add(Me.txtADCAccDieTempMax)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVbatMax)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVoutMax)
        Me.GroupBox3.Controls.Add(Me.txtADCAccVinMax)
        Me.GroupBox3.Controls.Add(Me.txtADCAccIoutMax)
        Me.GroupBox3.Controls.Add(Me.txtADCAccIINMax)
        Me.GroupBox3.Controls.Add(Me.txtADCAccNTCVoltage)
        Me.GroupBox3.Controls.Add(Me.txtADCAccDieTemp)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtADCAccBattVoltage)
        Me.GroupBox3.Controls.Add(Me.txtADCAccOutputVoltage)
        Me.GroupBox3.Controls.Add(Me.txtADCAccInputVoltage)
        Me.GroupBox3.Controls.Add(Me.txtADCAccOutputCurrent)
        Me.GroupBox3.Controls.Add(Me.txtADCAccInputCurrent)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 56)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(338, 188)
        Me.GroupBox3.TabIndex = 86
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(232, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 115
        Me.Label20.Text = "Delta"
        '
        'txtADCAccNTCDelta
        '
        Me.txtADCAccNTCDelta.Location = New System.Drawing.Point(220, 162)
        Me.txtADCAccNTCDelta.Name = "txtADCAccNTCDelta"
        Me.txtADCAccNTCDelta.ReadOnly = True
        Me.txtADCAccNTCDelta.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccNTCDelta.TabIndex = 114
        '
        'txtADCAccDieTempDelta
        '
        Me.txtADCAccDieTempDelta.Location = New System.Drawing.Point(220, 141)
        Me.txtADCAccDieTempDelta.Name = "txtADCAccDieTempDelta"
        Me.txtADCAccDieTempDelta.ReadOnly = True
        Me.txtADCAccDieTempDelta.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccDieTempDelta.TabIndex = 113
        '
        'txtADCAccVbatDelta
        '
        Me.txtADCAccVbatDelta.Location = New System.Drawing.Point(220, 119)
        Me.txtADCAccVbatDelta.Name = "txtADCAccVbatDelta"
        Me.txtADCAccVbatDelta.ReadOnly = True
        Me.txtADCAccVbatDelta.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVbatDelta.TabIndex = 112
        '
        'txtADCAccVoutDelta
        '
        Me.txtADCAccVoutDelta.Location = New System.Drawing.Point(220, 95)
        Me.txtADCAccVoutDelta.Name = "txtADCAccVoutDelta"
        Me.txtADCAccVoutDelta.ReadOnly = True
        Me.txtADCAccVoutDelta.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVoutDelta.TabIndex = 111
        '
        'txtADCAccVinDelta
        '
        Me.txtADCAccVinDelta.Location = New System.Drawing.Point(220, 72)
        Me.txtADCAccVinDelta.Name = "txtADCAccVinDelta"
        Me.txtADCAccVinDelta.ReadOnly = True
        Me.txtADCAccVinDelta.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVinDelta.TabIndex = 110
        '
        'txtADCAccIoutDelta
        '
        Me.txtADCAccIoutDelta.Location = New System.Drawing.Point(220, 50)
        Me.txtADCAccIoutDelta.Name = "txtADCAccIoutDelta"
        Me.txtADCAccIoutDelta.ReadOnly = True
        Me.txtADCAccIoutDelta.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccIoutDelta.TabIndex = 109
        '
        'txtADCAccIINDelta
        '
        Me.txtADCAccIINDelta.Location = New System.Drawing.Point(220, 26)
        Me.txtADCAccIINDelta.Name = "txtADCAccIINDelta"
        Me.txtADCAccIINDelta.ReadOnly = True
        Me.txtADCAccIINDelta.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccIINDelta.TabIndex = 108
        '
        'txtADCAccNTCMin
        '
        Me.txtADCAccNTCMin.Location = New System.Drawing.Point(156, 162)
        Me.txtADCAccNTCMin.Name = "txtADCAccNTCMin"
        Me.txtADCAccNTCMin.ReadOnly = True
        Me.txtADCAccNTCMin.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccNTCMin.TabIndex = 107
        '
        'txtADCAccDieTempMin
        '
        Me.txtADCAccDieTempMin.Location = New System.Drawing.Point(156, 141)
        Me.txtADCAccDieTempMin.Name = "txtADCAccDieTempMin"
        Me.txtADCAccDieTempMin.ReadOnly = True
        Me.txtADCAccDieTempMin.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccDieTempMin.TabIndex = 106
        '
        'txtADCAccVbatMin
        '
        Me.txtADCAccVbatMin.Location = New System.Drawing.Point(156, 119)
        Me.txtADCAccVbatMin.Name = "txtADCAccVbatMin"
        Me.txtADCAccVbatMin.ReadOnly = True
        Me.txtADCAccVbatMin.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVbatMin.TabIndex = 105
        '
        'txtADCAccVoutMin
        '
        Me.txtADCAccVoutMin.Location = New System.Drawing.Point(156, 95)
        Me.txtADCAccVoutMin.Name = "txtADCAccVoutMin"
        Me.txtADCAccVoutMin.ReadOnly = True
        Me.txtADCAccVoutMin.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVoutMin.TabIndex = 104
        '
        'txtADCAccVinMin
        '
        Me.txtADCAccVinMin.Location = New System.Drawing.Point(156, 72)
        Me.txtADCAccVinMin.Name = "txtADCAccVinMin"
        Me.txtADCAccVinMin.ReadOnly = True
        Me.txtADCAccVinMin.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVinMin.TabIndex = 103
        '
        'txtADCAccIoutMin
        '
        Me.txtADCAccIoutMin.Location = New System.Drawing.Point(156, 50)
        Me.txtADCAccIoutMin.Name = "txtADCAccIoutMin"
        Me.txtADCAccIoutMin.ReadOnly = True
        Me.txtADCAccIoutMin.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccIoutMin.TabIndex = 102
        '
        'txtADCAccIINMin
        '
        Me.txtADCAccIINMin.Location = New System.Drawing.Point(156, 26)
        Me.txtADCAccIINMin.Name = "txtADCAccIINMin"
        Me.txtADCAccIINMin.ReadOnly = True
        Me.txtADCAccIINMin.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccIINMin.TabIndex = 101
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(154, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "Min Reading"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(88, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Max Reading"
        '
        'txtADCAccNtcMax
        '
        Me.txtADCAccNtcMax.Location = New System.Drawing.Point(90, 162)
        Me.txtADCAccNtcMax.Name = "txtADCAccNtcMax"
        Me.txtADCAccNtcMax.ReadOnly = True
        Me.txtADCAccNtcMax.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccNtcMax.TabIndex = 91
        '
        'txtADCAccDieTempMax
        '
        Me.txtADCAccDieTempMax.Location = New System.Drawing.Point(90, 141)
        Me.txtADCAccDieTempMax.Name = "txtADCAccDieTempMax"
        Me.txtADCAccDieTempMax.ReadOnly = True
        Me.txtADCAccDieTempMax.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccDieTempMax.TabIndex = 90
        '
        'txtADCAccVbatMax
        '
        Me.txtADCAccVbatMax.Location = New System.Drawing.Point(90, 119)
        Me.txtADCAccVbatMax.Name = "txtADCAccVbatMax"
        Me.txtADCAccVbatMax.ReadOnly = True
        Me.txtADCAccVbatMax.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVbatMax.TabIndex = 89
        '
        'txtADCAccVoutMax
        '
        Me.txtADCAccVoutMax.Location = New System.Drawing.Point(90, 95)
        Me.txtADCAccVoutMax.Name = "txtADCAccVoutMax"
        Me.txtADCAccVoutMax.ReadOnly = True
        Me.txtADCAccVoutMax.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVoutMax.TabIndex = 88
        '
        'txtADCAccVinMax
        '
        Me.txtADCAccVinMax.Location = New System.Drawing.Point(90, 72)
        Me.txtADCAccVinMax.Name = "txtADCAccVinMax"
        Me.txtADCAccVinMax.ReadOnly = True
        Me.txtADCAccVinMax.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccVinMax.TabIndex = 87
        '
        'txtADCAccIoutMax
        '
        Me.txtADCAccIoutMax.Location = New System.Drawing.Point(90, 50)
        Me.txtADCAccIoutMax.Name = "txtADCAccIoutMax"
        Me.txtADCAccIoutMax.ReadOnly = True
        Me.txtADCAccIoutMax.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccIoutMax.TabIndex = 86
        '
        'txtADCAccIINMax
        '
        Me.txtADCAccIINMax.Location = New System.Drawing.Point(90, 26)
        Me.txtADCAccIINMax.Name = "txtADCAccIINMax"
        Me.txtADCAccIINMax.ReadOnly = True
        Me.txtADCAccIINMax.Size = New System.Drawing.Size(61, 20)
        Me.txtADCAccIINMax.TabIndex = 85
        '
        'txtADCAccNTCVoltage
        '
        Me.txtADCAccNTCVoltage.Location = New System.Drawing.Point(286, 162)
        Me.txtADCAccNTCVoltage.Name = "txtADCAccNTCVoltage"
        Me.txtADCAccNTCVoltage.ReadOnly = True
        Me.txtADCAccNTCVoltage.Size = New System.Drawing.Size(33, 20)
        Me.txtADCAccNTCVoltage.TabIndex = 83
        '
        'txtADCAccDieTemp
        '
        Me.txtADCAccDieTemp.Location = New System.Drawing.Point(286, 143)
        Me.txtADCAccDieTemp.Name = "txtADCAccDieTemp"
        Me.txtADCAccDieTemp.ReadOnly = True
        Me.txtADCAccDieTemp.Size = New System.Drawing.Size(33, 20)
        Me.txtADCAccDieTemp.TabIndex = 82
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(280, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "LSB Delta"
        '
        'txtADCAccBattVoltage
        '
        Me.txtADCAccBattVoltage.Location = New System.Drawing.Point(286, 119)
        Me.txtADCAccBattVoltage.Name = "txtADCAccBattVoltage"
        Me.txtADCAccBattVoltage.ReadOnly = True
        Me.txtADCAccBattVoltage.Size = New System.Drawing.Size(33, 20)
        Me.txtADCAccBattVoltage.TabIndex = 81
        '
        'txtADCAccOutputVoltage
        '
        Me.txtADCAccOutputVoltage.Location = New System.Drawing.Point(286, 95)
        Me.txtADCAccOutputVoltage.Name = "txtADCAccOutputVoltage"
        Me.txtADCAccOutputVoltage.ReadOnly = True
        Me.txtADCAccOutputVoltage.Size = New System.Drawing.Size(33, 20)
        Me.txtADCAccOutputVoltage.TabIndex = 80
        '
        'txtADCAccInputVoltage
        '
        Me.txtADCAccInputVoltage.Location = New System.Drawing.Point(286, 72)
        Me.txtADCAccInputVoltage.Name = "txtADCAccInputVoltage"
        Me.txtADCAccInputVoltage.ReadOnly = True
        Me.txtADCAccInputVoltage.Size = New System.Drawing.Size(33, 20)
        Me.txtADCAccInputVoltage.TabIndex = 79
        '
        'txtADCAccOutputCurrent
        '
        Me.txtADCAccOutputCurrent.Location = New System.Drawing.Point(286, 50)
        Me.txtADCAccOutputCurrent.Name = "txtADCAccOutputCurrent"
        Me.txtADCAccOutputCurrent.ReadOnly = True
        Me.txtADCAccOutputCurrent.Size = New System.Drawing.Size(33, 20)
        Me.txtADCAccOutputCurrent.TabIndex = 78
        '
        'txtADCAccInputCurrent
        '
        Me.txtADCAccInputCurrent.Location = New System.Drawing.Point(286, 26)
        Me.txtADCAccInputCurrent.Name = "txtADCAccInputCurrent"
        Me.txtADCAccInputCurrent.ReadOnly = True
        Me.txtADCAccInputCurrent.Size = New System.Drawing.Size(33, 20)
        Me.txtADCAccInputCurrent.TabIndex = 77
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 162)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "NTC Voltage"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 141)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "Die Temperature"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 119)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Battery Voltage"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 97)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Output Voltage"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 74)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Input Voltage"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 51)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Output Current"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 28)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Input Current"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "ADC Channel"
        '
        'btnADCTestStart
        '
        Me.btnADCTestStart.BackColor = System.Drawing.SystemColors.Control
        Me.btnADCTestStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnADCTestStart.Location = New System.Drawing.Point(346, 176)
        Me.btnADCTestStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnADCTestStart.Name = "btnADCTestStart"
        Me.btnADCTestStart.Size = New System.Drawing.Size(57, 21)
        Me.btnADCTestStart.TabIndex = 85
        Me.btnADCTestStart.Text = "Test"
        Me.btnADCTestStart.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(92, 10)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "File Name"
        '
        'txtXslFileName
        '
        Me.txtXslFileName.Location = New System.Drawing.Point(94, 28)
        Me.txtXslFileName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtXslFileName.Name = "txtXslFileName"
        Me.txtXslFileName.ReadOnly = True
        Me.txtXslFileName.Size = New System.Drawing.Size(174, 20)
        Me.txtXslFileName.TabIndex = 60
        '
        'btnSaveADC
        '
        Me.btnSaveADC.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaveADC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveADC.Location = New System.Drawing.Point(346, 217)
        Me.btnSaveADC.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveADC.Name = "btnSaveADC"
        Me.btnSaveADC.Size = New System.Drawing.Size(57, 21)
        Me.btnSaveADC.TabIndex = 59
        Me.btnSaveADC.Text = "Save"
        Me.btnSaveADC.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Repeats"
        '
        'cmbADCTestRepeats
        '
        Me.cmbADCTestRepeats.FormattingEnabled = True
        Me.cmbADCTestRepeats.Items.AddRange(New Object() {"10", "50", "100", "200", "500"})
        Me.cmbADCTestRepeats.Location = New System.Drawing.Point(14, 28)
        Me.cmbADCTestRepeats.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbADCTestRepeats.Name = "cmbADCTestRepeats"
        Me.cmbADCTestRepeats.Size = New System.Drawing.Size(62, 21)
        Me.cmbADCTestRepeats.TabIndex = 0
        '
        'tsbRefresh
        '
        Me.tsbRefresh.Image = Global.PCA9468.My.Resources.Resources.clock
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(92, 24)
        Me.tsbRefresh.Text = "Auto refresh"
        Me.tsbRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'tsbRegisters
        '
        Me.tsbRegisters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRegisters.Image = Global.PCA9468.My.Resources.Resources.table
        Me.tsbRegisters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRegisters.Name = "tsbRegisters"
        Me.tsbRegisters.Size = New System.Drawing.Size(24, 24)
        Me.tsbRegisters.Text = "Register map"
        '
        'tsbFunctions
        '
        Me.tsbFunctions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFunctions.Image = CType(resources.GetObject("tsbFunctions.Image"), System.Drawing.Image)
        Me.tsbFunctions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFunctions.Name = "tsbFunctions"
        Me.tsbFunctions.Size = New System.Drawing.Size(24, 24)
        Me.tsbFunctions.Text = "Functions"
        Me.tsbFunctions.ToolTipText = "Functional view"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'tsbReset
        '
        Me.tsbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReset.Image = Global.PCA9468.My.Resources.Resources.counter_reset
        Me.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReset.Name = "tsbReset"
        Me.tsbReset.Size = New System.Drawing.Size(24, 24)
        Me.tsbReset.Text = "Reset device"
        Me.tsbReset.ToolTipText = "Reset PCA9468"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'tsbRead
        '
        Me.tsbRead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRead.Image = Global.PCA9468.My.Resources.Resources.spectacle
        Me.tsbRead.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRead.Name = "tsbRead"
        Me.tsbRead.Size = New System.Drawing.Size(24, 24)
        Me.tsbRead.Text = "Read all"
        Me.tsbRead.ToolTipText = "Read all registers"
        '
        'tsbWrite
        '
        Me.tsbWrite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbWrite.Image = Global.PCA9468.My.Resources.Resources.pencil__arrow
        Me.tsbWrite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbWrite.Name = "tsbWrite"
        Me.tsbWrite.Size = New System.Drawing.Size(24, 24)
        Me.tsbWrite.Text = "Write all"
        Me.tsbWrite.ToolTipText = "Write all registers"
        '
        'theToolbar
        '
        Me.theToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.theToolbar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.theToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbWrite, Me.tsbRead, Me.ToolStripSeparator4, Me.tsbReset, Me.ToolStripSeparator5, Me.tsbFunctions, Me.tsbRegisters, Me.ToolStripSeparator6, Me.tsbRefresh, Me.tscRefresh})
        Me.theToolbar.Location = New System.Drawing.Point(0, 24)
        Me.theToolbar.Name = "theToolbar"
        Me.theToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.theToolbar.Size = New System.Drawing.Size(701, 27)
        Me.theToolbar.TabIndex = 33
        Me.theToolbar.Text = "ToolStrip1"
        '
        'tscRefresh
        '
        Me.tscRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscRefresh.Items.AddRange(New Object() {"Disabled", "1 / second", "2 / second", "4 / second"})
        Me.tscRefresh.Name = "tscRefresh"
        Me.tscRefresh.Size = New System.Drawing.Size(121, 27)
        Me.tscRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'tsmManual
        '
        Me.tsmManual.Name = "tsmManual"
        Me.tsmManual.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.tsmManual.Size = New System.Drawing.Size(220, 22)
        Me.tsmManual.Text = "Open the User Manual..."
        Me.tsmManual.ToolTipText = "Open the User Manual with an external PDF viewer"
        '
        'tsmAbout
        '
        Me.tsmAbout.Name = "tsmAbout"
        Me.tsmAbout.ShortcutKeyDisplayString = ""
        Me.tsmAbout.Size = New System.Drawing.Size(220, 22)
        Me.tsmAbout.Text = "About..."
        Me.tsmAbout.ToolTipText = "Version and file information"
        '
        'tsmHelp
        '
        Me.tsmHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAbout, Me.tsmManual})
        Me.tsmHelp.Name = "tsmHelp"
        Me.tsmHelp.Size = New System.Drawing.Size(44, 20)
        Me.tsmHelp.Text = "&Help"
        '
        'tsmInterval4
        '
        Me.tsmInterval4.Name = "tsmInterval4"
        Me.tsmInterval4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.tsmInterval4.Size = New System.Drawing.Size(220, 22)
        Me.tsmInterval4.Text = "&Four times a second"
        Me.tsmInterval4.ToolTipText = "Read ADC and interrupts four times a second"
        '
        'tsmInterval1
        '
        Me.tsmInterval1.Name = "tsmInterval1"
        Me.tsmInterval1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.tsmInterval1.Size = New System.Drawing.Size(220, 22)
        Me.tsmInterval1.Text = "&Once a second"
        Me.tsmInterval1.ToolTipText = "Read ADC and interrupts once a second"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(217, 6)
        '
        'tsmInterval0
        '
        Me.tsmInterval0.Name = "tsmInterval0"
        Me.tsmInterval0.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.tsmInterval0.Size = New System.Drawing.Size(220, 22)
        Me.tsmInterval0.Text = "&Disabled"
        Me.tsmInterval0.ToolTipText = "Registers are read manually"
        '
        'tsmRefresh
        '
        Me.tsmRefresh.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmInterval0, Me.ToolStripSeparator3, Me.tsmInterval1, Me.tsmInterval2, Me.tsmInterval4})
        Me.tsmRefresh.Name = "tsmRefresh"
        Me.tsmRefresh.Size = New System.Drawing.Size(139, 22)
        Me.tsmRefresh.Text = "&Auto refresh"
        Me.tsmRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'tsmInterval2
        '
        Me.tsmInterval2.Name = "tsmInterval2"
        Me.tsmInterval2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.tsmInterval2.Size = New System.Drawing.Size(220, 22)
        Me.tsmInterval2.Text = "&Twice a second"
        Me.tsmInterval2.ToolTipText = "Read ADC and interrupts twice a second"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(136, 6)
        '
        'tsmReset
        '
        Me.tsmReset.Name = "tsmReset"
        Me.tsmReset.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.tsmReset.Size = New System.Drawing.Size(139, 22)
        Me.tsmReset.Text = "Re&set"
        Me.tsmReset.ToolTipText = "Reset PCA949x to defaults"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'tsmWrite
        '
        Me.tsmWrite.Name = "tsmWrite"
        Me.tsmWrite.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.tsmWrite.Size = New System.Drawing.Size(139, 22)
        Me.tsmWrite.Text = "&Write all"
        Me.tsmWrite.ToolTipText = "Write all registers"
        '
        'tsmRead
        '
        Me.tsmRead.Name = "tsmRead"
        Me.tsmRead.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.tsmRead.Size = New System.Drawing.Size(139, 22)
        Me.tsmRead.Text = "&Read all"
        Me.tsmRead.ToolTipText = "Read all registers"
        '
        'tsmIO
        '
        Me.tsmIO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmRead, Me.tsmWrite, Me.ToolStripSeparator1, Me.tsmReset, Me.ToolStripSeparator2, Me.tsmRefresh})
        Me.tsmIO.Name = "tsmIO"
        Me.tsmIO.Size = New System.Drawing.Size(31, 20)
        Me.tsmIO.Text = "&IO"
        '
        'tsmRegisters
        '
        Me.tsmRegisters.Name = "tsmRegisters"
        Me.tsmRegisters.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.tsmRegisters.Size = New System.Drawing.Size(162, 22)
        Me.tsmRegisters.Text = "&Register map"
        Me.tsmRegisters.ToolTipText = "Registers values in hexadecimal and binary"
        '
        'tsmFunctions
        '
        Me.tsmFunctions.Name = "tsmFunctions"
        Me.tsmFunctions.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.tsmFunctions.Size = New System.Drawing.Size(162, 22)
        Me.tsmFunctions.Text = "&Functions"
        Me.tsmFunctions.ToolTipText = "Functional view of register map"
        '
        'tsmView
        '
        Me.tsmView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFunctions, Me.tsmRegisters})
        Me.tsmView.Name = "tsmView"
        Me.tsmView.Size = New System.Drawing.Size(44, 20)
        Me.tsmView.Text = "&View"
        '
        'TheMenu
        '
        Me.TheMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TheMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmView, Me.tsmIO, Me.tsmHelp})
        Me.TheMenu.Location = New System.Drawing.Point(0, 0)
        Me.TheMenu.Name = "TheMenu"
        Me.TheMenu.Size = New System.Drawing.Size(701, 24)
        Me.TheMenu.TabIndex = 32
        Me.TheMenu.Text = "MenuStrip1"
        '
        'pnlRegisters
        '
        Me.pnlRegisters.Location = New System.Drawing.Point(0, 95)
        Me.pnlRegisters.Name = "pnlRegisters"
        Me.pnlRegisters.Size = New System.Drawing.Size(610, 404)
        Me.pnlRegisters.TabIndex = 38
        Me.pnlRegisters.Visible = False
        '
        'tmrADCTest
        '
        Me.tmrADCTest.Interval = 1000
        '
        'FrmMain_mp12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 522)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.tbpMisc.ResumeLayout(False)
        Me.gbxDebug.ResumeLayout(False)
        Me.gbxDebug.PerformLayout()
        Me.tbpADCTest.ResumeLayout(False)
        Me.tbpADCTest.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents chkRevCurrentDet As System.Windows.Forms.CheckBox
    Friend WithEvents chkStandbyEn As System.Windows.Forms.CheckBox
    Friend WithEvents lblSwFreqCfg As System.Windows.Forms.Label
    Friend WithEvents lblIinCfgVal As System.Windows.Forms.Label
    Friend WithEvents trbIinCfg As System.Windows.Forms.TrackBar
    Friend WithEvents lblIinCfg As System.Windows.Forms.Label
    Friend WithEvents lblIchgCfgVal As System.Windows.Forms.Label
    Friend WithEvents trbIchgCfg As System.Windows.Forms.TrackBar
    Friend WithEvents lblIchgCfg As System.Windows.Forms.Label
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
    Friend WithEvents tbpMisc As System.Windows.Forms.TabPage
    Friend WithEvents gbxDebug As System.Windows.Forms.GroupBox
    Friend WithEvents btnDbgRegRead1 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegSet1 As System.Windows.Forms.Button
    Friend WithEvents txtDbgRegAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegVal1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegReadBack1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDbgRegRead6 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegSet6 As System.Windows.Forms.Button
    Friend WithEvents txtDbgRegAddr6 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegVal6 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegReadBack6 As System.Windows.Forms.TextBox
    Friend WithEvents btnDbgRegRead5 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegSet5 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegRead4 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegSet4 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegRead3 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegSet3 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegRead2 As System.Windows.Forms.Button
    Friend WithEvents btnDbgRegSet2 As System.Windows.Forms.Button
    Friend WithEvents txtDbgRegAddr5 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegVal5 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegReadBack5 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegAddr3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegVal3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegReadBack3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegAddr4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegVal4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegReadBack4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegVal2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDbgRegReadBack2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbSwFreqCfg As System.Windows.Forms.ComboBox
    Friend WithEvents chkAdcShutDownCfg As System.Windows.Forms.CheckBox
    Friend WithEvents txtCFlyShortSts As System.Windows.Forms.TextBox
    Friend WithEvents chkCFlyShortSts As System.Windows.Forms.CheckBox
    Friend WithEvents tbpADCTest As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtADCAccNTCDelta As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccDieTempDelta As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVbatDelta As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVoutDelta As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVinDelta As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccIoutDelta As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccIINDelta As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccNTCMin As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccDieTempMin As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVbatMin As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVoutMin As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVinMin As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccIoutMin As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccIINMin As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtADCAccNtcMax As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccDieTempMax As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVbatMax As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVoutMax As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccVinMax As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccIoutMax As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccIINMax As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccNTCVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccDieTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtADCAccBattVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccOutputVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccInputVoltage As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccOutputCurrent As System.Windows.Forms.TextBox
    Friend WithEvents txtADCAccInputCurrent As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnADCTestStart As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtXslFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveADC As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbADCTestRepeats As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkADCEnDis As System.Windows.Forms.CheckBox
    Friend WithEvents cmbADCAccDelay As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tmrADCTest As System.Windows.Forms.Timer
    Friend WithEvents chkADCModeSelect As System.Windows.Forms.CheckBox
    Friend WithEvents chkForceUnplugStandby As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnSpreadRead As System.Windows.Forms.Button
    Friend WithEvents btnSpreadSet As System.Windows.Forms.Button
    Friend WithEvents chkScClkDitherEn As System.Windows.Forms.CheckBox
    Friend WithEvents cmbScClkDitherLimit As System.Windows.Forms.ComboBox
    Friend WithEvents lblScClkDitherLimit As System.Windows.Forms.Label
    Friend WithEvents cmbScClkDitherSR As System.Windows.Forms.ComboBox
    Friend WithEvents lblScClkDitherSR As System.Windows.Forms.Label
End Class
