<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerminal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTerminal))
        Me.txtPoleDisplay = New System.Windows.Forms.TextBox()
        Me.PanelDetails = New System.Windows.Forms.Panel()
        Me.txtMachineNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTIN = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBIRPermit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboAuthentication = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTerminal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrinter = New System.Windows.Forms.TextBox()
        Me.lvTerminal = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.txtPosManagerPrinter = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.chkPrintReportEveryEnd = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtLine4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLine1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLine2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLine3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rbSRRollPaper = New System.Windows.Forms.RadioButton()
        Me.rbSRReceipt = New System.Windows.Forms.RadioButton()
        Me.rbSRItem = New System.Windows.Forms.RadioButton()
        Me.rbSRTransaction = New System.Windows.Forms.RadioButton()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.chkPrintReportToPrinter = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkExportToPDF = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtPrinterName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPrintNoCopy = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.chkPrintCoupon = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkPrintPoints = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkPrintReceipt = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnBrowseFolder = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtPDFFilepath = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnNew = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PanelDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPoleDisplay
        '
        Me.txtPoleDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoleDisplay.Location = New System.Drawing.Point(110, 59)
        Me.txtPoleDisplay.Name = "txtPoleDisplay"
        Me.txtPoleDisplay.Size = New System.Drawing.Size(258, 22)
        Me.txtPoleDisplay.TabIndex = 37
        '
        'PanelDetails
        '
        Me.PanelDetails.BackColor = System.Drawing.Color.Transparent
        Me.PanelDetails.Controls.Add(Me.txtMachineNo)
        Me.PanelDetails.Controls.Add(Me.Label12)
        Me.PanelDetails.Controls.Add(Me.Label13)
        Me.PanelDetails.Controls.Add(Me.txtSerial)
        Me.PanelDetails.Controls.Add(Me.Label15)
        Me.PanelDetails.Controls.Add(Me.txtTIN)
        Me.PanelDetails.Controls.Add(Me.Label16)
        Me.PanelDetails.Controls.Add(Me.txtBIRPermit)
        Me.PanelDetails.Controls.Add(Me.GroupBox1)
        Me.PanelDetails.Controls.Add(Me.txtTerminal)
        Me.PanelDetails.Controls.Add(Me.Label4)
        Me.PanelDetails.Controls.Add(Me.Label6)
        Me.PanelDetails.Controls.Add(Me.txtIP)
        Me.PanelDetails.Controls.Add(Me.Label10)
        Me.PanelDetails.Controls.Add(Me.txtPoleDisplay)
        Me.PanelDetails.Enabled = False
        Me.PanelDetails.Location = New System.Drawing.Point(8, 11)
        Me.PanelDetails.Name = "PanelDetails"
        Me.PanelDetails.Size = New System.Drawing.Size(752, 202)
        Me.PanelDetails.TabIndex = 73
        '
        'txtMachineNo
        '
        Me.txtMachineNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachineNo.Location = New System.Drawing.Point(110, 87)
        Me.txtMachineNo.Name = "txtMachineNo"
        Me.txtMachineNo.Size = New System.Drawing.Size(258, 22)
        Me.txtMachineNo.TabIndex = 75
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Machine No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Serial No."
        '
        'txtSerial
        '
        Me.txtSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(110, 115)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(258, 22)
        Me.txtSerial.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 16)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "TIN No."
        '
        'txtTIN
        '
        Me.txtTIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIN.Location = New System.Drawing.Point(110, 143)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Size = New System.Drawing.Size(258, 22)
        Me.txtTIN.TabIndex = 72
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(8, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 16)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "BIR Permit No."
        '
        'txtBIRPermit
        '
        Me.txtBIRPermit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBIRPermit.Location = New System.Drawing.Point(110, 173)
        Me.txtBIRPermit.Name = "txtBIRPermit"
        Me.txtBIRPermit.Size = New System.Drawing.Size(258, 22)
        Me.txtBIRPermit.TabIndex = 74
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboAuthentication)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDatabase)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(374, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 192)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Network Connection"
        '
        'txtServer
        '
        Me.txtServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.Location = New System.Drawing.Point(98, 19)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(258, 22)
        Me.txtServer.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Server"
        '
        'cboAuthentication
        '
        Me.cboAuthentication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAuthentication.FormattingEnabled = True
        Me.cboAuthentication.Items.AddRange(New Object() {"Windows Authentication", "Sql Server Authentcation"})
        Me.cboAuthentication.Location = New System.Drawing.Point(98, 75)
        Me.cboAuthentication.Name = "cboAuthentication"
        Me.cboAuthentication.Size = New System.Drawing.Size(258, 23)
        Me.cboAuthentication.TabIndex = 64
        Me.cboAuthentication.Text = "Windows Authentication"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Database"
        '
        'txtDatabase
        '
        Me.txtDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabase.Location = New System.Drawing.Point(98, 47)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(258, 22)
        Me.txtDatabase.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(98, 132)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(258, 22)
        Me.txtPassword.TabIndex = 58
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(98, 104)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(258, 22)
        Me.txtUsername.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Authentication"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Username"
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(98, 160)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(258, 22)
        Me.txtPort.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Port"
        '
        'txtTerminal
        '
        Me.txtTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerminal.Location = New System.Drawing.Point(110, 3)
        Me.txtTerminal.Name = "txtTerminal"
        Me.txtTerminal.Size = New System.Drawing.Size(258, 22)
        Me.txtTerminal.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Terminal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "IP Address"
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(110, 31)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(258, 22)
        Me.txtIP.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Pole Display"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(144, 341)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Printer"
        '
        'txtPrinter
        '
        Me.txtPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrinter.Location = New System.Drawing.Point(246, 341)
        Me.txtPrinter.Name = "txtPrinter"
        Me.txtPrinter.Size = New System.Drawing.Size(258, 22)
        Me.txtPrinter.TabIndex = 35
        '
        'lvTerminal
        '
        '
        '
        '
        Me.lvTerminal.Border.Class = "ListViewBorder"
        Me.lvTerminal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvTerminal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTerminal.FullRowSelect = True
        Me.lvTerminal.GridLines = True
        Me.lvTerminal.Location = New System.Drawing.Point(8, 219)
        Me.lvTerminal.Name = "lvTerminal"
        Me.lvTerminal.Size = New System.Drawing.Size(746, 183)
        Me.lvTerminal.TabIndex = 66
        Me.lvTerminal.UseCompatibleStateImageBehavior = False
        Me.lvTerminal.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = " #"
        Me.ColumnHeader3.Width = 39
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Terminal Name"
        Me.ColumnHeader1.Width = 131
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IP Address"
        Me.ColumnHeader2.Width = 132
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Connection Properties"
        Me.ColumnHeader4.Width = 328
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Authentication"
        Me.ColumnHeader5.Width = 116
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Printer"
        Me.ColumnHeader6.Width = 151
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Pole Display"
        Me.ColumnHeader7.Width = 97
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(875, 436)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 74
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Document
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.txtPosManagerPrinter)
        Me.SuperTabControlPanel2.Controls.Add(Me.LabelX8)
        Me.SuperTabControlPanel2.Controls.Add(Me.chkPrintReportEveryEnd)
        Me.SuperTabControlPanel2.Controls.Add(Me.GroupPanel2)
        Me.SuperTabControlPanel2.Controls.Add(Me.GroupPanel1)
        Me.SuperTabControlPanel2.Controls.Add(Me.ButtonX1)
        Me.SuperTabControlPanel2.Controls.Add(Me.ButtonX2)
        Me.SuperTabControlPanel2.Controls.Add(Me.chkPrintReportToPrinter)
        Me.SuperTabControlPanel2.Controls.Add(Me.chkExportToPDF)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtPrinterName)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtPrintNoCopy)
        Me.SuperTabControlPanel2.Controls.Add(Me.LabelX3)
        Me.SuperTabControlPanel2.Controls.Add(Me.LabelX2)
        Me.SuperTabControlPanel2.Controls.Add(Me.chkPrintCoupon)
        Me.SuperTabControlPanel2.Controls.Add(Me.chkPrintPoints)
        Me.SuperTabControlPanel2.Controls.Add(Me.chkPrintReceipt)
        Me.SuperTabControlPanel2.Controls.Add(Me.btnBrowseFolder)
        Me.SuperTabControlPanel2.Controls.Add(Me.LabelX1)
        Me.SuperTabControlPanel2.Controls.Add(Me.txtPDFFilepath)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 31)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(875, 405)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'txtPosManagerPrinter
        '
        '
        '
        '
        Me.txtPosManagerPrinter.Border.Class = "TextBoxBorder"
        Me.txtPosManagerPrinter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPosManagerPrinter.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosManagerPrinter.Location = New System.Drawing.Point(161, 53)
        Me.txtPosManagerPrinter.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtPosManagerPrinter.Name = "txtPosManagerPrinter"
        Me.txtPosManagerPrinter.Size = New System.Drawing.Size(312, 24)
        Me.txtPosManagerPrinter.TabIndex = 85
        Me.txtPosManagerPrinter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(15, 51)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(140, 26)
        Me.LabelX8.TabIndex = 84
        Me.LabelX8.Text = "POS Manager Printer"
        '
        'chkPrintReportEveryEnd
        '
        Me.chkPrintReportEveryEnd.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkPrintReportEveryEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkPrintReportEveryEnd.Checked = True
        Me.chkPrintReportEveryEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintReportEveryEnd.CheckValue = "Y"
        Me.chkPrintReportEveryEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintReportEveryEnd.Location = New System.Drawing.Point(565, 140)
        Me.chkPrintReportEveryEnd.Name = "chkPrintReportEveryEnd"
        Me.chkPrintReportEveryEnd.Size = New System.Drawing.Size(294, 18)
        Me.chkPrintReportEveryEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkPrintReportEveryEnd.TabIndex = 83
        Me.chkPrintReportEveryEnd.Text = "Print Sales Report after End-of-Shift "
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.txtLine4)
        Me.GroupPanel2.Controls.Add(Me.txtLine1)
        Me.GroupPanel2.Controls.Add(Me.txtLine2)
        Me.GroupPanel2.Controls.Add(Me.txtLine3)
        Me.GroupPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(15, 160)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(458, 173)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 82
        Me.GroupPanel2.Text = "Receipt Footer"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(3, 102)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(74, 26)
        Me.LabelX6.TabIndex = 78
        Me.LabelX6.Text = "Line 4"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(3, 72)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(74, 26)
        Me.LabelX7.TabIndex = 77
        Me.LabelX7.Text = "Line 3"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(3, 41)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(74, 26)
        Me.LabelX5.TabIndex = 76
        Me.LabelX5.Text = "Line 2"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 11)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(74, 26)
        Me.LabelX4.TabIndex = 75
        Me.LabelX4.Text = "Line 1"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtLine4
        '
        '
        '
        '
        Me.txtLine4.Border.Class = "TextBoxBorder"
        Me.txtLine4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLine4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine4.ForeColor = System.Drawing.Color.Green
        Me.txtLine4.Location = New System.Drawing.Point(83, 108)
        Me.txtLine4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtLine4.Name = "txtLine4"
        Me.txtLine4.Size = New System.Drawing.Size(354, 24)
        Me.txtLine4.TabIndex = 74
        Me.txtLine4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLine1
        '
        '
        '
        '
        Me.txtLine1.Border.Class = "TextBoxBorder"
        Me.txtLine1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLine1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine1.ForeColor = System.Drawing.Color.Green
        Me.txtLine1.Location = New System.Drawing.Point(83, 13)
        Me.txtLine1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.Size = New System.Drawing.Size(354, 24)
        Me.txtLine1.TabIndex = 73
        Me.txtLine1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLine2
        '
        '
        '
        '
        Me.txtLine2.Border.Class = "TextBoxBorder"
        Me.txtLine2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLine2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine2.ForeColor = System.Drawing.Color.Green
        Me.txtLine2.Location = New System.Drawing.Point(83, 43)
        Me.txtLine2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.Size = New System.Drawing.Size(354, 24)
        Me.txtLine2.TabIndex = 72
        Me.txtLine2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLine3
        '
        '
        '
        '
        Me.txtLine3.Border.Class = "TextBoxBorder"
        Me.txtLine3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLine3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine3.ForeColor = System.Drawing.Color.Green
        Me.txtLine3.Location = New System.Drawing.Point(83, 74)
        Me.txtLine3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.Size = New System.Drawing.Size(354, 24)
        Me.txtLine3.TabIndex = 71
        Me.txtLine3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.GroupPanel1.Controls.Add(Me.rbSRRollPaper)
        Me.GroupPanel1.Controls.Add(Me.rbSRReceipt)
        Me.GroupPanel1.Controls.Add(Me.rbSRItem)
        Me.GroupPanel1.Controls.Add(Me.rbSRTransaction)
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(565, 188)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(298, 145)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 81
        Me.GroupPanel1.Text = "Default Sales Report"
        '
        'rbSRRollPaper
        '
        Me.rbSRRollPaper.AutoSize = True
        Me.rbSRRollPaper.BackColor = System.Drawing.Color.Transparent
        Me.rbSRRollPaper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSRRollPaper.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbSRRollPaper.Location = New System.Drawing.Point(10, 90)
        Me.rbSRRollPaper.Name = "rbSRRollPaper"
        Me.rbSRRollPaper.Size = New System.Drawing.Size(257, 21)
        Me.rbSRRollPaper.TabIndex = 3
        Me.rbSRRollPaper.Text = "Generate Sales Report in Roll Paper"
        Me.rbSRRollPaper.UseVisualStyleBackColor = False
        '
        'rbSRReceipt
        '
        Me.rbSRReceipt.AutoSize = True
        Me.rbSRReceipt.BackColor = System.Drawing.Color.Transparent
        Me.rbSRReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSRReceipt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbSRReceipt.Location = New System.Drawing.Point(10, 63)
        Me.rbSRReceipt.Name = "rbSRReceipt"
        Me.rbSRReceipt.Size = New System.Drawing.Size(249, 21)
        Me.rbSRReceipt.TabIndex = 2
        Me.rbSRReceipt.Text = "Generate Sales Report per Receipt"
        Me.rbSRReceipt.UseVisualStyleBackColor = False
        '
        'rbSRItem
        '
        Me.rbSRItem.AutoSize = True
        Me.rbSRItem.BackColor = System.Drawing.Color.Transparent
        Me.rbSRItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSRItem.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbSRItem.Location = New System.Drawing.Point(10, 37)
        Me.rbSRItem.Name = "rbSRItem"
        Me.rbSRItem.Size = New System.Drawing.Size(227, 21)
        Me.rbSRItem.TabIndex = 1
        Me.rbSRItem.Text = "Generate Sales Report per Item"
        Me.rbSRItem.UseVisualStyleBackColor = False
        '
        'rbSRTransaction
        '
        Me.rbSRTransaction.AutoSize = True
        Me.rbSRTransaction.BackColor = System.Drawing.Color.Transparent
        Me.rbSRTransaction.Checked = True
        Me.rbSRTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSRTransaction.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbSRTransaction.Location = New System.Drawing.Point(10, 11)
        Me.rbSRTransaction.Name = "rbSRTransaction"
        Me.rbSRTransaction.Size = New System.Drawing.Size(276, 21)
        Me.rbSRTransaction.TabIndex = 0
        Me.rbSRTransaction.TabStop = True
        Me.rbSRTransaction.Text = "Generate Sales Report per Transaction"
        Me.rbSRTransaction.UseVisualStyleBackColor = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.ButtonX1.Location = New System.Drawing.Point(761, 346)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(98, 47)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 80
        Me.ButtonX1.Text = "Close"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonX2.Location = New System.Drawing.Point(657, 346)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(98, 47)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 79
        Me.ButtonX2.Text = "Save"
        '
        'chkPrintReportToPrinter
        '
        Me.chkPrintReportToPrinter.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkPrintReportToPrinter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkPrintReportToPrinter.Checked = True
        Me.chkPrintReportToPrinter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintReportToPrinter.CheckValue = "Y"
        Me.chkPrintReportToPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintReportToPrinter.Location = New System.Drawing.Point(565, 116)
        Me.chkPrintReportToPrinter.Name = "chkPrintReportToPrinter"
        Me.chkPrintReportToPrinter.Size = New System.Drawing.Size(294, 18)
        Me.chkPrintReportToPrinter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkPrintReportToPrinter.TabIndex = 72
        Me.chkPrintReportToPrinter.Text = "Print Reports to Printer"
        '
        'chkExportToPDF
        '
        Me.chkExportToPDF.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkExportToPDF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkExportToPDF.Checked = True
        Me.chkExportToPDF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExportToPDF.CheckValue = "Y"
        Me.chkExportToPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExportToPDF.Location = New System.Drawing.Point(565, 92)
        Me.chkExportToPDF.Name = "chkExportToPDF"
        Me.chkExportToPDF.Size = New System.Drawing.Size(294, 18)
        Me.chkExportToPDF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkExportToPDF.TabIndex = 71
        Me.chkExportToPDF.Text = "Export Reports to PDF"
        '
        'txtPrinterName
        '
        '
        '
        '
        Me.txtPrinterName.Border.Class = "TextBoxBorder"
        Me.txtPrinterName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrinterName.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrinterName.Location = New System.Drawing.Point(161, 22)
        Me.txtPrinterName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtPrinterName.Name = "txtPrinterName"
        Me.txtPrinterName.Size = New System.Drawing.Size(312, 24)
        Me.txtPrinterName.TabIndex = 70
        Me.txtPrinterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrintNoCopy
        '
        '
        '
        '
        Me.txtPrintNoCopy.Border.Class = "TextBoxBorder"
        Me.txtPrintNoCopy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPrintNoCopy.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrintNoCopy.Location = New System.Drawing.Point(161, 86)
        Me.txtPrintNoCopy.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtPrintNoCopy.Name = "txtPrintNoCopy"
        Me.txtPrintNoCopy.Size = New System.Drawing.Size(312, 24)
        Me.txtPrintNoCopy.TabIndex = 69
        Me.txtPrintNoCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(15, 20)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(140, 26)
        Me.LabelX3.TabIndex = 68
        Me.LabelX3.Text = "POS Printer"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(15, 84)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(140, 26)
        Me.LabelX2.TabIndex = 67
        Me.LabelX2.Text = "Print Copy"
        '
        'chkPrintCoupon
        '
        Me.chkPrintCoupon.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkPrintCoupon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkPrintCoupon.Checked = True
        Me.chkPrintCoupon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintCoupon.CheckValue = "Y"
        Me.chkPrintCoupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintCoupon.Location = New System.Drawing.Point(565, 68)
        Me.chkPrintCoupon.Name = "chkPrintCoupon"
        Me.chkPrintCoupon.Size = New System.Drawing.Size(294, 18)
        Me.chkPrintCoupon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkPrintCoupon.TabIndex = 66
        Me.chkPrintCoupon.Text = "Print Coupon as Receipt Replacement"
        '
        'chkPrintPoints
        '
        Me.chkPrintPoints.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkPrintPoints.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkPrintPoints.Checked = True
        Me.chkPrintPoints.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintPoints.CheckValue = "Y"
        Me.chkPrintPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintPoints.Location = New System.Drawing.Point(565, 44)
        Me.chkPrintPoints.Name = "chkPrintPoints"
        Me.chkPrintPoints.Size = New System.Drawing.Size(294, 18)
        Me.chkPrintPoints.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkPrintPoints.TabIndex = 65
        Me.chkPrintPoints.Text = "Include Points to Receipt"
        '
        'chkPrintReceipt
        '
        Me.chkPrintReceipt.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkPrintReceipt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkPrintReceipt.Checked = True
        Me.chkPrintReceipt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintReceipt.CheckValue = "Y"
        Me.chkPrintReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintReceipt.Location = New System.Drawing.Point(565, 20)
        Me.chkPrintReceipt.Name = "chkPrintReceipt"
        Me.chkPrintReceipt.Size = New System.Drawing.Size(294, 18)
        Me.chkPrintReceipt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkPrintReceipt.TabIndex = 64
        Me.chkPrintReceipt.Text = "Always print receipt every transaction"
        '
        'btnBrowseFolder
        '
        Me.btnBrowseFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowseFolder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowseFolder.Image = CType(resources.GetObject("btnBrowseFolder.Image"), System.Drawing.Image)
        Me.btnBrowseFolder.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnBrowseFolder.Location = New System.Drawing.Point(479, 117)
        Me.btnBrowseFolder.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btnBrowseFolder.Name = "btnBrowseFolder"
        Me.btnBrowseFolder.Size = New System.Drawing.Size(54, 24)
        Me.btnBrowseFolder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBrowseFolder.TabIndex = 63
        Me.btnBrowseFolder.Text = "..."
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(15, 115)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(140, 26)
        Me.LabelX1.TabIndex = 62
        Me.LabelX1.Text = "PDF Export Path"
        '
        'txtPDFFilepath
        '
        '
        '
        '
        Me.txtPDFFilepath.Border.Class = "TextBoxBorder"
        Me.txtPDFFilepath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPDFFilepath.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDFFilepath.Location = New System.Drawing.Point(161, 117)
        Me.txtPDFFilepath.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtPDFFilepath.Name = "txtPDFFilepath"
        Me.txtPDFFilepath.Size = New System.Drawing.Size(312, 24)
        Me.txtPDFFilepath.TabIndex = 61
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.SelectedTabFont = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabItem2.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabItem2.Text = "Printing"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.btnDelete)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnCancel)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnSave)
        Me.SuperTabControlPanel1.Controls.Add(Me.lvTerminal)
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelDetails)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnNew)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnEdit)
        Me.SuperTabControlPanel1.Controls.Add(Me.txtPrinter)
        Me.SuperTabControlPanel1.Controls.Add(Me.Label11)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 31)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(875, 405)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnDelete.Location = New System.Drawing.Point(766, 114)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 47)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 79
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnCancel.Location = New System.Drawing.Point(766, 220)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 47)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 78
        Me.btnCancel.Text = "Close"
        Me.btnCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnSave.Location = New System.Drawing.Point(766, 167)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 47)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 77
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnNew
        '
        Me.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnNew.Location = New System.Drawing.Point(766, 8)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(98, 47)
        Me.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNew.TabIndex = 75
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnEdit.Location = New System.Drawing.Point(766, 61)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(98, 47)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 76
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.SelectedTabFont = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabItem1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabItem1.Text = "Terminal"
        '
        'frmTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(875, 436)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTerminal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS Settings"
        Me.PanelDetails.ResumeLayout(False)
        Me.PanelDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPoleDisplay As System.Windows.Forms.TextBox
    Friend WithEvents PanelDetails As System.Windows.Forms.Panel
    Friend WithEvents txtMachineNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTIN As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtBIRPermit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboAuthentication As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTerminal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPrinter As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lvTerminal As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents rbSRReceipt As System.Windows.Forms.RadioButton
    Friend WithEvents rbSRItem As System.Windows.Forms.RadioButton
    Friend WithEvents rbSRTransaction As System.Windows.Forms.RadioButton
    Friend WithEvents rbSRRollPaper As System.Windows.Forms.RadioButton
    Private WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Private WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnNew As DevComponents.DotNetBar.ButtonX
    Private WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents btnBrowseFolder As DevComponents.DotNetBar.ButtonX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtPDFFilepath As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtPrinterName As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtPrintNoCopy As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents chkPrintCoupon As DevComponents.DotNetBar.Controls.CheckBoxX
    Private WithEvents chkPrintPoints As DevComponents.DotNetBar.Controls.CheckBoxX
    Private WithEvents chkPrintReceipt As DevComponents.DotNetBar.Controls.CheckBoxX
    Private WithEvents chkExportToPDF As DevComponents.DotNetBar.Controls.CheckBoxX
    Private WithEvents chkPrintReportToPrinter As DevComponents.DotNetBar.Controls.CheckBoxX
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents txtLine4 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtLine1 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtLine2 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtLine3 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents chkPrintReportEveryEnd As DevComponents.DotNetBar.Controls.CheckBoxX
    Private WithEvents txtPosManagerPrinter As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
End Class
