Imports System.Data.SqlClient

Public Class frmManagerLogin

    Private Sub frmManagerLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Control Then
            frmConnection.ShowDialog()
        ElseIf e.KeyCode = Keys.Enter Then
            btnDone.PerformClick()
            'ElseIf e.KeyCode = Keys.NumPad0 Or e.KeyCode = Keys.D0 Then 'KEYS
            '    user_pin = user_pin & 0
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Then 'KEYS
            '    user_pin = user_pin & 1
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then 'KEYS
            '    user_pin = user_pin & 2
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Then 'KEYS
            '    user_pin = user_pin & 3
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4 Then 'KEYS
            '    user_pin = user_pin & 4
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.D5 Then 'KEYS
            '    user_pin = user_pin & 5
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6 Then 'KEYS
            '    user_pin = user_pin & 6
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7 Then 'KEYS
            '    user_pin = user_pin & 7
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad8 Or e.KeyCode = Keys.D8 Then 'KEYS
            '    user_pin = user_pin & 8
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad9 Or e.KeyCode = Keys.D9 Then 'KEYS
            '    user_pin = user_pin & 9
            '    txtPassword.Text = user_pin
        End If
        txtPassword.Focus()
    End Sub

    Private Sub frmManagerLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub ProcessLogin()

        connect()
        Dim cmd As New SqlCommand("select userid,username,password,usertype from useraccounts where password = '" & getSHA1Hash(txtPassword.Text) & "' and usertype = '2' ", con)
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        If rd.Read() = True Then

            txtPassword.Clear()
            user_pin = ""
            Me.Opacity = 0
            manager_id = rd("userid")
            If managersaccess = "cashpullout" Then
                frmCash_PullOutvb.ShowDialog()
            ElseIf managersaccess = "cashdeposit" Then
                frmCash_Receive.ShowDialog()
            ElseIf managersaccess = "startday" Then
                frmStartofDay.ShowDialog()
            ElseIf managersaccess = "endday" Then
                frmDeclareSales.ShowDialog()
            ElseIf managersaccess = "void_transaction" Then
                frmTransact_Void.ShowDialog()
            ElseIf managersaccess = "refund" Then
                frmItemReturn.ShowDialog()
            End If

        Else

            MsgBox("The Pin Number you entered is invalid!", vbExclamation, "Access Denied")
            txtPassword.Clear()
            user_pin = ""
            manager_id = ""

        End If

        rd.Close()
        cmd.Dispose()
        disconnect()

    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        ProcessLogin()
    End Sub

#Region "Button PINS"

    Private Sub btnPin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 1
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 2
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 3
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 4
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 5
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 6
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 7
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 8
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 9
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_pin = user_pin & 0
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        user_pin = ""
        txtPassword.Clear()
    End Sub

#End Region

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class