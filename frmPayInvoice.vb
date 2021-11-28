Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmPayInvoice

    Dim x As Decimal
    Dim y As Decimal
    Dim z As Decimal

    Private Sub frmPayInvoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lblBalance.Text = ""
        lblCustName.Text = ""
    End Sub

    Private Sub frmPayInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MM-dd-yyyy"
        dtpDate.Value.ToString("MM-dd-yyyy")

        lblCustName.Text = frmCustomer.lvUsers.SelectedItems(0).SubItems(1).Text & " " & frmCustomer.lvUsers.SelectedItems(0).SubItems(2).Text
        lblBalance.Text = frmCustomer.lvUsers.SelectedItems(0).SubItems(4).Text
        x = frmCustomer.lvUsers.SelectedItems(0).SubItems(4).Text
        lblBalance.Text = x.ToString("N2", CultureInfo.InvariantCulture)

        Text = "Enter Payment - " & lblCustName.Text

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        If txtPaymentAmnt.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("PLEASE ENTER A VALID PAYMENT AMOUNT!", "PAYMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtReceiptNo.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("PLEASE ENTER RECEIPT NUMBER!", "RECEIPT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        y = txtPaymentAmnt.Text

        If y = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please enter a valid amount!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtReceiptNo.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please enter Receipt Number!", "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'COMPUTE RUNNING BALANCE
        z = x - y

        connect()
        cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,RECEIPTNO,DATETIME,SESSIONID,S_IN,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
                                    "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
                                    "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_OUT,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY,DAILYADJ,COLLECTIONAMNT,REMARKS,CUST_RBALANCE) VALUES " & _
                                    "(1,'" & txtReceiptNo.Text & "','" & dtpDate.Text & "','" & NewSessionID & "',0,0,1,0,0,'" & cashier_id & "','" & terminal_no & "','" & branch_id & "',0,0,0,0,0,'','',0,0,0, " & _
                                    "'" & frmCustomer.lvUsers.SelectedItems(0).Text & "','" & lblCustName.Text & "','',0,0,'',0,0,0,0,0,0,0,0,0,'" & txtPaymentAmnt.Text & "','" & cboPaymentType.Text & " " & txtRemarks.Text & "','" & z & "')", con)
        cmd.ExecuteNonQuery()
        disconnect()

        'UPDATE CUSTOMER'S BALANCE
        connect()
        cmd = New SqlCommand("update customers set balance = balance - '" & y & "', amntpaid = amntpaid + '" & y & "', STATUS = 0 " & _
                             "where customerid = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        'PAY OPTION : PARTIAL / FULL
        If cboPaymentType.Text = "PAY INVOICE" Then
            connect()
            cmd = New SqlCommand("update dbo.[transaction] set chargestatus = 1 where invoiceno = '" & txtInvoiceNo.Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
        ElseIf cboPaymentType.Text = "FULL PAYMENT" Then
            connect()
            cmd = New SqlCommand("update dbo.[transaction] set chargestatus = 1 where customerid = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand("update dbo.customers set status = 1 where customerid = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
        End If

        frmCustomer.GetCustomers()
        frmCustomer.lvUsers.Refresh()
        Close()

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Close()
    End Sub

    Private Sub cboPaymentType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaymentType.SelectedIndexChanged
        If cboPaymentType.Text = "PAY INVOICE" Then
            txtInvoiceNo.Enabled = True
        Else
            txtInvoiceNo.Enabled = False
        End If

        If cboPaymentType.Text = "FULL PAYMENT" Then
            txtPaymentAmnt.Text = lblBalance.Text
        Else
            txtPaymentAmnt.Clear()
        End If

    End Sub

End Class