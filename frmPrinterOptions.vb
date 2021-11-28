Imports System.Data.SqlClient

Public Class frmPrinterOptions

    Dim cboPrinter_ID As New ComboBox

    Private Sub frmPrinterOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetPrinters()
        GetCurrPrinter()
    End Sub

    Friend Sub GetPrinters()
        connect()
        cmd = New SqlCommand("select printer_name from printerlist", con)
        connect()
        'Initialize the DataAdapter object and set the SelectCommand property
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        'Initialize the DataTable object
        Dim dt = New DataTable

        'Populate the DataTable
        da.Fill(dt)

        'Bind the DataTable to the ComboBox
        cboPrinters.DataSource = dt
        cboPrinters.DisplayMember = "printer_name"
        cboPrinters.ValueMember = "printer_name"

        'Bind the DataTable to the ComboBox
        cboPrinter_ID.DataSource = dt
        cboPrinter_ID.DisplayMember = "printer_no"
        cboPrinter_ID.ValueMember = "printer_no"

        'Clean up
        'da.Dispose()
        da = Nothing

        disconnect()

    End Sub

    Friend Sub GetCurrPrinter()
        connect()
        cmd = New SqlCommand("select printer from terminal", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            cboPrinters.Text = dr("printer")
        End If
        disconnect()
    End Sub

    Private Sub btnSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        connect()
        cmd = New SqlCommand(" update terminal set printer = '" & cboPrinters.Text & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        pos_printer = cboPrinters.Text
        MsgBox("Printer successfuly updated!", vbInformation, "")
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

   
End Class