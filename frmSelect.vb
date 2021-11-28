
Public Class frmSelect

    Private Sub frmSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFromDate.Format = DateTimePickerFormat.Custom
        dtpFromDate.CustomFormat = "MM-dd-yyyy"
        dtpFromDate.Value.ToString("MM-dd-yyyy")
        dtpToDate.Format = DateTimePickerFormat.Custom
        dtpToDate.CustomFormat = "MM-dd-yyyy"
        dtpToDate.Value.ToString("MM-dd-yyyy")
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        frmReport.FromDate = dtpFromDate.Value.ToString("MM-dd-yyyy")
        frmReport.ToDate = dtpToDate.Value.ToString("MM-dd-yyyy")

        If frmReport.cboReportType.Text = "Monthly Inventory Report" Then
            frmReport.Generate_MonthlySalesReport()

        ElseIf frmReport.cboReportType.Text = "Patronage Report" Then
            calculateCashback(dtpFromDate.Value.ToString("MM-dd-yyyy"), dtpToDate.Value.ToString("MM-dd-yyyy"))
            frmReport.Generate_PatronageReport()

        ElseIf frmReport.cboReportType.Text = "Adjustment Report" Then
            frmReport.Generate_AdjustmentReport()
        End If

        Close()
    End Sub

End Class