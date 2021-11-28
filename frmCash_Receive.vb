Imports System.Data.SqlClient

Public Class frmCash_Receive

    Private Sub frmCash_Receive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

#Region "Button Numbers"

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtCashAmt.Text = txtCashAmt.Text & "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtCashAmt.Text = txtCashAmt.Text & "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtCashAmt.Text = txtCashAmt.Text & "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtCashAmt.Text = txtCashAmt.Text & "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtCashAmt.Text = txtCashAmt.Text & "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtCashAmt.Text = txtCashAmt.Text & "6"
    End Sub

    Private Sub btn7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtCashAmt.Text = txtCashAmt.Text & "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtCashAmt.Text = txtCashAmt.Text & "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtCashAmt.Text = txtCashAmt.Text & "9"
    End Sub

    Private Sub btn0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtCashAmt.Text = txtCashAmt.Text & "0"
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCashAmt.Text = ""
    End Sub

    Private Sub btnDot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDot.Click
        txtCashAmt.Text = txtCashAmt.Text & "."
    End Sub
#End Region

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        connect()
        cmd = New SqlCommand(" update pos_session set cashdeposit = cashdeposit + '" & Val(txtCashAmt.Text) & "', " & _
                             " cashonhand = cashonhand + '" & Val(txtCashAmt.Text) & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        MsgBox("Cash was added!", vbInformation, "Confirmation")
        txtCashAmt.Clear()
        txtRemarks.Clear()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        frmManagerLogin.Close()
        Me.Close()
    End Sub
End Class