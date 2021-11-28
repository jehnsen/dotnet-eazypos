<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplaySettings
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.txtBussAddress = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBussName = New System.Windows.Forms.TextBox()
        Me.lblTenderType = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.btnSaveSettings = New DevComponents.DotNetBar.ButtonX()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SuspendLayout()
        '
        'txtBussAddress
        '
        Me.txtBussAddress.BackColor = System.Drawing.Color.White
        Me.txtBussAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBussAddress.Location = New System.Drawing.Point(17, 183)
        Me.txtBussAddress.Name = "txtBussAddress"
        Me.txtBussAddress.Size = New System.Drawing.Size(520, 35)
        Me.txtBussAddress.TabIndex = 143
        Me.txtBussAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(12, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(185, 25)
        Me.Label17.TabIndex = 142
        Me.Label17.Text = "Business Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(162, 25)
        Me.Label14.TabIndex = 141
        Me.Label14.Text = "Business Name"
        '
        'txtBussName
        '
        Me.txtBussName.BackColor = System.Drawing.Color.White
        Me.txtBussName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBussName.Location = New System.Drawing.Point(17, 105)
        Me.txtBussName.Name = "txtBussName"
        Me.txtBussName.Size = New System.Drawing.Size(520, 35)
        Me.txtBussName.TabIndex = 140
        Me.txtBussName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTenderType
        '
        Me.lblTenderType.AutoSize = True
        Me.lblTenderType.BackColor = System.Drawing.Color.Transparent
        Me.lblTenderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenderType.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblTenderType.Location = New System.Drawing.Point(12, 19)
        Me.lblTenderType.Name = "lblTenderType"
        Me.lblTenderType.Size = New System.Drawing.Size(201, 29)
        Me.lblTenderType.TabIndex = 144
        Me.lblTenderType.Text = "Display Settings"
        Me.lblTenderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LawnGreen
        Me.RectangleShape1.Location = New System.Drawing.Point(6, 56)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(538, 241)
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(404, 236)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 56)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 151
        Me.btnClose.Text = "Cancel"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings.Location = New System.Drawing.Point(265, 236)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(133, 56)
        Me.btnSaveSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSaveSettings.TabIndex = 150
        Me.btnSaveSettings.Text = "Save Settings"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(553, 307)
        Me.ShapeContainer1.TabIndex = 145
        Me.ShapeContainer1.TabStop = False
        '
        'frmDisplaySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(553, 307)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.lblTenderType)
        Me.Controls.Add(Me.txtBussAddress)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBussName)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDisplaySettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBussAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBussName As System.Windows.Forms.TextBox
    Friend WithEvents lblTenderType As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSaveSettings As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
