Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmViewSales

    Dim TRANS_QTY As Decimal

    Private Sub frmViewSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_Sales()
        GetCurrentSalesReport()

        'Get_TOPSELLERS()
        'Get_TOPCUSTOMERS()
        'Get_REORDERITEMS()
        'Get_ChartData()
        'SuperTabItem1.ReleaseFocus()
    End Sub

    Friend Sub Get_Sales()
        cmd = New SqlCommand("SELECT NUMBER=T.RECEIPTNO + T.INVOICENO,P.PROD_DESCRIPTION,T.QUANTITY,T.PRICE,AMOUNT FROM DBO.[TRANSACTION] T " & _
                             "INNER JOIN DBO.PRODUCTS P ON T.PRODUCTID=P.ITEMID WHERE T.SESSIONID = '" & NewSessionID & "' AND " & _
                             "T.STATUS = 1 AND PAYMENTTYPE <> 0 AND P.PRODUCTID NOT IN (1,2,3,4,5,6)", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrSales
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
            End While
        End With
        dr.Close()
        disconnect()

        Try
            For i As Integer = 0 To dgrSales.Rows.Count - 1
                TRANS_QTY = dgrSales.Rows(i).Cells(2).Value
                If TRANS_QTY = Int(TRANS_QTY) Then
                    dgrSales.Rows(i).Cells(2).Value = TRANS_QTY.ToString("N0", CultureInfo.InvariantCulture)
                Else
                    dgrSales.Rows(i).Cells(2).Value = TRANS_QTY.ToString("N2", CultureInfo.InvariantCulture)
                End If
            Next
        Catch ex As Exception

        End Try


    End Sub

    Public Sub GetCurrentSalesReport()

        'RETRIEVE CURRENT SALES
        connect()
        cmd = New SqlCommand("EXEC sp_GetCurrentSales '" & NewSessionID & "'", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                txtTotalSales.Text = Format(dr("totalsales"), "##,##0.00")
                txtCashSales.Text = Format(dr("cashsales"), "##,##0.00")
                txtChargeSales.Text = Format(dr("chargesales"), "##,##0.00")
                txtTotalTrans.Text = dr("totaltransactions")
                txtCashFund.Text = Format(dr("cashfund"), "##,##0.00")
                txtTotDeposit.Text = Format(dr("cashdeposit"), "##,##0.00")
                txtCashOut.Text = Format(dr("cashpullout"), "##,##0.00")
                txtTotalDiscounts.Text = Format(dr("totaldiscount"), "##,##0.00")
                txtVatableSales.Text = Format(dr("totalvatablesales"), "##,##0.00")
                txtVatAmount.Text = Format(dr("totalvatamount"), "##,##0.00")
            Catch ex As Exception
                txtTotalSales.Text = "0.00"
                txtCashSales.Text = "0.00"
                txtChargeSales.Text = "0.00"
                txtTotalTrans.Text = "0.00"
                txtCashFund.Text = "0.00"
                txtTotDeposit.Text = "0.00"
                txtCashOut.Text = "0.00"
                txtTotalDiscounts.Text = "0.00"
                txtVatableSales.Text = "0.00"
                txtVatAmount.Text = "0.00"
            End Try
        End If
        disconnect()

    End Sub

    Friend Sub Get_TOPSELLERS()
        cmd = New SqlCommand("SELECT TOP 10 'PRODUCTID' = MAX(PRODUCTID),MAX(PRODUCT_DESCRIPTION),TOTQTY=COUNT(RECEIPTNO) FROM VIEW_SALESINVENTORYREPORT " & _
                                "WHERE PRODUCTID >= 6 GROUP BY PRODUCTID ORDER BY TOTQTY DESC", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrTopTen
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
            End While
        End With
        dr.Close()
        disconnect()

    End Sub

    Friend Sub Get_TOPCUSTOMERS()
        cmd = New SqlCommand("SELECT TOP 10 CUSTOMERID,NAME = MAX(ISNULL(FIRSTNAME,'')) + ' ' + MAX(ISNULL(LASTNAME,'')), " & _
                            "'TOTALPURCHASE' = SUM(Amount) FROM view_CustomerAccnt GROUP BY CUSTOMERID ORDER BY TOTALPURCHASE DESC", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrTopCust
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
            End While
        End With
        dr.Close()
        disconnect()

    End Sub

    Friend Sub Get_REORDERITEMS()
        cmd = New SqlCommand("SELECT PRODUCTID,PROD_DESCRIPTION,QUANTITY FROM VIEW_PRODUCTS WHERE QUANTITY = 0 OR QUANTITY = REORDERPOINT", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrReorder
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
            End While
        End With
        dr.Close()
        disconnect()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click
        reading_type = "X-Report"
        'GetReadings()
        'GetReceiptRange()
        'GetSalesReport()

        frmReport.is_printed = True
        frmReport.str_ReportDate = Format(Now, "MM-dd-yyyy")
        modReports.Generate_ReportForCurrentSession()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        frmReport.cboReportType.Text = "Sales Report per Transaction"
        frmReport.is_printed = False
        frmReport.str_ReportDate = Format(Now, "MM-dd-yyyy")
        frmReport.Generate_XReport()
        frmReport.Show()
    End Sub

End Class