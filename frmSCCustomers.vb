Imports System.Data.SqlClient

Public Class frmSCCustomers


    Private Sub frmSCCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCustomers()
    End Sub

    Friend Sub GetCustomers()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand(" SELECT CUSTOMERID,FIRSTNAME,LASTNAME FROM CUSTOMERS ORDER BY CUSTOMERID ASC", con)
        Else
            cmd = New SqlCommand(" SELECT CUSTOMERID,FIRSTNAME,LASTNAME FROM CUSTOMERS WHERE FIRSTNAME LIKE '" & txtSearch.Text & "%' " & _
                                 " ORDER BY FIRSTNAME ASC", con)
        End If

        connect()
        dr = cmd.ExecuteReader()
        lvSeniorCtzen.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("CUSTOMERID").ToString())
            Dim b = (dr.Item("FIRSTNAME").ToString())
            Dim c = (dr.Item("LASTNAME").ToString())
            Dim lv As ListViewItem = lvSeniorCtzen.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetCustomers()
    End Sub

    Private Sub lvSeniorCtzen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSeniorCtzen.DoubleClick
        frmDiscount.txtSCName.Text = lvSeniorCtzen.SelectedItems(0).SubItems(1).Text & " " & lvSeniorCtzen.SelectedItems(0).SubItems(2).Text
        frmDiscount.txtSCID.Text = lvSeniorCtzen.SelectedItems(0).Text
        Me.Close()
    End Sub

End Class