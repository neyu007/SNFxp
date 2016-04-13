Public Class BranchForm

    Private Sub BranchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BranchBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SNFDatabaseDataSet)
    End Sub

    Private Sub BranchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SNFDatabaseDataSet.Branch' table. You can move, or remove it, as needed.
        If getLoggedUser().RoleID < 5 Then
            Me.BranchTableAdapter.Fill(Me.SNFDatabaseDataSet.Branch)
        Else
            Me.BranchTableAdapter.FillByBranchID(Me.SNFDatabaseDataSet.Branch, getLoggedUser().BranchID)
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If getLoggedUser().RoleID < 3 Then
            Dim branchNew As New BranchNewForm
            If branchNew.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                Me.BranchTableAdapter.Fill(Me.SNFDatabaseDataSet.Branch)
                'Dim home As New Home
                'home.MdiParent = Me.MdiParent
                'home.Dock = DockStyle.Fill
                'home.Show()
                'Me.Close()
            End If
        Else
            MsgBox("Access Denied")
        End If

       
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim row As DataRowView = DirectCast(Me.BranchBindingSource.Current, DataRowView)
        Dim dtRow As SNFDatabaseDataSet.BranchRow = row.Row

        setCurrentBranch(dtRow)


        Home.MdiParent = Me.MdiParent
        Home.Dock = DockStyle.Fill
        Home.Show()
        Me.Close()

    End Sub
End Class