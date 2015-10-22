Imports System.Data.SqlClient

Public Class NewTermForm

    Private branchID As Integer = getCurrentBranch().BranchID
    Dim conn As SqlConnection
    Dim term, description As String
    Dim daysDue As Integer
    Private Sub TermsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TermsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TermsDataSet)

    End Sub

    Private Sub NewTermForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TermsDataSet.Terms' table. You can move, or remove it, as needed.
        Me.TermsTableAdapter.Fill(Me.TermsDataSet.Terms)

    End Sub

    Private Function isValid() As Boolean

        Dim valid As Boolean = False
        Try
            If Not Me.TermTextBox.Text.Equals("") And
           Not Me.TermTextBox.Text.StartsWith(" ") And
            Integer.TryParse(DaysDueTextBox.Text, daysDue) Then
                valid = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       

        Return valid

    End Function

    Private Sub insertTerm()
        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")


        Try
            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO Terms(Term, Description, DaysDue)" &
                                       "VALUES('{0}', '{1}', '{2}) SELECT SCOPE_IDENTITY()",
                                       term,
                                       description,
                                       daysDue)

            Dim createdObj As Object = cmd.ExecuteScalar()
            setCurrentAreaID(CInt(createdObj.ToString))

            'Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            'If rowsAffected > 0 Then
            '    MsgBox("Success")
            'Else
            '    MsgBox("Fail")
            'End If

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class