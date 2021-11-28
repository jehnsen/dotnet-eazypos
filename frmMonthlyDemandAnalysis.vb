Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmMonthlyDemandAnalysis

    Public InventoryIds As String
    Public IdList As List(Of String) = New List(Of String)
    Private LastId As Integer
    Private LastMonth As String
    Private SecondMonth As String

    Private Sub frmMonthlyDemandAnalysis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetLastMonth()
        GetSecondMonth()
        lblMonthRange.Text = "Month Range: " & SecondMonth & " to " & LastMonth
        ListBox1.Items.Clear()
    End Sub

    Friend Sub GetLastMonth()
        connect()
        cmd = New SqlCommand("select top 1 recordid, Month from InventoryMonthlySummary order by RecordId desc", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read
            LastMonth = dr("Month")
            LastId = dr("recordid")
        Loop
        disconnect()

    End Sub
    Friend Sub GetSecondMonth()
        Dim _id = LastId - 2
        connect()
        cmd = New SqlCommand("select top 3 Month from InventoryMonthlySummary where recordid = '" & _id & "' ", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read
            SecondMonth = dr("Month")
        Loop
        disconnect()

    End Sub

    Friend Sub GetPreviousMonths()
        connect()
        cmd = New SqlCommand("select top 3 RECORDID from InventoryMonthlySummary order by RecordId desc", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Do While dr.Read
            IdList.Add(dr("recordid"))
        Loop
        disconnect()
        InventoryIds = String.Join(",", IdList)
    End Sub

    Friend Sub GenerateMonthlyDemandAnalysis()
        connect()
        cmd = New SqlCommand("SELECT MAX(isd.inventoryid) as 'inventoryid', MAX(isd.PRODUCTID) as 'ProductId', MAX(p.Prod_Description) as 'Description'," & _
                        "SUM(isd.ENDINGQTY) / 3 AS 'Demand', " & _
                        "(SUM(isd.ENDINGQTY) / 3) / 2 AS 'Ave' " & _
                        "FROM InventoryMonthlySummaryDetails isd " & _
                        "left join Products p on isd.ProductId = p.ProductID " & _
                        "WHERE isd.InventoryId IN (" & InventoryIds & ") GROUP BY isd.ProductId", con)

        Dim dr As SqlDataReader = cmd.ExecuteReader
        lvList.Items.Clear()
        Do While dr.Read
            Dim a = (dr.Item("inventoryid").ToString())
            Dim b = (dr.Item("ProductId").ToString())
            Dim c = (dr.Item("Description").ToString())
            Dim d = (dr.Item("Demand").ToString())
            Dim e As Decimal = (dr.Item("Ave").ToString())
            Dim lv As ListViewItem = lvList.Items.Add(a)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(e.ToString("N2", CultureInfo.InvariantCulture))
        Loop
        dr.Close()
        disconnect()

        For Each item As ListViewItem In Me.lvList.Items
            item.SubItems.Item(3).ForeColor = Color.Green
            item.SubItems.Item(4).ForeColor = Color.Blue
        Next
    End Sub

    Friend Sub GetMonthlyQty()

        ListBox1.Items.Clear()

        Dim index As Integer = 4

        For Each invId In IdList
            index -= 1
            connect()
            cmd = New SqlCommand("SELECT endingqty FROM InventoryMonthlySummaryDetails " & _
                                 "WHERE inventoryid = '" & invId & "' " & _
                                 "AND productid= '" & lvList.SelectedItems(0).SubItems(1).Text & "'", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read Then
                ListBox1.Items.Add("Month " & index & " : " & dr("endingqty").ToString)
            End If
            disconnect()

        Next

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        GetPreviousMonths()
        GenerateMonthlyDemandAnalysis()
        lvList.Refresh()
        ListBox1.Items.Clear()
    End Sub

    Private Sub lvList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.Click
        GetMonthlyQty()
    End Sub
End Class