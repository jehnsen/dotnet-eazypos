<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessRoles
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
        Me.components = New System.ComponentModel.Container()
        Me.lvAccessRoles = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.access = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btnAllow = New DevComponents.DotNetBar.ButtonX()
        Me.btnRestrict = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'lvAccessRoles
        '
        Me.lvAccessRoles.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lvAccessRoles.Border.Class = "ListViewBorder"
        Me.lvAccessRoles.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvAccessRoles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.access})
        Me.lvAccessRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAccessRoles.FullRowSelect = True
        Me.lvAccessRoles.GridLines = True
        Me.lvAccessRoles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvAccessRoles.Location = New System.Drawing.Point(3, 49)
        Me.lvAccessRoles.Name = "lvAccessRoles"
        Me.lvAccessRoles.Size = New System.Drawing.Size(496, 382)
        Me.lvAccessRoles.TabIndex = 53
        Me.lvAccessRoles.UseCompatibleStateImageBehavior = False
        Me.lvAccessRoles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "#"
        Me.ColumnHeader6.Width = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Module"
        Me.ColumnHeader7.Width = 180
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Functions"
        Me.ColumnHeader8.Width = 150
        '
        'access
        '
        Me.access.Text = "Access"
        Me.access.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.access.Width = 100
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'btnAllow
        '
        Me.btnAllow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAllow.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnAllow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllow.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnAllow.Location = New System.Drawing.Point(330, 5)
        Me.btnAllow.Name = "btnAllow"
        Me.btnAllow.Size = New System.Drawing.Size(79, 38)
        Me.btnAllow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAllow.TabIndex = 55
        Me.btnAllow.Text = "Allow"
        '
        'btnRestrict
        '
        Me.btnRestrict.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRestrict.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnRestrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestrict.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.btnRestrict.Location = New System.Drawing.Point(415, 5)
        Me.btnRestrict.Name = "btnRestrict"
        Me.btnRestrict.Size = New System.Drawing.Size(85, 38)
        Me.btnRestrict.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRestrict.TabIndex = 54
        Me.btnRestrict.Text = "Restrict"
        '
        'frmAccessRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 441)
        Me.Controls.Add(Me.btnAllow)
        Me.Controls.Add(Me.btnRestrict)
        Me.Controls.Add(Me.lvAccessRoles)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAccessRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Access Roles"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvAccessRoles As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents access As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAllow As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRestrict As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class
