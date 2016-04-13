Imports System.Data.SqlClient

Module AccountsReceivableModule
    Dim conn As SqlConnection
    Dim conString = My.Settings.Item("snfdbxpConnectionString")
    Dim ArDate As Date = Date.Now

    'connect to sql server
    Public Sub SQLconnect()
        conn = New SqlConnection(conString)
        conn.Open()

    End Sub

    Public Function insertAR(ByVal CustomerID As Integer, InvoiceID As Integer, DRNo As Integer, _
                             TermsID As Integer, DueDate As Date, isPaid As Boolean, _
                             BranchID As Integer, SalesAgentID As Integer, Amount As Double) As Boolean
        Dim success = New Boolean = False

        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO AccountsReceivable(CustomerID, InvoiceID, DRNo, TermsID, DueDate," &
                                            "isPaid, BranchID, SalesAgentID, Amount) " &
                                            "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                            CustomerID, InvoiceID, DRNo, TermsID, DueDate, isPaid, BranchID, SalesAgentID, Amount)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            'Dim id As Object = cmd.ExecuteScalar()
            'MsgBox("Success!")
        Catch ex As Exception
            MsgBox("Failed to add A/R!")
        End Try
        Return success
    End Function

    Public Function checkCustomerBalance(ByVal CustomerId As Integer) As Double
        Dim myBalance As Double = 0
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("SELECT (isnull(SUM(AR.Amount),0) - isnull(SUM(PR.Amount),0)) AS Balance" &
                                            " FROM AccountsReceivable AS AR LEFT JOIN PaymentsReceive AS PR ON AR.CustomerID = PR.CustomerID" &
                                            " WHERE AR.CustomerID=('{0}')",
                                            CustomerId)
            'Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            Console.WriteLine(cmd.CommandText)
            Dim bal As Object = cmd.ExecuteScalar()
            'Dim dr As SqlDataReader = cmd.ExecuteReader()


            ' MsgBox("Success! " & bal.ToString)
            myBalance = Convert.ToDouble(bal)
        Catch ex As Exception
            Console.WriteLine(ex.Message)

            MsgBox("Database Error.")
            'MsgBox(ex.ToString)
        End Try

        Return myBalance
    End Function

    Public Function checkInvoiceBalance(ByVal InvoiceID As Integer, BranchID As Integer) As Double
        Dim invBalance As Double = 0
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("SELECT (isnull(SUM(AR.Amount),0) - isnull(SUM(PR.Amount),0)) AS Balance" &
                                            " FROM AccountsReceivable AS AR LEFT JOIN PaymentsReceive AS PR ON AR.DRNo = PR.DRNo" &
                                            " WHERE AR.DRNo=('{0}') AND AR.BranchID=('{1}')",
                                            InvoiceID, BranchID)
            'Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            Dim bal As Object = cmd.ExecuteScalar()
            'Dim dr As SqlDataReader = cmd.ExecuteReader()


            'MsgBox("Success! " & bal.ToString)
            invBalance = Convert.ToDouble(bal)
        Catch ex As Exception
            Console.WriteLine(ex.Message)

            MsgBox("Database Error.")
        End Try

        Return invBalance
    End Function

    Public Function getDRNo(ByVal CustomerID As Integer) As DataTable
        Dim dt As DataTable = Nothing

        Try
            dt = New DataTable
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("SELECT AR.CustomerID, RIGHT('0000'+Convert(Varchar,AR.DRNo),7) as DRNo, (isnull(SUM(AR.Amount),0) - isnull(SUM(PR.Amount),0)) AS Balance" &
                                            " FROM AccountsReceivable AS AR LEFT JOIN PaymentsReceive AS PR ON AR.DRNo = PR.DRNo" &
                                            " WHERE AR.CustomerID=('{0}')" &
                                            " Group by AR.CustomerID, AR.DRNo" &
                                            " Having (isnull(SUM(AR.Amount), 0) - isnull(SUM(PR.Amount), 0)) > 0",
                                            CustomerID)
            'Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            'Dim bal As Object = cmd.ExecuteScalar()

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dt.Load(dr)

            'MsgBox("Success! " & bal.ToString)
            ' invBalance = Convert.ToDouble(bal)
        Catch ex As Exception
            Console.WriteLine(ex.Message)

            MsgBox("Database Error.")
        Finally
            conn.Close()
        End Try


        Return dt
    End Function

    Public Function getARDATE() As Date
        Return ArDate
    End Function

    Public Sub setARDATE(newARDate As Date)
        ArDate = newARDate
    End Sub

End Module
