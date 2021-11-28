Imports System.Data.SqlClient
Imports Microsoft.Win32
Imports System.Globalization

Public Class frmTender_Split

    Private Sub frmTender_Split_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCardType()
        GetChargeType()
        GetPaymentDetails()



        lblAmount.Text = "0"
        txtAmount.Text = frmMain.lblTotal.Text
        GetPaymentDetails()
        trans_points = frmMain.lblTotal.Text / points_percentage

        txtORNo.Focus()

        lblAmount.Font = CustFont.GetInstance(28, FontStyle.Bold)
        txtTotalPayment.Font = CustFont.GetInstance(28, FontStyle.Bold)
    End Sub

    Private Sub lblTenderType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTenderType.Click
        Me.Close()
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click

        If txtORNo.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please enter OR Number!", "OR Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtCustomerName.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please select customer!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        receipt_no = txtORNo.Text

        trans_cardamount = txtCardAmt.Text
        trans_cardtype = cboCardType.Text

        payment_mode = "4"
        'SaveCardTransaction()
        SaveTransaction()

        cust_name = txtCardHolder.Text
        trans_expirydate = txtExpiryDate.Text
        trans_approvalno = txtApprovalNo.Text
        trans_cardno = txtCardNo.Text

        trans_payment = txtTotalPayment.Text
        trans_change = "0.00"
        trans_chargetype = cboChargeType.Text
        ReceiptPaymentDetails()
        'GenerateReceipt_SplitPayment()

        txtORNo.Clear()

        If is_print_coupon = "NO" Then
            GenerateReceipt()
        Else
            GenerateCoupon()
        End If


        Me.Opacity = 0
        frmTender_Cash.Opacity = 0
        frmTender_Card.Opacity = 0
        frmTender_Charge.Opacity = 0

        frmPayment_Accepted.ShowDialog()

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        frmBrowseCust.Cust_Select_Mode = "Charge_Payment"
        frmBrowseCust.ShowDialog()
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

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Friend Sub GetChargeType()
        cmd = New SqlCommand(" select charge_type from chargetype ", con)

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
        cboChargeType.ValueMember = "charge_type"

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Friend Sub GetPaymentDetails()
        Try
            connect()
            cmd = New SqlCommand(" select total = sum(amount)  from transaction_temp", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                txtAmount.Text = dr("total")
                lblAmount.Text = Format(dr("total"), "#,#00.00")
            End If
            disconnect()
        Catch ex As Exception
        End Try
    End Sub

    Friend Sub AddAllPayments()
        'Try


        Dim x As Decimal


        x = Val(txtCashAmnt.Text) + Val(txtChargeAmt.Text)


        txtTotalPayment.Text = x.ToString("N2", CultureInfo.InvariantCulture)

        If x > lblAmount.Text Then
            DevComponents.DotNetBar.MessageBoxEx.Show("The total amount you entered is greater than the amount due! ", "Payment", _
                                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTotalPayment.Text = Val(txtCashAmnt.Text) + Val(txtChargeAmt.Text)
            txtTotalPayment.ForeColor = Color.Red
        Else
            txtTotalPayment.Text = Val(txtCashAmnt.Text) + Val(txtChargeAmt.Text)
            txtTotalPayment.ForeColor = Color.Lime
        End If


        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub txtCardAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCardAmt.TextChanged
        AddAllPayments()
    End Sub

    Private Sub txtTender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashAmnt.TextChanged
        AddAllPayments()
    End Sub

    Private Sub txtChargeAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChargeAmt.TextChanged
        AddAllPayments()
    End Sub

    Private Sub MbGlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MbGlassButton1.Click
        Close()
    End Sub
End Class