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
        If UserModule.isNewTerm Then
            Me.TermsTableAdapter.Fill(Me.TermsDataSet.Terms)
            Me.TermsBindingSource.AddNew()
        Else
            Me.TermsTableAdapter.FillByTermID(Me.TermsDataSet.Terms, UserModule.editTermID)
        End If
       
    End Sub

    Private Function isValid() As Boolean

        Dim valid As Boolean = False
        Try
            If Not Me.TermTextBox.Text.Equals("") And
            Not Me.TermTextBox.Text.StartsWith(" ") And
            Integer.TryParse(Me.DaysDueTextBox.Text, daysDue) Then
                MsgBox("Valid")
                valid = True
            Else
                MsgBox("Invalid")
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
        term = TermTextBox.Text
        description = DescriptionTextBox.Text

        Try

            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO Terms(Term, Description, DaysDue)" &
                                       "VALUES('{0}', '{1}', '{2}') SELECT SCOPE_IDENTITY()",
                                       term,
                                       description,
                                       daysDue)

            Dim createdObj As Object = cmd.ExecuteScalar()
            setCurrentTermID(CInt(createdObj.ToString))

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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        If UserModule.isNewTerm Then
            Me.insertTerm()
        Else
            Me.updateTerm()
        End If
      
    End Sub

    Private Sub updateTerm()
        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")
        term = TermTextBox.Text
        description = DescriptionTextBox.Text
        'daysDue = Integer.Parse(DaysDueTextBox.Text)

        Try

            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("UPDATE Terms SET " &
                                      "Term='{0}', " &
                                      "Description='{1}', " &
                                      "DaysDue='{2}' " &
                                      "WHERE TermsID='{3}'",
                                      term,
                                      description,
                                      daysDue,
                                      UserModule.editTermID)

            'Dim createdObj As Object = cmd.ExecuteScalar()


            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Success")
            Else
                MsgBox("Fail")
            End If
            setCurrentTermID(UserModule.editTermID)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

#Region "Validation"
    Private Sub DaysDueTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DaysDueTextBox.Validating
        If Not Integer.TryParse(Me.DaysDueTextBox.Text, daysDue) Then
            MsgBox("Invalid Input")
            Me.DaysDueTextBox.Focus()
        End If
    End Sub

    Private Sub TermTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TermTextBox.Validating, DescriptionTextBox.Validating
        Dim txtBox = CType(sender, TextBox)
        If Not ValidationsModule.isValidName(txtBox.Text) Then
            MsgBox("Invalid Input")
            txtBox.Focus()
            'Me.TermTextBox.Focus()
        End If
    End Sub

    'Private Sub DescriptionTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DescriptionTextBox.Validating
    '    If Not ValidationsModule.isValidName(Me.DescriptionTextBox.Text) Then
    '        MsgBox("Invalid Input")
    '        Me.DescriptionTextBox.Focus()
    '    End If
    'End Sub
#End Region
  
End Class