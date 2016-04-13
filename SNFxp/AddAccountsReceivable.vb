Public Class AddAccountsReceivable


    Private Sub AddAccountsReceivable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.FillByBranchID(Me.CustomersDataSet.Customers, getCurrentBranch.BranchID)
        Me.CustomerIDComboBox.SelectedIndex = -1
        'TODO: This line of code loads data into the 'TermsDataSet.Terms' table. You can move, or remove it, as needed.
        Me.TermsTableAdapter.Fill(Me.TermsDataSet.Terms)
        'TODO: This line of code loads data into the 'SalesAgentDataSet.SalesAgent' table. You can move, or remove it, as needed.
        Me.SalesAgentTableAdapter.FillByBranchID(Me.SalesAgentDataSet.SalesAgent, getCurrentBranch.BranchID)
        'Call SQLconnect()
        'Call insertAR(1, 1, 2, 2, DateTime.Now, False, 1, 1, 123.5)
        'Dim i As Double = checkCustomerBalance(1)
        'Dim ii As Double = checkInvoiceBalance(2, 1)
        Me.DueDateDateTimePicker.Value = AccountsReceivableModule.getARDATE

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim Cid As Integer = Me.CustomerIDComboBox.SelectedValue
            Dim Tid As Integer = Me.TermsIDComboBox.SelectedValue
            Dim SAid As Integer = Me.SalesAgentIDComboBox.SelectedValue
            Dim DueDate As DateTime = Me.DueDateDateTimePicker.Value.Date
            Dim drNo As Integer = CInt(DRNoTextBox.Text)
            Dim amount As Double = Me.AmountTextBox.Text

            Call SQLconnect()
            Dim invBal As Double = AccountsReceivableModule.checkInvoiceBalance(drNo, getCurrentBranch.BranchID)
            If invBal <= 0 Then
                Call insertAR(Cid, 0, drNo, Tid, DueDate, False, getCurrentBranch.BranchID, SAid, amount)
                AccountsReceivableModule.setARDATE(Me.DueDateDateTimePicker.Value)
                Me.Close()
            Else
                MsgBox("Possible Duplicate: Balance(" & invBal & ")")
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        Dim newCustomer As NewCustomerForm = New NewCustomerForm
        If newCustomer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.CustomersTableAdapter.FillByBranchID(Me.CustomersDataSet.Customers, getCurrentBranch.BranchID)
            Me.CustomerIDComboBox.SelectedValue = UserModule.getCurrentCustomerID()
        End If

    End Sub

    'Private Sub CustomerIDComboBox_GotFocus(sender As Object, e As EventArgs) Handles CustomerIDComboBox.GotFocus
    '    Try
    '        Me.CustomersTableAdapter.FillByBranchID(Me.CustomersDataSet.Customers, getCurrentBranch.BranchID)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Private Sub btnNewTerms_Click(sender As Object, e As EventArgs) Handles btnNewTerms.Click
        Dim newTerms As NewTermForm = New NewTermForm
        newTerms.Show()
    End Sub


    Private Sub TermsIDComboBox_GotFocus(sender As Object, e As EventArgs) Handles TermsIDComboBox.GotFocus
        Me.TermsTableAdapter.Fill(Me.TermsDataSet.Terms)
    End Sub

    Private Sub SalesAgentIDComboBox_GotFocus(sender As Object, e As EventArgs) Handles SalesAgentIDComboBox.GotFocus
        Me.SalesAgentTableAdapter.FillByBranchID(Me.SalesAgentDataSet.SalesAgent, getCurrentBranch.BranchID)
    End Sub

    Private Sub btnNewSalesAgent_Click(sender As Object, e As EventArgs) Handles btnNewSalesAgent.Click
        Dim newSalesAgent As NewSalesAgentForm = New NewSalesAgentForm
        newSalesAgent.Show()
    End Sub
End Class