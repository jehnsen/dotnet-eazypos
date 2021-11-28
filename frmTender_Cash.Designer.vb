<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTender_Cash
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
        Me.txtTender = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.btn1 = New DevComponents.DotNetBar.ButtonX()
        Me.btn2 = New DevComponents.DotNetBar.ButtonX()
        Me.btn3 = New DevComponents.DotNetBar.ButtonX()
        Me.btn4 = New DevComponents.DotNetBar.ButtonX()
        Me.btn5 = New DevComponents.DotNetBar.ButtonX()
        Me.btn6 = New DevComponents.DotNetBar.ButtonX()
        Me.btn7 = New DevComponents.DotNetBar.ButtonX()
        Me.btn8 = New DevComponents.DotNetBar.ButtonX()
        Me.btn9 = New DevComponents.DotNetBar.ButtonX()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btn0 = New DevComponents.DotNetBar.ButtonX()
        Me.btnExact = New DevComponents.DotNetBar.ButtonX()
        Me.btn1000 = New DevComponents.DotNetBar.ButtonX()
        Me.btn500 = New DevComponents.DotNetBar.ButtonX()
        Me.btn200 = New DevComponents.DotNetBar.ButtonX()
        Me.btn100 = New DevComponents.DotNetBar.ButtonX()
        Me.btnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtORNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTender
        '
        Me.txtTender.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTender.ForeColor = System.Drawing.Color.Black
        Me.txtTender.Location = New System.Drawing.Point(9, 47)
        Me.txtTender.Name = "txtTender"
        Me.txtTender.Size = New System.Drawing.Size(392, 47)
        Me.txtTender.TabIndex = 0
        Me.txtTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Black
        Me.txtChange.Location = New System.Drawing.Point(420, 179)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(278, 73)
        Me.txtChange.TabIndex = 61
        Me.txtChange.Text = "000.00"
        Me.txtChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(419, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 26)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Change : "
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(420, 47)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(278, 73)
        Me.txtAmount.TabIndex = 59
        Me.txtAmount.Text = "000.00"
        Me.txtAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(418, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 26)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Total amount due : "
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Black
        Me.lblAmount.Location = New System.Drawing.Point(420, 47)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(278, 73)
        Me.lblAmount.TabIndex = 62
        Me.lblAmount.Text = "000.00"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn1
        '
        Me.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(119, 110)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(90, 68)
        Me.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn1.ThemeAware = True
        '
        'btn2
        '
        Me.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(215, 110)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(90, 68)
        Me.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn2.ThemeAware = True
        '
        'btn3
        '
        Me.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(311, 110)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(90, 68)
        Me.btn3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn3.ThemeAware = True
        '
        'btn4
        '
        Me.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(119, 184)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(90, 68)
        Me.btn4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn4.ThemeAware = True
        '
        'btn5
        '
        Me.btn5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(215, 184)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(90, 68)
        Me.btn5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn5.ThemeAware = True
        '
        'btn6
        '
        Me.btn6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(311, 184)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(90, 68)
        Me.btn6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn6.ThemeAware = True
        '
        'btn7
        '
        Me.btn7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(119, 258)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(90, 68)
        Me.btn7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "7"
        Me.btn7.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn7.ThemeAware = True
        '
        'btn8
        '
        Me.btn8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(215, 258)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(90, 68)
        Me.btn8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn8.ThemeAware = True
        '
        'btn9
        '
        Me.btn9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(311, 258)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(90, 68)
        Me.btn9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn9.ThemeAware = True
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(119, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 68)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btnClear.ThemeAware = True
        '
        'btn0
        '
        Me.btn0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn0.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn0.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(215, 332)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(90, 68)
        Me.btn0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn0.TabIndex = 10
        Me.btn0.Text = "0"
        Me.btn0.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn0.ThemeAware = True
        '
        'btnExact
        '
        Me.btnExact.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExact.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExact.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExact.Location = New System.Drawing.Point(311, 332)
        Me.btnExact.Name = "btnExact"
        Me.btnExact.Size = New System.Drawing.Size(90, 68)
        Me.btnExact.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExact.TabIndex = 12
        Me.btnExact.Text = "Exact Amount"
        Me.btnExact.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btnExact.ThemeAware = True
        '
        'btn1000
        '
        Me.btn1000.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1000.Location = New System.Drawing.Point(10, 110)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(92, 67)
        Me.btn1000.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn1000.TabIndex = 13
        Me.btn1000.Text = "1000"
        Me.btn1000.TextColor = System.Drawing.Color.MidnightBlue
        '
        'btn500
        '
        Me.btn500.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn500.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn500.Location = New System.Drawing.Point(10, 185)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(92, 67)
        Me.btn500.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn500.TabIndex = 14
        Me.btn500.Text = "500"
        Me.btn500.TextColor = System.Drawing.Color.MidnightBlue
        '
        'btn200
        '
        Me.btn200.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn200.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn200.Location = New System.Drawing.Point(10, 258)
        Me.btn200.Name = "btn200"
        Me.btn200.Size = New System.Drawing.Size(92, 67)
        Me.btn200.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn200.TabIndex = 15
        Me.btn200.Text = "200"
        Me.btn200.TextColor = System.Drawing.Color.MidnightBlue
        '
        'btn100
        '
        Me.btn100.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn100.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.Location = New System.Drawing.Point(10, 332)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(92, 67)
        Me.btn100.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn100.TabIndex = 16
        Me.btn100.Text = "100"
        Me.btn100.TextColor = System.Drawing.Color.MidnightBlue
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.Location = New System.Drawing.Point(420, 340)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(134, 59)
        Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAccept.TabIndex = 17
        Me.btnAccept.Text = "<b>Tender </b> (Enter)"
        Me.btnAccept.TextColor = System.Drawing.Color.DarkSlateGray
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.White
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(564, 340)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(134, 59)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 18
        Me.ButtonX1.Text = "Cancel (Esc)"
        Me.ButtonX1.TextColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ButtonX1.ThemeAware = True
        '
        'txtORNo
        '
        Me.txtORNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtORNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNo.ForeColor = System.Drawing.Color.Black
        Me.txtORNo.Location = New System.Drawing.Point(69, 120)
        Me.txtORNo.Name = "txtORNo"
        Me.txtORNo.Size = New System.Drawing.Size(30, 47)
        Me.txtORNo.TabIndex = 20
        Me.txtORNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 37)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "OR #:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 26)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Enter payment amount"
        '
        'frmTender_Cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 414)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn200)
        Me.Controls.Add(Me.btn500)
        Me.Controls.Add(Me.btn1000)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnExact)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtTender)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtORNo)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTender_Cash"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTender As System.Windows.Forms.TextBox
    Friend WithEvents txtChange As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Private WithEvents btn1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn3 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn4 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn5 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn6 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn7 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn8 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn9 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn0 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnExact As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn1000 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn500 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn200 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btn100 As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtORNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
