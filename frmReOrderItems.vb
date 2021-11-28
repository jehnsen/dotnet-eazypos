Imports System.Data.SqlClient

Public Class frmReOrderItems

    Private Sub frmReOrderItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_ReOrderItems()
    End Sub

    Friend Sub Get_ReOrderItems()
        cmd = New SqlCommand("SELECT PRODUCTID,PROD_DESCRIPTION, QUANTITY = CAST(QUANTITY as INT) ,REORDERPOINT FROM PRODUCTS WHERE (QUANTITY <= 0 OR QUANTITY <= REORDERPOINT) AND PRODUCTID NOT IN (1,2,3,4,5,6)", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrSales
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
            End While
        End With
        dr.Close()
        disconnect()

    End Sub

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        Close()
    End Sub
End Class