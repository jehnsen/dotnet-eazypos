Imports System.Data.SqlClient

Public Class frmDiscEntry

    Dim is_new As Boolean

    Private Sub frmDiscEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetDiscounts()
    End Sub

    Friend Sub GetDiscounts()
        cmd = New SqlCommand(" select recordid,discount_name,discount_amount,discount_type from discounts ", con)
        connect()
        dr = cmd.ExecuteReader()
        lvDiscounts.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("recordid").ToString())
            Dim b = (dr.Item("discount_name").ToString())
            Dim c = (dr.Item("discount_amount").ToString()) & "%"
            Dim d = (dr.Item("discount_type").ToString())
            Dim lv As ListViewItem = lvDiscounts.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Friend Sub GetDiscountDetails()
        cmd = New SqlCommand("select recordid,discount_name,discount_amount,discount_type from " & _
                             "discounts where recordid = '" & lvDiscounts.SelectedItems(0).Text & "'", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtDiscountName.Text = dr("discount_name").ToString
            txtPercentage.Text = dr("discount_amount").ToString
            cboDiscountType.Text = dr("discount_type").ToString
        End If
        disconnect()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        is_new = True
        txtDiscountName.Clear()
        txtPercentage.Clear()

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = True
        panelDetails.Enabled = True
        txtDiscountName.Focus()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        is_new = False

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = True
        panelDetails.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If is_new = True Then
            connect()
            cmd = New SqlCommand("insert into discounts (discount_name,discount_amount,discount_type) values " & _
                                 "('" & txtDiscountName.Text & "','" & txtPercentage.Text & "','" & cboDiscountType.Text & "')", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("New record added!", vbInformation, "New Discount")
        Else
            connect()
            cmd = New SqlCommand("update discounts set discount_name='" & txtDiscountName.Text & "',discount_amount='" & txtPercentage.Text & "', " & _
                                 "discount_type='" & cboDiscountType.Text & "' where recordid = '" & lvDiscounts.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("Record successfully updated!", vbInformation, "Update Discount")
        End If
        GetDiscounts()
        lvDiscounts.Refresh()

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        panelDetails.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        connect()
        cmd = New SqlCommand("delete from discounts where recordid = '" & lvDiscounts.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        MsgBox("New record deleted!", vbInformation, "Delete Discount")
        GetDiscounts()
        lvDiscounts.Refresh()
    End Sub

    Private Sub lvDiscounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDiscounts.Click
        GetDiscountDetails()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class