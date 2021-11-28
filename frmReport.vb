Imports System.Data.SqlClient
Imports CrystalDecisions.Shared

Public Class frmReport

    Dim rptItemList1 As New rptItemList
    Dim rptSalesReport1 As New rptSalesReport
    Dim rptMonthlySalesReport1 As New rptMonthlySalesReport
    Dim rptSalesReportItem1 As New rptSalesReportItem
    Dim rptSalesReportReceipt1 As New rptSalesReportReceipt
    Dim rptInvReport1 As New rptInvReport
    Dim rptDailyInvReport1 As New rptDailyInvReport
    Dim rptCustAccnt1 As New rptCustAccnt
    Dim rptCustLedger1 As New rptCustLedger
    Dim rptCustAccntOverall1 As New rptCustAccntOverall
    Dim rptCustPurchHist1 As New rptCustPurchHist
    Dim rptItemTransHist1 As New rptItemTransHist
    Dim rptCustomerList1 As New rptCustomerList
    Dim rptPurchaseList1 As New rptPurchaseList
    Dim rptPatronageReport1 As New rptPatronageReport
    Dim rptPurchaseOrder1 As New rptPurchaseOrder
    Dim rptAdjustmentReport1 As New rptAdjustmentReport

    Friend FromDate As String
    Friend ToDate As String

    Friend is_printed As Boolean
    Friend is_export As Boolean
    Friend str_ReportDate As String

    Dim MONTHNAME_REPORT As String
    Dim IS_PRINT_ZERO_ITEMS As Boolean

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CRViewer.ShowLogo = False

        dtpDate.Text = Now
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MM-dd-yyyy"
        dtpDate.Value.ToString("MM-dd-yyyy")

        Get_MONTH()
        IS_PRINT_ZERO_ITEMS = True

        GetBusinessInfo()
    End Sub

    Friend Sub GetBusinessInfo()
        connect()
        cmd = New SqlCommand("select businessname,address,phone from branch", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            business_name = dr("businessname")
            branch_address = dr("address")
            branch_phoneno = dr("phone")
        End If
        disconnect()
    End Sub

    Friend Sub Get_MONTH()
        cmd = New SqlCommand("select TOP 1 LEFT(DATENAME(MONTH,DATETIME),12) from dbo.[TRANSACTION] ORDER BY DATETIME ASC", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            MONTHNAME_REPORT = dr(0)
        End If
        dr.Close()
        disconnect()
    End Sub

    Friend Sub Generate_ProductList()

        CRViewer.ReportSource = rptItemList1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            If IS_PRINT_ZERO_ITEMS = True Then
                MyCommand.CommandText = "SELECT PLU,PROD_DESCRIPTION,UNIT,PRICE,COST,WS_PRICE,CATEGORY FROM VIEW_PRODUCTS ORDER BY PROD_DESCRIPTION"
            Else
                MyCommand.CommandText = "SELECT PLU,PROD_DESCRIPTION,UNIT,PRICE,COST,WS_PRICE,CATEGORY FROM VIEW_PRODUCTS WHERE QUANTITY > 0 ORDER BY PROD_DESCRIPTION"
            End If

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "VIEW_PRODUCTS")
            rptItemList1.SetDataSource(myDS)
            CRViewer.ReportSource = rptItemList1

            rptItemList1.DataDefinition.FormulaFields.Item("var_BusinessName").Text = "'" & business_name & "'"
            rptItemList1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
            rptItemList1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & Now.ToString("MM/dd/yyyy") & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

        If is_export = True Then

            Try
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New  _
                DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                CrDiskFileDestinationOptions.DiskFileName = INV_FILEPATH & "\DAILY SALES REPORT - " & Format(Now, "MM-dd-yyyy") & ".pdf"

                CrExportOptions = rptSalesReport1.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                rptSalesReport1.Export()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If


    End Sub

    Friend Sub Generate_StockControl()

        Get_MONTH()

        CRViewer.ReportSource = rptInvReport1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT * FROM VIEW_INVENTORY  ORDER BY Prod_Description ASC"

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "VIEW_INVENTORY")
            rptInvReport1.SetDataSource(myDS)
            CRViewer.ReportSource = rptInvReport1

            rptInvReport1.DataDefinition.FormulaFields.Item("var_BusinessName").Text = "'" & business_name & "'"
            rptInvReport1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
            rptInvReport1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & dtpDate.Text.ToString & "'"


        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

        If is_export = True Then

            Try
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New  _
                DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                CrDiskFileDestinationOptions.DiskFileName = INV_FILEPATH & "\INVENTORY REPORT - " & MONTHNAME_REPORT & ".pdf"

                CrExportOptions = rptInvReport1.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                rptInvReport1.Export()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If


    End Sub

    'Friend Sub Generate_SalesReport()

    '    CRViewer.ReportSource = rptSalesReport1
    '    CRViewer.ShowLogo = False

    '    Dim MyCommand As New SqlCommand()
    '    Dim myDA As New SqlDataAdapter()
    '    Dim myDS As New dsPOS   'The DataSet you created.

    '    Try
    '        myDS.EnforceConstraints = False
    '        MyCommand.Connection = con

    '        MyCommand.CommandText = "SELECT * FROM VIEW_SALESREPORT WHERE SESSIONID ='" & NewSessionID & "' "

    '        MyCommand.CommandType = CommandType.Text
    '        myDA.SelectCommand = MyCommand

    '        myDA.Fill(myDS, "VIEW_SALESREPORT")
    '        rptSalesReport1.SetDataSource(myDS)
    '        CRViewer.ReportSource = rptSalesReport1

    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & Now.ToString("dddd, dd MMMM yyyy") & "'"

    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_CashFund").Text = "'" & frmViewSales.txtCashFund.Text & "'"
    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_CashOut").Text = "'" & frmViewSales.txtCashOut.Text & "'"
    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_CashDeposit").Text = "'" & frmViewSales.txtTotDeposit.Text & "'"
    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_Receivables").Text = "'" & frmViewSales.txtReceivable.Text & "'"
    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_TotalSales").Text = "'" & frmViewSales.txtTotalSales.Text & "'"
    '        rptSalesReport1.DataDefinition.FormulaFields.Item("var_TotalTrans").Text = "'" & frmViewSales.txtTotalTrans.Text & "'"
    '    Catch Excep As Exception
    '        MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    '    CRViewer.Refresh()

    '    If is_export = True Then

    '        Try
    '            Dim CrExportOptions As ExportOptions
    '            Dim CrDiskFileDestinationOptions As New  _
    '            DiskFileDestinationOptions()
    '            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
    '            CrDiskFileDestinationOptions.DiskFileName = INV_FILEPATH & "\DAILY SALES REPORT - " & Format(Now, "MM-dd-yyyy") & ".pdf"

    '            CrExportOptions = rptSalesReport1.ExportOptions
    '            With CrExportOptions
    '                .ExportDestinationType = ExportDestinationType.DiskFile
    '                .ExportFormatType = ExportFormatType.PortableDocFormat
    '                .DestinationOptions = CrDiskFileDestinationOptions
    '                .FormatOptions = CrFormatTypeOptions
    '            End With
    '            rptSalesReport1.Export()
    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '    End If


    'End Sub

    'Friend Sub Generate_SalesReport()

    '    CRViewer.ReportSource = rptSalesReportItem1
    '    CRViewer.ShowLogo = False

    '    Dim MyCommand1 As New SqlCommand()
    '    Dim MyCommand2 As New SqlCommand()
    '    Dim myDA1 As New SqlDataAdapter()
    '    Dim myDA2 As New SqlDataAdapter()
    '    Dim myDS As New dsPOS   'The DataSet you created.

    '    Try
    '        myDS.EnforceConstraints = False
    '        MyCommand1.Connection = con
    '        MyCommand2.Connection = con

    '        MyCommand1.CommandText = "SELECT * FROM VIEW_SALESREPORT WHERE SESSIONID ='" & NewSessionID & "' ORDER BY PROD_DESCRIPTION ASC "
    '        MyCommand2.CommandText = "SELECT * FROM VIEW_DAILYINVENTORY WHERE IT_SESSIONID = '" & NewSessionID & "' OR R_SESSIONID = '" & NewSessionID & "' ORDER BY Prod_Description ASC"

    '        MyCommand1.CommandType = CommandType.Text
    '        MyCommand2.CommandType = CommandType.Text
    '        myDA1.SelectCommand = MyCommand1
    '        myDA2.SelectCommand = MyCommand2

    '        myDA1.Fill(myDS, "VIEW_SALESREPORT")
    '        myDA2.Fill(myDS, "VIEW_DAILYINVENTORY")
    '        rptSalesReportItem1.SetDataSource(myDS)
    '        CRViewer.ReportSource = rptSalesReportItem1

    '        rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
    '        rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
    '        rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & dtpDate.Text & "'"

    '    Catch Excep As Exception
    '        MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    '    CRViewer.Refresh()

    'End Sub

    Friend Sub Generate_DailyInvReport()
        CRViewer.ReportSource = rptDailyInvReport1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT * FROM VIEW_DAILYINVENTORY WHERE TRANSDATE like '%" & dtpDate.Text & "%' ORDER BY Prod_Description,RECORDID ASC"

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "VIEW_DAILYINVENTORY")
            rptDailyInvReport1.SetDataSource(myDS)
            CRViewer.ReportSource = rptDailyInvReport1

            rptDailyInvReport1.DataDefinition.FormulaFields.Item("var_BusinessName").Text = "'" & business_name & "'"
            rptDailyInvReport1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
            rptDailyInvReport1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & dtpDate.Text & "'"


        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()


        If is_export = True Then

            Try
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New  _
                DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                CrDiskFileDestinationOptions.DiskFileName = INV_FILEPATH & "\DAILY INVENTORY REPORT " & Format(Now, "MM-dd-yyyy") & ".pdf"

                CrExportOptions = rptDailyInvReport1.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                rptDailyInvReport1.Export()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If

    End Sub

    Friend Sub Generate_CustomerAccnt()

        CRViewer.ReportSource = rptCustAccnt1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        'Try
        myDS.EnforceConstraints = False
        MyCommand.Connection = con

        MyCommand.CommandText = "SELECT FIRSTNAME = isnull(FIRSTNAME,'') + ' ' + isnull(LASTNAME,''),ACCOUNTNO,ADDRESS,BALANCE,AMOUNT,STARTINGBAL, " & _
            "CASE WHEN PRODUCTID = 1 THEN RECEIPTNO ELSE INVOICENO END AS 'RECEIPTNO', " & _
            "CONVERT(VARCHAR(10),DATETIME,110) as DATETIME, " & _
            "CASE WHEN PRODUCTID = 1 THEN '' ELSE EMAIL END AS 'EMAIL',TRANSACTIONNO, " & _
            "CASE WHEN PRODUCTID = 1 THEN 'PAYMENT' ELSE PRODUCT_DESC END AS 'PRODUCT_DESC', " & _
            "CASE WHEN PRODUCTID = 1 THEN 0 ELSE QUANTITY END AS 'QUANTITY', " & _
            "CASE WHEN PRODUCTID = 1 THEN 0 ELSE PRICE END AS 'PRICE', " & _
            "CASE WHEN PRODUCTID = 1 THEN COLLECTIONAMNT ELSE RECEIVABLES END AS 'TOTAL' " & _
            "FROM VIEW_CUSTOMERACCNT WHERE chargestatus = 0 AND PAYMENTTYPE <> 1 AND " & _
            "CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ORDER BY DATETIME ASC"

        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand

        myDA.Fill(myDS, "VIEW_CUSTOMERACCNT")
        rptCustAccnt1.SetDataSource(myDS)
        CRViewer.ReportSource = rptCustAccnt1

        rptCustAccnt1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
        rptCustAccnt1.DataDefinition.FormulaFields.Item("var_ComAddress").Text = "'" & branch_address & "'"


        'Catch Excep As Exception
        '    MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        CRViewer.Refresh()

    End Sub

    Friend Sub Generate_CustomerLedger()

        CRViewer.ReportSource = rptCustLedger1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        'Try
        myDS.EnforceConstraints = False
        MyCommand.Connection = con

        MyCommand.CommandText = "SELECT PRODUCTID,FIRSTNAME = isnull(FIRSTNAME,'') + ' ' + isnull(LASTNAME,''),ACCOUNTNO,ADDRESS,BALANCE,AMOUNT,STARTINGBAL, " & _
            "CASE WHEN PRODUCTID = 1 THEN '---' ELSE INVOICENO END AS 'INVOICENO', " & _
            "CONVERT(VARCHAR(10),DATETIME,110) as DATETIME, " & _
            "CASE WHEN PRODUCTID = 1 THEN '---' ELSE UNIT END AS 'UNIT',REMARKS, " & _
            "CASE WHEN PRODUCTID = 1 THEN 'PAYMENT' + ' OR# ' + RECEIPTNO ELSE PRODUCT_DESC END AS 'PRODUCT_DESC', " & _
            "CASE WHEN PRODUCTID = 1 THEN 0 ELSE QUANTITY END AS 'QUANTITY', " & _
            "CASE WHEN PRODUCTID = 1 THEN 0 ELSE PRICE END AS 'PRICE', " & _
            "CASE WHEN PRODUCTID = 1 THEN COLLECTIONAMNT ELSE RECEIVABLES END AS 'RECEIVABLES', " & _
            "CUST_RBALANCE " & _
            "FROM VIEW_CUSTOMERACCNT WHERE chargestatus = 0 AND PAYMENTTYPE <> 1 AND " & _
            "CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ORDER BY DATETIME ASC, RECORDID ASC"

        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand

        myDA.Fill(myDS, "VIEW_CUSTOMERACCNT")
        rptCustLedger1.SetDataSource(myDS)
        CRViewer.ReportSource = rptCustLedger1

        rptCustLedger1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
        rptCustLedger1.DataDefinition.FormulaFields.Item("var_ComAddress").Text = "'" & branch_address & "'"


        'Catch Excep As Exception
        '    MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        CRViewer.Refresh()

    End Sub

    Friend Sub Generate_CustomerAccnt_Overall()

        CRViewer.ReportSource = rptCustAccntOverall1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        'Try
        myDS.EnforceConstraints = False
        MyCommand.Connection = con

        MyCommand.CommandText = "SELECT PRODUCTID,CUSTOMERID,FIRSTNAME = FIRSTNAME + ' ' + LASTNAME, BALANCE, " & _
            "CASE WHEN PRODUCTID = 1 THEN '' ELSE INVOICENO END AS 'INVOICENO', " & _
            "DATETIME = CONVERT(VARCHAR(10),DATETIME,110), " & _
            "CASE WHEN PRODUCTID = 1 THEN '' ELSE UNIT END AS 'UNIT',REMARKS, " & _
            "CASE WHEN PRODUCTID = 1 THEN 'PAYMENT' + ' - OR# ' + RECEIPTNO ELSE PRODUCT_DESC END AS 'PRODUCT_DESC', " & _
            "CASE WHEN PRODUCTID = 1 THEN 0 ELSE QUANTITY END AS 'QUANTITY', " & _
            "CASE WHEN PRODUCTID = 1 THEN 0 ELSE PRICE END AS 'PRICE', " & _
            "CASE WHEN PRODUCTID = 1 THEN COLLECTIONAMNT ELSE RECEIVABLES END AS 'RECEIVABLES',CUST_RBALANCE " & _
            "FROM VIEW_CUSTOMERACCNT WHERE chargestatus = 0 AND PAYMENTTYPE <> 1 ORDER BY DATETIME ASC, RECORDID ASC"

        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand

        myDA.Fill(myDS, "VIEW_CUSTOMERACCNT")
        rptCustAccntOverall1.SetDataSource(myDS)
        CRViewer.ReportSource = rptCustAccntOverall1

        rptCustAccntOverall1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
        rptCustAccntOverall1.DataDefinition.FormulaFields.Item("var_ComAddress").Text = "'" & branch_address & "'"


        'Catch Excep As Exception
        '    MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        CRViewer.Refresh()

    End Sub

    Friend Sub Generate_CustomerLIST()

        CRViewer.ReportSource = rptCustomerList1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        'Try
        myDS.EnforceConstraints = False
        MyCommand.Connection = con

        MyCommand.CommandText = "SELECT CUSTOMERID,FIRSTNAME = ISNULL(FIRSTNAME,'') + ' ' + ISNULL(LASTNAME,''),ADDRESS,PHONE,BALANCE,POINTS FROM DBO.CUSTOMERS"

        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand

        myDA.Fill(myDS, "CUSTOMERS")
        rptCustomerList1.SetDataSource(myDS)
        CRViewer.ReportSource = rptCustomerList1

        rptCustomerList1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
        rptCustomerList1.DataDefinition.FormulaFields.Item("var_ComAddress").Text = "'" & branch_address & "'"


        'Catch Excep As Exception
        '    MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        CRViewer.Refresh()

    End Sub

    Friend Sub Generate_CustomerPurchaseHistory()

        CRViewer.ReportSource = rptCustPurchHist1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        'Try
        myDS.EnforceConstraints = False
        MyCommand.Connection = con

        MyCommand.CommandText = "SELECT PAYMENTTYPE,FIRSTNAME = FIRSTNAME + ' ' + LASTNAME, ACCOUNTNO,ADDRESS,BALANCE,AMOUNT,STARTINGBAL,RECEIPTNO,DATETIME = CONVERT(VARCHAR(10),DATETIME,110), " & _
            "EMAIL,TRANSACTIONNO,PRODUCT_DESC,QUANTITY,PRICE,TOTAL FROM VIEW_CUSTOMERACCNT WHERE CUSTOMERID = '" & frmCustomer.lvUsers.SelectedItems(0).Text & "' ORDER BY DATETIME ASC"

        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand

        myDA.Fill(myDS, "VIEW_CUSTOMERACCNT")
        rptCustPurchHist1.SetDataSource(myDS)
        CRViewer.ReportSource = rptCustPurchHist1

        rptCustPurchHist1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
        rptCustPurchHist1.DataDefinition.FormulaFields.Item("var_ComAddress").Text = "'" & branch_address & "'"


        'Catch Excep As Exception
        '    MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        CRViewer.Refresh()

    End Sub

    Friend Sub Generate_ItemTransHistory()

        CRViewer.ReportSource = rptItemTransHist1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT * FROM VIEW_ITEMTRANSHISTORY WHERE ITEMID = '" & frmInventory.dgrItems.CurrentRow.Cells(0).Value & "' "

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "VIEW_ITEMTRANSHISTORY")
            rptItemTransHist1.SetDataSource(myDS)
            CRViewer.ReportSource = rptItemTransHist1

            rptItemTransHist1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

    End Sub

    Friend Sub Generate_PurchaseItemsDetails()

        CRViewer.ReportSource = rptPurchaseList1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT * FROM VIEW_PURCHASEDETAILS WHERE pd_no = '" & frmPurchases.dgrPurchases.CurrentRow.Cells(0).Value & "' "

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "VIEW_PURCHASEDETAILS")
            rptPurchaseList1.SetDataSource(myDS)
            CRViewer.ReportSource = rptPurchaseList1

            rptPurchaseList1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
            rptPurchaseList1.DataDefinition.FormulaFields.Item("var_CompanyAddress").Text = "'" & branch_address & "'"
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

    End Sub

    Friend Sub Generate_MonthlySalesReport()

        CRViewer.ReportSource = rptMonthlySalesReport1
        CRViewer.ShowLogo = False

        Dim MyCommand1 As New SqlCommand()
        Dim myDA1 As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand1.Connection = con

            MyCommand1.CommandText = "SELECT MAX(p.ProductID) AS ProductID, MAX(p.Prod_Description) AS Product_Description, MAX(p.Cost) AS Cost,MAX(t.Price) AS Price, SUM(t.Quantity) AS SalesQty, SUM(t.Amount) AS Amount, " & _
                                        "MIN( Datetime) as Datetime FROM Products p INNER JOIN [Transaction] t ON p.ProductID = t.ProductId " & _
                                        "WHERE (t.Status = 1) AND (t.ProductId NOT IN (5, 6)) AND DATETIME BETWEEN '" & FromDate & "' AND '" & ToDate & "' GROUP BY t.ProductId"

            MyCommand1.CommandType = CommandType.Text
            myDA1.SelectCommand = MyCommand1


            myDA1.Fill(myDS, "VIEW_MONTHLYSALESREPORT")

            rptMonthlySalesReport1.SetDataSource(myDS)
            CRViewer.ReportSource = rptMonthlySalesReport1

            rptMonthlySalesReport1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
            rptMonthlySalesReport1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
            rptMonthlySalesReport1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & FromDate & " - " & ToDate & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

        If is_printed = True Then
            rptMonthlySalesReport1.PrintOptions.PrinterName = pos_manager_printer
            rptMonthlySalesReport1.PrintToPrinter(printcopy, False, 0, 0)
        End If

    End Sub

    Friend Sub Generate_SalesReport()

        CRViewer.ReportSource = rptSalesReport1
        CRViewer.ShowLogo = False

        Dim MyCommand1 As New SqlCommand()
        Dim myDA1 As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand1.Connection = con

            MyCommand1.CommandText = "SELECT * FROM VIEW_SALESINVENTORYREPORT WHERE DATETIME LIKE '%" & dtpDate.Text & "%' ORDER BY  Product_Description asc, RecordID asc"

            MyCommand1.CommandType = CommandType.Text
            myDA1.SelectCommand = MyCommand1


            myDA1.Fill(myDS, "VIEW_SALESINVENTORYREPORT")

            rptSalesReport1.SetDataSource(myDS)
            CRViewer.ReportSource = rptSalesReport1

            rptSalesReport1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
            rptSalesReport1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
            rptSalesReport1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & str_ReportDate & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

        If is_printed = True Then
            rptSalesReport1.PrintOptions.PrinterName = pos_manager_printer
            rptSalesReport1.PrintToPrinter(printcopy, False, 0, 0)
        End If

    End Sub

    Friend Sub Generate_SalesReportPerItem()

        CRViewer.ReportSource = rptSalesReportItem1
        CRViewer.ShowLogo = False

        Dim MyCommand1 As New SqlCommand()
        Dim myDA1 As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand1.Connection = con

            MyCommand1.CommandText = "SELECT * FROM view_SalesInventoryReportItem WHERE DATETIME LIKE '%" & dtpDate.Text & "%' " & _
                "AND STATUS = 1 AND PAYMENTTYPE <> '' AND PRODUCTID NOT IN (1,2,3,4,5,6) ORDER BY  Product_Description asc"

            MyCommand1.CommandType = CommandType.Text
            myDA1.SelectCommand = MyCommand1


            myDA1.Fill(myDS, "view_SalesInventoryReportItem")

            rptSalesReportItem1.SetDataSource(myDS)
            CRViewer.ReportSource = rptSalesReportItem1

            rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
            rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
            rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & str_ReportDate & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

        If is_printed = True Then
            rptSalesReportItem1.PrintOptions.PrinterName = pos_manager_printer
            rptSalesReportItem1.PrintToPrinter(printcopy, False, 0, 0)
        End If

    End Sub

    Friend Sub Generate_SalesReportPerReceipt()

        CRViewer.ReportSource = rptSalesReportReceipt1
        CRViewer.ShowLogo = False

        Dim MyCommand1 As New SqlCommand()
        Dim myDA1 As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand1.Connection = con

            MyCommand1.CommandText = "SELECT RECEIPTNO =  max(receiptno) + MAX(INVOICENO), AMOUNT = SUM(amount) , RECEIVABLES = SUM (RECEIVABLES) " & _
                                        "FROM VIEW_SALESINVENTORYREPORT WHERE DATETIME LIKE '%" & dtpDate.Text & "%' GROUP BY receiptno ORDER BY  receiptno asc"

            MyCommand1.CommandType = CommandType.Text
            myDA1.SelectCommand = MyCommand1


            myDA1.Fill(myDS, "VIEW_SALESINVENTORYREPORT")

            rptSalesReportReceipt1.SetDataSource(myDS)
            CRViewer.ReportSource = rptSalesReportReceipt1

            rptSalesReportReceipt1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
            rptSalesReportReceipt1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
            rptSalesReportReceipt1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & str_ReportDate & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

        If is_printed = True Then
            rptSalesReportReceipt1.PrintOptions.PrinterName = pos_manager_printer
            rptSalesReportReceipt1.PrintToPrinter(printcopy, False, 0, 0)
        End If

    End Sub

    Friend Sub Generate_XReport()

        If def_SR_Type = "TR" Then 'X-REPORT PER TRANSACTION

            CRViewer.ReportSource = rptSalesReport1
            CRViewer.ShowLogo = False
            Dim MyCommand1 As New SqlCommand()
            Dim myDA1 As New SqlDataAdapter()
            Dim myDS As New dsPOS   'The DataSet you created.
            Try
                myDS.EnforceConstraints = False
                MyCommand1.Connection = con
                MyCommand1.CommandText = "SELECT * FROM VIEW_SALESINVENTORYREPORT WHERE SESSIONID = '" & NewSessionID & "' ORDER BY  Product_Description asc, RecordID asc"
                MyCommand1.CommandType = CommandType.Text
                myDA1.SelectCommand = MyCommand1
                myDA1.Fill(myDS, "VIEW_SALESINVENTORYREPORT")
                rptSalesReport1.SetDataSource(myDS)
                CRViewer.ReportSource = rptSalesReport1
                rptSalesReport1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
                rptSalesReport1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
                rptSalesReport1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & str_ReportDate & "'"
            Catch Excep As Exception
                MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            CRViewer.Refresh()
            If is_printed = True Then
                rptSalesReport1.PrintOptions.PrinterName = pos_manager_printer
                rptSalesReport1.PrintToPrinter(printcopy, False, 0, 0)
            End If

        ElseIf def_SR_Type = "IT" Then  'X-REPORT PER ITEM
            CRViewer.ReportSource = rptSalesReportItem1
            CRViewer.ShowLogo = False
            Dim MyCommand1 As New SqlCommand()
            Dim myDA1 As New SqlDataAdapter()
            Dim myDS As New dsPOS   'The DataSet you created.
            Try
                myDS.EnforceConstraints = False
                MyCommand1.Connection = con

                MyCommand1.CommandText = "SELECT * FROM view_SalesInventoryReportItem WHERE SESSIONID = '" & NewSessionID & "' ORDER BY  Product_Description asc"
                MyCommand1.CommandType = CommandType.Text
                myDA1.SelectCommand = MyCommand1
                myDA1.Fill(myDS, "view_SalesInventoryReportItem")
                rptSalesReportItem1.SetDataSource(myDS)
                CRViewer.ReportSource = rptSalesReportItem1
                rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
                rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
                rptSalesReportItem1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & str_ReportDate & "'"
            Catch Excep As Exception
                MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            CRViewer.Refresh()
            If is_printed = True Then
                rptSalesReportItem1.PrintOptions.PrinterName = pos_manager_printer
                rptSalesReportItem1.PrintToPrinter(printcopy, False, 0, 0)
            End If


        ElseIf def_SR_Type = "RE" Then 'X-REPORT PER RECEIPT

            CRViewer.ReportSource = rptSalesReportReceipt1
            CRViewer.ShowLogo = False
            Dim MyCommand1 As New SqlCommand()
            Dim myDA1 As New SqlDataAdapter()
            Dim myDS As New dsPOS   'The DataSet you created.
            Try
                myDS.EnforceConstraints = False
                MyCommand1.Connection = con
                MyCommand1.CommandText = "SELECT RECEIPTNO =  max(receiptno) + MAX(INVOICENO), AMOUNT = SUM(amount) , RECEIVABLES = SUM (RECEIVABLES) " & _
                                            "FROM VIEW_SALESINVENTORYREPORT WHERE SESSIONID = '" & NewSessionID & "' AND STATUS = 1 AND PAYMENTTYPE <> 0 GROUP BY receiptno ORDER BY  receiptno asc"
                MyCommand1.CommandType = CommandType.Text
                myDA1.SelectCommand = MyCommand1
                myDA1.Fill(myDS, "VIEW_SALESINVENTORYREPORT")
                rptSalesReportReceipt1.SetDataSource(myDS)
                CRViewer.ReportSource = rptSalesReportReceipt1
                rptSalesReportReceipt1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
                rptSalesReportReceipt1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
                rptSalesReportReceipt1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & str_ReportDate & "'"
            Catch Excep As Exception
                MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            CRViewer.Refresh()
            If is_printed = True Then
                rptSalesReportReceipt1.PrintOptions.PrinterName = pos_manager_printer
                rptSalesReportReceipt1.PrintToPrinter(printcopy, False, 0, 0)
            End If

        Else ' X-REPORT PER ITEM IN ROLL PAPER

            Generate_Reading()

        End If

    End Sub

    Friend Sub Generate_PatronageReport()
        CRViewer.ReportSource = rptCustomerList1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        'Try
        myDS.EnforceConstraints = False
        MyCommand.Connection = con

        MyCommand.CommandText = "SELECT CUSTOMERID,FIRSTNAME = ISNULL(FIRSTNAME,'') + ' ' + ISNULL(LASTNAME,''), POINTS FROM DBO.CUSTOMERS"

        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand

        myDA.Fill(myDS, "CUSTOMERS")
        rptPatronageReport1.SetDataSource(myDS)
        CRViewer.ReportSource = rptPatronageReport1
        rptPatronageReport1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
        rptPatronageReport1.DataDefinition.FormulaFields.Item("var_ComAddress").Text = "'" & branch_address & "'"
        rptPatronageReport1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & FromDate & " - " & ToDate & "'"

        'Catch Excep As Exception
        '    MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        CRViewer.Refresh()
    End Sub

    Friend Sub Generate_PurchaseOrderReport()
        CRViewer.ReportSource = rptPurchaseOrder1
        CRViewer.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con
            MyCommand.CommandText = "SELECT * FROM VIEW_PURCHASEORDER WHERE PONUMBER = '" & PoNumber & "' "
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "VIEW_PURCHASEORDER")
            rptPurchaseOrder1.SetDataSource(myDS)
            CRViewer.ReportSource = rptPurchaseOrder1

            rptPurchaseOrder1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
            rptPurchaseOrder1.DataDefinition.FormulaFields.Item("var_CompanyAddress").Text = "'" & branch_address & "'"
            rptPurchaseOrder1.DataDefinition.FormulaFields.Item("var_CompanyContactNo").Text = "'" & branch_phoneno & "'"
            rptPurchaseOrder1.DataDefinition.FormulaFields.Item("var_Supplier").Text = "'" & SupplierName & "'"
            rptPurchaseOrder1.DataDefinition.FormulaFields.Item("var_SupplierAddress").Text = "'" & SupplierAddress & "'"
            rptPurchaseOrder1.DataDefinition.FormulaFields.Item("var_SupplierContactNo").Text = "'" & SupplierContactNo & "'"
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()
    End Sub

    Friend Sub Generate_AdjustmentReport()

        CRViewer.ReportSource = rptAdjustmentReport1
        CRViewer.ShowLogo = False

        Dim MyCommand1 As New SqlCommand()
        Dim myDA1 As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand1.Connection = con

            MyCommand1.CommandText = "SELECT * FROM VIEW_SALESINVENTORYREPORT WHERE DATETIME BETWEEN '" & FromDate & "' AND '" & ToDate & "' " & _
                "AND STATUS = 1 AND PAYMENTTYPE = 0 AND PRODUCTID NOT IN (1,2,3,4,5,6) ORDER BY  Product_Description asc"

            MyCommand1.CommandType = CommandType.Text
            myDA1.SelectCommand = MyCommand1

            myDA1.Fill(myDS, "VIEW_SALESINVENTORYREPORT")
            rptAdjustmentReport1.SetDataSource(myDS)
            CRViewer.ReportSource = rptAdjustmentReport1
            rptAdjustmentReport1.DataDefinition.FormulaFields.Item("var_CompanyName").Text = "'" & business_name & "'"
            rptAdjustmentReport1.DataDefinition.FormulaFields.Item("var_Address").Text = "'" & branch_address & "'"
            rptAdjustmentReport1.DataDefinition.FormulaFields.Item("var_Date").Text = "'" & str_ReportDate & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        CRViewer.Refresh()

        If is_printed = True Then
            rptAdjustmentReport1.PrintOptions.PrinterName = pos_manager_printer
            rptAdjustmentReport1.PrintToPrinter(printcopy, False, 0, 0)
        End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        str_ReportDate = dtpDate.Text
        is_printed = False

        If cboReportType.Text = "Sales Report per Transaction" Then
            Generate_SalesReport()
        ElseIf cboReportType.Text = "Monthly Sales Report" Then
            If cboReportType.Text = "Monthly Sales Report" Then
                frmSelect.ShowDialog()
            End If
        ElseIf cboReportType.Text = "Sales Report per Item" Then
            Generate_SalesReportPerItem()
        ElseIf cboReportType.Text = "Sales Report per Receipt" Then
            Generate_SalesReportPerReceipt()
        ElseIf cboReportType.Text = "Daily Inventory Report" Then
            Generate_DailyInvReport()
        ElseIf cboReportType.Text = "Monthly Inventory Report" Then
            Generate_StockControl()
        ElseIf cboReportType.Text = "Adjustment Report" Then
            frmSelect.ShowDialog()
        ElseIf cboReportType.Text = "Customers Masterlist" Then
            Generate_CustomerLIST()
        ElseIf cboReportType.Text = "Patronage Report" Then
            frmSelect.ShowDialog()
        ElseIf cboReportType.Text = "Purchase Order" Then
            Generate_PurchaseOrderReport()
        ElseIf cboReportType.Text = "Statement of Accounts Overall" Then
            Generate_CustomerAccnt_Overall()
        Else 'ItemMasterlist
            Generate_ProductList()
        End If

    End Sub

    Private Sub ShowItemsWithZeroMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowItemsWithZeroMenu.Click
        If cboReportType.Text = "Item Masterlist" Then
            IS_PRINT_ZERO_ITEMS = True
            Generate_ProductList()
        End If
    End Sub

    Private Sub DontShowItemsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DontShowItemsMenu.Click
        If cboReportType.Text = "Item Masterlist" Then
            IS_PRINT_ZERO_ITEMS = False
            Generate_ProductList()
        End If
    End Sub

End Class