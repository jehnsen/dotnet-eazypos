Imports System.Data.SqlClient

Public Class frmViewInvoiceItems

    Private Sub frmViewInvoiceItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_ItemReceivables()
        Text = "View Items - " & frmReceivables.dgrReceivables.CurrentRow.Cells(0).Value
    End Sub

    Friend Sub Get_ItemReceivables()

        cmd = New SqlCommand("SELECT T.RECORDID,P.PROD_DESCRIPTION,P.UNIT,T.PRICE,T.QUANTITY,T.RECEIVABLES " & _
                                "FROM dbo.[Transaction] T INNER JOIN dbo.Products P ON T.ProductId=P.ItemID " & _
                                "WHERE INVOICENO= '" & frmReceivables.dgrReceivables.CurrentRow.Cells(0).Value & "' ", con)

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrReceivables
            .Rows.Clear()
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
            End While
        End With
        dr.Close()
        disconnect()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class