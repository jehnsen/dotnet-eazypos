Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmBrowseItems

    Friend select_mode As String
    Private Duplicate_Item As Boolean
    Public Trans_Type As String
    Dim CURR_QTY As Decimal

    Private Sub frmBrowseItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmBrowseItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_Items()
        txtSearch.Focus()
    End Sub

    Friend Sub Get_Items()
        connect()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("SELECT TOP 30 * FROM dbo.products WHERE PRODUCTID NOT IN (1,2,3,4,5,6) ORDER BY prod_description DESC", con)
        Else
            cmd = New SqlCommand("SELECT TOP 20 * FROM dbo.products WHERE PRODUCTID NOT IN (1,2,3,4,5,6) AND " & _
                                   "prod_description like '%" & convertQuotes(txtSearch.Text) & "%' ORDER BY prod_description DESC", con)
        End If
        Dim dr As SqlDataReader = cmd.ExecuteReader
        lvItems.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("itemid").ToString())
            Dim c = (dr.Item("prod_description").ToString())
            Dim d As Decimal = (dr.Item("quantity").ToString())
            Dim lv As ListViewItem = lvItems.Items.Add(a)
            lv.SubItems.Add(c)
            If d = Int(d) Then
                lv.SubItems.Add(d.ToString("N0", CultureInfo.InvariantCulture))
            Else
                lv.SubItems.Add(d.ToString("N2", CultureInfo.InvariantCulture))
            End If
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()

        For Each item As ListViewItem In Me.lvItems.Items
            If item.SubItems.Item(2).Text = 0 Then
                item.SubItems.Item(0).ForeColor = Color.Red
                item.SubItems.Item(1).ForeColor = Color.Red
                item.SubItems.Item(2).ForeColor = Color.Red

            ElseIf item.SubItems.Item(2).Text > 0 Then
                item.SubItems.Item(0).ForeColor = Color.Blue
                item.SubItems.Item(1).ForeColor = Color.Blue
                item.SubItems.Item(2).ForeColor = Color.Blue
            ElseIf item.SubItems.Item(2).Text < 0 Then
                item.SubItems.Item(0).ForeColor = Color.Violet
                item.SubItems.Item(1).ForeColor = Color.Violet
                item.SubItems.Item(2).ForeColor = Color.Violet
            End If
        Next

    End Sub

    Friend Sub Check_Duplicate_Items()
        connect()
        cmd = New SqlCommand("select * from inventorytranstemp where itemid = '" & lvItems.SelectedItems(0).Text & "'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read() = True Then
            Duplicate_Item = True
        Else
            Duplicate_Item = False
        End If
        dr.Close()
        disconnect()
        cmd.Dispose()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Get_Items()
    End Sub

    Private Sub lvItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvItems.DoubleClick

        If select_mode = "inventory" Then

            Check_Duplicate_Items()

            If Duplicate_Item = True Then
                MsgBox("Item already exist!", vbExclamation, "")
                Exit Sub
            End If

            connect()
            cmd = New SqlCommand("insert into inventorytranstemp (itemid,QUANTITY) values ('" & lvItems.SelectedItems(0).Text & "',1) ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            frmInvTrans.Get_IssuanceItems()
            frmInvTrans.Get_IssuanceItems()

        Else
            frmEnterInvItems.Inv_ItemId = lvItems.SelectedItems(0).Text
            frmEnterInvItems.txtDesc.Text = lvItems.SelectedItems(0).SubItems(1).Text
            Close()
        End If


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        txtSearch.Clear()
        txtSearch.Focus()
    End Sub
End Class