Imports System.Windows.Forms

Public Class mdiManagerDashboard

    Public userType As Integer

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mdiManagerDashboard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub mdiManagerDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        frmReport.GetBusinessInfo()
    End Sub

    Private Sub btnItemMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemMaintenance.Click
        frmItemMaintenance.MdiParent = Me
        frmItemMaintenance.WindowState = FormWindowState.Maximized
        frmItemMaintenance.Show()
    End Sub

    Private Sub btnCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomers.Click
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        frmCustomer.MdiParent = Me
        frmCustomer.WindowState = FormWindowState.Maximized
        frmCustomer.Show()
    End Sub

    Private Sub btnDiscounts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDiscounts.Click
        frmDiscEntry.ShowDialog()
    End Sub

    Private Sub btnSuppliers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSuppliers.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub btnUserAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserAccess.Click
        frmAccessRoles.ShowDialog()
    End Sub

    Private Sub btnGenerateReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReports.Click
        frmReport.MdiParent = Me
        frmReport.WindowState = 2
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

    Private Sub btnReprintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprintReceipt.Click
        frmUsers.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutInfo.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub ExitPOSManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitPOSManagerToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        btnItemMaintenance.PerformClick()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        btnInventory.PerformClick()
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        btnGenerateReports.PerformClick()
    End Sub

    Private Sub btnConsoDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsoDB.Click
        frmConsolidateDB.ShowDialog()
    End Sub

    Private Sub btnBackupDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackupDB.Click
        frmDBMaintenance.ShowDialog()
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        frmDisplaySettings.ShowDialog()

    End Sub

    Private Sub btnResetPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetPos.Click
        frmResetPos.ShowDialog()
    End Sub
End Class
