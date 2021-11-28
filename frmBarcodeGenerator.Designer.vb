<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarcodeGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBarcodeGenerator))
        Me.BarCodeControl1 = New Spire.Barcode.Forms.BarCodeControl()
        Me.btnBarcodeGenerator = New DevComponents.DotNetBar.ButtonX()
        Me.txtBarcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.lblBarcodeAvailability = New DevComponents.DotNetBar.LabelX()
        Me.txtFilename = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BarCodeControl1
        '
        Me.BarCodeControl1.BorderWidth = 0.6!
        Me.BarCodeControl1.DpiX = 96.0!
        Me.BarCodeControl1.DpiY = 96.0!
        Me.BarCodeControl1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BarCodeControl1.ImageHeight = 30.0!
        Me.BarCodeControl1.ImageWidth = 120.0!
        Me.BarCodeControl1.Location = New System.Drawing.Point(12, 62)
        Me.BarCodeControl1.Name = "BarCodeControl1"
        Me.BarCodeControl1.Rotate = 0.0!
        Me.BarCodeControl1.ShowTextOnBottom = True
        Me.BarCodeControl1.ShowTopText = True
        Me.BarCodeControl1.Size = New System.Drawing.Size(189, 100)
        Me.BarCodeControl1.SupSpace = 4.0!
        Me.BarCodeControl1.TabIndex = 0
        Me.BarCodeControl1.TextFont = New System.Drawing.Font("Arial", 8.0!)
        Me.BarCodeControl1.TopTextAligment = System.Drawing.StringAlignment.Center
        Me.BarCodeControl1.TopTextFont = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.BarCodeControl1.UseChecksum = Spire.Barcode.CheckSumMode.[Auto]
        Me.BarCodeControl1.WideNarrowRatio = 3.0!
        Me.BarCodeControl1.XYRatio = 0.0!
        Me.BarCodeControl1.Y = 2.0!
        '
        'btnBarcodeGenerator
        '
        Me.btnBarcodeGenerator.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBarcodeGenerator.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBarcodeGenerator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarcodeGenerator.Image = CType(resources.GetObject("btnBarcodeGenerator.Image"), System.Drawing.Image)
        Me.btnBarcodeGenerator.ImageFixedSize = New System.Drawing.Size(20, 24)
        Me.btnBarcodeGenerator.ImageTextSpacing = 5
        Me.btnBarcodeGenerator.Location = New System.Drawing.Point(369, 12)
        Me.btnBarcodeGenerator.Name = "btnBarcodeGenerator"
        Me.btnBarcodeGenerator.Size = New System.Drawing.Size(123, 41)
        Me.btnBarcodeGenerator.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBarcodeGenerator.TabIndex = 57
        Me.btnBarcodeGenerator.Text = "Generate Barcode"
        Me.btnBarcodeGenerator.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'txtBarcode
        '
        '
        '
        '
        Me.txtBarcode.Border.Class = "TextBoxBorder"
        Me.txtBarcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBarcode.Location = New System.Drawing.Point(12, 168)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(189, 20)
        Me.txtBarcode.TabIndex = 58
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.Shockwave_POS.My.Resources.Resources.Printer_green_icon
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.ButtonX1.ImageTextSpacing = 5
        Me.ButtonX1.Location = New System.Drawing.Point(369, 106)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(123, 41)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 59
        Me.ButtonX1.Text = "Print"
        Me.ButtonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'PrintDocument1
        '
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.Shockwave_POS.My.Resources.Resources.check
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.ButtonX2.ImageTextSpacing = 5
        Me.ButtonX2.Location = New System.Drawing.Point(369, 59)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(123, 41)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 60
        Me.ButtonX2.Text = "Check Availability"
        Me.ButtonX2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'lblBarcodeAvailability
        '
        '
        '
        '
        Me.lblBarcodeAvailability.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblBarcodeAvailability.Location = New System.Drawing.Point(14, 254)
        Me.lblBarcodeAvailability.Name = "lblBarcodeAvailability"
        Me.lblBarcodeAvailability.Size = New System.Drawing.Size(478, 22)
        Me.lblBarcodeAvailability.TabIndex = 61
        '
        'txtFilename
        '
        '
        '
        '
        Me.txtFilename.Border.Class = "TextBoxBorder"
        Me.txtFilename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFilename.Location = New System.Drawing.Point(12, 36)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(189, 20)
        Me.txtFilename.TabIndex = 62
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(13, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(57, 17)
        Me.LabelX1.TabIndex = 63
        Me.LabelX1.Text = "Filename"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(12, 194)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(117, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 65
        Me.ButtonX3.Text = "Change directory..."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(564, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(566, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 22)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Status: "
        '
        'ProgressBarX1
        '
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Location = New System.Drawing.Point(13, 254)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(479, 22)
        Me.ProgressBarX1.TabIndex = 71
        Me.ProgressBarX1.Text = "ProgressBarX1"
        Me.ProgressBarX1.Visible = False
        '
        'lblDirectory
        '
        Me.lblDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDirectory.Location = New System.Drawing.Point(14, 294)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(478, 21)
        Me.lblDirectory.TabIndex = 72
        Me.lblDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmBarcodeGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 319)
        Me.Controls.Add(Me.lblDirectory)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.lblBarcodeAvailability)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.btnBarcodeGenerator)
        Me.Controls.Add(Me.BarCodeControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBarcodeGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarCodeControl1 As Spire.Barcode.Forms.BarCodeControl
    Friend WithEvents btnBarcodeGenerator As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtBarcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblBarcodeAvailability As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFilename As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents lblDirectory As System.Windows.Forms.Label
End Class
