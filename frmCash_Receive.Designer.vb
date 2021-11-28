<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCash_Receive
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
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCashAmt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDone = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btn0 = New DevComponents.DotNetBar.ButtonX()
        Me.btn3 = New DevComponents.DotNetBar.ButtonX()
        Me.btn6 = New DevComponents.DotNetBar.ButtonX()
        Me.btnDot = New DevComponents.DotNetBar.ButtonX()
        Me.btn2 = New DevComponents.DotNetBar.ButtonX()
        Me.btn5 = New DevComponents.DotNetBar.ButtonX()
        Me.btn7 = New DevComponents.DotNetBar.ButtonX()
        Me.btn1 = New DevComponents.DotNetBar.ButtonX()
        Me.btn4 = New DevComponents.DotNetBar.ButtonX()
        Me.btn8 = New DevComponents.DotNetBar.ButtonX()
        Me.btn9 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtRemarks.Location = New System.Drawing.Point(17, 370)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(236, 66)
        Me.txtRemarks.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(12, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Remarks"
        '
        'txtCashAmt
        '
        Me.txtCashAmt.BackColor = System.Drawing.Color.White
        Me.txtCashAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashAmt.Location = New System.Drawing.Point(17, 41)
        Me.txtCashAmt.Name = "txtCashAmt"
        Me.txtCashAmt.Size = New System.Drawing.Size(236, 35)
        Me.txtCashAmt.TabIndex = 92
        Me.txtCashAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Cash Amount"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(52, 456)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(90, 22)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        '
        'btnDone
        '
        Me.btnDone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(271, 41)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(98, 48)
        Me.btnDone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDone.TabIndex = 110
        Me.btnDone.Text = "Done"
        Me.btnDone.TextColor = System.Drawing.Color.DarkSlateGray
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(271, 95)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(98, 48)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 111
        Me.ButtonX1.Text = "Cancel"
        Me.ButtonX1.TextColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ButtonX1.ThemeAware = True
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(17, 269)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 57)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 129
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btnClear.ThemeAware = True
        '
        'btn0
        '
        Me.btn0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn0.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn0.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(97, 269)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(76, 57)
        Me.btn0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn0.TabIndex = 128
        Me.btn0.Text = "0"
        Me.btn0.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn0.ThemeAware = True
        '
        'btn3
        '
        Me.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(177, 86)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(76, 57)
        Me.btn3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn3.TabIndex = 120
        Me.btn3.Text = "3"
        Me.btn3.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn3.ThemeAware = True
        '
        'btn6
        '
        Me.btn6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(177, 147)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(76, 57)
        Me.btn6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn6.TabIndex = 121
        Me.btn6.Text = "6"
        Me.btn6.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn6.ThemeAware = True
        '
        'btnDot
        '
        Me.btnDot.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDot.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot.Location = New System.Drawing.Point(177, 269)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(76, 57)
        Me.btnDot.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDot.TabIndex = 127
        Me.btnDot.Text = "."
        Me.btnDot.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btnDot.ThemeAware = True
        '
        'btn2
        '
        Me.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(97, 86)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(76, 57)
        Me.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn2.TabIndex = 119
        Me.btn2.Text = "2"
        Me.btn2.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn2.ThemeAware = True
        '
        'btn5
        '
        Me.btn5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(97, 147)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(76, 57)
        Me.btn5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn5.TabIndex = 122
        Me.btn5.Text = "5"
        Me.btn5.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn5.ThemeAware = True
        '
        'btn7
        '
        Me.btn7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(17, 208)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(76, 57)
        Me.btn7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn7.TabIndex = 126
        Me.btn7.Text = "7"
        Me.btn7.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn7.ThemeAware = True
        '
        'btn1
        '
        Me.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(17, 86)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(76, 57)
        Me.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn1.TabIndex = 118
        Me.btn1.Text = "1"
        Me.btn1.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn1.ThemeAware = True
        '
        'btn4
        '
        Me.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(17, 147)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(76, 57)
        Me.btn4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn4.TabIndex = 123
        Me.btn4.Text = "4"
        Me.btn4.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn4.ThemeAware = True
        '
        'btn8
        '
        Me.btn8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(97, 208)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(76, 57)
        Me.btn8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn8.TabIndex = 125
        Me.btn8.Text = "8"
        Me.btn8.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn8.ThemeAware = True
        '
        'btn9
        '
        Me.btn9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(177, 208)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(76, 57)
        Me.btn9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn9.TabIndex = 124
        Me.btn9.Text = "9"
        Me.btn9.TextColor = System.Drawing.Color.DarkSlateGray
        Me.btn9.ThemeAware = True
        '
        'frmCash_Receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 446)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtCashAmt)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCash_Receive"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposit / Receive Cash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCashAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnDone As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn0 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDot As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn8 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn9 As DevComponents.DotNetBar.ButtonX
End Class
