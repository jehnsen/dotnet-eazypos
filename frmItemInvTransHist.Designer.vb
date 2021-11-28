<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemInvTransHist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemInvTransHist))
        Me.lblItemName = New DevComponents.DotNetBar.LabelX()
        Me.btnViewRep = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.lvTransaction = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblItemName
        '
        '
        '
        '
        Me.lblItemName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblItemName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblItemName.Location = New System.Drawing.Point(8, 12)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(557, 40)
        Me.lblItemName.TabIndex = 91
        Me.lblItemName.Text = "HOLCIM CEMENT KRAFT (RED)"
        '
        'btnViewRep
        '
        Me.btnViewRep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnViewRep.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnViewRep.Image = CType(resources.GetObject("btnViewRep.Image"), System.Drawing.Image)
        Me.btnViewRep.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnViewRep.Location = New System.Drawing.Point(627, 491)
        Me.btnViewRep.Name = "btnViewRep"
        Me.btnViewRep.Size = New System.Drawing.Size(120, 46)
        Me.btnViewRep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnViewRep.TabIndex = 89
        Me.btnViewRep.Text = "View as Report"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(28, 28)
        Me.btnCancel.Location = New System.Drawing.Point(755, 491)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 46)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 88
        Me.btnCancel.Text = "Cancel"
        '
        'lvTransaction
        '
        Me.lvTransaction.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lvTransaction.Border.Class = "ListViewBorder"
        Me.lvTransaction.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvTransaction.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader4, Me.ColumnHeader12, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader9, Me.ColumnHeader8})
        Me.lvTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTransaction.ForeColor = System.Drawing.Color.Black
        Me.lvTransaction.FullRowSelect = True
        Me.lvTransaction.GridLines = True
        Me.lvTransaction.Location = New System.Drawing.Point(5, 71)
        Me.lvTransaction.Name = "lvTransaction"
        Me.lvTransaction.Size = New System.Drawing.Size(870, 414)
        Me.lvTransaction.TabIndex = 87
        Me.lvTransaction.UseCompatibleStateImageBehavior = False
        Me.lvTransaction.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DATE"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "RECEIPT NO."
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "BEGINNING QTY"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 140
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SALES"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "PURCHASES"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "STOCK IN"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "STOCK OUT"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "RETURNED"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ADJUSTMENT"
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ENDING QTY"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 105
        '
        'frmItemInvTransHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(884, 545)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.btnViewRep)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lvTransaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemInvTransHist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction History"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblItemName As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnViewRep As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lvTransaction As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
End Class
