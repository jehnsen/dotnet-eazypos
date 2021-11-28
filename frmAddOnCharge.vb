Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmAddOnCharge

    Private Sub frmAddOnCharge_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX1.PerformClick()
        End If
    End Sub

    Private Sub frmAddOnCharge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPaymentAmnt.Clear()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        addon_fee = txtPaymentAmnt.Text

        trans_totaldue = (trans_totaldue + addon_fee)
        frmMain.lblTotal.Text = trans_totaldue

        connect()
        cmd = New SqlCommand(" insert into transaction_temp (recordid,productid,prod_description,amount,discount,discountrate,discounttype) values " & _
                             "(999998,2,'Add: DELIVERY FEE','" & txtPaymentAmnt.Text & "',0,0,0) ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        frmMain.lblAddOnFee.Text = addon_fee.ToString("N2", CultureInfo.InvariantCulture)
        frmMain.Transaction()
        frmMain.dgrTransaction.Refresh()

        Me.Close()
        frmMain.txtSearchBox.Focus()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Close()
    End Sub

End Class