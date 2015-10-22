Public Class BranchNewForm

    Private Sub BranchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BranchBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BranchBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SNFDatabaseDataSet)

    End Sub

    Private Sub BranchNewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SNFDatabaseDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.SNFDatabaseDataSet.Branch)
        Me.BranchBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.BranchBindingSource.EndEdit()
        Me.BranchTableAdapter.Update(Me.SNFDatabaseDataSet.Branch)
    End Sub
End Class