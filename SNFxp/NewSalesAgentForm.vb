Public Class NewSalesAgentForm

    Private Sub SalesAgentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesAgentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalesAgentDataSet)
    End Sub

    Private Sub NewSalesAgentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'SalesAgentDataSet.Branch' table. You can move, or remove it, as needed.
            Me.BranchTableAdapter.FillByMyBranchID(Me.SalesAgentDataSet.Branch, getCurrentBranch.BranchID)
            'If getLoggedUser.RoleID < 5 Then
            '    'TODO: This line of code loads data into the 'SalesAgentDataSet.SalesAgent' table. You can move, or remove it, as needed.
            '    Me.SalesAgentTableAdapter.Fill(Me.SalesAgentDataSet.SalesAgent)
            'Else
            Me.SalesAgentTableAdapter.FillByBranchID(Me.SalesAgentDataSet.SalesAgent, getCurrentBranch.BranchID)
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.SalesAgentBindingSource.CancelEdit()
        Me.SalesAgentBindingSource.AddNew()
        Me.DateHiredDateTimePicker.Value = DateTime.Today
        Me.BirthdayDateTimePicker.Value = DateTime.Today
        Me.BranchIDComboBox.SelectedValue = getCurrentBranch.BranchID
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If getLoggedUser().RoleID < 3 Then
            If MsgBox("Delete Item?", MsgBoxStyle.OkCancel, "Delete") = MsgBoxResult.Ok Then
                Me.SalesAgentBindingSource.RemoveCurrent()
                Me.SalesAgentTableAdapter.Update(Me.SalesAgentDataSet.SalesAgent)
            End If
        Else
            MsgBox("Access Denied")
        End If
       
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Try
            Me.SalesAgentBindingSource.EndEdit()
            Me.SalesAgentTableAdapter.Update(Me.SalesAgentDataSet.SalesAgent)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BranchIDComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BranchIDComboBox.Validating
        If Me.BranchIDComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Select Branch", _
                       "Entry Error", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Exclamation)
            Me.BranchIDComboBox.Focus()
        End If
    End Sub

End Class