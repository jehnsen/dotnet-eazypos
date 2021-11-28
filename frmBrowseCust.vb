Imports System.Data.SqlClient

Public Class frmBrowseCust

    Friend Cust_Select_Mode As String

    Private Sub frmBrowseCust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_Customers()
    End Sub

    Friend Sub Get_Customers()
        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("select customerid, name = isnull(firstname,'') + ' ' + isnull(lastname,'') from dbo.customers", con)
        Else
            cmd = New SqlCommand("select customerid, name = isnull(firstname,'') + ' ' + isnull(lastname,'') from dbo.customers where firstname like '%" & txtSearch.Text & "%' " & _
                                 "or lastname like '%" & txtSearch.Text & "%' ", con)
        End If
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrCustomers
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
            End While
        End With
        disconnect()
    End Sub

    Private Sub SelectCustomer()
        cust_id = dgrCustomers.CurrentRow.Cells(0).Value
        cust_name = dgrCustomers.CurrentRow.Cells(1).Value

        If Cust_Select_Mode = "Charge_Payment" Then
            frmTender_Charge.GetPreviousCharges()
            frmTender_Charge.txtCustomerName.Text = cust_name
            frmTender_Split.txtCustomerName.Text = cust_name
            frmTransact_Hold.txtCustomer.Text = cust_name
            frmMain.lblCustomer.Text = cust_name
        ElseIf Cust_Select_Mode = "Cash_Payment" Then
            frmMain.lblCustomer.Text = dgrCustomers.CurrentRow.Cells(1).Value
        End If

        Me.Close()
    End Sub

    Private Sub dgrCustomers_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrCustomers.CellDoubleClick
        SelectCustomer()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Get_Customers()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        SelectCustomer()
    End Sub
End Class