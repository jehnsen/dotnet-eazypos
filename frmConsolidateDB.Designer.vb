<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsolidateDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsolidateDB))
        Me.consoProgressbar = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.lblProgress = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.chkOp1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkOp2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkOp3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnConsolidate = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'consoProgressbar
        '
        '
        '
        '
        Me.consoProgressbar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.consoProgressbar.Location = New System.Drawing.Point(6, 190)
        Me.consoProgressbar.Name = "consoProgressbar"
        Me.consoProgressbar.Size = New System.Drawing.Size(625, 19)
        Me.consoProgressbar.TabIndex = 58
        Me.consoProgressbar.Text = "ProgressBarX1"
        '
        'lblProgress
        '
        '
        '
        '
        Me.lblProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblProgress.Location = New System.Drawing.Point(6, 165)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(185, 19)
        Me.lblProgress.TabIndex = 59
        Me.lblProgress.Text = "Database consolidatin started..."
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(6, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(185, 19)
        Me.LabelX1.TabIndex = 60
        Me.LabelX1.Text = "Select Operations"
        '
        'chkOp1
        '
        '
        '
        '
        Me.chkOp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkOp1.Location = New System.Drawing.Point(6, 49)
        Me.chkOp1.Name = "chkOp1"
        Me.chkOp1.Size = New System.Drawing.Size(391, 26)
        Me.chkOp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkOp1.TabIndex = 61
        Me.chkOp1.Text = "Download latest product updates from server"
        '
        'chkOp2
        '
        '
        '
        '
        Me.chkOp2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkOp2.Enabled = False
        Me.chkOp2.Location = New System.Drawing.Point(6, 81)
        Me.chkOp2.Name = "chkOp2"
        Me.chkOp2.Size = New System.Drawing.Size(391, 26)
        Me.chkOp2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkOp2.TabIndex = 62
        Me.chkOp2.Text = "Upload newly added customers and their transaction logs"
        '
        'chkOp3
        '
        '
        '
        '
        Me.chkOp3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkOp3.Enabled = False
        Me.chkOp3.Location = New System.Drawing.Point(6, 113)
        Me.chkOp3.Name = "chkOp3"
        Me.chkOp3.Size = New System.Drawing.Size(391, 26)
        Me.chkOp3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkOp3.TabIndex = 63
        Me.chkOp3.Text = "Upload local transactions to server"
        '
        'BackgroundWorker1
        '
        '
        'btnConsolidate
        '
        Me.btnConsolidate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConsolidate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnConsolidate.Enabled = False
        Me.btnConsolidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsolidate.Image = CType(resources.GetObject("btnConsolidate.Image"), System.Drawing.Image)
        Me.btnConsolidate.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnConsolidate.ImageTextSpacing = 5
        Me.btnConsolidate.Location = New System.Drawing.Point(476, 12)
        Me.btnConsolidate.Name = "btnConsolidate"
        Me.btnConsolidate.Size = New System.Drawing.Size(155, 42)
        Me.btnConsolidate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnConsolidate.TabIndex = 57
        Me.btnConsolidate.Text = "Sync Database"
        Me.btnConsolidate.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'frmConsolidateDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 217)
        Me.Controls.Add(Me.chkOp3)
        Me.Controls.Add(Me.chkOp2)
        Me.Controls.Add(Me.chkOp1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.consoProgressbar)
        Me.Controls.Add(Me.btnConsolidate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsolidateDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sync Database"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConsolidate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents consoProgressbar As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents lblProgress As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkOp1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkOp2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkOp3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
