Imports System.Data.SqlClient

Public Class frmReprint

    Public REPRINT_RECEIPTNO As String
    Public reprint_SubTotal As String
    Public reprint_TotalAmnt As String
    Public reprint_transPayment As String
    Public reprint_transChange As String
    Public reprint_VatableSales As String
    Public reprint_12PercentVat As String
    Public reprint_TotalDiscounts As String
    Public reprint_TotalPoint As String

    Private Sub frmReprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SearchTransaction()
    End Sub

    Friend Sub SearchTransaction()
        cmd = New SqlCommand("SELECT MAX(TRANSACTIONNO) AS TRANS,RECEIPTNO,CASE MAX(AMOUNT) WHEN 0 THEN SUM(RECEIVABLES) ELSE SUM(AMOUNT) END AS TOTAL_AMOUNT,CASE STATUS WHEN 1 THEN 'TENDERED' ELSE 'NOT TENDERED' END AS [STATUS_DESC]  FROM [TRANSACTION] " & _
                             "WHERE SESSIONID = '" & NewSessionID & "' AND RECEIPTNO <> '0' GROUP BY RECEIPTNO,STATUS", con)
        connect()
        dr = cmd.ExecuteReader()
        lvItems.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("TRANS").ToString())
            Dim b = (dr.Item("RECEIPTNO").ToString())
            Dim c = (dr.Item("TOTAL_AMOUNT").ToString())
            Dim d = (dr.Item("STATUS_DESC").ToString())
            Dim lv As ListViewItem = lvItems.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub


    Friend Sub Get_ReprintDetails()

        cmd = New SqlCommand("SELECT ROUND(SUM(AMOUNT), 2) AS 'TOTAL_AMOUNT', ROUND(SUM(DISCOUNT), 2) AS 'TOTAL_DISCOUNT', " & _
                             "ROUND(SUM(VATABLESALES), 2) AS 'TOTAL_VATABLE', ROUND(SUM(VAT), 2) AS 'TOTAL_VAT' " & _
                             "FROM VIEW_TRANSACTION WHERE RECEIPTNO = '" & lvItems.SelectedItems(0).SubItems(1).Text & "' ", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            reprint_SubTotal = Format(dr("TOTAL_AMOUNT"), "##,##0.00")
            reprint_TotalAmnt = Format(dr("TOTAL_AMOUNT"), "##,##0.00")
            reprint_transPayment = Format(dr("TOTAL_AMOUNT"), "##,##0.00")
            reprint_transChange = "0.00"
            reprint_VatableSales = Format(dr("TOTAL_VATABLE"), "##,##0.00")
            reprint_12PercentVat = Format(dr("TOTAL_VAT"), "##,##0.00")
            reprint_TotalDiscounts = Format(dr("TOTAL_DISCOUNT"), "##,##0.00")
            'reprint_TotalPoint = dr("").ToString
        End If
        disconnect()

    End Sub


    Private Sub btnReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprint.Click
        Get_ReprintDetails()
        GenerateReprintReceipt()
        'GenerateReprintCoupon()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()
    End Sub

    Private Sub lvItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvItems.Click
        REPRINT_RECEIPTNO = lvItems.SelectedItems(0).SubItems(1).Text
    End Sub
End Class