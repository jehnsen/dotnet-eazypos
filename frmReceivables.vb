Imports System.Data.SqlClient

Public Class frmReceivables

    Private Sub frmReceivables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MM-dd-yyyy"
        dtpDate.Value.ToString("MM-dd-yyyy")

        Get_Receivables()
        GetTransactionHistory()
        GetTotalPurchasedAmount()
    End Sub

    Friend Sub Get_Receivables()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("SELECT INVOICENO,RECEIVABLES=ISNULL(SUM(RECEIVABLES),0),INVOICEDATE=MAX(CONVERT(VARCHAR(10), DATETIME, 101)),CUSTOMERNAME=MAX(CUSTOMERNAME), " & _
                                 "CASE WHEN MAX(CHARGESTATUS) = 1 THEN 'PAID' WHEN MAX(CHARGESTATUS) = 2 THEN 'CLOSED' ELSE '' END AS 'CHARGESTATUS' FROM dbo.[Transaction] " & _
                                 "WHERE CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' AND PAYMENTTYPE = 2 AND  CHARGESTATUS = 0 GROUP BY INVOICENO " & _
                                 "ORDER BY INVOICEDATE DESC", con)
        Else
            cmd = New SqlCommand("SELECT INVOICENO,RECEIVABLES=ISNULL(SUM(RECEIVABLES),0),INVOICEDATE=MAX(CONVERT(VARCHAR(10), DATETIME, 101)),CUSTOMERNAME=MAX(CUSTOMERNAME)," & _
                                 "CASE WHEN MAX(CHARGESTATUS) = 1 THEN 'PAID' WHEN MAX(CHARGESTATUS) = 2 THEN 'CLOSED' ELSE '' END AS 'CHARGESTATUS' FROM dbo.[Transaction] " & _
                                 "WHERE CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' AND PAYMENTTYPE = 2 AND INVOICENO LIKE '%" & txtSearch.Text & "%' AND CHARGESTATUS = 0 " & _
                                 "GROUP BY INVOICENO ORDER BY INVOICEDATE DESC", con)
        End If

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
            End While
        End With
        dr.Close()
        disconnect()

        If dgrReceivables.RowCount = 0 Then
            lblInvoiceNo.Text = ""
            lvInvItems.Items.Clear()
        Else
            Try
                lblInvoiceNo.Text = "Invoice No. " & dgrReceivables.CurrentRow.Cells(0).Value
                GetInvoiceItems()
            Catch ex As Exception

            End Try

        End If

    End Sub

    Friend Sub GetInvoiceItems()
        cmd = New SqlCommand("select prod_description,unit,price,quantity,remarks from view_transaction where invoiceno = '" & dgrReceivables.CurrentRow.Cells(0).Value & "' and productid > 6", con)
        connect()
        dr = cmd.ExecuteReader
        lvInvItems.Items.Clear()
        Do While dr.Read
            Dim a = (dr.Item("prod_description").ToString())
            Dim b = (dr.Item("unit").ToString())
            Dim c = (dr.Item("price").ToString())
            Dim d = (dr.Item("quantity").ToString())
            Dim e = (dr.Item("remarks").ToString())

            Dim lv As ListViewItem = lvInvItems.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(e)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Friend Sub GetTransactionHistory()
        cmd = New SqlCommand("select receiptno,prod_description,unit,price,quantity,amount from view_transaction where customerid = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ", con)
        connect()
        dr = cmd.ExecuteReader
        lvTransactionHistory.Items.Clear()
        Do While dr.Read
            Dim a = (dr.Item("receiptno").ToString())
            Dim b = (dr.Item("prod_description").ToString())
            Dim c = (dr.Item("unit").ToString())
            Dim d = (dr.Item("price").ToString())
            Dim e = (dr.Item("quantity").ToString())
            Dim f = (dr.Item("amount").ToString())

            Dim lv As ListViewItem = lvTransactionHistory.Items.Add(a)
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

    Friend Sub GetTotalPurchasedAmount()
        connect()
        cmd = New SqlCommand("select isnull(sum(amount), 0) from dbo.[transaction] where customerid = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' and paymenttype = 1", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            lblTotalPurchasedAmount.Text = "Total Purchased amount: " & Format(dr(0), "##,##0.00")
        End If
        disconnect()
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click

        If dgrReceivables.RowCount = 0 Then
            MsgBox("No Receivables!", MessageBoxIcon.Stop, "")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to mark this invoice as PAID?", "Close Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            connect()
            cmd = New SqlCommand("update dbo.[transaction] set chargestatus = 1 where invoiceno = '" & dgrReceivables.CurrentRow.Cells(0).Value & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("Invoice successfully closed!", vbInformation, "Close Invoice")

            Get_Receivables()
            dgrReceivables.Refresh()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmMain.Hide()
        Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Get_Receivables()
    End Sub

    Private Sub dgrReceivables_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrReceivables.CellClick
        lblInvoiceNo.Text = "Invoice No. " & dgrReceivables.CurrentRow.Cells(0).Value
        GetInvoiceItems()
        lvInvItems.Refresh()
    End Sub

    Private Sub dtpDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDate.TextChanged
        Get_Receivables()
    End Sub

    Private Sub btnGenReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenReport.Click
        frmMain.Hide()
        'frmReport.Generate_CustomerAccnt()
        frmReport.Generate_CustomerLedger()
        frmReport.Show()
    End Sub

End Class