Imports System.Data.SqlClient

Public Class frmTender_Card

    Private Sub frmTender_Card_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCardType()
        PaymentDetails()
    End Sub

    Private Sub lblTenderType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTenderType.Click
        Me.Close()
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click

        If txtCardNo.Text.Length = 0 Then
            MsgBox("Please enter card number!", vbExclamation, "Card Number")
        ElseIf txtApprovalNo.Text.Length = 0 Then
            MsgBox("Please enter approval number!", vbExclamation, "Approval Number")
        Else
            trans_cardamount = txtCardAmt.Text

            payment_mode = "3"
            SaveCardTransaction()
            SaveTransaction()

            cust_name = txtCardHolder.Text
            trans_expirydate = txtExpiryDate.Text
            trans_approvalno = txtApprovalNo.Text
            trans_cardno = txtCardNo.Text
            ReceiptPaymentDetails()
            GenerateReceipt_Card()

            frmTender_Charge.Opacity = 0
            frmTender_Cash.Opacity = 0
            Me.Opacity = 0
            frmTender_Split.Opacity = 0

            frmPayment_Accepted.lblAmountTendered.Text = txtCardAmt.Text
            frmPayment_Accepted.lblChange.Text = "0.00"
            frmPayment_Accepted.ShowDialog()
        End If

    End Sub

    Friend Sub GetCardType()
        cmd = New SqlCommand(" select recordid,card_type from cardtype ", con)

        connect()

        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        'Initialize the DataTable object
        Dim dt = New DataTable

        'Populate the DataTable
        da.Fill(dt)

        'Bind the DataTable to the ComboBox
        cboCardType.DataSource = dt
        cboCardType.DisplayMember = "card_type"
        cboCardType.ValueMember = "recordid"

        cboCardTypeID.DataSource = dt
        cboCardTypeID.DisplayMember = "recordid"
        cboCardTypeID.ValueMember = "recordid"

        trans_cardtype = cboCardTypeID.Text

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Friend Sub PaymentDetails()
        txtAmount.Text = Format(trans_totaldue, "0.00")
        lblAmount.Text = Format(trans_totaldue, "0.00")
        txtCardAmt.Text = Format(trans_totaldue, "0.00")
    End Sub

End Class