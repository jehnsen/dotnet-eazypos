Imports System.Data.SqlClient

Public Class frmReturnQty

    Private Sub frmReturnQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub

    Private Sub frmReturnQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQTY.Text = frmViewReturned.lvItems.SelectedItems(0).SubItems(3).Text
        lblProduct.Text = frmViewReturned.lvItems.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtQTY.Text > frmViewReturned.lvItems.SelectedItems(0).SubItems(3).Text Then
            MsgBox("Invalid Quantity", vbExclamation, "")
        Else
            connect()
            
            cmd = New SqlCommand(" delete from returned_items where productid = '" & frmViewReturned.lvItems.SelectedItems(0).Text & "' " & _
                                 " and receiptno = '" & frmViewReturned.lvItems.SelectedItems(0).SubItems(1).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            frmViewReturned.GetReturnedItems()
            frmViewReturned.Refresh()
            Me.Close()
        End If

    End Sub
End Class