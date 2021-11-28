Public Class frmManagerDashboard

    Private Sub frmManagerDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'frmSalesDashboard.MdiParent = Me
        'frmSalesDashboard.WindowState = FormWindowState.Maximized
        'frmSalesDashboard.Show()
    End Sub

    Private Sub btnItemMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemMaintenance.Click
        frmItemMaintenance.ShowDialog()
    End Sub

    Private Sub btnCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomers.Click
        frmCustomer.ShowDialog()
    End Sub

    Private Sub btnDiscounts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDiscounts.Click
        frmDiscount.ShowDialog()
    End Sub

    Private Sub btnSuppliers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSuppliers.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub btnUserAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserAccess.Click
        frmAccessRoles.MdiParent = Me
        frmAccessRoles.Show()
    End Sub

    Private Sub btnGenerateReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReports.Click
        frmReport.MdiParent = Me
        'frmReport.WindowState = FormWindowState.Maximized
        frmReport.Show()
    End Sub

    Private Sub btnCategoies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoies.Click
        frmCategory.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmInventory.MdiParent = Me
        frmInventory.WindowState = FormWindowState.Maximized
        frmInventory.Show()
    End Sub
    Private Sub btnPurchaseOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchaseOrders.Click
        frmPurchases.MdiParent = Me
        frmPurchases.WindowState = FormWindowState.Maximized
        frmPurchases.Show()
    End Sub

 
    Private Sub btnPOSSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOSSettings.Click
        frmTerminal.ShowDialog()
    End Sub
End Class