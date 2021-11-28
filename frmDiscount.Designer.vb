<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiscount))
        Me.btnLineDiscount = New MBGlassStyleButton.MBGlassButton()
        Me.btnSCDiscount = New MBGlassStyleButton.MBGlassButton()
        Me.btnSubTotalDiscount = New MBGlassStyleButton.MBGlassButton()
        Me.btnClose = New MBGlassStyleButton.MBGlassButton()
        Me.pnlSC = New System.Windows.Forms.Panel()
        Me.btnBrowse = New MBGlassStyleButton.MBGlassButton()
        Me.txtSCName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSCID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApply = New MBGlassStyleButton.MBGlassButton()
        Me.pnlSubtotal = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalDiscAmt = New System.Windows.Forms.TextBox()
        Me.cboOtherDisc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboLineDiscAmt = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDiscountType = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboTotalDiscAmt = New System.Windows.Forms.ComboBox()
        Me.pnlApplyVat = New System.Windows.Forms.Panel()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProductName2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLineDiscPercent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLineDisc_Type = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnApplyDiscount = New DevComponents.DotNetBar.ButtonX()
        Me.pnlSC.SuspendLayout()
        Me.pnlSubtotal.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlApplyVat.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLineDiscount
        '
        Me.btnLineDiscount.BackColor = System.Drawing.Color.Transparent
        Me.btnLineDiscount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLineDiscount.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLineDiscount.FlatAppearance.BorderSize = 0
        Me.btnLineDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLineDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLineDiscount.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnLineDiscount.Location = New System.Drawing.Point(6, 19)
        Me.btnLineDiscount.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnLineDiscount.Name = "btnLineDiscount"
        Me.btnLineDiscount.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnLineDiscount.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnLineDiscount.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLineDiscount.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLineDiscount.Size = New System.Drawing.Size(146, 63)
        Me.btnLineDiscount.TabIndex = 0
        Me.btnLineDiscount.Text = "Line Discount"
        Me.btnLineDiscount.UseVisualStyleBackColor = False
        '
        'btnSCDiscount
        '
        Me.btnSCDiscount.BackColor = System.Drawing.Color.Transparent
        Me.btnSCDiscount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSCDiscount.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSCDiscount.FlatAppearance.BorderSize = 0
        Me.btnSCDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSCDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSCDiscount.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnSCDiscount.Location = New System.Drawing.Point(89, 120)
        Me.btnSCDiscount.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnSCDiscount.Name = "btnSCDiscount"
        Me.btnSCDiscount.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnSCDiscount.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnSCDiscount.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSCDiscount.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSCDiscount.Size = New System.Drawing.Size(28, 25)
        Me.btnSCDiscount.TabIndex = 2
        Me.btnSCDiscount.Text = "Senior Citizen Discount"
        Me.btnSCDiscount.UseVisualStyleBackColor = False
        '
        'btnSubTotalDiscount
        '
        Me.btnSubTotalDiscount.BackColor = System.Drawing.Color.Transparent
        Me.btnSubTotalDiscount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubTotalDiscount.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubTotalDiscount.FlatAppearance.BorderSize = 0
        Me.btnSubTotalDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubTotalDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubTotalDiscount.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnSubTotalDiscount.Location = New System.Drawing.Point(6, 92)
        Me.btnSubTotalDiscount.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnSubTotalDiscount.Name = "btnSubTotalDiscount"
        Me.btnSubTotalDiscount.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnSubTotalDiscount.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnSubTotalDiscount.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubTotalDiscount.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubTotalDiscount.Size = New System.Drawing.Size(146, 63)
        Me.btnSubTotalDiscount.TabIndex = 4
        Me.btnSubTotalDiscount.Text = "Sub-Total Discount"
        Me.btnSubTotalDiscount.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnClose.Location = New System.Drawing.Point(520, 209)
        Me.btnClose.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnClose.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnClose.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(99, 63)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlSC
        '
        Me.pnlSC.Controls.Add(Me.btnBrowse)
        Me.pnlSC.Controls.Add(Me.txtSCName)
        Me.pnlSC.Controls.Add(Me.Label2)
        Me.pnlSC.Controls.Add(Me.txtSCID)
        Me.pnlSC.Controls.Add(Me.Label1)
        Me.pnlSC.Location = New System.Drawing.Point(158, 23)
        Me.pnlSC.Name = "pnlSC"
        Me.pnlSC.Size = New System.Drawing.Size(464, 132)
        Me.pnlSC.TabIndex = 6
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnBrowse.Location = New System.Drawing.Point(407, 3)
        Me.btnBrowse.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnBrowse.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnBrowse.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrowse.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrowse.Size = New System.Drawing.Size(57, 29)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtSCName
        '
        Me.txtSCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCName.Location = New System.Drawing.Point(97, 51)
        Me.txtSCName.Name = "txtSCName"
        Me.txtSCName.Size = New System.Drawing.Size(367, 29)
        Me.txtSCName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtSCID
        '
        Me.txtSCID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCID.Location = New System.Drawing.Point(97, 3)
        Me.txtSCID.Name = "txtSCID"
        Me.txtSCID.Size = New System.Drawing.Size(304, 29)
        Me.txtSCID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "S.C.  #"
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Transparent
        Me.btnApply.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnApply.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnApply.FlatAppearance.BorderSize = 0
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Image = CType(resources.GetObject("btnApply.Image"), System.Drawing.Image)
        Me.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApply.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnApply.Location = New System.Drawing.Point(415, 209)
        Me.btnApply.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnApply.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnApply.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApply.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApply.Size = New System.Drawing.Size(99, 63)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply"
        Me.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'pnlSubtotal
        '
        Me.pnlSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.pnlSubtotal.Controls.Add(Me.CheckBox1)
        Me.pnlSubtotal.Controls.Add(Me.Label4)
        Me.pnlSubtotal.Controls.Add(Me.txtTotalDiscAmt)
        Me.pnlSubtotal.Controls.Add(Me.cboOtherDisc)
        Me.pnlSubtotal.Controls.Add(Me.Label6)
        Me.pnlSubtotal.Controls.Add(Me.cboLineDiscAmt)
        Me.pnlSubtotal.ForeColor = System.Drawing.Color.Black
        Me.pnlSubtotal.Location = New System.Drawing.Point(158, 19)
        Me.pnlSubtotal.Name = "pnlSubtotal"
        Me.pnlSubtotal.Size = New System.Drawing.Size(464, 136)
        Me.pnlSubtotal.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(257, 92)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(165, 24)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Apply/Remove VAT"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Amount"
        '
        'txtTotalDiscAmt
        '
        Me.txtTotalDiscAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiscAmt.Location = New System.Drawing.Point(149, 151)
        Me.txtTotalDiscAmt.Name = "txtTotalDiscAmt"
        Me.txtTotalDiscAmt.Size = New System.Drawing.Size(79, 29)
        Me.txtTotalDiscAmt.TabIndex = 5
        '
        'cboOtherDisc
        '
        Me.cboOtherDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOtherDisc.FormattingEnabled = True
        Me.cboOtherDisc.Location = New System.Drawing.Point(149, 27)
        Me.cboOtherDisc.Name = "cboOtherDisc"
        Me.cboOtherDisc.Size = New System.Drawing.Size(309, 32)
        Me.cboOtherDisc.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Other Discount"
        '
        'cboLineDiscAmt
        '
        Me.cboLineDiscAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLineDiscAmt.FormattingEnabled = True
        Me.cboLineDiscAmt.Location = New System.Drawing.Point(149, 90)
        Me.cboLineDiscAmt.Name = "cboLineDiscAmt"
        Me.cboLineDiscAmt.Size = New System.Drawing.Size(260, 32)
        Me.cboLineDiscAmt.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.lblDiscountType)
        Me.Panel3.Location = New System.Drawing.Point(397, 434)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 23)
        Me.Panel3.TabIndex = 9
        '
        'lblDiscountType
        '
        Me.lblDiscountType.AutoSize = True
        Me.lblDiscountType.Font = New System.Drawing.Font("Tw Cen MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountType.ForeColor = System.Drawing.Color.White
        Me.lblDiscountType.Location = New System.Drawing.Point(120, 21)
        Me.lblDiscountType.Name = "lblDiscountType"
        Me.lblDiscountType.Size = New System.Drawing.Size(165, 34)
        Me.lblDiscountType.TabIndex = 8
        Me.lblDiscountType.Text = "Item Discount"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnApply)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnSubTotalDiscount)
        Me.GroupBox1.Controls.Add(Me.btnSCDiscount)
        Me.GroupBox1.Controls.Add(Me.btnLineDiscount)
        Me.GroupBox1.Controls.Add(Me.cboTotalDiscAmt)
        Me.GroupBox1.Controls.Add(Me.pnlSubtotal)
        Me.GroupBox1.Controls.Add(Me.pnlApplyVat)
        Me.GroupBox1.Controls.Add(Me.pnlSC)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(20, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 92)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'cboTotalDiscAmt
        '
        Me.cboTotalDiscAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTotalDiscAmt.FormattingEnabled = True
        Me.cboTotalDiscAmt.Location = New System.Drawing.Point(89, 107)
        Me.cboTotalDiscAmt.Name = "cboTotalDiscAmt"
        Me.cboTotalDiscAmt.Size = New System.Drawing.Size(34, 32)
        Me.cboTotalDiscAmt.TabIndex = 13
        '
        'pnlApplyVat
        '
        Me.pnlApplyVat.Controls.Add(Me.txtVat)
        Me.pnlApplyVat.Controls.Add(Me.Label8)
        Me.pnlApplyVat.Controls.Add(Me.txtProductName2)
        Me.pnlApplyVat.Controls.Add(Me.Label12)
        Me.pnlApplyVat.Location = New System.Drawing.Point(158, 23)
        Me.pnlApplyVat.Name = "pnlApplyVat"
        Me.pnlApplyVat.Size = New System.Drawing.Size(464, 132)
        Me.pnlApplyVat.TabIndex = 12
        '
        'txtVat
        '
        Me.txtVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.Location = New System.Drawing.Point(141, 43)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(317, 29)
        Me.txtVat.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Amount"
        '
        'txtProductName2
        '
        Me.txtProductName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName2.Location = New System.Drawing.Point(141, 3)
        Me.txtProductName2.Name = "txtProductName2"
        Me.txtProductName2.Size = New System.Drawing.Size(317, 29)
        Me.txtProductName2.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(4, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Product Name"
        '
        'txtLineDiscPercent
        '
        Me.txtLineDiscPercent.BackColor = System.Drawing.Color.White
        Me.txtLineDiscPercent.Enabled = False
        Me.txtLineDiscPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLineDiscPercent.ForeColor = System.Drawing.Color.Black
        Me.txtLineDiscPercent.Location = New System.Drawing.Point(153, 103)
        Me.txtLineDiscPercent.Name = "txtLineDiscPercent"
        Me.txtLineDiscPercent.Size = New System.Drawing.Size(317, 29)
        Me.txtLineDiscPercent.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Discount Rate"
        '
        'cboLineDisc_Type
        '
        Me.cboLineDisc_Type.BackColor = System.Drawing.Color.White
        Me.cboLineDisc_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLineDisc_Type.ForeColor = System.Drawing.Color.Black
        Me.cboLineDisc_Type.FormattingEnabled = True
        Me.cboLineDisc_Type.Location = New System.Drawing.Point(153, 57)
        Me.cboLineDisc_Type.Name = "cboLineDisc_Type"
        Me.cboLineDisc_Type.Size = New System.Drawing.Size(317, 32)
        Me.cboLineDisc_Type.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 24)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Discount Type"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.White
        Me.txtProductName.Enabled = False
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(153, 12)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(317, 29)
        Me.txtProductName.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Product Name"
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxX1.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxX1.Location = New System.Drawing.Point(195, 281)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(90, 23)
        Me.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX1.TabIndex = 15
        Me.CheckBoxX1.Text = "Apply VAT"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(380, 174)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 43)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.ThemeAware = True
        '
        'btnApplyDiscount
        '
        Me.btnApplyDiscount.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnApplyDiscount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyDiscount.Location = New System.Drawing.Point(284, 174)
        Me.btnApplyDiscount.Name = "btnApplyDiscount"
        Me.btnApplyDiscount.Size = New System.Drawing.Size(90, 43)
        Me.btnApplyDiscount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnApplyDiscount.TabIndex = 16
        Me.btnApplyDiscount.Text = "Apply"
        Me.btnApplyDiscount.TextColor = System.Drawing.Color.DarkSlateGray
        '
        'frmDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 228)
        Me.Controls.Add(Me.txtLineDiscPercent)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnApplyDiscount)
        Me.Controls.Add(Me.cboLineDisc_Type)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CheckBoxX1)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDiscount"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Discount"
        Me.pnlSC.ResumeLayout(False)
        Me.pnlSC.PerformLayout()
        Me.pnlSubtotal.ResumeLayout(False)
        Me.pnlSubtotal.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlApplyVat.ResumeLayout(False)
        Me.pnlApplyVat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLineDiscount As MBGlassStyleButton.MBGlassButton
    Friend WithEvents btnSCDiscount As MBGlassStyleButton.MBGlassButton
    Friend WithEvents btnSubTotalDiscount As MBGlassStyleButton.MBGlassButton
    Friend WithEvents btnClose As MBGlassStyleButton.MBGlassButton
    Friend WithEvents pnlSC As System.Windows.Forms.Panel
    Friend WithEvents btnBrowse As MBGlassStyleButton.MBGlassButton
    Friend WithEvents txtSCName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSCID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnApply As MBGlassStyleButton.MBGlassButton
    Friend WithEvents pnlSubtotal As System.Windows.Forms.Panel
    Friend WithEvents txtTotalDiscAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblDiscountType As System.Windows.Forms.Label
    Friend WithEvents cboOtherDisc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboLineDisc_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLineDiscPercent As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlApplyVat As System.Windows.Forms.Panel
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProductName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboTotalDiscAmt As System.Windows.Forms.ComboBox
    Friend WithEvents cboLineDiscAmt As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnApplyDiscount As DevComponents.DotNetBar.ButtonX
End Class
