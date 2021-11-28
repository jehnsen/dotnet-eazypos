Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmViewReturned

    Dim RetQty As Decimal

    Private Sub frmViewReturned_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            lblProductName.Text = frmItemReturn.lvItems.SelectedItems(0).SubItems(1).Text
            RetQty = frmItemReturn.lvItems.SelectedItems(0).SubItems(2).Text

            If RetQty = Int(RetQty) Then
                txtQty.Text = RetQty.ToString("N0", CultureInfo.InvariantCulture)
            Else
                txtQty.Text = RetQty.ToString("N2", CultureInfo.InvariantCulture)
            End If

        Catch ex As Exception
            lblProductName.Text = "List of returned items"
        End Try

        GetReturnedItems()

    End Sub

    Friend Sub GetReturnedItems()
        cmd = New SqlCommand(" SELECT P.PRODUCTID,RI.RECEIPTNO,P.PROD_DESCRIPTION,RI.QUANTITY,RI.DATE,RI.REMARKS FROM RETURNED_ITEMS RI INNER JOIN PRODUCTS P ON RI.PRODUCTID=P.PRODUCTID  ", con)
        connect()
        dr = cmd.ExecuteReader()
        lvItems.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("PRODUCTID").ToString())
            Dim b = (dr.Item("RECEIPTNO").ToString())
            Dim c = (dr.Item("PROD_DESCRIPTION").ToString())
            Dim d As Decimal = (dr.Item("QUANTITY").ToString())
            Dim e = (dr.Item("DATE").ToString())
            Dim f = (dr.Item("REMARKS").ToString())
            Dim lv As ListViewItem = lvItems.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            If d = Int(d) Then
                lv.SubItems.Add(d.ToString("N0", CultureInfo.InvariantCulture))
            Else
                lv.SubItems.Add(d.ToString("N2", CultureInfo.InvariantCulture))
            End If
            lv.SubItems.Add(e)
            lv.SubItems.Add(f)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Private Sub btnAddtoList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddtoList.Click
        If txtQty.Text > frmItemReturn.lvItems.SelectedItems(0).SubItems(2).Text Then
            MsgBox("The quantity you entered is more than the quantity purchased!", vbInformation, "Invalid Quantity")
            txtQty.Focus()
            Exit Sub
        ElseIf Val(txtQty.Text) = 0 Then
            MsgBox("Invalid quantity!", vbInformation, "Invalid Quantity")
            txtQty.Focus()
            Exit Sub
        Else
            connect()
            cmd = New SqlCommand(" insert into returned_items (productid,quantity,price,amount,date,remarks,status,receiptno,sessionid) values " & _
                                 " ('" & frmItemReturn.lvItems.SelectedItems(0).Text & "','" & txtQty.Text & "', " & _
                                 " '" & frmItemReturn.lvItems.SelectedItems(0).SubItems(3).Text & "','" & frmItemReturn.lvItems.SelectedItems(0).SubItems(4).Text & "', " & _
                                 " '" & system_time & "','" & cboRemarks.Text & "','" & cboStatus.Text & "','" & frmItemReturn.txtORNumber.Text & "','" & NewSessionID & "') ", con)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand(" insert into inventorytrans (itemid,returnedqty,transno,date,sessionid) values " & _
                               " ('" & frmItemReturn.lvItems.SelectedItems(0).Text & "','" & txtQty.Text & "','" & frmItemReturn.txtORNumber.Text & "','" & Format(Now, "MM/dd/yyyy") & "','" & NewSessionID & "') ", con)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("update products set quantity = quantity + '" & txtQty.Text & "' where " & _
                                 "productid = '" & frmItemReturn.lvItems.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand(" update [transaction] set returned = 1 where productid = '" & frmItemReturn.lvItems.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            frmItemReturn.SearchTransaction()
            GetReturnedItems()
            lvItems.Refresh()
            txtQty.Clear()
            lblProductName.Text = "Item was added to returned products list!"
        End If
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        connect()
        cmd = New SqlCommand(" delete from returned_items where productid = '" & lvItems.SelectedItems(0).Text & "' " & _
                             " and receiptno = '" & lvItems.SelectedItems(0).SubItems(1).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        GetReturnedItems()
        Refresh()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        connect()
        cmd = New SqlCommand(" update [transaction] set returned = 0 where productid = '" & lvItems.SelectedItems(0).Text & "' " & _
                             "and receiptno = '" & frmItemReturn.txtORNumber.Text & "' ", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand(" delete from returned_items where productid = '" & lvItems.SelectedItems(0).Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        frmItemReturn.SearchTransaction()
        GetReturnedItems()
        lvItems.Refresh()
    End Sub

End Class