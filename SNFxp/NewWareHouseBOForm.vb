Public Class NewWareHouseBOForm
    Private branchID As Integer = getCurrentBranch.BranchID
    Private Sub WareHouseBOInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WareHouseBOInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WareHouseBOInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WarehouseBODataSet)

    End Sub

    Private Sub NewWareHouseBOForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.ProductsDataSet.Products)
        'TODO: This line of code loads data into the 'SalesAgentDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.FillByMyBranchID(Me.SalesAgentDataSet.Branch, branchID)
        'TODO: This line of code loads data into the 'WarehouseBODataSet.WareHouseBOInfo' table. You can move, or remove it, as needed.
        Me.WareHouseBOInfoTableAdapter.Fill(Me.WarehouseBODataSet.WareHouseBOInfo)
        'TODO: This line of code loads data into the 'WarehouseBODataSet.WarehouseBOLineItems' table. You can move, or remove it, as needed.
        Me.WarehouseBOLineItemsTableAdapter.Fill(Me.WarehouseBODataSet.WarehouseBOLineItems)
        Me.WareHouseBOInfoBindingSource.AddNew()
        Me.BranchIDComboBox.SelectedValue = branchID
        Me.DateDateTimePicker.Value = DateTime.Now
    End Sub
End Class