Imports Spire.Barcode
Imports System.Data.SqlClient

Public Class frmBarcodeGenerator
    Shared random As New Random()
    Private barcodeData As String
    Private pathDirectory As String
    Private filename As String

    Private Sub frmBarcodeGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pathDirectory = "D:"
        lblDirectory.Text = "Directory: " & pathDirectory & "\"
        Label2.Text = ""
    End Sub

    Friend Sub GenerateBarcode()
        If txtFilename.Text.Length > 0 Then
            filename = txtFilename.Text
        Else
            filename = barcodeData
        End If
        With BarCodeControl1
            .Data = barcodeData
            .TopText = business_name
            .TopTextAligment = 1
        End With

        'Generate the barcode based on the barCodeControl1
        Dim generator As New BarCodeGenerator(BarCodeControl1)
        Dim barcode As Image = generator.GenerateImage()

        'save the barcode as an image
        barcode.Save(pathDirectory & "\" & filename & ".png")
    End Sub

    Friend Sub ScanBarcode()
        'scan the barcode
        Dim datas() As String = Spire.Barcode.BarcodeScanner.Scan(pathDirectory & "\" & filename & ".png")

        'show the scan result
        txtBarcode.Text = datas(0)
    End Sub

    Friend Sub GenerateRandomNumbers()
        barcodeData = ""
        Dim i As Integer
        For i = 0 To 6
            barcodeData = String.Concat(barcodeData, Convert.ToString(random.Next(10, 20)))
        Next
    End Sub

    Private Sub btnBarcodeGenerator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBarcodeGenerator.Click
        lblBarcodeAvailability.Text = ""
        Label2.Text = "Status: "

        'If txtFilename.Text.Length = 0 Then
        '    With lblBarcodeAvailability
        '        .Text = "Please provide product name or any barcode description."
        '        .ForeColor = Color.Red
        '    End With
        '    Exit Sub
        'End If

        ProgressBarX1.Visible = True

        If BackgroundWorker1.IsBusy Then
            BackgroundWorker1.CancelAsync()
        End If
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True

        '' call this method to start your asynchronous Task.
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim newImage As Image = Image.FromFile(pathDirectory & "\" & filename & ".png")
        e.Graphics.DrawImage(newImage, 50, 50)
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        PrintDocument1.PrinterSettings.Copies = 2
        PrintDocument1.Print()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        connect()
        Dim cmd As New SqlCommand("SELECT * FROM PRODUCTS WHERE PLU = '" & txtBarcode.Text & "' ", con)
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        If rd.Read Then
            With lblBarcodeAvailability
                .Text = "Barcode already exist!"
                .ForeColor = Color.Red
            End With
        Else
            With lblBarcodeAvailability
                .Text = "Barcode is available. No Duplicate found!"
                .ForeColor = Color.Green
            End With
        End If
        rd.Close()
        cmd.Dispose()
        disconnect()

        Label2.Text = "Status: "
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        FolderBrowserDialog1.ShowDialog()
        pathDirectory = FolderBrowserDialog1.SelectedPath
        With lblDirectory
            .Text = "Directory: " & pathDirectory
            .ForeColor = Color.Green
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = True

        '' these properties should be set to True (at design-time or runtime) before calling the RunWorkerAsync
        '' to ensure that it supports Cancellation and reporting Progress
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True

        '' call this method to start your asynchronous Task.
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '' to cancel the task, just call the BackgroundWorker1.CancelAsync method.
        Button2.Enabled = False
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        '' The asynchronous task you want to perform goes here
        '' the following is an example of how it typically goes.
        GenerateRandomNumbers()
        GenerateBarcode()

        Const Max As Integer = 10

        For i = 1 To Max
            '' do something

            '' (I put a sleep to simulate time consumed)
            Threading.Thread.Sleep(100)

            '' report progress at regular intervals
            BackgroundWorker1.ReportProgress(CInt(10 * i / Max) * 10, "Running..." & i.ToString)

            '' check at regular intervals for CancellationPending
            If BackgroundWorker1.CancellationPending Then
                BackgroundWorker1.ReportProgress(CInt(10 * i / Max), "Cancelling...")
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
        Label2.Text = e.ProgressPercentage.ToString & "% complete."
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
            ScanBarcode()
            ProgressBarX1.Value = 0
            ProgressBarX1.Visible = False

            txtFilename.Clear()
            lblBarcodeAvailability.Text = "Barcode successfully generated at " & pathDirectory
            lblBarcodeAvailability.ForeColor = Color.Green
        End If


        
    End Sub

 
End Class