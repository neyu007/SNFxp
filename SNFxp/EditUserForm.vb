Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text

Public Class EditUserForm
    Private currentUser As User = getLoggedUser()

    Private password As String
    Private role As Integer
    Private branch As Integer
    Dim conn As SqlConnection
    'Dim strText As String
    Dim bytHashedData As Byte()
    Dim encoder As New UTF8Encoding()
    Dim md5Hasher As New MD5CryptoServiceProvider

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.updateUser()
    End Sub

    Private Sub updateUser()

        password = tbNewPassword.Text
        bytHashedData = md5Hasher.ComputeHash(encoder.GetBytes(password))

        Try
            Dim conString = My.Settings.Item("snfdbxpConnectionString")
            conn = New SqlConnection(conString)

            'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")
            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("UPDATE Users SET " &
                                            "password='{0}' " &
                                            "WHERE UserID='{1}'",
                                            Convert.ToBase64String(bytHashedData),
                                            currentUser.UserID)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Success")
            Else
                MsgBox("Fail")
            End If
            Me.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub tbOldPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbOldPass.Validating
        Dim oldPassStr As String = ValidationsModule.MyMD5Hasher(Me.tbOldPass.Text)
        If Not ValidationsModule.MyMD5Checker(currentUser.Password, oldPassStr) Then
            MsgBox("Enter your old password.")
            Me.tbOldPass.Focus()
        End If
    End Sub

    Private Sub tbNewPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbNewPassword.Validating
        If (Me.tbNewPassword.Text.StartsWith(" ") Or Me.tbNewPassword.Text.Length < 1) Then
            MsgBox("Invalid Input: New Password Field")
            Me.tbNewPassword.Focus()
        ElseIf Me.tbConfirmPass.TextLength > 0 And Not Me.tbNewPassword.Text.Equals(Me.tbConfirmPass.Text) Then
            MsgBox("New password and password confirmation do not match.")
        ElseIf Me.tbNewPassword.TextLength < 6 Then
            MsgBox("Password must contain at least 6 characters.")
            Me.tbNewPassword.Focus()
        End If
    End Sub

    Private Sub tbConfirmPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbConfirmPass.Validating
        If Me.tbConfirmPass.TextLength > 0 And Not Me.tbNewPassword.Text.Equals(Me.tbConfirmPass.Text) Then
            MsgBox("New password and password confirmation do not match.")
            Me.tbConfirmPass.Focus()
        ElseIf Me.tbConfirmPass.TextLength < 1 Then
            MsgBox("Confirm new password")
            Me.tbConfirmPass.Focus()
        End If
    End Sub

End Class