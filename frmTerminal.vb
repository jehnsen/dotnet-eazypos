Imports System.Data.SqlClient

Public Class frmTerminal

    Dim LineReceipt As Integer
    Dim TextReceipt As String

    Dim is_new As Boolean
    Dim New_TerminalID As String
    Dim terminal_connectionstring As String

    Private Sub frmTerminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetTeminal()

        txtPDFFilepath.Text = INV_FILEPATH
        txtPrinterName.Text = pos_printer
        txtPrintNoCopy.Text = printcopy
        LoadSettings()
        GetReceiptSetup()
    End Sub

    Friend Sub GetTeminal()
        cmd = New SqlCommand(" select terminal_no,terminal_name,ip_address,connectionstring,authentication,printer,poledisplay from terminal  ", con)
        connect()
        dr = cmd.ExecuteReader()
        lvTerminal.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("terminal_no").ToString())
            Dim b = (dr.Item("terminal_name").ToString())
            Dim c = (dr.Item("ip_address").ToString())
            Dim d = (dr.Item("connectionstring").ToString())
            Dim e = (dr.Item("authentication").ToString())
            Dim f = (dr.Item("printer").ToString())
            Dim g = (dr.Item("poledisplay").ToString())
            Dim lv As ListViewItem = lvTerminal.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(e)
            lv.SubItems.Add(f)
            lv.SubItems.Add(g)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Friend Sub GetTerminalDetails()
        cmd = New SqlCommand(" select terminal_name,ip_address,printer,poledisplay,port_connection,connectionstring,authentication,server, " & _
                             " databasename,username,password,serialno,machineno,tinno,birpermit,PosManagerPrinter from terminal " & _
                             " where terminal_no = '" & lvTerminal.SelectedItems(0).Text & "'", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtTerminal.Text = dr("terminal_name").ToString
            txtIP.Text = dr("ip_address").ToString
            txtPrinterName.Text = dr("printer").ToString
            txtPosManagerPrinter.Text = dr("PosManagerPrinter").ToString

            txtPoleDisplay.Text = dr("poledisplay").ToString
            txtPort.Text = dr("port_connection").ToString

            txtServer.Text = dr("server").ToString
            txtDatabase.Text = dr("databasename").ToString
            txtUsername.Text = dr("username").ToString
            txtPassword.Text = dr("password").ToString
            cboAuthentication.Text = dr("authentication").ToString

            txtSerial.Text = dr("serialno").ToString
            txtMachineNo.Text = dr("machineno").ToString
            txtTIN.Text = dr("tinno").ToString
            txtBIRPermit.Text = dr("birpermit").ToString
        End If
        disconnect()
    End Sub

    Friend Sub GetLastTerminalNO()
        connect()
        cmd = New SqlCommand(" select top 1 terminal_no = terminal_no + 1 from terminal order by terminal_no desc ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            New_TerminalID = dr("terminal_no").ToString
        End If
        disconnect()
    End Sub

    Friend Sub LoadSettings()
        If isalways_print_receipt = "YES" Then
            chkPrintReceipt.Checked = True
        Else
            chkPrintReceipt.Checked = False
        End If

        If is_print_report_after_endshift = "YES" Then
            chkPrintReportEveryEnd.Checked = True
        Else
            chkPrintReportEveryEnd.Checked = False
        End If

        If is_print_coupon = "YES" Then
            chkPrintCoupon.Checked = True
        Else
            chkPrintCoupon.Checked = False
        End If

        If is_print_points = "YES" Then
            chkPrintPoints.Checked = True
        Else
            chkPrintPoints.Checked = False
        End If

        If is_export_receipt = "YES" Then
            chkExportToPDF.Checked = True
        Else
            chkExportToPDF.Checked = False
        End If

        If is_PRINT_INV_REPORT = "YES" Then
            chkPrintReportToPrinter.Checked = True
        Else
            chkPrintReportToPrinter.Checked = False
        End If

        If def_SR_Type = "TR" Then
            rbSRTransaction.Checked = True
        Else
            rbSRTransaction.Checked = False
        End If

        If def_SR_Type = "IT" Then
            rbSRItem.Checked = True
        Else
            rbSRItem.Checked = False
        End If

        If def_SR_Type = "RE" Then
            rbSRReceipt.Checked = True
        Else
            rbSRReceipt.Checked = False
        End If

        If def_SR_Type = "RP" Then
            rbSRRollPaper.Checked = True
        Else
            rbSRRollPaper.Checked = False
        End If

    End Sub

    Friend Sub GetReceiptSetup()
        cmd = New SqlCommand(" select line,text from receiptsetup ", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read
            LineReceipt = dr("line").ToString
            TextReceipt = dr("text").ToString

            Select Case LineReceipt
                Case 26
                    txtLine1.Text = TextReceipt
                Case 27
                    txtLine2.Text = TextReceipt
                Case 28
                    txtLine3.Text = TextReceipt
                Case 29
                    txtLine4.Text = TextReceipt
            End Select
        Loop

    End Sub

    Friend Sub PRINT_RECEIPT()
        If chkPrintReceipt.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set isalwaysprintreceipt = 'YES'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            isalways_print_receipt = "YES"
        Else
            connect()
            cmd = New SqlCommand("update systemsettings set isalwaysprintreceipt = 'NO'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            isalways_print_receipt = "NO"
        End If
    End Sub

    Friend Sub PRINT_COUPON()
        If chkPrintCoupon.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set isprintcoupon = 'YES'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_print_coupon = "YES"
        Else
            connect()
            cmd = New SqlCommand("update systemsettings set isprintcoupon = 'NO'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_print_coupon = "NO"
        End If
    End Sub

    Friend Sub PRINT_POINTS()
        If chkPrintPoints.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set isprintpoints = 'YES'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_print_points = "YES"
        Else
            connect()
            cmd = New SqlCommand("update systemsettings set isprintpoints = 'NO'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_print_points = "NO"
        End If
    End Sub

    Friend Sub UPDATE_PRINTER()
        connect()
        cmd = New SqlCommand(" update terminal set printer = '" & txtPrinterName.Text & "', PosManagerPrinter = '" & txtPosManagerPrinter.Text & "'  ", con)
        cmd.ExecuteNonQuery()
        disconnect()
        pos_printer = txtPrinterName.Text
    End Sub

    Friend Sub EXPORT_TO_PDF()
        If chkExportToPDF.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set isexportreceipt = 'YES'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_export_receipt = "YES"
        Else
            connect()
            cmd = New SqlCommand("update systemsettings set isexportreceipt = 'NO'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_export_receipt = "NO"
        End If
    End Sub

    Friend Sub PRINT_REPORT_TO_PRINTER()
        If chkPrintReportToPrinter.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set isprintreport = 'YES'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_PRINT_INV_REPORT = "YES"
        Else
            connect()
            cmd = New SqlCommand("update systemsettings set isprintreport = 'NO'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_PRINT_INV_REPORT = "NO"
        End If
    End Sub

    Friend Sub PRINT_REPORT_AFTER_END_SHIFT()
        If chkPrintReportEveryEnd.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set isprintreporteveryend = 'YES'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_print_report_after_endshift = "YES"
        Else
            connect()
            cmd = New SqlCommand("update systemsettings set isprintreporteveryend = 'NO'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            is_print_report_after_endshift = "NO"
        End If
    End Sub

    Friend Sub CHANGE_DEF_SALESREPORT_TYPE()

        If rbSRTransaction.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set def_sr_type = 'TR'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            def_SR_Type = "TR"
        ElseIf rbSRItem.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set def_sr_type = 'IT'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            def_SR_Type = "IT"
        ElseIf rbSRReceipt.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set def_sr_type = 'RE'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            def_SR_Type = "RE"
        ElseIf rbSRRollPaper.Checked = True Then
            connect()
            cmd = New SqlCommand("update systemsettings set def_sr_type = 'RP'", con)
            cmd.ExecuteNonQuery()
            disconnect()
            def_SR_Type = "RP"
        End If

    End Sub

    Friend Sub UpdateReceiptContent()
        connect()
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand(" update receiptsetup set text = '" & txtLine1.Text & "' where line = '26' ", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand(" update receiptsetup set text = '" & txtLine2.Text & "' where line = '27' ", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand(" update receiptsetup set text = '" & txtLine3.Text & "' where line = '28' ", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand(" update receiptsetup set text = '" & txtLine4.Text & "' where line = '29' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

    End Sub

    Private Sub lvTerminal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTerminal.Click
        GetTerminalDetails()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        is_new = True
        PanelDetails.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        is_new = False
        PanelDetails.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If cboAuthentication.Text = "Windows Authetication" Then
            terminal_connectionstring = "UID=" + txtServer.Text + ";Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=" + txtDatabase.Text + ";Data Source=" + txtServer.Text + "; MultipleActiveResultSets=true"
        Else
            terminal_connectionstring = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID=" + txtUsername.Text + "; Password=" + txtPassword.Text + "; MultipleActiveResultSets=true"
        End If

        GetLastTerminalNO()
        If is_new = True Then
            connect()
            cmd = New SqlCommand(" insert into terminal (terminal_no,terminal_name,ip_address,port_connection,poledisplay,connectionstring,server,databasename,username,password,authentication,serialno,machineno,tinno,birpermit) values " & _
                                 " ('" & New_TerminalID & "','" & txtTerminal.Text & "','" & txtIP.Text & "','" & txtPort.Text & "','" & txtPoleDisplay.Text & "', " & _
                                 " '" & terminal_connectionstring & "','" & txtServer.Text & "','" & txtDatabase.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "', " & _
                                 "'" & cboAuthentication.Text & "','" & txtSerial.Text & "','" & txtMachineNo.Text & "','" & txtTIN.Text & "','" & txtBIRPermit.Text & "',) ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("New terminal added!", vbInformation, "")
        Else
            connect()
            cmd = New SqlCommand(" update terminal set terminal_name = '" & txtTerminal.Text & "',ip_address = '" & txtIP.Text & "',port_connection = '" & txtPort.Text & "', " & _
                                 " poledisplay= '" & txtPoleDisplay.Text & "',connectionstring = '" & terminal_connectionstring & "',server = '" & txtServer.Text & "', " & _
                                 " databasename = '" & txtDatabase.Text & "',username = '" & txtUsername.Text & "',password = '" & txtPassword.Text & "',authentication = '" & cboAuthentication.Text & "', " & _
                                 " serialno = '" & txtSerial.Text & "',machineno= '" & txtMachineNo.Text & "',tinno = '" & txtTIN.Text & "',birpermit = '" & txtBIRPermit.Text & "' " & _
                                 " where terminal_no = '" & lvTerminal.SelectedItems(0).Text & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()
            MsgBox("Terminal updated!", vbInformation, "")
        End If

        GetTeminal()
        lvTerminal.Refresh()
        PanelDetails.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub cboAuthentication_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAuthentication.SelectedIndexChanged
        If cboAuthentication.Text = "Windows Authentication" Then
            txtUsername.Enabled = False
            txtPassword.Enabled = False
        Else
            txtUsername.Enabled = True
            txtPassword.Enabled = True
        End If
    End Sub

    Private Sub btnBrowseFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFolder.Click
        FolderBrowserDialog1.ShowDialog()
        INV_FILEPATH = FolderBrowserDialog1.SelectedPath
        txtPDFFilepath.Text = INV_FILEPATH

        connect()
        cmd = New SqlCommand("UPDATE dbo.SYSTEMSETTINGS SET PDFEXPORT_FPATH = '" & INV_FILEPATH & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        PRINT_COUPON()
        PRINT_POINTS()
        PRINT_RECEIPT()
        UPDATE_PRINTER()
        EXPORT_TO_PDF()
        PRINT_REPORT_TO_PRINTER()
        CHANGE_DEF_SALESREPORT_TYPE()
        PRINT_REPORT_AFTER_END_SHIFT()
        UpdateReceiptContent()

        UpdateReceiptContent() ' RECEIPT FOOTER
        txtLine1.Clear()
        txtLine2.Clear()
        txtLine3.Clear()
        txtLine4.Clear()
        GetReceiptSetup()

        DevComponents.DotNetBar.MessageBoxEx.Show("SETTINGS WAS UPDATED!", "SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()
    End Sub

End Class