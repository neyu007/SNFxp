Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Dim bytHashedData As Byte()
    Dim encoder As New UTF8Encoding()
    Dim md5Hasher As New MD5CryptoServiceProvider

    Private usr As New UsersDataClassesDataContext


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.checkValididty()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.login()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub tbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.login()
        End If
    End Sub

    Private Sub tbUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub login()
        Dim username As String
        Dim password As String

        username = tbUsername.Text
        password = tbPassword.Text
        bytHashedData = md5Hasher.ComputeHash(encoder.GetBytes(password))
        Dim myUser = From user In usr.Users _
                     Where user.Username.Equals(username)
        Try
            If myUser.Count > 0 _
                And myUser.First.Username.Equals(username, StringComparison.Ordinal) _
                And myUser.First.Password.Equals(Convert.ToBase64String(bytHashedData)) Then

                'MsgBox(loggedUser.firstname)
                Dim home As New HomeMDI
                ' MsgBox(myUser.First.RoleID)
                setLoggedUser(myUser.First)

                home.Show()
                Me.Close()

            Else
                MsgBox("Invalid username or password")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Function HandleRegistry() As Boolean
        Dim returnVal As Boolean = False
        Dim SNFxpHash As String = ValidationsModule.GetHash("SNFxpHash")
        'MsgBox(SNFxpHash)
        'Dim Registered As Boolean = _
        'Registered = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\SNFApp", "Registered", Nothing)
        'If Registered = Nothing Then
        '    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\SNFApp\" & SNFxpHash, "Registered", False)
        '    Registered = False
        'ElseIf Registered Then
        '    MsgBox("Reg")
        'Else
        '    MsgBox("Unreg")
        'End If
        'MsgBox("Value: " & CStr(Registered))
        'Return Registered
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\" & SNFxpHash, "Registered", Nothing) Is Nothing Then
            returnVal = False
        ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\" & SNFxpHash, "Registered", Nothing) = True Then
            returnVal = True
        End If

        Return returnVal
    End Function

    Private Sub DisableButtons()
        Me.tbPassword.Enabled = False
        Me.tbUsername.Enabled = False
        Me.btnLogin.Enabled = False
        Me.linkUnlock.Enabled = True
    End Sub

    Private Sub EnableButtons()
        Me.tbPassword.Enabled = True
        Me.tbUsername.Enabled = True
        Me.btnLogin.Enabled = True
        Me.linkUnlock.Visible = False
    End Sub

    Private Sub linkUnlock_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkUnlock.LinkClicked
        Dim enable As New Enable
        If enable.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.checkValididty()
        Else
            Me.checkValididty()
        End If

    End Sub

    Public Sub checkValididty()
        If Me.HandleRegistry Then
            Me.EnableButtons()
        Else
            Me.DisableButtons()
        End If
    End Sub
End Class
