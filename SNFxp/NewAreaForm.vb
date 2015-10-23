Imports System.Data.SqlClient

Public Class NewAreaForm

    Private branchID As Integer = getCurrentBranch().BranchID
    Dim conn As SqlConnection
    Dim areaName, town, province, city As String

    Private Sub AreasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AreasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomersDataSet)
    End Sub

    Private Sub NewAreaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'CustomersDataSet.Branch' table. You can move, or remove it, as needed.
            Me.BranchTableAdapter.FillByBranchID(Me.CustomersDataSet.Branch, branchID)
            If UserModule.isNewArea Then
                Me.AreasTableAdapter.Fill(Me.CustomersDataSet.Areas)
                Me.AreasBindingSource.AddNew()
            Else
                Me.AreasTableAdapter.FillByAreaID(Me.CustomersDataSet.Areas, editAreaID)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.BranchIDComboBox.SelectedValue = branchID
    End Sub


    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        areaName = AreaNameTextBox.Text
        town = TownTextBox.Text
        province = ProvinceTextBox.Text
        city = CityTextBox.Text
        'If Me.isValid() Then
        '    If btnSaveClose.DialogResult = Windows.Forms.DialogResult.OK Then
        '        InsertArea()
        '    End If
        'Else
        '    MsgBox("Invalid Input")
        'End If
        If UserModule.isNewArea Then
            Me.InsertArea()
        Else
            Me.UpdateArea()
        End If

    End Sub

#Region "CustomSUBS"
    Private Sub InsertArea()
        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")


        Try
            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO Areas(AreaName, BranchID, Town, Province, City)" &
                                       "VALUES('{0}', '{1}', '{2}', '{3}', '{4}') SELECT SCOPE_IDENTITY()",
                                       areaName,
                                       branchID,
                                       town,
                                       province,
                                       city)

            Dim createdObj As Object = cmd.ExecuteScalar()
            setCurrentAreaID(CInt(createdObj.ToString))

            'Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            'If rowsAffected > 0 Then
            '    MsgBox("Success")
            'Else
            '    MsgBox("Fail")
            'End If

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Function isValid()
        Dim valid As Boolean = False
        If Not Me.AreaNameTextBox.Text.Equals("") And
            Not Me.BranchIDComboBox.SelectedIndex = -1 And
            Not Me.AreaNameTextBox.Text.StartsWith(" ") Then
            valid = True
        End If

        Return valid

    End Function
    Private Sub updateArea()
        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")


        Try
            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("UPDATE Areas SET " &
                                      "AreaName='{0}', " &
                                      "BranchID='{1}', " &
                                      "Town='{2}' " &
                                      "Province='{3}', " &
                                      "City='{4}', " &
                                      "WHERE AreaID='{5}'",
                                      areaName,
                                      branchID,
                                      town,
                                      province,
                                      city,
                                      UserModule.editAreaID)

            'Dim createdObj As Object = cmd.ExecuteScalar()


            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Success")
            Else
                MsgBox("Fail")
            End If
            setCurrentTermID(UserModule.editTermID)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region
    
    '#Region "TextBoxChanged"
    '    Private Sub AreaNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles AreaNameTextBox.TextChanged
    '        If Me.AreaNameTextBox.Text.Count > 0 And
    '            Not Me.AreaNameTextBox.Text.StartsWith(" ") Then
    '            btnSaveClose.DialogResult = Windows.Forms.DialogResult.OK
    '        End If
    '    End Sub
    '#End Region
    

    Private Sub AreaNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) _
        Handles AreaNameTextBox.Validating, CityTextBox.Validating, ProvinceTextBox.Validating, TownTextBox.Validating
        Dim txtBox = CType(sender, TextBox)
        If Not ValidationsModule.isValidName(txtBox.Text) Then
            MsgBox("Invalid Input")
            txtBox.Focus()
            'Me.TermTextBox.Focus()
        End If
    End Sub
End Class