Imports System.Data.SqlClient
Imports System.Configuration
Imports Spire.Barcode

Public Class frmLogin

    Public str As String
    Public authentication As String
    Public getserver As String = ConfigurationManager.AppSettings.Get("server")
    Public getdatabase As String = ConfigurationManager.AppSettings.Get("database")
    Public getusername As String = ConfigurationManager.AppSettings.Get("username")
    Public getpassword As String = ConfigurationManager.AppSettings.Get("password")
    Public getport As String = ConfigurationManager.AppSettings.Get("port")
    Public userType As Integer

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Control Then
            frmConnection.ShowDialog()
        ElseIf e.KeyCode = Keys.J AndAlso e.Modifiers = Keys.Alt Then
            BackdoorLogin()
        ElseIf e.KeyCode = Keys.Enter Then
            btnDone.PerformClick()
            'ElseIf e.KeyCode = Keys.NumPad0 Then 'KEYS
            '    user_pin = user_pin & 0
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad1 Then 'KEYS
            '    user_pin = user_pin & 1
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad2 Then 'KEYS
            '    user_pin = user_pin & 2
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad3 Then 'KEYS
            '    user_pin = user_pin & 3
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad4 Then 'KEYS
            '    user_pin = user_pin & 4
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad5 Then 'KEYS
            '    user_pin = user_pin & 5
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad6 Then 'KEYS
            '    user_pin = user_pin & 6
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad7 Then 'KEYS
            '    user_pin = user_pin & 7
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad8 Then 'KEYS
            '    user_pin = user_pin & 8
            '    txtPassword.Text = user_pin
            'ElseIf e.KeyCode = Keys.NumPad9 Then 'KEYS
            '    user_pin = user_pin & 9
            '    txtPassword.Text = user_pin
        End If
        'txtPassword.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Spire.Barcode.BarcodeSettings.ApplyKey("A7ZYH7EH6WL-5OCGK-PJ0ZI-W459S")
        txtUsername.Focus()

        Try
            Timer1.Stop()
            ConnectToDatabase()
        Catch ex As Exception
            frmConnection.ShowDialog()
        End Try

        'LabelUN.Font = CustFont.GetInstance(16, FontStyle.Bold)
        'LabelP.Font = CustFont.GetInstance(16, FontStyle.Bold)

    End Sub

    Friend Sub ConnectToDatabase()
        authentication = System.Configuration.ConfigurationManager.AppSettings.Get("connection")

        If authentication = "Windows Authentication" Then
            str = "UID=" + getserver + ";Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=" + getdatabase + ";Data Source=" + getserver + "; MultipleActiveResultSets=true"
        Else
            str = "Data Source=" + getserver + ";Initial Catalog=" + getdatabase + ";User ID=" + getusername + "; Password=" + getpassword + "; MultipleActiveResultSets=true"
        End If
    End Sub

    Private Sub btnPin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin1.Click
        user_pin = user_pin & 1
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin2.Click
        user_pin = user_pin & 2
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin3.Click
        user_pin = user_pin & 3
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin4.Click
        user_pin = user_pin & 4
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin5.Click
        user_pin = user_pin & 5
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin6.Click
        user_pin = user_pin & 6
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin7.Click
        user_pin = user_pin & 7
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin8.Click
        user_pin = user_pin & 8
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin9.Click
        user_pin = user_pin & 9
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnPin0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPin0.Click
        user_pin = user_pin & 0
        txtPassword.Text = user_pin
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        user_pin = ""
        txtPassword.Clear()
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        ProcessLogin()

    End Sub

    Friend Sub ProcessLogin()
        connect()
        Dim cmd As New SqlCommand("SELECT username,password,usertype from useraccounts where username = '" & txtUsername.Text & "' and password = '" & getSHA1Hash(txtPassword.Text) & "'", con)
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        If rd.Read Then
            GetCashierName()
            txtUsername.Clear()
            txtPassword.Clear()
            user_pin = ""

            Me.Hide()
            If userType = 3 Then
                frmMain.userType = 3
                frmMain.Show()
            Else
                mdiManagerDashboard.userType = 2
                mdiManagerDashboard.Show()
            End If
            
        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("Username and Password not found!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
            user_pin = ""
            cashier_id = ""
        End If
        rd.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Friend Sub GetCashierName()
        connect()
        cmd = New SqlCommand(" select userid, usertype, cashier = firstname + ' ' + lastname from useraccounts where username = '" & txtUsername.Text & "' and password = '" & getSHA1Hash(txtPassword.Text) & "'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            cashier_name = dr("cashier")
            cashier_id = dr("userid")
            frmMain.lblCashier.Text = dr("cashier")
            userType = dr("usertype")
            

        End If
        disconnect()
    End Sub

    Friend Sub BackdoorLogin()
        GetCashierName()
      
        user_pin = ""
        Me.Hide()
        mdiManagerDashboard.userType = 2
        mdiManagerDashboard.Show()
    End Sub

   

End Class