Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Management

Public Class frmDeclareSales

    Dim DEC_TOTALSALES As Decimal
    Dim DEC_CASHSALES As Decimal
    Dim DEC_CHARGESALES As Decimal
    Dim DEC_CARDSALES As Decimal
    Dim DEC_CASHFUND As Decimal
    Dim DEC_CASHDEPOSIT As Decimal
    Dim DEC_CASHOUT As Decimal
    Dim DEC_CASHONHAND As Decimal

    Private Sub frmDeclareSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetTotalSales()
        GetCashSales()
        GetChargeSales()
        GetCardSales()
        GetCashFund()
        GetCashDeposit()
        GetCashonHand()

        txtTotalSales.Text = DEC_TOTALSALES.ToString("N2", CultureInfo.InvariantCulture)
        txtCashSales.Text = DEC_CASHSALES.ToString("N2", CultureInfo.InvariantCulture)
        txtChargeSales.Text = DEC_CHARGESALES.ToString("N2", CultureInfo.InvariantCulture)
        txtCardSales.Text = DEC_CARDSALES.ToString("N2", CultureInfo.InvariantCulture)
        txtCashFund.Text = DEC_CASHFUND.ToString("N2", CultureInfo.InvariantCulture)
        txtCashReceived.Text = DEC_CASHDEPOSIT.ToString("N2", CultureInfo.InvariantCulture)
        txtCashPullout.Text = DEC_CASHOUT.ToString("N2", CultureInfo.InvariantCulture)
        txtCashOnHand.Text = DEC_CASHONHAND.ToString("N2", CultureInfo.InvariantCulture)

    End Sub

#Region "Denominations"

    Private Sub txt1000_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1000.TextChanged
        Try
            txt1000amt.Text = Format(txt1000.Text * 1000, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt1000amt.Text = "0.00"
        End Try
    End Sub

    Private Sub txt500_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt500.TextChanged
        Try
            txt500amt.Text = Format(txt500.Text * 500, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt500amt.Text = "0.00"
        End Try

    End Sub

    Private Sub txt200_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt200.TextChanged
        Try
            txt200amt.Text = Format(txt200.Text * 200, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt200amt.Text = "0.00"
        End Try

    End Sub

    Private Sub txt100_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt100.TextChanged
        Try
            txt100amt.Text = Format(txt100.Text * 100, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt100amt.Text = "0.00"
        End Try

    End Sub

    Private Sub txt50_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt50.TextChanged
        Try
            txt50amt.Text = Format(txt50.Text * 50, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt50amt.Text = "0.00"
        End Try

    End Sub

    Private Sub txt20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt20.TextChanged
        Try
            txt20amt.Text = Format(txt20.Text * 20, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt20amt.Text = "0.00"
        End Try

    End Sub

    Private Sub txt10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt10.TextChanged
        Try
            txt10amt.Text = Format(txt10.Text * 10, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt10amt.Text = "0.00"
        End Try
    End Sub

    Private Sub txt5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt5.TextChanged
        Try
            txt5amt.Text = Format(txt5.Text * 5, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt5amt.Text = "0.00"
        End Try
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        Try
            txt1amt.Text = Format(txt1.Text * 1, "0.00")
            ProcessTotalCash()
        Catch ex As Exception
            txt1amt.Text = "0.00"
        End Try
    End Sub

#End Region

    Friend Sub GetSessionID()
        connect()
        cmd = New SqlCommand(" select sessionid from pos_session ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            NewSessionID = dr("sessionid")
        End If
        disconnect()
    End Sub

    Friend Sub ProcessTotalCash()
        Try
            txtTotalCount.Text = Format(Val(txt1000amt.Text) + Val(txt500amt.Text) + Val(txt200amt.Text) + Val(txt100amt.Text) _
                                      + Val(txt50amt.Text) + Val(txt20amt.Text) + Val(txt10amt.Text) + Val(txt5amt.Text) + Val(txt1amt.Text), "#,#00.00")
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub GetTotalSales()
        connect()
        cmd = New SqlCommand("select totalsales = ISNULL(sum(amount),0) + ISNULL(sum(receivables),0) from [transaction] where " & _
                             "sessionid = '" & NewSessionID & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            DEC_TOTALSALES = dr("totalsales")
        Else
            DEC_TOTALSALES = 0
        End If
        disconnect()
    End Sub

    Friend Sub GetCashSales()
        connect()
        cmd = New SqlCommand("select cashsales = isnull(sum(amount),0) from [transaction] where paymenttype = '1' and " & _
                             "sessionid = '" & NewSessionID & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            DEC_CASHSALES = dr("cashsales")
        Else
            DEC_CASHSALES = 0
        End If
        disconnect()
    End Sub

    Friend Sub GetChargeSales()
        connect()
        cmd = New SqlCommand(" select chargesales = isnull(sum(receivables), 0) from [transaction] where paymenttype = '2' and sessionid = '" & NewSessionID & "'", con)
        Dim dr2 As SqlDataReader = cmd.ExecuteReader
        If dr2.Read Then
            DEC_CHARGESALES = dr2("chargesales")
        Else
            DEC_CHARGESALES = 0
        End If
        disconnect()
    End Sub

    Friend Sub GetCardSales()
        connect()
        cmd = New SqlCommand("select cardsales = isnull(round(sum(amount),2),0) from [transaction] where paymenttype = '3' " & _
                             "and sessionid = '" & NewSessionID & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            DEC_CARDSALES = dr("cardsales")
        Else
            DEC_CARDSALES = 0
        End If
        disconnect()
    End Sub

    Friend Sub GetCashFund()
        connect()
        cmd = New SqlCommand(" select cashfund=isnull(cashfund,0) from pos_session ", con)
        Dim dr1 As SqlDataReader = cmd.ExecuteReader
        If dr1.Read Then
            DEC_CASHFUND = dr1("cashfund")
        Else
            DEC_CASHFUND = 0
        End If
        disconnect()
    End Sub

    Friend Sub GetCashDeposit()
        connect()
        cmd = New SqlCommand("select round(isnull(cashdeposit,0),2),round(isnull(cashpullout,0),2) from pos_session", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            DEC_CASHDEPOSIT = dr(0)
            DEC_CASHOUT = dr(1)
        Else
            DEC_CASHDEPOSIT = 0
            DEC_CASHOUT = 0
        End If
        disconnect()
    End Sub

    Friend Sub GetCashonHand()
        connect()
        cmd = New SqlCommand(" select cashonhand = (cashdeposit + cashfund + '" & CDbl(DEC_CASHSALES) & "') - cashpullout from pos_session ", con)
        Dim drCoh As SqlDataReader = cmd.ExecuteReader
        If drCoh.Read Then
            DEC_CASHONHAND = drCoh("cashonhand")
        Else
            DEC_CASHONHAND = 0
        End If
        disconnect()
    End Sub

    Private Sub btnEndShift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndShift.Click
        If txtTotalCount.Text.Length = 0 And txtCashOnHand.Text.Length = 0 Then
            txtTotalCount.Text = 0
            txtCashOnHand.Text = 0
        End If
        If txtTotalCount.Text <> txtCashOnHand.Text Then
            MessageBox.Show("Cash on hand & denomination total should match!", "End session not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to end this session?", "Close Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Try
                DENO_1000 = Val(txt1000.Text)
                DENO_500 = Val(txt500.Text)
                DENO_200 = Val(txt200.Text)
                DENO_100 = Val(txt100.Text)
                DENO_50 = Val(txt50.Text)
                DENO_20 = Val(txt20.Text)
                DENO_10 = Val(txt10.Text)
                DENO_5 = Val(txt5.Text)
                DENO_1 = Val(txt1.Text)
            Catch ex As Exception
                MessageBox.Show("Check if denomination count is empty or null.", "Invalid input", MessageBoxButtons.RetryCancel)
                Exit Sub
            End Try

            reading_type = "Z-Report"
            GetReadings()
            GetReceiptRange()
            GetSalesReport()

            connect()
            cmd = New SqlCommand("update pos_session set cashierid = '',datetime = '', managerid = '',timestarted = '',timeended = '', " & _
                               "cashfund = '',cashdeposit = '',cashpullout = '', cashsales = '',cashonhand = '', cashreceivables = 0, status = '0' ", con)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand(" insert into pos_sessionhistory (sessionid,terminalno,cashierid,managerid,datetime,cashfund,cashdeposit,cashpullout,cashsales, " & _
                                 " chargesales,cardsales,totalsales,timestarted,timeended) values ('" & NewSessionID & "','" & terminal_no & "','" & cashier_id & "','" & manager_id & "', " & _
                                 " '" & system_time & "','" & txtCashFund.Text & "','" & txtCashReceived.Text & "','" & txtCashPullout.Text & "','" & txtCashSales.Text & "', " & _
                                 " '" & txtChargeSales.Text & "','" & txtCardSales.Text & "','" & txtTotalSales.Text & "','" & session_timestarted & "','" & system_time & "') ", con)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand("delete from transaction_temp", con)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand("UPDATE DBO.PRODUCTS SET DAILYBQTY = QUANTITY", con)
            cmd.ExecuteNonQuery()
            disconnect()

            If is_print_report_after_endshift = "YES" Then
                frmReport.is_export = False
                frmReport.is_printed = True
                frmReport.str_ReportDate = Format(Now, "MM-dd-yyyy")
                ' generate z-report, 
                ' end current session
                frmReport.Generate_XReport()
            End If

            frmMain.Transaction()
            frmMain.dgrTransaction.Refresh()
            frmMain.ResetAllDepartments()
            frmMain.ResetAll_Button()
            NewSessionID = NewSessionID + 1

            Me.Opacity = 0
            Me.Close()
            frmMain.POS_Start()

        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmManagerLogin.Close()
        Me.Close()
    End Sub
End Class