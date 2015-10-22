Imports System.Data.SqlClient

Public Class NewTruckForm

    Private branchID As Integer = getCurrentBranch().BranchID
    Dim conn As SqlConnection
    Dim plateNumber As String

    Private Sub TrucksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TrucksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransmittalDataSet)

    End Sub

    Private Sub NewTruckForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesAgentDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.FillByMyBranchID(Me.SalesAgentDataSet.Branch, branchID)
        'TODO: This line of code loads data into the 'TransmittalDataSet.Trucks' table. You can move, or remove it, as needed.
        Me.TrucksTableAdapter.Fill(Me.TransmittalDataSet.Trucks)
        Me.TrucksBindingSource.AddNew()
        Me.BranchIDComboBox.SelectedValue = branchID
    End Sub

    Private Sub insertTruck()
        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")

        plateNumber = PlateNumberTextBox.Text

        Try
            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO Trucks(PlateNumber, BranchID)" &
                                       "VALUES('{0}', '{1}') SELECT SCOPE_IDENTITY()",
                                       plateNumber,
                                       branchID)

            Dim createdObj As Object = cmd.ExecuteScalar()
            setCurrentTruckID(CInt(createdObj.ToString))

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.insertTruck()
    End Sub
End Class