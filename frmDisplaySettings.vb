Imports System.Data.SqlClient

Public Class frmDisplaySettings

    Private Sub frmDisplaySettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_CurrDisplay()
    End Sub

    Friend Sub Get_CurrDisplay()
        connect()
        cmd = New SqlCommand("select * from Branch ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtBussName.Text = dr("BusinessName")
            txtBussAddress.Text = dr("Address")
        End If
        disconnect()
    End Sub

    Private Sub btnSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSettings.Click
        connect()
        cmd = New SqlCommand("update branch set businessname = '" & convertQuotes(txtBussName.Text) & "' , address = '" & convertQuotes(txtBussAddress.Text) & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        'REFRESH DISPLAY
        frmMain.GetBranch()
        Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class