Imports System.Data.SqlClient

Public Class NewGroupForm

    Dim conn As SqlConnection
    Private groupName As String
    Private description As String
    Private departmentID As Integer

    Private Sub NewGroupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.ProductDepartment' table. You can move, or remove it, as needed.
        Me.ProductDepartmentTableAdapter.Fill(Me.ProductsDataSet.ProductDepartment)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        groupName = GroupNameTextBox.Text
        description = GroupDescriptionTextBox.Text
        departmentID = DepartmentIDComboBox.SelectedValue

        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")
        conn.Open()
        Dim cmd = conn.CreateCommand
        cmd.CommandText = String.Format("INSERT INTO ProductGroup(GroupName, GroupDescription, DepartmentID)" &
                                        "VALUES('{0}', '{1}', '{2}') SELECT SCOPE_IDENTITY()",
                                        groupName,
                                        description,
                                        departmentID)

        Dim createdObj As Object = cmd.ExecuteScalar()
        setCurrentGroupID(CInt(createdObj.ToString))


        'Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        'If rowsAffected > 0 Then
        '    MsgBox("Success")
        'Else
        '    MsgBox("Fail")
        'End If

        conn.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNewDept_Click(sender As Object, e As EventArgs) Handles btnNewDept.Click
        Dim deptForm As New DepartmentNewForm
        If deptForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            Me.ProductDepartmentTableAdapter.Fill(Me.ProductsDataSet.ProductDepartment)
            Me.DepartmentIDComboBox.SelectedValue = getCurrentDepartmentID()
        End If
    End Sub

End Class