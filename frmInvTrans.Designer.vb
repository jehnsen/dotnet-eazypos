<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvTrans
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvTrans))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDRNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboIssueTo = New System.Windows.Forms.ComboBox()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.TXTDELBY = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TXTCHECKBY = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblDRNo = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.chkAddItems = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.dgrIssuanceItems = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cboSupplierID = New System.Windows.Forms.ComboBox()
        Me.cboIssueToID = New System.Windows.Forms.ComboBox()
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdateQty = New DevComponents.DotNetBar.ButtonX()
        Me.btnBrowseItem = New DevComponents.DotNetBar.ButtonX()
        Me.btnRemove = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.View_SalesReportTableAdapter1 = New Shockwave_POS.dsPOSTableAdapters.view_SalesReportTableAdapter()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrIssuanceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Orange
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtRemarks.Border.Class = "TextBoxBorder"
        Me.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtRemarks, True)
        Me.txtRemarks.Location = New System.Drawing.Point(90, 69)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(309, 83)
        Me.txtRemarks.TabIndex = 93
        Me.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRemarks.WatermarkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtRemarks.WatermarkFont = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.WatermarkText = "Add Stock In / Stock Out description..."
        '
        'txtDRNo
        '
        Me.txtDRNo.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtDRNo.Border.Class = "TextBoxBorder"
        Me.txtDRNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDRNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDRNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDRNo, True)
        Me.txtDRNo.Location = New System.Drawing.Point(90, 12)
        Me.txtDRNo.Name = "txtDRNo"
        Me.txtDRNo.Size = New System.Drawing.Size(309, 22)
        Me.txtDRNo.TabIndex = 92
        Me.txtDRNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboIssueTo
        '
        Me.cboIssueTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIssueTo.FormattingEnabled = True
        Me.Highlighter1.SetHighlightOnFocus(Me.cboIssueTo, True)
        Me.cboIssueTo.Location = New System.Drawing.Point(1102, 341)
        Me.cboIssueTo.Name = "cboIssueTo"
        Me.cboIssueTo.Size = New System.Drawing.Size(79, 24)
        Me.cboIssueTo.TabIndex = 109
        '
        'cboLocation
        '
        Me.cboLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.FormattingEnabled = True
        Me.Highlighter1.SetHighlightOnFocus(Me.cboLocation, True)
        Me.cboLocation.Location = New System.Drawing.Point(1102, 311)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(79, 24)
        Me.cboLocation.TabIndex = 106
        '
        'TXTDELBY
        '
        Me.TXTDELBY.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TXTDELBY.Border.Class = "TextBoxBorder"
        Me.TXTDELBY.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTDELBY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDELBY.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.TXTDELBY, True)
        Me.TXTDELBY.Location = New System.Drawing.Point(429, 38)
        Me.TXTDELBY.Name = "TXTDELBY"
        Me.TXTDELBY.Size = New System.Drawing.Size(270, 22)
        Me.TXTDELBY.TabIndex = 118
        Me.TXTDELBY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTCHECKBY
        '
        Me.TXTCHECKBY.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TXTCHECKBY.Border.Class = "TextBoxBorder"
        Me.TXTCHECKBY.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TXTCHECKBY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCHECKBY.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Highlighter1.SetHighlightOnFocus(Me.TXTCHECKBY, True)
        Me.TXTCHECKBY.Location = New System.Drawing.Point(430, 92)
        Me.TXTCHECKBY.Name = "TXTCHECKBY"
        Me.TXTCHECKBY.Size = New System.Drawing.Size(270, 22)
        Me.TXTCHECKBY.TabIndex = 120
        Me.TXTCHECKBY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpDate
        '
        '
        '
        '
        Me.dtpDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpDate.ButtonDropDown.Visible = True
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.IsPopupCalendarOpen = False
        Me.dtpDate.Location = New System.Drawing.Point(258, 253)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(2)
        '
        '
        '
        Me.dtpDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpDate.MonthCalendar.DisplayMonth = New Date(2016, 6, 1, 0, 0, 0, 0)
        Me.dtpDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpDate.MonthCalendar.TodayButtonVisible = True
        Me.dtpDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(154, 24)
        Me.dtpDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpDate.TabIndex = 116
        '
        'lblDRNo
        '
        '
        '
        '
        Me.lblDRNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDRNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDRNo.Location = New System.Drawing.Point(12, 10)
        Me.lblDRNo.Name = "lblDRNo"
        Me.lblDRNo.Size = New System.Drawing.Size(72, 25)
        Me.lblDRNo.TabIndex = 114
        Me.lblDRNo.Text = "DR No."
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(12, 38)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 25)
        Me.LabelX2.TabIndex = 113
        Me.LabelX2.Text = "Date"
        '
        'chkAddItems
        '
        Me.chkAddItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.chkAddItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkAddItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAddItems.Location = New System.Drawing.Point(3, 566)
        Me.chkAddItems.Name = "chkAddItems"
        Me.chkAddItems.Size = New System.Drawing.Size(217, 37)
        Me.chkAddItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkAddItems.TabIndex = 111
        Me.chkAddItems.Text = "Add Stock In/Stock Out Items"
        Me.chkAddItems.TextColor = System.Drawing.Color.Red
        Me.chkAddItems.Visible = False
        '
        'dgrIssuanceItems
        '
        Me.dgrIssuanceItems.AllowUserToAddRows = False
        Me.dgrIssuanceItems.AllowUserToDeleteRows = False
        Me.dgrIssuanceItems.AllowUserToResizeColumns = False
        Me.dgrIssuanceItems.AllowUserToResizeRows = False
        Me.dgrIssuanceItems.BackgroundColor = System.Drawing.Color.White
        Me.dgrIssuanceItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrIssuanceItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrIssuanceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrIssuanceItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column6, Me.Column1, Me.Column3, Me.Column5, Me.Column2, Me.Column7, Me.Column9})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrIssuanceItems.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgrIssuanceItems.EnableHeadersVisualStyles = False
        Me.dgrIssuanceItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgrIssuanceItems.Location = New System.Drawing.Point(3, 192)
        Me.dgrIssuanceItems.Name = "dgrIssuanceItems"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrIssuanceItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgrIssuanceItems.RowHeadersVisible = False
        Me.dgrIssuanceItems.RowTemplate.Height = 32
        Me.dgrIssuanceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrIssuanceItems.Size = New System.Drawing.Size(710, 373)
        Me.dgrIssuanceItems.TabIndex = 100
        '
        'Column8
        '
        Me.Column8.HeaderText = "RecordID"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Lookup Code"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Item Description"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Unit"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "0"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.Width = 80
        '
        'Column2
        '
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "CURR_QTY"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column7
        '
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "ENDING_QTY"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'Column9
        '
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column9.HeaderText = "DAILYBEG_QTY"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(1011, 340)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(85, 25)
        Me.LabelX3.TabIndex = 104
        Me.LabelX3.Text = "Issue To"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(1011, 310)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(85, 25)
        Me.LabelX4.TabIndex = 105
        Me.LabelX4.Text = "Location"
        '
        'cboSupplierID
        '
        Me.cboSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplierID.FormattingEnabled = True
        Me.cboSupplierID.Location = New System.Drawing.Point(17, 275)
        Me.cboSupplierID.Name = "cboSupplierID"
        Me.cboSupplierID.Size = New System.Drawing.Size(42, 24)
        Me.cboSupplierID.TabIndex = 107
        '
        'cboIssueToID
        '
        Me.cboIssueToID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIssueToID.FormattingEnabled = True
        Me.cboIssueToID.Location = New System.Drawing.Point(468, 307)
        Me.cboIssueToID.Name = "cboIssueToID"
        Me.cboIssueToID.Size = New System.Drawing.Size(30, 24)
        Me.cboIssueToID.TabIndex = 110
        '
        'dtpDateTime
        '
        Me.dtpDateTime.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpDateTime.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTime.Location = New System.Drawing.Point(90, 40)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(308, 23)
        Me.dtpDateTime.TabIndex = 117
        '
        'btnUpdateQty
        '
        Me.btnUpdateQty.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUpdateQty.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnUpdateQty.Image = CType(resources.GetObject("btnUpdateQty.Image"), System.Drawing.Image)
        Me.btnUpdateQty.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnUpdateQty.Location = New System.Drawing.Point(424, 154)
        Me.btnUpdateQty.Name = "btnUpdateQty"
        Me.btnUpdateQty.Size = New System.Drawing.Size(95, 32)
        Me.btnUpdateQty.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUpdateQty.TabIndex = 98
        Me.btnUpdateQty.Text = "Edit Qty..."
        Me.btnUpdateQty.Visible = False
        '
        'btnBrowseItem
        '
        Me.btnBrowseItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowseItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowseItem.Image = CType(resources.GetObject("btnBrowseItem.Image"), System.Drawing.Image)
        Me.btnBrowseItem.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnBrowseItem.Location = New System.Drawing.Point(521, 154)
        Me.btnBrowseItem.Name = "btnBrowseItem"
        Me.btnBrowseItem.Size = New System.Drawing.Size(95, 32)
        Me.btnBrowseItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBrowseItem.TabIndex = 95
        Me.btnBrowseItem.Text = "Items..."
        '
        'btnRemove
        '
        Me.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnRemove.Location = New System.Drawing.Point(618, 154)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(95, 32)
        Me.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemove.TabIndex = 97
        Me.btnRemove.Text = "Remove"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnCancel.Location = New System.Drawing.Point(624, 571)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 40)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 103
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnSave.Location = New System.Drawing.Point(529, 571)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 40)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 102
        Me.btnSave.Text = "Save"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(428, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(98, 25)
        Me.LabelX1.TabIndex = 119
        Me.LabelX1.Text = "Delivered By"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(429, 64)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(98, 25)
        Me.LabelX5.TabIndex = 121
        Me.LabelX5.Text = "Checked By"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(12, 67)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(72, 25)
        Me.LabelX6.TabIndex = 123
        Me.LabelX6.Text = "Description"
        '
        'View_SalesReportTableAdapter1
        '
        Me.View_SalesReportTableAdapter1.ClearBeforeFill = True
        '
        'frmInvTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(716, 615)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.TXTCHECKBY)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.TXTDELBY)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.dtpDateTime)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtDRNo)
        Me.Controls.Add(Me.cboIssueTo)
        Me.Controls.Add(Me.lblDRNo)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.chkAddItems)
        Me.Controls.Add(Me.btnUpdateQty)
        Me.Controls.Add(Me.dgrIssuanceItems)
        Me.Controls.Add(Me.btnBrowseItem)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboSupplierID)
        Me.Controls.Add(Me.cboIssueToID)
        Me.Controls.Add(Me.dtpDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Transaction"
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrIssuanceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboIssueTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents dgrIssuanceItems As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cboSupplierID As System.Windows.Forms.ComboBox
    Friend WithEvents cboIssueToID As System.Windows.Forms.ComboBox
    Private WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Private WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtDRNo As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents dtpDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents lblDRNo As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents chkAddItems As DevComponents.DotNetBar.Controls.CheckBoxX
    Private WithEvents btnUpdateQty As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnBrowseItem As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnRemove As DevComponents.DotNetBar.ButtonX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtpDateTime As System.Windows.Forms.DateTimePicker
    Private WithEvents TXTDELBY As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents TXTCHECKBY As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents View_SalesReportTableAdapter1 As Shockwave_POS.dsPOSTableAdapters.view_SalesReportTableAdapter
End Class
