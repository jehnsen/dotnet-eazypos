Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmItemReturn

    Private Sub frmItemReturn_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmManagerLogin.Close()
    End Sub

    Private Sub frmItemReturn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchReceipt.PerformClick()
        End If
    End Sub

    Private Sub frmItemReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SearchTransaction()
    End Sub

    Friend Sub SearchTransaction()
        cmd = New SqlCommand(" SELECT PRODUCTID,PROD_DESCRIPTION,QUANTITY,PRICE,AMOUNT FROM VIEW_TRANSACTION WHERE RECEIPTNO = '" & txtORNumber.Text & "' AND RETURNED = '0' AND PRODUCTID NOT IN (1,2,3,4,5,6)", con)
        connect()
        dr = cmd.ExecuteReader()
        lvItems.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("PRODUCTID").ToString())
            Dim b = (dr.Item("PROD_DESCRIPTION").ToString())
            Dim c As Decimal = (dr.Item("QUANTITY").ToString())
            Dim d As Decimal = (dr.Item("PRICE").ToString())
            Dim e As Decimal = (dr.Item("AMOUNT").ToString())
            Dim lv As ListViewItem = lvItems.Items.Add(a)
            lv.SubItems.Add(b)
            If c = Int(c) Then
                lv.SubItems.Add(c.ToString("N0", CultureInfo.InvariantCulture))
            Else
                lv.SubItems.Add(c.ToString("N2", CultureInfo.InvariantCulture))
            End If
            lv.SubItems.Add(d.ToString("N2", CultureInfo.InvariantCulture))
            lv.SubItems.Add(e.ToString("N2", CultureInfo.InvariantCulture))
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub



    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lvItems.Items.Count = 0 Then
            MsgBox("No item to return or exchange." & vbCrLf & " Please enter OR Number first before proceeding!", vbExclamation, "Access Denied")
        Else
            frmViewReturned.TabControl1.Dock = DockStyle.None
            frmViewReturned.ShowDialog()
        End If
    End Sub

    Private Sub btnViewReturned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReturned.Click
        frmViewReturned.TabControl1.Dock = DockStyle.Fill
        frmViewReturned.ShowDialog()
    End Sub

    Private Sub btnRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefund.Click
        If lvItems.Items.Count = 0 Then
            MsgBox("Please Enter Receipt Number first!", vbInformation, "Receipt Number")
            Exit Sub
        End If

        frmRefQty.ShowDialog()
        frmRefQty.txtRefQTY.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearchReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchReceipt.Click
        If txtORNumber.Text.Length = 0 Then
            MsgBox("Please enter receipt number!", vbExclamation, "")
            Exit Sub
        End If

        SearchTransaction()
        lvItems.Refresh()

        If lvItems.Items.Count = 0 Then
            MsgBox("No receipt found!", vbExclamation, "")
            Exit Sub
        End If
    End Sub
End Class