Public Class DatasetTest
    Private UserData As New UsersDataClassesDataContext

    Private Sub DatasetTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SNFDatabaseDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.SNFDatabaseDataSet.Users)
        ' Dim ubs As BindingSource
        'ubs = New BindingSource

        Dim query = From u In _
                    UserData.Users _
                    Where u.RoleID = 6 _
                    Select u

        ' Me.UsersBindingSource.DataSource = query
        Me.DataGridView1.DataSource = query
        For Each User In query
            Console.WriteLine(User.Username)

        Next


    End Sub

End Class