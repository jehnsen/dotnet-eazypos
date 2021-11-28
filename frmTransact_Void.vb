Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmTransact_Void

    Dim QTY_DECIMAL As Decimal
    Dim AMNT_INVOICE As Decimal
    Dim CUSTID_INVOICE As Integer

    Private Sub frmTransact_Void_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmManagerLogin.Close()
    End Sub

    Private Sub frmTransact_Void_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Friend Sub Get_ReceiptItems()

        If rbReceipt.Checked = True Then
            cmd = New SqlCommand("SELECT T.PRODUCTID,P.PROD_DESCRIPTION,T.QUANTITY,T.PRICE,T.AMOUNT " & _
                            "FROM DBO.PRODUCTS P INNER JOIN DBO.[TRANSACTION] T ON P.ITEMID=T.PRODUCTID " & _
                            "WHERE T.RECEIPTNO = '" & txtORNumber.Text & "' AND T.STATUS = 1 AND P.PRODUCTID NOT IN (1,2,3,4,5,6)", con)
        Else
            cmd = New SqlCommand("SELECT T.PRODUCTID,P.PROD_DESCRIPTION,T.QUANTITY,T.PRICE,T.AMOUNT " & _
                          "FROM DBO.PRODUCTS P INNER JOIN DBO.[TRANSACTION] T ON P.ITEMID=T.PRODUCTID " & _
                          "WHERE T.INVOICENO = '" & txtORNumber.Text & "' AND T.STATUS = 1 AND P.PRODUCTID NOT IN (1,2,3,4,5,6)", con)
        End If
       
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrItemVoid
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightPink
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)

                QTY_DECIMAL = .Rows(.Rows.Count - 1).Cells(2).Value

                If QTY_DECIMAL = Int(QTY_DECIMAL) Then
                    .Rows(.Rows.Count - 1).Cells(2).Value = QTY_DECIMAL.ToString("N0", CultureInfo.InvariantCulture)
                Else
                    .Rows(.Rows.Count - 1).Cells(2).Value = QTY_DECIMAL.ToString("N2", CultureInfo.InvariantCulture)
                End If



            End While
        End With
        dr.Close()
        disconnect()

    End Sub

    Friend Sub Get_TotalInvoiceAmnt()
        connect()
        cmd = New SqlCommand("SELECT SUM(RECEIVABLES),MAX(CUSTOMERID) FROM DBO.[TRANSACTION] WHERE INVOICENO = '" & txtORNumber.Text & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            Try
                AMNT_INVOICE = dr(0)
                CUSTID_INVOICE = dr(1)
            Catch ex As Exception

            End Try
        End If
        disconnect()
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        If txtORNumber.Text.Length = 0 Then
            MsgBox("Please enter an OR number!", vbExclamation, "Error")
        ElseIf txtRemarks.Text.Length = 0 Then
            MsgBox("Please enter remarks!", vbExclamation, "Error")
        Else

            connect()
            For i As Integer = 0 To Me.dgrItemVoid.Rows.Count - 1
                cmd = New SqlCommand("UPDATE DBO.PRODUCTS SET QUANTITY = QUANTITY + @QTY WHERE PRODUCTID = @PRODUCTID", con)
                cmd.Parameters.AddWithValue("@QTY", dgrItemVoid.Rows(i).Cells(2).Value)
                cmd.Parameters.AddWithValue("@PRODUCTID", dgrItemVoid.Rows(i).Cells(0).Value)
                cmd.ExecuteNonQuery()
            Next
            disconnect()


            connect()
            cmd = New SqlCommand(" update dbo.[transaction] set status = '0', remarks = 'void', amount = 0 where receiptno = '" & txtORNumber.Text & "' ", con)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand(" insert into [transaction_void] (receiptno,datetime,remarks,manager) values " & _
                                 " ('" & txtORNumber.Text & "','" & system_time & "','" & txtRemarks.Text & "','" & manager & "') ", con)
            cmd.ExecuteNonQuery()
            disconnect()

            If rbInvoice.Checked = True Then

                connect()
                cmd = New SqlCommand("DELETE FROM dbo.[transaction] where INVOICENO = '" & txtORNumber.Text & "' ", con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand(" insert into [transaction_void] (RECEIPTNO,datetime,remarks,manager) values " & _
                                     " ('" & txtORNumber.Text & "','" & system_time & "','" & txtRemarks.Text & "','" & manager & "') ", con)
                cmd.ExecuteNonQuery()
                disconnect()

                'UPDATE CUSTOMER BALANCE
                Get_TotalInvoiceAmnt()
                connect()
                cmd = New SqlCommand("UPDATE DBO.CUSTOMERS SET BALANCE = BALANCE - '" & AMNT_INVOICE & "' WHERE CUSTOMERID = '" & CUSTID_INVOICE & "' ", con)
                cmd.ExecuteNonQuery()
                disconnect()
            End If

            DevComponents.DotNetBar.MessageBoxEx.Show("TRANSACTION WAS SUCCESSFULL VOID!", "VOID", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click

        Get_ReceiptItems()
        dgrItemVoid.Refresh()

        If dgrItemVoid.RowCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("NO RECEIPT FOUND!", "VOID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub rbReceipt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbReceipt.CheckedChanged
        If rbReceipt.Checked = True Then
            rbInvoice.Checked = False
        End If
    End Sub

    Private Sub rbInvoice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInvoice.CheckedChanged
        If rbInvoice.Checked = True Then
            rbReceipt.Checked = False
        End If
    End Sub
End Class