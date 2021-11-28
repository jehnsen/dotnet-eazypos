Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmCustomer

    Friend is_new As Boolean

    Private Sub frmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If frmMain.userType = 3 Then 'cashier
            frmMain.styleMain.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
            frmMain.Show()
        End If
    End Sub

    Private Sub frmCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        ElseIf e.KeyCode = Keys.N And e.Modifiers = Keys.Control Then
            btnNew.PerformClick()
        End If
    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            GetCustomers()
        Catch ex As Exception

        End Try
        ' user access level
        If frmMain.userType = 3 Then 'cashier
            SetUserAcess()
        End If
    End Sub

    Friend Sub SetUserAcess()
        Dim buttonId As Integer
        connect()
        cmd = New SqlCommand("SELECT Id FROM MODULES Where Cashier = 0 AND ModuleId = 4", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read

            buttonId = dr("Id")

            Select Case buttonId
                Case 15
                    btnNew.Enabled = False
                Case 16
                    btnEdit.Enabled = False
                Case 17
                    btnDelete.Enabled = False
                Case 18
                    btnProcessPayment.Enabled = False
                Case Else

            End Select

        Loop
        disconnect()

    End Sub


    Friend Sub GetCustomers()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("select customerid,firstname,lastname,address,balance,amntpaid, " & _
                                 "case when status = 1 then 'PAID' else 'UNPAID' end as 'status' from customers ORDER BY CUSTOMERID DESC", con)
        Else
            cmd = New SqlCommand("select customerid,firstname,lastname,address,balance,amntpaid, " & _
                                 "case when status = 1 then 'PAID' else 'UNPAID' end as 'status' from customers where firstname like '%" & convertQuotes(txtSearch.Text) & "%' " & _
                                 "or lastname like '%" & convertQuotes(txtSearch.Text) & "%' ORDER BY CUSTOMERID DESC", con)
        End If
        connect()
        dr = cmd.ExecuteReader
        lvUsers.Items.Clear()
        Do While dr.Read
            Dim a = (dr.Item("customerid").ToString())
            Dim b = (dr.Item("firstname").ToString())
            Dim c = (dr.Item("lastname").ToString())
            Dim d = (dr.Item("address").ToString())
            Dim e As Decimal = (dr.Item("balance").ToString())
            Dim f As Decimal = (dr.Item("amntpaid").ToString())
            Dim g = (dr.Item("status").ToString())
            Dim lv As ListViewItem = lvUsers.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(e.ToString("N2", CultureInfo.InvariantCulture))
            lv.SubItems.Add(f.ToString("N2", CultureInfo.InvariantCulture))
            lv.SubItems.Add(g)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Friend Sub GetCustomerDetails()
        cmd = New SqlCommand("select customerid,firstname,lastname,address,phone,accountno from customers where customerid = '" & lvUsers.SelectedItems(0).Text & "' ", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtCustID.Text = dr("customerid").ToString
            txtFirstname.Text = dr("firstname").ToString
            txtLastname.Text = dr("lastname").ToString
            txtAddress.Text = dr("address").ToString
            txtPhone.Text = dr("phone").ToString
            txtPhone.Text = dr("accountno").ToString
        End If
        disconnect()
    End Sub

    Friend Sub clearTextboxes()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtAccountNo.Clear()
        txtCustID.Clear()
        txtFirstname.Focus()
    End Sub

    Friend Sub EnableButtons()
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnNew.Enabled = False
        btnEdit.Enabled = False
        grpDetails.Enabled = True
        txtFirstname.Focus()
    End Sub

    Friend Sub DisableButtons()
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnNew.Enabled = True
        btnEdit.Enabled = True
        grpDetails.Enabled = False
    End Sub

    Private Sub lvUsers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvUsers.Click
        GetCustomerDetails()
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
        is_new = True
        EnableButtons()
        clearTextboxes()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        is_new = False
        EnableButtons()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        '1=regular customer
        '2=bsdc member
        Dim _custType As Integer = cboCustomerType.SelectedIndex

        If is_new = True Then
            connect()
            cmd = New SqlCommand("insert into customers (firstname,lastname,address,phone,customercode,accountno,points,balance,amntpaid,startingbal,status) values " & _
                                  "('" & convertQuotes(txtFirstname.Text) & "','" & convertQuotes(txtLastname.Text) & "','" & convertQuotes(txtAddress.Text) & "'," & _
                                  "'" & txtPhone.Text & "','" & _custType & "', '" & txtAccountNo.Text & "',0,0,0,0,1)", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("New customer added!", vbInformation, "New Customer")
        Else
            connect()
            cmd = New SqlCommand("update customers set firstname='" & convertQuotes(txtFirstname.Text) & "',lastname='" & convertQuotes(txtLastname.Text) & "'," & _
                                 "address='" & convertQuotes(txtAddress.Text) & "',phone='" & txtPhone.Text & "',accountno='" & txtAccountNo.Text & "', customercode = '" & _custType & "' " & _
                                 "where customerid = '" & lvUsers.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("Customer record was updated!", vbInformation, "Update Customer")
        End If

        GetCustomers()
        lvUsers.Refresh()
        DisableButtons()
        clearTextboxes()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        connect()
        cmd = New SqlCommand("delete from customers where customerid = '" & lvUsers.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        MsgBox("Customer record was deleted!", vbInformation, "Delete Customer")
        GetCustomers()
        lvUsers.Refresh()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetCustomers()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If txtFirstname.Text.Length = 0 Then
            Exit Sub
        End If
        frmReceivables.ShowDialog()
    End Sub

    Private Sub btnProcessPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessPayment.Click
        Try
            If txtCustID.Text.Length = 0 Then
                MsgBox("Please select customer first!", vbExclamation, "Customer")
                Exit Sub
            Else
                frmPayInvoice.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Please select customer first!", vbExclamation, "Customer")
        End Try
        
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If txtCustID.Text.Length = 0 Then
            Exit Sub
        End If

        frmEnterInvItems.ShowDialog()

        'frmReport.Generate_CustomerPurchaseHistory()
        'frmReport.ShowDialog()
    End Sub


End Class