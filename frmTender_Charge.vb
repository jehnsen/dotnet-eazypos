Imports System.Data.SqlClient

Public Class frmTender_Charge

    Private charge_TotalAmount As Double

    Private Sub frmTender_Charge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetChargeType()
        PaymentDetails()
        cust_id = 0
        cust_name = ""
        txtCustomerName.Clear()
        lblAmount.ForeColor = Color.FromArgb(80, 203, 147)
    End Sub

    Friend Sub PaymentDetails()
        charge_TotalAmount = CDbl(frmMain.lblTotal.Text)
        txtAmount.Text = Format(charge_TotalAmount, "##,##0.00")
        lblAmount.Text = Format(charge_TotalAmount, "##,##0.00")
        txtChargeAmt.Text = Format(charge_TotalAmount, "##,##0.00")
        trans_newbalance = charge_TotalAmount
        trans_points = charge_TotalAmount * "0.10"
    End Sub

    Friend Sub GetChargeType()
        cmd = New SqlCommand(" select recordid,charge_type from chargetype ", con)

        connect()

        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        'Initialize the DataTable object
        Dim dt = New DataTable

        'Populate the DataTable
        da.Fill(dt)

        'Bind the DataTable to the ComboBox
        cboChargeType.DataSource = dt
        cboChargeType.DisplayMember = "charge_type"
        cboChargeType.ValueMember = "recordid"

        cboChargeTypeID.DataSource = dt
        cboChargeTypeID.DisplayMember = "recordid"
        cboChargeTypeID.ValueMember = "recordid"

        trans_chargetype = cboChargeTypeID.Text

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Friend Sub GetPreviousCharges()
        Try
            connect()
            cmd = New SqlCommand(" select totalpoints = points + '" & trans_points & "',totalbalance = balance + '" & trans_newbalance & "' from customers where customerid = '" & cust_id & "' ", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                new_balance = dr("totalbalance").ToString
                new_points = dr("totalpoints").ToString
            End If
            dr.Close()
            disconnect()
        Catch ex As Exception
        End Try
    End Sub

    Friend Sub GetCustomerBalance()
        connect()
        cmd = New SqlCommand("select balance from customers where customerid = '" & cust_id & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            cust_total_balance = dr("balance")
        End If
        dr.Close()
        disconnect()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        frmBrowseCust.Cust_Select_Mode = "Charge_Payment"
        frmBrowseCust.ShowDialog()
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        If txtCustomerName.Text.Length = 0 Then
            MsgBox("Please a customer first!", vbExclamation, "Customer Selection")
            Exit Sub
        ElseIf txtInvNo.Text.Length = 0 Then
            'DevComponents.DotNetBar.MessageBoxEx.Show("Please enter Invoice Number!", "CI Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Exit Sub
            Dim rng As New Random
            rng.Next(10000000, 99999999)
            txtInvNo.Text = rng.Next(10000000, 99999999)

        End If

        invoice_no = txtInvNo.Text
        receipt_no = ""
        payment_mode = "2"

        'generate receipt no
        GetLast_TransactionNo()
        GenerateReceiptNo()
        ' save transaction
        SaveTransaction()

        trans_payment = txtChargeAmt.Text
        trans_change = "0.00"
        trans_chargetype = cboChargeTypeID.Text
        ReceiptPaymentDetails()

        If is_print_coupon = "NO" Then
            GenerateReceipt_Charge()
        Else
            GenerateCoupon()
        End If

        txtInvNo.Clear()

        Me.Opacity = 0
        frmTender_Cash.Opacity = 0
        frmTender_Card.Opacity = 0
        frmTender_Split.Opacity = 0

        frmPayment_Accepted.ShowDialog()


    End Sub

    Private Sub cboChargeType_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboChargeType.TextChanged
        GetChargeType()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()
    End Sub
End Class