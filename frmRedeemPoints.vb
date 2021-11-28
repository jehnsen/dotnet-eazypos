Imports System.Data.SqlClient

Public Class frmRedeemPoints

    Private Sub frmGiftCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCustomers()
        GetRedeemableItems()
    End Sub


    Friend Sub GetCustomers()
        cmd = New SqlCommand("SELECT CUSTOMERID,FIRSTNAME = FIRSTNAME + ' ' + LASTNAME FROM CUSTOMERS", con)

        connect()

        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        'Initialize the DataTable object
        Dim dt = New DataTable

        'Populate the DataTable
        da.Fill(dt)

        'Bind the DataTable to the ComboBox
        cboCustomer.DataSource = dt
        cboCustomer.DisplayMember = "FIRSTNAME"
        cboCustomer.ValueMember = "FIRSTNAME"

        'cboChargeTypeID.DataSource = dt
        'cboChargeTypeID.DisplayMember = "recordid"
        'cboChargeTypeID.ValueMember = "recordid"

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Friend Sub GetRedeemableItems()
        cmd = New SqlCommand("SELECT ID,REDEEMABLEITEM,POINTSNEEDED FROM REDEEMABLEITEMS", con)

        connect()

        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        'Initialize the DataTable object
        Dim dt = New DataTable

        'Populate the DataTable
        da.Fill(dt)

        'Bind the DataTable to the ComboBox
        cboItems.DataSource = dt
        cboItems.DisplayMember = "REDEEMABLEITEM"
        cboItems.ValueMember = "REDEEMABLEITEM"

        'cboChargeTypeID.DataSource = dt
        'cboChargeTypeID.DisplayMember = "recordid"
        'cboChargeTypeID.ValueMember = "recordid"


        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class