Imports System.Data.SqlClient

Public Class frmCustomerCard

    Private CARD_DISCOUNT_RATE As Decimal
    Private CUST_DISCOUNT As Decimal
    Private Is_CARDNO_EXIST As Boolean
    Private CustName As String

    Private Sub frmCustomerCard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            InsertDiscount()
        End If
    End Sub

    Private Sub frmCustomerCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_DISCOUNT()
    End Sub

    Friend Sub Get_DISCOUNT()
        connect()
        cmd = New SqlCommand("SELECT DISCOUNT_AMOUNT FROM DISCOUNTS WHERE DISCOUNT_TYPE = 'CARD' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            CARD_DISCOUNT_RATE = "0." & dr("DISCOUNT_AMOUNT")
        End If
        disconnect()
    End Sub

    Friend Sub Get_CardNo()
        connect()
        cmd = New SqlCommand("SELECT ACCOUNTNO,DISC=ISNULL(CUSTDISCOUNT,0),CNAME = FIRSTNAME + ' ' + LASTNAME FROM CUSTOMERS WHERE ACCOUNTNO = '" & txtCardNo.Text & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtCardNo.Text = dr("ACCOUNTNO").ToString
            CUST_DISCOUNT = dr("DISC")
            CustName = dr("CNAME").ToString
            Is_CARDNO_EXIST = True
        Else
            Is_CARDNO_EXIST = False
        End If
        disconnect()

    End Sub

    Friend Sub GetPaymentDetails()
        connect()
        cmd = New SqlCommand(" select total = (sum(amount) - sum(discount))  from transaction_temp", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            frmMain.lblTotal.Text = Format(dr("total"), "##,##0.00")
        End If
        disconnect()
    End Sub

    Friend Sub InsertDiscount()

        If Is_CARDNO_EXIST = False Then
            DevComponents.DotNetBar.MessageBoxEx.Show("NO CUSTOMER FOUND!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf frmMain.dgrTransaction.RowCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("NO TRANSACTION FOUND!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
            Close()
        Else

            trans_discount = trans_totaldue * CARD_DISCOUNT_RATE
            trans_totaldue = (trans_totaldue - trans_discount)
            frmMain.lblTotal.Text = trans_totaldue

            connect()
            cmd = New SqlCommand("insert into transaction_temp (recordid,productid,prod_description,amount,discount,discountrate,discounttype) values ('999999','999999', " & _
                                 " 'Less: DISCOUNT @','" & Format(trans_discount, "0.00") & "','" & trans_discount & "','" & CARD_DISCOUNT_RATE & "','" & trans_disctype & "') ", con)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand(" update transaction_temp set discount = '" & trans_discount & "',discountrate = '" & CARD_DISCOUNT_RATE & "',discounttype = 0  " & _
                                 "where productid = '" & frmMain.dgrTransaction.CurrentRow.Cells(1).Value & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()

            frmMain.lblCustomer.Text = CustName
            frmMain.Transaction()
            frmMain.dgrTransaction.Refresh()
            GetPaymentDetails()

            Me.Close()
        End If

    End Sub

    Private Sub txtCardNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardNo.TextChanged
        Get_CardNo()
    End Sub

End Class