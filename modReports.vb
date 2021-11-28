Imports System.Data.SqlClient
Imports CrystalDecisions.Shared

Module modReports

    Dim ReceiptRange As String
    Dim TotalSales As String = "0.00"
    Dim CashSales As String
    Dim ChargeSales As String
    Dim VISA As String
    Dim MASTERCARD As String
    Dim BDO As String
    Dim GiftCheck As String
    Dim VatExemptSales As String = "0.00"
    Dim TransactionCount As String = "0"
    Dim CashFund As String
    Dim CashDeposit As String
    Dim CashPullOut As String
    Dim NetSales As String = "0.00"
    Dim TotalDiscount As String
    Dim TotalRefund As String = "0.00"
    Dim R_VatableSales As String
    Dim R_VAT As String

    'purchase order
    Public PoNumber As String
    Public SupplierName As String
    Public SupplierAddress As String
    Public SupplierContactNo As String

    Public DENO_1000 As Integer
    Public DENO_500 As Integer
    Public DENO_200 As Integer
    Public DENO_100 As Integer
    Public DENO_50 As Integer
    Public DENO_20 As Integer
    Public DENO_10 As Integer
    Public DENO_5 As Integer
    Public DENO_1 As Integer

    Public viewer_Reading As New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Public rptReading1 As New rptReading
    Public rptXReport1 As New rptXReport

    'sales report for the end of day
    'can be use for bookkeeping
    'generated after end session
    'Z-REPORT
    Friend Sub Generate_Reading()
        'GetSalesReport()

        viewer_Reading.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            'MyCommand.CommandText = "SELECT PROD_DESCRIPTION,QUANTITY = SUM(QUANTITY), PRICE =(MAX(PRICE) * SUM(QUANTITY)) - DISCOUNT FROM VIEW_READING WHERE " & _
            '                        "SESSIONID = '" & NewSessionID & "' AND STATUS = 1 AND PAYMENTTYPE <> 0 GROUP BY PROD_DESCRIPTION,DISCOUNT ORDER BY PROD_DESCRIPTION ASC"
            MyCommand.CommandText = "SELECT PROD_DESCRIPTION, " & _
                                   "QUANTITY = SUM(QUANTITY), PRICE = CASE WHEN DISCOUNT = 0 THEN (MAX(PRICE) * SUM(QUANTITY)) - DISCOUNT  ELSE ((MAX(PRICE) * SUM(QUANTITY)) / 1.12) - DISCOUNT END " & _
                                   "FROM VIEW_READING WHERE SESSIONID = '" & NewSessionID & "' AND STATUS = 1 " & _
                                   "AND PAYMENTTYPE <> 0 GROUP BY PROD_DESCRIPTION,DISCOUNT ORDER BY PROD_DESCRIPTION ASC"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "READING")
            rptReading1.SetDataSource(myDS)
            viewer_Reading.ReportSource = rptReading1

            rptReading1.DataDefinition.FormulaFields.Item("BusinessName").Text = "'" & business_name & "'"
            rptReading1.DataDefinition.FormulaFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
            rptReading1.DataDefinition.FormulaFields.Item("MachineNo").Text = "'" & "Machine# : " & machine_no & "'"
            rptReading1.DataDefinition.FormulaFields.Item("PermitNo").Text = "'" & "BIR Permit# : " & permit_no & "'"
            rptReading1.DataDefinition.FormulaFields.Item("SerialNo").Text = "'" & "Serial# : " & serial_no & "'"
            rptReading1.DataDefinition.FormulaFields.Item("TIN").Text = "'" & "TIN# : " & tin_no & "'"
            rptReading1.DataDefinition.FormulaFields.Item("Reading").Text = "'" & "Report : Z-REPORT" & "'"
            rptReading1.DataDefinition.FormulaFields.Item("Branch").Text = "'" & "Branch : " & branch_name & "'"
            rptReading1.DataDefinition.FormulaFields.Item("TerminalNo").Text = "'" & "Terminal# : Terminal " & terminal_no & "'"
            rptReading1.DataDefinition.FormulaFields.Item("DateRange").Text = "'" & "Time Range : " & reading_timerange & "'"
            rptReading1.DataDefinition.FormulaFields.Item("ReceiptRange").Text = "'" & "Receipt# used : " & ReceiptRange & "'"
            rptReading1.DataDefinition.FormulaFields.Item("TotalSales").Text = "'" & TotalSales & "'"
            rptReading1.DataDefinition.FormulaFields.Item("CashSales").Text = "'" & CashSales & "'"
            rptReading1.DataDefinition.FormulaFields.Item("ChargeSales").Text = "'" & ChargeSales & "'"
            rptReading1.DataDefinition.FormulaFields.Item("VISA").Text = "'" & VISA & "'"
            rptReading1.DataDefinition.FormulaFields.Item("MASTERCARD").Text = "'" & MASTERCARD & "'"
            rptReading1.DataDefinition.FormulaFields.Item("BDO").Text = "'" & BDO & "'"
            rptReading1.DataDefinition.FormulaFields.Item("GiftCheck").Text = "'" & GiftCheck & "'"
            rptReading1.DataDefinition.FormulaFields.Item("VatableSales").Text = "'" & R_VatableSales & "'"
            rptReading1.DataDefinition.FormulaFields.Item("VAT").Text = "'" & R_VAT & "'"
            rptReading1.DataDefinition.FormulaFields.Item("VatExemptSales").Text = "'" & VatExemptSales & "'"
            rptReading1.DataDefinition.FormulaFields.Item("TransactionCount").Text = "'" & TransactionCount & "'"
            rptReading1.DataDefinition.FormulaFields.Item("CashFund").Text = "'" & CashFund & "'"
            rptReading1.DataDefinition.FormulaFields.Item("CashDeposit").Text = "'" & CashDeposit & "'"
            rptReading1.DataDefinition.FormulaFields.Item("CashPullOut").Text = "'" & CashPullOut & "'"
            rptReading1.DataDefinition.FormulaFields.Item("NetSales").Text = "'" & NetSales & "'"
            rptReading1.DataDefinition.FormulaFields.Item("TotalDiscount").Text = "'" & TotalDiscount & "'"
            rptReading1.DataDefinition.FormulaFields.Item("TotalRefund").Text = "'" & TotalRefund & "'"
            'DENOMINATIONS
            rptReading1.DataDefinition.FormulaFields.Item("var_1000").Text = "'" & DENO_1000 & "'"
            rptReading1.DataDefinition.FormulaFields.Item("var_500").Text = "'" & DENO_500 & "'"
            rptReading1.DataDefinition.FormulaFields.Item("var_200").Text = "'" & DENO_200 & "'"
            rptReading1.DataDefinition.FormulaFields.Item("var_100").Text = "'" & DENO_100 & "'"
            rptReading1.DataDefinition.FormulaFields.Item("var_50").Text = "'" & DENO_50 & "'"
            rptReading1.DataDefinition.FormulaFields.Item("var_20").Text = "'" & DENO_20 & "'"
            rptReading1.DataDefinition.FormulaFields.Item("var_10").Text = "'" & DENO_10 & "'"
            rptReading1.DataDefinition.FormulaFields.Item("var_5").Text = "'" & DENO_5 & "'"
            rptReading1.DataDefinition.FormulaFields.Item("var_1").Text = "'" & DENO_1 & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        viewer_Reading.Refresh()

        'whether to print to printer
        If is_PRINT_INV_REPORT = "YES" Then
            rptReading1.PrintOptions.PrinterName = pos_printer
            rptReading1.PrintToPrinter(1, False, 0, 0)
        End If

        'export to pdf
        If is_export_receipt = "YES" Then
            Try
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New  _
                DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                CrDiskFileDestinationOptions.DiskFileName = INV_FILEPATH & "\DAILY SALES REPORT - " & Format(Now, "MM-dd-yyyy") & ".pdf"

                CrExportOptions = rptReading1.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                rptReading1.Export()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    'generate quick sales reports for the current session
    'X-REPORT
    Friend Sub Generate_ReportForCurrentSession()
        GetSalesReport()
        viewer_Reading.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT PROD_DESCRIPTION, " & _
                                    "QUANTITY = SUM(QUANTITY), PRICE = CASE WHEN DISCOUNT = 0 THEN (MAX(PRICE) * SUM(QUANTITY)) - DISCOUNT  ELSE ((MAX(PRICE) * SUM(QUANTITY)) / 1.12) - DISCOUNT END " & _
                                    "FROM VIEW_READING WHERE SESSIONID = '" & NewSessionID & "' AND STATUS = 1 " & _
                                    "AND PAYMENTTYPE <> 0 GROUP BY PROD_DESCRIPTION,DISCOUNT ORDER BY PROD_DESCRIPTION ASC"

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "READING")
            rptXReport1.SetDataSource(myDS)
            viewer_Reading.ReportSource = rptXReport1

            Dim _reportFields = rptXReport1.DataDefinition.FormulaFields
            _reportFields.Item("BusinessName").Text = "'" & business_name & "'"
            _reportFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
            _reportFields.Item("MachineNo").Text = "'" & "Machine# : " & machine_no & "'"
            _reportFields.Item("PermitNo").Text = "'" & "BIR Permit# : " & permit_no & "'"
            _reportFields.Item("SerialNo").Text = "'" & "Serial# : " & serial_no & "'"
            _reportFields.Item("TIN").Text = "'" & "TIN# : " & tin_no & "'"
            _reportFields.Item("Reading").Text = "'" & "Report : Z-REPORT" & "'"
            _reportFields.Item("Branch").Text = "'" & "Branch : " & branch_name & "'"
            _reportFields.Item("TerminalNo").Text = "'" & "Terminal# : Terminal " & terminal_no & "'"
            _reportFields.Item("DateRange").Text = "'" & "Time Range : " & reading_timerange & "'"
            _reportFields.Item("ReceiptRange").Text = "'" & "Receipt# used : " & ReceiptRange & "'"
            _reportFields.Item("TotalSales").Text = "'" & TotalSales & "'"
            _reportFields.Item("CashSales").Text = "'" & CashSales & "'"
            _reportFields.Item("ChargeSales").Text = "'" & ChargeSales & "'"
            _reportFields.Item("VISA").Text = "'" & VISA & "'"
            _reportFields.Item("MASTERCARD").Text = "'" & MASTERCARD & "'"
            _reportFields.Item("BDO").Text = "'" & BDO & "'"
            _reportFields.Item("GiftCheck").Text = "'" & GiftCheck & "'"
            _reportFields.Item("VatableSales").Text = "'" & R_VatableSales & "'"
            _reportFields.Item("VAT").Text = "'" & R_VAT & "'"
            _reportFields.Item("VatExemptSales").Text = "'" & VatExemptSales & "'"
            _reportFields.Item("TransactionCount").Text = "'" & TransactionCount & "'"
            _reportFields.Item("CashFund").Text = "'" & CashFund & "'"
            _reportFields.Item("CashDeposit").Text = "'" & CashDeposit & "'"
            _reportFields.Item("CashPullOut").Text = "'" & CashPullOut & "'"
            _reportFields.Item("NetSales").Text = "'" & NetSales & "'"
            _reportFields.Item("TotalDiscount").Text = "'" & TotalDiscount & "'"
            _reportFields.Item("TotalRefund").Text = "'" & TotalRefund & "'"

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        viewer_Reading.Refresh()

        'whether to print to printer
        If is_PRINT_INV_REPORT = "YES" Then
            rptXReport1.PrintOptions.PrinterName = pos_printer
            rptXReport1.PrintToPrinter(1, False, 0, 0)
        End If

        'export to pdf
        If is_export_receipt = "YES" Then
            Try
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New  _
                DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                CrDiskFileDestinationOptions.DiskFileName = INV_FILEPATH & "\DAILY SALES REPORT - " & Format(Now, "MM-dd-yyyy") & ".pdf"

                CrExportOptions = rptXReport1.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                rptXReport1.Export()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Public Sub GetReadings()
        connect()
        cmd = New SqlCommand("SELECT RIGHT(timestarted, 8)  FROM POS_SESSION ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            reading_type = "Z-REPORT"
            reading_timestart = dr(0)
            reading_timeend = Format(Now, "hh:mm tt")
            reading_timerange = reading_timestart & " - " & DateTime.Now.ToString("hh:mm tt")
        End If
        disconnect()
    End Sub

    Public Sub GetReceiptRange()
        Dim x As String
        Dim y As String
        connect()
        cmd = New SqlCommand(" select top 1 receiptno from view_reading where sessionid = '" & NewSessionID & "' and status = 1 and receiptno <> '0' order by receiptno asc ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            x = dr("receiptno")
            ReceiptRange = x
        Else
            ReceiptRange = ""
        End If
        disconnect()

        connect()
        cmd = New SqlCommand(" select top 1 receiptno from  view_reading where sessionid = '" & NewSessionID & "' and status = 1 and receiptno <> '0' order by receiptno desc ", con)
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        If dr1.Read Then
            y = dr1("receiptno")
            ReceiptRange = ReceiptRange & " - " & y
        Else
            ReceiptRange = ""
        End If
        disconnect()

    End Sub

    Public Sub GetSalesReport()

        'TOTAL SALES
        connect()
        cmd = New SqlCommand("EXEC sp_GetCurrentSales '" & NewSessionID & "'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                TotalSales = Format(dr("totalsales"), "##,##0.00")
                CashSales = Format(dr("cashsales"), "##,##0.00")
                ChargeSales = Format(dr("chargesales"), "##,##0.00")
                TotalDiscount = Format(dr("totaldiscount"), "##,##0.00")
                TransactionCount = dr("totaltransactions")
                CashFund = Format(dr("cashfund"), "##,##0.00")
                CashDeposit = Format(dr("cashdeposit"), "##,##0.00")
                CashPullOut = Format(dr("cashpullout"), "##,##0.00")
                R_VatableSales = Format(dr("totalvatablesales"), "##,##0.00")
                R_VAT = Format(dr("totalvatamount"), "##,##0.00")

            Catch ex As Exception

                MsgBox(ex.ToString())

                TotalSales = "0.00"
                CashSales = "0.00"
                ChargeSales = "0.00"
                TotalDiscount = "0.00"
                TransactionCount = "0.00"
                CashFund = "0.00"
                CashDeposit = "0.00"
                CashPullOut = "0.00"
                R_VatableSales = "0.00"
                R_VAT = "0.00"
            End Try
        End If
        disconnect()

        ''CASH SALES
        'connect()
        'cmd = New SqlCommand(" select cashsales = sum(amount) from [transaction] where sessionid = '" & NewSessionID & "'  and paymenttype = '1' and status = 1", con)
        'Dim dr1 As SqlDataReader = cmd.ExecuteReader
        'If dr1.Read Then
        '    Try
        '        CashSales = Format(dr1("cashsales"), "0.00")
        '    Catch ex As Exception
        '        CashSales = "0.00"
        '    End Try
        'End If
        'disconnect()

        ''CHARGE SALES
        'connect()
        'cmd = New SqlCommand(" select chargesales = round(sum(receivables), 2, 1)  from [transaction] where sessionid = '" & NewSessionID & "'  and paymenttype = '2' and status = 1", con)
        'Dim dr2 As SqlDataReader = cmd.ExecuteReader
        'If dr2.Read Then
        '    Try
        '        ChargeSales = Format(dr2("chargesales"), "0.00")
        '    Catch ex As Exception
        '        ChargeSales = "0.00"
        '    End Try
        'End If
        'disconnect()

        ''MASTER CARD
        'connect()
        'cmd = New SqlCommand(" select cardsales = sum(amount) from [transaction] where sessionid = '" & NewSessionID & "'  and paymenttype = '3' and cardtype = '2' and status = 1", con) ' MASTERCARD
        'Dim dr_mastercard As SqlDataReader = cmd.ExecuteReader
        'If dr_mastercard.Read Then
        '    Try
        '        MASTERCARD = Format(dr_mastercard("cardsales"), "0.00")
        '    Catch ex As Exception
        '        MASTERCARD = "0.00"
        '    End Try
        'End If
        'disconnect()

        ''VISA
        'connect()
        'cmd = New SqlCommand(" select cardsales = sum(amount) from [transaction] where sessionid = '" & NewSessionID & "'  and paymenttype = '3' and cardtype = '1' and status = 1", con) ' VISA
        'Dim dr_visa As SqlDataReader = cmd.ExecuteReader
        'If dr_visa.Read Then
        '    Try
        '        VISA = Format(dr_visa("cardsales"), "0.00")
        '    Catch ex As Exception
        '        VISA = "0.00"
        '    End Try
        'End If
        'disconnect()

        ''BDO
        'connect()
        'cmd = New SqlCommand(" select cardsales = sum(amount) from [transaction] where sessionid = '" & NewSessionID & "'  and paymenttype = '3' and cardtype = '3' and status = 1", con) ' BDO
        'Dim dr_bdo As SqlDataReader = cmd.ExecuteReader
        'If dr_bdo.Read Then
        '    Try
        '        BDO = Format(dr_bdo("cardsales"), "0.00")
        '    Catch ex As Exception
        '        BDO = "0.00"
        '    End Try
        'End If
        'disconnect()

        ''GIFT CHECK
        'connect()
        'cmd = New SqlCommand(" select cardsales = sum(amount) from [transaction] where sessionid = '" & NewSessionID & "'  and paymenttype = '3' and cardtype = '6' and status = 1", con) ' GIFTCHECK
        'Dim dr_giftcheck As SqlDataReader = cmd.ExecuteReader
        'If dr_giftcheck.Read Then
        '    Try
        '        GiftCheck = Format(dr_giftcheck("cardsales"), "0.00")
        '    Catch ex As Exception
        '        GiftCheck = "0.00"
        '    End Try
        'End If
        'disconnect()

        ''TOTAL DISCOUNT
        'connect()
        'cmd = New SqlCommand(" select discount = round(sum(discount), 2, 1) from [transaction] where SessionID = '" & NewSessionID & "' and status = 1", con)
        'Dim dr4 As SqlDataReader = cmd.ExecuteReader
        'If dr4.Read Then
        '    Try
        '        TotalDiscount = Format(dr4("discount"), "0.00")
        '    Catch ex As Exception
        '        TotalDiscount = "0.00"
        '    End Try
        'End If
        'disconnect()

        ''TRANSACTION COUNT
        'connect()
        'cmd = New SqlCommand("select transactionno = isnull(count(transactionno),0) from [transaction] where " & _
        '                     "sessionid = '" & NewSessionID & "' and status = 1 group by receiptno", con)
        'Dim dr5 As SqlDataReader = cmd.ExecuteReader
        'If dr5.HasRows Then
        '    Dim i As Integer
        '    While dr5.Read()
        '        i = i + 1
        '    End While
        '    If i = 0 Then
        '        TransactionCount = "No data returned"
        '    Else
        '        TransactionCount = i
        '    End If
        'Else
        '    TransactionCount = "0"
        'End If
        'disconnect()

        ''CASH FUND, CASH DEPOSIT & CASH PULL-OUT
        'connect()
        'cmd = New SqlCommand(" select cashfund,cashdeposit,cashpullout from pos_session ", con)
        'Dim dr6 As SqlDataReader = cmd.ExecuteReader
        'If dr6.Read Then
        '    'Try
        '    CashFund = Format(dr6("cashfund"), "0.00")
        '    CashDeposit = Format(dr6("cashdeposit"), "0.00")
        '    CashPullOut = Format(dr6("cashpullout"), "0.00")
        '    'Catch ex As Exception
        '    '    CashFund = "0.00"
        '    '    CashDeposit = "0.00"
        '    '    CashPullOut = "0.00"
        '    'End Try
        'End If
        'disconnect()

        ''VATABLE SALES
        'connect()
        'cmd = New SqlCommand(" select vatable_sales = sum(VatableSales), vat = sum(Vat) from [transaction] where sessionid = '" & NewSessionID & "' and status = 1", con)
        'Dim dr7 As SqlDataReader = cmd.ExecuteReader
        'If dr7.Read Then
        '    Try
        '        R_VatableSales = Format(dr7("vatable_sales"), "0.00")
        '        R_VAT = Format(dr7("vat"), "0.00")
        '    Catch ex As Exception
        '        R_VatableSales = "0.00"
        '        R_VAT = "0.00"
        '    End Try
        'End If
        'disconnect()

    End Sub

    Friend Sub calculateCashback(ByVal fromDate As String, ByVal toDate As String)
        connect()
        cmd = New SqlCommand("EXEC sp_GeneratePatronageReport '" & fromDate & "', '" & toDate & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

End Module