Imports System.Data.SqlClient

Module modGlobal

    Public constring As String = frmLogin.str
    Public con As New SqlConnection(frmLogin.str)

    Public userType As Integer
    
    Public Sub connect()
        If con.State = System.Data.ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub disconnect()
        If con.State = System.Data.ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Function ConnServer() As Boolean
        Try
            ConnServer = True
            connect()
            Exit Function
        Catch ex As Exception
            ConnServer = False
            MsgBox("Application cannot connect to database! ", MsgBoxStyle.Information)
            frmConnection.ShowDialog()
        End Try
    End Function

    Public Function SetUserType(ByVal type)
        Return userType = 2
    End Function

    Public Function GetUserType()
        Return userType
    End Function

    Public AppModule As String

    'SQL VARIABLES

    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public dt As DataTable

    'PRODUCT
    Public product_dept As Integer
    Public product_cat As Integer
    Public product_plu As String
    Public product_id As String
    Public button_id As String
    Public product_desc As String
    Public product_price As String
    Public dept_id As Integer
    Public dept_name As String
    Public cat_id As Integer
    Public cat_name As String

    'TRANSACTION
    Public transaction_no As String = 1
    Public receipt_no As String = 1
    Public invoice_no As String = ""
    Public cash_amnt As Decimal
    Public receivable_amnt As Decimal
    Public trans_LINEQTY As Double
    Public trans_totaldue As Double
    Public trans_discount As Double
    Public trans_payment As String
    Public trans_change As String
    Public trans_disctype As Integer = 0
    Public trans_vatablesales As String
    Public trans_productvat As String
    Public trans_vatpercent As String
    Public trans_chargeamount As String
    Public trans_chargetype As String = ""
    Public new_balance As String
    Public trans_newbalance As String
    Public max_trans_date As Date
    Public addon_fee As Decimal

    Public amnt_of_vat As Decimal
    Public sales_NET_VAT As Decimal
    Public amnt_to_pay As Decimal

    Public trans_cardamount As String
    Public trans_cardtype As String = ""
    Public trans_expirydate As String
    Public trans_cardno As String
    Public trans_approvalno As String
    Public trans_points As String
    Public new_points As String
    Public points_percentage As Double = 10.0

    Public cust_name As String = ""
    Public cust_id As Integer = 0
    Public cust_total_balance As Decimal
    Public cashier_id As String = 1
    Public cashier_name As String
    Public bagger_id As String = ""
    Public payment_mode As Integer = 1  ' 1 = cash, 2 = charge/PO, 3 = card(credit/debit card)

    'SYSTEM INFO
    Public business_name As String
    Public POS_Security As Integer
    Public system_time As String
    Public session_timestarted As String
    Public session_timeended As String
    Public branch_id As Integer
    Public branch_name As String
    Public branch_address As String
    Public branch_phoneno As String
    Public terminal_no As Integer = 1
    Public terminal_name As String
    Public serial_no As String
    Public machine_no As String
    Public permit_no As String
    Public tin_no As String
    Public manager As String = ""
    Public manager_id As String
    Public managersaccess As String
    Public user_pin As String
    Public NewSessionID As Integer = 1
    Public productselection_mode As String
    Public pos_printer As String
    Public pos_manager_printer As String
    Public printing_option As String
    Public printcopy As Integer
    Public isreceiptduplicate As Boolean
    Public isalways_print_receipt As String
    Public is_print_coupon As String
    Public is_print_points As String
    Public is_export_receipt As String
    Public is_print_report_after_endshift As String

    'INVENTORY
    Public INV_FILEPATH As String
    Public is_PRINT_INV_REPORT As String

    'REPORT/READING
    Public reading_type As String
    Public reading_timestart As String
    Public reading_timeend As String
    Public reading_timerange As String
    Public def_SR_Type As String

    'RECEIPT
    Public Header1 As String
    Public Header2 As String
    Public Header3 As String
    Public Header4 As String
    Public Header5 As String
    Public Header6 As String
    Public Header7 As String
    Public Footer24 As String
    Public Footer25 As String
    Public Footer26 As String
    Public Footer27 As String
    Public Footer28 As String

    'SHORTCUT KEYS
    Public key_ChangeQty As Keys
    Public key_CashPullout As Keys
    Public key_CashReceive As Keys
    Public key_CustomerLookup As Keys


    'PASSWORD ENCRYPTION
    Function getSHA1Hash(ByVal strToHash As String) As String

        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult

    End Function

    Public Function convertQuotes(ByVal str As String) As String
        convertQuotes = str.Replace("'", "''")
    End Function

End Module
