Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmRefQty

    Dim RefAmnt As Decimal
    Dim DBQ As Decimal
    Dim DEQ As Decimal
    Dim CQ As Decimal

    Private Sub frmRefQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProcessRefund()
        End If
    End Sub

    Private Sub frmRefQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetInventoryDetails()
        txtRefQTY.Text = frmItemReturn.lvItems.SelectedItems(0).SubItems(2).Text
    End Sub

    Friend Sub GetInventoryDetails()
        cmd = New SqlCommand("select quantity,dailybqty from dbo.products where productid = '" & frmItemReturn.lvItems.SelectedItems(0).Text & "' ", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            CQ = dr("quantity")
            DBQ = dr("dailybqty")
            DEQ = dr("quantity")
        End If
        dr.Close()
        disconnect()
    End Sub

    Friend Sub ProcessRefund()

        If txtRefQTY.Text > frmItemReturn.lvItems.SelectedItems(0).SubItems(2).Text Then
            MsgBox("The Amount you entered is greater than the current quantity!", vbExclamation, "Invalid")
            Exit Sub
        End If

        RefAmnt = frmItemReturn.lvItems.SelectedItems(0).SubItems(3).Text * Val(txtRefQTY.Text)
        RefAmnt = RefAmnt.ToString("N2", CultureInfo.InvariantCulture)
        DEQ = CQ - txtRefQTY.Text

        connect()
        cmd = New SqlCommand("update dbo.[transaction] set retqty= '" & Val(txtRefQTY.Text) & "' " & _
                             "where productid = '" & frmItemReturn.lvItems.SelectedItems(0).Text & "' and receiptno = '" & frmItemReturn.txtORNumber.Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        'quantity = quantity - '" & Val(txtRefQTY.Text) & "'
        'connect()
        'cmd = New SqlCommand("update dbo.[transaction] set amount = quantity * price where productid = '" & frmItemReturn.lvItems.SelectedItems(0).Text & "' and receiptno = '" & frmItemReturn.txtORNumber.Text & "' ", con)
        'cmd.ExecuteNonQuery()
        'disconnect()

        connect()
        cmd = New SqlCommand("update dbo.products set quantity = quantity +  '" & Val(txtRefQTY.Text) & "' where productid = '" & frmItemReturn.lvItems.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        connect()
        cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,RECEIPTNO,DATETIME,SESSIONID,S_IN,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
                                    "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
                                    "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_OUT,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY,DAILYADJ,COLLECTIONAMNT,REMARKS,EXPENSES,DAILYPURCHASEQTY) VALUES " & _
                                    "(3,'" & frmItemReturn.txtORNumber.Text & "','" & Format(Now, "MM-dd-yyyy hh:mm tt") & "','" & NewSessionID & "',0,0,1,0,0,'" & cashier_id & "','" & terminal_no & "','" & branch_id & "',0,0,0,0,0,'','',0,0,0, " & _
                                    "0,'" & frmItemReturn.lvItems.SelectedItems(0).SubItems(1).Text & "','',0,0,'',0,0,0,'" & txtRefQTY.Text & "','" & frmItemReturn.lvItems.SelectedItems(0).SubItems(3).Text & "',0,0,0,0,0,'','" & RefAmnt & "',0)", con)
        cmd.ExecuteNonQuery()
        disconnect()

        Text = RefAmnt
        DevComponents.DotNetBar.MessageBoxEx.Show("Item successfully refunded!", "Refund", MessageBoxButtons.OK, MessageBoxIcon.Information)

        frmItemReturn.SearchTransaction()
        frmItemReturn.lvItems.Refresh()
        Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        ProcessRefund()
    End Sub
End Class