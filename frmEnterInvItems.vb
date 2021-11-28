Imports System.Globalization
Imports System.Data.SqlClient

Public Class frmEnterInvItems
    Friend Inv_CustID As Integer
    Friend Inv_ItemId As Integer
    Friend Inv_Amount As Decimal

    Friend Sub Get_InvoiceItems()
        cmd = New SqlCommand("SELECT T.RECORDID,CONVERT(VARCHAR(10),T.DATETIME,110) as 'DATETIME',T.INVOICENO,P.PROD_DESCRIPTION,T.PRICE,T.QUANTITY,T.AMOUNT + T.RECEIVABLES AS 'RECEIVABLES',T.CUST_RBALANCE FROM DBO.[TRANSACTION] T " & _
                             "INNER JOIN DBO.PRODUCTS P ON T.PRODUCTID = P.PRODUCTID WHERE T.CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' " & _
                             "AND T.PRODUCTID NOT IN (1,2,3,4,5,6) AND T.PAYMENTTYPE = 2  AND T.CHARGESTATUS = 0 ORDER BY T.DATETIME ASC, T.RECORDID ASC", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrInvoiceItems
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
                .Rows(.Rows.Count - 1).Cells(6).Value = dr(6)
                .Rows(.Rows.Count - 1).Cells(7).Value = dr(7)
            End While
        End With
        dr.Close()
        disconnect()

    End Sub

    Friend Sub Get_CustInfo()
        connect()
        cmd = New SqlCommand("SELECT STARTINGBAL FROM DBO.CUSTOMERS WHERE CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                txtBal.Text = dr("STARTINGBAL")

            Catch ex As Exception

            End Try
        End If
        disconnect()
    End Sub

    Private Sub frmEnterInvItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.J And e.Modifiers = Keys.Control Then
            Me.Height = 600
        ElseIf e.KeyCode = Keys.K And e.Modifiers = Keys.Control Then
            Me.Height = 145
        End If
    End Sub

    Private Sub frmEnterInvItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inv_CustID = frmCustomer.lvUsers.SelectedItems(0).Text

        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MM-dd-yyyy hh:mm tt"
        dtpDate.Value.ToString("MM-dd-yyyy hh:mm tt")

        Text = frmCustomer.lvUsers.SelectedItems(0).SubItems(1).Text & " " & frmCustomer.lvUsers.SelectedItems(0).SubItems(2).Text
        txtRBAL.Text = frmCustomer.lvUsers.SelectedItems(0).SubItems(4).Text


        Get_InvoiceItems()
        Get_CustInfo()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        connect()
        cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,RECEIPTNO,DATETIME,SESSIONID,S_IN,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
                                    "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
                                    "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_OUT,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY,DAILYADJ,COLLECTIONAMNT,REMARKS) VALUES " & _
                                    "('" & Inv_ItemId & "','','" & dtpDate.Text & "',0,0,2,0,0,0,0,'" & terminal_no & "','" & branch_id & "',0,0,0,0,0,'','',0,0,0, " & _
                                    "'" & Inv_CustID & "','" & cust_name & "','',0,0,'" & txtInvoice.Text & "',0,0,0,0,'" & txtPrice.Text & "','" & txtQTY.Text & "','" & txtAmnt.Text & "',0,0,0,'')", con)
        cmd.ExecuteNonQuery()
        disconnect()

        txtDesc.Clear()
        txtQTY.Clear()
        txtPrice.Clear()

        MsgBox("Item successfully saved!", vbInformation, "Save")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmBrowseItems.select_mode = "invoice"
        frmBrowseItems.ShowDialog()
    End Sub

    Private Sub txtQTY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQTY.TextChanged
        Try
            Inv_Amount = txtPrice.Text * txtQTY.Text
            txtAmnt.Text = Inv_Amount.ToString("N2", CultureInfo.InvariantCulture)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        connect()
        'cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,RECEIPTNO,DATETIME,SESSIONID,S_IN,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
        '                            "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
        '                            "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_OUT,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY,DAILYADJ,COLLECTIONAMNT,EXPENSES,REMARKS) VALUES " & _
        '                            "(5,0,'" & dtpDate.Text & "',0,0,0,0,0,0,0,'" & terminal_no & "','" & branch_id & "',0,0,0,0,0,'','',0,0,0, " & _
        '                            "'" & Inv_CustID & "','" & cust_name & "','',0,0,'00001','" & txtBal.Text & "',0,0,0,0,0,0,0,0,0,0,'')", con)
        'cmd.ExecuteNonQuery()
        cmd = New SqlCommand("UPDATE DBO.CUSTOMERS SET STARTINGBAL = '" & txtBal.Text & "' WHERE CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()

        disconnect()
        MsgBox("Starting Balance successfully saved!", vbInformation, "Save")
        txtBal.Clear()
        txtInvoice.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        connect()
        cmd = New SqlCommand("UPDATE DBO.CUSTOMERS SET BALANCE = '" & txtRBAL.Text & "' WHERE CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        MsgBox("Starting Balance successfully saved!", vbInformation, "Save")
        txtBal.Clear()
        txtInvoice.Clear()
    End Sub

    Private Sub dgrInvoiceItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrInvoiceItems.CellClick
        Try
            txtRunBal.Text = dgrInvoiceItems.CurrentRow.Cells(7).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgrInvoiceItems_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrInvoiceItems.CellEndEdit

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        connect()
        cmd = New SqlCommand("UPDATE DBO.[TRANSACTION] SET CUST_RBALANCE = '" & txtRunBal.Text & "' WHERE RECORDID = '" & dgrInvoiceItems.CurrentRow.Cells(0).Value & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        Get_InvoiceItems()
        dgrInvoiceItems.Refresh()

        txtRunBal.Clear()
    End Sub

End Class