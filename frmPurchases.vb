Imports System.Data.SqlClient
Imports System.Globalization
Imports DevComponents.DotNetBar

Public Class frmPurchases

    Private Sub frmPurchases_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmLogin.userType = 3 Then 'cashier
            frmMain.styleMain.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
            frmMain.Show()
        End If
    End Sub

    Private Sub frmPurchases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_PURCHASES()
        GetPO()
        'user access level
        If frmMain.userType = 3 Then 'cashier
            SetUserAcess()
        End If

        StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        dgrPurchases.BackgroundColor = Color.White
    End Sub

    Friend Sub SetUserAcess()
        Dim buttonId As Integer
        connect()
        cmd = New SqlCommand("SELECT Id FROM MODULES Where Cashier = 0 AND ModuleId = 3", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read

            buttonId = dr("Id")

            Select Case buttonId
                Case 10
                    btnCreatePO.Enabled = False
                Case 11
                    btnEditPO.Enabled = False
                Case 12
                    btnClosePO.Enabled = False
                Case 14
                    btnReceivePurchases.Enabled = False
                Case 13
                    btnClosePurchase.Enabled = False
                Case Else

            End Select

        Loop
        disconnect()

    End Sub

    Friend Sub Get_PURCHASES()
        cmd = New SqlCommand("SELECT PD_NO,DATE_RECEIVED,OR_NO,SUPPLIER_NAME,RECEIVED_BY,CHECKED_BY,REMARKS,CASE WHEN STATUS = 1 THEN 'OPEN' ELSE 'CLOSED' END AS 'STATUS' FROM DBO.PURCHASEDELIVERIES", con)
        connect()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        With dgrPurchases
            .Rows.Clear()
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
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
        dr.Close()
        disconnect()

    End Sub

    Friend Sub GetPO()
        cmd = New SqlCommand("SELECT RECORDID,PONUMBER,POTITLE,SUPPLIER,SHIPTO,TERMS,DATECREATED=CONVERT(VARCHAR(10), DATECREATED, 101),TOTALAMOUNT, " & _
                             "PREPAREDBY,CASE WHEN STATUS = '1' THEN 'Received' WHEN STATUS = '2' THEN 'Placed' ELSE " & _
                             "'Pending' END AS [STATUS],REMARKS FROM PURCHASEORDER ", con)
        connect()
        dr = cmd.ExecuteReader()
        lvPurchaseOrder.Items.Clear()
        Do While dr.Read()
            Dim a = (dr.Item("RECORDID").ToString())
            Dim b = (dr.Item("PONUMBER").ToString())
            Dim c = (dr.Item("POTITLE").ToString())
            Dim d = (dr.Item("SUPPLIER").ToString())
            Dim e = (dr.Item("SHIPTO").ToString())
            Dim f = (dr.Item("TERMS").ToString())
            Dim g = (dr.Item("DATECREATED").ToString())
            Dim h As Decimal = (dr.Item("TOTALAMOUNT").ToString())
            Dim i = (dr.Item("STATUS").ToString())
            Dim j = (dr.Item("REMARKS").ToString())

            Dim lv As ListViewItem = lvPurchaseOrder.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(e)
            lv.SubItems.Add(f)
            lv.SubItems.Add(g)
            lv.SubItems.Add(h.ToString("N2", CultureInfo.InvariantCulture))
            lv.SubItems.Add(i)
            lv.SubItems.Add(j)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
    End Sub

    Private Sub btnReceivePurchases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivePurchases.Click
        frmPurchaseReceive.ShowDialog()
    End Sub

    Private Sub btnClosePurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosePurchase.Click
       
        frmViewReceivedPurchases.ShowDialog()
    End Sub

    Private Sub btnCreatePO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePO.Click
        frmPurchaseOrderCreate.is_NewPO = True
        frmPurchaseOrderCreate.ShowDialog()
    End Sub

    Private Sub btnEditPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPO.Click
        Try
            If lvPurchaseOrder.SelectedItems(0).SubItems(8).Text = "Received" Then
                MessageBoxEx.Show("Cannot edit. Purchase Order was already closed!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            frmPurchaseOrderCreate.is_NewPO = False
            frmPurchaseOrderCreate.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClosePO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClosePO.Click
        Try
            If DevComponents.DotNetBar.MessageBoxEx.Show("Are you sure you want to CLOSE this Purchase Order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                connect()
                cmd = New SqlCommand("UPDATE DBO.PURCHASEORDER SET STATUS = 1,  ISPLACED = 1 WHERE RECORDID = '" & lvPurchaseOrder.SelectedItems(0).Text & "' ", con)
                cmd.ExecuteNonQuery()
                disconnect()
            Else
                Exit Sub
            End If

            MessageBoxEx.Show("Purchase Order was closed!", "Confirmation", MessageBoxButtons.OK)
            GetPO()
            lvPurchaseOrder.Refresh()

        Catch ex As Exception
            MessageBoxEx.Show("Please select a record first!", "Close", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        PoNumber = lvPurchaseOrder.SelectedItems(0).SubItems(1).Text
        GetSupplierInfo()
        frmReport.GetBusinessInfo()
        frmReport.Generate_PurchaseOrderReport()
        frmReport.Show()
    End Sub

    Friend Sub GetSupplierInfo()
        connect()
        cmd = New SqlCommand("select * from suppliers where suppliername = '" & lvPurchaseOrder.SelectedItems(0).SubItems(3).Text & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            SupplierName = dr("suppliername")
            SupplierAddress = dr("address")
            SupplierContactNo = dr("phone")
        End If
        disconnect()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        frmReport.GetBusinessInfo()
        frmReport.Generate_PurchaseItemsDetails()
        frmReport.Show()
    End Sub

    Private Sub dgrPurchases_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrPurchases.CellDoubleClick
        frmViewReceivedPurchases.ShowDialog()
    End Sub
End Class