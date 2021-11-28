<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesDashboard
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
        Me.MicroChart1 = New DevComponents.DotNetBar.MicroChart()
        Me.MicroChart2 = New DevComponents.DotNetBar.MicroChart()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'MicroChart1
        '
        '
        '
        '
        Me.MicroChart1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MicroChart1.Location = New System.Drawing.Point(37, 44)
        Me.MicroChart1.Name = "MicroChart1"
        Me.MicroChart1.Size = New System.Drawing.Size(329, 183)
        Me.MicroChart1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MicroChart1.TabIndex = 0
        Me.MicroChart1.Text = "MicroChart1"
        '
        'MicroChart2
        '
        '
        '
        '
        Me.MicroChart2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MicroChart2.Location = New System.Drawing.Point(552, 44)
        Me.MicroChart2.Name = "MicroChart2"
        Me.MicroChart2.Size = New System.Drawing.Size(349, 199)
        Me.MicroChart2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MicroChart2.TabIndex = 1
        Me.MicroChart2.Text = "MicroChart2"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(21, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(55, 19)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Sales"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(552, 19)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(145, 19)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Transactions"
        '
        'frmSalesDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 495)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.MicroChart2)
        Me.Controls.Add(Me.MicroChart1)
        Me.DoubleBuffered = True
        Me.Name = "frmSalesDashboard"
        Me.Text = "frmSalesDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MicroChart1 As DevComponents.DotNetBar.MicroChart
    Friend WithEvents MicroChart2 As DevComponents.DotNetBar.MicroChart
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
