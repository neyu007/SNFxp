Imports System.Data.SqlClient

Module CustomerModule

    Dim conn As SqlConnection
    Dim conString = My.Settings.Item("snfdbxpConnectionString")




    Public Function insertCustomer(ByVal StoreName As String, NameOfOwner As String, Address As String, _
                             BranchID As Integer, PriceLevelID As Integer, Remarks As String, _
                             TermsID As Integer, AreaID As Integer) As Boolean
        Dim success = New Boolean = False

        Try
            conn = New SqlConnection(conString)
            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO Customers(StoreName, NameOfOwner, Address, BranchID, " &
                                            "PriceLevelID, Remarks, TermsID, AreaID) " &
                                            "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                            StoreName, NameOfOwner, Address, BranchID, PriceLevelID, Remarks, TermsID, AreaID)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            'Dim id As Object = cmd.ExecuteScalar()
            'MsgBox("Success!")
            conn.Close()
        Catch ex As Exception
            MsgBox("Failed to add Customer!")
        End Try
        Return success
    End Function

    Public Function updateCustomer(ByVal CustomerID As Integer, StoreName As String, Address As String, _
                                   TermsID As Integer, PriceLevelID As Integer) As Boolean
        Dim success = New Boolean = False
        Try
            conn = New SqlConnection(conString)
            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("UPDATE Customers SET StoreName = '{0}', Address = '{1}', " &
                                            "TermsID = '{2}', PriceLevelID = '{3}' " &
                                            "WHERE CustomerID = '{4}' ",
                                            StoreName, Address, PriceLevelID, TermsID, CustomerID)
            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("Success!")
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            MsgBox("Failed to update Customer!")
        End Try

        Return success
    End Function
End Module
