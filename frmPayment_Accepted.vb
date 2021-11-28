Imports System.Data.SqlClient

Public Class frmPayment_Accepted

    Private Sub frmPayment_Accepted_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.lblTotal.Text = "0.00"
        frmMain.lblAddOnFee.Text = "0.00"
        frmMain.lblDiscount.Text = "0.00"
        frmMain.lblChange.Text = "0.00"

        trans_totaldue = "0"
        trans_payment = "0"
        trans_change = "0"
        trans_discount = "0"
        trans_cardamount = "0"
        trans_cardno = "0"
        trans_chargeamount = "0"
        trans_newbalance = "0"
        trans_points = "0"
        trans_productvat = "0"
        trans_vatablesales = "0"
        trans_points = "0"
        cust_id = 0
        addon_fee = 0.0
        sales_NET_VAT = 0

        frmMain.GetDGProducts()
        frmMain.dgrProducts.Update()

        frmMain.GetInventoryStatus()

    End Sub

    Private Sub frmPayment_Accepted_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If payment_mode = 1 Then
            lblAmountTendered.Text = Format(CDbl(trans_payment), "##,##0.00")
        Else
            lblAmountTendered.Text = Format(CDbl(trans_payment), "##,##0.00")
        End If
        lblChange.Text = trans_change
        GetLast_TransactionNo()
    End Sub

    Friend Sub ResetAllDisplay()
        frmTender_Card.lblAmount.Text = "0.00"
        frmTender_Card.lblTransactionFee.Text = "0.00"
        frmTender_Card.txtCardAmt.Clear()

        frmTender_Cash.lblAmount.Text = "0.00"
        frmTender_Cash.txtChange.Text = "0.00"
        frmTender_Cash.txtTender.Clear()

        frmTender_Charge.lblAmount.Text = "0.00"
        frmTender_Charge.txtChargeAmt.Clear()

        frmTender_Split.lblAmount.Text = "0.00"
        frmTender_Split.txtTotalPayment.Text = "0.00"
        frmTender_Split.txtCashAmnt.Clear()
        frmTender_Split.txtCardAmt.Clear()
        frmTender_Split.txtChargeAmt.Clear()

        trans_cardtype = ""
    End Sub

    Friend Sub ClearDiscounts()
        connect()
        cmd = New SqlCommand("delete from [transaction] where productid = '0'", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    Private Sub btnReprintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprintReceipt.Click
        ReceiptPaymentDetails()
        GenerateReceipt()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        connect()
        cmd = New SqlCommand(" delete from transaction_temp ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        GetTotalVatableSales()
        frmMain.Transaction()
        frmMain.dgrTransaction.Refresh()
        frmMain.GetPaymentDetails()

        GetLast_TransactionNo() 'get last transaction #
        GenerateReceiptNo()     'format receipt #
        ResetAllDisplay()       'reset all payment details to zero
        ClearDiscounts()        'clear discounts from transaction_details
        Close()
        'RESET CUSTOMER DETAILS
        cust_name = ""
        cust_id = 0
        receipt_no = ""
        invoice_no = ""
        receivable_amnt = 0.0
        cash_amnt = 0.0
        frmMain.lblCustomer.Text = ""
        frmMain.txtSearchBox.Focus()

        frmTender_Cash.Close()
        frmTender_Card.Close()
        frmTender_Charge.Close()
        frmTender_Split.Close()
        frmMain.txtSearchBox.Focus()
    End Sub
End Class