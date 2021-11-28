Imports System.Data.SqlClient

Public Class frmUsers

    Dim is_NewUser As Boolean
    Dim isEditPassword As Boolean = False
    Dim usertypecode As Integer = 3

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetUsers()
    End Sub

    Friend Sub GetUsers()
        cmd = New SqlCommand(" select userid,firstname,lastname,username from useraccounts ", con)
        connect()
        dr = cmd.ExecuteReader()
        lvUsers.Items.Clear()
        Do While dr.Read()
            Dim a = dr.Item("userid")
            Dim b = (dr.Item("firstname").ToString())
            Dim c = (dr.Item("lastname").ToString())
            Dim d = (dr.Item("username").ToString())
            Dim lv As ListViewItem = lvUsers.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()

    End Sub

    Friend Sub GetUserDetails()
        cmd = New SqlCommand("select userid,firstname,lastname,username,password, " & _
                             "case when status = '1' then 'active' else 'Inactive' end as [status], " & _
                             "case when usertype = '1' then 'Admin' when usertype = '2' then 'Manager' " & _
                             "else 'Cashier' end as [usertype] from useraccounts where userid = '" & lvUsers.SelectedItems(0).Text & "'", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtUserID.Text = dr("userid").ToString
            txtFirstname.Text = dr("firstname").ToString
            txtLastname.Text = dr("lastname").ToString
            txtUser_Username.Text = dr("username").ToString
            txtUserPasword.Text = getSHA1Hash(dr("password"))
            txtStatus.Text = dr("status").ToString
            cboUserType.Text = dr("usertype").ToString
        End If
        disconnect()

        If txtStatus.Text = "1" Then
            btnUserActivate.Text = "Deactivate"
        Else
            btnUserActivate.Text = "Activate"
        End If

    End Sub

    Friend Sub ClearFields()
        txtUserID.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtUser_Username.Clear()
        txtUserPasword.Clear()
        txtStatus.Clear()
        txtStatus.Clear()
        txtUserID.Focus()
    End Sub

    Private Sub btnUserNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserNew.Click
        is_NewUser = True
        ClearFields()
        isEditPassword = False
        txtUserPasword.Enabled = True
        btnUserUpdate.Enabled = False
        PanelUserDetails.Enabled = True
        txtFirstname.Focus()
    End Sub

    Private Sub btnUserUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserUpdate.Click
        GetUserDetails()
        is_NewUser = False
        isEditPassword = False
        PanelUserDetails.Enabled = True
        btnUserUpdate.Enabled = False
        btnUserNew.Enabled = False
        txtUserPasword.Enabled = False
    End Sub

    Private Sub btnUserSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserSave.Click

        If is_NewUser = True Then
            connect()
            cmd = New SqlCommand(" insert into useraccounts (firstname,lastname,username,password,usertype,status) values " & _
                                 " ('" & txtFirstname.Text & "','" & txtLastname.Text & "','" & txtUser_Username.Text & "','" & getSHA1Hash(txtUserPasword.Text) & "', " & _
                                 " '" & usertypecode & "','1') ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("New User Added!", vbInformation, "")
        Else
            If isEditPassword = False Then
                connect()
                cmd = New SqlCommand(" update useraccounts set firstname = '" & txtFirstname.Text & "',lastname = '" & txtLastname.Text & "' ,username = '" & txtUser_Username.Text & "' " & _
                                     " where userid = '" & lvUsers.SelectedItems(0).Text & "' ", con)
                cmd.ExecuteNonQuery()
                disconnect()
                MsgBox("User Info was updated!", vbInformation, "")
            Else
                connect()
                cmd = New SqlCommand(" update useraccounts set password = '" & getSHA1Hash(txtUserPasword.Text) & "' " & _
                                     " where userid = '" & lvUsers.SelectedItems(0).Text & "' ", con)
                cmd.ExecuteNonQuery()
                disconnect()
                MsgBox("User Password was updated!", vbInformation, "")
            End If
        End If
        PanelUserDetails.Enabled = False

        GetUsers()
        lvUsers.Refresh()
        PanelUserDetails.Enabled = False
        btnUserNew.Enabled = True
        btnUserUpdate.Enabled = True
        isEditPassword = False
    End Sub

    Private Sub btnUserActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserActivate.Click
        If txtStatus.Text = 1 Then
            connect()
            cmd = New SqlCommand("update useraccounts set status = '1' where userid = '" & lvUsers.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
        Else
            connect()
            cmd = New SqlCommand("update useraccounts set status = '2' where userid = '" & lvUsers.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
        End If
        PanelUserDetails.Enabled = False
    End Sub

    Private Sub btnUserClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserClose.Click
        Close()
    End Sub

    Private Sub lvUsers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvUsers.Click
        GetUserDetails()
    End Sub

    Private Sub cboUserType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUserType.SelectedIndexChanged
        If cboUserType.Text = "Manager" Then
            usertypecode = 2
        Else
            usertypecode = 3
        End If
    End Sub

    Private Sub MbGlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MbGlassButton1.Click
        PanelUserDetails.Enabled = True

        txtFirstname.Enabled = False
        txtLastname.Enabled = False
        txtUser_Username.Enabled = False
        txtStatus.Enabled = False
        cboUserType.Enabled = False
        btnUserUpdate.Enabled = False
        btnUserNew.Enabled = False

        txtUserPasword.Enabled = True
        txtUserPasword.Clear()
        txtUserPasword.Focus()
        isEditPassword = True
    End Sub

End Class