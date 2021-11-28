Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmInvTrans

    Friend is_New As Boolean
    Friend TRANS_TYPE As String
    Dim TRANS_QTY As Decimal
    Dim STOCKID As Integer

    Private Sub frmInvTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDateTime.Format = DateTimePickerFormat.Custom
        dtpDateTime.CustomFormat = "MM-dd-yyyy hh:mm tt"
        dtpDateTime.Value.ToString("MM-dd-yyyy hh:mm tt")

        If is_New = True Then

            txtDRNo.Clear()
            txtRemarks.Clear()
            TXTCHECKBY.Clear()
            TXTDELBY.Clear()

            Get_IssuanceItems()

            dgrIssuanceItems.ReadOnly = False
            dgrIssuanceItems.Columns(0).ReadOnly = True
            dgrIssuanceItems.Columns(1).ReadOnly = True
            dgrIssuanceItems.Columns(2).ReadOnly = True
            dgrIssuanceItems.Columns(3).ReadOnly = True
            btnSave.Enabled = True
            btnBrowseItem.Enabled = True
            btnRemove.Enabled = True
        Else
            Get_ItemsforUpdate()
            dgrIssuanceItems.ReadOnly = True
            btnSave.Enabled = False
            btnBrowseItem.Enabled = False
            btnRemove.Enabled = False
        End If
        Text = TRANS_TYPE

        dgrIssuanceItems.BackgroundColor = Color.White
    End Sub

    Friend Sub Get_IssuanceItems()
        cmd = New SqlCommand("SELECT P.ITEMID,P.PLU,P.PROD_DESCRIPTION,P.UNIT,IT.QUANTITY,P.QUANTITY,QUANTITY=P.QUANTITY " & _
                             "FROM DBO.PRODUCTS P INNER JOIN DBO.INVENTORYTRANSTEMP IT ON P.ITEMID=IT.ITEMID", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrIssuanceItems
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
                .Rows(.Rows.Count - 1).Cells(6).Value = dr(6)

                For i As Integer = 0 To dgrIssuanceItems.Rows.Count - 1

                    TRANS_QTY = dgrIssuanceItems.Rows(i).Cells(4).Value

                    If TRANS_QTY = Int(TRANS_QTY) Then
                        dgrIssuanceItems.Rows(i).Cells(4).Value = TRANS_QTY.ToString("N0", CultureInfo.InvariantCulture)
                    Else
                        dgrIssuanceItems.Rows(i).Cells(4).Value = TRANS_QTY.ToString("N2", CultureInfo.InvariantCulture)
                    End If

                    If dgrIssuanceItems.Rows(i).Cells(4).Value = 0 Then
                        dgrIssuanceItems.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    ElseIf dgrIssuanceItems.Rows(i).Cells(4).Value > 0 Then
                        dgrIssuanceItems.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                    End If
                Next

            End While
        End With
        dr.Close()
        disconnect()

    End Sub

    Friend Sub Get_ItemsforUpdate()
        If TRANS_TYPE = "STOCKIN" Then
            cmd = New SqlCommand("SELECT P.PRODUCTID,P.PLU,P.PROD_DESCRIPTION,P.UNIT,T.S_IN,T.DAILYBQTY,T.DAILYEQTY " & _
                                      "FROM DBO.PRODUCTS P INNER JOIN DBO.[TRANSACTION] T ON P.PRODUCTID=T.PRODUCTID WHERE RECEIPTNO = '" & frmInventory.dgrStockInOut.CurrentRow.Cells(2).Value & "' ", con)
        Else
            cmd = New SqlCommand("SELECT P.PRODUCTID,P.PLU,P.PROD_DESCRIPTION,P.UNIT,T.S_OUT,T.DAILYBQTY,T.DAILYEQTY " & _
                              "FROM DBO.PRODUCTS P INNER JOIN DBO.[TRANSACTION] T ON P.PRODUCTID=T.PRODUCTID WHERE RECEIPTNO = '" & frmInventory.dgrStockInOut.CurrentRow.Cells(2).Value & "'", con)
        End If
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrIssuanceItems
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
                .Rows(.Rows.Count - 1).Cells(6).Value = dr(6)

                For i As Integer = 0 To dgrIssuanceItems.Rows.Count - 1

                    TRANS_QTY = dgrIssuanceItems.Rows(i).Cells(4).Value

                    If TRANS_QTY = Int(TRANS_QTY) Then
                        dgrIssuanceItems.Rows(i).Cells(4).Value = TRANS_QTY.ToString("N0", CultureInfo.InvariantCulture)
                    Else
                        dgrIssuanceItems.Rows(i).Cells(4).Value = TRANS_QTY.ToString("N2", CultureInfo.InvariantCulture)
                    End If

                    If dgrIssuanceItems.Rows(i).Cells(4).Value = 0 Then
                        dgrIssuanceItems.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    ElseIf dgrIssuanceItems.Rows(i).Cells(4).Value > 0 Then
                        dgrIssuanceItems.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                    End If
                Next

            End While
        End With
        dr.Close()
        disconnect()

        Get_StockDetails()

    End Sub

    Friend Sub Get_StockDetails()
        connect()
        cmd = New SqlCommand("SELECT RECORDID,DRNO,TRANSDATE,CHECKBY,DELBY,DESCRIPTION FROM DBO.INVENTORYTRANS WHERE RECORDID = '" & frmInventory.dgrStockInOut.CurrentRow.Cells(0).Value & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                STOCKID = dr("RECORDID")
                txtDRNo.Text = dr("DRNO").ToString
                dtpDateTime.Text = dr("TRANSDATE").ToString
                TXTCHECKBY.Text = dr("CHECKBY")
                TXTDELBY.Text = dr("DELBY")
                txtRemarks.Text = dr("DESCRPTION")
            Catch ex As Exception
            End Try
        End If
        disconnect()
    End Sub

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtDRNo.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please enter the Delivery Receipt Number!", "DR Number", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        ElseIf TXTCHECKBY.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please enter checker name!", "CHECKER", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        ElseIf TXTDELBY.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please enter driver name!", "DELIVERED BY", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If TRANS_TYPE = "STOCKIN" Then
            Process_StockIn()
        Else
            Process_StockOut()
        End If
        txtDRNo.Clear()
        txtRemarks.Clear()


        frmInventory.GetItems()
        frmInventory.dgrItems.Refresh()
        frmInventory.Get_InventoryItems()
        frmInventory.dgrStockInOut.Refresh()

        frmMain.GetDGProducts()
        frmMain.dgrProducts.Refresh()
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Friend Sub Process_StockIn()

        'SAVE TO INVENTORY TRANSACTION TABLE
        connect()
        For i As Integer = 0 To Me.dgrIssuanceItems.Rows.Count - 1

            dgrIssuanceItems.Rows(i).Cells(6).Value = dgrIssuanceItems.Rows(i).Cells(4).Value + dgrIssuanceItems.Rows(i).Cells(6).Value

            cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,RECEIPTNO,DATETIME,SESSIONID,S_IN,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
                                 "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
                                 "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_OUT,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY,DAILYADJ,REMARKS) values " & _
                                   "(@PRODUCTID,@RECEIPTNO,@DATETIME,@SESSIONID,@S_IN,0,1,0,0,@CASHIERID,@TERMINALNO,@BRANCH,0,0,0,0,0,'','',0,0,0, " & _
                                   "0,@REMARKS,'',0,0,'',0,0,@DAILYEQTY,0,0,0,0,@DAILYBQTY,0,@REMARKS)", con)
            cmd.Parameters.AddWithValue("@DATETIME", dtpDateTime.Text)
            cmd.Parameters.AddWithValue("@RECEIPTNO", txtDRNo.Text)
            cmd.Parameters.AddWithValue("@SESSIONID", NewSessionID)
            cmd.Parameters.AddWithValue("@S_IN", dgrIssuanceItems.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@PRODUCTID", dgrIssuanceItems.Rows(i).Cells(0).Value)
            cmd.Parameters.AddWithValue("@CASHIERID", cashier_id)
            cmd.Parameters.AddWithValue("@TERMINALNO", terminal_no)
            cmd.Parameters.AddWithValue("@BRANCH", branch_id)
            cmd.Parameters.AddWithValue("@DAILYBQTY", dgrIssuanceItems.Rows(i).Cells(5).Value)
            cmd.Parameters.AddWithValue("@DAILYEQTY", dgrIssuanceItems.Rows(i).Cells(6).Value)
            cmd.Parameters.AddWithValue("@REMARKS", TXTDELBY.Text & " - " & txtRemarks.Text)
            cmd.ExecuteNonQuery()
        Next
        disconnect()

        connect()
        For i As Integer = 0 To Me.dgrIssuanceItems.Rows.Count - 1
            cmd = New SqlCommand("UPDATE DBO.PRODUCTS SET QUANTITY = QUANTITY + @QTY WHERE ITEMID = @ITEMID", con)
            cmd.Parameters.AddWithValue("@DATE", dtpDateTime.Text)
            cmd.Parameters.AddWithValue("@DRNO", txtDRNo.Text)
            cmd.Parameters.AddWithValue("@SESSIONID", NewSessionID)
            cmd.Parameters.AddWithValue("@QTY", dgrIssuanceItems.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@ITEMID", dgrIssuanceItems.Rows(i).Cells(0).Value)
            cmd.ExecuteNonQuery()
        Next
        disconnect()

        connect()
        cmd = New SqlCommand("INSERT INTO DBO.INVENTORYTRANS (SESSIONID,TRANSTYPE,TRANSDATE,DRNO,DESCRIPTION,DELBY,CHECKBY,STATUS) " & _
                             "VALUES ('" & NewSessionID & "','SI','" & dtpDateTime.Text & "','" & txtDRNo.Text & "','" & txtRemarks.Text & "', " & _
                             "'" & TXTDELBY.Text & "','" & TXTCHECKBY.Text & "',1)", con)
        cmd.ExecuteNonQuery()
        disconnect()

        connect()
        cmd = New SqlCommand("DELETE FROM INVENTORYTRANSTEMP", con)
        cmd.ExecuteNonQuery()
        disconnect()

        DevComponents.DotNetBar.MessageBoxEx.Show("STOCK IN SUCCESSFULLY SAVED!", "STOCKIN", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Friend Sub Process_StockOut()

        'SAVE TO INVENTORY TRANSACTION TABLE
        connect()
        For i As Integer = 0 To Me.dgrIssuanceItems.Rows.Count - 1

            dgrIssuanceItems.Rows(i).Cells(6).Value = dgrIssuanceItems.Rows(i).Cells(6).Value - dgrIssuanceItems.Rows(i).Cells(4).Value

            cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,RECEIPTNO,DATETIME,SESSIONID,S_OUT,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
                                 "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
                                 "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_IN,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY,DAILYADJ,REMARKS) values " & _
                                   "(@PRODUCTID,@RECEIPTNO,@DATETIME,@SESSIONID,@S_OUT,0,1,0,0,@CASHIERID,@TERMINALNO,@BRANCH,0,0,0,0,0,'','',0,0,0, " & _
                                   "0,@REMARKS,'',0,0,'',0,0,@DAILYEQTY,0,0,0,0,@DAILYBQTY,0,@REMARKS)", con)
            cmd.Parameters.AddWithValue("@DATETIME", dtpDateTime.Text)
            cmd.Parameters.AddWithValue("@RECEIPTNO", txtDRNo.Text)
            cmd.Parameters.AddWithValue("@SESSIONID", NewSessionID)
            cmd.Parameters.AddWithValue("@S_OUT", dgrIssuanceItems.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@PRODUCTID", dgrIssuanceItems.Rows(i).Cells(0).Value)
            cmd.Parameters.AddWithValue("@CASHIERID", cashier_id)
            cmd.Parameters.AddWithValue("@TERMINALNO", terminal_no)
            cmd.Parameters.AddWithValue("@BRANCH", branch_id)
            cmd.Parameters.AddWithValue("@DAILYBQTY", dgrIssuanceItems.Rows(i).Cells(5).Value)
            cmd.Parameters.AddWithValue("@DAILYEQTY", dgrIssuanceItems.Rows(i).Cells(6).Value)
            cmd.Parameters.AddWithValue("@REMARKS", txtRemarks.Text)
            cmd.ExecuteNonQuery()
        Next
        disconnect()


        connect()
        For i As Integer = 0 To Me.dgrIssuanceItems.Rows.Count - 1
            cmd = New SqlCommand("UPDATE DBO.PRODUCTS SET QUANTITY = QUANTITY - @QTY WHERE ITEMID=@ITEMID", con)
            cmd.Parameters.AddWithValue("@DATE", dtpDateTime.Text)
            cmd.Parameters.AddWithValue("@DRNO", txtDRNo.Text)
            cmd.Parameters.AddWithValue("@SESSIONID", NewSessionID)
            cmd.Parameters.AddWithValue("@QTY", dgrIssuanceItems.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@ITEMID", dgrIssuanceItems.Rows(i).Cells(0).Value)
            cmd.ExecuteNonQuery()
        Next
        disconnect()

        connect()
        cmd = New SqlCommand("INSERT INTO DBO.INVENTORYTRANS (SESSIONID,TRANSTYPE,TRANSDATE,DRNO,DESCRIPTION,DELBY,CHECKBY,STATUS) " & _
                             "VALUES ('" & NewSessionID & "','SO','" & dtpDateTime.Text & "','" & txtDRNo.Text & "','" & txtRemarks.Text & "', " & _
                             "'" & TXTDELBY.Text & "','" & TXTCHECKBY.Text & "',1)", con)
        cmd.ExecuteNonQuery()
        disconnect()

        connect()
        cmd = New SqlCommand("DELETE FROM INVENTORYTRANSTEMP", con)
        cmd.ExecuteNonQuery()
        disconnect()

        DevComponents.DotNetBar.MessageBoxEx.Show("STOCK OUT SUCCESSFULLY SAVED!", "STOCKOUT", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseItem.Click
        frmBrowseItems.select_mode = "inventory"
        frmBrowseItems.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dgrIssuanceItems.Rows.Count = 0 Then
            MsgBox("No item to remove!", vbExclamation, "Empty")
        Else
            connect()
            cmd = New SqlCommand("delete from INVENTORYTRANStemp where itemid ='" & dgrIssuanceItems.CurrentRow.Cells(0).Value & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            Get_IssuanceItems()
           
            dgrIssuanceItems.Refresh()

        End If
    End Sub

    Private Sub dgrIssuanceItems_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrIssuanceItems.CellEndEdit
        connect()
        For i As Integer = 0 To Me.dgrIssuanceItems.Rows.Count - 1
            cmd = New SqlCommand("UPDATE DBO.InventoryTransTemp SET QUANTITY = @QUANTITY WHERE ITEMID = @ITEMID", con)
            cmd.Parameters.AddWithValue("@QUANTITY", dgrIssuanceItems.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@ITEMID", dgrIssuanceItems.Rows(i).Cells(0).Value)
            cmd.ExecuteNonQuery()
        Next
        cmd.Dispose()
        disconnect()
    End Sub

    Private Sub btnUpdateQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateQty.Click

    End Sub

End Class