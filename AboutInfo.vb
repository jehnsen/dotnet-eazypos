Public Class AboutInfo

    Private Sub AboutInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Close()
    End Sub

    Private Sub AboutInfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class