<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeclareSales
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeclareSales))
        Me.lblTenderType = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCashPullout = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCardSales = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtChargeSales = New System.Windows.Forms.TextBox()
        Me.txtCashSales = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.txtCashReceived = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCashFund = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCashOnHand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCount = New System.Windows.Forms.TextBox()
        Me.txt1amt = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt5amt = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt10amt = New System.Windows.Forms.TextBox()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt20amt = New System.Windows.Forms.TextBox()
        Me.txt20 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt50amt = New System.Windows.Forms.TextBox()
        Me.txt50 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt100amt = New System.Windows.Forms.TextBox()
        Me.txt100 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt200amt = New System.Windows.Forms.TextBox()
        Me.txt200 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt500amt = New System.Windows.Forms.TextBox()
        Me.txt500 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt1000amt = New System.Windows.Forms.TextBox()
        Me.txt1000 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEndShift = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTenderType
        '
        Me.lblTenderType.AutoSize = True
        Me.lblTenderType.BackColor = System.Drawing.Color.Transparent
        Me.lblTenderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenderType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblTenderType.Location = New System.Drawing.Point(66, 21)
        Me.lblTenderType.Name = "lblTenderType"
        Me.lblTenderType.Size = New System.Drawing.Size(177, 29)
        Me.lblTenderType.TabIndex = 1
        Me.lblTenderType.Text = "Declare Sales"
        Me.lblTenderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCashPullout)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtCardSales)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.txtChargeSales)
        Me.Panel1.Controls.Add(Me.txtCashSales)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtTotalSales)
        Me.Panel1.Controls.Add(Me.txtCashReceived)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtCashFund)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtCashOnHand)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 456)
        Me.Panel1.TabIndex = 105
        '
        'txtCashPullout
        '
        Me.txtCashPullout.BackColor = System.Drawing.Color.White
        Me.txtCashPullout.Enabled = False
        Me.txtCashPullout.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashPullout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtCashPullout.Location = New System.Drawing.Point(240, 270)
        Me.txtCashPullout.Name = "txtCashPullout"
        Me.txtCashPullout.Size = New System.Drawing.Size(241, 35)
        Me.txtCashPullout.TabIndex = 147
        Me.txtCashPullout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(22, 273)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(138, 25)
        Me.Label21.TabIndex = 146
        Me.Label21.Text = "Cash PullOut"
        '
        'txtCardSales
        '
        Me.txtCardSales.BackColor = System.Drawing.Color.White
        Me.txtCardSales.Enabled = False
        Me.txtCardSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtCardSales.Location = New System.Drawing.Point(240, 146)
        Me.txtCardSales.Name = "txtCardSales"
        Me.txtCardSales.Size = New System.Drawing.Size(241, 35)
        Me.txtCardSales.TabIndex = 143
        Me.txtCardSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(22, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 25)
        Me.Label18.TabIndex = 142
        Me.Label18.Text = "Card Sales"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(22, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 25)
        Me.Label19.TabIndex = 141
        Me.Label19.Text = "Charge Sales"
        '
        'txtChargeSales
        '
        Me.txtChargeSales.BackColor = System.Drawing.Color.White
        Me.txtChargeSales.Enabled = False
        Me.txtChargeSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargeSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtChargeSales.Location = New System.Drawing.Point(240, 105)
        Me.txtChargeSales.Name = "txtChargeSales"
        Me.txtChargeSales.Size = New System.Drawing.Size(241, 35)
        Me.txtChargeSales.TabIndex = 140
        Me.txtChargeSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCashSales
        '
        Me.txtCashSales.BackColor = System.Drawing.Color.White
        Me.txtCashSales.Enabled = False
        Me.txtCashSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtCashSales.Location = New System.Drawing.Point(240, 65)
        Me.txtCashSales.Name = "txtCashSales"
        Me.txtCashSales.Size = New System.Drawing.Size(241, 35)
        Me.txtCashSales.TabIndex = 139
        Me.txtCashSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(22, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 25)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Cash Sales"
        '
        'txtTotalSales
        '
        Me.txtTotalSales.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTotalSales.Enabled = False
        Me.txtTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtTotalSales.Location = New System.Drawing.Point(240, 312)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(241, 35)
        Me.txtTotalSales.TabIndex = 107
        Me.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCashReceived
        '
        Me.txtCashReceived.BackColor = System.Drawing.Color.White
        Me.txtCashReceived.Enabled = False
        Me.txtCashReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashReceived.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtCashReceived.Location = New System.Drawing.Point(240, 229)
        Me.txtCashReceived.Name = "txtCashReceived"
        Me.txtCashReceived.Size = New System.Drawing.Size(241, 35)
        Me.txtCashReceived.TabIndex = 137
        Me.txtCashReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(22, 232)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 25)
        Me.Label16.TabIndex = 136
        Me.Label16.Text = "Cash Deposit"
        '
        'txtCashFund
        '
        Me.txtCashFund.BackColor = System.Drawing.Color.White
        Me.txtCashFund.Enabled = False
        Me.txtCashFund.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashFund.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtCashFund.Location = New System.Drawing.Point(240, 188)
        Me.txtCashFund.Name = "txtCashFund"
        Me.txtCashFund.Size = New System.Drawing.Size(241, 35)
        Me.txtCashFund.TabIndex = 135
        Me.txtCashFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(22, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 25)
        Me.Label15.TabIndex = 134
        Me.Label15.Text = "Cash Fund"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(22, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 25)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "Cash On-hand"
        '
        'txtCashOnHand
        '
        Me.txtCashOnHand.BackColor = System.Drawing.Color.White
        Me.txtCashOnHand.Enabled = False
        Me.txtCashOnHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashOnHand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtCashOnHand.Location = New System.Drawing.Point(240, 24)
        Me.txtCashOnHand.Name = "txtCashOnHand"
        Me.txtCashOnHand.Size = New System.Drawing.Size(241, 35)
        Me.txtCashOnHand.TabIndex = 101
        Me.txtCashOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 29)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Total Sales"
        '
        'txtTotalCount
        '
        Me.txtTotalCount.BackColor = System.Drawing.Color.White
        Me.txtTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCount.Enabled = False
        Me.txtTotalCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txtTotalCount.Location = New System.Drawing.Point(241, 406)
        Me.txtTotalCount.Name = "txtTotalCount"
        Me.txtTotalCount.ReadOnly = True
        Me.txtTotalCount.Size = New System.Drawing.Size(194, 35)
        Me.txtTotalCount.TabIndex = 144
        Me.txtTotalCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt1amt
        '
        Me.txt1amt.BackColor = System.Drawing.Color.White
        Me.txt1amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt1amt.Location = New System.Drawing.Point(241, 365)
        Me.txt1amt.Name = "txt1amt"
        Me.txt1amt.ReadOnly = True
        Me.txt1amt.Size = New System.Drawing.Size(194, 35)
        Me.txt1amt.TabIndex = 131
        Me.txt1amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.White
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt1.Location = New System.Drawing.Point(167, 365)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(68, 35)
        Me.txt1.TabIndex = 8
        Me.txt1.Text = "0"
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(38, 368)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 29)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "1"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt5amt
        '
        Me.txt5amt.BackColor = System.Drawing.Color.White
        Me.txt5amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt5amt.Location = New System.Drawing.Point(241, 324)
        Me.txt5amt.Name = "txt5amt"
        Me.txt5amt.ReadOnly = True
        Me.txt5amt.Size = New System.Drawing.Size(194, 35)
        Me.txt5amt.TabIndex = 128
        Me.txt5amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt5
        '
        Me.txt5.BackColor = System.Drawing.Color.White
        Me.txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt5.Location = New System.Drawing.Point(167, 324)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(68, 35)
        Me.txt5.TabIndex = 7
        Me.txt5.Text = "0"
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(38, 327)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 29)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "5"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt10amt
        '
        Me.txt10amt.BackColor = System.Drawing.Color.White
        Me.txt10amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt10amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt10amt.Location = New System.Drawing.Point(241, 283)
        Me.txt10amt.Name = "txt10amt"
        Me.txt10amt.ReadOnly = True
        Me.txt10amt.Size = New System.Drawing.Size(194, 35)
        Me.txt10amt.TabIndex = 125
        Me.txt10amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt10
        '
        Me.txt10.BackColor = System.Drawing.Color.White
        Me.txt10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt10.Location = New System.Drawing.Point(167, 283)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(68, 35)
        Me.txt10.TabIndex = 6
        Me.txt10.Text = "0"
        Me.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(38, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 29)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "10"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt20amt
        '
        Me.txt20amt.BackColor = System.Drawing.Color.White
        Me.txt20amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt20amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt20amt.Location = New System.Drawing.Point(241, 242)
        Me.txt20amt.Name = "txt20amt"
        Me.txt20amt.ReadOnly = True
        Me.txt20amt.Size = New System.Drawing.Size(194, 35)
        Me.txt20amt.TabIndex = 122
        Me.txt20amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt20
        '
        Me.txt20.BackColor = System.Drawing.Color.White
        Me.txt20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt20.Location = New System.Drawing.Point(167, 242)
        Me.txt20.Name = "txt20"
        Me.txt20.Size = New System.Drawing.Size(68, 35)
        Me.txt20.TabIndex = 5
        Me.txt20.Text = "0"
        Me.txt20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(38, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 29)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "20"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt50amt
        '
        Me.txt50amt.BackColor = System.Drawing.Color.White
        Me.txt50amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt50amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt50amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt50amt.Location = New System.Drawing.Point(241, 201)
        Me.txt50amt.Name = "txt50amt"
        Me.txt50amt.ReadOnly = True
        Me.txt50amt.Size = New System.Drawing.Size(194, 35)
        Me.txt50amt.TabIndex = 119
        Me.txt50amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt50
        '
        Me.txt50.BackColor = System.Drawing.Color.White
        Me.txt50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt50.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt50.Location = New System.Drawing.Point(167, 201)
        Me.txt50.Name = "txt50"
        Me.txt50.Size = New System.Drawing.Size(68, 35)
        Me.txt50.TabIndex = 4
        Me.txt50.Text = "0"
        Me.txt50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(38, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 29)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "50"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt100amt
        '
        Me.txt100amt.BackColor = System.Drawing.Color.White
        Me.txt100amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt100amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt100amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt100amt.Location = New System.Drawing.Point(241, 160)
        Me.txt100amt.Name = "txt100amt"
        Me.txt100amt.ReadOnly = True
        Me.txt100amt.Size = New System.Drawing.Size(194, 35)
        Me.txt100amt.TabIndex = 116
        Me.txt100amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt100
        '
        Me.txt100.BackColor = System.Drawing.Color.White
        Me.txt100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt100.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt100.Location = New System.Drawing.Point(167, 160)
        Me.txt100.Name = "txt100"
        Me.txt100.Size = New System.Drawing.Size(68, 35)
        Me.txt100.TabIndex = 3
        Me.txt100.Text = "0"
        Me.txt100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(38, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 29)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "100"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt200amt
        '
        Me.txt200amt.BackColor = System.Drawing.Color.White
        Me.txt200amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt200amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt200amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt200amt.Location = New System.Drawing.Point(241, 119)
        Me.txt200amt.Name = "txt200amt"
        Me.txt200amt.ReadOnly = True
        Me.txt200amt.Size = New System.Drawing.Size(194, 35)
        Me.txt200amt.TabIndex = 113
        Me.txt200amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt200
        '
        Me.txt200.BackColor = System.Drawing.Color.White
        Me.txt200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt200.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt200.Location = New System.Drawing.Point(167, 119)
        Me.txt200.Name = "txt200"
        Me.txt200.Size = New System.Drawing.Size(68, 35)
        Me.txt200.TabIndex = 2
        Me.txt200.Text = "0"
        Me.txt200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(38, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 29)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "200"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt500amt
        '
        Me.txt500amt.BackColor = System.Drawing.Color.White
        Me.txt500amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt500amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt500amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt500amt.Location = New System.Drawing.Point(241, 78)
        Me.txt500amt.Name = "txt500amt"
        Me.txt500amt.ReadOnly = True
        Me.txt500amt.Size = New System.Drawing.Size(194, 35)
        Me.txt500amt.TabIndex = 110
        Me.txt500amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt500
        '
        Me.txt500.BackColor = System.Drawing.Color.White
        Me.txt500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt500.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt500.Location = New System.Drawing.Point(167, 78)
        Me.txt500.Name = "txt500"
        Me.txt500.Size = New System.Drawing.Size(68, 35)
        Me.txt500.TabIndex = 1
        Me.txt500.Text = "0"
        Me.txt500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(38, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 29)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "500"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(263, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 24)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Total Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(182, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 24)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Pcs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Denominations"
        '
        'txt1000amt
        '
        Me.txt1000amt.BackColor = System.Drawing.Color.White
        Me.txt1000amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1000amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1000amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt1000amt.Location = New System.Drawing.Point(241, 37)
        Me.txt1000amt.Name = "txt1000amt"
        Me.txt1000amt.ReadOnly = True
        Me.txt1000amt.Size = New System.Drawing.Size(194, 35)
        Me.txt1000amt.TabIndex = 104
        Me.txt1000amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt1000
        '
        Me.txt1000.BackColor = System.Drawing.Color.White
        Me.txt1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt1000.Location = New System.Drawing.Point(167, 37)
        Me.txt1000.Name = "txt1000"
        Me.txt1000.Size = New System.Drawing.Size(68, 35)
        Me.txt1000.TabIndex = 0
        Me.txt1000.Text = "0"
        Me.txt1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(38, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 29)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "1000"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(58, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 149)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        '
        'btnEndShift
        '
        Me.btnEndShift.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEndShift.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndShift.Location = New System.Drawing.Point(677, 535)
        Me.btnEndShift.Name = "btnEndShift"
        Me.btnEndShift.Size = New System.Drawing.Size(135, 48)
        Me.btnEndShift.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEndShift.TabIndex = 114
        Me.btnEndShift.Text = "End Session"
        Me.btnEndShift.TextColor = System.Drawing.Color.DarkSlateGray
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(818, 535)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 48)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 115
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.ThemeAware = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt20)
        Me.Panel2.Controls.Add(Me.txt20amt)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtTotalCount)
        Me.Panel2.Controls.Add(Me.txt10)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt1000)
        Me.Panel2.Controls.Add(Me.txt10amt)
        Me.Panel2.Controls.Add(Me.txt1000amt)
        Me.Panel2.Controls.Add(Me.txt50amt)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt50)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txt500)
        Me.Panel2.Controls.Add(Me.txt100amt)
        Me.Panel2.Controls.Add(Me.txt500amt)
        Me.Panel2.Controls.Add(Me.txt5amt)
        Me.Panel2.Controls.Add(Me.txt1amt)
        Me.Panel2.Controls.Add(Me.txt100)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt200)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt1)
        Me.Panel2.Controls.Add(Me.txt200amt)
        Me.Panel2.Location = New System.Drawing.Point(501, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 456)
        Me.Panel2.TabIndex = 146
        '
        'frmDeclareSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(961, 587)
        Me.Controls.Add(Me.btnEndShift)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTenderType)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeclareSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "End of Shift"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTenderType As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCashReceived As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt1amt As System.Windows.Forms.TextBox
    Friend WithEvents txtCashFund As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt5amt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt10amt As System.Windows.Forms.TextBox
    Friend WithEvents txt10 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt20amt As System.Windows.Forms.TextBox
    Friend WithEvents txt20 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt50amt As System.Windows.Forms.TextBox
    Friend WithEvents txt50 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt100amt As System.Windows.Forms.TextBox
    Friend WithEvents txt100 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt200amt As System.Windows.Forms.TextBox
    Friend WithEvents txt200 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt500amt As System.Windows.Forms.TextBox
    Friend WithEvents txt500 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt1000amt As System.Windows.Forms.TextBox
    Friend WithEvents txt1000 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCashOnHand As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalSales As System.Windows.Forms.TextBox
    Friend WithEvents txtCashSales As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCardSales As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtChargeSales As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCount As System.Windows.Forms.TextBox
    Friend WithEvents txtCashPullout As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Private WithEvents btnEndShift As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
End Class
