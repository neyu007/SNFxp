Public Class NewWareHouseBOForm
    Private branchID As Integer = getCurrentBranch.BranchID
    Private Sub WareHouseBOInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WareHouseBOInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WarehouseBODataSet)

    End Sub

    Private Sub NewWareHouseBOForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.ProductsDataSet.Products)
        Me.ProductListTableAdapter.FillByBranchIDandPriceLevelID(Me.LookupProductsDataSet.ProductList, 1, getCurrentBranch.BranchID)
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

    Private Sub WarehouseBOLineItemsDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles WarehouseBOLineItemsDataGridView.EditingControlShowing
        Dim cb As ComboBox
        If TypeOf e.Control Is ComboBox Then
            cb = e.Control
            cb.DropDownWidth = 200
            cb.DropDownStyle = ComboBoxStyle.DropDown
            cb.AutoCompleteMode = AutoCompleteMode.Suggest
            cb.AutoCompleteSource = AutoCompleteSource.ListItems
        End If
    End Sub
End Class