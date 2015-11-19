Public Class NewInvoiceForm

    Private Sub SalesInvoiceInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SalesInvoiceInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InvoiceDataSet)

    End Sub

    Private Sub NewInvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.Areas' table. You can move, or remove it, as needed.
        Me.AreasTableAdapter.Fill(Me.CustomersDataSet.Areas)
        'TODO: This line of code loads data into the 'TrucksDataSet.Trucks' table. You can move, or remove it, as needed.
        Me.TrucksTableAdapter.FillByBranchID(Me.TrucksDataSet.Trucks, getCurrentBranch.BranchID)
        'TODO: This line of code loads data into the 'SalesAgentDataSet.SalesAgent' table. You can move, or remove it, as needed.
        Me.SalesAgentTableAdapter.FillByBranchID(Me.SalesAgentDataSet.SalesAgent, getCurrentBranch.BranchID)
        'TODO: This line of code loads data into the 'CustomersDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.FillByBranchID(Me.CustomersDataSet.Branch, getCurrentBranch.BranchID)
        'TODO: This line of code loads data into the 'CustomersDataSet.Terms' table. You can move, or remove it, as needed.
        Me.TermsTableAdapter.Fill(Me.CustomersDataSet.Terms)
        'TODO: This line of code loads data into the 'CustomersDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.FillByBranchID(Me.CustomersDataSet.Customers, getCurrentBranch.BranchID)

        'TODO: This line of code loads data into the 'InvoiceDataSet.SalesInvoiceInfo' table. You can move, or remove it, as needed.
        Me.SalesInvoiceInfoTableAdapter.Fill(Me.InvoiceDataSet.SalesInvoiceInfo)
        'TODO: This line of code loads data into the 'InvoiceDataSet.SalesInvoiceLineItems' table. You can move, or remove it, as needed.
        Me.SalesInvoiceLineItemsTableAdapter.Fill(Me.InvoiceDataSet.SalesInvoiceLineItems)

        If UserModule.isNewInvoice Then
            Me.SalesInvoiceInfoBindingSource.AddNew()
        End If
    End Sub
   
    Private Sub btnNewTruck_Click(sender As Object, e As EventArgs) Handles btnNewTruck.Click
        Dim newTruck As New NewTruckForm
        newTruck.ShowDialog()
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        If SingleFormClass.newCustomerForm Is Nothing Then
            SingleFormClass.newCustomerForm = New NewCustomerForm
        End If
        SingleFormClass.newCustomerForm.MdiParent = Me.MdiParent
        SingleFormClass.newCustomerForm.Show()
        SingleFormClass.newCustomerForm.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class