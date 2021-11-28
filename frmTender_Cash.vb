Imports DevComponents.DotNetBar.Keyboard
Imports DevComponents.DotNetBar.Metro
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization

Public Class frmTender_Cash

    Dim TenderAmount As Double
    Dim TotalChange As Double
    Dim TotalAmount As Double

    Private Sub frmTender_Cash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Decimal Then
            txtTender.Clear()
            TenderAmount = 0
        ElseIf e.KeyCode = Keys.Delete Then
            txtTender.Clear()
            TenderAmount = 0
        ElseIf e.KeyCode = Keys.Enter Then
            btnAccept.PerformClick()
        ElseIf e.KeyCode = Keys.Add Then
            btnAccept.PerformClick()
        End If
    End Sub

    Private Sub frmTender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtChange.ForeColor = Color.FromArgb(255, 38, 38)
        lblAmount.ForeColor = Color.FromArgb(80, 203, 147)

        btnClear.PerformClick()
        txtChange.Text = "0.00"
        TenderAmount = "0"

        GetPaymentDetails()
        trans_points = frmMain.lblTotal.Text / points_percentage

        txtTender.Focus()
    End Sub

    Friend Sub GetPaymentDetails()
        TotalAmount = CDbl(frmMain.lblTotal.Text)
        lblAmount.Text = TotalAmount.ToString("N", CultureInfo.InvariantCulture) 'Format(trans_totaldue, "#,#00.00")
    End Sub

    Private Sub lblTenderType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub txtTender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTender.TextChanged
        'compute change
        TotalChange = CDbl(Val(txtTender.Text)) - TotalAmount
        txtChange.Text = TotalChange.ToString("N", CultureInfo.InvariantCulture)
    End Sub

#Region "Buttons"

    Private Sub btn1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1000.Click
        TenderAmount = TenderAmount + 1000
        txtTender.Text = TenderAmount
    End Sub

    Private Sub btn500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn500.Click
        TenderAmount = TenderAmount + 500
        txtTender.Text = TenderAmount
    End Sub

    Private Sub btn200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn200.Click
        TenderAmount = TenderAmount + 200
        txtTender.Text = TenderAmount
    End Sub

    Private Sub btn100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn100.Click
        TenderAmount = TenderAmount + 100
        txtTender.Text = TenderAmount
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtTender.Text = txtTender.Text & 1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtTender.Text = txtTender.Text & 2
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click

        txtTender.Text = txtTender.Text & 3
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtTender.Text = txtTender.Text & 4
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtTender.Text = txtTender.Text & 5
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtTender.Text = txtTender.Text & 6
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click

        txtTender.Text = txtTender.Text & 7
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click

        txtTender.Text = txtTender.Text & 8
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click

        txtTender.Text = txtTender.Text & 9
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If txtTender.Text.Length > 0 Then
            txtTender.Text = txtTender.Text & 0
        End If

    End Sub

#End Region

    Friend Sub ValidateTenderField()
        If txtTender.Text.Length = 0 Then
            txtTender.Text = 0
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtTender.Clear()
        TenderAmount = 0
        TotalChange = 0
        txtChange.Text = TotalChange.ToString("N", CultureInfo.InvariantCulture)
    End Sub

    Private Sub btnExact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExact.Click
        TenderAmount = frmMain.lblTotal.Text
        txtChange.Text = "0.00"
        txtTender.Text = TenderAmount
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        'generate receipt no
        GetLast_TransactionNo()
        GenerateReceiptNo()

        payment_mode = "1"

        If Val(lblAmount.Text) <= Val(txtTender.Text) Then
            SaveTransaction()
            trans_payment = txtTender.Text
            trans_change = txtChange.Text
            ReceiptPaymentDetails()


            If is_print_coupon = "NO" Then
                GenerateReceipt()
            Else
                GenerateCoupon()
            End If

            txtORNo.Clear()
            Me.Opacity = 0
            frmTender_Charge.Opacity = 0
            frmTender_Card.Opacity = 0
            frmTender_Split.Opacity = 0

            frmPayment_Accepted.ShowDialog()
        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("Invalid Payment Amount!", "TENDER DENIED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()
    End Sub

End Class