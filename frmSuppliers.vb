Imports System.Data.SqlClient

Public Class frmSuppliers

    Dim is_new As Boolean

    Private Sub frmSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetSuppliers()
        ' access level
        If frmMain.userType = 3 Then 'cashier
            SetUserAcess()
        End If
    End Sub

    Friend Sub SetUserAcess()
        Dim buttonId As Integer
        connect()
        cmd = New SqlCommand("SELECT Id FROM MODULES Where Cashier = 0 AND ModuleId = 6", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read

            buttonId = dr("Id")

            Select Case buttonId
                Case 22
                    btnNew.Enabled = False
                Case 23
                    btnEdit.Enabled = False
                Case 24
                    btnDel.Enabled = False
                Case Else

            End Select

        Loop
        disconnect()

    End Sub

    Friend Sub GetSuppliers()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("select suppliercode,suppliername from suppliers", con)
        Else
            cmd = New SqlCommand("select suppliercode,suppliername from suppliers where suppliername like '%" & convertQuotes(txtSearch.Text) & "%' ", con)
        End If
        connect()
        dr = cmd.ExecuteReader
        lvSuppliers.Items.Clear()
        Do While dr.Read
            Dim a = (dr.Item("suppliercode").ToString())
            Dim b = (dr.Item("suppliername").ToString())
            Dim lv As ListViewItem = lvSuppliers.Items.Add(a)
            lv.SubItems.Add(b)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Friend Sub GetSupplierDetails()
        cmd = New SqlCommand("select suppliercode,suppliername,contactperson,address, " & _
                             "email,website,phone,terms from suppliers where suppliercode = '" & lvSuppliers.SelectedItems(0).Text & "' ", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtSuppliercode.Text = dr("suppliercode").ToString
            txtSupplierName.Text = dr("suppliername").ToString
            txtAddress.Text = dr("address").ToString
            txtContactname.Text = dr("contactperson").ToString
            txtEmail.Text = dr("email").ToString
            txtWebsite.Text = dr("website").ToString
            txtTelephone.Text = dr("phone").ToString
            txtTerms.Text = dr("terms").ToString
        End If
        disconnect()
    End Sub

    Friend Sub ClearFields()
        txtSuppliercode.Clear()
        txtSupplierName.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtContactname.Clear()
        txtTelephone.Clear()
        txtTerms.Clear()
        txtWebsite.Clear()
    End Sub

    Private Sub lvSuppliers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSuppliers.Click
        GetSupplierDetails()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        is_new = True
        ClearFields()
        panelFields.Enabled = True
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnNew.Enabled = False
        lvSuppliers.Enabled = False
        txtSuppliercode.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If is_new = True Then
            connect()
            cmd = New SqlCommand("insert into suppliers (suppliercode,suppliername,address,email,website, " & _
                                  "contactperson,phone,terms) values ('" & txtSuppliercode.Text & "','" & convertQuotes(txtSupplierName.Text) & "', " & _
                                  "'" & convertQuotes(txtAddress.Text) & "','" & txtEmail.Text & "','" & txtWebsite.Text & "', '" & txtContactname.Text & "', " & _
                                  "'" & txtTelephone.Text & "','" & txtTerms.Text & "')", con)
            cmd.ExecuteNonQuery()
            disconnect()
        Else
            connect()
            cmd = New SqlCommand("update suppliers set suppliercode='" & txtSuppliercode.Text & "',suppliername='" & convertQuotes(txtSupplierName.Text) & "', " & _
                                 "address='" & convertQuotes(txtAddress.Text) & "',email='" & txtEmail.Text & "',website='" & txtWebsite.Text & "', " & _
                                  "contactperson='" & txtContactname.Text & "',phone='" & txtTelephone.Text & "',terms='" & txtTerms.Text & "' " & _
                                  "where suppliercode = '" & lvSuppliers.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
        End If

        GetSuppliers()
        lvSuppliers.Refresh()
        ClearFields()
        panelFields.Enabled = False
        lvSuppliers.Enabled = True

        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDel.Enabled = True
        btnNew.Enabled = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        is_new = False
        panelFields.Enabled = True
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDel.Enabled = False
        btnNew.Enabled = False
        lvSuppliers.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        connect()
        cmd = New SqlCommand("delete from suppliers where suppliercode = '" & lvSuppliers.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetSuppliers()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class