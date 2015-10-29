Public Class Enable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim SNFxpHash As String = ValidationsModule.GetHash("SNFxpHash")
        If Me.TextBox1.Text = "PxVjA'NAZPzb,^GI(&BTKxmTiA|3|" Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\" & SNFxpHash, "Registered", True)
            MsgBox("Success")
            Me.Close()
        Else
            MsgBox("Invalid code.")
        End If
    End Sub
End Class