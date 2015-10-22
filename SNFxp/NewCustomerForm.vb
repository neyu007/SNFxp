Public Class NewCustomerForm

    Private branchID As Integer = getCurrentBranch().BranchID

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomersDataSet)

    End Sub

    Private Sub NewCustomerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.StoreNameTextBox.CausesValidation = False
        e.Cancel = False
    End Sub


    Private Sub NewCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'CustomersDataSet.PriceLevel' table. You can move, or remove it, as needed.
            Me.PriceLevelTableAdapter.Fill(Me.CustomersDataSet.PriceLevel)
            'TODO: This line of code loads data into the 'CustomersDataSet.Terms' table. You can move, or remove it, as needed.
            Me.TermsTableAdapter.Fill(Me.CustomersDataSet.Terms)
            'TODO: This line of code loads data into the 'CustomersDataSet.Areas' table. You can move, or remove it, as needed.
            Me.AreasTableAdapter.FillByBranchID(Me.CustomersDataSet.Areas, branchID)
            'TODO: This line of code loads data into the 'CustomersDataSet.Branch' table. You can move, or remove it, as needed.
            Me.BranchTableAdapter.FillByBranchID(Me.CustomersDataSet.Branch, branchID)
            'TODO: This line of code loads data into the 'CustomersDataSet.Customers' table. You can move, or remove it, as needed.
            Me.CustomersTableAdapter.Fill(Me.CustomersDataSet.Customers)
            Me.CustomersBindingSource.AddNew()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        Me.ValidateChildren()
        If Me.isValid Then
            MsgBox("True")
        Else
            MsgBox("false")

        End If
    End Sub
    Private Function isValid() As Boolean
        Dim val As Boolean = False
        If Not Me.StoreNameTextBox.Text.Equals("") And
            Not Me.StoreNameTextBox.Text.StartsWith(" ") And
            Not Me.AddressTextBox.Text.Equals("") And
            Not Me.BranchIDComboBox.SelectedIndex = -1 And
            Not Me.AreaIDComboBox.SelectedIndex = -1 And
            Not Me.PriceLevelIDComboBox.SelectedIndex = -1 Then 'And
            'Not Me.TermsIDComboBox.SelectedIndex = -1 Then
            val = True
        End If
        Return val
    End Function

    Private Sub btnNewArea_Click(sender As Object, e As EventArgs) Handles btnNewArea.Click
        Dim newArea As New NewAreaForm
        If newArea.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            ' MsgBox("ok")
            Try
                Me.AreasTableAdapter.FillByBranchID(Me.CustomersDataSet.Areas, branchID)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

   
    Private Sub btnNewTerm_Click(sender As Object, e As EventArgs) Handles btnNewTerm.Click
        Dim newTerm As New NewTermForm
        If newTerm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            ' MsgBox("ok")

            Try
                Me.TermsTableAdapter.Fill(Me.CustomersDataSet.Terms)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
      
        End If
    End Sub
End Class