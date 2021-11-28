Imports System.Data.SqlClient

Public Class frmShortcutkeys

    Private Sub frmShortcutkeys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetShortcutKeys()
    End Sub

    Friend Sub GetShortcutKeys()
        cmd = New SqlCommand("select functionname,shortcutkey from shortcutkeys", con)
        connect()
        dr = cmd.ExecuteReader()
        lvShortcutKeys.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("functionname").ToString())
            Dim b = (dr.Item("shortcutkey").ToString())
            Dim lv As ListViewItem = lvShortcutKeys.Items.Add(a)
            lv.SubItems.Add(b)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class