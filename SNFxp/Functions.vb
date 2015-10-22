Public Class Functions

    Dim numString As String = "0123456789-. /"

    Public Sub KeyPressNumeric(ByVal pFlag As Boolean, ByVal e As KeyPressEventArgs)
        If pFlag = True Then
            If Not IsNumeric(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        ElseIf pFlag = False Then
            If IsNumeric(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If

    End Sub

    Public Sub KeyPressNumeric(ByVal e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class
