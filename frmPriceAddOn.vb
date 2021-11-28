Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmPriceAddOn

    Dim x As Decimal

    Private Sub frmPriceAddOn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX1.PerformClick()
        End If
    End Sub

    Private Sub frmPriceAddOn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = "EDIT PRICE - " & frmMain.dgrTransaction.CurrentRow.Cells(2).Value

        x = frmMain.dgrTransaction.CurrentRow.Cells(4).Value

        txtPrice.Text = x.ToString("N2", CultureInfo.InvariantCulture)

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        connect()
        cmd = New SqlCommand("update transaction_temp set price= '" & txtPrice.Text & "', " & _
                             "amount = '" & txtPrice.Text & "' where recordid = '" & frmMain.dgrTransaction.CurrentRow.Cells(0).Value & "'", con)
        cmd.ExecuteNonQuery()
        disconnect()

        frmMain.Transaction()
        frmMain.dgrTransaction.Refresh()
        Close()
    End Sub

End Class