Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmItemMaintenance

    Dim selRow As Integer
    Dim selCol As Integer

    Dim is_newproduct As Boolean
    Dim CURR_QTY As Decimal
    Dim is_Duplicate As Boolean

    Private Sub frmItemMaintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.styleMain.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        'mdiManagerDashboard.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
    End Sub

    Private Sub frmItemMaintenance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        ElseIf e.KeyCode = Keys.S And e.Modifiers = Keys.Control Then
            txtSearch.Focus()
        End If
    End Sub

    Private Sub frmItemMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If is_newproduct = True Then
            ClearFields()
        Else
            txtQTY.ReadOnly = True
        End If

        GetDepartment()
        GetCategory()
        GetSupplier()
        GetItems()
        ResetProperties()
        txtSearch.Enabled = True

        ' user access
        If frmLogin.userType = 3 Then 'cashier
            SetUserAcess()
        End If

        dgrItems.BackgroundColor = Color.White
    End Sub

    Friend Sub SetUserAcess()
        Dim buttonId As Integer
        connect()
        cmd = New SqlCommand("SELECT Id FROM MODULES Where Cashier = 0 AND ModuleId = 1", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read

            buttonId = dr("Id")

            Select Case buttonId
                Case 1
                    btnNew.Enabled = False
                Case 2
                    btnUpdate.Enabled = False
                Case 3
                    btnDelete.Enabled = False
                Case 4
                    btnActivate.Enabled = False
                Case 50
                    btnAddCategory.Enabled = False
                Case Else

            End Select

        Loop
        disconnect()

    End Sub


    Friend Sub GetItems()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("SELECT TOP 80 RECORDID,PLU,PROD_DESCRIPTION," & _
                                       " CASE WHEN PRICE = '0' THEN '0.00' ELSE PRICE END AS [PRICE],WS_PRICE FROM PRODUCTS WHERE PRODUCTID NOT IN (1,2,3,4,5,6) ORDER BY PROD_DESCRIPTION ASC", con)
        Else
            cmd = New SqlCommand("SELECT TOP 80 RECORDID,PLU,PROD_DESCRIPTION," & _
                                 "CASE WHEN PRICE = '0' THEN '0.00' ELSE PRICE END AS [PRICE],WS_PRICE FROM PRODUCTS  WHERE PRODUCTID NOT IN (1,2,3,4,5,6) AND " & _
                                 "PROD_DESCRIPTION LIKE '%" & convertQuotes(txtSearch.Text) & "%' ORDER BY PROD_DESCRIPTION ASC", con)
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
            End While
        End With
        disconnect()

        If dgrItems.SelectedRows.Count > 0 Then
            Try
                Dim X, Y As Integer
                X = dgrItems.CurrentCell.RowIndex
                Y = dgrItems.CurrentCell.ColumnIndex

                If (dgrItems.Rows.Count - 1) > selRow Then
                    dgrItems.ClearSelection()
                    dgrItems.Rows(selRow).Cells(selCol).Selected = True
                End If

                dgrItems.CurrentCell = dgrItems.Rows(selRow).Cells(selCol)
                dgrItems.Rows(selRow).Cells(selCol).Selected = True
            Catch ex As Exception
            End Try
        End If


        Try
            GetItemDetails()
            lblItemCount.Text = "Items Found: " & dgrItems.RowCount
        Catch ex As Exception

        End Try

    End Sub

    Friend Sub GetItemDetails()

        If dgrItems.RowCount = 0 Then
            ClearFields()
            Exit Sub
        End If

        connect()
        cmd = New SqlCommand(" select PLU,prod_description,quantity=ISNULL(quantity,0),price,ws_price,cost,unit,department,category,supplier,expiredate=ISNULL(CONVERT(VARCHAR(10), expiredate, 101),''), " & _
                             "CASE WHEN status = 1 THEN 'ACTIVE' ELSE 'INACTIVE' END AS [status] from products where RECORDID = '" & dgrItems.CurrentRow.Cells(0).Value & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                txtLookupCode.Text = dr("plu").ToString
                txtDescription.Text = dr("prod_description").ToString
                CURR_QTY = dr("quantity")
                txtRPrice.Text = Format(dr("price"), "0.00")
                txtWSPrice.Text = Format(dr("ws_price"), "0.00")
                txtCost.Text = Format(dr("cost"), "0.00")
                cboUnit.Text = dr("UNIT").ToString
                cboDepartment.Text = dr("department").ToString
                cboCategory.Text = dr("category").ToString
                cboSupplier.Text = dr("supplier").ToString
                txtStatus.Text = dr("status").ToString
                dtpExpirationDate.Text = dr("expiredate")
            Catch ex As Exception
                dtpExpirationDate.Text = ""
            End Try
        End If
        disconnect()

        If CURR_QTY = Int(CURR_QTY) Then
            txtQTY.Text = CURR_QTY.ToString("N0", CultureInfo.InvariantCulture)
        Else
            txtQTY.Text = CURR_QTY.ToString("N2", CultureInfo.InvariantCulture)
        End If

        If txtStatus.Text = "ACTIVE" Then
            btnActivate.Text = "Deactivate"
            btnActivate.Image = My.Resources.deactivate1
        Else
            btnActivate.Text = "Activate"
            btnActivate.Image = My.Resources.activate
        End If

    End Sub

    Friend Sub GetDepartment()
        cmd = New SqlCommand(" select dept_id,dept_id,dept_name from department ", con)

        connect()

        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        'Initialize the DataTable object
        Dim dt = New DataTable

        'Populate the DataTable
        da.Fill(dt)

        'Bind the DataTable to the ComboBox
        cboDepartment.DataSource = dt
        cboDepartment.DisplayMember = "dept_name"
        cboDepartment.ValueMember = "dept_id"

        cboDepartmentID.DataSource = dt
        cboDepartmentID.DisplayMember = "dept_id"
        cboDepartmentID.ValueMember = "dept_id"

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Friend Sub GetCategory()
        cmd = New SqlCommand(" select cat_id,cat_name from category ", con)

        connect()

        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        'Initialize the DataTable object
        Dim dt = New DataTable

        'Populate the DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
        End Try

        'Bind the DataTable to the ComboBox
        cboCategory.DataSource = dt
        cboCategory.DisplayMember = "cat_name"
        cboCategory.ValueMember = "cat_id"

        cboCategoryID.DataSource = dt
        cboCategoryID.DisplayMember = "cat_id"
        cboCategoryID.ValueMember = "cat_id"

        'Clean up
        'da.Dispose()
        da = Nothing

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
        Try
            da.Fill(dt)
        Catch ex As Exception
        End Try

        'Bind the DataTable to the ComboBox
        cboSupplier.DataSource = dt
        cboSupplier.DisplayMember = "suppliername"
        cboSupplier.ValueMember = "recordid"

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Friend Sub ClearFields()
        txtLookupCode.Clear()
        txtDescription.Clear()
        txtRPrice.Clear()
        txtWSPrice.Clear()
        txtCost.Clear()
        txtQTY.Clear()
        cboUnit.Text = ""
        cboSupplier.Text = ""
        cboCategory.Text = ""
        cboDepartment.Text = ""
        dtpExpirationDate.Text = ""
        txtPoints.Clear()
        txtStatus.Clear()
        txtQTY.ReadOnly = False
    End Sub

    Friend Sub ResetProperties()
        is_newproduct = True
        btnNew.Enabled = True
        btnUpdate.Enabled = True
        btnSave.Enabled = False
        dgrItems.Enabled = True
        panelDetails.Enabled = False
        cboDepartment.Enabled = True
        cboCategory.Enabled = True

    End Sub

    Friend Sub Check_Duplicate()

        connect()
        cmd = New SqlCommand("select prod_description from dbo.products where prod_description = '" & convertQuotes(txtDescription.Text) & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read() = True Then
            is_Duplicate = True
        Else
            is_Duplicate = False
        End If
        cmd.Dispose()
        dr.Close()
        disconnect()

    End Sub

    Private Sub cboDepartmentID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartmentID.SelectedIndexChanged
        GetCategory()
    End Sub

    Private Sub cboCategoryID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoryID.SelectedIndexChanged
        'GetItems()
    End Sub

    Private Sub dgrItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrItems.CellClick
        selRow = dgrItems.CurrentCell.RowIndex
        selCol = dgrItems.CurrentCell.ColumnIndex
        GetItemDetails()
    End Sub

    Friend Sub Generate_ID()
        connect()
        cmd = New SqlCommand("limit select * from products  ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtLookupCode.Text = dr("plu").ToString
            txtDescription.Text = dr("prod_description").ToString
            txtRPrice.Text = Format(dr("price"), "0.00")
            txtWSPrice.Text = Format(dr("ws_price"), "0.00")
            cboDepartment.Text = dr("department").ToString
            cboCategory.Text = dr("category").ToString
            cboSupplier.Text = dr("supplier").ToString
            txtStatus.Text = dr("status").ToString
        Else

        End If
        disconnect()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtDescription.Text.Length = 0 Or _
              txtRPrice.Text.Length = 0 Then

            MsgBox("Please fill the required fields!", vbExclamation, "REQUIRED")
            Exit Sub

        Else

            If is_newproduct = True Then

                Check_Duplicate() ' Check for duplicate description
                If is_Duplicate = True Then
                    DevComponents.DotNetBar.MessageBoxEx.Show("Item description already exist!", "Filter Entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                connect()
                cmd = New SqlCommand("insert into products (plu,prod_description,cost,unit,quantity,dailybqty,price,ws_price,department,category,supplier,maxlevel,minlevel,status," & _
                                     "reorderpoint,discount_rate,discount_type,standardorder,buttonid,departmentid,categoryid,monthlybqty,adjqty,expiredate) values " & _
                                     "('" & txtLookupCode.Text & "','" & convertQuotes(txtDescription.Text) & "','" & txtCost.Text & "','" & cboUnit.Text & "','" & txtQTY.Text & "','" & txtQTY.Text & "', " & _
                                     "'" & txtRPrice.Text & "','" & txtWSPrice.Text & "','" & cboDepartment.Text & "','" & cboCategory.Text & "'," & _
                                     "'" & convertQuotes(cboSupplier.Text) & "',0,0,1,0,0,'',0,0,'" & cboDepartmentID.Text & "','" & cboCategoryID.Text & "','" & txtQTY.Text & "',0,'" & dtpExpirationDate.Text & "') ", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand("update products set itemid = recordid, productid = recordid ", con)
                cmd.ExecuteNonQuery()
                disconnect()
                DevComponents.DotNetBar.MessageBoxEx.Show("New item added!", "NEW ITEM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                connect()
                cmd = New SqlCommand("update products set plu = '" & txtLookupCode.Text & "', prod_description = '" & convertQuotes(txtDescription.Text) & "', unit = '" & cboUnit.Text & "', " & _
                                     "cost = '" & txtCost.Text & "', price = '" & txtRPrice.Text & "',ws_price = '" & txtWSPrice.Text & "',department='" & cboDepartment.Text & "', category='" & cboCategory.Text & "', " & _
                                     "QUANTITY = '" & txtQTY.Text & "', supplier = '" & convertQuotes(cboSupplier.Text) & "', expiredate= '" & dtpExpirationDate.Text & "' where recordid = '" & dgrItems.CurrentRow.Cells(0).Value & "' ", con)
                cmd.ExecuteNonQuery()
                disconnect()
                DevComponents.DotNetBar.MessageBoxEx.Show("Item successfully updated!", "ITEM UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            dgrItems.Enabled = True
            GetItems()
            dgrItems.Update()
            ClearFields()
            btnNew.Enabled = True
            btnUpdate.Enabled = True
            btnSave.Enabled = False
            panelDetails.Enabled = False
            cboDepartment.Enabled = True
            cboCategory.Enabled = True
            txtSearch.Enabled = True


            frmMain.GetDGProducts()
            frmMain.dgrProducts.Update()

        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        is_newproduct = True
        ClearFields()
        btnUpdate.Enabled = False
        btnNew.Enabled = False
        btnSave.Enabled = True
        dgrItems.Enabled = False
        panelDetails.Enabled = True
        txtQTY.Enabled = True
        txtRPrice.Text = 0
        txtCost.Text = 0
        txtWSPrice.Text = 0
        txtQTY.Text = 0
        txtDescription.Focus()
        txtSearch.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtDescription.Text.Length = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please select an items first!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        is_newproduct = False
        btnUpdate.Enabled = False
        btnNew.Enabled = False
        btnSave.Enabled = True
        dgrItems.Enabled = False
        panelDetails.Enabled = True
        txtSearch.Enabled = False

        'txtQTY.Enabled = False
    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        Try
            If txtStatus.Text = "ACTIVE" Then
                cmd = New SqlCommand("update products set status = '0' where plu = '" & txtLookupCode.Text & "' ", con)
                connect()
                cmd.ExecuteNonQuery()
                disconnect()
                MsgBox("Item successfully deactivated!", vbInformation, "")
            Else
                cmd = New SqlCommand("update products set status = '1' where plu = '" & txtLookupCode.Text & "' ", con)
                connect()
                cmd.ExecuteNonQuery()
                disconnect()
                MsgBox("Item successfully activated!", vbInformation, "")
            End If

            GetItems()
            dgrItems.Refresh()
            GetItemDetails()
            btnNew.Enabled = True
            btnUpdate.Enabled = True
            btnSave.Enabled = False
            btnActivate.Enabled = False
            panelDetails.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetItems()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo) = vbYes Then
            connect()
            cmd = New SqlCommand("delete from products where recordid = '" & dgrItems.CurrentRow.Cells(0).Value & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("Item successfully deleted!", vbInformation, "Delete")
            GetItems()
            dgrItems.Refresh()

            frmMain.GetDGProducts()
            frmMain.dgrProducts.Update()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCategory.Click
        frmCategory.ShowDialog()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click       
        frmBarcodeGenerator.ShowDialog()
    End Sub

End Class