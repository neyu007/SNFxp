Public Class Login

    Private usr As New UsersDataClassesDataContext
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim myUser = From user In usr.Users _
                     Where user.Username.Equals(username)
        Try
            If myUser.Count > 0 _
                And myUser.First.Username.Equals(username, StringComparison.Ordinal) _
                And myUser.First.Password.Equals(password, StringComparison.Ordinal) Then

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
    
    
End Class
