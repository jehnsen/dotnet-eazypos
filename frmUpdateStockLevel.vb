Imports System.Data.SqlClient

Public Class frmUpdateStockLevel

    Private Sub frmUpdateStockLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtReorder.Text = frmInventory.txtReorder.Text
        txtmaxstock.Text = frmInventory.txtmaxstock.Text
        txtminstock.Text = frmInventory.txtminstock.Text
        Text = frmInventory.dgrItems.CurrentRow.Cells(1).Value
        txtReorder.Focus()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        connect()
        cmd = New SqlCommand("UPDATE DBO.PRODUCTS SET REORDERPOINT = '" & txtReorder.Text & "',MAXLEVEL = '" & txtmaxstock.Text & "',MINLEVEL = '" & txtminstock.Text & "' WHERE PRODUCTID = '" & frmInventory.dgrItems.CurrentRow.Cells(0).Value & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        frmInventory.GetItemDetails()
        frmInventory.GetItems()
        frmInventory.dgrItems.Update()
        Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()
    End Sub
End Class