<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblEnterPIN = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPin9 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin6 = New DevComponents.DotNetBar.ButtonX()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin0 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin7 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin8 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin4 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin5 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin3 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin2 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPin1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnDone = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.LabelP = New System.Windows.Forms.Label()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.LabelUN = New System.Windows.Forms.Label()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterPIN
        '
        Me.lblEnterPIN.AutoSize = True
        Me.lblEnterPIN.BackColor = System.Drawing.Color.Transparent
        Me.lblEnterPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterPIN.ForeColor = System.Drawing.Color.Black
        Me.lblEnterPIN.Location = New System.Drawing.Point(124, 14)
        Me.lblEnterPIN.Name = "lblEnterPIN"
        Me.lblEnterPIN.Size = New System.Drawing.Size(63, 31)
        Me.lblEnterPIN.TabIndex = 1
        Me.lblEnterPIN.Text = "PIN"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Wingdings", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(147, 186)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtPassword.Size = New System.Drawing.Size(270, 28)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnPin9)
        Me.GroupBox1.Controls.Add(Me.btnPin6)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnPin0)
        Me.GroupBox1.Controls.Add(Me.btnPin7)
        Me.GroupBox1.Controls.Add(Me.btnPin8)
        Me.GroupBox1.Controls.Add(Me.btnPin4)
        Me.GroupBox1.Controls.Add(Me.btnPin5)
        Me.GroupBox1.Controls.Add(Me.btnPin3)
        Me.GroupBox1.Controls.Add(Me.btnPin2)
        Me.GroupBox1.Controls.Add(Me.btnPin1)
        Me.GroupBox1.Controls.Add(Me.lblEnterPIN)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(696, 370)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(95, 57)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'btnPin9
        '
        Me.btnPin9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin9.Location = New System.Drawing.Point(208, 253)
        Me.btnPin9.Name = "btnPin9"
        Me.btnPin9.Size = New System.Drawing.Size(90, 68)
        Me.btnPin9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin9.TabIndex = 94
        Me.btnPin9.Text = "9"
        '
        'btnPin6
        '
        Me.btnPin6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin6.Location = New System.Drawing.Point(208, 179)
        Me.btnPin6.Name = "btnPin6"
        Me.btnPin6.Size = New System.Drawing.Size(90, 68)
        Me.btnPin6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin6.TabIndex = 91
        Me.btnPin6.Text = "6"
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(16, 327)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 68)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 99
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColor = System.Drawing.Color.Red
        '
        'btnPin0
        '
        Me.btnPin0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin0.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin0.Location = New System.Drawing.Point(112, 327)
        Me.btnPin0.Name = "btnPin0"
        Me.btnPin0.Size = New System.Drawing.Size(90, 68)
        Me.btnPin0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin0.TabIndex = 98
        Me.btnPin0.Text = "0"
        '
        'btnPin7
        '
        Me.btnPin7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin7.Location = New System.Drawing.Point(16, 253)
        Me.btnPin7.Name = "btnPin7"
        Me.btnPin7.Size = New System.Drawing.Size(90, 68)
        Me.btnPin7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin7.TabIndex = 96
        Me.btnPin7.Text = "7"
        '
        'btnPin8
        '
        Me.btnPin8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin8.Location = New System.Drawing.Point(112, 253)
        Me.btnPin8.Name = "btnPin8"
        Me.btnPin8.Size = New System.Drawing.Size(90, 68)
        Me.btnPin8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin8.TabIndex = 95
        Me.btnPin8.Text = "8"
        '
        'btnPin4
        '
        Me.btnPin4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin4.Location = New System.Drawing.Point(16, 179)
        Me.btnPin4.Name = "btnPin4"
        Me.btnPin4.Size = New System.Drawing.Size(90, 68)
        Me.btnPin4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin4.TabIndex = 93
        Me.btnPin4.Text = "4"
        '
        'btnPin5
        '
        Me.btnPin5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin5.Location = New System.Drawing.Point(112, 179)
        Me.btnPin5.Name = "btnPin5"
        Me.btnPin5.Size = New System.Drawing.Size(90, 68)
        Me.btnPin5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin5.TabIndex = 92
        Me.btnPin5.Text = "5"
        '
        'btnPin3
        '
        Me.btnPin3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin3.Location = New System.Drawing.Point(208, 105)
        Me.btnPin3.Name = "btnPin3"
        Me.btnPin3.Size = New System.Drawing.Size(90, 68)
        Me.btnPin3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin3.TabIndex = 90
        Me.btnPin3.Text = "3"
        '
        'btnPin2
        '
        Me.btnPin2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin2.Location = New System.Drawing.Point(112, 105)
        Me.btnPin2.Name = "btnPin2"
        Me.btnPin2.Size = New System.Drawing.Size(90, 68)
        Me.btnPin2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin2.TabIndex = 89
        Me.btnPin2.Text = "2"
        '
        'btnPin1
        '
        Me.btnPin1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPin1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPin1.Location = New System.Drawing.Point(16, 105)
        Me.btnPin1.Name = "btnPin1"
        Me.btnPin1.Size = New System.Drawing.Size(90, 68)
        Me.btnPin1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPin1.TabIndex = 88
        Me.btnPin1.Text = "1"
        '
        'btnDone
        '
        Me.btnDone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDone.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Image = CType(resources.GetObject("btnDone.Image"), System.Drawing.Image)
        Me.btnDone.ImageFixedSize = New System.Drawing.Size(26, 26)
        Me.btnDone.ImageTextSpacing = 3
        Me.btnDone.Location = New System.Drawing.Point(300, 243)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(117, 46)
        Me.btnDone.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Login"
        Me.btnDone.TextColor = System.Drawing.Color.White
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(147, 120)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(270, 30)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelP
        '
        Me.LabelP.AutoSize = True
        Me.LabelP.BackColor = System.Drawing.Color.Transparent
        Me.LabelP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelP.ForeColor = System.Drawing.Color.Black
        Me.LabelP.Location = New System.Drawing.Point(147, 163)
        Me.LabelP.Name = "LabelP"
        Me.LabelP.Size = New System.Drawing.Size(87, 20)
        Me.LabelP.TabIndex = 102
        Me.LabelP.Text = "PASSWORD"
        Me.LabelP.UseCompatibleTextRendering = True
        '
        'ReflectionImage1
        '
        Me.ReflectionImage1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionImage1.Image = CType(resources.GetObject("ReflectionImage1.Image"), System.Drawing.Image)
        Me.ReflectionImage1.Location = New System.Drawing.Point(3, 35)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(126, 169)
        Me.ReflectionImage1.TabIndex = 4
        '
        'LabelUN
        '
        Me.LabelUN.AutoSize = True
        Me.LabelUN.BackColor = System.Drawing.Color.Transparent
        Me.LabelUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUN.ForeColor = System.Drawing.Color.Black
        Me.LabelUN.Location = New System.Drawing.Point(149, 97)
        Me.LabelUN.Name = "LabelUN"
        Me.LabelUN.Size = New System.Drawing.Size(85, 20)
        Me.LabelUN.TabIndex = 101
        Me.LabelUN.Text = "USERNAME"
        Me.LabelUN.UseCompatibleTextRendering = True
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Broadway", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionLabel1.Location = New System.Drawing.Point(147, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(270, 52)
        Me.ReflectionLabel1.TabIndex = 103
        Me.ReflectionLabel1.Text = "<font color=""#50CB93"">Eazy</font><font color=""#54436B"">POS</font>"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(147, 58)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(71, 23)
        Me.LabelX1.TabIndex = 104
        Me.LabelX1.Text = "version 3.9.0"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(428, 299)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ReflectionImage1)
        Me.Controls.Add(Me.LabelUN)
        Me.Controls.Add(Me.LabelP)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterPIN As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnDone As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin9 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin0 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin8 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPin1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents LabelP As System.Windows.Forms.Label
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents LabelUN As System.Windows.Forms.Label
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
