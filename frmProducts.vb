Imports System.Data.SqlClient

Public Class frmProducts

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetProducts(txtSearch.Text)
    End Sub

    Friend Sub GetProducts(ByVal Keyword As String)
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand(" SELECT PLU,PROD_DESCRIPTION,PRICE FROM PRODUCTS WHERE PRICE > 0", con)
        Else
            If cboFilter.Text = "Description" Then
                cmd = New SqlCommand(" SELECT PLU,PROD_DESCRIPTION,PRICE FROM PRODUCTS WHERE PRICE > 0 AND PROD_DESCRIPTION LIKE '%" & Keyword & "%' ", con)
            Else
                cmd = New SqlCommand(" SELECT PLU,PROD_DESCRIPTION,PRICE FROM PRODUCTS WHERE PRICE > 0 AND PLU LIKE '%" & Keyword & "%' ", con)
            End If
        End If
        connect()
        dr = cmd.ExecuteReader()
        lvProducts.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("PLU").ToString())
            Dim b = (dr.Item("PROD_DESCRIPTION").ToString())
            Dim c = (dr.Item("PRICE").ToString())
            Dim lv As ListViewItem = lvProducts.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetProducts(txtSearch.Text)
    End Sub

End Class