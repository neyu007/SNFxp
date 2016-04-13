Public Class AddPaymentForm
    Dim dt As DataTable
    Dim row() As DataRow

    Private Sub AddPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.FillByBranchID(Me.CustomersDataSet.Customers, getCurrentBranch.BranchID)
        Me.customerChanged()
        dt = New DataTable




    End Sub

    Private Sub CustomerIDComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles CustomerIDComboBox.SelectedValueChanged
        customerChanged()

    End Sub

    Private Sub customerChanged()
        Call SQLconnect()

        Try
            dt = getDRNo(Me.CustomerIDComboBox.SelectedValue)
            row = dt.Select()
            Me.DRNoComboBox.DataSource = dt
            Me.DRNoComboBox.DisplayMember = dt.Columns("DRNo").ToString()

            ' Me.tbPrevBalance.Text = row(Me.CustomerIDComboBox.SelectedIndex).Item("Balance")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Me.DRNoComboBox.SelectedIndex = -1
        Me.DRNoComboBox.ResetText()
        Me.tbPrevBalance.Text = ""
        Me.AmountTextBox.Text = ""
    End Sub

    Private Sub DRNoChange()
        If Me.CustomerIDComboBox.SelectedIndex > -1 Then
            'Call SQLconnect()

            Try
                'dt = getDRNo(Me.CustomerIDComboBox.SelectedValue)
                ' row = dt.Select()
                ' Me.DRNoComboBox.DataSource = dt
                'Me.DRNoComboBox.DisplayMember = dt.Columns("DRNo").ToString()

                Me.tbPrevBalance.Text = row(Me.DRNoComboBox.SelectedIndex).Item("Balance")
                Me.AmountTextBox.Text = row(Me.DRNoComboBox.SelectedIndex).Item("Balance")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If

    End Sub

    Private Sub DRNoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DRNoComboBox.SelectedIndexChanged
        DRNoChange()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        MsgBox("Not yet Implemented")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
    End Sub

End Class