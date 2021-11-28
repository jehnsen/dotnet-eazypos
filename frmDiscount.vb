Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmDiscount

    Dim discount_type As String = "LineDisc"
    Private DISCOUNT_NAME As String
    Private ITEM_AMOUNT As Double
    Private VAT_EXEMPT_SALE As Double
    Private SENIOR_CITIZEN_DISCOUNT As Double
    Private TOTAL_SENIOR_CITIZEN_DISCOUNTS As Double
    Private TOTAL_AMOUNT As Double

    'discount types
    '1 - SENIOR CITIZEN

    Friend product_recordid As Integer

    Private Sub frmDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetDiscounts()
        txtProductName.Text = frmMain.dgrTransaction.CurrentRow.Cells(2).Value
        txtProductName2.Text = frmMain.dgrTransaction.CurrentRow.Cells(2).Value

        btnSubTotalDiscount.PerformClick()
        ' access level
        If frmMain.userType = 3 Then 'cashier
            SetUserAcess()
        End If

    End Sub

    Friend Sub SetUserAcess()
        Dim buttonId As Integer
        connect()
        cmd = New SqlCommand("SELECT Id FROM MODULES Where Cashier = 0 AND ModuleId = 5", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read

            buttonId = dr("Id")

            Select Case buttonId
                Case 19
                    btnLineDiscount.Enabled = False
                Case 10
                    btnSubTotalDiscount.Enabled = False
                Case 21
                    btnApply.Enabled = False
                Case Else

            End Select

        Loop
        disconnect()

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        ITEM_AMOUNT = frmMain.dgrTransaction.CurrentRow.Cells(5).Value

        Select Case discount_type
            Case "SCDisc

                'compute amount of VAT Exempt Sale
                Dim VAT_EXEMPT_SALE = ITEM_AMOUNT / 1.12

                'Deduct the 20% discount
                Dim SENIOR_CITIZEN_DISCOUNT = VAT_EXEMPT_SALE * 0.2

                'Compute the billable amount
                trans_discount = VAT_EXEMPT_SALE - SENIOR_CITIZEN_DISCOUNT


                frmMain.lblTotal.Text = trans_totaldue.ToString("N2", CultureInfo.InvariantCulture)

                'DISPLAY OUTPUT
                MsgBox(amnt_of_vat & vbCrLf & sales_NET_VAT & vbCrLf & trans_discount & vbCrLf & "TOTAL : " & trans_totaldue.ToString("N2", CultureInfo.InvariantCulture))

                connect()
                cmd = New SqlCommand(" insert into transaction_temp (recordid,productid,prod_description,amount,discount,discountrate,vatableamount,discounttype) values ('999999','999999', " & _
                                     " 'Less: Senior Citizen','" & Format(trans_discount, "0.00") & "','" & trans_discount & "','0.2857','" & VAT_EXEMPT_SALE & "','" & trans_disctype & "') ", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand(" update transaction_temp set discount = '" & trans_discount & "',discountrate = '" & txtTotalDiscAmt.Text & "',discounttype = 0  " & _
                                     "where productid = '" & frmMain.dgrTransaction.CurrentRow.Cells(1).Value & "' ", con)
                cmd.ExecuteNonQuery()

                disconnect()

            Case "SubTotalDisc"

                trans_discount = trans_totaldue * Val(txtTotalDiscAmt.Text)
                trans_totaldue = (trans_totaldue - trans_discount)

                frmMain.lblTotal.Text = trans_totaldue

                connect()
                cmd = New SqlCommand(" insert into transaction_temp (recordid,productid,prod_description,amount,discount,discountrate,discounttype) values ('999999','999999', " & _
                                     " 'Total Discount : ' + '" & cboOtherDisc.Text & "','" & Format(trans_discount, "0.00") & "','" & trans_discount & "', " & _
                                     "'" & txtTotalDiscAmt.Text & "','" & trans_disctype & "' ) ", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand(" update transaction_temp set discount = '" & trans_discount & "',discountrate = '" & txtTotalDiscAmt.Text & "', " & _
                                     " discounttype = 0  where productid = '" & frmMain.dgrTransaction.CurrentRow.Cells(1).Value & "' ", con)
                cmd.ExecuteNonQuery()
                disconnect()

            Case "LineDisc"

                Dim _amount As Double = frmMain.dgrTransaction.CurrentRow.Cells(5).Value

                CalculateSeniorCitizenDiscount(CDbl(cboLineDiscAmt.Text), _amount)

                'If cboLineDisc_Type.Text = "Senior Citizen" Then
                '    'compute amount of VAT Exempt Sale
                '    VAT_EXEMPT_SALE = ITEM_AMOUNT / 1.12

                '    'Deduct the 20% discount
                '    SENIOR_CITIZEN_DISCOUNT = VAT_EXEMPT_SALE * cboLineDiscAmt.Text '0.2

                '    'Compute the billable amount
                '    trans_discount = VAT_EXEMPT_SALE - SENIOR_CITIZEN_DISCOUNT

                'Else
                '    trans_discount = frmMain.dgrTransaction.CurrentRow.Cells(5).Value * Val(txtLineDiscPercent.Text)
                '    trans_totaldue = (trans_totaldue - trans_discount)
                'End If

                'Dim formattedString As String = "- disc: SC - " & Format(SENIOR_CITIZEN_DISCOUNT, "##,##0.00")

                'connect()
                'cmd = New SqlCommand(" update transaction_temp set prod_description= CONCAT(prod_description,'" & vbCrLf & "' ,'" & formattedString & "'), discount = '" & SENIOR_CITIZEN_DISCOUNT & "',discountrate = '" & txtLineDiscPercent.Text & "',discounttype = '" & trans_disctype & "'  " & _
                '                     " where productid = '" & frmMain.dgrTransaction.CurrentRow.Cells(1).Value & "' ", con)
                'cmd.ExecuteNonQuery()
                'disconnect()
        End Select

        CalculateTotalTransactionAmount()
        frmMain.Transaction()
        frmMain.dgrTransaction.Refresh()

        Me.Close()
        frmMain.txtSearchBox.Focus()
    End Sub

    Friend Sub GetDiscounts()
        cmd = New SqlCommand("select recordid,discount_name,discount_amount from discounts ", con)

        connect()

        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        'Initialize the DataTable object
        Dim dt1 = New DataTable
        Dim dt2 = New DataTable

        'Populate the DataTable
        da.Fill(dt1)
        da.Fill(dt2)

        'Bind the DataTable to the ComboBox
        cboOtherDisc.DataSource = dt1
        cboOtherDisc.DisplayMember = "discount_name"
        cboOtherDisc.ValueMember = "recordid"

        cboTotalDiscAmt.DataSource = dt1
        cboTotalDiscAmt.DisplayMember = "discount_amount"
        cboTotalDiscAmt.ValueMember = "recordid"

        'Bind the DataTable to the ComboBox
        cboLineDisc_Type.DataSource = dt2
        cboLineDisc_Type.DisplayMember = "discount_name"
        cboLineDisc_Type.ValueMember = "recordid"

        cboLineDiscAmt.DataSource = dt2
        cboLineDiscAmt.DisplayMember = "discount_amount"
        cboLineDiscAmt.ValueMember = "recordid"

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Friend Sub ButtonColor()
        Select Case discount_type
            Case "LineDisc"
                btnLineDiscount.BaseColor = Color.FromArgb(255, 128, 0)
                btnSCDiscount.BaseColor = Color.FromArgb(192, 192, 255)
                btnSubTotalDiscount.BaseColor = Color.FromArgb(192, 192, 255)
            Case "SCDisc"
                btnLineDiscount.BaseColor = Color.FromArgb(192, 192, 255)
                btnSCDiscount.BaseColor = Color.FromArgb(255, 128, 0)
                btnSubTotalDiscount.BaseColor = Color.FromArgb(192, 192, 255)
            Case "SubTotalDisc"
                btnLineDiscount.BaseColor = Color.FromArgb(192, 192, 255)
                btnSCDiscount.BaseColor = Color.FromArgb(192, 192, 255)
                btnSubTotalDiscount.BaseColor = Color.FromArgb(255, 128, 0)
            Case "ApplyVat"
                btnLineDiscount.BaseColor = Color.FromArgb(192, 192, 255)
                btnSCDiscount.BaseColor = Color.FromArgb(192, 192, 255)
                btnSubTotalDiscount.BaseColor = Color.FromArgb(192, 192, 255)
        End Select
    End Sub

    Private Sub btnLineDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLineDiscount.Click
        discount_type = "LineDisc"
        trans_disctype = 1
        ButtonColor()

    End Sub

    Private Sub btnSCDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSCDiscount.Click
        discount_type = "SCDisc"
        trans_disctype = 3
        pnlSC.BringToFront()
        ButtonColor()
    End Sub

    Private Sub btnSubTotalDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubTotalDiscount.Click
        discount_type = "SubTotalDisc"
        trans_disctype = 2
        pnlSubtotal.BringToFront()
        ButtonColor()
    End Sub

    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Me.Close()
    End Sub

    Private Sub cboOtherDisc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOtherDisc.SelectedIndexChanged
        cmd = New SqlCommand(" select recordid,discount_name,discount_amount from discounts where discount_name = '" & cboOtherDisc.Text & "' ", con)

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtTotalDiscAmt.Text = "0." & dr("discount_amount")
        End If
        dr.Close()
        disconnect()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        frmSCCustomers.ShowDialog()
    End Sub

    Private Sub cboLineDiscAmt_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLineDiscAmt.SelectedIndexChanged
        txtLineDiscPercent.Text = cboLineDiscAmt.Text

    End Sub

    Private Sub cboTotalDiscAmt_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTotalDiscAmt.SelectedIndexChanged
        txtTotalDiscAmt.Text = cboTotalDiscAmt.Text
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnApplyDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyDiscount.Click
        Dim _amount As Double = frmMain.dgrTransaction.CurrentRow.Cells(5).Value
        If cboLineDisc_Type.Text = "Senior Citizen" Then
            CalculateSeniorCitizenDiscount(CDbl(cboLineDiscAmt.Text), _amount)
        ElseIf cboLineDisc_Type.Text = "Exclude VAT" Then
            CalculateCoopMemberDiscount(CDbl(cboLineDiscAmt.Text), _amount)
        End If

        CalculateTotalTransactionAmount()
        frmMain.Transaction()
        frmMain.dgrTransaction.Refresh()

        Me.Close()
        frmMain.txtSearchBox.Focus()
    End Sub
End Class