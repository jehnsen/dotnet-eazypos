<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartofDay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartofDay))
        Me.lblTenderType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCashFund = New System.Windows.Forms.TextBox()
        Me.cboBranch = New System.Windows.Forms.ComboBox()
        Me.cboTerminal = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn00 = New DevComponents.DotNetBar.ButtonX()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btn0 = New DevComponents.DotNetBar.ButtonX()
        Me.btn7 = New DevComponents.DotNetBar.ButtonX()
        Me.btn8 = New DevComponents.DotNetBar.ButtonX()
        Me.btn9 = New DevComponents.DotNetBar.ButtonX()
        Me.btn4 = New DevComponents.DotNetBar.ButtonX()
        Me.btn5 = New DevComponents.DotNetBar.ButtonX()
        Me.btn6 = New DevComponents.DotNetBar.ButtonX()
        Me.btn3 = New DevComponents.DotNetBar.ButtonX()
        Me.btn2 = New DevComponents.DotNetBar.ButtonX()
        Me.btn1 = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStartShift = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTenderType
        '
        Me.lblTenderType.AutoSize = True
        Me.lblTenderType.BackColor = System.Drawing.Color.Transparent
        Me.lblTenderType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenderType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblTenderType.Location = New System.Drawing.Point(74, 27)
        Me.lblTenderType.Name = "lblTenderType"
        Me.lblTenderType.Size = New System.Drawing.Size(224, 28)
        Me.lblTenderType.TabIndex = 2
        Me.lblTenderType.Text = "Start New Session"
        Me.lblTenderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Branch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 31)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Terminal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Enter cash fund amount"
        '
        'txtCashFund
        '
        Me.txtCashFund.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashFund.Location = New System.Drawing.Point(12, 125)
        Me.txtCashFund.Name = "txtCashFund"
        Me.txtCashFund.Size = New System.Drawing.Size(252, 38)
        Me.txtCashFund.TabIndex = 1
        Me.txtCashFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboBranch
        '
        Me.cboBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBranch.FormattingEnabled = True
        Me.cboBranch.Items.AddRange(New Object() {"Alicia", "Bambang", "Cordon", "Roxas", "Tuguegarao", "Santiago"})
        Me.cboBranch.Location = New System.Drawing.Point(55, 50)
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(60, 39)
        Me.cboBranch.TabIndex = 32
        '
        'cboTerminal
        '
        Me.cboTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerminal.FormattingEnabled = True
        Me.cboTerminal.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cboTerminal.Location = New System.Drawing.Point(55, 106)
        Me.cboTerminal.Name = "cboTerminal"
        Me.cboTerminal.Size = New System.Drawing.Size(60, 39)
        Me.cboTerminal.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboBranch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboTerminal)
        Me.GroupBox1.Location = New System.Drawing.Point(727, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 200)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'btn00
        '
        Me.btn00.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn00.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn00.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn00.Location = New System.Drawing.Point(185, 340)
        Me.btn00.Name = "btn00"
        Me.btn00.Size = New System.Drawing.Size(80, 51)
        Me.btn00.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn00.TabIndex = 163
        Me.btn00.Text = "00"
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(12, 340)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 51)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClear.TabIndex = 162
        Me.btnClear.Text = "Clear"
        '
        'btn0
        '
        Me.btn0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn0.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(99, 340)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(80, 51)
        Me.btn0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn0.TabIndex = 161
        Me.btn0.Text = "0"
        '
        'btn7
        '
        Me.btn7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(12, 283)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(80, 51)
        Me.btn7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn7.TabIndex = 160
        Me.btn7.Text = "7"
        '
        'btn8
        '
        Me.btn8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(99, 283)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(80, 51)
        Me.btn8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn8.TabIndex = 159
        Me.btn8.Text = "8"
        '
        'btn9
        '
        Me.btn9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(185, 283)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(80, 51)
        Me.btn9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn9.TabIndex = 158
        Me.btn9.Text = "9"
        '
        'btn4
        '
        Me.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(12, 226)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(80, 51)
        Me.btn4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn4.TabIndex = 157
        Me.btn4.Text = "4"
        '
        'btn5
        '
        Me.btn5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(99, 226)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(80, 51)
        Me.btn5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn5.TabIndex = 156
        Me.btn5.Text = "5"
        '
        'btn6
        '
        Me.btn6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(185, 226)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(80, 51)
        Me.btn6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn6.TabIndex = 155
        Me.btn6.Text = "6"
        '
        'btn3
        '
        Me.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(185, 169)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(80, 51)
        Me.btn3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn3.TabIndex = 154
        Me.btn3.Text = "3"
        '
        'btn2
        '
        Me.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(99, 169)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(80, 51)
        Me.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn2.TabIndex = 153
        Me.btn2.Text = "2"
        '
        'btn1
        '
        Me.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(12, 169)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(80, 51)
        Me.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn1.TabIndex = 152
        Me.btn1.Text = "1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'btnStartShift
        '
        Me.btnStartShift.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnStartShift.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartShift.Location = New System.Drawing.Point(271, 125)
        Me.btnStartShift.Name = "btnStartShift"
        Me.btnStartShift.Size = New System.Drawing.Size(135, 48)
        Me.btnStartShift.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnStartShift.TabIndex = 164
        Me.btnStartShift.Text = "Start Session"
        Me.btnStartShift.TextColor = System.Drawing.Color.White
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(271, 179)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 48)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 165
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextColor = System.Drawing.Color.White
        '
        'frmStartofDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(415, 398)
        Me.Controls.Add(Me.btnStartShift)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn00)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.lblTenderType)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.txtCashFund)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStartofDay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Session"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTenderType As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCashFund As System.Windows.Forms.TextBox
    Friend WithEvents cboBranch As System.Windows.Forms.ComboBox
    Friend WithEvents cboTerminal As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn0 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn8 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn9 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn00 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnStartShift As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
End Class
