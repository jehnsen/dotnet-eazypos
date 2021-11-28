Imports System.Data.SqlClient

Public Class frmStartofDay

    Private isSessionActive As Integer = 0

    Private Sub frmStartofDay_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmManagerLogin.Close()
    End Sub

    Private Sub frmStartofDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetLastSessionNo()
        txtCashFund.Focus()
    End Sub

    Friend Sub GetLastSessionNo()

        connect()
        cmd = New SqlCommand(" select top 1 sessionid = sessionid + 1  from pos_sessionhistory order by sessionid desc", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            NewSessionID = dr("sessionid")
        Else
            NewSessionID = 1
        End If

        If IsDBNull(NewSessionID) Then
            NewSessionID = 1
        End If

        disconnect()
    End Sub

    Friend Sub CheckCurrentSession()
        connect()
        cmd = New SqlCommand("select * from pos_session", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            isSessionActive = dr("status")
        End If
        disconnect()
    End Sub

#Region "Button Numbers"

    Private Sub btnNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, _
        btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btn00.Click, btnClear.Click

        If sender Is btn1 Then
            txtCashFund.Text = txtCashFund.Text & "1"
        ElseIf sender Is btn2 Then
            txtCashFund.Text = txtCashFund.Text & "2"
        ElseIf sender Is btn3 Then
            txtCashFund.Text = txtCashFund.Text & "3"
        ElseIf sender Is btn4 Then
            txtCashFund.Text = txtCashFund.Text & "4"
        ElseIf sender Is btn5 Then
            txtCashFund.Text = txtCashFund.Text & "5"
        ElseIf sender Is btn6 Then
            txtCashFund.Text = txtCashFund.Text & "6"
        ElseIf sender Is btn7 Then
            txtCashFund.Text = txtCashFund.Text & "7"
        ElseIf sender Is btn8 Then
            txtCashFund.Text = txtCashFund.Text & "8"
        ElseIf sender Is btn9 Then
            txtCashFund.Text = txtCashFund.Text & "9"
        ElseIf sender Is btn0 Then
            txtCashFund.Text = txtCashFund.Text & "0"
        ElseIf sender Is btn00 Then
            txtCashFund.Text = txtCashFund.Text & "00"
        ElseIf sender Is btnClear Then
            txtCashFund.Clear()
        End If
    End Sub

#End Region


    Private Sub btnStartShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartShift.Click
        CheckCurrentSession()
        If txtCashFund.Text.Length = 0 Then

            MsgBox("You must enter cash fund amount!", vbEmpty, "Cash Fund")
            Exit Sub

        ElseIf isSessionActive > 0 Then
            MsgBox("Session already started. You must end the current shift first. " & isSessionActive, vbEmpty, "Start session")
            Exit Sub
        Else

            connect()
            cmd = New SqlCommand(" update pos_session set sessionid = '" & NewSessionID & "' ,timestarted = '" & system_time & "', datetime = '" & system_time & "',cashierid = '" & cashier_id & "',managerid = '" & manager_id & "', " & _
                                 " cashfund = '" & txtCashFund.Text & "', status = '1' ", con)
            cmd.ExecuteNonQuery()
            disconnect()

            txtCashFund.Clear()
            session_timestarted = system_time

            DENO_1000 = 0
            DENO_500 = 0
            DENO_200 = 0
            DENO_100 = 0
            DENO_50 = 0
            DENO_20 = 0
            DENO_10 = 0
            DENO_5 = 0
            DENO_1 = 0

            cashier_name = ""
            frmMain.Panel1.Enabled = True
            frmMain.pnlProducts.Enabled = True
            frmMain.pnlConfiguration.Enabled = True
            frmMain.POS_Start()
            frmDeclareSales.Opacity = 100
            frmDeclareSales.Close()
            frmManagerLogin.Close()

            Application.Restart()

        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'frmManagerLogin.Close()
        Close()
    End Sub

End Class