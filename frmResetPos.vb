Imports System.Data.SqlClient

Public Class frmResetPos
    Private Max As Integer = 100
    Private Divisor As Integer = 100
    Private statusText As String = "Connecting to database..."

    Private Sub txtResetCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResetCode.TextChanged
        If txtResetCode.Text = "oGH9Sn9tYTbk6en5MowQzEUl9KyNHRYbWWoIAWjUurzZyPB0me" Then
            btnReset.Enabled = True
            btnReset.BackColor = Color.Red
        Else
            btnReset.Enabled = False
            btnReset.BackColor = Color.Gray
        End If
    End Sub

    Friend Sub PerformDatabaseReset()
        connect()
        cmd = New SqlCommand("EXEC sp_ResetPosData", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    Private Sub btnReset_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.GotFocus
        btnReset.BackColor = Color.LightCoral
        btnReset.ForeColor = Color.Red
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If MessageBox.Show("Are you sure you want to reset the POS database?", "Reset Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            ProgressBarX1.Value = 0
            ProgressBarX1.Visible = True

            If BackgroundWorker1.IsBusy Then
                BackgroundWorker1.CancelAsync()
            End If
            BackgroundWorker1.WorkerSupportsCancellation = True
            BackgroundWorker1.WorkerReportsProgress = True

            '' call this method to start your asynchronous Task.
            BackgroundWorker1.RunWorkerAsync()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmResetPos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnReset.Enabled = False
        btnReset.BackColor = Color.Gray
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        '' The asynchronous task you want to perform goes here
        '' the following is an example of how it typically goes.
        'GenerateRandomNumbers()
        PerformDatabaseReset()

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
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        '' This event is fired when you call the ReportProgress method from inside your DoWork.
        '' Any visual indicators about the progress should go here.
        'Label1.Text = CType(e.UserState, String)

        If e.ProgressPercentage = 10 Then
            statusText = "Scanning database tables..."
        ElseIf e.ProgressPercentage = 20 Then
            statusText = "Database cleaning started..."
        ElseIf e.ProgressPercentage = 30 Then
            statusText = "Deleting all transactions..."
        ElseIf e.ProgressPercentage = 70 Then
            statusText = "Deleting customer & supplier records..."
        ElseIf e.ProgressPercentage = 90 Then
            statusText = "Deleting inventory records..."
        ElseIf e.ProgressPercentage = 100 Then
            statusText = "POS data successfully reset."
        End If

        lblStatus.Text = e.ProgressPercentage.ToString & "% " & statusText
        ProgressBarX1.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        '' This event is fired when your BackgroundWorker exits.
        '' It may have exitted Normally after completing its task, 
        '' or because of Cancellation, or due to any Error.

        If e.Error IsNot Nothing Then
            '' if BackgroundWorker terminated due to error
            'MessageBox.Show(e.Error.Message)
            'Label1.Text = "Error occurred!"

        ElseIf e.Cancelled Then
            '' otherwise if it was cancelled
            'MessageBox.Show("Task cancelled!")
            'Label1.Text = "Task Cancelled!"

        Else

            ProgressBarX1.Value = 0
            ProgressBarX1.Visible = False
            txtResetCode.Clear()
        End If

    End Sub

End Class