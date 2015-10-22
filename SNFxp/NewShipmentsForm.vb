Public Class NewShipmentsForm

    Private branchID As Integer = getCurrentBranch().BranchID
    Private Sub ShipmentInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ShipmentInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ShipmentsDataSet)

    End Sub
#Region "FormLOading"
    Private Sub NewShipmentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'ShipmentsDataSet.Branch' table. You can move, or remove it, as needed.
        'Me.BranchTableAdapter.Fill(Me.ShipmentsDataSet.Branch)
        ''TODO: This line of code loads data into the 'ShipmentsDataSet.ShipmentLineItems' table. You can move, or remove it, as needed.
        'Me.ShipmentLineItemsTableAdapter.Fill(Me.ShipmentsDataSet.ShipmentLineItems)
        ''TODO: This line of code loads data into the 'ShipmentsDataSet.ShipmentInfo' table. You can move, or remove it, as needed.
        'Me.ShipmentInfoTableAdapter.Fill(Me.ShipmentsDataSet.ShipmentInfo)

        Me.ProductPricingTableAdapter1.Fill(Me.ProductsDataSet.ProductPricing)
        Me.ProductsTableAdapter.Fill(Me.ProductsDataSet.Products)
        Me.BranchTableAdapter.Fill(Me.ShipmentsDataSet.Branch)
        Me.ShipmentInfoTableAdapter.Fill(Me.ShipmentsDataSet.ShipmentInfo)
        Me.ShipmentLineItemsTableAdapter.Fill(Me.ShipmentsDataSet.ShipmentLineItems)
        Me.ShipmentInfoBindingSource.AddNew()
        Me.ReceivedDateDateTimePicker.Value = DateTime.Now
        Me.ShipmentDateDateTimePicker.Value = DateTime.Now
        Me.BranchIDComboBox.SelectedValue = branchID
    End Sub
#End Region

#Region "datagridview"

    Private Sub ShipmentLineItemsDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles ShipmentLineItemsDataGridView.EditingControlShowing
        Dim cb As ComboBox

        If TypeOf e.Control Is ComboBox Then
            cb = e.Control
            cb.DropDownWidth = 550
            cb.DropDownStyle = ComboBoxStyle.DropDown
            cb.AutoCompleteMode = AutoCompleteMode.Suggest
            cb.AutoCompleteSource = AutoCompleteSource.ListItems
        End If
    End Sub

    Private Sub ShipmentLineItemsDataGridView_Enter(sender As Object, e As EventArgs) Handles ShipmentLineItemsDataGridView.Enter
        Me.Validate()
        Try
            Me.ShipmentInfoBindingSource.EndEdit()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

#Region "dataError"
    Private Sub ShipmentLineItemsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles ShipmentLineItemsDataGridView.DataError
        If e.ColumnIndex = 1 Then
            MsgBox("Must input a number.")
        End If
    End Sub
#End Region

#Region "cellValueChanged"
    Private Sub ShipmentLineItemsDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ShipmentLineItemsDataGridView.CellValueChanged
        Try
            If e.RowIndex >= 0 Then
                Dim prodTable As DataTable = Me.ProductsDataSet.Tables("Products")
                Dim qProdRow() As DataRow
                qProdRow = prodTable.Select("ProductID=" & Val(Me.ShipmentLineItemsDataGridView(0, e.RowIndex).Value))

                If e.ColumnIndex = 0 Then

                    Dim dTable As DataTable = Me.ProductsDataSet.Tables("ProductPricing")
                    Dim qPriceRow() As DataRow
                    qPriceRow = dTable.Select("ProductID=" & Val(Me.ShipmentLineItemsDataGridView(e.ColumnIndex, e.RowIndex).Value) & " AND BranchID=" & branchID)
                    'MsgBox("ProductID=" & Val(Me.ShipmentLineItemsDataGridView(e.ColumnIndex, e.RowIndex).Value) & " AND BranchID=" & branchID)
                    ' MsgBox("ProdID: " & Val(Me.ShipmentLineItemsDataGridView(e.ColumnIndex, e.RowIndex).Value) & " Count:" & qPriceRow.Count & "AND BranchID=" & branchID)
                    If qPriceRow.Count > 0 Then
                        Me.ShipmentLineItemsDataGridView("UnitPrice", e.RowIndex).Value = qPriceRow(0)("UnitPrice")
                        If Not Me.ShipmentLineItemsDataGridView("QtyPiece", e.RowIndex).Value Is Nothing And _
                            Not IsDBNull(Me.ShipmentLineItemsDataGridView("QtyPiece", e.RowIndex).Value) Then
                            Me.ShipmentLineItemsDataGridView("Amount", e.RowIndex).Value = Me.ShipmentLineItemsDataGridView("QtyPiece", e.RowIndex).Value * Me.ShipmentLineItemsDataGridView("UnitPrice", e.RowIndex).Value

                        End If
                    End If
                    If qProdRow.Count > 0 Then
                        If Not Me.ShipmentLineItemsDataGridView("QtyCase", e.RowIndex).Value Is Nothing And _
                        Not IsDBNull(Me.ShipmentLineItemsDataGridView(0, e.RowIndex).Value) Then
                            Me.ShipmentLineItemsDataGridView("QtyPiece", e.RowIndex).Value = qProdRow(0)("Packaging") * _
                                Me.ShipmentLineItemsDataGridView("QtyCase", e.RowIndex).Value
                        End If
                    End If
                ElseIf e.ColumnIndex = 1 Then

                    If qProdRow.Count > 0 Then
                        Me.ShipmentLineItemsDataGridView("QtyPiece", e.RowIndex).Value = qProdRow(0)("Packaging") * _
                                Me.ShipmentLineItemsDataGridView("QtyCase", e.RowIndex).Value

                    End If
                ElseIf e.ColumnIndex = 2 Then

                    If qProdRow.Count > 0 Then
                        Me.ShipmentLineItemsDataGridView("Amount", e.RowIndex).Value = Me.ShipmentLineItemsDataGridView("UnitPrice", e.RowIndex).Value * _
                                Me.ShipmentLineItemsDataGridView("QtyPiece", e.RowIndex).Value

                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Total"
    Private Sub ShipmentLineItemsBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles ShipmentLineItemsBindingSource.PositionChanged
        If Me.ShipmentLineItemsBindingSource.Position > -1 Then
            Dim total As Double = 0
            Dim totalPC As Integer = 0
            Dim totalCS As Integer = 0

            For Each row As DataRowView In Me.ShipmentLineItemsBindingSource.List
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
#End Region

#End Region

#Region "Buttons"
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            Me.ShipmentsDataSet.RejectChanges()
            Me.ShipmentInfoBindingSource.CancelEdit()
            Me.ShipmentInfoBindingSource.AddNew()
            Me.ReceivedDateDateTimePicker.Value = DateTime.Today
            Me.ShipmentDateDateTimePicker.Value = DateTime.Today
            Me.BranchIDComboBox.SelectedValue = branchID
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Me.ShipmentsDataSet.RejectChanges()
            Me.ShipmentInfoBindingSource.CancelEdit()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        Me.Validate()
        Try
            Me.ShipmentInfoBindingSource.EndEdit()
            Me.ShipmentInfoTableAdapter.Update(Me.ShipmentsDataSet.ShipmentInfo)
            Me.ShipmentLineItemsBindingSource.EndEdit()
            Me.ShipmentLineItemsTableAdapter.Update(Me.ShipmentsDataSet.ShipmentLineItems)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


 
End Class