<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetPos
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnReset = New DevComponents.DotNetBar.ButtonX()
        Me.txtResetCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(9, 2)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(281, 71)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "<font color=""#FFC20E""><b>Warning!</b></font><br /><br />" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All sales transactions," & _
            " customer records, inventory and other records in the database will be deleted. " & _
            "This cannot be undone."
        Me.LabelX1.WordWrap = True
        '
        'btnReset
        '
        Me.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.btnReset.Enabled = False
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(116, 239)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(182, 38)
        Me.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Confirm and Reset"
        Me.btnReset.TextColor = System.Drawing.Color.White
        '
        'txtResetCode
        '
        Me.txtResetCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.txtResetCode.Border.Class = "TextBoxBorder"
        Me.txtResetCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtResetCode.Font = New System.Drawing.Font("Wingdings", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtResetCode.ForeColor = System.Drawing.Color.Black
        Me.txtResetCode.Location = New System.Drawing.Point(12, 108)
        Me.txtResetCode.Name = "txtResetCode"
        Me.txtResetCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtResetCode.Size = New System.Drawing.Size(286, 22)
        Me.txtResetCode.TabIndex = 11
        Me.txtResetCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtResetCode.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResetCode.WatermarkText = "Enter reset code..."
        '
        'ProgressBarX1
        '
        Me.ProgressBarX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.ForeColor = System.Drawing.Color.Black
        Me.ProgressBarX1.Location = New System.Drawing.Point(9, 181)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(289, 16)
        Me.ProgressBarX1.TabIndex = 12
        Me.ProgressBarX1.Text = "ProgressBarX1"
        '
        'BackgroundWorker1
        '
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(9, 152)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(277, 23)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "10% dropping tables..."
        '
        'frmResetPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(317, 297)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.txtResetCode)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResetPos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset POS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents btnReset As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtResetCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
End Class
