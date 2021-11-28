Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmViewReceivedPurchases

    Private Sub frmViewReceivedPurchases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_PurchasedItems()
        Get_ReceivedPurchaseHeader()
    End Sub

    Friend Sub Get_PurchasedItems()

        cmd = New SqlCommand("SELECT PD.RECORDNO,P.PLU, P.Prod_Description,P.Unit, CONVERT(varchar, CAST(pd.cost AS money), 1), PD.Qty_Received, " & _
                             "CONVERT(varchar, CAST(pd.amount AS money), 1) FROM dbo.PurchaseDelivery_Details PD " & _
                            "INNER JOIN dbo.Products P ON PD.ProductID=P.ProductID WHERE pd.pd_no = '" & frmPurchases.dgrPurchases.CurrentRow.Cells(0).Value & "' ", con)


        connect()
        dr = cmd.ExecuteReader()
        lvItems.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item(1).ToString())
            Dim b = (dr.Item(2).ToString())
            Dim c = (dr.Item(3).ToString())
            Dim d = (dr.Item(4).ToString())
            Dim e = (dr.Item(5).ToString())
            Dim f = (dr.Item(6).ToString())

            Dim lv As ListViewItem = lvItems.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(e)
            lv.SubItems.Add(f)

        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()

    End Sub

    Friend Sub Get_ReceivedPurchaseHeader()
        connect()
        cmd = New SqlCommand("SELECT DR_NO,OR_NO,SUPPLIER_NAME, TOTAL_AMNT,DATE_RECEIVED, ISNULL(RECEIVED_BY, '') as 'RECEIVER', ISNULL(CHECKED_BY,'') AS 'CHECKER', ISNULL(REMARKS,'') AS 'REMARKS' FROM PURCHASEDELIVERIES WHERE PD_NO = '" & frmPurchases.dgrPurchases.CurrentRow.Cells(0).Value & "'   ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            lblSupplier.Text = dr("SUPPLIER_NAME")
            lblDRNo.Text = dr("DR_NO")
            lblDate.Text = dr("DATE_RECEIVED")
            lblReceivedBy.Text = dr("RECEIVER")
            lblORNo.Text = dr("OR_NO")
            lblDelBy.Text = dr("CHECKER")
            lblRemarks.Text = dr("REMARKS")
        End If
        disconnect()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmReport.GetBusinessInfo()
        frmReport.Generate_PurchaseItemsDetails()
        frmReport.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class