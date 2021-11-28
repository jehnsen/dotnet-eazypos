<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTender_Split
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTender_Split))
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.lblTenderType = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtTotalPayment = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAccept = New MBGlassStyleButton.MBGlassButton()
        Me.txtCashAmnt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboChargeType = New System.Windows.Forms.ComboBox()
        Me.txtChargeAmt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboCardType = New System.Windows.Forms.ComboBox()
        Me.txtApprovalNo = New System.Windows.Forms.TextBox()
        Me.txtExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtCardHolder = New System.Windows.Forms.TextBox()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.txtCardAmt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnBrowse = New MBGlassStyleButton.MBGlassButton()
        Me.txtORNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.View_SalesReportTableAdapter1 = New Shockwave_POS.dsPOSTableAdapters.view_SalesReportTableAdapter()
        Me.MbGlassButton1 = New MBGlassStyleButton.MBGlassButton()
        Me.pnlheader.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlheader
        '
        Me.pnlheader.BackgroundImage = CType(resources.GetObject("pnlheader.BackgroundImage"), System.Drawing.Image)
        Me.pnlheader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlheader.Controls.Add(Me.lblTenderType)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(901, 57)
        Me.pnlheader.TabIndex = 17
        '
        'lblTenderType
        '
        Me.lblTenderType.BackColor = System.Drawing.Color.Transparent
        Me.lblTenderType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTenderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenderType.ForeColor = System.Drawing.Color.White
        Me.lblTenderType.Location = New System.Drawing.Point(0, 0)
        Me.lblTenderType.Name = "lblTenderType"
        Me.lblTenderType.Size = New System.Drawing.Size(901, 57)
        Me.lblTenderType.TabIndex = 1
        Me.lblTenderType.Text = "Split Payment"
        Me.lblTenderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Black
        Me.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Lime
        Me.lblAmount.Location = New System.Drawing.Point(607, 118)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(278, 69)
        Me.lblAmount.TabIndex = 68
        Me.lblAmount.Text = "000.00"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAmount.UseMnemonic = False
        '
        'txtTotalPayment
        '
        Me.txtTotalPayment.BackColor = System.Drawing.Color.Black
        Me.txtTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotalPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPayment.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalPayment.Location = New System.Drawing.Point(607, 257)
        Me.txtTotalPayment.Name = "txtTotalPayment"
        Me.txtTotalPayment.Size = New System.Drawing.Size(278, 70)
        Me.txtTotalPayment.TabIndex = 67
        Me.txtTotalPayment.Text = "000.00"
        Me.txtTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtTotalPayment.UseMnemonic = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(600, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 37)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Total Payment : "
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.Lime
        Me.txtAmount.Location = New System.Drawing.Point(627, 118)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(198, 55)
        Me.txtAmount.TabIndex = 65
        Me.txtAmount.Text = "000.00"
        Me.txtAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(602, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 37)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Amount Due : "
        '
        'btnAccept
        '
        Me.btnAccept.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAccept.BaseStrokeColor = System.Drawing.Color.DarkGreen
        Me.btnAccept.FlatAppearance.BorderSize = 0
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.btnAccept.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnAccept.Location = New System.Drawing.Point(562, 381)
        Me.btnAccept.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.OnColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAccept.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAccept.PressColor = System.Drawing.Color.Green
        Me.btnAccept.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAccept.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.btnAccept.Size = New System.Drawing.Size(158, 62)
        Me.btnAccept.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.btnAccept.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.btnAccept.TabIndex = 63
        Me.btnAccept.Text = "Accept Payment"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'txtCashAmnt
        '
        Me.txtCashAmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashAmnt.Location = New System.Drawing.Point(194, 36)
        Me.txtCashAmnt.Name = "txtCashAmnt"
        Me.txtCashAmnt.Size = New System.Drawing.Size(291, 31)
        Me.txtCashAmnt.TabIndex = 69
        Me.txtCashAmnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Cash Amount"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCashAmnt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 87)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cash"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboChargeType)
        Me.GroupBox2.Controls.Add(Me.txtChargeAmt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 89)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charge"
        '
        'cboChargeType
        '
        Me.cboChargeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChargeType.FormattingEnabled = True
        Me.cboChargeType.Location = New System.Drawing.Point(194, 150)
        Me.cboChargeType.Name = "cboChargeType"
        Me.cboChargeType.Size = New System.Drawing.Size(291, 33)
        Me.cboChargeType.TabIndex = 92
        '
        'txtChargeAmt
        '
        Me.txtChargeAmt.BackColor = System.Drawing.Color.White
        Me.txtChargeAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargeAmt.Location = New System.Drawing.Point(194, 37)
        Me.txtChargeAmt.Name = "txtChargeAmt"
        Me.txtChargeAmt.Size = New System.Drawing.Size(291, 31)
        Me.txtChargeAmt.TabIndex = 91
        Me.txtChargeAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Charge Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 25)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Charge Amount"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.White
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(158, 122)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(303, 31)
        Me.txtCustomerName.TabIndex = 94
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 25)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Customer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboCardType)
        Me.GroupBox3.Controls.Add(Me.txtApprovalNo)
        Me.GroupBox3.Controls.Add(Me.txtExpiryDate)
        Me.GroupBox3.Controls.Add(Me.txtCardHolder)
        Me.GroupBox3.Controls.Add(Me.txtCardNo)
        Me.GroupBox3.Controls.Add(Me.txtCardAmt)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(910, 553)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(83, 82)
        Me.GroupBox3.TabIndex = 93
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Card"
        '
        'cboCardType
        '
        Me.cboCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCardType.FormattingEnabled = True
        Me.cboCardType.Location = New System.Drawing.Point(178, 67)
        Me.cboCardType.Name = "cboCardType"
        Me.cboCardType.Size = New System.Drawing.Size(303, 33)
        Me.cboCardType.TabIndex = 99
        '
        'txtApprovalNo
        '
        Me.txtApprovalNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovalNo.Location = New System.Drawing.Point(178, 217)
        Me.txtApprovalNo.Name = "txtApprovalNo"
        Me.txtApprovalNo.Size = New System.Drawing.Size(303, 31)
        Me.txtApprovalNo.TabIndex = 95
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiryDate.Location = New System.Drawing.Point(178, 180)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(303, 31)
        Me.txtExpiryDate.TabIndex = 94
        '
        'txtCardHolder
        '
        Me.txtCardHolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardHolder.Location = New System.Drawing.Point(178, 143)
        Me.txtCardHolder.Name = "txtCardHolder"
        Me.txtCardHolder.Size = New System.Drawing.Size(303, 31)
        Me.txtCardHolder.TabIndex = 93
        '
        'txtCardNo
        '
        Me.txtCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo.Location = New System.Drawing.Point(178, 106)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.Size = New System.Drawing.Size(303, 31)
        Me.txtCardNo.TabIndex = 92
        '
        'txtCardAmt
        '
        Me.txtCardAmt.BackColor = System.Drawing.Color.White
        Me.txtCardAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardAmt.Location = New System.Drawing.Point(178, 30)
        Me.txtCardAmt.Name = "txtCardAmt"
        Me.txtCardAmt.Size = New System.Drawing.Size(303, 31)
        Me.txtCardAmt.TabIndex = 91
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 25)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Approval No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 25)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Expiry Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 25)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Card Holder"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(24, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 25)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Card No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(24, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 25)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Card Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(24, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 25)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Card Amount"
        '
        'btnBrowse
        '
        Me.btnBrowse.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBrowse.BaseStrokeColor = System.Drawing.Color.Purple
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.btnBrowse.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnBrowse.Location = New System.Drawing.Point(467, 122)
        Me.btnBrowse.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.btnBrowse.Size = New System.Drawing.Size(54, 31)
        Me.btnBrowse.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.btnBrowse.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.btnBrowse.TabIndex = 100
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtORNo
        '
        Me.txtORNo.BackColor = System.Drawing.Color.White
        Me.txtORNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNo.Location = New System.Drawing.Point(158, 80)
        Me.txtORNo.Name = "txtORNo"
        Me.txtORNo.Size = New System.Drawing.Size(303, 31)
        Me.txtORNo.TabIndex = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 25)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "OR NUMBER"
        '
        'View_SalesReportTableAdapter1
        '
        Me.View_SalesReportTableAdapter1.ClearBeforeFill = True
        '
        'MbGlassButton1
        '
        Me.MbGlassButton1.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.MbGlassButton1.BackColor = System.Drawing.Color.Transparent
        Me.MbGlassButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.FlatAppearance.BorderSize = 0
        Me.MbGlassButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MbGlassButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MbGlassButton1.ForeColor = System.Drawing.Color.White
        Me.MbGlassButton1.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.MbGlassButton1.ImageSize = New System.Drawing.Size(24, 24)
        Me.MbGlassButton1.Location = New System.Drawing.Point(727, 381)
        Me.MbGlassButton1.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.MbGlassButton1.Name = "MbGlassButton1"
        Me.MbGlassButton1.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.MbGlassButton1.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.MbGlassButton1.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.MbGlassButton1.Size = New System.Drawing.Size(158, 62)
        Me.MbGlassButton1.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.MbGlassButton1.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.MbGlassButton1.TabIndex = 103
        Me.MbGlassButton1.Text = "Cancel"
        Me.MbGlassButton1.UseVisualStyleBackColor = False
        '
        'frmTender_Split
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(901, 461)
        Me.Controls.Add(Me.MbGlassButton1)
        Me.Controls.Add(Me.txtORNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtTotalPayment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTender_Split"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "/,l.*"
        Me.pnlheader.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents lblTenderType As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtTotalPayment As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAccept As MBGlassStyleButton.MBGlassButton
    Friend WithEvents txtCashAmnt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboChargeType As System.Windows.Forms.ComboBox
    Friend WithEvents txtChargeAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCardType As System.Windows.Forms.ComboBox
    Friend WithEvents txtApprovalNo As System.Windows.Forms.TextBox
    Friend WithEvents txtExpiryDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCardHolder As System.Windows.Forms.TextBox
    Friend WithEvents txtCardNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCardAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As MBGlassStyleButton.MBGlassButton
    Friend WithEvents txtORNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents View_SalesReportTableAdapter1 As Shockwave_POS.dsPOSTableAdapters.view_SalesReportTableAdapter
    Friend WithEvents MbGlassButton1 As MBGlassStyleButton.MBGlassButton
End Class
