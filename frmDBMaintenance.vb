Imports System.Data.SqlClient

Public Class frmDBMaintenance
    Private thread As System.Threading.Thread
    Private Max As Integer = 100
    Private Divisor As Integer = 100
    Private pathDirectory As String
    Private filename As String

    Private Sub frmDBMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub BackupDatabase()
        connect()
        cmd = New SqlCommand("exec sp_BackupDatabase '" & pathDirectory & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If txtPath.Text = "" Then
            MessageBox.Show("Please select backup directory first!")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to BACKUP the database?", "Backup Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                progressbar.Visible = True
                BackgroundWorker1.WorkerSupportsCancellation = True
                BackgroundWorker1.WorkerReportsProgress = True

                '' call this method to start your asynchronous Task.
                BackgroundWorker1.RunWorkerAsync()

                thread = New System.Threading.Thread(AddressOf BackupDatabase)
                thread.Start()
            Catch ex As Exception

            End Try

        Else
            Exit Sub
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            '' asynchronous task 

            For i = 1 To Max
                '' do something

                '' (I put a sleep to simulate time consumed)
                Threading.Thread.Sleep(600)

                '' report progress at regular intervals
                BackgroundWorker1.ReportProgress(CInt(Divisor * i / Max), "Running..." & i.ToString)

                '' check at regular intervals for CancellationPending
                If BackgroundWorker1.CancellationPending Then
                    BackgroundWorker1.ReportProgress(CInt(Divisor * i / Max), "Cancelling...")
                    Exit For
                End If
            Next

            '' any cleanup code go here
            '' ensure that you close all open resources before exitting out of this Method.
            '' try to skip off whatever is not desperately necessary if CancellationPending is True

            '' set the e.Cancel to True to indicate to the RunWorkerCompleted that you cancelled out
            If BackgroundWorker1.CancellationPending Then
                e.Cancel = True
                BackgroundWorker1.ReportProgress(100, "Cancelled.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        '' This event is fired when you call the ReportProgress method from inside your DoWork.
        '' Any visual indicators about the progress should go here.
        lblProgress.Text = e.ProgressPercentage.ToString & "% complete."
        progressbar.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        '' This event is fired when your BackgroundWorker exits.
        '' It may have exitted Normally after completing its task, 
        '' or because of Cancellation, or due to any Error.

        'If e.Error IsNot Nothing Then

        'ElseIf e.Cancelled Then

        'Else
        progressbar.Value = 0
        progressbar.Visible = False
        lblProgress.Text = "Database backup process completed!"

        'End If

    End Sub

    Private Sub btnLocatePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocatePath.Click
        FolderBrowserDialog1.ShowDialog()
        pathDirectory = FolderBrowserDialog1.SelectedPath
        With txtPath
            .Text = "Directory: " & pathDirectory
            .ForeColor = Color.Green
        End With
    End Sub
End Class