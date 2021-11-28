<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlyDemandAnalysis
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
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.lblMonthRange = New DevComponents.DotNetBar.LabelX()
        Me.btnGenerate = New DevComponents.DotNetBar.ButtonX()
        Me.lvList = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtMonth1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.grpPanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtMonth3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtMonth2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.grpPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.Shockwave_POS.My.Resources.Resources.delete
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnClose.Location = New System.Drawing.Point(558, 472)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 45)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 49
        Me.btnClose.Text = "Close"
        '
        'lblMonthRange
        '
        '
        '
        '
        Me.lblMonthRange.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMonthRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthRange.Location = New System.Drawing.Point(5, 2)
        Me.lblMonthRange.Name = "lblMonthRange"
        Me.lblMonthRange.Size = New System.Drawing.Size(189, 29)
        Me.lblMonthRange.TabIndex = 50
        Me.lblMonthRange.Text = "January 2021 to March 2021"
        '
        'btnGenerate
        '
        Me.btnGenerate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Image = Global.Shockwave_POS.My.Resources.Resources.Sync
        Me.btnGenerate.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnGenerate.Location = New System.Drawing.Point(452, 472)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(100, 45)
        Me.btnGenerate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGenerate.TabIndex = 51
        Me.btnGenerate.Text = "Generate"
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lvList.Border.Class = "ListViewBorder"
        Me.lvList.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader1})
        Me.lvList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.Location = New System.Drawing.Point(5, 35)
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(653, 363)
        Me.lvList.TabIndex = 53
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Inv ID"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Item Description"
        Me.ColumnHeader7.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ave. Monthly Demand"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Suggested Order (50% of AMD)"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 210
        '
        'txtMonth1
        '
        '
        '
        '
        Me.txtMonth1.Border.Class = "TextBoxBorder"
        Me.txtMonth1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMonth1.Location = New System.Drawing.Point(60, 8)
        Me.txtMonth1.Name = "txtMonth1"
        Me.txtMonth1.Size = New System.Drawing.Size(90, 20)
        Me.txtMonth1.TabIndex = 54
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(7, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(49, 23)
        Me.LabelX1.TabIndex = 55
        Me.LabelX1.Text = "Month 1"
        '
        'grpPanel
        '
        Me.grpPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.grpPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.grpPanel.Controls.Add(Me.txtMonth3)
        Me.grpPanel.Controls.Add(Me.LabelX3)
        Me.grpPanel.Controls.Add(Me.txtMonth2)
        Me.grpPanel.Controls.Add(Me.LabelX2)
        Me.grpPanel.Controls.Add(Me.txtMonth1)
        Me.grpPanel.Controls.Add(Me.LabelX1)
        Me.grpPanel.Location = New System.Drawing.Point(33, 435)
        Me.grpPanel.Name = "grpPanel"
        Me.grpPanel.Size = New System.Drawing.Size(127, 61)
        '
        '
        '
        Me.grpPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grpPanel.Style.BackColorGradientAngle = 90
        Me.grpPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grpPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpPanel.Style.BorderBottomWidth = 1
        Me.grpPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grpPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpPanel.Style.BorderLeftWidth = 1
        Me.grpPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpPanel.Style.BorderRightWidth = 1
        Me.grpPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpPanel.Style.BorderTopWidth = 1
        Me.grpPanel.Style.CornerDiameter = 4
        Me.grpPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.grpPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grpPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.grpPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.grpPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grpPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grpPanel.TabIndex = 56
        Me.grpPanel.Text = "Item Details"
        '
        'txtMonth3
        '
        '
        '
        '
        Me.txtMonth3.Border.Class = "TextBoxBorder"
        Me.txtMonth3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMonth3.Location = New System.Drawing.Point(391, 8)
        Me.txtMonth3.Name = "txtMonth3"
        Me.txtMonth3.Size = New System.Drawing.Size(90, 20)
        Me.txtMonth3.TabIndex = 58
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(338, 5)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(49, 23)
        Me.LabelX3.TabIndex = 59
        Me.LabelX3.Text = "Month 3"
        '
        'txtMonth2
        '
        '
        '
        '
        Me.txtMonth2.Border.Class = "TextBoxBorder"
        Me.txtMonth2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMonth2.Location = New System.Drawing.Point(223, 8)
        Me.txtMonth2.Name = "txtMonth2"
        Me.txtMonth2.Size = New System.Drawing.Size(90, 20)
        Me.txtMonth2.TabIndex = 56
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(170, 5)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(49, 23)
        Me.LabelX2.TabIndex = 57
        Me.LabelX2.Text = "Month 2"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(5, 409)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(248, 108)
        Me.ListBox1.TabIndex = 58
        '
        'frmMonthlyDemandAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 527)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.grpPanel)
        Me.Controls.Add(Me.lvList)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblMonthRange)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonthlyDemandAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Demand Analysis"
        Me.grpPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblMonthRange As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnGenerate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lvList As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMonth1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents grpPanel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtMonth3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMonth2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
