<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiManagerDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiManagerDashboard))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitPOSManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NavigationPane1 = New DevComponents.DotNetBar.NavigationPane()
        Me.NavigationPanePanel1 = New DevComponents.DotNetBar.NavigationPanePanel()
        Me.btnBackupDB = New DevComponents.DotNetBar.ButtonX()
        Me.btnConsoDB = New DevComponents.DotNetBar.ButtonX()
        Me.btnCategoies = New DevComponents.DotNetBar.ButtonX()
        Me.btnSuppliers = New DevComponents.DotNetBar.ButtonX()
        Me.btnDiscounts = New DevComponents.DotNetBar.ButtonX()
        Me.btnItemMaintenance = New DevComponents.DotNetBar.ButtonX()
        Me.btnCustomers = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.NavigationPanePanel2 = New DevComponents.DotNetBar.NavigationPanePanel()
        Me.btnInventory = New DevComponents.DotNetBar.ButtonX()
        Me.btnPurchaseOrders = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.NavigationPanePanel4 = New DevComponents.DotNetBar.NavigationPanePanel()
        Me.btnResetPos = New DevComponents.DotNetBar.ButtonX()
        Me.btnDisplay = New DevComponents.DotNetBar.ButtonX()
        Me.btnPOSSettings = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.NavigationPanePanel3 = New DevComponents.DotNetBar.NavigationPanePanel()
        Me.btnUserAccess = New DevComponents.DotNetBar.ButtonX()
        Me.btnReprintReceipt = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.NavigationPanePanel5 = New DevComponents.DotNetBar.NavigationPanePanel()
        Me.btnGenerateReports = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.NavigationPane1.SuspendLayout()
        Me.NavigationPanePanel1.SuspendLayout()
        Me.NavigationPanePanel2.SuspendLayout()
        Me.NavigationPanePanel4.SuspendLayout()
        Me.NavigationPanePanel3.SuspendLayout()
        Me.NavigationPanePanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ViewMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(973, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitPOSManagerToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitPOSManagerToolStripMenuItem
        '
        Me.ExitPOSManagerToolStripMenuItem.Name = "ExitPOSManagerToolStripMenuItem"
        Me.ExitPOSManagerToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExitPOSManagerToolStripMenuItem.Text = "Exit POS Manager"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 577)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(973, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'NavigationPane1
        '
        Me.NavigationPane1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.NavigationPane1.Controls.Add(Me.NavigationPanePanel1)
        Me.NavigationPane1.Controls.Add(Me.NavigationPanePanel2)
        Me.NavigationPane1.Controls.Add(Me.NavigationPanePanel4)
        Me.NavigationPane1.Controls.Add(Me.NavigationPanePanel3)
        Me.NavigationPane1.Controls.Add(Me.NavigationPanePanel5)
        Me.NavigationPane1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavigationPane1.ForeColor = System.Drawing.Color.Black
        Me.NavigationPane1.ItemPaddingBottom = 2
        Me.NavigationPane1.ItemPaddingTop = 2
        Me.NavigationPane1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem5, Me.ButtonItem3, Me.ButtonItem4})
        Me.NavigationPane1.Location = New System.Drawing.Point(0, 24)
        Me.NavigationPane1.Name = "NavigationPane1"
        Me.NavigationPane1.NavigationBarHeight = 207
        Me.NavigationPane1.Padding = New System.Windows.Forms.Padding(1)
        Me.NavigationPane1.Size = New System.Drawing.Size(188, 553)
        Me.NavigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.NavigationPane1.TabIndex = 82
        '
        '
        '
        Me.NavigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.NavigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavigationPane1.TitlePanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigationPane1.TitlePanel.Location = New System.Drawing.Point(1, 1)
        Me.NavigationPane1.TitlePanel.Name = "panelTitle"
        Me.NavigationPane1.TitlePanel.Size = New System.Drawing.Size(186, 24)
        Me.NavigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.NavigationPane1.TitlePanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.NavigationPane1.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.NavigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.NavigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.NavigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.NavigationPane1.TitlePanel.Style.GradientAngle = 90
        Me.NavigationPane1.TitlePanel.Style.MarginLeft = 4
        Me.NavigationPane1.TitlePanel.TabIndex = 0
        Me.NavigationPane1.TitlePanel.Text = "Maintenance"
        '
        'NavigationPanePanel1
        '
        Me.NavigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.NavigationPanePanel1.Controls.Add(Me.btnBackupDB)
        Me.NavigationPanePanel1.Controls.Add(Me.btnConsoDB)
        Me.NavigationPanePanel1.Controls.Add(Me.btnCategoies)
        Me.NavigationPanePanel1.Controls.Add(Me.btnSuppliers)
        Me.NavigationPanePanel1.Controls.Add(Me.btnDiscounts)
        Me.NavigationPanePanel1.Controls.Add(Me.btnItemMaintenance)
        Me.NavigationPanePanel1.Controls.Add(Me.btnCustomers)
        Me.NavigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPanePanel1.Location = New System.Drawing.Point(1, 25)
        Me.NavigationPanePanel1.Name = "NavigationPanePanel1"
        Me.NavigationPanePanel1.ParentItem = Me.ButtonItem1
        Me.NavigationPanePanel1.Size = New System.Drawing.Size(186, 320)
        Me.NavigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.NavigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.NavigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.NavigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.NavigationPanePanel1.Style.GradientAngle = 90
        Me.NavigationPanePanel1.TabIndex = 2
        '
        'btnBackupDB
        '
        Me.btnBackupDB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBackupDB.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnBackupDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupDB.Image = CType(resources.GetObject("btnBackupDB.Image"), System.Drawing.Image)
        Me.btnBackupDB.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnBackupDB.ImageTextSpacing = 3
        Me.btnBackupDB.Location = New System.Drawing.Point(8, 256)
        Me.btnBackupDB.Name = "btnBackupDB"
        Me.btnBackupDB.Size = New System.Drawing.Size(173, 39)
        Me.btnBackupDB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBackupDB.SubItemsExpandWidth = 32
        Me.btnBackupDB.TabIndex = 86
        Me.btnBackupDB.Text = "Backup Database"
        Me.btnBackupDB.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnConsoDB
        '
        Me.btnConsoDB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConsoDB.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnConsoDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsoDB.Image = CType(resources.GetObject("btnConsoDB.Image"), System.Drawing.Image)
        Me.btnConsoDB.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnConsoDB.ImageTextSpacing = 3
        Me.btnConsoDB.Location = New System.Drawing.Point(8, 213)
        Me.btnConsoDB.Name = "btnConsoDB"
        Me.btnConsoDB.Size = New System.Drawing.Size(173, 39)
        Me.btnConsoDB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnConsoDB.SubItemsExpandWidth = 32
        Me.btnConsoDB.TabIndex = 85
        Me.btnConsoDB.Text = "Sync Database"
        Me.btnConsoDB.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnCategoies
        '
        Me.btnCategoies.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCategoies.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnCategoies.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoies.Image = CType(resources.GetObject("btnCategoies.Image"), System.Drawing.Image)
        Me.btnCategoies.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnCategoies.ImageTextSpacing = 3
        Me.btnCategoies.Location = New System.Drawing.Point(8, 170)
        Me.btnCategoies.Name = "btnCategoies"
        Me.btnCategoies.Size = New System.Drawing.Size(173, 39)
        Me.btnCategoies.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCategoies.SubItemsExpandWidth = 32
        Me.btnCategoies.TabIndex = 84
        Me.btnCategoies.Text = "Categories"
        Me.btnCategoies.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnSuppliers
        '
        Me.btnSuppliers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSuppliers.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliers.Image = CType(resources.GetObject("btnSuppliers.Image"), System.Drawing.Image)
        Me.btnSuppliers.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnSuppliers.ImageTextSpacing = 3
        Me.btnSuppliers.Location = New System.Drawing.Point(8, 88)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(173, 39)
        Me.btnSuppliers.TabIndex = 83
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnDiscounts
        '
        Me.btnDiscounts.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDiscounts.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnDiscounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscounts.Image = CType(resources.GetObject("btnDiscounts.Image"), System.Drawing.Image)
        Me.btnDiscounts.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnDiscounts.ImageTextSpacing = 3
        Me.btnDiscounts.Location = New System.Drawing.Point(8, 129)
        Me.btnDiscounts.Name = "btnDiscounts"
        Me.btnDiscounts.Size = New System.Drawing.Size(173, 39)
        Me.btnDiscounts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDiscounts.SubItemsExpandWidth = 32
        Me.btnDiscounts.TabIndex = 82
        Me.btnDiscounts.Text = "Discounts"
        Me.btnDiscounts.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnItemMaintenance
        '
        Me.btnItemMaintenance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnItemMaintenance.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnItemMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemMaintenance.Image = CType(resources.GetObject("btnItemMaintenance.Image"), System.Drawing.Image)
        Me.btnItemMaintenance.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnItemMaintenance.ImageTextSpacing = 3
        Me.btnItemMaintenance.Location = New System.Drawing.Point(8, 6)
        Me.btnItemMaintenance.Name = "btnItemMaintenance"
        Me.btnItemMaintenance.Size = New System.Drawing.Size(173, 39)
        Me.btnItemMaintenance.TabIndex = 73
        Me.btnItemMaintenance.Text = "Item Maintenance"
        Me.btnItemMaintenance.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnCustomers
        '
        Me.btnCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCustomers.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.Image = CType(resources.GetObject("btnCustomers.Image"), System.Drawing.Image)
        Me.btnCustomers.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnCustomers.ImageTextSpacing = 3
        Me.btnCustomers.Location = New System.Drawing.Point(8, 47)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(173, 39)
        Me.btnCustomers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCustomers.SubItemsExpandWidth = 32
        Me.btnCustomers.TabIndex = 71
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Checked = True
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.OptionGroup = "navBar"
        Me.ButtonItem1.Text = "Maintenance"
        '
        'NavigationPanePanel2
        '
        Me.NavigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.NavigationPanePanel2.Controls.Add(Me.btnInventory)
        Me.NavigationPanePanel2.Controls.Add(Me.btnPurchaseOrders)
        Me.NavigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPanePanel2.Location = New System.Drawing.Point(1, 1)
        Me.NavigationPanePanel2.Name = "NavigationPanePanel2"
        Me.NavigationPanePanel2.ParentItem = Me.ButtonItem2
        Me.NavigationPanePanel2.Size = New System.Drawing.Size(186, 344)
        Me.NavigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.NavigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.NavigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.NavigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.NavigationPanePanel2.Style.GradientAngle = 90
        Me.NavigationPanePanel2.TabIndex = 3
        '
        'btnInventory
        '
        Me.btnInventory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnInventory.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnInventory.Location = New System.Drawing.Point(8, 6)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(173, 39)
        Me.btnInventory.TabIndex = 66
        Me.btnInventory.Text = "Manage Inventory"
        Me.btnInventory.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnPurchaseOrders
        '
        Me.btnPurchaseOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPurchaseOrders.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnPurchaseOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseOrders.Image = CType(resources.GetObject("btnPurchaseOrders.Image"), System.Drawing.Image)
        Me.btnPurchaseOrders.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnPurchaseOrders.ImageTextSpacing = 3
        Me.btnPurchaseOrders.Location = New System.Drawing.Point(8, 46)
        Me.btnPurchaseOrders.Name = "btnPurchaseOrders"
        Me.btnPurchaseOrders.Size = New System.Drawing.Size(173, 39)
        Me.btnPurchaseOrders.TabIndex = 74
        Me.btnPurchaseOrders.Text = "Manage Purchases"
        Me.btnPurchaseOrders.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.OptionGroup = "navBar"
        Me.ButtonItem2.Text = "Inventory"
        '
        'NavigationPanePanel4
        '
        Me.NavigationPanePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.NavigationPanePanel4.Controls.Add(Me.btnResetPos)
        Me.NavigationPanePanel4.Controls.Add(Me.btnDisplay)
        Me.NavigationPanePanel4.Controls.Add(Me.btnPOSSettings)
        Me.NavigationPanePanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPanePanel4.Location = New System.Drawing.Point(1, 1)
        Me.NavigationPanePanel4.Name = "NavigationPanePanel4"
        Me.NavigationPanePanel4.ParentItem = Me.ButtonItem4
        Me.NavigationPanePanel4.Size = New System.Drawing.Size(186, 344)
        Me.NavigationPanePanel4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.NavigationPanePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.NavigationPanePanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.NavigationPanePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.NavigationPanePanel4.Style.GradientAngle = 90
        Me.NavigationPanePanel4.TabIndex = 5
        '
        'btnResetPos
        '
        Me.btnResetPos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnResetPos.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnResetPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPos.Image = CType(resources.GetObject("btnResetPos.Image"), System.Drawing.Image)
        Me.btnResetPos.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnResetPos.ImageTextSpacing = 3
        Me.btnResetPos.Location = New System.Drawing.Point(8, 94)
        Me.btnResetPos.Name = "btnResetPos"
        Me.btnResetPos.Size = New System.Drawing.Size(173, 39)
        Me.btnResetPos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnResetPos.TabIndex = 80
        Me.btnResetPos.Text = "Reset POS"
        Me.btnResetPos.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnDisplay
        '
        Me.btnDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDisplay.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Image = CType(resources.GetObject("btnDisplay.Image"), System.Drawing.Image)
        Me.btnDisplay.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnDisplay.ImageTextSpacing = 3
        Me.btnDisplay.Location = New System.Drawing.Point(8, 50)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(173, 39)
        Me.btnDisplay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDisplay.TabIndex = 79
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnPOSSettings
        '
        Me.btnPOSSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPOSSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnPOSSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOSSettings.Image = CType(resources.GetObject("btnPOSSettings.Image"), System.Drawing.Image)
        Me.btnPOSSettings.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnPOSSettings.ImageTextSpacing = 3
        Me.btnPOSSettings.Location = New System.Drawing.Point(8, 6)
        Me.btnPOSSettings.Name = "btnPOSSettings"
        Me.btnPOSSettings.Size = New System.Drawing.Size(173, 39)
        Me.btnPOSSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPOSSettings.TabIndex = 78
        Me.btnPOSSettings.Text = "POS Settings"
        Me.btnPOSSettings.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.OptionGroup = "navBar"
        Me.ButtonItem4.Text = "POS Settings"
        '
        'NavigationPanePanel3
        '
        Me.NavigationPanePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.NavigationPanePanel3.Controls.Add(Me.btnUserAccess)
        Me.NavigationPanePanel3.Controls.Add(Me.btnReprintReceipt)
        Me.NavigationPanePanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPanePanel3.Location = New System.Drawing.Point(1, 1)
        Me.NavigationPanePanel3.Name = "NavigationPanePanel3"
        Me.NavigationPanePanel3.ParentItem = Me.ButtonItem3
        Me.NavigationPanePanel3.Size = New System.Drawing.Size(186, 344)
        Me.NavigationPanePanel3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.NavigationPanePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.NavigationPanePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.NavigationPanePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.NavigationPanePanel3.Style.GradientAngle = 90
        Me.NavigationPanePanel3.TabIndex = 4
        '
        'btnUserAccess
        '
        Me.btnUserAccess.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUserAccess.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnUserAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAccess.Image = CType(resources.GetObject("btnUserAccess.Image"), System.Drawing.Image)
        Me.btnUserAccess.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnUserAccess.Location = New System.Drawing.Point(8, 6)
        Me.btnUserAccess.Name = "btnUserAccess"
        Me.btnUserAccess.Size = New System.Drawing.Size(173, 39)
        Me.btnUserAccess.TabIndex = 65
        Me.btnUserAccess.Text = "Set User Access"
        Me.btnUserAccess.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnReprintReceipt
        '
        Me.btnReprintReceipt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReprintReceipt.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnReprintReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReprintReceipt.Image = CType(resources.GetObject("btnReprintReceipt.Image"), System.Drawing.Image)
        Me.btnReprintReceipt.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnReprintReceipt.Location = New System.Drawing.Point(8, 46)
        Me.btnReprintReceipt.Name = "btnReprintReceipt"
        Me.btnReprintReceipt.Size = New System.Drawing.Size(173, 39)
        Me.btnReprintReceipt.TabIndex = 72
        Me.btnReprintReceipt.Text = "User Accounts"
        Me.btnReprintReceipt.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.OptionGroup = "navBar"
        Me.ButtonItem3.Text = "Manage Users"
        '
        'NavigationPanePanel5
        '
        Me.NavigationPanePanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.NavigationPanePanel5.Controls.Add(Me.btnGenerateReports)
        Me.NavigationPanePanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationPanePanel5.Location = New System.Drawing.Point(1, 1)
        Me.NavigationPanePanel5.Name = "NavigationPanePanel5"
        Me.NavigationPanePanel5.ParentItem = Me.ButtonItem5
        Me.NavigationPanePanel5.Size = New System.Drawing.Size(186, 344)
        Me.NavigationPanePanel5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.NavigationPanePanel5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.NavigationPanePanel5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.NavigationPanePanel5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.NavigationPanePanel5.Style.GradientAngle = 90
        Me.NavigationPanePanel5.TabIndex = 6
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerateReports.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnGenerateReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReports.Image = CType(resources.GetObject("btnGenerateReports.Image"), System.Drawing.Image)
        Me.btnGenerateReports.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnGenerateReports.ImageTextSpacing = 3
        Me.btnGenerateReports.Location = New System.Drawing.Point(8, 6)
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.Size = New System.Drawing.Size(173, 39)
        Me.btnGenerateReports.TabIndex = 86
        Me.btnGenerateReports.Text = "Generate Reports"
        Me.btnGenerateReports.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.OptionGroup = "navBar"
        Me.ButtonItem5.Text = "Reports"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(147, Byte), Integer)))
        '
        'mdiManagerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(973, 599)
        Me.Controls.Add(Me.NavigationPane1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiManagerDashboard"
        Me.Text = "POS Manager v.3.0.2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.NavigationPane1.ResumeLayout(False)
        Me.NavigationPanePanel1.ResumeLayout(False)
        Me.NavigationPanePanel2.ResumeLayout(False)
        Me.NavigationPanePanel4.ResumeLayout(False)
        Me.NavigationPanePanel3.ResumeLayout(False)
        Me.NavigationPanePanel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavigationPane1 As DevComponents.DotNetBar.NavigationPane
    Friend WithEvents NavigationPanePanel1 As DevComponents.DotNetBar.NavigationPanePanel
    Private WithEvents btnCategoies As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnSuppliers As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnDiscounts As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnItemMaintenance As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnCustomers As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents NavigationPanePanel5 As DevComponents.DotNetBar.NavigationPanePanel
    Private WithEvents btnGenerateReports As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents NavigationPanePanel3 As DevComponents.DotNetBar.NavigationPanePanel
    Private WithEvents btnUserAccess As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnReprintReceipt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents NavigationPanePanel4 As DevComponents.DotNetBar.NavigationPanePanel
    Private WithEvents btnPOSSettings As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents NavigationPanePanel2 As DevComponents.DotNetBar.NavigationPanePanel
    Private WithEvents btnInventory As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnPurchaseOrders As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitPOSManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnConsoDB As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnBackupDB As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnDisplay As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnResetPos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager

End Class
