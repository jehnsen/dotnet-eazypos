Imports System.Data.SqlClient

Public Class frmQuantity

    Private amt As Double
    Private discounRate As Double

    Private Sub frmQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        txtQuantity.Focus()
        If e.KeyCode = Keys.Enter Then
            btnDone.PerformClick()
        ElseIf e.KeyCode = Keys.Subtract Then
            btnClear.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
       
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub

    Private Sub frmQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQuantity.Focus()
        txtQuantity.Clear()
        RibbonClientPanel1.Text = frmMain.dgrTransaction.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Try
            If txtQuantity.Text.Length = 0 Then
                txtQuantity.Text = "1"
                UpdateQuantity()
            ElseIf txtQuantity.Text = "0" Then
                Exit Sub
            Else
                UpdateQuantity()
                'frmMain.GetPaymentDetails()
            End If

            ' get current discout rate
            'GetCurrentDiscountRate()
            'sc discount
            'CalculateSeniorCitizenDiscount(discounRate, frmMain.dgrTransaction.CurrentRow.Cells(5).Value)
            'Update total trasaction amount
            CalculateTotalTransactionAmount()
            'Refresh the transaction items
            frmMain.Transaction()
            frmMain.dgrTransaction.Refresh()

            Me.Close()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Friend Sub GetCurrentDiscountRate()
        connect()
        cmd = New SqlCommand("SELECT DISCOUNTRATE FROM transaction_temp WHERE PRODUCTID = '" & frmMain.dgrTransaction.CurrentRow.Cells(0).Value & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            discounRate = dr("DISCOUNTRATE")
        End If
        disconnect()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtQuantity.Clear()
    End Sub

    Friend Sub UpdateQuantity()
        connect()
        cmd = New SqlCommand("EXEC sp_UpdateItemInCurrentTransaction '" & Val(frmMain.dgrTransaction.CurrentRow.Cells(0).Value) & "', '" & Val(txtQuantity.Text) & "'", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

#Region "Button Numbers"

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtQuantity.Text = txtQuantity.Text & 1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtQuantity.Text = txtQuantity.Text & 2
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtQuantity.Text = txtQuantity.Text & 3
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtQuantity.Text = txtQuantity.Text & 4
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtQuantity.Text = txtQuantity.Text & 5
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtQuantity.Text = txtQuantity.Text & 6
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtQuantity.Text = txtQuantity.Text & 7
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtQuantity.Text = txtQuantity.Text & 8
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtQuantity.Text = txtQuantity.Text & 9
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If txtQuantity.Text.Length > 0 Then
            txtQuantity.Text = txtQuantity.Text & 0
        End If
    End Sub

#End Region


    Private Sub btn1_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1_2.Click
        txtQuantity.Text = 0.5 + Val(txtQuantity.Text)
    End Sub

    Private Sub btn1_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1_4.Click
        txtQuantity.Text = 0.25 + Val(txtQuantity.Text)
    End Sub

    Private Sub btn3_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3_4.Click
        txtQuantity.Text = 0.75 + Val(txtQuantity.Text)
    End Sub

    Private Sub btn1_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1_8.Click
        txtQuantity.Text = 0.125 + Val(txtQuantity.Text)
    End Sub
End Class