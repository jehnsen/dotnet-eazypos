Imports System.Data.SqlClient

Public Class frmPurchaseReceive

    Private PD_No As Integer
    Dim x As Double
    Dim BQTY As Double
    Dim EQTY As Double
    Dim CQTY As Double

    Private Sub frmPurchaseReceive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_Items()
        Get_PurchasedItems()
        Get_Suppliers()

        txtDRNo.Clear()
        txtReceivedBy.Clear()
        txtInvoice.Clear()
        txtORNo.Clear()
        txtRemarks.Clear()
        txtDelivered.Clear()
        txtSupplier.Text = ""
        lblTotalAmnt.Text = "Total Amount: "

        dgrReceive.Columns(0).ReadOnly = True
        dgrReceive.Columns(1).ReadOnly = True
        dgrReceive.Columns(2).ReadOnly = True
        dgrReceive.Columns(3).ReadOnly = True
        dgrReceive.Columns(4).ReadOnly = True
        dgrItems.BackgroundColor = Color.White
        dgrReceive.BackgroundColor = Color.White
    End Sub

    Friend Sub Get_Items()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("select productid,prod_description,quantity,cost from products where productid not in (1,2,3,4,5,6)", con)
        Else
            cmd = New SqlCommand("select productid,prod_description,quantity,cost from products where plu like '%" & convertQuotes(txtSearch.Text) & "%' " & _
                                 "or prod_description like '%" & convertQuotes(txtSearch.Text) & "%' and productid not in (1,2,3,4,5,6)", con)
        End If

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrItems
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0).ToString
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1).ToString
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2).ToString
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3).ToString

                'For i As Integer = 0 To Me.dgrItems.Rows.Count - 1
                '    If Me.dgrItems.Rows(i).Cells(2).Value <= 0 Then
                '        Me.dgrItems.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                '    Else
                '        Me.dgrItems.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                '    End If
                'Next


            End While
        End With
        disconnect()



    End Sub

    Friend Sub Get_PurchasedItems()

        cmd = New SqlCommand("select pd.recordno, p.productid, p.plu, p.prod_description, CONVERT(varchar, CAST(p.price AS money), 1), " & _
                             "convert(decimal(10,2),p.cost), pd.qty_received, CONVERT(varchar, CAST(pd.amount AS money), 1), p.quantity from products p " & _
                             "inner join purchasedelivery_details pd on p.productid=pd.productid where pd.status = 0 order by recordno desc", con)


        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrReceive
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0).ToString
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1).ToString
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2).ToString
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3).ToString
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4).ToString
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5).ToString
                .Rows(.Rows.Count - 1).Cells(6).Value = dr(6).ToString
                .Rows(.Rows.Count - 1).Cells(7).Value = dr(7).ToString
                .Rows(.Rows.Count - 1).Cells(8).Value = dr(8).ToString

                For i As Integer = 0 To Me.dgrReceive.Rows.Count - 1
                    If Me.dgrReceive.Rows(i).Cells(5).Value <= 0 Then
                        Me.dgrReceive.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        Me.dgrReceive.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    End If

                Next

            End While
        End With
        disconnect()

    End Sub

    Friend Sub Get_PDNumber()
        connect()
        cmd = New SqlCommand("SELECT TOP 1 pd_no FROM PURCHASEDELIVERIES ORDER BY pd_no DESC ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                PD_No = dr(0)
            Catch ex As Exception

            End Try

        End If
        disconnect()

    End Sub

    Friend Sub Insert_Items()

        Dim isExists As Boolean = False

        For Each itm As DataGridViewRow In dgrReceive.Rows
            If itm.Cells(1).Value = dgrItems.CurrentRow.Cells(0).Value Then
                isExists = True
            End If
        Next


        If isExists = True Then

            MsgBox("Item already entered!", vbExclamation, "Duplicate Entry")

        Else
            connect()
            cmd = New SqlCommand("insert into purchasedelivery_details (pd_no,productid,qty_received,cost,amount,status) " & _
                                 "values ('" & PD_No & "','" & dgrItems.CurrentRow.Cells(0).Value & "',1, " & _
                                 "'" & dgrItems.CurrentRow.Cells(3).Value & "','" & dgrItems.CurrentRow.Cells(3).Value & "',0)", con)
            cmd.ExecuteNonQuery()
            disconnect()
        End If

        Get_PurchasedItems()
        dgrReceive.Refresh()

        For i As Integer = 0 To Me.dgrReceive.Rows.Count - 1


            dgrReceive.Rows(i).Cells(7).Value = dgrReceive.Rows(i).Cells(5).Value * dgrReceive.Rows(i).Cells(6).Value

            x = x + dgrReceive.Rows(i).Cells(7).Value

            lblTotalAmnt.Text = "Total Amount: " & x.ToString("C", New System.Globalization.CultureInfo("en-us")).Remove(0, 1)
        Next
    End Sub

    Friend Sub Get_Suppliers()
        cmd = New SqlCommand(" select * from suppliers", con)
        connect()
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt1 = New DataTable
        da.Fill(dt1)
        txtSupplier.DataSource = dt1
        txtSupplier.DisplayMember = "suppliername"
        txtSupplier.ValueMember = "suppliername"
        'Clean up
        da.Dispose()
        da = Nothing
        disconnect()
    End Sub

    'Friend Sub GetItemDetails()
    '    connect()
    '    cmd = New SqlCommand(" select quantity,price,cost,maxlevel,minlevel,reorderpoint,lastupdated,supplier from products where plu = '" & dgrItems.CurrentRow.Cells(0).Value & "' ", con)
    '    Dim dr As SqlDataReader = cmd.ExecuteReader
    '    If dr.Read Then
    '        txtQuantity.Text = dr("quantity").ToString
    '        txtCost.Text = dr("cost").ToString
    '        txtPrice.Text = dr("price").ToString
    '        txtmaxstock.Text = dr("maxlevel").ToString
    '        txtminstock.Text = dr("minlevel").ToString
    '        txtsupplier.Text = dr("supplier").ToString
    '        txtReorder.Text = dr("reorderpoint").ToString
    '    End If
    '    disconnect()
    'End Sub

    Private Sub dgrItems_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrItems.CellDoubleClick
        btnSelect.PerformClick()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Insert_Items()
        Get_PurchasedItems()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnselect.Click
        If dgrReceive.Rows.Count = 0 Then
            Exit Sub
        End If
        connect()
        cmd = New SqlCommand("delete from purchasedelivery_details where recordno = '" & dgrReceive.CurrentRow.Cells(0).Value & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        Get_PurchasedItems()
    End Sub

    Private Sub btnReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceive.Click

        If txtSupplier.Text.Length = 0 Then
            MsgBox("please enter supplier!", vbExclamation, "")
            Exit Sub
        End If
        If txtDRNo.Text.Length = 0 Then
            MsgBox("please enter Invoice Number!", vbExclamation, "")
            Exit Sub
        End If
        If txtReceivedBy.Text.Length = 0 Then
            MsgBox("Please enter name of receiver!", vbExclamation, "")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to receive this items?" & vbCrLf & vbCrLf & _
                           "Please check all items carefully before proceeding.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then

            connect()
            cmd = New SqlCommand("insert into purchasedeliveries (dr_no,or_no,supplier_name,date_received,total_amnt,received_by,checked_by,remarks,status) values " & _
                                 "('" & txtDRNo.Text & "','" & txtORNo.Text & "','" & txtSupplier.Text & "','" & dtpDate.Text & "', " & _
                                 "'" & x & "','" & txtReceivedBy.Text & "', '" & txtDelivered.Text & "', '" & txtRemarks.Text & "', 1) ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            'GET LAST PD NUMBER
            Get_PDNumber()

            connect()
            cmd = New SqlCommand("update purchasedelivery_details set status = 1 , PD_NO = '" & PD_No & "' where status = 0 ", con)
            cmd.ExecuteNonQuery()
            disconnect()

            Try
            
                'SAVE TO INVENTORY TRANSACTION TABLE
                connect()
                For i As Integer = 0 To Me.dgrReceive.Rows.Count - 1

                    Dim qtyReceived As Integer
                    ' check if qty is empty
                    If dgrReceive.Rows(i).Cells(6).Value Is Nothing Then
                        qtyReceived = 0
                    Else
                        qtyReceived = dgrReceive.Rows(i).Cells(6).Value
                    End If

                    cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,RECEIPTNO,DATETIME,SESSIONID,S_IN,DAILYPURCHASEQTY,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
                                         "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
                                         "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_OUT,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY,DAILYADJ,REMARKS) values " & _
                                           "(@PRODUCTID,@RECEIPTNO,@DATETIME,@SESSIONID,0,@DAILY_PURCHASE,0,1,0,0,@CASHIERID,@TERMINALNO,@BRANCH,0,0,0,0,0,'','',0,0,0, " & _
                                           "0,@REMARKS,'',0,0,'',0,0,@DAILYEQTY,0,0,0,0,@DAILYBQTY,0,@REMARKS)", con)
                    cmd.Parameters.AddWithValue("@DATETIME", dtpDate.Text)
                    cmd.Parameters.AddWithValue("@RECEIPTNO", txtORNo.Text)
                    cmd.Parameters.AddWithValue("@SESSIONID", NewSessionID)
                    cmd.Parameters.AddWithValue("@DAILY_PURCHASE", qtyReceived)
                    cmd.Parameters.AddWithValue("@PRODUCTID", dgrReceive.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@CASHIERID", cashier_id)
                    cmd.Parameters.AddWithValue("@TERMINALNO", terminal_no)
                    cmd.Parameters.AddWithValue("@BRANCH", branch_id)
                    cmd.Parameters.AddWithValue("@DAILYBQTY", dgrReceive.Rows(i).Cells(8).Value)
                    cmd.Parameters.AddWithValue("@DAILYEQTY", dgrReceive.Rows(i).Cells(9).Value)
                    cmd.Parameters.AddWithValue("@REMARKS", txtRemarks.Text & " - " & txtRemarks.Text)
                    cmd.ExecuteNonQuery()
                Next
                disconnect()

            Catch ex As Exception
                MsgBox("Please make sure to check the correct quantity of the items received.")
            End Try



            ' UPDATE INVENTORY
            Try
                For i As Integer = 0 To Me.dgrReceive.Rows.Count - 1

                    Dim qtyValue As Integer
                    ' check if qty is empty
                    If dgrReceive.Rows(i).Cells(6).Value Is Nothing Then
                        qtyValue = 0
                    Else
                        qtyValue = dgrReceive.Rows(i).Cells(6).Value
                    End If

                    connect()
                    Dim cmd As New SqlCommand()
                    cmd.Connection = con

                    cmd.CommandText = "update products set quantity = quantity + @quantity  where productid = @productid"

                    cmd.Parameters.AddWithValue("@productid", dgrReceive.Rows(i).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@quantity", qtyValue)
                    cmd.Parameters.AddWithValue("@cost", dgrReceive.Rows(i).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@amount", dgrReceive.Rows(i).Cells(7).Value)
                    cmd.ExecuteNonQuery()
                Next
                disconnect()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            MsgBox("Delivery Received!", vbInformation, "Purchase")
            Close()
        Else
            Exit Sub
        End If

        Close()
        frmPurchases.Get_PURCHASES()
        frmPurchases.dgrPurchases.Refresh()
    End Sub

    Private Sub dgrReceive_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrReceive.CellEndEdit
        Try
            For i As Integer = 0 To Me.dgrReceive.Rows.Count - 1

                Dim x As Double
                CQTY = dgrReceive.Rows(i).Cells(6).Value
                BQTY = dgrReceive.Rows(i).Cells(8).Value
                EQTY = dgrReceive.Rows(i).Cells(9).Value

                dgrReceive.Rows(i).Cells(7).Value = dgrReceive.Rows(i).Cells(5).Value * dgrReceive.Rows(i).Cells(6).Value

                x = x + dgrReceive.Rows(i).Cells(7).Value

                EQTY = CQTY + BQTY
                dgrReceive.Rows(i).Cells(9).Value = EQTY

                If dgrReceive.Rows(i).Cells(6).Value Is Nothing Then
                    dgrReceive.Rows(i).Cells(6).Value = 0
                End If

                lblTotalAmnt.Text = "Total Amount: " & x.ToString("C", New System.Globalization.CultureInfo("en-us")).Remove(0, 1)

                connect()
                Dim cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandText = "update purchasedelivery_details set qty_received = @quantity, cost=@cost, amount=@amount  where recordno = @recordno"
                cmd.Parameters.AddWithValue("@recordno", dgrReceive.Rows(i).Cells(0).Value)
                cmd.Parameters.AddWithValue("@quantity", dgrReceive.Rows(i).Cells(6).Value)
                cmd.Parameters.AddWithValue("@cost", dgrReceive.Rows(i).Cells(5).Value)
                cmd.Parameters.AddWithValue("@amount", dgrReceive.Rows(i).Cells(7).Value)
                cmd.ExecuteNonQuery()
            Next
            disconnect()
        Catch ex As Exception
            MsgBox("Please check your entry, fields should not be empty!")
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Get_Items()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class