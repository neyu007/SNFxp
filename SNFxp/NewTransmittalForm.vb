Public Class NewTransmittalForm

    Private branchID As Integer = getCurrentBranch().BranchID

    Private Sub TransmittalInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TransmittalInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TransmittalInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransmittalDataSet)

    End Sub
#Region "FormLOAD"
    Private Sub NewTransmittalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransmittalDataSet.Trucks' table. You can move, or remove it, as needed.
        Me.TrucksTableAdapter.FillByBranchID(Me.TransmittalDataSet.Trucks, branchID)
        'TODO: This line of code loads data into the 'LookupProductsDataSet.ProductPricing' table. You can move, or remove it, as needed.
        Me.ProductPricingTableAdapter.Fill(Me.LookupProductsDataSet.ProductPricing)
        'TODO: This line of code loads data into the 'LookupProductsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.LookupProductsDataSet.Products)
        'TODO: This line of code loads data into the 'SalesAgentDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter1.FillByMyBranchID(Me.SalesAgentDataSet.Branch, branchID)
        'TODO: This line of code loads data into the 'TransmittalDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.FillByNotMyBranchID(Me.TransmittalDataSet.Branch, branchID)

        'TODO: This line of code loads data into the 'TransmittalDataSet.TransmittalInfo' table. You can move, or remove it, as needed.
        Me.TransmittalInfoTableAdapter.Fill(Me.TransmittalDataSet.TransmittalInfo)
        'TODO: This line of code loads data into the 'TransmittalDataSet.TransmittalLineItems' table. You can move, or remove it, as needed.
        Me.TransmittalLineItemsTableAdapter.Fill(Me.TransmittalDataSet.TransmittalLineItems)
        Me.AddNew()

    End Sub

    Private Sub AddNew()
        Me.TransmittalInfoBindingSource.AddNew()
        Me.DateOfReceiveDateTimePicker.Value = DateTime.Now
        Me.DateOfTransmitDateTimePicker.Value = DateTime.Now
        Me.BranchIDComboBox.SelectedValue = branchID
    End Sub
#End Region
#Region "DataGridView"

    Private Sub TransmittalLineItemsDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TransmittalLineItemsDataGridView.CellValueChanged
        Try
            If e.RowIndex >= 0 Then
                Dim prodTable As DataTable = Me.LookupProductsDataSet.Tables("Products")
                Dim qProdRow() As DataRow
                qProdRow = prodTable.Select("ProductID=" & Val(Me.TransmittalLineItemsDataGridView(0, e.RowIndex).Value))

                If e.ColumnIndex = 0 Then

                    Dim dTable As DataTable = Me.LookupProductsDataSet.Tables("ProductPricing")
                    Dim qPriceRow() As DataRow
                    qPriceRow = dTable.Select("ProductID=" & Val(Me.TransmittalLineItemsDataGridView(e.ColumnIndex, e.RowIndex).Value) & " AND BranchID=" & branchID)
                    'MsgBox("ProductID=" & Val(Me.ShipmentLineItemsDataGridView(e.ColumnIndex, e.RowIndex).Value) & " AND BranchID=" & branchID)
                    '  MsgBox("ProdID: " & Val(Me.TransmittalLineItemsDataGridView(e.ColumnIndex, e.RowIndex).Value) & " Count:" & qPriceRow.Count & "AND BranchID=" & branchID)
                    If qPriceRow.Count > 0 Then
                        Me.TransmittalLineItemsDataGridView("UnitPrice", e.RowIndex).Value = qPriceRow(0)("UnitPrice")
                        If Not Me.TransmittalLineItemsDataGridView("QtyPiece", e.RowIndex).Value Is Nothing And _
                            Not IsDBNull(Me.TransmittalLineItemsDataGridView("QtyPiece", e.RowIndex).Value) Then
                            Me.TransmittalLineItemsDataGridView("Amount", e.RowIndex).Value = Me.TransmittalLineItemsDataGridView("QtyPiece", e.RowIndex).Value * Me.TransmittalLineItemsDataGridView("UnitPrice", e.RowIndex).Value

                        End If
                    End If
                    If qProdRow.Count > 0 Then
                        If Not Me.TransmittalLineItemsDataGridView("QtyCase", e.RowIndex).Value Is Nothing And _
                        Not IsDBNull(Me.TransmittalLineItemsDataGridView(0, e.RowIndex).Value) Then
                            Me.TransmittalLineItemsDataGridView("QtyPiece", e.RowIndex).Value = qProdRow(0)("Packaging") * _
                                Me.TransmittalLineItemsDataGridView("QtyCase", e.RowIndex).Value
                        End If
                    End If
                ElseIf e.ColumnIndex = 1 Then

                    If qProdRow.Count > 0 Then
                        Me.TransmittalLineItemsDataGridView("QtyPiece", e.RowIndex).Value = qProdRow(0)("Packaging") * _
                                Me.TransmittalLineItemsDataGridView("QtyCase", e.RowIndex).Value

                    End If
                ElseIf e.ColumnIndex = 2 Then

                    If qProdRow.Count > 0 Then
                        Me.TransmittalLineItemsDataGridView("Amount", e.RowIndex).Value = Me.TransmittalLineItemsDataGridView("UnitPrice", e.RowIndex).Value * _
                                Me.TransmittalLineItemsDataGridView("QtyPiece", e.RowIndex).Value

                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TransmittalLineItemsDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles TransmittalLineItemsDataGridView.EditingControlShowing
        Dim cb As ComboBox

        If TypeOf e.Control Is ComboBox Then
            cb = e.Control
            cb.DropDownWidth = 550
            cb.DropDownStyle = ComboBoxStyle.DropDown
            cb.AutoCompleteMode = AutoCompleteMode.Suggest
            cb.AutoCompleteSource = AutoCompleteSource.ListItems
        End If
    End Sub
    Private Sub TransmittalLineItemsDataGridView_Enter(sender As Object, e As EventArgs) Handles TransmittalLineItemsDataGridView.Enter
        Me.Validate()
        ' MsgBox(Me.DateOfReceiveDateTimePicker.Value.ToString)
        Me.TransmittalInfoBindingSource.EndEdit()
    End Sub

#End Region




    Private Sub TransmittalLineItemsBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles TransmittalLineItemsBindingSource.PositionChanged
        If Me.TransmittalLineItemsBindingSource.Position > -1 Then
            Dim total As Double = 0
            Dim totalPC As Integer = 0
            Dim totalCS As Integer = 0

            For Each row As DataRowView In Me.TransmittalLineItemsBindingSource.List
                total += row!Amount
                totalPC += row!QtyPiece
                totalCS += row!QtyCase
            Next
            Me.tbTotalAmount.Text = Format(total, "N2")
            Me.tbTotalPiece.Text = Format(totalPC, "N0")
            Me.tbTotalCase.Text = Format(totalCS, "N0")
        Else
            Me.tbTotalAmount.Text = ""
            Me.tbTotalPiece.Text = ""
            Me.tbTotalCase.Text = ""
        End If
    End Sub

#Region "Buttons"
    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        Me.Validate()
        Try
            Me.TransmittalInfoBindingSource.EndEdit()
            Me.TransmittalInfoTableAdapter.Update(Me.TransmittalDataSet.TransmittalInfo)
            Me.TransmittalLineItemsBindingSource.EndEdit()
            Me.TransmittalLineItemsTableAdapter.Update(Me.TransmittalDataSet.TransmittalLineItems)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

    Private Sub btnNewTruck_Click(sender As Object, e As EventArgs) Handles btnNewTruck.Click
        Dim newTruckForm As New NewTruckForm
        newTruckForm.ShowDialog()
        Me.TrucksTableAdapter.FillByBranchID(Me.TransmittalDataSet.Trucks, branchID)
        Me.TruckIDComboBox.SelectedValue = getCurrentTruckID()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.AddNew()
    End Sub
End Class