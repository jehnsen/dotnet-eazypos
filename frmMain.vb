Imports System.Data.SqlClient
Imports DevComponents.DotNetBar
Imports System.Collections.ObjectModel
Imports Microsoft.Win32
Imports System.Globalization

Public Class frmMain

    Public constring As String
    Public userType As Integer
    Dim ProdTransaction_ID As Integer
    Dim RecordId As Integer

    Dim selRow As Integer
    Dim selCol As Integer

    Dim Is_DoubleDiscount As Boolean
    Dim Is_ReorderStock As Boolean = False

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.P And e.Modifiers = Keys.Control
                frmPrinterOptions.ShowDialog()
            Case Keys.Tab
                txtSearchBox.Focus()
            Case Keys.Delete
                txtSearchBox.Clear()
            Case Keys.F4
                btnQty.PerformClick()
            Case Keys.F6
                btnRemove.PerformClick()
            Case Keys.F10
                btnCashPayment.PerformClick()
            Case Keys.F11
                btnChargePayment.PerformClick()
            Case Keys.F12
                btnSplitPayment.PerformClick()
            Case Keys.Enter
                Trigger_Scanner()
            Case Keys.P And e.Modifiers = Keys.Alt
                btnOtherMenus.PerformClick()

        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAllComponents()
        GetVatValue()
        txtSearchBox.Focus()

        dgrTransaction.Columns(0).ReadOnly = True
        dgrTransaction.Columns(1).ReadOnly = True
        dgrTransaction.Columns(2).ReadOnly = True
        dgrTransaction.Columns(3).ReadOnly = True
        dgrTransaction.Columns(5).ReadOnly = True
        dgrTransaction.Columns(6).ReadOnly = True
        dgrTransaction.Columns(7).ReadOnly = True
        dgrTransaction.Columns(8).ReadOnly = True
        dgrTransaction.Columns(9).ReadOnly = True
        dgrTransaction.Columns(10).ReadOnly = True

        pnlProducts.Dock = DockStyle.Fill

        btnOtherMenus.PerformClick()

        GetUserAccess() ' access level 

        GetInventoryStatus() ' display inventory alerts (out of stock, for re-order items)

        CalculateTotalTransactionAmount()

        lblAddOnFee.Font = CustFont.GetInstance(20, FontStyle.Bold)
        lblTotal.Font = CustFont.GetInstance(28, FontStyle.Bold)
        LabelTotal.Font = CustFont.GetInstance(28, FontStyle.Bold)
        lblDiscount.Font = CustFont.GetInstance(20, FontStyle.Bold)
        LabelDiscount.Font = CustFont.GetInstance(18, FontStyle.Bold)
        LabelCharges.Font = CustFont.GetInstance(18, FontStyle.Bold)

    End Sub

    Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        system_time = Format(Now, "MM-dd-yyyy hh:mm tt")

        'If Is_ReorderStock = True Then
        '    lblInvNotification.Visible = Not lblInvNotification.Visible
        'End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        CheckReorderItems()
    End Sub

    Friend Sub GetUserAccess()
        Dim buttonId As Integer
        connect()
        cmd = New SqlCommand("SELECT Id, Module, ModFunctions FROM MODULES Where Cashier = 0 AND ModuleId IN (7,8)", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read

            buttonId = dr("Id")

            Select Case buttonId
                Case 25
                    btnStartDay.Enabled = False
                Case 26
                    btnDeclareSales.Enabled = False
                Case 27
                    btnCashPullOut.Enabled = False
                Case 28
                    btnCashDeposit.Enabled = False
                Case 29
                    btnReturn.Enabled = False
                Case 30
                    btnReprintReceipt.Enabled = False
                Case 31
                    btnHoldRecall.Enabled = False
                Case 32
                    btnVoidTransaction.Enabled = False
                Case 33
                    btnSettings.Enabled = False
                Case 34
                    btnInventory.Enabled = False
                Case 35
                    btnPurchaseOrders.Enabled = False
                Case 36
                    btnViewCust.Enabled = False
                Case 37
                    btnViewCust.SubItems.Item(2).Enabled = False
                Case 38
                    btnViewCust.SubItems.Item(1).Enabled = False
                Case 39
                    btnViewCust.SubItems.Item(0).Enabled = False
                Case 53
                    btnViewCust.SubItems.Item(0).Enabled = False
                Case 40
                    ButtonX1.Enabled = False
                Case 41
                    ButtonX2.Enabled = False
                Case 42
                    btnCashPayment.Enabled = False
                Case 43
                    btnChargePayment.Enabled = False
                Case 44
                    btnQty.Enabled = False
                Case 45
                    btnRemove.Enabled = False
                Case 46
                    btnAddDiscounts.Enabled = False
                Case 47
                    btnRemoveDisc.Enabled = False
                Case 48
                    btnEditLinePrice.Enabled = False
                Case 51
                    btnClearAll.Enabled = False
                Case 52
                    btnCustCard.Enabled = False
                Case Else

            End Select

        Loop
        disconnect()

        'frmItemMaintenance.btnNew.Enabled = False

    End Sub

    Friend Sub POS_Start()
        connect()
        cmd = New SqlCommand(" select top 1 status,sessionid from pos_session", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            POS_Security = dr("status")
            NewSessionID = dr("sessionid")
        End If
        disconnect()

        If POS_Security = 1 Then
            Transaction()
            GetDGProducts()
            'GetProducts()
            GetDepartment()
            GetCategory()
            GetLast_TransactionNo()
            btnDept1.PerformClick()
            btnCat1.PerformClick()
        Else
            Panel1.Enabled = False
            pnlProducts.Enabled = False
            pnlConfiguration.Enabled = False
            managersaccess = "startday"

            If frmManagerLogin.Visible = True Then
                frmManagerLogin.Opacity = 100
                frmManagerLogin.Show()
            Else
                frmManagerLogin.ShowDialog()
                Me.Hide()
            End If
        End If

    End Sub

    Friend Sub GetProducts()

        ResetAll_Button()

        connect()
        cmd = New SqlCommand(" select buttonid,productid,plu,prod_description,price,departmentid,categoryid, cost from products where departmentid = '" & dept_id & "' and categoryid = '" & cat_id & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read
            product_plu = dr("plu")
            product_id = dr("productid")
            button_id = dr("buttonid").ToString
            product_desc = dr("prod_description").ToString
            product_price = dr("price")


            Select Case button_id

                Case 1
                    btnProd1.Tag = product_price
                    btnProd1.Text = product_desc
                    btnProd1.TabIndex = product_id
                    btnProd1.AccessibleName = dept_name
                    btnProd1.AccessibleDescription = cat_name
                Case 2
                    btnProd2.Tag = product_price
                    btnProd2.Text = product_desc
                    btnProd2.TabIndex = product_id
                    btnProd2.AccessibleName = dept_name
                    btnProd2.AccessibleDescription = cat_name
                Case 3
                    btnProd3.Tag = product_price
                    btnProd3.Text = product_desc
                    btnProd3.TabIndex = product_id
                    btnProd3.AccessibleName = dept_name
                    btnProd3.AccessibleDescription = cat_name
                Case 4
                    btnProd4.Tag = product_price
                    btnProd4.Text = product_desc
                    btnProd4.TabIndex = product_id
                    btnProd4.AccessibleName = dept_name
                    btnProd4.AccessibleDescription = cat_name
                Case 5
                    btnProd5.Tag = product_price
                    btnProd5.Text = product_desc
                    btnProd5.TabIndex = product_id
                    btnProd5.AccessibleName = dept_name
                    btnProd5.AccessibleDescription = cat_name
                Case 6
                    btnProd6.Tag = product_price
                    btnProd6.Text = product_desc
                    btnProd6.TabIndex = product_id
                    btnProd6.AccessibleName = dept_name
                    btnProd6.AccessibleDescription = cat_name
                Case 7
                    btnProd7.Tag = product_price
                    btnProd7.Text = product_desc
                    btnProd7.TabIndex = product_id
                    btnProd7.AccessibleName = dept_name
                    btnProd7.AccessibleDescription = cat_name
                Case 8
                    btnProd8.Tag = product_price
                    btnProd8.Text = product_desc
                    btnProd8.TabIndex = product_id
                    btnProd8.AccessibleName = dept_name
                    btnProd8.AccessibleDescription = cat_name
                Case 9
                    btnProd9.Tag = product_price
                    btnProd9.Text = product_desc
                    btnProd9.TabIndex = product_id
                    btnProd9.AccessibleName = dept_name
                    btnProd9.AccessibleDescription = cat_name
                Case 10
                    btnProd10.Tag = product_price
                    btnProd10.Text = product_desc
                    btnProd10.TabIndex = product_id
                    btnProd10.AccessibleName = dept_name
                    btnProd10.AccessibleDescription = cat_name
                Case 11
                    btnProd11.Tag = product_price
                    btnProd11.Text = product_desc
                    btnProd11.TabIndex = product_id
                    btnProd11.AccessibleName = dept_name
                    btnProd11.AccessibleDescription = cat_name
                Case 12
                    btnProd12.Tag = product_price
                    btnProd12.Text = product_desc
                    btnProd12.TabIndex = product_id
                    btnProd12.AccessibleName = dept_name
                    btnProd12.AccessibleDescription = cat_name
                Case 13
                    btnProd13.Tag = product_price
                    btnProd13.Text = product_desc
                    btnProd13.TabIndex = product_id
                    btnProd13.AccessibleName = dept_name
                    btnProd13.AccessibleDescription = cat_name
                Case 14
                    btnProd14.Tag = product_price
                    btnProd14.Text = product_desc
                    btnProd14.TabIndex = product_id
                    btnProd14.AccessibleName = dept_name
                    btnProd14.AccessibleDescription = cat_name
                Case 15
                    btnProd15.Tag = product_price
                    btnProd15.Text = product_desc
                    btnProd15.TabIndex = product_id
                    btnProd15.AccessibleName = dept_name
                    btnProd15.AccessibleDescription = cat_name
                Case 16
                    btnProd16.Tag = product_price
                    btnProd16.Text = product_desc
                    btnProd16.TabIndex = product_id
                    btnProd16.AccessibleName = dept_name
                    btnProd16.AccessibleDescription = cat_name
                Case 17
                    btnProd17.Tag = product_price
                    btnProd17.Text = product_desc
                    btnProd17.TabIndex = product_id
                    btnProd17.AccessibleName = dept_name
                    btnProd17.AccessibleDescription = cat_name
                Case 18
                    btnProd18.Tag = product_price
                    btnProd18.Text = product_desc
                    btnProd18.TabIndex = product_id
                    btnProd18.AccessibleName = dept_name
                    btnProd18.AccessibleDescription = cat_name
                Case 19
                    btnProd19.Tag = product_price
                    btnProd19.Text = product_desc
                    btnProd19.TabIndex = product_id
                    btnProd19.AccessibleName = dept_name
                    btnProd19.AccessibleDescription = cat_name
                Case 20
                    btnProd20.Tag = product_price
                    btnProd20.Text = product_desc
                    btnProd20.TabIndex = product_id
                    btnProd20.AccessibleName = dept_name
                    btnProd20.AccessibleDescription = cat_name
            End Select


        Loop
        disconnect()


        GetDGProducts()
    End Sub

    Friend Sub GetDGProducts()

        If SwitchButton1.Value = True Then
            If txtSearchBox.Text.Length = 0 Then
                cmd = New SqlCommand("select top 50 productid,plu,prod_description,WS_price,department,category,quantity,quantity from products WHERE PRODUCTID NOT IN (1,2,3,4,5,6)", con)
            Else
                cmd = New SqlCommand("select top 50 productid,plu,prod_description,WS_price,department,category,quantity,quantity from products WHERE PRODUCTID NOT IN (1,2,3,4,5,6) and prod_description like '%" & convertQuotes(txtSearchBox.Text) & "%' " & _
                                     "or plu like '" & convertQuotes(txtSearchBox.Text) & "%' ", con)
            End If

        Else
            If txtSearchBox.Text.Length = 0 Then
                cmd = New SqlCommand("select top 50 productid,plu,prod_description,price,department,category,quantity,quantity from products WHERE PRODUCTID NOT IN (1,2,3,4,5,6)", con)
            Else
                cmd = New SqlCommand("select top 50 productid,plu,prod_description,price,department,category,quantity,quantity from products WHERE PRODUCTID NOT IN (1,2,3,4,5,6) and prod_description like '%" & convertQuotes(txtSearchBox.Text) & "%' " & _
                                     "or plu like '%" & convertQuotes(txtSearchBox.Text) & "%' ", con)
            End If
        End If

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrProducts
            .Rows.Clear()
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
                .Rows(.Rows.Count - 1).Cells(6).Value = dr(6)
                .Rows(.Rows.Count - 1).Cells(7).Value = dr(7)
            End While
        End With
        dr.Close()
        disconnect()

        If dgrProducts.SelectedRows.Count > 0 Then
            Try
                Dim X, Y As Integer
                X = dgrProducts.CurrentCell.RowIndex
                Y = dgrProducts.CurrentCell.ColumnIndex

                If (dgrProducts.Rows.Count - 1) > selRow Then
                    dgrProducts.ClearSelection()
                    dgrProducts.Rows(selRow).Cells(selCol).Selected = True
                End If

                dgrProducts.CurrentCell = dgrProducts.Rows(selRow).Cells(selCol)
                dgrProducts.Rows(selRow).Cells(selCol).Selected = True
            Catch ex As Exception
            End Try
        End If

    End Sub

    Friend Sub GetDepartment()
        connect()
        cmd = New SqlCommand(" select dept_id,dept_name from department ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read
            dept_id = dr("dept_id")
            dept_name = dr("dept_name")

            Select Case dept_id
                Case 1
                    btnDept1.Tag = dept_id
                    btnDept1.Text = dept_name
                Case 2
                    btnDept2.Tag = dept_id
                    btnDept2.Text = dept_name
                Case 3
                    btnDept3.Tag = dept_id
                    btnDept3.Text = dept_name
                Case 4
                    btnDept4.Tag = dept_id
                    btnDept4.Text = dept_name
            End Select

        Loop
        disconnect()
    End Sub

    Friend Sub GetCategory()
        connect()
        cmd = New SqlCommand(" select cat_id,cat_name from category where dept_name = '" & dept_id & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read
            cat_id = dr("cat_id")
            cat_name = dr("cat_name")

            Select Case cat_id
                Case 1
                    btnCat1.Tag = cat_id
                    btnCat1.Text = cat_name
                Case 2
                    btnCat2.Tag = cat_id
                    btnCat2.Text = cat_name
                Case 3
                    btnCat3.Tag = cat_id
                    btnCat3.Text = cat_name
                Case 4
                    btnCat4.Tag = cat_id
                    btnCat4.Text = cat_name
            End Select

        Loop
        disconnect()
    End Sub

    Friend Sub Transaction()
        Try

            Dim QTY_DECIMAL As Decimal


            cmd = New SqlCommand(" SELECT RECORDID,PRODUCTID,PROD_DESCRIPTION,QUANTITY,PRICE,AMOUNT,DISCOUNT,ISNULL(VATABLEAMOUNT,0),DISCOUNTRATE,DEPARTMENT,CATEGORY,DAILYBQTY,DAILYEQTY FROM TRANSACTION_TEMP ORDER BY RECORDID DESC", con)

            connect()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            With dgrTransaction
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
                    .Rows(.Rows.Count - 1).Cells(7).Value = dr(7)
                    .Rows(.Rows.Count - 1).Cells(8).Value = dr(8)
                    .Rows(.Rows.Count - 1).Cells(9).Value = dr(9)
                    .Rows(.Rows.Count - 1).Cells(10).Value = dr(10)
                    .Rows(.Rows.Count - 1).Cells(11).Value = dr(11)
                    .Rows(.Rows.Count - 1).Cells(12).Value = dr(12)

                    For i As Integer = 0 To Me.dgrTransaction.Rows.Count - 1
                        Try
                            QTY_DECIMAL = .Rows(.Rows.Count - 1).Cells(3).Value

                            If QTY_DECIMAL = Int(QTY_DECIMAL) Then
                                .Rows(.Rows.Count - 1).Cells(3).Value = QTY_DECIMAL.ToString("N0", CultureInfo.InvariantCulture)
                            Else
                                .Rows(.Rows.Count - 1).Cells(3).Value = QTY_DECIMAL.ToString("N2", CultureInfo.InvariantCulture)
                            End If
                        Catch ex As Exception
                        End Try
                    Next

                End While
            End With
            disconnect()


            If dgrTransaction.SelectedRows.Count > 0 Then
                Try
                    Dim X, Y As Integer
                    X = dgrTransaction.CurrentCell.RowIndex
                    Y = dgrTransaction.CurrentCell.ColumnIndex

                    If (dgrTransaction.Rows.Count - 1) > selRow Then
                        dgrTransaction.ClearSelection()
                        dgrTransaction.Rows(selRow).Cells(selCol).Selected = True
                    End If

                    dgrTransaction.CurrentCell = dgrTransaction.Rows(selRow).Cells(selCol)
                    dgrTransaction.Rows(selRow).Cells(selCol).Selected = True
                Catch ex As Exception
                End Try
            End If

        Catch ex As Exception

        End Try

        GetPaymentDetails()
        RenderGrid()
        txtSearchBox.Focus()
    End Sub

    Friend Sub GetSystemInfo()
        connect()
        cmd = New SqlCommand("select * from terminal", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                terminal_no = dr("terminal_no")
                terminal_name = dr("terminal_name").ToString
                machine_no = dr("machineno").ToString
                serial_no = dr("serialno").ToString
                permit_no = dr("birpermit").ToString
                tin_no = dr("tinno").ToString
                pos_printer = dr("printer").ToString
                constring = dr("connectionstring").ToString
            Catch ex As Exception
                DevComponents.DotNetBar.MessageBoxEx.Show("Please configure system settings before proceeding! ok?", "SYSTEM INFO", _
                                                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
        disconnect()

        connect()
        cmd = New SqlCommand(" select * from systemsettings", con)
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        If dr1.Read Then
            Try
                productselection_mode = dr1("selectionmode").ToString
                printing_option = dr1("printingoption").ToString
                printcopy = dr1("printcopy").ToString
                isalways_print_receipt = dr1("isalwaysprintreceipt").ToString
                is_print_report_after_endshift = dr1("isprintreporteveryend").ToString
                is_print_coupon = dr1("isprintcoupon").ToString
                is_print_points = dr1("isprintpoints").ToString
                is_export_receipt = dr1("isexportreceipt").ToString
                INV_FILEPATH = dr1("pdfexport_fpath").ToString
                is_PRINT_INV_REPORT = dr1("isprintreport").ToString
                def_SR_Type = dr1("def_sr_type").ToString
            Catch ex As Exception
                DevComponents.DotNetBar.MessageBoxEx.Show("Please configure system settings before proceeding! ok?", "SYSTEM INFO", _
                                                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
        disconnect()

        If productselection_mode = "Button" Then
            pnlButtons.Visible = True

            txtSearchBox.Visible = False
        Else
            pnlButtons.Visible = False

            dgrProducts.Dock = DockStyle.Fill
            txtSearchBox.Visible = True
        End If

        lblServer.Text = "Server: " & System.Configuration.ConfigurationManager.AppSettings.Get("server")
        lblDB.Text = "Database: " & System.Configuration.ConfigurationManager.AppSettings.Get("database")

        lblTerminalName.Text = business_name & vbCrLf & branch_address

    End Sub

    Friend Sub Check_UnclosedShift()
        'connect()
        'cmd = New SqlCommand("select top 1 isnull(max(datetime),GETDATE()) from dbo.[transaction] where sessionid = '" & NewSessionID & "' ", con)
        'Dim dr As SqlDataReader = cmd.ExecuteReader
        'If dr.Read Then
        '    max_trans_date = dr(0)
        'Else
        '    max_trans_date = Format(Now, "MM-dd-yyyy")
        'End If
        'dr.Close()
        'cmd.Dispose()
        'disconnect()

        'If Format(Now, "MM-dd-yyyy") > max_trans_date Then
        '    If DevComponents.DotNetBar.MessageBoxEx.Show("The system detected that the previous date transaction is not yet closed." & vbCrLf & vbCrLf & _
        '                                              "Would you like to close this date now?" & vbCrLf & vbCrLf & max_trans_date, "Confirm", _
        '                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        '        managersaccess = "endday"
        '        frmManagerLogin.Opacity = 100
        '        frmManagerLogin.ShowDialog()
        '    Else
        '        DevComponents.DotNetBar.MessageBoxEx.Show("The Application will now close!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Application.Exit()
        '        Application.ExitThread()
        '    End If

        'End If

    End Sub

    Friend Sub GetPaymentDetails()
        'Dim tot_disc As Double
        'Try
        '    connect()
        '    cmd = New SqlCommand("SELECT total = ISNULL(SUM(DISCOUNT),0) FROM transaction_temp WHERE productid = 999999", con)
        '    Dim dr As SqlDataReader = cmd.ExecuteReader
        '    If dr.Read Then
        '        tot_disc = dr("total")
        '        Total_Discount = dr("total")
        '    End If
        '    disconnect()
        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        'End Try

        'Try
        '    connect()
        '    cmd = New SqlCommand(" select total = sum(amount) - '" & tot_disc & "',discount = MAX(discount) from transaction_temp where productid <> 999999", con)
        '    Dim drx As SqlDataReader = cmd.ExecuteReader
        '    If drx.Read Then
        '        lblTotal.Text = Format(drx("total"), "##,##0.00")
        '        trans_totaldue = drx("total")
        '        'trans_totaldue = (drx("total") - sales_NET_VAT) - trans_discount
        '        trans_discount = Format(drx("discount"), "##,##0.00")
        '        'lblDiscount.Text = trans_discount.ToString("N2", CultureInfo.InvariantCulture)
        '    End If
        '    drx.Close()
        '    cmd.Dispose()
        '    disconnect()
        'Catch ex As Exception
        'End Try

        'Try
        '    connect()
        '    cmd = New SqlCommand(" select AMOUNT from transaction_temp where productid = 2", con)
        '    Dim drY As SqlDataReader = cmd.ExecuteReader
        '    If drY.Read Then
        '        Dim DEC_FEE As Decimal = drY(0)
        '        lblAddOnFee.Text = DEC_FEE.ToString("N2", CultureInfo.InvariantCulture)
        '    End If
        '    drY.Close()
        '    disconnect()
        'Catch ex As Exception
        '    lblAddOnFee.Text = "0.00"
        'End Try

        'lblDiscount.Text = tot_disc.ToString("N2", CultureInfo.InvariantCulture)

       
    End Sub

    Friend Sub GetPaymentDetails_From_Hold()
        Try
            connect()
            cmd = New SqlCommand(" select total = sum(amount)  from transaction_hold", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                lblTotal.Text = Format(dr("total"), "##,##0.00")
                trans_totaldue = dr("total")
            End If
            disconnect()
        Catch ex As Exception
        End Try
    End Sub

    Friend Sub InsertProducts()

        Dim isExist As String = "false"
        For Each itm As DataGridViewRow In dgrTransaction.Rows
            If itm.Cells(2).Value = product_desc Then
                isExist = "true"
            End If
        Next

        GetRecordID()

        connect()
        cmd = New SqlCommand("EXEC sp_InsertItemToTransactionTemp '" & RecordId & "','" & ProdTransaction_ID & "', " & _
                         "'" & convertQuotes(product_desc) & "','1','" & product_price & "','" & dept_name & "','" & cat_name & "', " & _
                         "'" & product_price & "','0',0,'" & trans_productvat & "','" & trans_vatablesales & "', " & _
                         "'" & dgrProducts.CurrentRow.Cells(6).Value & "','" & dgrProducts.CurrentRow.Cells(7).Value & "', 0, '" & isExist & "'", con)
        cmd.ExecuteNonQuery()
        disconnect()

        CalculateTotalTransactionAmount()

        'REFRESH TRANSACTION
        Transaction()
        dgrTransaction.Refresh()

        txtSearchBox.Focus()

        If dgrProducts.RowCount = 1 Then
            txtSearchBox.Clear()
            txtSearchBox.Text = ""
        End If


    End Sub

    'FOR BARCODE SCANNER
    Friend Sub Trigger_Scanner()
        GetDGProducts()
        If dgrProducts.Rows.Count = 1 Then
            If IsNumeric(txtSearchBox.Text) = True And txtSearchBox.Text.Length >= 6 Then
                ProdTransaction_ID = dgrProducts.CurrentRow.Cells(0).Value
                product_desc = dgrProducts.CurrentRow.Cells(2).Value
                product_price = dgrProducts.CurrentRow.Cells(3).Value
                dept_name = dgrProducts.CurrentRow.Cells(4).Value.ToString
                cat_name = dgrProducts.CurrentRow.Cells(5).Value.ToString
                InsertProducts()
                txtSearchBox.Clear()
            Else
            End If
        End If
    End Sub

    Friend Sub UpdateQuantity()
        Dim amt As Double
        connect()
        For i As Integer = 0 To Me.dgrTransaction.Rows.Count - 1
            cmd = New SqlCommand("update transaction_temp set quantity = @qty , amount = @amount, price = @price," & _
                                 " discount = amount * discountrate where recordid = @recordid and productid <> 0 ", con)

            cmd.Parameters.AddWithValue("@recordid", dgrTransaction.Rows(i).Cells(0).Value)
            cmd.Parameters.AddWithValue("@amount", dgrTransaction.Rows(i).Cells(3).Value * dgrTransaction.Rows(i).Cells(4).Value)
            cmd.Parameters.AddWithValue("@qty", dgrTransaction.Rows(i).Cells(3).Value)
            cmd.Parameters.AddWithValue("@price", dgrTransaction.Rows(i).Cells(4).Value)
            cmd.ExecuteNonQuery()
        Next
        disconnect()

        Transaction()
        dgrTransaction.Refresh()

        Try
            amt = dgrTransaction.CurrentRow.Cells(5).Value * dgrTransaction.CurrentRow.Cells(8).Value
        Catch ex As Exception
        End Try

        connect()
        cmd = New SqlCommand(" update transaction_temp set amount = '" & amt & "' " & _
                                 " where recordid = '" & dgrTransaction.CurrentRow.Cells(0).Value & "' and productid = 0 ", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand(" update transaction_temp set tax = amount * 0.12 where recordid = '" & dgrTransaction.CurrentRow.Cells(0).Value & "' ", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand(" update transaction_temp set vatableamount = amount - vat where recordid = '" & dgrTransaction.CurrentRow.Cells(0).Value & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

    End Sub

    Friend Sub RenderGrid()
        Try
            For i As Integer = 0 To Me.dgrTransaction.Rows.Count - 1
                If Me.dgrTransaction.Rows(i).Cells(1).Value = 999999 Then
                    Me.dgrTransaction.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    Me.dgrTransaction.Rows(i).DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold Or FontStyle.Underline)
                ElseIf Me.dgrTransaction.Rows(i).Cells(1).Value = 2 Then
                    Me.dgrTransaction.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                    Me.dgrTransaction.Rows(i).DefaultCellStyle.Font = New Font("Comic Sans MS", 9, FontStyle.Bold Or FontStyle.Underline)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub GetRecordID()
        connect()
        cmd = New SqlCommand(" select top 1 recordid = recordid + 1 + 0 from transaction_temp order by recordid desc", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            RecordId = dr("recordid")
        End If
        disconnect()
    End Sub

    Friend Sub ButtonColor_Dept()
        If dept_id = 1 Then
            btnDept1.ForeColor = Color.Blue
            btnDept2.ForeColor = Color.Black
            btnDept3.ForeColor = Color.Black
            btnDept4.ForeColor = Color.Black
        ElseIf dept_id = 2 Then
            btnDept1.ForeColor = Color.Black
            btnDept2.ForeColor = Color.Blue
            btnDept3.ForeColor = Color.Black
            btnDept4.ForeColor = Color.Black
        ElseIf dept_id = 3 Then
            btnDept1.ForeColor = Color.Black
            btnDept2.ForeColor = Color.Black
            btnDept3.ForeColor = Color.Blue
            btnDept4.ForeColor = Color.Black
        ElseIf dept_id = 4 Then
            btnDept1.ForeColor = Color.Black
            btnDept2.ForeColor = Color.Black
            btnDept3.ForeColor = Color.Black
            btnDept4.ForeColor = Color.Blue
        End If
    End Sub

    Friend Sub ButtonColor_Cat()
        If cat_id = 1 Then
            btnCat1.ForeColor = Color.Blue
            btnCat2.ForeColor = Color.Black
            btnCat3.ForeColor = Color.Black
            btnCat4.ForeColor = Color.Black
        ElseIf cat_id = 2 Then
            btnCat1.ForeColor = Color.Black
            btnCat2.ForeColor = Color.Blue
            btnCat3.ForeColor = Color.Black
            btnCat4.ForeColor = Color.Black
        ElseIf cat_id = 3 Then
            btnCat1.ForeColor = Color.Black
            btnCat2.ForeColor = Color.Black
            btnCat3.ForeColor = Color.Blue
            btnCat4.ForeColor = Color.Black
        ElseIf cat_id = 4 Then
            btnCat1.ForeColor = Color.Black
            btnCat2.ForeColor = Color.Black
            btnCat3.ForeColor = Color.Black
            btnCat4.ForeColor = Color.Blue
        End If
    End Sub

    Friend Sub ResetAll_Button()

        btnProd1.Tag = ""
        btnProd1.Text = ""
        btnProd1.TabIndex = "0"

        btnProd2.Tag = ""
        btnProd2.Text = ""
        btnProd2.TabIndex = "1"

        btnProd3.Tag = ""
        btnProd3.Text = ""
        btnProd3.TabIndex = "2"

        btnProd4.Tag = ""
        btnProd4.Text = ""
        btnProd4.TabIndex = "3"

        btnProd5.Tag = ""
        btnProd5.Text = ""
        btnProd5.TabIndex = "4"

        btnProd6.Tag = ""
        btnProd6.Text = ""
        btnProd6.TabIndex = "5"

        btnProd7.Tag = ""
        btnProd7.Text = ""
        btnProd7.TabIndex = "6"

        btnProd8.Tag = ""
        btnProd8.Text = ""
        btnProd8.TabIndex = "7"

        btnProd9.Tag = ""
        btnProd9.Text = ""
        btnProd9.TabIndex = "8"

        btnProd10.Tag = ""
        btnProd10.Text = ""
        btnProd10.TabIndex = "9"

        btnProd11.Tag = ""
        btnProd11.Text = ""
        btnProd11.TabIndex = "10"

        btnProd12.Tag = ""
        btnProd12.Text = ""
        btnProd12.TabIndex = "11"

        btnProd13.Tag = ""
        btnProd13.Text = ""
        btnProd13.TabIndex = "12"

        btnProd14.Tag = ""
        btnProd14.Text = ""
        btnProd14.TabIndex = "13"

        btnProd15.Tag = ""
        btnProd15.Text = ""
        btnProd15.TabIndex = "14"

        btnProd16.Tag = ""
        btnProd16.Text = ""
        btnProd16.TabIndex = "15"

        btnProd17.Tag = ""
        btnProd17.Text = ""
        btnProd17.TabIndex = "16"

        btnProd18.Tag = ""
        btnProd18.Text = ""
        btnProd18.TabIndex = "17"

        btnProd19.Tag = ""
        btnProd19.Text = ""
        btnProd19.TabIndex = "18"

        btnProd20.Tag = ""
        btnProd20.Text = ""
        btnProd20.TabIndex = "19"


    End Sub

    Friend Sub ResetAllDepartments()

        btnDept1.Tag = ""
        btnDept1.Text = ""

        btnDept2.Tag = ""
        btnDept2.Text = ""

        btnDept3.Tag = ""
        btnDept3.Text = ""

        btnDept4.Tag = ""
        btnDept4.Text = ""

        btnCat1.Tag = ""
        btnCat1.Text = ""

        btnCat2.Tag = ""
        btnCat2.Text = ""

        btnCat3.Tag = ""
        btnCat3.Text = ""

        btnCat4.Tag = ""
        btnCat4.Text = ""

    End Sub

    Friend Sub GetBranch()
        connect()
        cmd = New SqlCommand(" select  branchid,branchname,businessname,address,phone from branch", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            branch_id = dr("branchid")
            branch_name = dr("branchname")
            business_name = dr("businessname")
            branch_address = dr("address")
            branch_phoneno = dr("phone")
        End If
        disconnect()

        lblBusinessName.Text = business_name
        lblTerminalName.Text = business_name & vbCrLf & branch_address
        lblBusinessAdd.Text = branch_address
    End Sub

    Friend Sub GenerateReceiptFooter()

        connect()
        cmd = New SqlCommand(" select text from receiptsetup where line = 26", con)
        Dim dr3 As SqlDataReader = cmd.ExecuteReader
        If dr3.Read Then
            Footer26 = dr3("text").ToString
        End If
        dr3.Close()
        disconnect()

        connect()
        cmd = New SqlCommand(" select text from receiptsetup where line = 27", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Footer27 = dr("text").ToString
        End If
        dr.Close()
        disconnect()

        connect()
        cmd = New SqlCommand(" select text from receiptsetup where line = 28", con)
        Dim dr2 As SqlDataReader = cmd.ExecuteReader
        If dr2.Read Then
            Footer28 = dr2("text").ToString
        End If
        dr2.Close()
        disconnect()

    End Sub

    Friend Sub CheckDoubleDiscount()
        connect()
        cmd = New SqlCommand(" select productid from transaction_temp where productid = 999999", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read = True Then
            Is_DoubleDiscount = True
        Else
            Is_DoubleDiscount = False
        End If
        disconnect()
    End Sub

    Friend Sub CheckReorderItems()
        connect()
        cmd = New SqlCommand("select productid from dbo.products where quantity = reorderpoint and productid not in (1,2,3,4,5,6)", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read = True Then
            Is_ReorderStock = True
        Else
            Is_ReorderStock = False
        End If
        disconnect()
    End Sub

#Region "Button_Click"

    Private Sub btnProd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProd1.Click
        ProdTransaction_ID = btnProd1.TabIndex
        product_desc = btnProd1.Text
        product_price = btnProd1.Tag
        dept_name = btnProd1.AccessibleName
        cat_name = btnProd1.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProd2.Click
        ProdTransaction_ID = btnProd2.TabIndex
        product_desc = btnProd2.Text
        product_price = btnProd2.Tag
        dept_name = btnProd2.AccessibleName
        cat_name = btnProd2.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProd3.Click
        ProdTransaction_ID = btnProd3.TabIndex
        product_desc = btnProd3.Text
        product_price = btnProd3.Tag
        dept_name = btnProd3.AccessibleName
        cat_name = btnProd3.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProd4.Click
        ProdTransaction_ID = btnProd4.TabIndex
        product_desc = btnProd4.Text
        product_price = btnProd4.Tag
        dept_name = btnProd4.AccessibleName
        cat_name = btnProd4.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProd5.Click
        ProdTransaction_ID = btnProd5.TabIndex
        product_desc = btnProd5.Text
        product_price = btnProd5.Tag
        dept_name = btnProd5.AccessibleName
        cat_name = btnProd5.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProd6.Click
        ProdTransaction_ID = btnProd6.TabIndex
        product_desc = btnProd6.Text
        product_price = btnProd6.Tag
        dept_name = btnProd6.AccessibleName
        cat_name = btnProd6.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd7.Click
        ProdTransaction_ID = btnProd7.TabIndex
        product_desc = btnProd7.Text
        product_price = btnProd7.Tag
        dept_name = btnProd7.AccessibleName
        cat_name = btnProd7.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd8.Click
        ProdTransaction_ID = btnProd8.TabIndex
        product_desc = btnProd8.Text
        product_price = btnProd8.Tag
        dept_name = btnProd8.AccessibleName
        cat_name = btnProd8.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd9.Click
        ProdTransaction_ID = btnProd9.TabIndex
        product_desc = btnProd9.Text
        product_price = btnProd9.Tag
        dept_name = btnProd9.AccessibleName
        cat_name = btnProd9.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd10.Click
        ProdTransaction_ID = btnProd10.TabIndex
        product_desc = btnProd10.Text
        product_price = btnProd10.Tag
        dept_name = btnProd10.AccessibleName
        cat_name = btnProd10.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd11.Click
        ProdTransaction_ID = btnProd11.TabIndex
        product_desc = btnProd11.Text
        product_price = btnProd11.Tag
        dept_name = btnProd11.AccessibleName
        cat_name = btnProd11.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd12.Click
        ProdTransaction_ID = btnProd12.TabIndex
        product_desc = btnProd12.Text
        product_price = btnProd12.Tag
        dept_name = btnProd12.AccessibleName
        cat_name = btnProd12.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd13.Click
        ProdTransaction_ID = btnProd13.TabIndex
        product_desc = btnProd13.Text
        product_price = btnProd13.Tag
        dept_name = btnProd13.AccessibleName
        cat_name = btnProd13.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd14.Click
        ProdTransaction_ID = btnProd14.TabIndex
        product_desc = btnProd14.Text
        product_price = btnProd14.Tag
        dept_name = btnProd14.AccessibleName
        cat_name = btnProd14.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd15.Click
        ProdTransaction_ID = btnProd15.TabIndex
        product_desc = btnProd15.Text
        product_price = btnProd15.Tag
        dept_name = btnProd15.AccessibleName
        cat_name = btnProd15.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd16.Click
        ProdTransaction_ID = btnProd16.TabIndex
        product_desc = btnProd16.Text
        product_price = btnProd16.Tag
        dept_name = btnProd16.AccessibleName
        cat_name = btnProd16.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd17.Click
        ProdTransaction_ID = btnProd17.TabIndex
        product_desc = btnProd17.Text
        product_price = btnProd17.Tag
        dept_name = btnProd17.AccessibleName
        cat_name = btnProd17.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd18.Click
        ProdTransaction_ID = btnProd18.TabIndex
        product_desc = btnProd18.Text
        product_price = btnProd18.Tag
        dept_name = btnProd18.AccessibleName
        cat_name = btnProd18.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd19.Click
        ProdTransaction_ID = btnProd19.TabIndex
        product_desc = btnProd19.Text
        product_price = btnProd19.Tag
        dept_name = btnProd19.AccessibleName
        cat_name = btnProd19.AccessibleDescription
        InsertProducts()
    End Sub

    Private Sub btnProd20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProd20.Click
        ProdTransaction_ID = btnProd20.TabIndex
        product_desc = btnProd20.Text
        product_price = btnProd20.Tag
        dept_name = btnProd20.AccessibleName
        cat_name = btnProd20.AccessibleDescription
        InsertProducts()
    End Sub

#End Region

#Region "Dept & Categories"

    Private Sub btnDept1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDept1.Click
        dept_name = btnDept1.Text
        dept_id = btnDept1.Tag
        ButtonColor_Dept()
        GetCategory()
        'GetProducts()
        btnCat1.PerformClick()
    End Sub

    Private Sub btnDept2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDept2.Click
        dept_name = btnDept2.Text
        dept_id = btnDept2.Tag
        ButtonColor_Dept()
        GetCategory()
        GetProducts()
        btnCat1.PerformClick()
    End Sub

    Private Sub btnDept3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDept3.Click
        dept_name = btnDept3.Text
        dept_id = btnDept3.Tag
        ButtonColor_Dept()
        GetCategory()
        GetProducts()
        btnCat1.PerformClick()
    End Sub

    Private Sub btnDept4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDept4.Click
        dept_name = btnDept4.Text
        dept_id = btnDept4.Tag
        ButtonColor_Dept()
        GetCategory()
        GetProducts()
        btnCat1.PerformClick()
    End Sub

    Private Sub btnCat1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat1.Click
        cat_name = btnCat1.Text
        cat_id = btnCat1.Tag
        ButtonColor_Cat()
        'GetProducts()
    End Sub

    Private Sub btnCat2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat2.Click
        cat_name = btnCat2.Text
        cat_id = btnCat2.Tag
        ButtonColor_Cat()
        GetProducts()
    End Sub

    Private Sub btnCat3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat3.Click
        cat_name = btnCat3.Text
        cat_id = btnCat3.Tag
        ButtonColor_Cat()
        GetProducts()
    End Sub

    Private Sub btnCat4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat4.Click
        cat_name = btnCat4.Text
        cat_id = btnCat4.Tag
        ButtonColor_Cat()
        GetProducts()
    End Sub

#End Region

#Region "PaymentModes"

    Private Sub btnCashPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashPayment.Click
        If dgrTransaction.RowCount > 0 Then
            payment_mode = 1
            frmTender_Cash.Opacity = 100
            frmTender_Cash.ShowDialog()
        Else
            MessageBoxEx.Show("NO TRANSACTION TO PROCESS!", "PAYMENT DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnChargePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChargePayment.Click
        If dgrTransaction.RowCount > 0 Then
            payment_mode = 2
            frmTender_Charge.Opacity = 100
            frmTender_Charge.ShowDialog()
        Else
            MsgBox("No transaction to process payment!", vbExclamation, "Charge Payment")
        End If
    End Sub

    Private Sub btnSplitPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplitPayment.Click
        If dgrTransaction.RowCount > 0 Then
            payment_mode = 4
            frmTender_Split.Opacity = 100
            frmTender_Split.ShowDialog()
        Else
            MessageBoxEx.Show("NO TRANSACTION TO PROCESS!", "PAYMENT DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

#End Region

#Region "Miscellaneous Buttons"

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            If dgrTransaction.RowCount = 0 Then
                DevComponents.DotNetBar.MessageBoxEx.Show("No transaction to perform!", "No Transaction", _
                                                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If dgrTransaction.CurrentRow.Cells(0).Value = 999999 Then 'AVOID DISCOUNT DELETE
                Exit Sub
            ElseIf dgrTransaction.CurrentRow.Cells(1).Value = 2 Then 'REMOVE DELIVERY FEE
                lblAddOnFee.Text = "0.00"
                connect()
                cmd = New SqlCommand("delete from transaction_temp where recordid = '" & dgrTransaction.CurrentRow.Cells(0).Value & "' ", con)
                cmd.ExecuteNonQuery()
                disconnect()
                Transaction()
                dgrTransaction.Refresh()

                CalculateTotalTransactionAmount()
            Else
                Try
                    connect()
                    cmd = New SqlCommand("delete from transaction_temp where recordid = '" & dgrTransaction.CurrentRow.Cells(0).Value & "' ", con)
                    cmd.ExecuteNonQuery()
                    disconnect()
                    Transaction()
                    dgrTransaction.Refresh()

                    CalculateTotalTransactionAmount()

                    If dgrTransaction.RowCount = 0 Then
                        lblTotal.Text = "0.00"
                    End If
                Catch ex As Exception

                End Try
                txtSearchBox.Focus()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOtherMenus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherMenus.Click
        If btnOtherMenus.Text = "(Alt + P) Main Menu" Then
            btnOtherMenus.Text = "(Alt + P) Products"
            txtSearchBox.Visible = False
            btnVirtualKeyboard.Visible = False
            pnlProducts.Visible = False
            SwitchButton1.Visible = False
        Else
            btnOtherMenus.Text = "(Alt + P) Main Menu"
            pnlConfiguration.Visible = True
            pnlProducts.Visible = True
            txtSearchBox.Visible = True
            btnVirtualKeyboard.Visible = True
            SwitchButton1.Visible = True
            txtSearchBox.Focus()
        End If
    End Sub

    Private Sub btnQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQty.Click
        If dgrTransaction.RowCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("There is no transaction to perform", "No Transaction", _
                                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        ElseIf dgrTransaction.CurrentRow.Cells(6).Value > 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Please remove discount first before updating quantity!", "Update quantity", _
                                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If dgrTransaction.CurrentRow.Cells(0).Value = 999999 Then
            Exit Sub
            'ElseIf lblDiscount.Text <> "0.00" Then
            '    DevComponents.DotNetBar.MessageBoxEx.Show("Please remove discount first!", "Wait", _
            '                                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
        Else
            frmQuantity.ShowDialog()
        End If


    End Sub

    Private Sub btnHoldRecall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoldRecall.Click
        frmTransact_Hold.ShowDialog()
    End Sub

    Private Sub btnAddDiscounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDiscounts.Click

        CheckDoubleDiscount()

        If Is_DoubleDiscount = True Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Discount already exist!", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If dgrTransaction.RowCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("There is no transaction to perform", "No Transaction", _
                                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            frmDiscount.product_recordid = dgrTransaction.CurrentRow.Cells(0).Value.ToString
            frmDiscount.ShowDialog()
        End If
    End Sub

    Private Sub btnRemoveDisc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDisc.Click
        If dgrTransaction.RowCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("There is no transaction to perform", "No Transaction", _
                                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf dgrTransaction.CurrentRow.Cells(6).Value = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("No discount applied for the selected item.", "Invalid selection", _
                                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim formattedStr As String = dgrTransaction.CurrentRow.Cells(2).Value.Split("*")(0).Replace(Environment.NewLine, String.Empty)

            connect()
            cmd = New SqlCommand("UPDATE transaction_temp SET prod_description = '" & convertQuotes(formattedStr) & "', discount = 0, discountrate = 0, discounttype = 0, amount = price * quantity WHERE recordid = '" & dgrTransaction.CurrentRow.Cells(0).Value & "'", con)
            cmd.ExecuteNonQuery()
            disconnect()


            GetPaymentDetails()
            CalculateTotalTransactionAmount()

            Transaction()
            dgrTransaction.Refresh()


        End If
        'lblDiscount.Text = "0.00"
        lblCustomer.Text = ""
        txtSearchBox.Focus()
    End Sub

    Private Sub btnVoidTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoidTransaction.Click
        managersaccess = "void_transaction"
        frmManagerLogin.Opacity = 100
        frmManagerLogin.ShowDialog()
    End Sub

    Private Sub btnCashPullOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashPullOut.Click
        managersaccess = "cashpullout"
        frmManagerLogin.Opacity = 100
        frmManagerLogin.ShowDialog()
    End Sub

    Private Sub btnCashDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashDeposit.Click
        managersaccess = "cashdeposit"
        frmManagerLogin.Opacity = 100
        frmManagerLogin.ShowDialog()
    End Sub

    Private Sub btnDeclareSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeclareSales.Click
        managersaccess = "endday"
        frmManagerLogin.Opacity = 100
        frmManagerLogin.ShowDialog()
    End Sub

    'RECEIVABLES
    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchaseOrders.Click
        Me.Hide()
        frmPurchases.ShowDialog()
    End Sub

    Private Sub btnStartDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartDay.Click
        managersaccess = "startday"
        frmManagerLogin.Opacity = 100
        frmManagerLogin.ShowDialog()
    End Sub

    Private Sub btnReprintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprintReceipt.Click
        frmReprint.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        managersaccess = "refund"
        frmManagerLogin.Opacity = 100
        frmManagerLogin.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        Me.Hide()
        frmInventory.Show()
    End Sub

    Private Sub btnEditPrice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditLinePrice.Click
        If dgrTransaction.RowCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("There is no transaction to perform", "No Transaction", _
                                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf dgrTransaction.CurrentRow.Cells(0).Value = 999999 Then
            Exit Sub
        Else
            frmPriceAddOn.ShowDialog()
        End If
    End Sub

#End Region

    Private Sub btnConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        frmItemMaintenance.ShowDialog()
    End Sub

    Private Sub dgrProducts_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrProducts.CellClick
        selRow = dgrProducts.CurrentCell.RowIndex
        selCol = dgrProducts.CurrentCell.ColumnIndex

        Dim a As Decimal
        a = dgrProducts.CurrentRow.Cells(6).Value

        If a = Int(a) Then
            lblItemQty.Text = "Current Quantity : " & a.ToString("N0", CultureInfo.InvariantCulture)
        Else
            lblItemQty.Text = "Current Quantity : " & a.ToString("N2", CultureInfo.InvariantCulture)
        End If


    End Sub

    Private Sub dgrProducts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrProducts.Click
        txtSearchBox.Focus()
    End Sub

    Private Sub dgrProducts_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrProducts.CellDoubleClick

        ProdTransaction_ID = dgrProducts.CurrentRow.Cells(0).Value
        product_desc = dgrProducts.CurrentRow.Cells(2).Value
        product_price = dgrProducts.CurrentRow.Cells(3).Value
        dept_name = dgrProducts.CurrentRow.Cells(4).Value.ToString
        cat_name = dgrProducts.CurrentRow.Cells(5).Value.ToString

        If IsNothing(product_price) Then
            MsgBox("Check item's assigned price.", vbOK)
            Exit Sub
        End If

        InsertProducts()

        If dgrProducts.RowCount = 1 Then
            txtSearchBox.Clear()
        End If

    End Sub

    Private Sub btnVirtualKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVirtualKeyboard.Click
        If btnVirtualKeyboard.BackColor = Color.White Then
            KeyboardControl1.Visible = True
            KeyboardControl1.BringToFront()
            pnlProducts.Dock = DockStyle.None
            btnVirtualKeyboard.BackColor = Color.Orange
            txtSearchBox.Focus()
        Else
            KeyboardControl1.Visible = False
            KeyboardControl1.SendToBack()
            pnlProducts.Dock = DockStyle.Fill
            btnVirtualKeyboard.BackColor = Color.White
        End If
        txtSearchBox.Focus()
    End Sub

    Private Sub btnXZReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXZReport.Click
        frmViewSales.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If DevComponents.DotNetBar.MessageBoxEx.Show("Are you sure you want to exit this POS?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Application.Exit()
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX10.Click
        Process.Start("D:\vs2010\Personal Files\POS Manual.docx")
    End Sub

    Private Sub lblBusinessName_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBusinessName.DoubleClick
        frmDisplaySettings.ShowDialog()
    End Sub

    Private Sub lblBusinessAdd_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBusinessAdd.DoubleClick
        frmDisplaySettings.ShowDialog()
    End Sub

    Private Sub SwitchButton1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchButton1.ValueChanged
        GetDGProducts()
        dgrProducts.Refresh()
    End Sub

    Private Sub btnVirtualKeyboard_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVirtualKeyboard.MouseHover
        btnVirtualKeyboard.ForeColor = Color.LightYellow
    End Sub

    Private Sub txtSearchBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchBox.TextChanged
        GetDGProducts()
    End Sub

    Private Sub dgrTransaction_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrTransaction.CellClick
        selRow = dgrProducts.CurrentCell.RowIndex
        selCol = dgrProducts.CurrentCell.ColumnIndex
    End Sub

    Private Sub dgrTransaction_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrTransaction.CellEndEdit
        UpdateQuantity()
    End Sub

    Private Sub btnCustCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustCard.Click
        'CheckDoubleDiscount()
        'If Is_DoubleDiscount = True Then
        '    DevComponents.DotNetBar.MessageBoxEx.Show("Discount already exist!", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'Else
        '    frmCustomerCard.ShowDialog()
        'End If
        frmBrowseCust.Cust_Select_Mode = "Cash_Payment"
        frmBrowseCust.ShowDialog()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        frmReport.ShowDialog()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        frmTerminal.ShowDialog()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemCustomers.Click
        'Me.Hide()
        frmCustomer.ShowDialog()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemDiscounts.Click
        frmDiscEntry.ShowDialog()
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemSuppliers.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub dgrProducts_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgrProducts.MouseLeave
        lblItemQty.Text = ""
    End Sub

    'CLEAR TRANSACTION LIST
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        If dgrTransaction.RowCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("No items found in transaction entry!", "No Transaction", _
                                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to clear all items?", "Clear transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If dgrTransaction.RowCount = 0 Then

                lblCustomer.Text = ""
                lblDiscount.Text = "0.00"
                lblTotal.Text = "0.00"
                trans_totaldue = 0
                Exit Sub
            Else
                connect()
                cmd = New SqlCommand("delete from transaction_temp", con)
                cmd.ExecuteNonQuery()
                disconnect()

                Transaction()
                dgrTransaction.Refresh()
                GetPaymentDetails()
                lblDiscount.Text = "0.00"
                lblTotal.Text = "0.00"
                trans_totaldue = 0
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lblInvNotification_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblInvNotification.Click
        frmReOrderItems.ShowDialog()
    End Sub

    Private Sub ReflectionLabel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReflectionLabel1.DoubleClick
        AboutInfo.ShowDialog()
    End Sub

    Private Sub dgrTransaction_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrTransaction.DoubleClick
        frmQuantity.ShowDialog()
    End Sub

    Friend Sub GetInventoryStatus()
        connect()
        cmd = New SqlCommand("SELECT PROD_DESCRIPTION FROM PRODUCTS WHERE (QUANTITY <= 0 OR QUANTITY <= REORDERPOINT) AND PRODUCTID NOT IN (1,2,3,4,5,6)", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.HasRows() Then
            lblInvNotification.Visible = True
        Else
            lblInvNotification.Visible = False
        End If

        disconnect()

    End Sub

    Private Sub ButtonItemConsolidate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonItemConsolidate.Click
        frmConsolidateDB.ShowDialog()
    End Sub

End Class
