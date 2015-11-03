Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text

Public Class UserNewForm

    Private userData As New UsersDataClassesDataContext
    Private username As String
    Private password As String
    Private role As Integer
    Private branch As Integer
    Dim conn As SqlConnection
    'Dim strText As String
    Dim bytHashedData As Byte()
    Dim encoder As New UTF8Encoding()
    Dim md5Hasher As New MD5CryptoServiceProvider



    Private Sub UserNewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SNFDatabaseDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.SNFDatabaseDataSet.Branch)
        'TODO: This line of code loads data into the 'SNFDatabaseDataSet.Roles' table. You can move, or remove it, as needed.
        Me.RolesTableAdapter.Fill(Me.SNFDatabaseDataSet.Roles)

    End Sub
   
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    
        username = tbUsername.Text
        password = tbPassword.Text
        role = cbRole.SelectedValue
        branch = cbBranch.SelectedValue
        bytHashedData = md5Hasher.ComputeHash(encoder.GetBytes(password))


        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)

        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")
        conn.Open()
        Dim cmd = conn.CreateCommand
        cmd.CommandText = String.Format("INSERT INTO Users(Username, Password, RoleID, BranchID)" &
                                        "VALUES('{0}', '{1}', '{2}', '{3}')",
                                        username,
                                        Convert.ToBase64String(bytHashedData),
                                        role,
                                        branch)
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        If rowsAffected > 0 Then
            MsgBox("Success")
        Else
            MsgBox("Fail")
        End If

        conn.Close()

    End Sub

    'Private Sub btnAdd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles btnAdd.Validating
    '    username = tbUsername.Text
    '    password = tbPassword.Text
    '    If String.IsNullOrEmpty(username) Then
    '        MessageBox.Show("Please supply Username fields.", _
    '                        "Entry Error", _
    '                        MessageBoxButtons.OK, _
    '                        MessageBoxIcon.Exclamation)
    '    End If
    '    If String.IsNullOrEmpty(password) Then
    '        MessageBox.Show("Please supply Password field.", _
    '                        "Entry Error", _
    '                        MessageBoxButtons.OK, _
    '                        MessageBoxIcon.Exclamation)
    '    End If
    '    If String.IsNullOrEmpty(tbConfirmPass.Text) Then
    '        MessageBox.Show("Please supply Confirm Password field.", _
    '                        "Entry Error", _
    '                        MessageBoxButtons.OK, _
    '                        MessageBoxIcon.Exclamation)
    '    End If

    'End Sub


    Private Sub tbUsername_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbUsername.Validating

        username = tbUsername.Text
        Dim qCount As Integer = 0
        Dim userQuery = From u In userData.Users _
                        Where u.Username.Equals(username)
                        Select u

        Try
            qCount = userQuery.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If username.Length < 1 Then
            MessageBox.Show("Please supply Username fields.", _
                           "Entry Error", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Exclamation)

            tbUsername.Focus()
        ElseIf qCount > 0 Then
            MessageBox.Show("Username is already taken.", _
                          "Entry Error", _
                                   MessageBoxButtons.OK, _
                                   MessageBoxIcon.Exclamation)

            tbUsername.Focus()
        ElseIf Not Regex.IsMatch(username, "^([a-zA-Z])[a-zA-Z_-]*[\w_-]*[\S]$|^([a-zA-Z])[0-9_-]*[\S]$|^[a-zA-Z]*[\S]$") Then
            MessageBox.Show("Invalid username.", _
                         "Entry Error", _
                                  MessageBoxButtons.OK, _
                                  MessageBoxIcon.Exclamation)

            tbUsername.Focus()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Me.RemoveValidation()
        Me.Close()

    End Sub

    'Private Sub RemoveValidation()
    '    Me.tbUsername.CausesValidation = False
    '    Me.tbPassword.CausesValidation = False
    '    Me.tbConfirmPass.CausesValidation = False
    '    Me.cbBranch.CausesValidation = False
    '    Me.cbRole.CausesValidation = False
    'End Sub

    Private Sub tbConfirmPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbConfirmPass.Validating
        password = tbPassword.Text

        If Not password.Equals(tbConfirmPass.Text) Then
            MessageBox.Show("Password mismatch.", _
                          "Entry Error", _
                                   MessageBoxButtons.OK, _
                                   MessageBoxIcon.Exclamation)


        End If
    End Sub

    Private Sub cbRole_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbRole.Validating
        If cbRole.SelectedIndex = -1 Then
            MessageBox.Show("Select Role", _
                       "Entry Error", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Exclamation)
            cbRole.Focus()
        End If
    End Sub

    Private Sub cbBranch_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbBranch.Validating
        If cbBranch.SelectedIndex = -1 Then
            MessageBox.Show("Select Branch", _
                       "Entry Error", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Exclamation)
            cbBranch.Focus()
        End If
    End Sub

    Private Sub tbPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbPassword.Validating
        If (Me.tbPassword.Text.StartsWith(" ") Or Me.tbPassword.Text.Length < 1) Then
            MsgBox("Invalid Input: New Password Field")
            Me.tbPassword.Focus()
        ElseIf Me.tbConfirmPass.TextLength > 0 And Not Me.tbPassword.Text.Equals(Me.tbConfirmPass.Text) Then
            MsgBox("New password and password confirmation do not match.")
        ElseIf Me.tbPassword.TextLength < 6 Then
            MsgBox("Password must contain at least 6 characters.")
            Me.tbPassword.Focus()
        End If
    End Sub
End Class