Imports System.Data.SqlClient
Imports CrystalDecisions.Shared

Module modReceipt

    'RECEIPT VARIABLES
    Dim Payment As String
    Dim Change As String
    Dim VAT As String
    Dim TotalAmount As String
    Dim SubTotal As String
    Public Total_Discount As String
    Dim CompanyName As String
    Dim BusinessName As String
    Dim VatableSales As String
    Dim PercentVat As String

    'REPORTVIEWER
    Dim reportviewCash As New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Dim reportviewCharge As New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Dim reportviewCard As New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Dim reportviewSplit As New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Dim reportviewCoupon As New CrystalDecisions.Windows.Forms.CrystalReportViewer

    'CRYSTAL REPORT DOCUMENT
    Dim rptReceipt_Cash1 As New rptReceipt_Cash
    Dim rptReceipt_Charge1 As New rptReceipt_Charge
    Dim rptReceipt_Card1 As New rptReceipt_Card
    Dim rptReceipt_Split1 As New rptReceipt_Split
    Dim rptCoupon1 As New rptCoupon
    Dim rptReprintReceipt1 As New rptReprintReceipt
    Dim rptReprintCoupon1 As New rptReprintCoupon

    'CASH PAYMENT
    Friend Sub GenerateReceipt()

        reportviewCash.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT CASE WHEN PRODUCTID = 0 THEN PROD_DESCRIPTION + ' - ' + CAST(AMOUNT AS NVARCHAR) ELSE PROD_DESCRIPTION END AS " & _
                                    "[PROD_DESCRIPTION],QUANTITY,PRICE,AMOUNT FROM TRANSACTION_TEMP ORDER BY RECORDID,DISCOUNTTYPE ASC"

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "TRANSACTION_TEMP")
            rptReceipt_Cash1.SetDataSource(myDS)
            reportviewCash.ReportSource = rptReceipt_Cash1

            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("Cashier").Text = "'" & cashier_name & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("Customer").Text = "'" & cust_name & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("SubTotal").Text = "'" & SubTotal & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("TotalAmount").Text = "'" & TotalAmount & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("Payment").Text = "'" & Format(CDbl(Val(trans_payment)), "##,##0.00") & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("Change").Text = "'" & trans_change & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("TotalPoints").Text = "'" & trans_points & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("VatSales").Text = "'" & VatableSales & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("12PercentVat").Text = "'" & PercentVat & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("TotalDiscount").Text = "'" & Total_Discount & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("BusinessName").Text = "'" & business_name & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("TIN").Text = "'" & "TIN#: " & tin_no & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("SerialNo").Text = "'" & "SN: " & serial_no & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("PermitNo").Text = "'" & "BIR Permit#: " & permit_no & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("MachineNo").Text = "'" & "MIN: " & machine_no & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("TerminalNo").Text = "'" & terminal_name & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("ReceiptNo").Text = "'" & receipt_no & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("Cashier").Text = "'" & cashier_name & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("Line26").Text = "'" & Footer26 & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("Line27").Text = "'" & Footer27 & "'"
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("Line28").Text = "'" & Footer28 & "'"
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        reportviewCash.Refresh()

        'PrintToPrinter(NumberOFCopies, Collated, StartPage, EndPage)
        If isalways_print_receipt = "YES" Then
            rptReceipt_Cash1.PrintOptions.PrinterName = pos_printer
            rptReceipt_Cash1.PrintToPrinter(printcopy, True, 0, 0)
        End If

        If is_print_points = "NO" Then
            rptReceipt_Cash1.DataDefinition.FormulaFields.Item("TotalPoints").Text = ""
        End If


        If is_export_receipt = "YES" Then

            Try
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New  _
                DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                CrDiskFileDestinationOptions.DiskFileName = INV_FILEPATH & "\RECEIPT# - " & receipt_no & ".pdf"

                CrExportOptions = rptReceipt_Cash1.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                rptReceipt_Cash1.Export()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If


    End Sub

    'CHARGE PAYMENT
    Friend Sub GenerateReceipt_Charge()
        reportviewCharge.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        'Try
        myDS.EnforceConstraints = False
        MyCommand.Connection = con

        MyCommand.CommandText = "SELECT CASE WHEN PRODUCTID = 0 THEN PROD_DESCRIPTION + ' --- ' + CAST(AMOUNT AS NVARCHAR) ELSE PROD_DESCRIPTION END AS " & _
                                "[PROD_DESCRIPTION],QUANTITY,PRICE = PRICE * QUANTITY FROM TRANSACTION_TEMP ORDER BY RECORDID,DISCOUNTTYPE ASC"

        MyCommand.CommandType = CommandType.Text
        myDA.SelectCommand = MyCommand

        myDA.Fill(myDS, "TRANSACTION_TEMP")
        rptReceipt_Charge1.SetDataSource(myDS)
        reportviewCharge.ReportSource = rptReceipt_Charge1

        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("SubTotal").Text = "'" & SubTotal & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("Cashier").Text = "'" & cashier_name & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("Customer").Text = "'" & cust_name & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("TotalAmount").Text = "'" & TotalAmount & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("ChargeAmount").Text = "'" & CDbl(TotalAmount) & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("ChargeType").Text = "'" & trans_chargetype & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("TotalPoints").Text = "'" & new_points & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("Balance").Text = "'" & new_balance & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("VatSales").Text = "'" & VatableSales & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("12PercentVat").Text = "'" & PercentVat & "'"
        'rptReceipt_Charge1.DataDefinition.FormulaFields.Item("TotalDiscount").Text = "'" & Total_Discount & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("BusinessName").Text = "'" & business_name & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("TIN").Text = "'" & "TIN No. :" & tin_no & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("PermitNo").Text = "'" & "BIR Permit No. :" & permit_no & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("MachineNo").Text = "'" & "Machine No. :" & machine_no & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("SerialNo").Text = "'" & "Serial No. :" & serial_no & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("TerminalNo").Text = "'" & "Terminal :" & terminal_name & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("ReceiptNo").Text = "'" & receipt_no & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("Cashier").Text = "'" & cashier_name & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("Line27").Text = "'" & Footer27 & "'"
        rptReceipt_Charge1.DataDefinition.FormulaFields.Item("Line28").Text = "'" & Footer28 & "'"
        'Catch Ex As Exception
        '    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        reportviewCharge.Refresh()

        If isalways_print_receipt = "YES" Then
            rptReceipt_Charge1.PrintOptions.PrinterName = pos_printer
            rptReceipt_Charge1.PrintToPrinter(1, False, 0, 0)
        End If
    End Sub

    'CARD PAYMENT
    Friend Sub GenerateReceipt_Card()
        reportviewCard.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT CASE WHEN PRODUCTID = 0 THEN PROD_DESCRIPTION + ' --- ' + CAST(AMOUNT AS NVARCHAR) ELSE PROD_DESCRIPTION END AS " & _
                                    "[PROD_DESCRIPTION],QUANTITY,PRICE FROM TRANSACTION_TEMP ORDER BY RECORDID,DISCOUNTTYPE ASC"

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "TRANSACTION_TEMP")
            rptReceipt_Card1.SetDataSource(myDS)
            reportviewCard.ReportSource = rptReceipt_Card1

            rptReceipt_Card1.DataDefinition.FormulaFields.Item("SubTotal").Text = "'" & SubTotal & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("TotalAmount").Text = "'" & TotalAmount & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("CardAmount").Text = "'" & trans_cardamount & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("CardType").Text = "'" & trans_cardtype & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("VatSales").Text = "'" & trans_vatablesales & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("12PercentVat").Text = "'" & trans_productvat & "'"
            'rptReceipt_Card1.DataDefinition.FormulaFields.Item("TotalDiscount").Text = "'" & Total_Discount & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("BusinessName").Text = "'" & business_name & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("TIN").Text = "'" & "TIN No. :" & tin_no & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("SerialNo").Text = "'" & "Serial No. :" & serial_no & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("PermitNo").Text = "'" & "BIR Permit No. :" & permit_no & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("MachineNo").Text = "'" & "Machine No. :" & machine_no & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("TerminalNo").Text = "'" & "Terminal :" & terminal_name & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("ReceiptNo").Text = "'" & receipt_no & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("Cashier").Text = "'" & cashier_name & "'"
            'rptReceipt_Card1.DataDefinition.FormulaFields.Item("Balance").Text = "'" & trans_newbalance & "'"
            'rptReceipt_Card1.DataDefinition.FormulaFields.Item("TotalPoints").Text = "'" & trans_points & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("CardHolder").Text = "'" & cust_name & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("CardNo").Text = "'" & trans_cardno & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("ApprovalNo").Text = "'" & trans_approvalno & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("ExpiryDate").Text = "'" & trans_expirydate & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("Line26").Text = "'" & Footer26 & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("Line27").Text = "'" & Footer27 & "'"
            rptReceipt_Card1.DataDefinition.FormulaFields.Item("Line28").Text = "'" & Footer28 & "'"
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        reportviewCard.Refresh()

        If isalways_print_receipt = "YES" Then
            rptReceipt_Card1.PrintOptions.PrinterName = pos_printer
            rptReceipt_Card1.PrintToPrinter(printcopy, False, 0, 0)
        End If
    End Sub

    'SPLIT PAYMENT
    Friend Sub GenerateReceipt_SplitPayment()
        reportviewSplit.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT CASE WHEN PRODUCTID = 0 THEN PROD_DESCRIPTION + ' --- ' + CAST(AMOUNT AS NVARCHAR) ELSE PROD_DESCRIPTION END AS " & _
                                    "[PROD_DESCRIPTION],QUANTITY,PRICE FROM TRANSACTION_TEMP ORDER BY RECORDID,DISCOUNTTYPE ASC"

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "TRANSACTION_TEMP")
            rptReceipt_Split1.SetDataSource(myDS)
            reportviewSplit.ReportSource = rptReceipt_Split1

            rptReceipt_Split1.DataDefinition.FormulaFields.Item("SubTotal").Text = "'" & SubTotal & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("TotalAmount").Text = "'" & TotalAmount & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("CashAmount").Text = "'" & frmTender_Split.txtCashAmnt.Text & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("ChargeAmount").Text = "'" & frmTender_Split.txtChargeAmt.Text & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("ChargeType").Text = "'" & trans_chargetype & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("CardAmount").Text = "'" & frmTender_Split.txtCardAmt.Text & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("CardType").Text = "'" & trans_cardtype & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("VatSales").Text = "'" & trans_vatablesales & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("12PercentVat").Text = "'" & trans_productvat & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("TotalDiscount").Text = "'" & Total_Discount & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("BusinessName").Text = "'" & business_name & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("TIN").Text = "'" & "TIN No. :" & tin_no & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("SerialNo").Text = "'" & "TIN No. :" & serial_no & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("PermitNo").Text = "'" & "Permit No. :" & permit_no & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("MachineNo").Text = "'" & "Machine No. :" & machine_no & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("TerminalNo").Text = "'" & "Terminal :" & terminal_name & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("ReceiptNo").Text = "'" & receipt_no & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("Cashier").Text = "'" & cashier_name & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("Balance").Text = "'" & trans_newbalance & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("TotalPoints").Text = "'" & trans_points & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("CardHolder").Text = "'" & cust_name & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("CardNo").Text = "'" & trans_cardno & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("ApprovalNo").Text = "'" & trans_approvalno & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("ExpiryDate").Text = "'" & trans_expirydate & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("Line26").Text = "'" & Footer26 & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("Line27").Text = "'" & Footer27 & "'"
            rptReceipt_Split1.DataDefinition.FormulaFields.Item("Line28").Text = "'" & Footer28 & "'"
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        reportviewSplit.Refresh()

        If isalways_print_receipt = "YES" Then
            rptReceipt_Split1.PrintOptions.PrinterName = pos_printer
            rptReceipt_Split1.PrintToPrinter(printcopy, False, 0, 0)
        End If

    End Sub

    'CASH PAYMENT (COUPON)
    Friend Sub GenerateCoupon()

        reportviewCoupon.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT CASE WHEN PRODUCTID = 0 THEN PROD_DESCRIPTION + ' - ' + CAST(AMOUNT AS NVARCHAR) ELSE PROD_DESCRIPTION END AS " & _
                                    "[PROD_DESCRIPTION],QUANTITY,PRICE,AMOUNT FROM TRANSACTION_TEMP ORDER BY RECORDID,DISCOUNTTYPE ASC"

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "TRANSACTION_TEMP")
            rptCoupon1.SetDataSource(myDS)
            reportviewCoupon.ReportSource = rptCoupon1

            rptCoupon1.DataDefinition.FormulaFields.Item("SubTotal").Text = "'" & SubTotal & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("TotalAmount").Text = "'" & TotalAmount & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("Payment").Text = "'" & trans_payment & ".00" & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("Change").Text = "'" & trans_change & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("VatSales").Text = "'" & VatableSales & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("12PercentVat").Text = "'" & PercentVat & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("TotalDiscount").Text = "'" & Total_Discount & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("BusinessName").Text = "'" & business_name & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("Line26").Text = "'" & Footer26 & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("Line27").Text = "'" & Footer27 & "'"
            rptCoupon1.DataDefinition.FormulaFields.Item("Line28").Text = "'" & Footer28 & "'"
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        reportviewCoupon.Refresh()
        ''''''''PrintToPrinter(NumberOFCopies, Collated, StartPage, EndPage)
        Try
            If isalways_print_receipt = "YES" Then
                rptCoupon1.PrintOptions.PrinterName = pos_printer
                rptCoupon1.PrintToPrinter(printcopy, True, 0, 0)
            End If
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Check printer connectivity.", "Print Receipt", _
                                                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        

    End Sub

    'PAYMENT DETAILS
    Friend Sub ReceiptPaymentDetails()

        connect()
        cmd = New SqlCommand("SELECT total = ROUND(SUM(amount),2 ,1), subtotal = ROUND(SUM(amount),2 ,1), discount = ISNULL(ROUND(SUM(discount),2 ,1),0), " & _
                             "vatablesales = ROUND(sum(vatableamount),2 ,1), percentvat = ROUND(SUM(vat), 2, 1) ," & _
                             "points = ROUND(sum(amount),2 ,1) / '" & points_percentage & "' FROM transaction_temp WHERE productid <> 0", con)
        Dim dr2 As SqlDataReader = cmd.ExecuteReader
        If dr2.Read Then
            TotalAmount = Format(dr2("total"), "#,##0.00")
            Total_Discount = Format(dr2("discount"), "#,##0.00")
            SubTotal = Format(dr2("subtotal"), "#,##0.00")
            VatableSales = Format(dr2("vatablesales"), "#,##0.00")
            PercentVat = Format(dr2("percentvat"), "#,##0.00")
            trans_points = Format(dr2("points"), "#,##0.00")
        End If
        disconnect()

    End Sub

    'REPRINT RECEIPT
    Friend Sub GenerateReprintReceipt()

        reportviewCash.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT PROD_DESCRIPTION, QUANTITY, PRICE, AMOUNT FROM VIEW_TRANSACTION WHERE RECEIPTNO = '" & frmReprint.REPRINT_RECEIPTNO & "' "

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "VIEW_TRANSACTION")
            rptReprintReceipt1.SetDataSource(myDS)
            reportviewCash.ReportSource = rptReprintReceipt1

            rptReprintReceipt1.DataDefinition.FormulaFields.Item("Cashier").Text = "'" & cashier_name & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("Customer").Text = "'" & cust_name & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("SubTotal").Text = "'" & frmReprint.reprint_SubTotal & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("TotalAmount").Text = "'" & frmReprint.reprint_TotalAmnt & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("Payment").Text = "'" & frmReprint.reprint_transPayment & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("Change").Text = "'" & frmReprint.reprint_transChange & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("TotalPoints").Text = "'" & frmReprint.reprint_TotalPoint & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("VatSales").Text = "'" & frmReprint.reprint_VatableSales & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("12PercentVat").Text = "'" & frmReprint.reprint_12PercentVat & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("TotalDiscount").Text = "'" & frmReprint.reprint_TotalDiscounts & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("BusinessName").Text = "'" & business_name & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("TIN").Text = "'" & "TIN#:" & tin_no & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("SerialNo").Text = "'" & "SN:" & serial_no & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("PermitNo").Text = "'" & "BIR Permit#:" & permit_no & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("MachineNo").Text = "'" & "MIN:" & machine_no & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("TerminalNo").Text = "'" & terminal_name & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("ReceiptNo").Text = "'" & frmReprint.REPRINT_RECEIPTNO & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("Cashier").Text = "'" & cashier_name & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("Line26").Text = "'" & Footer26 & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("Line27").Text = "'" & Footer27 & "'"
            rptReprintReceipt1.DataDefinition.FormulaFields.Item("Line28").Text = "'" & Footer28 & "'"
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        reportviewCash.Refresh()
        ''''''''PrintToPrinter(NumberOFCopies, Collated, StartPage, EndPage)
        If isalways_print_receipt = "YES" Then
            rptReprintReceipt1.PrintOptions.PrinterName = pos_printer
            rptReprintReceipt1.PrintToPrinter(printcopy, True, 0, 0)
        End If

    End Sub

    Friend Sub GenerateReprintCoupon()

        reportviewCoupon.ShowLogo = False

        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New dsPOS   'The DataSet you created.

        Try
            myDS.EnforceConstraints = False
            MyCommand.Connection = con

            MyCommand.CommandText = "SELECT CASE WHEN PRODUCT_ID = 0 THEN PROD_DESCRIPTION + ' - ' + CAST(AMOUNT AS NVARCHAR) ELSE PROD_DESCRIPTION END AS " & _
                                    "[PROD_DESCRIPTION],QUANTITY,PRICE,AMOUNT FROM VIEW_SALESREPORT WHERE RECEIPTNO = '" & frmReprint.REPRINT_RECEIPTNO & "' "

            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "VIEW_SALESREPORT")
            rptReprintCoupon1.SetDataSource(myDS)
            reportviewCoupon.ReportSource = rptReprintCoupon1

            rptReprintCoupon1.DataDefinition.FormulaFields.Item("SubTotal").Text = "'" & SubTotal & "'"
            rptReprintCoupon1.DataDefinition.FormulaFields.Item("TotalAmount").Text = "'" & TotalAmount & "'"
            rptReprintCoupon1.DataDefinition.FormulaFields.Item("BusinessName").Text = "'" & business_name & "'"
            rptReprintCoupon1.DataDefinition.FormulaFields.Item("BusinessAddress").Text = "'" & branch_address & "'"
            rptReprintCoupon1.DataDefinition.FormulaFields.Item("Line26").Text = "'" & Footer26 & "'"
            rptReprintCoupon1.DataDefinition.FormulaFields.Item("Line27").Text = "'" & Footer27 & "'"
            rptReprintCoupon1.DataDefinition.FormulaFields.Item("Line28").Text = "'" & Footer28 & "'"
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        reportviewCoupon.Refresh()
        ''''''''PrintToPrinter(NumberOFCopies, Collated, StartPage, EndPage)
        If isalways_print_receipt = "YES" Then
            rptReprintCoupon1.PrintOptions.PrinterName = pos_printer
            rptReprintCoupon1.PrintToPrinter(printcopy, True, 0, 0)
        End If

    End Sub

End Module
