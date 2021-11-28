Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmMCount

    Dim x As Decimal
    Dim y As Decimal
    Dim z As Decimal
    Dim DEC_BEGQTY As Decimal
    Dim DEC_ENDQTY As Decimal

    Dim DEC_ADJ_QTY As Decimal
    Dim DEC_CURR_QTY As Decimal

    Dim isAdd As Boolean

    Dim tt As New ToolTip With {.IsBalloon = True}

    Private Sub frmMCount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub frmMCount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblItemDesc.Text = frmInventory.dgrItems.CurrentRow.Cells(1).Value
        Get_Items()
        txtAdjQty.Clear()
        txtAdjQty.Focus()

        DEC_ADJ_QTY = 0
        isAdd = True
    End Sub

    Friend Sub Get_Items()
        cmd = New SqlCommand("select isnull(quantity,0),isnull(MonthlyBQty,0),isnull(DAILYBQTY,0) from dbo.products where itemid = '" & frmInventory.dgrItems.CurrentRow.Cells(0).Value & "'", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            x = dr(0)
            y = dr(0)
            z = dr(1)

            DEC_BEGQTY = dr(0)
            DEC_ENDQTY = dr(0)

            DEC_CURR_QTY = dr(0)
        End If
        dr.Close()
        disconnect()

        txtPhysicalQty.Text = x
        txtCurrQty.Text = y
        txtMonthlyBeg.Text = z

        'If x = Int(x) Then
        '    txtPhysicalQty.Text = x.ToString("N0", CultureInfo.InvariantCulture)
        'Else
        '    txtPhysicalQty.Text = x.ToString("N2", CultureInfo.InvariantCulture)
        'End If

        'If y = Int(y) Then
        '    txtCurrQty.Text = y.ToString("N0", CultureInfo.InvariantCulture)
        'Else
        '    txtCurrQty.Text = y.ToString("N2", CultureInfo.InvariantCulture)
        'End If

        'If z = Int(z) Then
        '    txtMonthlyBeg.Text = z.ToString("N0", CultureInfo.InvariantCulture)
        'Else
        '    txtMonthlyBeg.Text = z.ToString("N2", CultureInfo.InvariantCulture)
        'End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtAdjQty.Text.Length = 0 Then
            MsgBox("Please enter adjustment quantity!", vbExclamation, "ITEM QUANITY")
            Exit Sub

        End If

        DEC_ADJ_QTY = txtAdjQty.Text

        If isAdd = True Then
            txtPhysicalQty.Text = DEC_CURR_QTY + DEC_ADJ_QTY
        Else
            txtPhysicalQty.Text = DEC_CURR_QTY - DEC_ADJ_QTY
            txtAdjQty.Text = DEC_ADJ_QTY - (DEC_ADJ_QTY * 2)
        End If


        connect()
        cmd = New SqlCommand("update products set quantity = '" & txtPhysicalQty.Text & "', ADJQTY = '" & txtAdjQty.Text & "',MonthlyBQty='" & txtMonthlyBeg.Text & "' where itemid = '" & frmInventory.dgrItems.CurrentRow.Cells(0).Value & "' ", con)
        cmd.ExecuteNonQuery()
        disconnect()

        connect()
        cmd = New SqlCommand("INSERT INTO DBO.[TRANSACTION] (PRODUCTID,DAILYADJ,RECEIPTNO,DATETIME,SESSIONID,S_IN,PAYMENTTYPE,STATUS,TRANSACTIONNO,LINE_NO, " & _
                                "CASHIERID,TERMINALNO,BRANCH,DISCOUNT,VAT,VATABLESALES,TAX,TAXABLEAMOUNT,DEPARTMENT,CATEGORY,CARDTYPE,CHARGETYPE,RETURNED, " & _
                                "CUSTOMERID,CUSTOMERNAME,SHIFT,BAGGERID,CHARGESTATUS,INVOICENO,RECEIVABLES,S_OUT,DAILYEQTY,RETQTY,PRICE,QUANTITY,AMOUNT,DAILYBQTY) values " & _
                                  "('" & frmInventory.dgrItems.CurrentRow.Cells(0).Value & "','" & txtAdjQty.Text & "','','" & Format(Now, "MM-dd-yyyy hh:mm tt") & "','" & NewSessionID & "',0,0,1,0,0,'" & cashier_id & "','" & terminal_no & "','" & branch_id & "',0,0,0,0,0,'','',0,0,0, " & _
                                  "0,'','',0,0,'',0,0,'" & txtPhysicalQty.Text & "',0,0,0,0,'" & DEC_BEGQTY & "')", con)
        cmd.ExecuteNonQuery()
        disconnect()

        MsgBox("Item quantity successfully updated!", vbInformation, "ITEM QUANITY")
        frmInventory.GetItemDetails()
        frmInventory.GetItems()
        frmInventory.dgrItems.Refresh()


        frmMain.GetDGProducts()
        frmMain.dgrProducts.Update()
        Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtPhysicalQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhysicalQty.TextChanged
       
    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        isAdd = True
        lblOperation.Text = "+"
        lblOperation.ForeColor = Color.Green

        'If isAdd = True Then
        '    txtPhysicalQty.Text = DEC_CURR_QTY + DEC_ADJ_QTY
        'Else
        '    txtPhysicalQty.Text = DEC_CURR_QTY - DEC_ADJ_QTY
        'End If

    End Sub



    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        isAdd = False
        lblOperation.Text = "-"
        lblOperation.ForeColor = Color.Red

        'If isAdd = True Then
        '    txtPhysicalQty.Text = DEC_CURR_QTY + DEC_ADJ_QTY
        'Else
        '    txtPhysicalQty.Text = DEC_CURR_QTY - DEC_ADJ_QTY
        'End If

    End Sub

    Private Sub txtAdjQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdjQty.TextChanged
        'isAdd = True
        'lblOperation.Text = "+"

        'If isAdd = True Then
        '    txtPhysicalQty.Text = DEC_CURR_QTY + DEC_ADJ_QTY
        'Else
        '    txtPhysicalQty.Text = DEC_CURR_QTY - DEC_ADJ_QTY
        'End If

    End Sub
End Class