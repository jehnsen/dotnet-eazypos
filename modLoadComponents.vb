Imports System.Data.SqlClient

Module modLoadComponents


    Friend Sub LoadAllComponents()

        frmMain.GetBranch() ' 

        frmMain.POS_Start()

        frmMain.GetSystemInfo()

        frmMain.GenerateReceiptFooter()

        frmMain.Check_UnclosedShift()

        GetReadings()
        GetReceiptRange()
        GetSalesReport()


        'GetVatValue()

        'GetLast_TransactionNo()

    End Sub

End Module
