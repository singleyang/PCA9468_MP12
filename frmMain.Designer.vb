<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslInterface = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrWork = New System.Windows.Forms.Timer(Me.components)
        Me.grpDevice = New System.Windows.Forms.GroupBox()
        Me.lblRev = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TheMenu = New System.Windows.Forms.MenuStrip()
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFunctions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRegisters = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmWrite = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInterval0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmInterval1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInterval2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInterval4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.theToolbar = New System.Windows.Forms.ToolStrip()
        Me.tsbWrite = New System.Windows.Forms.ToolStripButton()
        Me.tsbRead = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbReset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbFunctions = New System.Windows.Forms.ToolStripButton()
        Me.tsbRegisters = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripLabel()
        Me.tscRefresh = New System.Windows.Forms.ToolStripComboBox()
        Me.pnlFunctions = New System.Windows.Forms.Panel()
        Me.grpRaised = New System.Windows.Forms.GroupBox()
        Me.chkIocFlt = New System.Windows.Forms.CheckBox()
        Me.chkTshutFlt = New System.Windows.Forms.CheckBox()
        Me.chkVbatIns = New System.Windows.Forms.CheckBox()
        Me.chkVbusIns = New System.Windows.Forms.CheckBox()
        Me.chkVdropOvpFlt = New System.Windows.Forms.CheckBox()
        Me.chkVdropAlmFlt = New System.Windows.Forms.CheckBox()
        Me.chkAdcDone = New System.Windows.Forms.CheckBox()
        Me.chkWatchdogFlt = New System.Windows.Forms.CheckBox()
        Me.chkIbusRevFlt = New System.Windows.Forms.CheckBox()
        Me.chkTbatOtpFlt = New System.Windows.Forms.CheckBox()
        Me.chkTbusOtpFlt = New System.Windows.Forms.CheckBox()
        Me.chkVoutLdoReg = New System.Windows.Forms.CheckBox()
        Me.chkIbatLdoReg = New System.Windows.Forms.CheckBox()
        Me.chkVbatLdoReg = New System.Windows.Forms.CheckBox()
        Me.chkIbusLdoReg = New System.Windows.Forms.CheckBox()
        Me.chkVbusOvpFlt = New System.Windows.Forms.CheckBox()
        Me.grpAdcChannels = New System.Windows.Forms.GroupBox()
        Me.txtTbat = New System.Windows.Forms.TextBox()
        Me.txtTbus = New System.Windows.Forms.TextBox()
        Me.txtVbat = New System.Windows.Forms.TextBox()
        Me.txtIbat = New System.Windows.Forms.TextBox()
        Me.txtVout = New System.Windows.Forms.TextBox()
        Me.txtVdrop = New System.Windows.Forms.TextBox()
        Me.txtIbus = New System.Windows.Forms.TextBox()
        Me.txtVbus = New System.Windows.Forms.TextBox()
        Me.txtDieTemp = New System.Windows.Forms.TextBox()
        Me.chkTbatAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkTbusAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkIbatAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkVbatAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkVdropAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkVoutAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkIbusAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkVbusAdcEn = New System.Windows.Forms.CheckBox()
        Me.chkTdieAdcEn = New System.Windows.Forms.CheckBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tbpControl = New System.Windows.Forms.TabPage()
        Me.lblIbusRegVal = New System.Windows.Forms.Label()
        Me.trbIbusReg = New System.Windows.Forms.TrackBar()
        Me.lblIbusReg = New System.Windows.Forms.Label()
        Me.lblIbatRegVal = New System.Windows.Forms.Label()
        Me.trbIbatReg = New System.Windows.Forms.TrackBar()
        Me.lblIbatReg = New System.Windows.Forms.Label()
        Me.lblVbatRegVal = New System.Windows.Forms.Label()
        Me.trbVbatReg = New System.Windows.Forms.TrackBar()
        Me.lblVbatReg = New System.Windows.Forms.Label()
        Me.lblVoutRegVal = New System.Windows.Forms.Label()
        Me.trbVoutReg = New System.Windows.Forms.TrackBar()
        Me.lblVoutReg = New System.Windows.Forms.Label()
        Me.chkChgEn = New System.Windows.Forms.CheckBox()
        Me.cmbIrevSet = New System.Windows.Forms.ComboBox()
        Me.lblIrevSet = New System.Windows.Forms.Label()
        Me.cmbWatchdog = New System.Windows.Forms.ComboBox()
        Me.lblWatchdog = New System.Windows.Forms.Label()
        Me.cmbSenseR = New System.Windows.Forms.ComboBox()
        Me.lblSenseR = New System.Windows.Forms.Label()
        Me.tbpAdc = New System.Windows.Forms.TabPage()
        Me.cmbAdcSamples = New System.Windows.Forms.ComboBox()
        Me.lblAdcSamples = New System.Windows.Forms.Label()
        Me.cmbAdcRate = New System.Windows.Forms.ComboBox()
        Me.lblAdcRate = New System.Windows.Forms.Label()
        Me.chkAdcAvg = New System.Windows.Forms.CheckBox()
        Me.chkAdcEn = New System.Windows.Forms.CheckBox()
        Me.tbpInt = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkIocMask = New System.Windows.Forms.CheckBox()
        Me.chkTshutFltMask = New System.Windows.Forms.CheckBox()
        Me.chkBatInsMask = New System.Windows.Forms.CheckBox()
        Me.chkVbusInsMask = New System.Windows.Forms.CheckBox()
        Me.chkVdropOvpMask = New System.Windows.Forms.CheckBox()
        Me.chkVdropAlmMask = New System.Windows.Forms.CheckBox()
        Me.chkAdcDoneMask = New System.Windows.Forms.CheckBox()
        Me.chkWatchdogMask = New System.Windows.Forms.CheckBox()
        Me.chkIbusRevMask = New System.Windows.Forms.CheckBox()
        Me.chkTbatOtpMask = New System.Windows.Forms.CheckBox()
        Me.chkTbusOtpMask = New System.Windows.Forms.CheckBox()
        Me.chkVoutRegMask = New System.Windows.Forms.CheckBox()
        Me.chkIbatRegMask = New System.Windows.Forms.CheckBox()
        Me.chkVbatRegMask = New System.Windows.Forms.CheckBox()
        Me.chkIbusRegMask = New System.Windows.Forms.CheckBox()
        Me.chkVbusOvpMask = New System.Windows.Forms.CheckBox()
        Me.tbpEvents = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkVdropAlmEn = New System.Windows.Forms.CheckBox()
        Me.chkVdropOvpEn = New System.Windows.Forms.CheckBox()
        Me.chkVbusPdEn = New System.Windows.Forms.CheckBox()
        Me.chkTbatOtpEn = New System.Windows.Forms.CheckBox()
        Me.chkTbusOtpEn = New System.Windows.Forms.CheckBox()
        Me.chkVoutRegEn = New System.Windows.Forms.CheckBox()
        Me.chkIbatRegEn = New System.Windows.Forms.CheckBox()
        Me.chkVbatRegEn = New System.Windows.Forms.CheckBox()
        Me.chkIbusRegEn = New System.Windows.Forms.CheckBox()
        Me.chkVbusOvpEn = New System.Windows.Forms.CheckBox()
        Me.tbpProt = New System.Windows.Forms.TabPage()
        Me.lblTbatOtpVal = New System.Windows.Forms.Label()
        Me.trbTbatOtp = New System.Windows.Forms.TrackBar()
        Me.lblTbatOtp = New System.Windows.Forms.Label()
        Me.lblTbusOtpVal = New System.Windows.Forms.Label()
        Me.trbTbusOtp = New System.Windows.Forms.TrackBar()
        Me.lblTbusOtp = New System.Windows.Forms.Label()
        Me.lblVdropAlmVal = New System.Windows.Forms.Label()
        Me.trbVdropAlm = New System.Windows.Forms.TrackBar()
        Me.lblVdropAlm = New System.Windows.Forms.Label()
        Me.lblVdropOvpVal = New System.Windows.Forms.Label()
        Me.trbVdropOvp = New System.Windows.Forms.TrackBar()
        Me.lblVdropOvp = New System.Windows.Forms.Label()
        Me.lblVbusOvpVal = New System.Windows.Forms.Label()
        Me.trbVbusOvp = New System.Windows.Forms.TrackBar()
        Me.lblVbusOvp = New System.Windows.Forms.Label()
        Me.cmbVbusOvpDly = New System.Windows.Forms.ComboBox()
        Me.lblVbusOvpDly = New System.Windows.Forms.Label()
        Me.cmbOcpRes = New System.Windows.Forms.ComboBox()
        Me.lblOcpRes = New System.Windows.Forms.Label()
        Me.lblIbusOcpVal = New System.Windows.Forms.Label()
        Me.trbIbusOcp = New System.Windows.Forms.TrackBar()
        Me.lblIbusOCP = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRegisters = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        Me.grpDevice.SuspendLayout()
        Me.TheMenu.SuspendLayout()
        Me.theToolbar.SuspendLayout()
        Me.pnlFunctions.SuspendLayout()
        Me.grpRaised.SuspendLayout()
        Me.grpAdcChannels.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tbpControl.SuspendLayout()
        CType(Me.trbIbusReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbIbatReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbVbatReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbVoutReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpAdc.SuspendLayout()
        Me.tbpInt.SuspendLayout()
        Me.tbpEvents.SuspendLayout()
        Me.tbpProt.SuspendLayout()
        CType(Me.trbTbatOtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbTbusOtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbVdropAlm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbVdropOvp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbVbusOvp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbIbusOcp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslConnection, Me.tslInterface})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 620)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(781, 25)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
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
        Me.tslInterface.Size = New System.Drawing.Size(642, 20)
        Me.tslInterface.Spring = True
        Me.tslInterface.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrWork
        '
        '
        'grpDevice
        '
        Me.grpDevice.Controls.Add(Me.lblRev)
        Me.grpDevice.Controls.Add(Me.lblId)
        Me.grpDevice.Controls.Add(Me.Label5)
        Me.grpDevice.Controls.Add(Me.Label4)
        Me.grpDevice.Controls.Add(Me.lblAddr)
        Me.grpDevice.Controls.Add(Me.Label2)
        Me.grpDevice.Location = New System.Drawing.Point(16, 64)
        Me.grpDevice.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDevice.Name = "grpDevice"
        Me.grpDevice.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDevice.Size = New System.Drawing.Size(449, 59)
        Me.grpDevice.TabIndex = 22
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
        'TheMenu
        '
        Me.TheMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TheMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmView, Me.tsmIO, Me.tsmHelp})
        Me.TheMenu.Location = New System.Drawing.Point(0, 0)
        Me.TheMenu.Name = "TheMenu"
        Me.TheMenu.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.TheMenu.Size = New System.Drawing.Size(781, 28)
        Me.TheMenu.TabIndex = 2
        Me.TheMenu.Text = "MenuStrip1"
        '
        'tsmView
        '
        Me.tsmView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFunctions, Me.tsmRegisters})
        Me.tsmView.Name = "tsmView"
        Me.tsmView.Size = New System.Drawing.Size(53, 24)
        Me.tsmView.Text = "&View"
        '
        'tsmFunctions
        '
        Me.tsmFunctions.Image = Global.PCA9468.My.Resources.Resources._function
        Me.tsmFunctions.Name = "tsmFunctions"
        Me.tsmFunctions.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.tsmFunctions.Size = New System.Drawing.Size(194, 26)
        Me.tsmFunctions.Text = "&Functions"
        Me.tsmFunctions.ToolTipText = "Functional view of register map"
        '
        'tsmRegisters
        '
        Me.tsmRegisters.Image = Global.PCA9468.My.Resources.Resources.table
        Me.tsmRegisters.Name = "tsmRegisters"
        Me.tsmRegisters.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.tsmRegisters.Size = New System.Drawing.Size(194, 26)
        Me.tsmRegisters.Text = "&Register map"
        Me.tsmRegisters.ToolTipText = "Registers values in hexadecimal and binary"
        '
        'tsmIO
        '
        Me.tsmIO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmRead, Me.tsmWrite, Me.ToolStripSeparator1, Me.tsmReset, Me.ToolStripSeparator2, Me.tsmRefresh})
        Me.tsmIO.Name = "tsmIO"
        Me.tsmIO.Size = New System.Drawing.Size(36, 24)
        Me.tsmIO.Text = "&IO"
        '
        'tsmRead
        '
        Me.tsmRead.Image = Global.PCA9468.My.Resources.Resources.spectacle
        Me.tsmRead.Name = "tsmRead"
        Me.tsmRead.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.tsmRead.Size = New System.Drawing.Size(163, 26)
        Me.tsmRead.Text = "&Read all"
        Me.tsmRead.ToolTipText = "Read all registers"
        '
        'tsmWrite
        '
        Me.tsmWrite.Image = Global.PCA9468.My.Resources.Resources.pencil__arrow
        Me.tsmWrite.Name = "tsmWrite"
        Me.tsmWrite.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.tsmWrite.Size = New System.Drawing.Size(163, 26)
        Me.tsmWrite.Text = "&Write all"
        Me.tsmWrite.ToolTipText = "Write all registers"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'tsmReset
        '
        Me.tsmReset.Image = Global.PCA9468.My.Resources.Resources.counter_reset
        Me.tsmReset.Name = "tsmReset"
        Me.tsmReset.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.tsmReset.Size = New System.Drawing.Size(163, 26)
        Me.tsmReset.Text = "Re&set"
        Me.tsmReset.ToolTipText = "Reset PCA949x to defaults"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
        '
        'tsmRefresh
        '
        Me.tsmRefresh.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmInterval0, Me.ToolStripSeparator3, Me.tsmInterval1, Me.tsmInterval2, Me.tsmInterval4})
        Me.tsmRefresh.Image = Global.PCA9468.My.Resources.Resources.clock
        Me.tsmRefresh.Name = "tsmRefresh"
        Me.tsmRefresh.Size = New System.Drawing.Size(163, 26)
        Me.tsmRefresh.Text = "&Auto refresh"
        Me.tsmRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'tsmInterval0
        '
        Me.tsmInterval0.Name = "tsmInterval0"
        Me.tsmInterval0.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.tsmInterval0.Size = New System.Drawing.Size(260, 24)
        Me.tsmInterval0.Text = "&Disabled"
        Me.tsmInterval0.ToolTipText = "Registers are read manually"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(257, 6)
        '
        'tsmInterval1
        '
        Me.tsmInterval1.Name = "tsmInterval1"
        Me.tsmInterval1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.tsmInterval1.Size = New System.Drawing.Size(260, 24)
        Me.tsmInterval1.Text = "&Once a second"
        Me.tsmInterval1.ToolTipText = "Read ADC and interrupts once a second"
        '
        'tsmInterval2
        '
        Me.tsmInterval2.Name = "tsmInterval2"
        Me.tsmInterval2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.tsmInterval2.Size = New System.Drawing.Size(260, 24)
        Me.tsmInterval2.Text = "&Twice a second"
        Me.tsmInterval2.ToolTipText = "Read ADC and interrupts twice a second"
        '
        'tsmInterval4
        '
        Me.tsmInterval4.Name = "tsmInterval4"
        Me.tsmInterval4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.tsmInterval4.Size = New System.Drawing.Size(260, 24)
        Me.tsmInterval4.Text = "&Four times a second"
        Me.tsmInterval4.ToolTipText = "Read ADC and interrupts four times a second"
        '
        'tsmHelp
        '
        Me.tsmHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAbout, Me.tsmManual})
        Me.tsmHelp.Name = "tsmHelp"
        Me.tsmHelp.Size = New System.Drawing.Size(53, 24)
        Me.tsmHelp.Text = "&Help"
        '
        'tsmAbout
        '
        Me.tsmAbout.Image = Global.PCA9468.My.Resources.Resources.information
        Me.tsmAbout.Name = "tsmAbout"
        Me.tsmAbout.ShortcutKeyDisplayString = ""
        Me.tsmAbout.Size = New System.Drawing.Size(262, 26)
        Me.tsmAbout.Text = "About..."
        Me.tsmAbout.ToolTipText = "Version and file information"
        '
        'tsmManual
        '
        Me.tsmManual.Image = Global.PCA9468.My.Resources.Resources.book_question
        Me.tsmManual.Name = "tsmManual"
        Me.tsmManual.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.tsmManual.Size = New System.Drawing.Size(262, 26)
        Me.tsmManual.Text = "Open the User Manual..."
        Me.tsmManual.ToolTipText = "Open the User Manual with an external PDF viewer"
        '
        'theToolbar
        '
        Me.theToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.theToolbar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.theToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbWrite, Me.tsbRead, Me.ToolStripSeparator4, Me.tsbReset, Me.ToolStripSeparator5, Me.tsbFunctions, Me.tsbRegisters, Me.ToolStripSeparator6, Me.tsbRefresh, Me.tscRefresh})
        Me.theToolbar.Location = New System.Drawing.Point(0, 28)
        Me.theToolbar.Name = "theToolbar"
        Me.theToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.theToolbar.Size = New System.Drawing.Size(781, 28)
        Me.theToolbar.TabIndex = 3
        Me.theToolbar.Text = "ToolStrip1"
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 28)
        '
        'tsbFunctions
        '
        Me.tsbFunctions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFunctions.Image = Global.PCA9468.My.Resources.Resources._function
        Me.tsbFunctions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFunctions.Name = "tsbFunctions"
        Me.tsbFunctions.Size = New System.Drawing.Size(24, 25)
        Me.tsbFunctions.Text = "Functions"
        Me.tsbFunctions.ToolTipText = "Functional view"
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 28)
        '
        'tsbRefresh
        '
        Me.tsbRefresh.Image = Global.PCA9468.My.Resources.Resources.clock
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(110, 25)
        Me.tsbRefresh.Text = "Auto refresh"
        Me.tsbRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'tscRefresh
        '
        Me.tscRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscRefresh.Items.AddRange(New Object() {"Disabled", "1 / second", "2 / second", "4 / second"})
        Me.tscRefresh.Name = "tscRefresh"
        Me.tscRefresh.Size = New System.Drawing.Size(160, 28)
        Me.tscRefresh.ToolTipText = "Refresh interval for ADC and interrupts"
        '
        'pnlFunctions
        '
        Me.pnlFunctions.Controls.Add(Me.grpRaised)
        Me.pnlFunctions.Controls.Add(Me.grpAdcChannels)
        Me.pnlFunctions.Controls.Add(Me.TabControl2)
        Me.pnlFunctions.Location = New System.Drawing.Point(0, 126)
        Me.pnlFunctions.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFunctions.Name = "pnlFunctions"
        Me.pnlFunctions.Size = New System.Drawing.Size(780, 491)
        Me.pnlFunctions.TabIndex = 27
        '
        'grpRaised
        '
        Me.grpRaised.Controls.Add(Me.chkIocFlt)
        Me.grpRaised.Controls.Add(Me.chkTshutFlt)
        Me.grpRaised.Controls.Add(Me.chkVbatIns)
        Me.grpRaised.Controls.Add(Me.chkVbusIns)
        Me.grpRaised.Controls.Add(Me.chkVdropOvpFlt)
        Me.grpRaised.Controls.Add(Me.chkVdropAlmFlt)
        Me.grpRaised.Controls.Add(Me.chkAdcDone)
        Me.grpRaised.Controls.Add(Me.chkWatchdogFlt)
        Me.grpRaised.Controls.Add(Me.chkIbusRevFlt)
        Me.grpRaised.Controls.Add(Me.chkTbatOtpFlt)
        Me.grpRaised.Controls.Add(Me.chkTbusOtpFlt)
        Me.grpRaised.Controls.Add(Me.chkVoutLdoReg)
        Me.grpRaised.Controls.Add(Me.chkIbatLdoReg)
        Me.grpRaised.Controls.Add(Me.chkVbatLdoReg)
        Me.grpRaised.Controls.Add(Me.chkIbusLdoReg)
        Me.grpRaised.Controls.Add(Me.chkVbusOvpFlt)
        Me.grpRaised.Location = New System.Drawing.Point(16, 4)
        Me.grpRaised.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRaised.Name = "grpRaised"
        Me.grpRaised.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRaised.Size = New System.Drawing.Size(229, 484)
        Me.grpRaised.TabIndex = 28
        Me.grpRaised.TabStop = False
        Me.grpRaised.Text = "Raised interrupts"
        '
        'chkIocFlt
        '
        Me.chkIocFlt.Location = New System.Drawing.Point(19, 455)
        Me.chkIocFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkIocFlt.Name = "chkIocFlt"
        Me.chkIocFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkIocFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkIocFlt.TabIndex = 51
        Me.chkIocFlt.Text = "Vbus OVP"
        Me.chkIocFlt.UseVisualStyleBackColor = True
        '
        'chkTshutFlt
        '
        Me.chkTshutFlt.Location = New System.Drawing.Point(19, 427)
        Me.chkTshutFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkTshutFlt.Name = "chkTshutFlt"
        Me.chkTshutFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkTshutFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkTshutFlt.TabIndex = 50
        Me.chkTshutFlt.Text = "Vbus OVP"
        Me.chkTshutFlt.UseVisualStyleBackColor = True
        '
        'chkVbatIns
        '
        Me.chkVbatIns.Location = New System.Drawing.Point(19, 399)
        Me.chkVbatIns.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVbatIns.Name = "chkVbatIns"
        Me.chkVbatIns.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVbatIns.Size = New System.Drawing.Size(192, 21)
        Me.chkVbatIns.TabIndex = 49
        Me.chkVbatIns.Text = "Vbus OVP"
        Me.chkVbatIns.UseVisualStyleBackColor = True
        '
        'chkVbusIns
        '
        Me.chkVbusIns.Location = New System.Drawing.Point(19, 370)
        Me.chkVbusIns.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVbusIns.Name = "chkVbusIns"
        Me.chkVbusIns.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVbusIns.Size = New System.Drawing.Size(192, 21)
        Me.chkVbusIns.TabIndex = 48
        Me.chkVbusIns.Text = "Vbus OVP"
        Me.chkVbusIns.UseVisualStyleBackColor = True
        '
        'chkVdropOvpFlt
        '
        Me.chkVdropOvpFlt.Location = New System.Drawing.Point(19, 342)
        Me.chkVdropOvpFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVdropOvpFlt.Name = "chkVdropOvpFlt"
        Me.chkVdropOvpFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVdropOvpFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkVdropOvpFlt.TabIndex = 47
        Me.chkVdropOvpFlt.Text = "Vbus OVP"
        Me.chkVdropOvpFlt.UseVisualStyleBackColor = True
        '
        'chkVdropAlmFlt
        '
        Me.chkVdropAlmFlt.Location = New System.Drawing.Point(19, 314)
        Me.chkVdropAlmFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVdropAlmFlt.Name = "chkVdropAlmFlt"
        Me.chkVdropAlmFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVdropAlmFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkVdropAlmFlt.TabIndex = 46
        Me.chkVdropAlmFlt.Text = "Vbus OVP"
        Me.chkVdropAlmFlt.UseVisualStyleBackColor = True
        '
        'chkAdcDone
        '
        Me.chkAdcDone.Location = New System.Drawing.Point(19, 286)
        Me.chkAdcDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAdcDone.Name = "chkAdcDone"
        Me.chkAdcDone.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkAdcDone.Size = New System.Drawing.Size(192, 21)
        Me.chkAdcDone.TabIndex = 45
        Me.chkAdcDone.Text = "Vbus OVP"
        Me.chkAdcDone.UseVisualStyleBackColor = True
        '
        'chkWatchdogFlt
        '
        Me.chkWatchdogFlt.Location = New System.Drawing.Point(19, 257)
        Me.chkWatchdogFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkWatchdogFlt.Name = "chkWatchdogFlt"
        Me.chkWatchdogFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkWatchdogFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkWatchdogFlt.TabIndex = 44
        Me.chkWatchdogFlt.Text = "Vbus OVP"
        Me.chkWatchdogFlt.UseVisualStyleBackColor = True
        '
        'chkIbusRevFlt
        '
        Me.chkIbusRevFlt.Location = New System.Drawing.Point(19, 229)
        Me.chkIbusRevFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkIbusRevFlt.Name = "chkIbusRevFlt"
        Me.chkIbusRevFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkIbusRevFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkIbusRevFlt.TabIndex = 43
        Me.chkIbusRevFlt.Text = "Vbus OVP"
        Me.chkIbusRevFlt.UseVisualStyleBackColor = True
        '
        'chkTbatOtpFlt
        '
        Me.chkTbatOtpFlt.Location = New System.Drawing.Point(19, 201)
        Me.chkTbatOtpFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkTbatOtpFlt.Name = "chkTbatOtpFlt"
        Me.chkTbatOtpFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkTbatOtpFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkTbatOtpFlt.TabIndex = 42
        Me.chkTbatOtpFlt.Text = "Vbus OVP"
        Me.chkTbatOtpFlt.UseVisualStyleBackColor = True
        '
        'chkTbusOtpFlt
        '
        Me.chkTbusOtpFlt.Location = New System.Drawing.Point(19, 172)
        Me.chkTbusOtpFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkTbusOtpFlt.Name = "chkTbusOtpFlt"
        Me.chkTbusOtpFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkTbusOtpFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkTbusOtpFlt.TabIndex = 41
        Me.chkTbusOtpFlt.Text = "Vbus OVP"
        Me.chkTbusOtpFlt.UseVisualStyleBackColor = True
        '
        'chkVoutLdoReg
        '
        Me.chkVoutLdoReg.Location = New System.Drawing.Point(19, 144)
        Me.chkVoutLdoReg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVoutLdoReg.Name = "chkVoutLdoReg"
        Me.chkVoutLdoReg.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVoutLdoReg.Size = New System.Drawing.Size(192, 21)
        Me.chkVoutLdoReg.TabIndex = 40
        Me.chkVoutLdoReg.Text = "Vbus OVP"
        Me.chkVoutLdoReg.UseVisualStyleBackColor = True
        '
        'chkIbatLdoReg
        '
        Me.chkIbatLdoReg.Location = New System.Drawing.Point(19, 116)
        Me.chkIbatLdoReg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkIbatLdoReg.Name = "chkIbatLdoReg"
        Me.chkIbatLdoReg.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkIbatLdoReg.Size = New System.Drawing.Size(192, 21)
        Me.chkIbatLdoReg.TabIndex = 39
        Me.chkIbatLdoReg.Text = "Vbus OVP"
        Me.chkIbatLdoReg.UseVisualStyleBackColor = True
        '
        'chkVbatLdoReg
        '
        Me.chkVbatLdoReg.Location = New System.Drawing.Point(19, 87)
        Me.chkVbatLdoReg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVbatLdoReg.Name = "chkVbatLdoReg"
        Me.chkVbatLdoReg.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVbatLdoReg.Size = New System.Drawing.Size(192, 21)
        Me.chkVbatLdoReg.TabIndex = 38
        Me.chkVbatLdoReg.Text = "Vbus OVP"
        Me.chkVbatLdoReg.UseVisualStyleBackColor = True
        '
        'chkIbusLdoReg
        '
        Me.chkIbusLdoReg.Location = New System.Drawing.Point(19, 59)
        Me.chkIbusLdoReg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkIbusLdoReg.Name = "chkIbusLdoReg"
        Me.chkIbusLdoReg.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkIbusLdoReg.Size = New System.Drawing.Size(192, 21)
        Me.chkIbusLdoReg.TabIndex = 37
        Me.chkIbusLdoReg.Text = "Vbus OVP"
        Me.chkIbusLdoReg.UseVisualStyleBackColor = True
        '
        'chkVbusOvpFlt
        '
        Me.chkVbusOvpFlt.Location = New System.Drawing.Point(19, 31)
        Me.chkVbusOvpFlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVbusOvpFlt.Name = "chkVbusOvpFlt"
        Me.chkVbusOvpFlt.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkVbusOvpFlt.Size = New System.Drawing.Size(192, 21)
        Me.chkVbusOvpFlt.TabIndex = 36
        Me.chkVbusOvpFlt.Text = "Vbus OVP"
        Me.chkVbusOvpFlt.UseVisualStyleBackColor = True
        '
        'grpAdcChannels
        '
        Me.grpAdcChannels.Controls.Add(Me.txtTbat)
        Me.grpAdcChannels.Controls.Add(Me.txtTbus)
        Me.grpAdcChannels.Controls.Add(Me.txtVbat)
        Me.grpAdcChannels.Controls.Add(Me.txtIbat)
        Me.grpAdcChannels.Controls.Add(Me.txtVout)
        Me.grpAdcChannels.Controls.Add(Me.txtVdrop)
        Me.grpAdcChannels.Controls.Add(Me.txtIbus)
        Me.grpAdcChannels.Controls.Add(Me.txtVbus)
        Me.grpAdcChannels.Controls.Add(Me.txtDieTemp)
        Me.grpAdcChannels.Controls.Add(Me.chkTbatAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkTbusAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkIbatAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkVbatAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkVdropAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkVoutAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkIbusAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkVbusAdcEn)
        Me.grpAdcChannels.Controls.Add(Me.chkTdieAdcEn)
        Me.grpAdcChannels.Location = New System.Drawing.Point(253, 313)
        Me.grpAdcChannels.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAdcChannels.Name = "grpAdcChannels"
        Me.grpAdcChannels.Padding = New System.Windows.Forms.Padding(4)
        Me.grpAdcChannels.Size = New System.Drawing.Size(509, 176)
        Me.grpAdcChannels.TabIndex = 30
        Me.grpAdcChannels.TabStop = False
        Me.grpAdcChannels.Text = "ADC channels"
        '
        'txtTbat
        '
        Me.txtTbat.Location = New System.Drawing.Point(419, 114)
        Me.txtTbat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTbat.Name = "txtTbat"
        Me.txtTbat.ReadOnly = True
        Me.txtTbat.Size = New System.Drawing.Size(79, 22)
        Me.txtTbat.TabIndex = 28
        '
        'txtTbus
        '
        Me.txtTbus.Location = New System.Drawing.Point(419, 82)
        Me.txtTbus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTbus.Name = "txtTbus"
        Me.txtTbus.ReadOnly = True
        Me.txtTbus.Size = New System.Drawing.Size(79, 22)
        Me.txtTbus.TabIndex = 27
        '
        'txtVbat
        '
        Me.txtVbat.Location = New System.Drawing.Point(419, 18)
        Me.txtVbat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVbat.Name = "txtVbat"
        Me.txtVbat.ReadOnly = True
        Me.txtVbat.Size = New System.Drawing.Size(79, 22)
        Me.txtVbat.TabIndex = 26
        '
        'txtIbat
        '
        Me.txtIbat.Location = New System.Drawing.Point(419, 50)
        Me.txtIbat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIbat.Name = "txtIbat"
        Me.txtIbat.ReadOnly = True
        Me.txtIbat.Size = New System.Drawing.Size(79, 22)
        Me.txtIbat.TabIndex = 26
        '
        'txtVout
        '
        Me.txtVout.Location = New System.Drawing.Point(164, 114)
        Me.txtVout.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVout.Name = "txtVout"
        Me.txtVout.ReadOnly = True
        Me.txtVout.Size = New System.Drawing.Size(79, 22)
        Me.txtVout.TabIndex = 25
        '
        'txtVdrop
        '
        Me.txtVdrop.Location = New System.Drawing.Point(164, 146)
        Me.txtVdrop.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVdrop.Name = "txtVdrop"
        Me.txtVdrop.ReadOnly = True
        Me.txtVdrop.Size = New System.Drawing.Size(79, 22)
        Me.txtVdrop.TabIndex = 25
        '
        'txtIbus
        '
        Me.txtIbus.Location = New System.Drawing.Point(164, 82)
        Me.txtIbus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIbus.Name = "txtIbus"
        Me.txtIbus.ReadOnly = True
        Me.txtIbus.Size = New System.Drawing.Size(79, 22)
        Me.txtIbus.TabIndex = 24
        '
        'txtVbus
        '
        Me.txtVbus.Location = New System.Drawing.Point(164, 50)
        Me.txtVbus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVbus.Name = "txtVbus"
        Me.txtVbus.ReadOnly = True
        Me.txtVbus.Size = New System.Drawing.Size(79, 22)
        Me.txtVbus.TabIndex = 23
        '
        'txtDieTemp
        '
        Me.txtDieTemp.Location = New System.Drawing.Point(164, 18)
        Me.txtDieTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDieTemp.Name = "txtDieTemp"
        Me.txtDieTemp.ReadOnly = True
        Me.txtDieTemp.Size = New System.Drawing.Size(79, 22)
        Me.txtDieTemp.TabIndex = 22
        '
        'chkTbatAdcEn
        '
        Me.chkTbatAdcEn.AutoSize = True
        Me.chkTbatAdcEn.Location = New System.Drawing.Point(289, 117)
        Me.chkTbatAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTbatAdcEn.Name = "chkTbatAdcEn"
        Me.chkTbatAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkTbatAdcEn.TabIndex = 21
        Me.chkTbatAdcEn.Text = "Vbus OVP"
        Me.chkTbatAdcEn.UseVisualStyleBackColor = True
        '
        'chkTbusAdcEn
        '
        Me.chkTbusAdcEn.AutoSize = True
        Me.chkTbusAdcEn.Location = New System.Drawing.Point(289, 85)
        Me.chkTbusAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTbusAdcEn.Name = "chkTbusAdcEn"
        Me.chkTbusAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkTbusAdcEn.TabIndex = 20
        Me.chkTbusAdcEn.Text = "Vbus OVP"
        Me.chkTbusAdcEn.UseVisualStyleBackColor = True
        '
        'chkIbatAdcEn
        '
        Me.chkIbatAdcEn.AutoSize = True
        Me.chkIbatAdcEn.Location = New System.Drawing.Point(289, 53)
        Me.chkIbatAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIbatAdcEn.Name = "chkIbatAdcEn"
        Me.chkIbatAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkIbatAdcEn.TabIndex = 19
        Me.chkIbatAdcEn.Text = "Vbus OVP"
        Me.chkIbatAdcEn.UseVisualStyleBackColor = True
        '
        'chkVbatAdcEn
        '
        Me.chkVbatAdcEn.AutoSize = True
        Me.chkVbatAdcEn.Location = New System.Drawing.Point(289, 21)
        Me.chkVbatAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbatAdcEn.Name = "chkVbatAdcEn"
        Me.chkVbatAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVbatAdcEn.TabIndex = 18
        Me.chkVbatAdcEn.Text = "Vbus OVP"
        Me.chkVbatAdcEn.UseVisualStyleBackColor = True
        '
        'chkVdropAdcEn
        '
        Me.chkVdropAdcEn.AutoSize = True
        Me.chkVdropAdcEn.Location = New System.Drawing.Point(19, 149)
        Me.chkVdropAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVdropAdcEn.Name = "chkVdropAdcEn"
        Me.chkVdropAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVdropAdcEn.TabIndex = 17
        Me.chkVdropAdcEn.Text = "Vbus OVP"
        Me.chkVdropAdcEn.UseVisualStyleBackColor = True
        '
        'chkVoutAdcEn
        '
        Me.chkVoutAdcEn.AutoSize = True
        Me.chkVoutAdcEn.Location = New System.Drawing.Point(19, 117)
        Me.chkVoutAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVoutAdcEn.Name = "chkVoutAdcEn"
        Me.chkVoutAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVoutAdcEn.TabIndex = 16
        Me.chkVoutAdcEn.Text = "Vbus OVP"
        Me.chkVoutAdcEn.UseVisualStyleBackColor = True
        '
        'chkIbusAdcEn
        '
        Me.chkIbusAdcEn.AutoSize = True
        Me.chkIbusAdcEn.Location = New System.Drawing.Point(19, 85)
        Me.chkIbusAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIbusAdcEn.Name = "chkIbusAdcEn"
        Me.chkIbusAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkIbusAdcEn.TabIndex = 15
        Me.chkIbusAdcEn.Text = "Vbus OVP"
        Me.chkIbusAdcEn.UseVisualStyleBackColor = True
        '
        'chkVbusAdcEn
        '
        Me.chkVbusAdcEn.AutoSize = True
        Me.chkVbusAdcEn.Location = New System.Drawing.Point(19, 53)
        Me.chkVbusAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbusAdcEn.Name = "chkVbusAdcEn"
        Me.chkVbusAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVbusAdcEn.TabIndex = 14
        Me.chkVbusAdcEn.Text = "Vbus OVP"
        Me.chkVbusAdcEn.UseVisualStyleBackColor = True
        '
        'chkTdieAdcEn
        '
        Me.chkTdieAdcEn.AutoSize = True
        Me.chkTdieAdcEn.Location = New System.Drawing.Point(19, 21)
        Me.chkTdieAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTdieAdcEn.Name = "chkTdieAdcEn"
        Me.chkTdieAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkTdieAdcEn.TabIndex = 13
        Me.chkTdieAdcEn.Text = "Vbus OVP"
        Me.chkTdieAdcEn.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.tbpControl)
        Me.TabControl2.Controls.Add(Me.tbpAdc)
        Me.TabControl2.Controls.Add(Me.tbpInt)
        Me.TabControl2.Controls.Add(Me.tbpEvents)
        Me.TabControl2.Controls.Add(Me.tbpProt)
        Me.TabControl2.Location = New System.Drawing.Point(249, 11)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(517, 297)
        Me.TabControl2.TabIndex = 29
        '
        'tbpControl
        '
        Me.tbpControl.BackColor = System.Drawing.SystemColors.Control
        Me.tbpControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpControl.Controls.Add(Me.lblIbusRegVal)
        Me.tbpControl.Controls.Add(Me.trbIbusReg)
        Me.tbpControl.Controls.Add(Me.lblIbusReg)
        Me.tbpControl.Controls.Add(Me.lblIbatRegVal)
        Me.tbpControl.Controls.Add(Me.trbIbatReg)
        Me.tbpControl.Controls.Add(Me.lblIbatReg)
        Me.tbpControl.Controls.Add(Me.lblVbatRegVal)
        Me.tbpControl.Controls.Add(Me.trbVbatReg)
        Me.tbpControl.Controls.Add(Me.lblVbatReg)
        Me.tbpControl.Controls.Add(Me.lblVoutRegVal)
        Me.tbpControl.Controls.Add(Me.trbVoutReg)
        Me.tbpControl.Controls.Add(Me.lblVoutReg)
        Me.tbpControl.Controls.Add(Me.chkChgEn)
        Me.tbpControl.Controls.Add(Me.cmbIrevSet)
        Me.tbpControl.Controls.Add(Me.lblIrevSet)
        Me.tbpControl.Controls.Add(Me.cmbWatchdog)
        Me.tbpControl.Controls.Add(Me.lblWatchdog)
        Me.tbpControl.Controls.Add(Me.cmbSenseR)
        Me.tbpControl.Controls.Add(Me.lblSenseR)
        Me.tbpControl.Location = New System.Drawing.Point(4, 28)
        Me.tbpControl.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpControl.Name = "tbpControl"
        Me.tbpControl.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpControl.Size = New System.Drawing.Size(509, 265)
        Me.tbpControl.TabIndex = 1
        Me.tbpControl.Text = "Control"
        '
        'lblIbusRegVal
        '
        Me.lblIbusRegVal.AutoSize = True
        Me.lblIbusRegVal.Location = New System.Drawing.Point(424, 217)
        Me.lblIbusRegVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIbusRegVal.Name = "lblIbusRegVal"
        Me.lblIbusRegVal.Size = New System.Drawing.Size(51, 17)
        Me.lblIbusRegVal.TabIndex = 52
        Me.lblIbusRegVal.Text = "Label8"
        '
        'trbIbusReg
        '
        Me.trbIbusReg.AutoSize = False
        Me.trbIbusReg.Location = New System.Drawing.Point(168, 214)
        Me.trbIbusReg.Margin = New System.Windows.Forms.Padding(4)
        Me.trbIbusReg.Name = "trbIbusReg"
        Me.trbIbusReg.Size = New System.Drawing.Size(252, 31)
        Me.trbIbusReg.TabIndex = 51
        '
        'lblIbusReg
        '
        Me.lblIbusReg.AutoSize = True
        Me.lblIbusReg.Location = New System.Drawing.Point(12, 217)
        Me.lblIbusReg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIbusReg.Name = "lblIbusReg"
        Me.lblIbusReg.Size = New System.Drawing.Size(51, 17)
        Me.lblIbusReg.TabIndex = 50
        Me.lblIbusReg.Text = "Label6"
        '
        'lblIbatRegVal
        '
        Me.lblIbatRegVal.AutoSize = True
        Me.lblIbatRegVal.Location = New System.Drawing.Point(424, 181)
        Me.lblIbatRegVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIbatRegVal.Name = "lblIbatRegVal"
        Me.lblIbatRegVal.Size = New System.Drawing.Size(51, 17)
        Me.lblIbatRegVal.TabIndex = 49
        Me.lblIbatRegVal.Text = "Label8"
        '
        'trbIbatReg
        '
        Me.trbIbatReg.AutoSize = False
        Me.trbIbatReg.Location = New System.Drawing.Point(168, 178)
        Me.trbIbatReg.Margin = New System.Windows.Forms.Padding(4)
        Me.trbIbatReg.Name = "trbIbatReg"
        Me.trbIbatReg.Size = New System.Drawing.Size(252, 31)
        Me.trbIbatReg.TabIndex = 48
        '
        'lblIbatReg
        '
        Me.lblIbatReg.AutoSize = True
        Me.lblIbatReg.Location = New System.Drawing.Point(12, 181)
        Me.lblIbatReg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIbatReg.Name = "lblIbatReg"
        Me.lblIbatReg.Size = New System.Drawing.Size(51, 17)
        Me.lblIbatReg.TabIndex = 47
        Me.lblIbatReg.Text = "Label6"
        '
        'lblVbatRegVal
        '
        Me.lblVbatRegVal.AutoSize = True
        Me.lblVbatRegVal.Location = New System.Drawing.Point(424, 145)
        Me.lblVbatRegVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVbatRegVal.Name = "lblVbatRegVal"
        Me.lblVbatRegVal.Size = New System.Drawing.Size(51, 17)
        Me.lblVbatRegVal.TabIndex = 46
        Me.lblVbatRegVal.Text = "Label8"
        '
        'trbVbatReg
        '
        Me.trbVbatReg.AutoSize = False
        Me.trbVbatReg.Location = New System.Drawing.Point(168, 143)
        Me.trbVbatReg.Margin = New System.Windows.Forms.Padding(4)
        Me.trbVbatReg.Name = "trbVbatReg"
        Me.trbVbatReg.Size = New System.Drawing.Size(252, 31)
        Me.trbVbatReg.TabIndex = 45
        '
        'lblVbatReg
        '
        Me.lblVbatReg.AutoSize = True
        Me.lblVbatReg.Location = New System.Drawing.Point(12, 145)
        Me.lblVbatReg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVbatReg.Name = "lblVbatReg"
        Me.lblVbatReg.Size = New System.Drawing.Size(51, 17)
        Me.lblVbatReg.TabIndex = 44
        Me.lblVbatReg.Text = "Label6"
        '
        'lblVoutRegVal
        '
        Me.lblVoutRegVal.AutoSize = True
        Me.lblVoutRegVal.Location = New System.Drawing.Point(424, 110)
        Me.lblVoutRegVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoutRegVal.Name = "lblVoutRegVal"
        Me.lblVoutRegVal.Size = New System.Drawing.Size(51, 17)
        Me.lblVoutRegVal.TabIndex = 21
        Me.lblVoutRegVal.Text = "Label6"
        '
        'trbVoutReg
        '
        Me.trbVoutReg.AutoSize = False
        Me.trbVoutReg.Location = New System.Drawing.Point(168, 107)
        Me.trbVoutReg.Margin = New System.Windows.Forms.Padding(4)
        Me.trbVoutReg.Name = "trbVoutReg"
        Me.trbVoutReg.Size = New System.Drawing.Size(252, 31)
        Me.trbVoutReg.TabIndex = 20
        '
        'lblVoutReg
        '
        Me.lblVoutReg.AutoSize = True
        Me.lblVoutReg.Location = New System.Drawing.Point(12, 110)
        Me.lblVoutReg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVoutReg.Name = "lblVoutReg"
        Me.lblVoutReg.Size = New System.Drawing.Size(51, 17)
        Me.lblVoutReg.TabIndex = 16
        Me.lblVoutReg.Text = "Label6"
        '
        'chkChgEn
        '
        Me.chkChgEn.AutoSize = True
        Me.chkChgEn.Location = New System.Drawing.Point(355, 10)
        Me.chkChgEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChgEn.Name = "chkChgEn"
        Me.chkChgEn.Size = New System.Drawing.Size(95, 21)
        Me.chkChgEn.TabIndex = 15
        Me.chkChgEn.Text = "Vbus OVP"
        Me.chkChgEn.UseVisualStyleBackColor = True
        '
        'cmbIrevSet
        '
        Me.cmbIrevSet.FormattingEnabled = True
        Me.cmbIrevSet.Location = New System.Drawing.Point(189, 74)
        Me.cmbIrevSet.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbIrevSet.Name = "cmbIrevSet"
        Me.cmbIrevSet.Size = New System.Drawing.Size(91, 24)
        Me.cmbIrevSet.TabIndex = 6
        '
        'lblIrevSet
        '
        Me.lblIrevSet.AutoSize = True
        Me.lblIrevSet.Location = New System.Drawing.Point(12, 78)
        Me.lblIrevSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIrevSet.Name = "lblIrevSet"
        Me.lblIrevSet.Size = New System.Drawing.Size(51, 17)
        Me.lblIrevSet.TabIndex = 5
        Me.lblIrevSet.Text = "Label6"
        '
        'cmbWatchdog
        '
        Me.cmbWatchdog.FormattingEnabled = True
        Me.cmbWatchdog.Location = New System.Drawing.Point(189, 41)
        Me.cmbWatchdog.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbWatchdog.Name = "cmbWatchdog"
        Me.cmbWatchdog.Size = New System.Drawing.Size(91, 24)
        Me.cmbWatchdog.TabIndex = 4
        '
        'lblWatchdog
        '
        Me.lblWatchdog.AutoSize = True
        Me.lblWatchdog.Location = New System.Drawing.Point(12, 44)
        Me.lblWatchdog.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWatchdog.Name = "lblWatchdog"
        Me.lblWatchdog.Size = New System.Drawing.Size(51, 17)
        Me.lblWatchdog.TabIndex = 3
        Me.lblWatchdog.Text = "Label3"
        '
        'cmbSenseR
        '
        Me.cmbSenseR.FormattingEnabled = True
        Me.cmbSenseR.Location = New System.Drawing.Point(189, 7)
        Me.cmbSenseR.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSenseR.Name = "cmbSenseR"
        Me.cmbSenseR.Size = New System.Drawing.Size(91, 24)
        Me.cmbSenseR.TabIndex = 2
        '
        'lblSenseR
        '
        Me.lblSenseR.AutoSize = True
        Me.lblSenseR.Location = New System.Drawing.Point(12, 11)
        Me.lblSenseR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSenseR.Name = "lblSenseR"
        Me.lblSenseR.Size = New System.Drawing.Size(51, 17)
        Me.lblSenseR.TabIndex = 1
        Me.lblSenseR.Text = "Label1"
        '
        'tbpAdc
        '
        Me.tbpAdc.BackColor = System.Drawing.SystemColors.Control
        Me.tbpAdc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpAdc.Controls.Add(Me.cmbAdcSamples)
        Me.tbpAdc.Controls.Add(Me.lblAdcSamples)
        Me.tbpAdc.Controls.Add(Me.cmbAdcRate)
        Me.tbpAdc.Controls.Add(Me.lblAdcRate)
        Me.tbpAdc.Controls.Add(Me.chkAdcAvg)
        Me.tbpAdc.Controls.Add(Me.chkAdcEn)
        Me.tbpAdc.Location = New System.Drawing.Point(4, 28)
        Me.tbpAdc.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpAdc.Name = "tbpAdc"
        Me.tbpAdc.Size = New System.Drawing.Size(509, 265)
        Me.tbpAdc.TabIndex = 2
        Me.tbpAdc.Text = "ADC"
        '
        'cmbAdcSamples
        '
        Me.cmbAdcSamples.FormattingEnabled = True
        Me.cmbAdcSamples.Location = New System.Drawing.Point(189, 114)
        Me.cmbAdcSamples.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAdcSamples.Name = "cmbAdcSamples"
        Me.cmbAdcSamples.Size = New System.Drawing.Size(108, 24)
        Me.cmbAdcSamples.TabIndex = 20
        '
        'lblAdcSamples
        '
        Me.lblAdcSamples.AutoSize = True
        Me.lblAdcSamples.Location = New System.Drawing.Point(25, 118)
        Me.lblAdcSamples.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdcSamples.Name = "lblAdcSamples"
        Me.lblAdcSamples.Size = New System.Drawing.Size(51, 17)
        Me.lblAdcSamples.TabIndex = 19
        Me.lblAdcSamples.Text = "Label1"
        '
        'cmbAdcRate
        '
        Me.cmbAdcRate.FormattingEnabled = True
        Me.cmbAdcRate.Location = New System.Drawing.Point(189, 81)
        Me.cmbAdcRate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAdcRate.Name = "cmbAdcRate"
        Me.cmbAdcRate.Size = New System.Drawing.Size(108, 24)
        Me.cmbAdcRate.TabIndex = 18
        '
        'lblAdcRate
        '
        Me.lblAdcRate.AutoSize = True
        Me.lblAdcRate.Location = New System.Drawing.Point(25, 85)
        Me.lblAdcRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdcRate.Name = "lblAdcRate"
        Me.lblAdcRate.Size = New System.Drawing.Size(51, 17)
        Me.lblAdcRate.TabIndex = 17
        Me.lblAdcRate.Text = "Label1"
        '
        'chkAdcAvg
        '
        Me.chkAdcAvg.AutoSize = True
        Me.chkAdcAvg.Location = New System.Drawing.Point(31, 50)
        Me.chkAdcAvg.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAdcAvg.Name = "chkAdcAvg"
        Me.chkAdcAvg.Size = New System.Drawing.Size(95, 21)
        Me.chkAdcAvg.TabIndex = 16
        Me.chkAdcAvg.Text = "Vbus OVP"
        Me.chkAdcAvg.UseVisualStyleBackColor = True
        '
        'chkAdcEn
        '
        Me.chkAdcEn.AutoSize = True
        Me.chkAdcEn.Location = New System.Drawing.Point(31, 22)
        Me.chkAdcEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAdcEn.Name = "chkAdcEn"
        Me.chkAdcEn.Size = New System.Drawing.Size(95, 21)
        Me.chkAdcEn.TabIndex = 15
        Me.chkAdcEn.Text = "Vbus OVP"
        Me.chkAdcEn.UseVisualStyleBackColor = True
        '
        'tbpInt
        '
        Me.tbpInt.BackColor = System.Drawing.SystemColors.Control
        Me.tbpInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpInt.Controls.Add(Me.Label1)
        Me.tbpInt.Controls.Add(Me.chkIocMask)
        Me.tbpInt.Controls.Add(Me.chkTshutFltMask)
        Me.tbpInt.Controls.Add(Me.chkBatInsMask)
        Me.tbpInt.Controls.Add(Me.chkVbusInsMask)
        Me.tbpInt.Controls.Add(Me.chkVdropOvpMask)
        Me.tbpInt.Controls.Add(Me.chkVdropAlmMask)
        Me.tbpInt.Controls.Add(Me.chkAdcDoneMask)
        Me.tbpInt.Controls.Add(Me.chkWatchdogMask)
        Me.tbpInt.Controls.Add(Me.chkIbusRevMask)
        Me.tbpInt.Controls.Add(Me.chkTbatOtpMask)
        Me.tbpInt.Controls.Add(Me.chkTbusOtpMask)
        Me.tbpInt.Controls.Add(Me.chkVoutRegMask)
        Me.tbpInt.Controls.Add(Me.chkIbatRegMask)
        Me.tbpInt.Controls.Add(Me.chkVbatRegMask)
        Me.tbpInt.Controls.Add(Me.chkIbusRegMask)
        Me.tbpInt.Controls.Add(Me.chkVbusOvpMask)
        Me.tbpInt.Location = New System.Drawing.Point(4, 28)
        Me.tbpInt.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpInt.Name = "tbpInt"
        Me.tbpInt.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpInt.Size = New System.Drawing.Size(509, 265)
        Me.tbpInt.TabIndex = 0
        Me.tbpInt.Text = "Interrupts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Masked interrupts. Masked interrupts do not assert the interrupt pin."
        '
        'chkIocMask
        '
        Me.chkIocMask.AutoSize = True
        Me.chkIocMask.Location = New System.Drawing.Point(287, 230)
        Me.chkIocMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIocMask.Name = "chkIocMask"
        Me.chkIocMask.Size = New System.Drawing.Size(95, 21)
        Me.chkIocMask.TabIndex = 35
        Me.chkIocMask.Text = "Vbus OVP"
        Me.chkIocMask.UseVisualStyleBackColor = True
        '
        'chkTshutFltMask
        '
        Me.chkTshutFltMask.AutoSize = True
        Me.chkTshutFltMask.Location = New System.Drawing.Point(287, 202)
        Me.chkTshutFltMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTshutFltMask.Name = "chkTshutFltMask"
        Me.chkTshutFltMask.Size = New System.Drawing.Size(95, 21)
        Me.chkTshutFltMask.TabIndex = 34
        Me.chkTshutFltMask.Text = "Vbus OVP"
        Me.chkTshutFltMask.UseVisualStyleBackColor = True
        '
        'chkBatInsMask
        '
        Me.chkBatInsMask.AutoSize = True
        Me.chkBatInsMask.Location = New System.Drawing.Point(287, 174)
        Me.chkBatInsMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBatInsMask.Name = "chkBatInsMask"
        Me.chkBatInsMask.Size = New System.Drawing.Size(95, 21)
        Me.chkBatInsMask.TabIndex = 33
        Me.chkBatInsMask.Text = "Vbus OVP"
        Me.chkBatInsMask.UseVisualStyleBackColor = True
        '
        'chkVbusInsMask
        '
        Me.chkVbusInsMask.AutoSize = True
        Me.chkVbusInsMask.Location = New System.Drawing.Point(287, 145)
        Me.chkVbusInsMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbusInsMask.Name = "chkVbusInsMask"
        Me.chkVbusInsMask.Size = New System.Drawing.Size(95, 21)
        Me.chkVbusInsMask.TabIndex = 32
        Me.chkVbusInsMask.Text = "Vbus OVP"
        Me.chkVbusInsMask.UseVisualStyleBackColor = True
        '
        'chkVdropOvpMask
        '
        Me.chkVdropOvpMask.AutoSize = True
        Me.chkVdropOvpMask.Location = New System.Drawing.Point(287, 117)
        Me.chkVdropOvpMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVdropOvpMask.Name = "chkVdropOvpMask"
        Me.chkVdropOvpMask.Size = New System.Drawing.Size(95, 21)
        Me.chkVdropOvpMask.TabIndex = 31
        Me.chkVdropOvpMask.Text = "Vbus OVP"
        Me.chkVdropOvpMask.UseVisualStyleBackColor = True
        '
        'chkVdropAlmMask
        '
        Me.chkVdropAlmMask.AutoSize = True
        Me.chkVdropAlmMask.Location = New System.Drawing.Point(287, 89)
        Me.chkVdropAlmMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVdropAlmMask.Name = "chkVdropAlmMask"
        Me.chkVdropAlmMask.Size = New System.Drawing.Size(95, 21)
        Me.chkVdropAlmMask.TabIndex = 30
        Me.chkVdropAlmMask.Text = "Vbus OVP"
        Me.chkVdropAlmMask.UseVisualStyleBackColor = True
        '
        'chkAdcDoneMask
        '
        Me.chkAdcDoneMask.AutoSize = True
        Me.chkAdcDoneMask.Location = New System.Drawing.Point(287, 60)
        Me.chkAdcDoneMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAdcDoneMask.Name = "chkAdcDoneMask"
        Me.chkAdcDoneMask.Size = New System.Drawing.Size(95, 21)
        Me.chkAdcDoneMask.TabIndex = 29
        Me.chkAdcDoneMask.Text = "Vbus OVP"
        Me.chkAdcDoneMask.UseVisualStyleBackColor = True
        '
        'chkWatchdogMask
        '
        Me.chkWatchdogMask.AutoSize = True
        Me.chkWatchdogMask.Location = New System.Drawing.Point(287, 32)
        Me.chkWatchdogMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkWatchdogMask.Name = "chkWatchdogMask"
        Me.chkWatchdogMask.Size = New System.Drawing.Size(95, 21)
        Me.chkWatchdogMask.TabIndex = 28
        Me.chkWatchdogMask.Text = "Vbus OVP"
        Me.chkWatchdogMask.UseVisualStyleBackColor = True
        '
        'chkIbusRevMask
        '
        Me.chkIbusRevMask.AutoSize = True
        Me.chkIbusRevMask.Location = New System.Drawing.Point(16, 230)
        Me.chkIbusRevMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIbusRevMask.Name = "chkIbusRevMask"
        Me.chkIbusRevMask.Size = New System.Drawing.Size(95, 21)
        Me.chkIbusRevMask.TabIndex = 27
        Me.chkIbusRevMask.Text = "Vbus OVP"
        Me.chkIbusRevMask.UseVisualStyleBackColor = True
        '
        'chkTbatOtpMask
        '
        Me.chkTbatOtpMask.AutoSize = True
        Me.chkTbatOtpMask.Location = New System.Drawing.Point(16, 202)
        Me.chkTbatOtpMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTbatOtpMask.Name = "chkTbatOtpMask"
        Me.chkTbatOtpMask.Size = New System.Drawing.Size(95, 21)
        Me.chkTbatOtpMask.TabIndex = 26
        Me.chkTbatOtpMask.Text = "Vbus OVP"
        Me.chkTbatOtpMask.UseVisualStyleBackColor = True
        '
        'chkTbusOtpMask
        '
        Me.chkTbusOtpMask.AutoSize = True
        Me.chkTbusOtpMask.Location = New System.Drawing.Point(16, 174)
        Me.chkTbusOtpMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTbusOtpMask.Name = "chkTbusOtpMask"
        Me.chkTbusOtpMask.Size = New System.Drawing.Size(95, 21)
        Me.chkTbusOtpMask.TabIndex = 25
        Me.chkTbusOtpMask.Text = "Vbus OVP"
        Me.chkTbusOtpMask.UseVisualStyleBackColor = True
        '
        'chkVoutRegMask
        '
        Me.chkVoutRegMask.AutoSize = True
        Me.chkVoutRegMask.Location = New System.Drawing.Point(16, 145)
        Me.chkVoutRegMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVoutRegMask.Name = "chkVoutRegMask"
        Me.chkVoutRegMask.Size = New System.Drawing.Size(95, 21)
        Me.chkVoutRegMask.TabIndex = 24
        Me.chkVoutRegMask.Text = "Vbus OVP"
        Me.chkVoutRegMask.UseVisualStyleBackColor = True
        '
        'chkIbatRegMask
        '
        Me.chkIbatRegMask.AutoSize = True
        Me.chkIbatRegMask.Location = New System.Drawing.Point(16, 117)
        Me.chkIbatRegMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIbatRegMask.Name = "chkIbatRegMask"
        Me.chkIbatRegMask.Size = New System.Drawing.Size(95, 21)
        Me.chkIbatRegMask.TabIndex = 23
        Me.chkIbatRegMask.Text = "Vbus OVP"
        Me.chkIbatRegMask.UseVisualStyleBackColor = True
        '
        'chkVbatRegMask
        '
        Me.chkVbatRegMask.AutoSize = True
        Me.chkVbatRegMask.Location = New System.Drawing.Point(16, 89)
        Me.chkVbatRegMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbatRegMask.Name = "chkVbatRegMask"
        Me.chkVbatRegMask.Size = New System.Drawing.Size(95, 21)
        Me.chkVbatRegMask.TabIndex = 22
        Me.chkVbatRegMask.Text = "Vbus OVP"
        Me.chkVbatRegMask.UseVisualStyleBackColor = True
        '
        'chkIbusRegMask
        '
        Me.chkIbusRegMask.AutoSize = True
        Me.chkIbusRegMask.Location = New System.Drawing.Point(16, 60)
        Me.chkIbusRegMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIbusRegMask.Name = "chkIbusRegMask"
        Me.chkIbusRegMask.Size = New System.Drawing.Size(95, 21)
        Me.chkIbusRegMask.TabIndex = 21
        Me.chkIbusRegMask.Text = "Vbus OVP"
        Me.chkIbusRegMask.UseVisualStyleBackColor = True
        '
        'chkVbusOvpMask
        '
        Me.chkVbusOvpMask.AutoSize = True
        Me.chkVbusOvpMask.Location = New System.Drawing.Point(16, 32)
        Me.chkVbusOvpMask.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbusOvpMask.Name = "chkVbusOvpMask"
        Me.chkVbusOvpMask.Size = New System.Drawing.Size(95, 21)
        Me.chkVbusOvpMask.TabIndex = 20
        Me.chkVbusOvpMask.Text = "Vbus OVP"
        Me.chkVbusOvpMask.UseVisualStyleBackColor = True
        '
        'tbpEvents
        '
        Me.tbpEvents.BackColor = System.Drawing.SystemColors.Control
        Me.tbpEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpEvents.Controls.Add(Me.Label3)
        Me.tbpEvents.Controls.Add(Me.chkVdropAlmEn)
        Me.tbpEvents.Controls.Add(Me.chkVdropOvpEn)
        Me.tbpEvents.Controls.Add(Me.chkVbusPdEn)
        Me.tbpEvents.Controls.Add(Me.chkTbatOtpEn)
        Me.tbpEvents.Controls.Add(Me.chkTbusOtpEn)
        Me.tbpEvents.Controls.Add(Me.chkVoutRegEn)
        Me.tbpEvents.Controls.Add(Me.chkIbatRegEn)
        Me.tbpEvents.Controls.Add(Me.chkVbatRegEn)
        Me.tbpEvents.Controls.Add(Me.chkIbusRegEn)
        Me.tbpEvents.Controls.Add(Me.chkVbusOvpEn)
        Me.tbpEvents.Location = New System.Drawing.Point(4, 28)
        Me.tbpEvents.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpEvents.Name = "tbpEvents"
        Me.tbpEvents.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpEvents.Size = New System.Drawing.Size(509, 265)
        Me.tbpEvents.TabIndex = 3
        Me.tbpEvents.Text = "Events"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Enabled events"
        '
        'chkVdropAlmEn
        '
        Me.chkVdropAlmEn.AutoSize = True
        Me.chkVdropAlmEn.Location = New System.Drawing.Point(216, 161)
        Me.chkVdropAlmEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVdropAlmEn.Name = "chkVdropAlmEn"
        Me.chkVdropAlmEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVdropAlmEn.TabIndex = 33
        Me.chkVdropAlmEn.Text = "Vbus OVP"
        Me.chkVdropAlmEn.UseVisualStyleBackColor = True
        '
        'chkVdropOvpEn
        '
        Me.chkVdropOvpEn.AutoSize = True
        Me.chkVdropOvpEn.Location = New System.Drawing.Point(216, 133)
        Me.chkVdropOvpEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVdropOvpEn.Name = "chkVdropOvpEn"
        Me.chkVdropOvpEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVdropOvpEn.TabIndex = 32
        Me.chkVdropOvpEn.Text = "Vbus OVP"
        Me.chkVdropOvpEn.UseVisualStyleBackColor = True
        '
        'chkVbusPdEn
        '
        Me.chkVbusPdEn.AutoSize = True
        Me.chkVbusPdEn.Location = New System.Drawing.Point(216, 105)
        Me.chkVbusPdEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbusPdEn.Name = "chkVbusPdEn"
        Me.chkVbusPdEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVbusPdEn.TabIndex = 31
        Me.chkVbusPdEn.Text = "Vbus OVP"
        Me.chkVbusPdEn.UseVisualStyleBackColor = True
        '
        'chkTbatOtpEn
        '
        Me.chkTbatOtpEn.AutoSize = True
        Me.chkTbatOtpEn.Location = New System.Drawing.Point(216, 76)
        Me.chkTbatOtpEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTbatOtpEn.Name = "chkTbatOtpEn"
        Me.chkTbatOtpEn.Size = New System.Drawing.Size(95, 21)
        Me.chkTbatOtpEn.TabIndex = 30
        Me.chkTbatOtpEn.Text = "Vbus OVP"
        Me.chkTbatOtpEn.UseVisualStyleBackColor = True
        '
        'chkTbusOtpEn
        '
        Me.chkTbusOtpEn.AutoSize = True
        Me.chkTbusOtpEn.Location = New System.Drawing.Point(216, 48)
        Me.chkTbusOtpEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTbusOtpEn.Name = "chkTbusOtpEn"
        Me.chkTbusOtpEn.Size = New System.Drawing.Size(95, 21)
        Me.chkTbusOtpEn.TabIndex = 29
        Me.chkTbusOtpEn.Text = "Vbus OVP"
        Me.chkTbusOtpEn.UseVisualStyleBackColor = True
        '
        'chkVoutRegEn
        '
        Me.chkVoutRegEn.AutoSize = True
        Me.chkVoutRegEn.Location = New System.Drawing.Point(16, 161)
        Me.chkVoutRegEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVoutRegEn.Name = "chkVoutRegEn"
        Me.chkVoutRegEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVoutRegEn.TabIndex = 28
        Me.chkVoutRegEn.Text = "Vbus OVP"
        Me.chkVoutRegEn.UseVisualStyleBackColor = True
        '
        'chkIbatRegEn
        '
        Me.chkIbatRegEn.AutoSize = True
        Me.chkIbatRegEn.Location = New System.Drawing.Point(16, 133)
        Me.chkIbatRegEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIbatRegEn.Name = "chkIbatRegEn"
        Me.chkIbatRegEn.Size = New System.Drawing.Size(95, 21)
        Me.chkIbatRegEn.TabIndex = 27
        Me.chkIbatRegEn.Text = "Vbus OVP"
        Me.chkIbatRegEn.UseVisualStyleBackColor = True
        '
        'chkVbatRegEn
        '
        Me.chkVbatRegEn.AutoSize = True
        Me.chkVbatRegEn.Location = New System.Drawing.Point(16, 105)
        Me.chkVbatRegEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbatRegEn.Name = "chkVbatRegEn"
        Me.chkVbatRegEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVbatRegEn.TabIndex = 26
        Me.chkVbatRegEn.Text = "Vbus OVP"
        Me.chkVbatRegEn.UseVisualStyleBackColor = True
        '
        'chkIbusRegEn
        '
        Me.chkIbusRegEn.AutoSize = True
        Me.chkIbusRegEn.Location = New System.Drawing.Point(16, 76)
        Me.chkIbusRegEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIbusRegEn.Name = "chkIbusRegEn"
        Me.chkIbusRegEn.Size = New System.Drawing.Size(95, 21)
        Me.chkIbusRegEn.TabIndex = 25
        Me.chkIbusRegEn.Text = "Vbus OVP"
        Me.chkIbusRegEn.UseVisualStyleBackColor = True
        '
        'chkVbusOvpEn
        '
        Me.chkVbusOvpEn.AutoSize = True
        Me.chkVbusOvpEn.Location = New System.Drawing.Point(16, 48)
        Me.chkVbusOvpEn.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVbusOvpEn.Name = "chkVbusOvpEn"
        Me.chkVbusOvpEn.Size = New System.Drawing.Size(95, 21)
        Me.chkVbusOvpEn.TabIndex = 24
        Me.chkVbusOvpEn.Text = "Vbus OVP"
        Me.chkVbusOvpEn.UseVisualStyleBackColor = True
        '
        'tbpProt
        '
        Me.tbpProt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpProt.Controls.Add(Me.lblTbatOtpVal)
        Me.tbpProt.Controls.Add(Me.trbTbatOtp)
        Me.tbpProt.Controls.Add(Me.lblTbatOtp)
        Me.tbpProt.Controls.Add(Me.lblTbusOtpVal)
        Me.tbpProt.Controls.Add(Me.trbTbusOtp)
        Me.tbpProt.Controls.Add(Me.lblTbusOtp)
        Me.tbpProt.Controls.Add(Me.lblVdropAlmVal)
        Me.tbpProt.Controls.Add(Me.trbVdropAlm)
        Me.tbpProt.Controls.Add(Me.lblVdropAlm)
        Me.tbpProt.Controls.Add(Me.lblVdropOvpVal)
        Me.tbpProt.Controls.Add(Me.trbVdropOvp)
        Me.tbpProt.Controls.Add(Me.lblVdropOvp)
        Me.tbpProt.Controls.Add(Me.lblVbusOvpVal)
        Me.tbpProt.Controls.Add(Me.trbVbusOvp)
        Me.tbpProt.Controls.Add(Me.lblVbusOvp)
        Me.tbpProt.Controls.Add(Me.cmbVbusOvpDly)
        Me.tbpProt.Controls.Add(Me.lblVbusOvpDly)
        Me.tbpProt.Controls.Add(Me.cmbOcpRes)
        Me.tbpProt.Controls.Add(Me.lblOcpRes)
        Me.tbpProt.Controls.Add(Me.lblIbusOcpVal)
        Me.tbpProt.Controls.Add(Me.trbIbusOcp)
        Me.tbpProt.Controls.Add(Me.lblIbusOCP)
        Me.tbpProt.Location = New System.Drawing.Point(4, 28)
        Me.tbpProt.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpProt.Name = "tbpProt"
        Me.tbpProt.Size = New System.Drawing.Size(509, 265)
        Me.tbpProt.TabIndex = 4
        Me.tbpProt.Text = "Protection"
        Me.tbpProt.UseVisualStyleBackColor = True
        '
        'lblTbatOtpVal
        '
        Me.lblTbatOtpVal.AutoSize = True
        Me.lblTbatOtpVal.Location = New System.Drawing.Point(428, 218)
        Me.lblTbatOtpVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTbatOtpVal.Name = "lblTbatOtpVal"
        Me.lblTbatOtpVal.Size = New System.Drawing.Size(51, 17)
        Me.lblTbatOtpVal.TabIndex = 43
        Me.lblTbatOtpVal.Text = "Label8"
        '
        'trbTbatOtp
        '
        Me.trbTbatOtp.AutoSize = False
        Me.trbTbatOtp.Location = New System.Drawing.Point(172, 215)
        Me.trbTbatOtp.Margin = New System.Windows.Forms.Padding(4)
        Me.trbTbatOtp.Name = "trbTbatOtp"
        Me.trbTbatOtp.Size = New System.Drawing.Size(252, 31)
        Me.trbTbatOtp.TabIndex = 42
        '
        'lblTbatOtp
        '
        Me.lblTbatOtp.AutoSize = True
        Me.lblTbatOtp.Location = New System.Drawing.Point(16, 218)
        Me.lblTbatOtp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTbatOtp.Name = "lblTbatOtp"
        Me.lblTbatOtp.Size = New System.Drawing.Size(51, 17)
        Me.lblTbatOtp.TabIndex = 41
        Me.lblTbatOtp.Text = "Label6"
        '
        'lblTbusOtpVal
        '
        Me.lblTbusOtpVal.AutoSize = True
        Me.lblTbusOtpVal.Location = New System.Drawing.Point(428, 183)
        Me.lblTbusOtpVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTbusOtpVal.Name = "lblTbusOtpVal"
        Me.lblTbusOtpVal.Size = New System.Drawing.Size(51, 17)
        Me.lblTbusOtpVal.TabIndex = 40
        Me.lblTbusOtpVal.Text = "Label6"
        '
        'trbTbusOtp
        '
        Me.trbTbusOtp.AutoSize = False
        Me.trbTbusOtp.Location = New System.Drawing.Point(172, 181)
        Me.trbTbusOtp.Margin = New System.Windows.Forms.Padding(4)
        Me.trbTbusOtp.Name = "trbTbusOtp"
        Me.trbTbusOtp.Size = New System.Drawing.Size(252, 31)
        Me.trbTbusOtp.TabIndex = 39
        '
        'lblTbusOtp
        '
        Me.lblTbusOtp.AutoSize = True
        Me.lblTbusOtp.Location = New System.Drawing.Point(16, 183)
        Me.lblTbusOtp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTbusOtp.Name = "lblTbusOtp"
        Me.lblTbusOtp.Size = New System.Drawing.Size(51, 17)
        Me.lblTbusOtp.TabIndex = 38
        Me.lblTbusOtp.Text = "Label6"
        '
        'lblVdropAlmVal
        '
        Me.lblVdropAlmVal.AutoSize = True
        Me.lblVdropAlmVal.Location = New System.Drawing.Point(428, 149)
        Me.lblVdropAlmVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVdropAlmVal.Name = "lblVdropAlmVal"
        Me.lblVdropAlmVal.Size = New System.Drawing.Size(51, 17)
        Me.lblVdropAlmVal.TabIndex = 37
        Me.lblVdropAlmVal.Text = "Label6"
        '
        'trbVdropAlm
        '
        Me.trbVdropAlm.AutoSize = False
        Me.trbVdropAlm.Location = New System.Drawing.Point(172, 146)
        Me.trbVdropAlm.Margin = New System.Windows.Forms.Padding(4)
        Me.trbVdropAlm.Name = "trbVdropAlm"
        Me.trbVdropAlm.Size = New System.Drawing.Size(252, 31)
        Me.trbVdropAlm.TabIndex = 36
        '
        'lblVdropAlm
        '
        Me.lblVdropAlm.AutoSize = True
        Me.lblVdropAlm.Location = New System.Drawing.Point(16, 149)
        Me.lblVdropAlm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVdropAlm.Name = "lblVdropAlm"
        Me.lblVdropAlm.Size = New System.Drawing.Size(51, 17)
        Me.lblVdropAlm.TabIndex = 35
        Me.lblVdropAlm.Text = "Label6"
        '
        'lblVdropOvpVal
        '
        Me.lblVdropOvpVal.AutoSize = True
        Me.lblVdropOvpVal.Location = New System.Drawing.Point(428, 114)
        Me.lblVdropOvpVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVdropOvpVal.Name = "lblVdropOvpVal"
        Me.lblVdropOvpVal.Size = New System.Drawing.Size(51, 17)
        Me.lblVdropOvpVal.TabIndex = 34
        Me.lblVdropOvpVal.Text = "Label6"
        '
        'trbVdropOvp
        '
        Me.trbVdropOvp.AutoSize = False
        Me.trbVdropOvp.Location = New System.Drawing.Point(172, 112)
        Me.trbVdropOvp.Margin = New System.Windows.Forms.Padding(4)
        Me.trbVdropOvp.Name = "trbVdropOvp"
        Me.trbVdropOvp.Size = New System.Drawing.Size(252, 31)
        Me.trbVdropOvp.TabIndex = 33
        '
        'lblVdropOvp
        '
        Me.lblVdropOvp.AutoSize = True
        Me.lblVdropOvp.Location = New System.Drawing.Point(16, 114)
        Me.lblVdropOvp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVdropOvp.Name = "lblVdropOvp"
        Me.lblVdropOvp.Size = New System.Drawing.Size(51, 17)
        Me.lblVdropOvp.TabIndex = 32
        Me.lblVdropOvp.Text = "Label6"
        '
        'lblVbusOvpVal
        '
        Me.lblVbusOvpVal.AutoSize = True
        Me.lblVbusOvpVal.Location = New System.Drawing.Point(428, 80)
        Me.lblVbusOvpVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVbusOvpVal.Name = "lblVbusOvpVal"
        Me.lblVbusOvpVal.Size = New System.Drawing.Size(51, 17)
        Me.lblVbusOvpVal.TabIndex = 31
        Me.lblVbusOvpVal.Text = "Label6"
        '
        'trbVbusOvp
        '
        Me.trbVbusOvp.AutoSize = False
        Me.trbVbusOvp.Location = New System.Drawing.Point(172, 78)
        Me.trbVbusOvp.Margin = New System.Windows.Forms.Padding(4)
        Me.trbVbusOvp.Name = "trbVbusOvp"
        Me.trbVbusOvp.Size = New System.Drawing.Size(252, 31)
        Me.trbVbusOvp.TabIndex = 30
        '
        'lblVbusOvp
        '
        Me.lblVbusOvp.AutoSize = True
        Me.lblVbusOvp.Location = New System.Drawing.Point(16, 80)
        Me.lblVbusOvp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVbusOvp.Name = "lblVbusOvp"
        Me.lblVbusOvp.Size = New System.Drawing.Size(51, 17)
        Me.lblVbusOvp.TabIndex = 29
        Me.lblVbusOvp.Text = "Label6"
        '
        'cmbVbusOvpDly
        '
        Me.cmbVbusOvpDly.FormattingEnabled = True
        Me.cmbVbusOvpDly.Location = New System.Drawing.Point(175, 11)
        Me.cmbVbusOvpDly.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbVbusOvpDly.Name = "cmbVbusOvpDly"
        Me.cmbVbusOvpDly.Size = New System.Drawing.Size(65, 24)
        Me.cmbVbusOvpDly.TabIndex = 28
        '
        'lblVbusOvpDly
        '
        Me.lblVbusOvpDly.AutoSize = True
        Me.lblVbusOvpDly.Location = New System.Drawing.Point(16, 15)
        Me.lblVbusOvpDly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVbusOvpDly.Name = "lblVbusOvpDly"
        Me.lblVbusOvpDly.Size = New System.Drawing.Size(51, 17)
        Me.lblVbusOvpDly.TabIndex = 27
        Me.lblVbusOvpDly.Text = "Label6"
        '
        'cmbOcpRes
        '
        Me.cmbOcpRes.FormattingEnabled = True
        Me.cmbOcpRes.Location = New System.Drawing.Point(367, 11)
        Me.cmbOcpRes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbOcpRes.Name = "cmbOcpRes"
        Me.cmbOcpRes.Size = New System.Drawing.Size(128, 24)
        Me.cmbOcpRes.TabIndex = 26
        '
        'lblOcpRes
        '
        Me.lblOcpRes.AutoSize = True
        Me.lblOcpRes.Location = New System.Drawing.Point(249, 15)
        Me.lblOcpRes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOcpRes.Name = "lblOcpRes"
        Me.lblOcpRes.Size = New System.Drawing.Size(51, 17)
        Me.lblOcpRes.TabIndex = 25
        Me.lblOcpRes.Text = "Label6"
        '
        'lblIbusOcpVal
        '
        Me.lblIbusOcpVal.AutoSize = True
        Me.lblIbusOcpVal.Location = New System.Drawing.Point(428, 47)
        Me.lblIbusOcpVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIbusOcpVal.Name = "lblIbusOcpVal"
        Me.lblIbusOcpVal.Size = New System.Drawing.Size(51, 17)
        Me.lblIbusOcpVal.TabIndex = 24
        Me.lblIbusOcpVal.Text = "Label6"
        '
        'trbIbusOcp
        '
        Me.trbIbusOcp.AutoSize = False
        Me.trbIbusOcp.Location = New System.Drawing.Point(172, 44)
        Me.trbIbusOcp.Margin = New System.Windows.Forms.Padding(4)
        Me.trbIbusOcp.Name = "trbIbusOcp"
        Me.trbIbusOcp.Size = New System.Drawing.Size(252, 31)
        Me.trbIbusOcp.TabIndex = 23
        '
        'lblIbusOCP
        '
        Me.lblIbusOCP.AutoSize = True
        Me.lblIbusOCP.Location = New System.Drawing.Point(16, 47)
        Me.lblIbusOCP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIbusOCP.Name = "lblIbusOCP"
        Me.lblIbusOCP.Size = New System.Drawing.Size(51, 17)
        Me.lblIbusOCP.TabIndex = 22
        Me.lblIbusOCP.Text = "Label6"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PCA9468.My.Resources.Resources.NXP_logo_s
        Me.PictureBox1.Location = New System.Drawing.Point(628, 71)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 62)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'pnlRegisters
        '
        Me.pnlRegisters.Location = New System.Drawing.Point(0, 126)
        Me.pnlRegisters.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlRegisters.Name = "pnlRegisters"
        Me.pnlRegisters.Size = New System.Drawing.Size(780, 491)
        Me.pnlRegisters.TabIndex = 29
        Me.pnlRegisters.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 645)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlFunctions)
        Me.Controls.Add(Me.theToolbar)
        Me.Controls.Add(Me.grpDevice)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TheMenu)
        Me.Controls.Add(Me.pnlRegisters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.TheMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PCA949x"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpDevice.ResumeLayout(False)
        Me.grpDevice.PerformLayout()
        Me.TheMenu.ResumeLayout(False)
        Me.TheMenu.PerformLayout()
        Me.theToolbar.ResumeLayout(False)
        Me.theToolbar.PerformLayout()
        Me.pnlFunctions.ResumeLayout(False)
        Me.grpRaised.ResumeLayout(False)
        Me.grpAdcChannels.ResumeLayout(False)
        Me.grpAdcChannels.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tbpControl.ResumeLayout(False)
        Me.tbpControl.PerformLayout()
        CType(Me.trbIbusReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbIbatReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbVbatReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbVoutReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpAdc.ResumeLayout(False)
        Me.tbpAdc.PerformLayout()
        Me.tbpInt.ResumeLayout(False)
        Me.tbpInt.PerformLayout()
        Me.tbpEvents.ResumeLayout(False)
        Me.tbpEvents.PerformLayout()
        Me.tbpProt.ResumeLayout(False)
        Me.tbpProt.PerformLayout()
        CType(Me.trbTbatOtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbTbusOtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbVdropAlm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbVdropOvp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbVbusOvp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbIbusOcp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslConnection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrWork As System.Windows.Forms.Timer
    Friend WithEvents tslInterface As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grpDevice As System.Windows.Forms.GroupBox
    Friend WithEvents lblRev As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAddr As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TheMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFunctions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRegisters As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmIO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRead As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmWrite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmInterval0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmInterval1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmInterval2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmInterval4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmManual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents theToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents pnlFunctions As System.Windows.Forms.Panel
    Friend WithEvents grpRaised As System.Windows.Forms.GroupBox
    Friend WithEvents chkIocFlt As System.Windows.Forms.CheckBox
    Friend WithEvents chkTshutFlt As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbatIns As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbusIns As System.Windows.Forms.CheckBox
    Friend WithEvents chkVdropOvpFlt As System.Windows.Forms.CheckBox
    Friend WithEvents chkVdropAlmFlt As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdcDone As System.Windows.Forms.CheckBox
    Friend WithEvents chkWatchdogFlt As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbusRevFlt As System.Windows.Forms.CheckBox
    Friend WithEvents chkTbatOtpFlt As System.Windows.Forms.CheckBox
    Friend WithEvents chkTbusOtpFlt As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoutLdoReg As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbatLdoReg As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbatLdoReg As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbusLdoReg As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbusOvpFlt As System.Windows.Forms.CheckBox
    Friend WithEvents grpAdcChannels As System.Windows.Forms.GroupBox
    Friend WithEvents txtTbat As System.Windows.Forms.TextBox
    Friend WithEvents txtTbus As System.Windows.Forms.TextBox
    Friend WithEvents txtVbat As System.Windows.Forms.TextBox
    Friend WithEvents txtIbat As System.Windows.Forms.TextBox
    Friend WithEvents txtVout As System.Windows.Forms.TextBox
    Friend WithEvents txtVdrop As System.Windows.Forms.TextBox
    Friend WithEvents txtIbus As System.Windows.Forms.TextBox
    Friend WithEvents txtVbus As System.Windows.Forms.TextBox
    Friend WithEvents txtDieTemp As System.Windows.Forms.TextBox
    Friend WithEvents chkTbatAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkTbusAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbatAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbatAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVdropAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoutAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbusAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbusAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkTdieAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tbpControl As System.Windows.Forms.TabPage
    Friend WithEvents lblIbusRegVal As System.Windows.Forms.Label
    Friend WithEvents trbIbusReg As System.Windows.Forms.TrackBar
    Friend WithEvents lblIbusReg As System.Windows.Forms.Label
    Friend WithEvents lblIbatRegVal As System.Windows.Forms.Label
    Friend WithEvents trbIbatReg As System.Windows.Forms.TrackBar
    Friend WithEvents lblIbatReg As System.Windows.Forms.Label
    Friend WithEvents lblVbatRegVal As System.Windows.Forms.Label
    Friend WithEvents trbVbatReg As System.Windows.Forms.TrackBar
    Friend WithEvents lblVbatReg As System.Windows.Forms.Label
    Friend WithEvents lblVoutRegVal As System.Windows.Forms.Label
    Friend WithEvents trbVoutReg As System.Windows.Forms.TrackBar
    Friend WithEvents lblVoutReg As System.Windows.Forms.Label
    Friend WithEvents chkChgEn As System.Windows.Forms.CheckBox
    Friend WithEvents cmbIrevSet As System.Windows.Forms.ComboBox
    Friend WithEvents lblIrevSet As System.Windows.Forms.Label
    Friend WithEvents cmbWatchdog As System.Windows.Forms.ComboBox
    Friend WithEvents lblWatchdog As System.Windows.Forms.Label
    Friend WithEvents cmbSenseR As System.Windows.Forms.ComboBox
    Friend WithEvents lblSenseR As System.Windows.Forms.Label
    Friend WithEvents tbpAdc As System.Windows.Forms.TabPage
    Friend WithEvents cmbAdcSamples As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdcSamples As System.Windows.Forms.Label
    Friend WithEvents cmbAdcRate As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdcRate As System.Windows.Forms.Label
    Friend WithEvents chkAdcAvg As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdcEn As System.Windows.Forms.CheckBox
    Friend WithEvents tbpInt As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkIocMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkTshutFltMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkBatInsMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbusInsMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkVdropOvpMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkVdropAlmMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkAdcDoneMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkWatchdogMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbusRevMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkTbatOtpMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkTbusOtpMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoutRegMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbatRegMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbatRegMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbusRegMask As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbusOvpMask As System.Windows.Forms.CheckBox
    Friend WithEvents tbpEvents As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkVdropAlmEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVdropOvpEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbusPdEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkTbatOtpEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkTbusOtpEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVoutRegEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbatRegEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbatRegEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkIbusRegEn As System.Windows.Forms.CheckBox
    Friend WithEvents chkVbusOvpEn As System.Windows.Forms.CheckBox
    Friend WithEvents tbpProt As System.Windows.Forms.TabPage
    Friend WithEvents lblTbatOtpVal As System.Windows.Forms.Label
    Friend WithEvents trbTbatOtp As System.Windows.Forms.TrackBar
    Friend WithEvents lblTbatOtp As System.Windows.Forms.Label
    Friend WithEvents lblTbusOtpVal As System.Windows.Forms.Label
    Friend WithEvents trbTbusOtp As System.Windows.Forms.TrackBar
    Friend WithEvents lblTbusOtp As System.Windows.Forms.Label
    Friend WithEvents lblVdropAlmVal As System.Windows.Forms.Label
    Friend WithEvents trbVdropAlm As System.Windows.Forms.TrackBar
    Friend WithEvents lblVdropAlm As System.Windows.Forms.Label
    Friend WithEvents lblVdropOvpVal As System.Windows.Forms.Label
    Friend WithEvents trbVdropOvp As System.Windows.Forms.TrackBar
    Friend WithEvents lblVdropOvp As System.Windows.Forms.Label
    Friend WithEvents lblVbusOvpVal As System.Windows.Forms.Label
    Friend WithEvents trbVbusOvp As System.Windows.Forms.TrackBar
    Friend WithEvents lblVbusOvp As System.Windows.Forms.Label
    Friend WithEvents cmbVbusOvpDly As System.Windows.Forms.ComboBox
    Friend WithEvents lblVbusOvpDly As System.Windows.Forms.Label
    Friend WithEvents cmbOcpRes As System.Windows.Forms.ComboBox
    Friend WithEvents lblOcpRes As System.Windows.Forms.Label
    Friend WithEvents lblIbusOcpVal As System.Windows.Forms.Label
    Friend WithEvents trbIbusOcp As System.Windows.Forms.TrackBar
    Friend WithEvents lblIbusOCP As System.Windows.Forms.Label
    Friend WithEvents tsbWrite As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRead As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbReset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbFunctions As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRegisters As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tscRefresh As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents pnlRegisters As System.Windows.Forms.Panel

End Class
