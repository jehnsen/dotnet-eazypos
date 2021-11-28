Imports System.Data.SqlClient

Public Class frmAccessRoles

    Private Sub frmAccessRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetModules()
    End Sub

    Friend Sub GetModules()
        cmd = New SqlCommand("SELECT Id, Module, ModFunctions, CASE WHEN Cashier = 1 THEN 'Allowed' ELSE 'Restricted' END AS Access FROM MODULES", con)
        connect()
        dr = cmd.ExecuteReader
        lvAccessRoles.Items.Clear()
        Do While dr.Read
            Dim a = (dr.Item("Id").ToString())
            Dim b = (dr.Item("Module").ToString())
            Dim c = (dr.Item("ModFunctions").ToString())
            Dim d = (dr.Item("Access").ToString())
            Dim lv As ListViewItem = lvAccessRoles.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()


        For Each item As ListViewItem In lvAccessRoles.Items
            If item.SubItems.Item(3).Text = "Restricted" Then
                item.SubItems.Item(3).ForeColor = Color.Red
            ElseIf item.SubItems.Item(3).Text = "Allowed" Then
                item.SubItems.Item(3).ForeColor = Color.Green
            End If
        Next
    End Sub

    Private Sub btnAllow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllow.Click
        connect()
        cmd = New SqlCommand("UPDATE Modules SET Cashier = 1 WHERE Id = '" & lvAccessRoles.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        GetModules()
        lvAccessRoles.Refresh()
    End Sub

    Private Sub btnRestrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestrict.Click
        connect()
        cmd = New SqlCommand("UPDATE Modules SET Cashier = 0 WHERE Id = '" & lvAccessRoles.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        GetModules()
        lvAccessRoles.Refresh()
    End Sub
End Class