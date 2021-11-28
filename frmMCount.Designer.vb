<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCount))
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.lblItemDesc = New DevComponents.DotNetBar.LabelX()
        Me.txtPhysicalQty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCurrQty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAdjQty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMonthlyBeg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.btnPlus = New DevComponents.DotNetBar.ButtonX()
        Me.btnMinus = New DevComponents.DotNetBar.ButtonX()
        Me.lblOperation = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnClose.Location = New System.Drawing.Point(248, 204)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 53)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnSave.Location = New System.Drawing.Point(99, 204)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 53)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'lblItemDesc
        '
        '
        '
        '
        Me.lblItemDesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblItemDesc.Font = New System.Drawing.Font("Arial Narrow", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDesc.ForeColor = System.Drawing.Color.DeepPink
        Me.lblItemDesc.Location = New System.Drawing.Point(8, 6)
        Me.lblItemDesc.Name = "lblItemDesc"
        Me.lblItemDesc.Size = New System.Drawing.Size(437, 40)
        Me.lblItemDesc.TabIndex = 231
        Me.lblItemDesc.Text = "Chicharon ni Mang Juan"
        '
        'txtPhysicalQty
        '
        Me.txtPhysicalQty.BackColor = System.Drawing.Color.LemonChiffon
        '
        '
        '
        Me.txtPhysicalQty.Border.Class = "TextBoxBorder"
        Me.txtPhysicalQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPhysicalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysicalQty.Location = New System.Drawing.Point(204, 455)
        Me.txtPhysicalQty.Name = "txtPhysicalQty"
        Me.txtPhysicalQty.Size = New System.Drawing.Size(276, 38)
        Me.txtPhysicalQty.TabIndex = 0
        Me.txtPhysicalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPhysicalQty.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtPhysicalQty.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysicalQty.WatermarkText = "Enter Quantity"
        '
        'txtCurrQty
        '
        Me.txtCurrQty.BackColor = System.Drawing.Color.LemonChiffon
        '
        '
        '
        Me.txtCurrQty.Border.Class = "TextBoxBorder"
        Me.txtCurrQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCurrQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrQty.Location = New System.Drawing.Point(204, 411)
        Me.txtCurrQty.Name = "txtCurrQty"
        Me.txtCurrQty.Size = New System.Drawing.Size(276, 38)
        Me.txtCurrQty.TabIndex = 232
        Me.txtCurrQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCurrQty.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtCurrQty.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrQty.WatermarkText = "Curr Quantity"
        '
        'txtAdjQty
        '
        Me.txtAdjQty.BackColor = System.Drawing.Color.LemonChiffon
        '
        '
        '
        Me.txtAdjQty.Border.Class = "TextBoxBorder"
        Me.txtAdjQty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAdjQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjQty.Location = New System.Drawing.Point(41, 121)
        Me.txtAdjQty.Name = "txtAdjQty"
        Me.txtAdjQty.Size = New System.Drawing.Size(321, 38)
        Me.txtAdjQty.TabIndex = 233
        Me.txtAdjQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAdjQty.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtAdjQty.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjQty.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMonthlyBeg
        '
        Me.txtMonthlyBeg.BackColor = System.Drawing.Color.LemonChiffon
        '
        '
        '
        Me.txtMonthlyBeg.Border.Class = "TextBoxBorder"
        Me.txtMonthlyBeg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMonthlyBeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyBeg.Location = New System.Drawing.Point(538, 622)
        Me.txtMonthlyBeg.Name = "txtMonthlyBeg"
        Me.txtMonthlyBeg.Size = New System.Drawing.Size(276, 38)
        Me.txtMonthlyBeg.TabIndex = 1
        Me.txtMonthlyBeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMonthlyBeg.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyBeg.WatermarkText = "Beginning Quantity"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(13, 62)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(132, 38)
        Me.LabelX1.TabIndex = 235
        Me.LabelX1.Text = "Adjustment Qty"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(373, 622)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(132, 38)
        Me.LabelX2.TabIndex = 236
        Me.LabelX2.Text = "Beginning Qty"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(39, 455)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(160, 38)
        Me.LabelX3.TabIndex = 240
        Me.LabelX3.Text = "Ending Qty"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(39, 411)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(159, 38)
        Me.LabelX4.TabIndex = 241
        Me.LabelX4.Text = "Current Qty"
        '
        'btnPlus
        '
        Me.btnPlus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPlus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Image = CType(resources.GetObject("btnPlus.Image"), System.Drawing.Image)
        Me.btnPlus.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnPlus.Location = New System.Drawing.Point(407, 121)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(33, 38)
        Me.btnPlus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPlus.TabIndex = 242
        '
        'btnMinus
        '
        Me.btnMinus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMinus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.Image = CType(resources.GetObject("btnMinus.Image"), System.Drawing.Image)
        Me.btnMinus.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnMinus.Location = New System.Drawing.Point(368, 121)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(33, 38)
        Me.btnMinus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMinus.TabIndex = 243
        '
        'lblOperation
        '
        '
        '
        '
        Me.lblOperation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperation.ForeColor = System.Drawing.Color.Green
        Me.lblOperation.Location = New System.Drawing.Point(21, 129)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(14, 23)
        Me.lblOperation.TabIndex = 244
        Me.lblOperation.Text = "+"
        '
        'frmMCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(457, 290)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtMonthlyBeg)
        Me.Controls.Add(Me.txtAdjQty)
        Me.Controls.Add(Me.txtCurrQty)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblItemDesc)
        Me.Controls.Add(Me.txtPhysicalQty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMCount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Adjustment"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblItemDesc As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPhysicalQty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCurrQty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAdjQty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMonthlyBeg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnPlus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMinus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblOperation As DevComponents.DotNetBar.LabelX
End Class
