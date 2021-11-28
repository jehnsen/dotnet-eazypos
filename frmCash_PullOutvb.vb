Imports System.Data.SqlClient

Public Class frmCash_PullOutvb

    Private Sub frmCash_PullOutvb_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmManagerLogin.Close()
    End Sub

    Private Sub frmCash_PullOutvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCashAmt.Focus()
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPullOut.Click
        If txtRemarks.Text.Length = 0 Then
            MsgBox("PLEASE ENTER REMARKS!", vbInformation, "REMARKS")
            Exit Sub
        End If

        connect()
        cmd = New SqlCommand(" update pos_session set cashpullout = cashpullout + '" & Val(txtCashAmt.Text) & "', " & _
                             " cashonhand = cashonhand - '" & Val(txtCashAmt.Text) & "' ", con)
        cmd.ExecuteNonQuery()

        disconnect()

        connect()
        cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,RECEIPTNO,DATETIME,SESSIONID,S_IN,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
                                    "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
                                    "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_OUT,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY,DAILYADJ,COLLECTIONAMNT,EXPENSES,REMARKS) VALUES " & _
                                    "(4,0,'" & Format(Now, "MM-dd-yyyy hh:mmmm tt") & "','" & NewSessionID & "',0,0,1,0,0,0,'" & terminal_no & "','" & branch_id & "',0,0,0,0,0,'','',0,0,0, " & _
                                    "0,'" & txtRemarks.Text & "','',0,0,0,0,0,0,0,0,0,0,0,0,0,'" & txtCashAmt.Text & "','')", con)
        cmd.ExecuteNonQuery()
        disconnect()

        MsgBox("You widthdrawn " & txtCashAmt.Text & " on your cash drawer.", vbInformation, "Confirmation")
        txtCashAmt.Clear()
        txtRemarks.Clear()
        btnCancel.PerformClick()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'frmManagerLogin.Close()
        Me.Close()
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

    Private Sub btnExact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExact.Click
        txtCashAmt.Text = txtCashAmt.Text & "."
    End Sub
#End Region

End Class