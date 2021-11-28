Imports System.Data.SqlClient

Public Class frmCategory

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCategories()
    End Sub

    Friend Sub GetCategories()
        cmd = New SqlCommand("SELECT CAT_ID, CAT_NAME FROM CATEGORY ORDER BY CAT_ID DESC", con)

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrCategory
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
            End While
        End With
        disconnect()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        connect()
        cmd = New SqlCommand("INSERT INTO CATEGORY (DEPT_NAME, CAT_CODE, CAT_NAME, STATUS) VALUES ('1', '" & txtCategoryCode.Text & "', '" & txtCategoryName.Text & "', 1)", con)
        cmd.ExecuteNonQuery()
        disconnect()
        txtCategoryCode.Clear()
        txtCategoryName.Clear()
        DevComponents.DotNetBar.MessageBoxEx.Show("Category Successfully saved!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
        GetCategories()
        frmItemMaintenance.GetCategory()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

   
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        connect()
        cmd = New SqlCommand("DELETE FROM CATEGORY WHERE CAT_ID = '" & dgrCategory.CurrentRow.Cells(0).Value & "'", con)
        cmd.ExecuteNonQuery()
        disconnect()
        DevComponents.DotNetBar.MessageBoxEx.Show("Category deleted!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
        GetCategories()
    End Sub
End Class