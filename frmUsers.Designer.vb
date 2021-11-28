<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.btnUserUpdate = New MBGlassStyleButton.MBGlassButton()
        Me.lvUsers = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelUserDetails = New System.Windows.Forms.Panel()
        Me.txtUser_Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserPasword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboUserType = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnUserClose = New MBGlassStyleButton.MBGlassButton()
        Me.btnUserNew = New MBGlassStyleButton.MBGlassButton()
        Me.btnUserActivate = New MBGlassStyleButton.MBGlassButton()
        Me.btnUserSave = New MBGlassStyleButton.MBGlassButton()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MbGlassButton1 = New MBGlassStyleButton.MBGlassButton()
        Me.PanelUserDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUserUpdate
        '
        Me.btnUserUpdate.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.btnUserUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUserUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserUpdate.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserUpdate.FlatAppearance.BorderSize = 0
        Me.btnUserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserUpdate.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.btnUserUpdate.Image = CType(resources.GetObject("btnUserUpdate.Image"), System.Drawing.Image)
        Me.btnUserUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserUpdate.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnUserUpdate.Location = New System.Drawing.Point(627, 277)
        Me.btnUserUpdate.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnUserUpdate.Name = "btnUserUpdate"
        Me.btnUserUpdate.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUserUpdate.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnUserUpdate.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserUpdate.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserUpdate.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.btnUserUpdate.Size = New System.Drawing.Size(110, 47)
        Me.btnUserUpdate.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.btnUserUpdate.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.btnUserUpdate.TabIndex = 65
        Me.btnUserUpdate.Text = "Update"
        Me.btnUserUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserUpdate.UseVisualStyleBackColor = False
        '
        'lvUsers
        '
        '
        '
        '
        Me.lvUsers.Border.Class = "ListViewBorder"
        Me.lvUsers.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvUsers.FullRowSelect = True
        Me.lvUsers.GridLines = True
        Me.lvUsers.Location = New System.Drawing.Point(3, 61)
        Me.lvUsers.Name = "lvUsers"
        Me.lvUsers.Size = New System.Drawing.Size(496, 318)
        Me.lvUsers.TabIndex = 60
        Me.lvUsers.UseCompatibleStateImageBehavior = False
        Me.lvUsers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "UserID"
        Me.ColumnHeader8.Width = 65
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Firstname"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Lastname"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Username"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "User Type"
        Me.ColumnHeader12.Width = 100
        '
        'PanelUserDetails
        '
        Me.PanelUserDetails.BackColor = System.Drawing.Color.Transparent
        Me.PanelUserDetails.Controls.Add(Me.txtUser_Username)
        Me.PanelUserDetails.Controls.Add(Me.Label1)
        Me.PanelUserDetails.Controls.Add(Me.txtUserPasword)
        Me.PanelUserDetails.Controls.Add(Me.Label14)
        Me.PanelUserDetails.Controls.Add(Me.txtStatus)
        Me.PanelUserDetails.Controls.Add(Me.Label17)
        Me.PanelUserDetails.Controls.Add(Me.cboUserType)
        Me.PanelUserDetails.Controls.Add(Me.Label18)
        Me.PanelUserDetails.Controls.Add(Me.txtLastname)
        Me.PanelUserDetails.Controls.Add(Me.Label19)
        Me.PanelUserDetails.Controls.Add(Me.txtFirstname)
        Me.PanelUserDetails.Controls.Add(Me.Label20)
        Me.PanelUserDetails.Controls.Add(Me.txtUserID)
        Me.PanelUserDetails.Controls.Add(Me.Label21)
        Me.PanelUserDetails.Enabled = False
        Me.PanelUserDetails.Location = New System.Drawing.Point(505, 61)
        Me.PanelUserDetails.Name = "PanelUserDetails"
        Me.PanelUserDetails.Size = New System.Drawing.Size(352, 205)
        Me.PanelUserDetails.TabIndex = 59
        '
        'txtUser_Username
        '
        Me.txtUser_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser_Username.Location = New System.Drawing.Point(86, 117)
        Me.txtUser_Username.Name = "txtUser_Username"
        Me.txtUser_Username.Size = New System.Drawing.Size(263, 22)
        Me.txtUser_Username.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Username"
        '
        'txtUserPasword
        '
        Me.txtUserPasword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPasword.Location = New System.Drawing.Point(86, 145)
        Me.txtUserPasword.Name = "txtUserPasword"
        Me.txtUserPasword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtUserPasword.Size = New System.Drawing.Size(263, 22)
        Me.txtUserPasword.TabIndex = 8
        Me.txtUserPasword.UseSystemPasswordChar = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Password"
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(86, 173)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(263, 22)
        Me.txtStatus.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 16)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Status"
        '
        'cboUserType
        '
        Me.cboUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserType.FormattingEnabled = True
        Me.cboUserType.Items.AddRange(New Object() {"Cashier", "Manager"})
        Me.cboUserType.Location = New System.Drawing.Point(86, 87)
        Me.cboUserType.Name = "cboUserType"
        Me.cboUserType.Size = New System.Drawing.Size(263, 24)
        Me.cboUserType.TabIndex = 6
        Me.cboUserType.Text = "Cashier"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "User Type"
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(86, 59)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(263, 22)
        Me.txtLastname.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 16)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Lastname"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(86, 31)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(263, 22)
        Me.txtFirstname.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 16)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Firstname"
        '
        'txtUserID
        '
        Me.txtUserID.Enabled = False
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(86, 3)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(263, 22)
        Me.txtUserID.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 16)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "User ID"
        '
        'btnUserClose
        '
        Me.btnUserClose.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.btnUserClose.BackColor = System.Drawing.Color.Transparent
        Me.btnUserClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserClose.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserClose.FlatAppearance.BorderSize = 0
        Me.btnUserClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserClose.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.btnUserClose.Image = CType(resources.GetObject("btnUserClose.Image"), System.Drawing.Image)
        Me.btnUserClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserClose.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnUserClose.Location = New System.Drawing.Point(743, 330)
        Me.btnUserClose.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnUserClose.Name = "btnUserClose"
        Me.btnUserClose.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUserClose.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnUserClose.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserClose.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserClose.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.btnUserClose.Size = New System.Drawing.Size(110, 47)
        Me.btnUserClose.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.btnUserClose.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.btnUserClose.TabIndex = 64
        Me.btnUserClose.Text = "Close"
        Me.btnUserClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserClose.UseVisualStyleBackColor = False
        '
        'btnUserNew
        '
        Me.btnUserNew.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.btnUserNew.BackColor = System.Drawing.Color.Transparent
        Me.btnUserNew.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserNew.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserNew.FlatAppearance.BorderSize = 0
        Me.btnUserNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserNew.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.btnUserNew.Image = CType(resources.GetObject("btnUserNew.Image"), System.Drawing.Image)
        Me.btnUserNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserNew.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnUserNew.Location = New System.Drawing.Point(511, 277)
        Me.btnUserNew.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnUserNew.Name = "btnUserNew"
        Me.btnUserNew.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUserNew.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnUserNew.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserNew.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserNew.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.btnUserNew.Size = New System.Drawing.Size(110, 47)
        Me.btnUserNew.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.btnUserNew.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.btnUserNew.TabIndex = 62
        Me.btnUserNew.Text = "New"
        Me.btnUserNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserNew.UseVisualStyleBackColor = False
        '
        'btnUserActivate
        '
        Me.btnUserActivate.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.btnUserActivate.BackColor = System.Drawing.Color.Transparent
        Me.btnUserActivate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserActivate.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserActivate.FlatAppearance.BorderSize = 0
        Me.btnUserActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserActivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserActivate.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.btnUserActivate.Image = CType(resources.GetObject("btnUserActivate.Image"), System.Drawing.Image)
        Me.btnUserActivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserActivate.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnUserActivate.Location = New System.Drawing.Point(626, 330)
        Me.btnUserActivate.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnUserActivate.Name = "btnUserActivate"
        Me.btnUserActivate.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUserActivate.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnUserActivate.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserActivate.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserActivate.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.btnUserActivate.Size = New System.Drawing.Size(110, 47)
        Me.btnUserActivate.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.btnUserActivate.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.btnUserActivate.TabIndex = 63
        Me.btnUserActivate.Text = "Activate"
        Me.btnUserActivate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserActivate.UseVisualStyleBackColor = False
        '
        'btnUserSave
        '
        Me.btnUserSave.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.btnUserSave.BackColor = System.Drawing.Color.Transparent
        Me.btnUserSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserSave.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserSave.FlatAppearance.BorderSize = 0
        Me.btnUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserSave.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.btnUserSave.Image = CType(resources.GetObject("btnUserSave.Image"), System.Drawing.Image)
        Me.btnUserSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserSave.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnUserSave.Location = New System.Drawing.Point(511, 330)
        Me.btnUserSave.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.btnUserSave.Name = "btnUserSave"
        Me.btnUserSave.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUserSave.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnUserSave.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserSave.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserSave.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.btnUserSave.Size = New System.Drawing.Size(110, 47)
        Me.btnUserSave.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.btnUserSave.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.btnUserSave.TabIndex = 61
        Me.btnUserSave.Text = "Save"
        Me.btnUserSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserSave.UseVisualStyleBackColor = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(77, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(130, 32)
        Me.LabelX1.TabIndex = 67
        Me.LabelX1.Text = "User Accounts"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'MbGlassButton1
        '
        Me.MbGlassButton1.Arrow = MBGlassStyleButton.MBGlassButton.MB_Arrow.None
        Me.MbGlassButton1.BackColor = System.Drawing.Color.Transparent
        Me.MbGlassButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MbGlassButton1.BaseStrokeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MbGlassButton1.FlatAppearance.BorderSize = 0
        Me.MbGlassButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MbGlassButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MbGlassButton1.GroupPosition = MBGlassStyleButton.MBGlassButton.MB_GroupPos.None
        Me.MbGlassButton1.Image = CType(resources.GetObject("MbGlassButton1.Image"), System.Drawing.Image)
        Me.MbGlassButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MbGlassButton1.ImageSize = New System.Drawing.Size(24, 24)
        Me.MbGlassButton1.Location = New System.Drawing.Point(743, 277)
        Me.MbGlassButton1.MenuListPosition = New System.Drawing.Point(0, 0)
        Me.MbGlassButton1.Name = "MbGlassButton1"
        Me.MbGlassButton1.OnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.MbGlassButton1.OnStrokeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.MbGlassButton1.PressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.PressStrokeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MbGlassButton1.ShowBase = MBGlassStyleButton.MBGlassButton.MB_ShowBase.Yes
        Me.MbGlassButton1.Size = New System.Drawing.Size(110, 47)
        Me.MbGlassButton1.SplitButton = MBGlassStyleButton.MBGlassButton.MB_SplitButton.No
        Me.MbGlassButton1.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Bottom
        Me.MbGlassButton1.TabIndex = 68
        Me.MbGlassButton1.Text = "Edit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.MbGlassButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MbGlassButton1.UseVisualStyleBackColor = False
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(864, 383)
        Me.Controls.Add(Me.MbGlassButton1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnUserUpdate)
        Me.Controls.Add(Me.lvUsers)
        Me.Controls.Add(Me.PanelUserDetails)
        Me.Controls.Add(Me.btnUserClose)
        Me.Controls.Add(Me.btnUserNew)
        Me.Controls.Add(Me.btnUserActivate)
        Me.Controls.Add(Me.btnUserSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        Me.PanelUserDetails.ResumeLayout(False)
        Me.PanelUserDetails.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUserUpdate As MBGlassStyleButton.MBGlassButton
    Friend WithEvents lvUsers As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanelUserDetails As System.Windows.Forms.Panel
    Friend WithEvents txtUser_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserPasword As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboUserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnUserClose As MBGlassStyleButton.MBGlassButton
    Friend WithEvents btnUserNew As MBGlassStyleButton.MBGlassButton
    Friend WithEvents btnUserActivate As MBGlassStyleButton.MBGlassButton
    Friend WithEvents btnUserSave As MBGlassStyleButton.MBGlassButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MbGlassButton1 As MBGlassStyleButton.MBGlassButton
End Class
