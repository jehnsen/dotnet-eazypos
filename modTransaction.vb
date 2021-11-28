Imports System.Data.SqlClient

Module modTransaction

    Public Sub SaveCardTransaction()
        connect()
        cmd = New SqlCommand(" insert into [transaction_cardinfo] (receiptno,transactionno,customerid,cardamount,cardno,cardholder,expirydate,approvalno,cardtype) " & _
                             " values ('" & receipt_no & "','" & transaction_no & "','" & cust_id & "','" & frmTender_Card.txtCardAmt.Text & "', " & _
                             "'" & frmTender_Card.txtCardNo.Text & "','" & frmTender_Card.txtCardHolder.Text & "','" & frmTender_Card.txtExpiryDate.Text & "', " & _
                             "'" & frmTender_Card.txtApprovalNo.Text & "','" & trans_cardtype & "') ", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    Public Sub SaveTransaction()


        For i As Integer = 0 To frmMain.dgrTransaction.Rows.Count - 1

            'CONVERT STRING QUANTITY TO DECIMAL
            'If trans_LINEQTY = Nothing Then
            '    trans_LINEQTY = 0
            'Else
            Try
                trans_LINEQTY = frmMain.dgrTransaction.Rows(i).Cells(3).Value
            Catch ex As Exception

            End Try

            'End If

            If payment_mode = 2 Then 'CHARGE PAYMENT
                Dim cmdx As New SqlCommand()

                cash_amnt = 0.0
                receivable_amnt = frmMain.dgrTransaction.Rows(i).Cells(5).Value
                frmTender_Charge.GetCustomerBalance()
                cust_total_balance = cust_total_balance + receivable_amnt

                connect()
                cmdx = New SqlCommand("update dbo.[customers] set balance = balance + '" & receivable_amnt & "' where customerid = '" & cust_id & "'", con)
                cmdx.ExecuteNonQuery()
                disconnect()

            Else 'CASH PAYMENT
                invoice_no = ""
                receivable_amnt = 0.0
                cash_amnt = frmMain.dgrTransaction.Rows(i).Cells(5).Value
            End If

            'Try
            '    'EQTY = BQTY - QTY
            '    frmMain.dgrTransaction.Rows(i).Cells(12).Value = frmMain.dgrTransaction.Rows(i).Cells(11).Value - frmMain.dgrTransaction.Rows(i).Cells(3).Value
            'Catch ex As Exception
            'End Try

            connect()
            Dim cmd As New SqlCommand()
            cmd.Connection = con
            cmd.CommandText = "EXEC sp_SaveTransaction @sessionid,@transactionno,@receiptno,@invoiceno,@terminalno,@branch,@paymenttype,@shift,@cashierid,@baggerid,@customerid,@customername,@datetime, " & _
                              "@tax,@taxableamount,@cardtype,@chargetype,@lineno,@productid,@quantity,@price,@amount,@receivables,@discount,@vatablesales,@department,@category, " & _
                              "@chargestatus,@dailybqty,@runningbalance"

            cmd.Parameters.AddWithValue("@sessionid", NewSessionID)
            cmd.Parameters.AddWithValue("@transactionno", transaction_no)
            cmd.Parameters.AddWithValue("@receiptno", receipt_no)
            cmd.Parameters.AddWithValue("@invoiceno", invoice_no)
            cmd.Parameters.AddWithValue("@terminalno", terminal_no)
            cmd.Parameters.AddWithValue("@branch", branch_id)
            cmd.Parameters.AddWithValue("@paymenttype", payment_mode)
            cmd.Parameters.AddWithValue("@shift", "")
            cmd.Parameters.AddWithValue("@cashierid", cashier_id)
            cmd.Parameters.AddWithValue("@baggerid", bagger_id)
            cmd.Parameters.AddWithValue("@customerid", cust_id)
            cmd.Parameters.AddWithValue("@customername", cust_name)
            cmd.Parameters.AddWithValue("@datetime", system_time)
            cmd.Parameters.AddWithValue("@status", 1)
            cmd.Parameters.AddWithValue("@tax", "")
            cmd.Parameters.AddWithValue("@taxableamount", 0)
            cmd.Parameters.AddWithValue("@cardtype", trans_cardtype)
            cmd.Parameters.AddWithValue("@chargetype", trans_chargetype)
            cmd.Parameters.AddWithValue("@lineno", frmMain.dgrTransaction.Rows(i).Cells(0).Value)
            cmd.Parameters.AddWithValue("@productid", frmMain.dgrTransaction.Rows(i).Cells(1).Value)
            cmd.Parameters.AddWithValue("@quantity", trans_LINEQTY)
            cmd.Parameters.AddWithValue("@price", frmMain.dgrTransaction.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@amount", cash_amnt)
            cmd.Parameters.AddWithValue("@receivables", receivable_amnt)
            cmd.Parameters.AddWithValue("@discount", frmMain.dgrTransaction.Rows(i).Cells(6).Value)
            'cmd.Parameters.AddWithValue("@vat", (CDbl(cash_amnt) + CDbl(receivable_amnt)) - CDbl(Val(frmMain.dgrTransaction.Rows(i).Cells(7).Value)))
            cmd.Parameters.AddWithValue("@vatablesales", frmMain.dgrTransaction.Rows(i).Cells(7).Value)
            cmd.Parameters.AddWithValue("@isreturned", 0)
            cmd.Parameters.AddWithValue("@department", frmMain.dgrTransaction.Rows(i).Cells(9).Value)
            cmd.Parameters.AddWithValue("@category", frmMain.dgrTransaction.Rows(i).Cells(10).Value)
            cmd.Parameters.AddWithValue("@dailybqty", frmMain.dgrTransaction.Rows(i).Cells(11).Value)
            cmd.Parameters.AddWithValue("@dailyeqty", frmMain.dgrTransaction.Rows(i).Cells(12).Value)
            cmd.Parameters.AddWithValue("@chargestatus", 0)
            cmd.Parameters.AddWithValue("@runningbalance", cust_total_balance)
            cmd.ExecuteNonQuery()


            'cmd.CommandText = "insert into [transaction] (sessionid,transactionno,receiptno,invoiceno,terminalno,branch,paymenttype,shift,cashierid,baggerid,customerid,customername, " & _
            '                  "datetime,status,tax,taxableamount,cardtype,chargetype,line_no,productid,quantity,price,amount,receivables,discount,vat,vatablesales,returned,department,category, " & _
            '                  "chargestatus,dailybqty,dailyeqty,s_in,s_out,retqty,dailyadj,collectionamnt,remarks,expenses,dailypurchaseqty,cust_rbalance) " & _
            '                  "values (@sessionid,@transactionno,@receiptno,@invoiceno,@terminalno,@branch,@paymenttype,@shift,@cashierid,@baggerid,@customerid,@customername,@datetime,@status, " & _
            '                  "@tax,@taxableamount,@cardtype,@chargetype,@lineno,@productid,@quantity,@price,@amount,@receivables,@discount,@vat,@vatablesales,@isreturned,@department,@category, " & _
            '                  "@chargestatus,@dailybqty,@dailyeqty,0,0,0,0,0,'',0,0,@runningbalance) "
        Next
        disconnect()

        frmMain.Transaction()
        frmMain.dgrTransaction.Refresh()

        'UPDATE ITEM INVENTORY
        For i As Integer = 0 To frmMain.dgrTransaction.Rows.Count - 1

            If trans_LINEQTY = Nothing Then
                trans_LINEQTY = 0
            Else
                Try
                    trans_LINEQTY = frmMain.dgrTransaction.Rows(i).Cells(3).Value
                Catch ex As Exception

                End Try

            End If

            connect()
            Dim cmd As New SqlCommand()
            cmd.Connection = con

            cmd.CommandText = "update products set quantity = quantity - @quantity  where productid = @productid  "

            cmd.Parameters.AddWithValue("@transactionno", transaction_no)
            cmd.Parameters.AddWithValue("@receiptno", receipt_no)
            cmd.Parameters.AddWithValue("@productid", frmMain.dgrTransaction.Rows(i).Cells(1).Value)
            cmd.Parameters.AddWithValue("@product_desc", frmMain.dgrTransaction.Rows(i).Cells(2).Value)
            cmd.Parameters.AddWithValue("@quantity", trans_LINEQTY)
            cmd.Parameters.AddWithValue("@price", frmMain.dgrTransaction.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@total", frmMain.dgrTransaction.Rows(i).Cells(5).Value)
            cmd.Parameters.AddWithValue("@discount", frmMain.dgrTransaction.Rows(i).Cells(6).Value)
            cmd.Parameters.AddWithValue("@vat", frmMain.dgrTransaction.Rows(i).Cells(7).Value)
            cmd.Parameters.AddWithValue("@isreturned", 0)
            cmd.ExecuteNonQuery()

        Next
        disconnect()

        connect()
        cmd = New SqlCommand("update DBO.[TRANSACTION] set COLLECTIONAMNT = AMOUNT WHERE RECEIPTNO = '" & receipt_no & "' AND PRODUCTID = 2", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("update DBO.[TRANSACTION] set AMOUNT=0 WHERE RECEIPTNO = '" & receipt_no & "' AND PRODUCTID = 2", con)
        cmd.ExecuteNonQuery()
        disconnect()


        'ADD CUSTOMER POINTS
        ProcessCustomerCharges()

    End Sub

    Public Sub GetLast_TransactionNo()
        connect()
        cmd = New SqlCommand(" select top 1 transactionno = transactionno + 1  from [transaction] order by transactionno desc", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            transaction_no = dr("transactionno")
            receipt_no = dr("transactionno")
        Else
            transaction_no = "1"
            receipt_no = "0000000001"
        End If
        disconnect()
        GenerateReceiptNo()
    End Sub

    Public Sub GenerateReceiptNo()

        If receipt_no.Length = 1 Then
            receipt_no = "0-000000000" & receipt_no
        ElseIf receipt_no.Length = 2 Then
            receipt_no = "0-00000000" & receipt_no
        ElseIf receipt_no.Length = 3 Then
            receipt_no = "0-0000000" & receipt_no
        ElseIf receipt_no.Length = 4 Then
            receipt_no = "0-000000" & receipt_no
        ElseIf receipt_no.Length = 5 Then
            receipt_no = "0-00000" & receipt_no
        ElseIf receipt_no.Length = 6 Then
            receipt_no = "0-0000" & receipt_no
        ElseIf receipt_no.Length = 7 Then
            receipt_no = "0-000" & receipt_no
        ElseIf receipt_no.Length = 8 Then
            receipt_no = "0-00" & receipt_no
        ElseIf receipt_no.Length = 9 Then
            receipt_no = "0-0" & receipt_no
        ElseIf receipt_no.Length = 10 Then
            receipt_no = "0-" & receipt_no
        End If

    End Sub

    Public Sub ProcessCustomerCharges()
        If payment_mode = "1" Then
            connect()
            cmd = New SqlCommand("update customers set points = points + '" & trans_points & "' where customerid = '" & cust_id & "'", con)
            cmd.ExecuteNonQuery()
            disconnect()
        ElseIf payment_mode = "2" Then
            connect()
            cmd = New SqlCommand("update customers set status = 0 where customerid = '" & cust_id & "'", con)
            cmd.ExecuteNonQuery()
            disconnect()
        ElseIf payment_mode = "3" Then
            connect()
            cmd = New SqlCommand("update customers set points = points + '" & trans_points & "', balance = balance + '" & trans_newbalance & "' where customerid = '" & cust_id & "'", con)
            cmd.ExecuteNonQuery()
            disconnect()
        Else
        End If
    End Sub

    Friend Sub GetVatValue()
        connect()
        cmd = New SqlCommand(" select percentage from tax ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            trans_vatpercent = dr("percentage")
        End If
        disconnect()
    End Sub

    Friend Sub GetTotalVatableSales()
        connect()
        cmd = New SqlCommand(" select tax = sum(vat), vatableamount = sum(vatableamount) from transaction_temp  ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                trans_productvat = Format(dr("vat"), "0.00")
                trans_vatablesales = Format(dr("vatableamount"), "0.00")
            Catch ex As Exception
                trans_productvat = ""
                trans_vatablesales = ""
            End Try
        End If
        disconnect()
    End Sub

    Friend Sub CalculateSeniorCitizenDiscount(ByVal discRate As Double, ByVal itemAmount As Double)
        Dim VAT_EXEMPT_SALE As Double
        Dim SENIOR_CITIZEN_DISCOUNT As Double

        'compute amount of VAT Exempt Sale
        VAT_EXEMPT_SALE = itemAmount / 1.12

        'Deduct the 20% discount
        SENIOR_CITIZEN_DISCOUNT = VAT_EXEMPT_SALE * discRate '0.2

        'Compute the billable amount
        trans_discount = VAT_EXEMPT_SALE - SENIOR_CITIZEN_DISCOUNT

        Dim formattedString As String = "*discount: SC - " & Format(SENIOR_CITIZEN_DISCOUNT, "##,##0.00")

        connect()
        cmd = New SqlCommand("UPDATE transaction_temp SET prod_description= CONCAT(prod_description,'" & vbCrLf & "' ,'" & formattedString & "'), discount = '" & SENIOR_CITIZEN_DISCOUNT & "',discountrate = '" & discRate & "',discounttype = 1  " & _
                             "WHERE recordid = '" & frmMain.dgrTransaction.CurrentRow.Cells(0).Value & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    Friend Sub CalculateCoopMemberDiscount(ByVal discRate As Double, ByVal itemAmount As Double)
 
        Dim formattedString As String = "*discount: VAT Excusive"

        connect()
        cmd = New SqlCommand("UPDATE transaction_temp SET prod_description= CONCAT(prod_description,'" & vbCrLf & "' ,'" & formattedString & "'), discount = 0 ,discountrate = '" & discRate & "',discounttype = 2  " & _
                             "WHERE recordid = '" & frmMain.dgrTransaction.CurrentRow.Cells(0).Value & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    Friend Sub CalculateTotalTransactionAmount()
        Try
            connect()
            cmd = New SqlCommand("EXEC sp_CalculateTransactionAmount", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                frmMain.lblTotal.Text = Format(dr("TOTALAMOUNT"), "##,##0.00")
                frmMain.lblDiscount.Text = Format(dr("TOTALDISCOUNTS"), "##,##0.00")
            End If
            disconnect()

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

End Module
