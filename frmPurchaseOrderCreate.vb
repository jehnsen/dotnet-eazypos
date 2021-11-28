Imports System.Data.SqlClient

Public Class frmPurchaseOrderCreate

    Dim New_PONumber As String
    Friend is_NewPO As Boolean

    Private Sub frmPurchaseOrderCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If is_NewPO = True Then
            GetProducts()
            GetPurchasedTemp()
            GetTotalPurchaseAmount()
            GetNewPONumber()
            GetSupplier()
            GetBranch()

            txtPOTitle.Clear()
            txtShipAddress.Clear()
            txtPreparedBy.Text = ""
            txtRemarks.Clear()
            txtTerms.Clear()
            txtTelephone.Clear()
            txtUpdatedBy.Text = ""
            txtSalesman.Clear()
            txtApprovedBy.Text = ""
            txtEmail.Clear()
            txtMobileNo.Clear()
            txtAddress.Clear()
            txtNotedBy.Text = ""
            txtContactPerson.Clear()
            cboSupplier.Text = ""

        Else
            GetProducts()
            Get_PurchaseOrderHeader()
            GetPurchased_items()
            GetTotalPurchaseAmount()

        End If
        dgrItems.BackgroundColor = Color.White
        dgrPurchaseOrder.BackgroundColor = Color.White
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If is_NewPO = True Then
            SavePO()
        Else

        End If

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            connect()
            cmd = New SqlCommand("delete from purchaseorder_temp where productid = '" & dgrPurchaseOrder.CurrentRow.Cells(0).Value & "'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            GetPurchasedTemp()
            dgrPurchaseOrder.Refresh()
            GetTotalPurchaseAmount()
        Catch ex As Exception
            MsgBox("No items!", vbExclamation, "")
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim isExists As Boolean = False
        For Each itm As DataGridViewRow In dgrPurchaseOrder.Rows
            If itm.Cells(0).Value = dgrItems.CurrentRow.Cells(0).Value Then
                isExists = True
            End If
        Next

        If isExists = True Then
            connect()
            cmd = New SqlCommand("update purchaseorder_temp set quantity = quantity + 1, amount = amount + '" & dgrItems.CurrentRow.Cells(3).Value & "' " & _
                                 "where productid = '" & dgrItems.CurrentRow.Cells(0).Value & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
        Else
            connect()
            cmd = New SqlCommand("insert into purchaseorder_temp (productid,productname,unit,quantity,cost,amount,standardorder) " & _
                                 "values ('" & dgrItems.CurrentRow.Cells(0).Value & "','" & convertQuotes(dgrItems.CurrentRow.Cells(1).Value) & "', " & _
                                 "'" & dgrItems.CurrentRow.Cells(4).Value & "','1','" & dgrItems.CurrentRow.Cells(3).Value & "', " & _
                                 "'" & dgrItems.CurrentRow.Cells(3).Value & "','" & dgrItems.CurrentRow.Cells(5).Value & "')", con)
            cmd.ExecuteNonQuery()
            disconnect()
        End If

        GetPurchasedTemp()
        dgrPurchaseOrder.Refresh()
        GetTotalPurchaseAmount()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetProducts()
    End Sub

    Private Sub dgrItems_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrItems.CellDoubleClick
        btnSelect.PerformClick()
    End Sub

    Friend Sub SavePO()

        GetNewPONumber()

        connect()
        cmd = New SqlCommand("insert into purchaseorder (ponumber,potitle,datecreated,supplier,shipto,dateplaced,totalamount,terms,remarks,isplaced,preparedby,status) " & _
                             "values ('" & New_PONumber & "','" & convertQuotes(txtPOTitle.Text) & "','" & Format(Now, "MM-dd-yyyy") & "','" & cboSupplier.Text & "', " & _
                             "'" & cboShipTo.Text & "','-','" & txtTotalAmount.Text & "','" & txtPaymentTerms.Text & "','" & txtRemarks.Text & "','0','" & txtPreparedBy.Text & "','0')", con)
        cmd.ExecuteNonQuery()
        disconnect()

        Try
            For i As Integer = 0 To Me.dgrPurchaseOrder.Rows.Count - 1

                connect()
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                cmd.CommandText = "insert into purchaseorder_details (ponumber,productid,unit,quantity,cost,amount) " & _
                                  "values (@ponumber,@productid,@unit,@quantity,@cost,@amount)"

                cmd.Parameters.AddWithValue("@ponumber", New_PONumber)
                cmd.Parameters.AddWithValue("@productid", dgrPurchaseOrder.Rows(i).Cells(0).Value)
                cmd.Parameters.AddWithValue("@unit", dgrPurchaseOrder.Rows(i).Cells(2).Value)
                cmd.Parameters.AddWithValue("@quantity", dgrPurchaseOrder.Rows(i).Cells(4).Value)
                cmd.Parameters.AddWithValue("@cost", dgrPurchaseOrder.Rows(i).Cells(5).Value)
                cmd.Parameters.AddWithValue("@amount", dgrPurchaseOrder.Rows(i).Cells(6).Value)
                cmd.ExecuteNonQuery()
            Next
            disconnect()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        connect()
        cmd = New SqlCommand("DELETE FROM PURCHASEORDER_TEMP", con)
        cmd.ExecuteNonQuery()
        disconnect()

        MsgBox("Purchase Order saved!", vbInformation, "")
        frmPurchases.GetPO()
        frmPurchases.lvPurchaseOrder.Refresh()
    End Sub

    Friend Sub GetNewPONumber()
        cmd = New SqlCommand("select top 1 recordid from purchaseorder order by recordid desc", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            New_PONumber = Format(Now, "yy - ") & dr(0)
        Else
            New_PONumber = Format(Now, "yy - ") & "1"
        End If
        disconnect()
    End Sub

    Friend Sub GetProducts()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand(" SELECT PRODUCTID,PROD_DESCRIPTION,QUANTITY,COST,UNIT,STANDARDORDER FROM PRODUCTS WHERE productid not in (1,2,3,4,5,6)" & _
                                 " AND PRICE > 0", con)
        Else
            cmd = New SqlCommand(" SELECT PRODUCTID,PROD_DESCRIPTION,QUANTITY,COST,UNIT,STANDARDORDER FROM PRODUCTS " & _
                                 " WHERE PROD_DESCRIPTION LIKE '%" & convertQuotes(txtSearch.Text) & "%' OR " & _
                                 " PLU LIKE '%" & convertQuotes(txtSearch.Text) & "%' AND PRICE > 0 AND productid not in (1,2,3,4,5,6)", con)
        End If
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrItems
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
            End While
        End With
        disconnect()

    End Sub

    Friend Sub GetTotalPurchaseAmount()
        If is_NewPO = True Then

            connect()
            cmd = New SqlCommand("select amount = sum(amount) from purchaseorder_temp", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                Try
                    txtTotalAmount.Text = Format(dr(0), "###,##0.00")
                Catch ex As Exception
                    txtTotalAmount.Text = "0.00"
                End Try

            End If
            disconnect()
        Else

            connect()
            cmd = New SqlCommand("select amount = sum(amount) from purchaseorder_details WHERE PONUMBER = '" & frmPurchases.lvPurchaseOrder.SelectedItems(0).SubItems(1).Text & "'", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                Try
                    txtTotalAmount.Text = Format(dr(0), "###,##0.00")
                Catch ex As Exception
                    txtTotalAmount.Text = "0.00"
                End Try

            End If
            disconnect()

        End If
      
    End Sub

    Friend Sub GetPurchasedTemp()

        cmd = New SqlCommand(" SELECT PRODUCTID,PRODUCTNAME,UNIT,STANDARDORDER,QUANTITY,COST,AMOUNT FROM PURCHASEORDER_TEMP ", con)

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrPurchaseOrder
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
                .Rows(.Rows.Count - 1).Cells(6).Value = dr(6)
            End While
        End With
        disconnect()
    End Sub

    Friend Sub Get_PurchaseOrderHeader()
        connect()
        cmd = New SqlCommand("SELECT POTITLE,SHIPTO,DATECREATED,SUPPLIER,TOTALAMOUNT,TERMS,REMARKS,PREPAREDBY " & _
                             "FROM purchaseorder WHERE PONUMBER = '" & frmPurchases.lvPurchaseOrder.SelectedItems(0).SubItems(1).Text & "'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                txtPOTitle.Text = dr("potitle")
                txtShipAddress.Text = dr("shipto")
                dtpDateApproved.Text = dr("datecreated")
                cboSupplier.Text = dr("supplier")
                txtTotalAmount.Text = dr("totalamount")
                txtTerms.Text = dr("terms")
                txtRemarks.Text = dr("remarks")
                txtPreparedBy.Text = dr("preparedby")
            Catch ex As Exception

            End Try

        End If
        disconnect()

    End Sub

    Friend Sub GetPurchased_items()

        cmd = New SqlCommand("SELECT P.PRODUCTID,P.PROD_DESCRIPTION,PD.UNIT,P.STANDARDORDER,PD.QUANTITY,PD.COST,PD.AMOUNT FROM PRODUCTS P INNER JOIN PURCHASEORDER_DETAILS PD " & _
                             "ON P.PRODUCTID=PD.PRODUCTID WHERE PONUMBER = '" & frmPurchases.lvPurchaseOrder.SelectedItems(0).SubItems(1).Text & "' ", con)

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrPurchaseOrder
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
                .Rows(.Rows.Count - 1).Cells(6).Value = dr(6)
            End While
        End With
        disconnect()
    End Sub

    Friend Sub GetSupplier()
        cmd = New SqlCommand(" select recordid,suppliername from suppliers ", con)
        connect()
        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        'Initialize the DataTable object
        Dim dt = New DataTable
        'Populate the DataTable
        da.Fill(dt)
        'Bind the DataTable to the ComboBox
        cboSupplier.DataSource = dt
        cboSupplier.DisplayMember = "suppliername"
        cboSupplier.ValueMember = "recordid"
        'Clean up
        'da.Dispose()
        da = Nothing
        disconnect()

    End Sub

    Friend Sub GetBranch()
        cmd = New SqlCommand(" select recordid,branchname from branch ", con)
        connect()
        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        'Initialize the DataTable object
        Dim dt = New DataTable
        'Populate the DataTable
        da.Fill(dt)
        'Bind the DataTable to the ComboBox
        cboShipTo.DataSource = dt
        cboShipTo.DisplayMember = "branchname"
        cboShipTo.ValueMember = "recordid"
        'Clean up
        'da.Dispose()
        da = Nothing
        disconnect()

    End Sub

    Private Sub dgrPurchaseOrder_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrPurchaseOrder.CellEndEdit
        Try
            For i As Integer = 0 To Me.dgrPurchaseOrder.Rows.Count - 1
                dgrPurchaseOrder.Rows(i).Cells(6).Value = Format(dgrPurchaseOrder.Rows(i).Cells(4).Value * dgrPurchaseOrder.Rows(i).Cells(5).Value, "##,##0.00")

                connect()
                Dim cmd As New SqlCommand()
                cmd.Connection = con

                cmd.CommandText = "update purchaseorder_temp set amount = @amount,quantity = @quantity where productid = @productid"
                cmd.Parameters.AddWithValue("@productid", dgrPurchaseOrder.Rows(i).Cells(0).Value)
                cmd.Parameters.AddWithValue("@quantity", dgrPurchaseOrder.Rows(i).Cells(4).Value)
                cmd.Parameters.AddWithValue("@amount", dgrPurchaseOrder.Rows(i).Cells(6).Value)
                cmd.ExecuteNonQuery()

            Next
            disconnect()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        GetTotalPurchaseAmount()
    End Sub

    Private Sub cboSupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSupplier.TextChanged
        connect()
        cmd = New SqlCommand("select address,phone,contactperson,terms from suppliers where suppliername = '" & cboSupplier.Text & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtAddress.Text = dr(0).ToString
            txtTelephone.Text = dr(1).ToString
            txtContactPerson.Text = dr(2).ToString
            txtPaymentTerms.Text = dr(3).ToString
        End If
        disconnect()
    End Sub

    Private Sub cboShipTo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboShipTo.TextChanged
        connect()
        cmd = New SqlCommand("select address,phone,email from branch where branchname = '" & cboShipTo.Text & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtShipAddress.Text = dr(0).ToString
            txtShipTelephone.Text = dr(1).ToString
            txtEmail.Text = dr(2).ToString
        End If
        disconnect()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class