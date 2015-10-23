Module ValidationsModule

    Function isValidName(ByVal myString As String) As Boolean
        Dim valid As Boolean = False

        If Not myString.Equals("") And Not myString.StartsWith(" ") Then
            valid = True
        End If

        Return valid
    End Function
End Module
