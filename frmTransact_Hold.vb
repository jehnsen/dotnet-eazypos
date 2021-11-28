Imports System.Data.SqlClient

Public Class frmTransact_Hold

    Private Sub frmTransact_Hold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRecall()
    End Sub

    Friend Sub Hold_Transaction()
        For i As Integer = 0 To frmMain.dgrTransaction.Rows.Count - 1
            connect()
            Dim cmd As New SqlCommand()
            cmd.Connection = con

            cmd.CommandText = "insert into transaction_hold (transactionno,customername,linenumber,productid,prod_description,quantity,price,amount,discount,discountrate,vat,vatableamount,category,department,remarks) values " & _
                             "(@transactionno,@cust_name,@linenumber,@productid,@prod_description,@quantity,@price,@amount,@discount,@discountrate,@vat,@vatableamount,@category,@department,@remarks) "

            cmd.Parameters.AddWithValue("@transactionno", transaction_no)
            cmd.Parameters.AddWithValue("@cust_name", cust_name)
            cmd.Parameters.AddWithValue("@linenumber", frmMain.dgrTransaction.Rows(i).Cells(0).Value)
            cmd.Parameters.AddWithValue("@productid", frmMain.dgrTransaction.Rows(i).Cells(1).Value)
            cmd.Parameters.AddWithValue("@prod_description", convertQuotes(frmMain.dgrTransaction.Rows(i).Cells(2).Value))
            cmd.Parameters.AddWithValue("@quantity", frmMain.dgrTransaction.Rows(i).Cells(3).Value)
            cmd.Parameters.AddWithValue("@price", frmMain.dgrTransaction.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@amount", frmMain.dgrTransaction.Rows(i).Cells(5).Value)
            cmd.Parameters.AddWithValue("@discount", frmMain.dgrTransaction.Rows(i).Cells(6).Value)
            cmd.Parameters.AddWithValue("@discountrate", frmMain.dgrTransaction.Rows(i).Cells(8).Value)
            cmd.Parameters.AddWithValue("@vat", frmMain.dgrTransaction.Rows(i).Cells(7).Value)
            cmd.Parameters.AddWithValue("@vatableamount", frmMain.dgrTransaction.Rows(i).Cells(8).Value)
            cmd.Parameters.AddWithValue("@category", frmMain.dgrTransaction.Rows(i).Cells(9).Value)
            cmd.Parameters.AddWithValue("@department", frmMain.dgrTransaction.Rows(i).Cells(10).Value)
            cmd.Parameters.AddWithValue("@remarks", convertQuotes(txtRemarks.Text))
            cmd.ExecuteNonQuery()

        Next
        disconnect()

        connect()
        cmd = New SqlCommand("delete from transaction_temp ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        cust_id = 0
        cust_name = ""
        frmMain.lblCustomer.Text = ""
        frmMain.Transaction()
        frmMain.dgrTransaction.Refresh()

        LoadRecall()
        txtCustomer.Clear()
        txtRemarks.Clear()
        MsgBox("Transaction was Hold!", vbInformation, " " & receipt_no & " ")

    End Sub

    Friend Sub Recall_Transaction()
        cmd = New SqlCommand(" SELECT LINENUMBER,PRODUCTID,PROD_DESCRIPTION,QUANTITY,PRICE,AMOUNT,DISCOUNT,VAT,VATABLEAMOUNT,CATEGORY,DEPARTMENT FROM TRANSACTION_HOLD " & _
                             " WHERE TRANSACTIONNO = '" & lvList.SelectedItems(0).Text & "' AND CUSTOMERNAME = '" & lvList.SelectedItems(0).SubItems(1).Text & "' ORDER BY LINENUMBER ASC", con)

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With frmMain.dgrTransaction
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite
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
                .Rows(.Rows.Count - 1).Cells(8).Value = dr(8)
                .Rows(.Rows.Count - 1).Cells(9).Value = dr(9)
                .Rows(.Rows.Count - 1).Cells(10).Value = dr(10)
            End While
        End With
        disconnect()

        ' DELETE FROM TRANSACTION HOLD TABLE
        connect()
        cmd = New SqlCommand("DELETE FROM TRANSACTION_HOLD WHERE TRANSACTIONNO = '" & lvList.SelectedItems(0).Text & "' AND CUSTOMERNAME = '" & lvList.SelectedItems(0).SubItems(1).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()


        cust_name = lvList.Items(0).SubItems(1).Text
        frmMain.lblCustomer.Text = cust_name
        frmMain.dgrTransaction.Refresh()
        frmMain.GetPaymentDetails_From_Hold()
        frmMain.RenderGrid()
    End Sub

    Friend Sub LoadRecall()
        cmd = New SqlCommand(" SELECT TRANSACTIONNO,CUSTOMERNAME,REMARKS FROM TRANSACTION_HOLD GROUP BY TRANSACTIONNO,CUSTOMERNAME,REMARKS", con)
        connect()
        dr = cmd.ExecuteReader()
        lvList.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("TRANSACTIONNO").ToString())
            Dim b = (dr.Item("CUSTOMERNAME").ToString())
            Dim c = (dr.Item("REMARKS").ToString())
            Dim lv As ListViewItem = lvList.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Friend Sub ReInsert_to_TempTransaction()

        Dim x As Integer = 0

        For i As Integer = 0 To frmMain.dgrTransaction.Rows.Count - 1

            x += 1

            connect()
            Dim cmd As New SqlCommand()
            cmd.Connection = con

            cmd.CommandText = "insert into transaction_temp (recordid,productid,prod_description,quantity,price,amount, " & _
                "discount,discounttype,vat,vatableamount,cashierid,department,category) values (@recordid,@productid, " & _
                "@prod_description,@quantity,@price,@amount,@discount,@discounttype,@vat,@vatableamount,@cashierid,@department,@category) "

            cmd.Parameters.AddWithValue("@recordid", x)
            cmd.Parameters.AddWithValue("@productid", frmMain.dgrTransaction.Rows(i).Cells(1).Value)
            cmd.Parameters.AddWithValue("@prod_description", convertQuotes(frmMain.dgrTransaction.Rows(i).Cells(2).Value))
            cmd.Parameters.AddWithValue("@quantity", frmMain.dgrTransaction.Rows(i).Cells(3).Value)
            cmd.Parameters.AddWithValue("@price", frmMain.dgrTransaction.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@amount", frmMain.dgrTransaction.Rows(i).Cells(5).Value)
            cmd.Parameters.AddWithValue("@discount", 0)
            cmd.Parameters.AddWithValue("@discounttype", 0)
            cmd.Parameters.AddWithValue("@vat", 0)
            cmd.Parameters.AddWithValue("@vatableamount", 0)
            cmd.Parameters.AddWithValue("@cashierid", cashier_id)
            cmd.Parameters.AddWithValue("@department", frmMain.dgrTransaction.Rows(i).Cells(9).Value)
            cmd.Parameters.AddWithValue("@category", frmMain.dgrTransaction.Rows(i).Cells(10).Value)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand(" update transaction_temp set vat = amount * 0.12 where productid = '" & frmMain.dgrTransaction.Rows(i).Cells(1).Value & "' ", con)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand(" update transaction_temp set vatableamount = amount - vat where productid = '" & frmMain.dgrTransaction.Rows(i).Cells(1).Value & "' ", con)
            cmd.ExecuteNonQuery()
        Next
        disconnect()
        Close()
    End Sub

    Private Sub btnHold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHold.Click
        If txtCustomer.Text.Length = 0 Then
            MsgBox("Please select or enter customer name first!", vbExclamation, "Hold Transaction")
            Exit Sub
        ElseIf frmMain.dgrTransaction.RowCount = 0 Then
            MsgBox("No transaction detected!", vbEmpty, "Hold Transaction")
            Exit Sub
        Else
            cust_name = txtCustomer.Text
            Hold_Transaction()
            frmMain.lblTotal.Text = "0.00"
        End If
    End Sub

    Private Sub btnRecall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecall.Click
        If frmMain.dgrTransaction.Rows.Count > 0 Then
            MsgBox("You must close first the current transaction before performing this operation!", vbInformation, "")
        Else
            Recall_Transaction()
            ReInsert_to_TempTransaction()
            frmMain.Transaction()
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Close()
    End Sub
End Class