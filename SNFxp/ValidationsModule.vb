Imports System.Security.Cryptography
Imports System.Text
Module ValidationsModule
    Const salt As String = "SNFsalt"
    Function isValidName(ByVal myString As String) As Boolean
        Dim valid As Boolean = False

        If Not myString.Equals("") And Not myString.StartsWith(" ") Then
            valid = True
        End If

        Return valid
    End Function

    Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput & salt))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using
    End Function

    Function CheckHash(hashedStr As String, newInput As String) As Boolean
        ' get the hash value of user input: 
        Dim newHash As String = GetHash(newInput)
        ' return comparison
        Return String.Compare(newHash, hashedStr, StringComparison.InvariantCultureIgnoreCase)
    End Function
End Module
