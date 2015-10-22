Imports System.Data.SqlClient

Public Class DepartmentNewForm

    Dim conn As SqlConnection
    Private deptName As String
    Private description As String

    Private Sub DepartmentNewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        deptName = DepartmentNameTextBox.Text
        description = DescriptionTextBox.Text

        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")

        Try
            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO ProductDepartment(DepartmentName, Description)" &
                                            "VALUES('{0}', '{1}') SELECT SCOPE_IDENTITY()",
                                            deptName,
                                            description)
            ' Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            Dim id As Object = cmd.ExecuteScalar()
            MsgBox(CInt(id.ToString))
            setCurrentDepartmentID(CInt(id.ToString))

            'If rowsAffected > 0 Then
            '    MsgBox("Success")
            'Else
            '    MsgBox("Fail")
            'End If

        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try
        
    End Sub
End Class