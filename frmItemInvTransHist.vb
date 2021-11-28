Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmItemInvTransHist

    Private Sub frmItemInvTransHist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_TransHistory()
        lblItemName.Text = frmInventory.dgrItems.CurrentRow.Cells(1).Value
    End Sub

    Friend Sub Get_TransHistory()
        'Try
        connect()

        cmd = New SqlCommand("select receiptno,datetime=CONVERT(VARCHAR(10), DATETIME, 101),dailybqty=isnull(dailybqty,0),salesqty=isnull(quantity,0), purchaseqty=isnull(dailypurchaseqty,0), stockinqty=isnull(s_in,0), " & _
                            "stockoutqty=isnull(s_out,0), returnedqty=isnull(retqty,0), adjqty=isnull(dailyadj,0), endingqty=isnull(dailyeqty,0) " & _
                            "from dbo.[transaction] where productid = '" & frmInventory.dgrItems.CurrentRow.Cells(0).Value & "' ORDER BY recordid ASC", con)


        Dim dr As SqlDataReader = cmd.ExecuteReader
        lvTransaction.Items.Clear()
        Do While dr.Read()
            Dim a As String = (dr.Item("datetime"))
            Dim x As String = (dr.Item("receiptno").ToString)
            Dim b As Decimal = (dr.Item("dailybqty").ToString())
            Dim c As Decimal = (dr.Item("salesqty").ToString())
            Dim d As Decimal = (dr.Item("purchaseqty").ToString())
            Dim e As Decimal = (dr.Item("stockinqty").ToString())
            Dim f As Decimal = (dr.Item("stockoutqty").ToString())
            Dim g As Decimal = (dr.Item("returnedqty").ToString())
            Dim i As Decimal = (dr.Item("ADJqty").ToString())
            Dim h As Decimal = (dr.Item("endingqty").ToString())

            If b = Int(b) Then
                b = b.ToString("N0", CultureInfo.InvariantCulture)
            Else
                b = b.ToString("N2", CultureInfo.InvariantCulture)
            End If

            If c = Int(c) Then
                c = c.ToString("N0", CultureInfo.InvariantCulture)
            Else
                c = c.ToString("N2", CultureInfo.InvariantCulture)
            End If

            If d = Int(d) Then
                d = d.ToString("N0", CultureInfo.InvariantCulture)
            Else
                d = d.ToString("N2", CultureInfo.InvariantCulture)
            End If

            If e = Int(e) Then
                e = e.ToString("N0", CultureInfo.InvariantCulture)
            Else
                e = e.ToString("N2", CultureInfo.InvariantCulture)
            End If

            If f = Int(f) Then
                f = f.ToString("N0", CultureInfo.InvariantCulture)
            Else
                f = f.ToString("N2", CultureInfo.InvariantCulture)
            End If

            If g = Int(g) Then
                g = g.ToString("N0", CultureInfo.InvariantCulture)
            Else
                g = g.ToString("N2", CultureInfo.InvariantCulture)
            End If

            If h = Int(h) Then
                h = h.ToString("N0", CultureInfo.InvariantCulture)
            Else
                h = h.ToString("N2", CultureInfo.InvariantCulture)
            End If


            If i = Int(i) Then
                i = i.ToString("N0", CultureInfo.InvariantCulture)
            Else
                i = i.ToString("N2", CultureInfo.InvariantCulture)
            End If

            Dim lv As ListViewItem = lvTransaction.Items.Add(a)
            lv.SubItems.Add(x)
            lv.SubItems.Add(b)
            lv.SubItems.Add(c)
            lv.SubItems.Add(d)
            lv.SubItems.Add(e)
            lv.SubItems.Add(f)
            lv.SubItems.Add(g)
            lv.SubItems.Add(i)
            lv.SubItems.Add(h)
        Loop
        dr.Close()
        cmd.Dispose()
        disconnect()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnViewRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewRep.Click
        frmReport.Generate_ItemTransHistory()
        frmReport.Show()
    End Sub

End Class