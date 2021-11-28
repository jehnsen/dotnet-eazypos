Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmInventory

    Dim selRow As Integer
    Dim selCol As Integer

    Dim CURR_QTY As Decimal
    Dim BEG_QTY As Decimal
    Dim ADJ_QTY As Decimal

    Private Sub frmInventory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmLogin.userType = 3 Then 'cashier
            frmMain.styleMain.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
            frmMain.GetInventoryStatus()
            frmMain.Show()

        End If
    End Sub

    Private Sub frmInventory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F And e.Modifiers = Keys.Control Then
            txtSearch.Focus()
        End If
    End Sub

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetItems()
        Get_InventoryItems()
        ' set access level
        If frmMain.userType = 3 Then 'cashier
            SetUserAcess()
        End If
        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        dgrItems.BackgroundColor = Color.White
        dgrStockInOut.BackgroundColor = Color.White

    End Sub

    Friend Sub SetUserAcess()
        Dim buttonId As Integer
        connect()
        cmd = New SqlCommand("SELECT Id FROM MODULES Where Cashier = 0 AND ModuleId = 2", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read

            buttonId = dr("Id")

            Select Case buttonId
                Case 5
                    btnAdjustment.Enabled = False
                Case 6
                    btnEnterStockIN.Enabled = False
                Case 7
                    btnEnterStockOut.Enabled = False
                Case 8
                    btnInvetorySettings.Enabled = False
                Case 9
                    btnEndMonth.Enabled = False
                Case Else

            End Select

        Loop
        disconnect()

    End Sub

    Friend Sub GetItems()

        Dim QTY_DECIMAL As Decimal

        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("select TOP 80 itemid,prod_description,quantity from products where productid not in (1,2,3,4,5,6) ORDER BY RECORDID DESC", con)
        Else
            cmd = New SqlCommand("select TOP 80 itemid,prod_description,quantity from products where productid not in (1,2,3,4,5,6) and prod_description like '%" & convertQuotes(txtSearch.Text) & "%' ", con)
        End If

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrItems
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)

                For i As Integer = 0 To Me.dgrItems.Rows.Count - 1
                    If Me.dgrItems.Rows(i).Cells(2).Value <= 0 Then
                        Me.dgrItems.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        Me.dgrItems.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                    End If

                    QTY_DECIMAL = .Rows(.Rows.Count - 1).Cells(2).Value

                    If QTY_DECIMAL = Int(QTY_DECIMAL) Then
                        .Rows(.Rows.Count - 1).Cells(2).Value = QTY_DECIMAL.ToString("N0", CultureInfo.InvariantCulture)
                    Else
                        .Rows(.Rows.Count - 1).Cells(2).Value = QTY_DECIMAL.ToString("N2", CultureInfo.InvariantCulture)
                    End If

                Next


            End While
        End With
        disconnect()

        If dgrItems.SelectedRows.Count > 0 Then
            Try
                Dim X, Y As Integer
                X = dgrItems.CurrentCell.RowIndex
                Y = dgrItems.CurrentCell.ColumnIndex

                If (dgrItems.Rows.Count - 1) > selRow Then
                    dgrItems.ClearSelection()
                    dgrItems.Rows(selRow).Cells(selCol).Selected = True
                End If

                dgrItems.CurrentCell = dgrItems.Rows(selRow).Cells(selCol)
                dgrItems.Rows(selRow).Cells(selCol).Selected = True
            Catch ex As Exception
            End Try
        End If


        GetItemDetails()

    End Sub

    Friend Sub GetItemDetails()
        Try
            connect()
            cmd = New SqlCommand(" select prod_description,quantity = ISNULL(quantity,0),adjqty=ISNULL(adjqty,0), " & _
                                 "monthlybqty=ISNULL(monthlybqty,0),maxlevel,minlevel,reorderpoint,lastupdated,supplier " & _
                                 "from products where itemid = '" & dgrItems.CurrentRow.Cells(0).Value & "' ", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                CURR_QTY = dr("quantity")
                BEG_QTY = dr("monthlybqty")
                ADJ_QTY = dr("adjqty")
                txtmaxstock.Text = dr("maxlevel").ToString
                txtminstock.Text = dr("minlevel").ToString
                txtsupplier.Text = dr("supplier").ToString
                txtReorder.Text = dr("reorderpoint").ToString
                GroupBox1.Text = dr("prod_description").ToString
            End If
            disconnect()

            If CURR_QTY = Int(CURR_QTY) Then
                txtQuantity.Text = CURR_QTY.ToString("N0", CultureInfo.InvariantCulture)
            Else
                txtQuantity.Text = CURR_QTY.ToString("N2", CultureInfo.InvariantCulture)
            End If

            If BEG_QTY = Int(BEG_QTY) Then
                txtMBQty.Text = BEG_QTY.ToString("N0", CultureInfo.InvariantCulture)
            Else
                txtMBQty.Text = BEG_QTY.ToString("N2", CultureInfo.InvariantCulture)
            End If

            If ADJ_QTY = Int(ADJ_QTY) Then
                txtAdjQty.Text = ADJ_QTY.ToString("N0", CultureInfo.InvariantCulture)
            Else
                txtAdjQty.Text = ADJ_QTY.ToString("N2", CultureInfo.InvariantCulture)
            End If

        Catch ex As Exception
            GroupBox1.Text = "NO ITEM FOUND"
            txtQuantity.Clear()
            txtMBQty.Clear()
            txtAdjQty.Clear()
            txtmaxstock.Clear()
            txtminstock.Clear()
            txtsupplier.Clear()
            txtReorder.Clear()
            Exit Sub
        End Try

    End Sub

    Friend Sub Get_InventoryItems()

        If txtSearch.Text.Length = 0 Then
            cmd = New SqlCommand("SELECT RECORDID,CASE WHEN TRANSTYPE = 'SI' THEN 'S-IN' ELSE 'S-OUT' END AS TRANSTYPE,DRNO,CONVERT(VARCHAR(10), TRANSDATE, 101), " & _
                                 "DESCRIPTION,DELBY,CHECKBY,CASE WHEN STATUS = 1 THEN 'ACTIVE' ELSE 'CLOSE' END AS 'STATUS' FROM DBO.INVENTORYTRANS ORDER BY TRANSDATE DESC", con)
        Else
            cmd = New SqlCommand("SELECT RECORDID,CASE WHEN TRANSTYPE = 'SI' THEN 'S-IN' ELSE 'S-OUT' END AS TRANSTYPE,DRNO,CONVERT(VARCHAR(10), TRANSDATE, 101), " & _
                                 "DESCRIPTION,DELBY,CHECKBY,CASE WHEN STATUS = 1 THEN 'ACTIVE' ELSE 'CLOSE' END AS 'STATUS' FROM DBO.INVENTORYTRANS WHERE DRNO like '%" & txtSearch.Text & "%' ORDER BY TRANSDATE DESC", con)
        End If

        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrStockInOut
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
            While dr.Read
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = dr(0)
                .Rows(.Rows.Count - 1).Cells(1).Value = dr(1)
                .Rows(.Rows.Count - 1).Cells(2).Value = dr(2)
                .Rows(.Rows.Count - 1).Cells(3).Value = dr(3)
                .Rows(.Rows.Count - 1).Cells(4).Value = dr(4)
                .Rows(.Rows.Count - 1).Cells(5).Value = dr(5)
                .Rows(.Rows.Count - 1).Cells(6).Value = dr(6)
                .Rows(.Rows.Count - 1).Cells(7).Value = dr(7)
            End While
        End With
        disconnect()

    End Sub

    Private Sub dgrItems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrItems.CellClick
        selRow = dgrItems.CurrentCell.RowIndex
        selCol = dgrItems.CurrentCell.ColumnIndex
    End Sub

    Private Sub dgrItems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrItems.Click
        GetItemDetails()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        GetItems()
        GetItemDetails()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjustment.Click
        frmMCount.ShowDialog()
    End Sub

    Private Sub btnEndMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndMonth.Click
        If DevComponents.DotNetBar.MessageBoxEx.Show("Are you sure you want to CLOSE the inventory for this month?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Dim currentMonth As String = DateTime.Now.ToString("MMM", CultureInfo.InvariantCulture)
            Dim currentYear As String = Now.Year.ToString()

            connect()
            cmd = New SqlCommand("UPDATE DBO.PRODUCTS SET MONTHLYBQTY = QUANTITY,  DAILYBQTY = QUANTITY", con)
            cmd.ExecuteNonQuery()
            'cmd = New SqlCommand("UPDATE INVENTORYTRANS SET CURRSTATUS = 1", con)
            'cmd.ExecuteNonQuery()
            disconnect()

            frmReport.Get_MONTH()
            frmReport.is_export = True
            frmReport.Generate_StockControl()

            connect()
            cmd = New SqlCommand("EXEC GenerateMonthlyAverageDemand '" & currentMonth & "', '" & currentYear & "' ", con)
            cmd.ExecuteNonQuery()
            disconnect()

            DevComponents.DotNetBar.MessageBoxEx.Show("MONTH WAS CLOSED!", "END-OF-MONTH", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnTransHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransHist.Click
        frmItemInvTransHist.ShowDialog()
    End Sub

    Private Sub btnDailyInvReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReport.is_export = False
        frmReport.Generate_DailyInvReport()
        frmReport.Show()
    End Sub

    Private Sub btnItemsReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReport.is_export = False
        frmReport.Generate_ProductList()
        frmReport.Show()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        txtSearch.Clear()
        txtSearch.Focus()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterStockIN.Click
        frmInvTrans.is_New = True
        frmInvTrans.TRANS_TYPE = "STOCKIN"
        frmInvTrans.Text = "Inventory Transaction - STOCK IN"
        frmInvTrans.ShowDialog()
    End Sub

    Private Sub ButtonX5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterStockOut.Click
        frmInvTrans.is_New = True
        frmInvTrans.TRANS_TYPE = "STOCKOUT"
        frmInvTrans.Text = "Inventory Transaction - STOCK OUT"
        frmInvTrans.ShowDialog()
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStock.Click
        If dgrStockInOut.RowCount = 0 Then
            DevComponents.DotNetBar.MessageBoxEx.Show("NO RECORD FOUND!", "RECORD", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If dgrStockInOut.CurrentRow.Cells(1).Value = "S-IN" Then
            frmInvTrans.TRANS_TYPE = "STOCKIN"
        Else
            frmInvTrans.TRANS_TYPE = "STOCKOUT"
        End If
        frmInvTrans.is_New = False
        frmInvTrans.ShowDialog()
    End Sub

    Private Sub SuperTabItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperTabItem1.Click
        btnAdjustment.Enabled = True
        btnTransHist.Enabled = True
        btnTransHist.Enabled = True
    End Sub

    Private Sub SuperTabItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperTabItem2.Click
        btnAdjustment.Enabled = False
        btnTransHist.Enabled = False
        btnTransHist.Enabled = False
    End Sub

    Private Sub ButtonX4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvetorySettings.Click
        frmUpdateStockLevel.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        GetItems()
        dgrItems.Refresh()
    End Sub

    Private Sub btnShowOrderAnalysisModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowOrderAnalysisModule.Click
        frmMonthlyDemandAnalysis.ShowDialog()
    End Sub

End Class