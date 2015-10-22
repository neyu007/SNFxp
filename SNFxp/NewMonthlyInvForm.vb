Public Class NewMonthlyInvForm

#Region "Variables"
    Private branchID As Integer = getCurrentBranch().BranchID
    Dim functions As New Functions
#End Region

#Region "Navigator"
    Private Sub StartingInventoryInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StartingInventoryInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductsDataSet)

    End Sub

    Private Sub StartingInventoryInfoBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles StartingInventoryInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StartingInventoryInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductsDataSet)
    End Sub

#End Region

#Region "Form Load"

    Private Sub NewMonthlyInvForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'ProductsDataSet.ProductPricing' table. You can move, or remove it, as needed.
            Me.ProductPricingTableAdapter.Fill(Me.ProductsDataSet.ProductPricing)
            'TODO: This line of code loads data into the 'ProductsDataSet.Products' table. You can move, or remove it, as needed.
            Me.ProductsTableAdapter.Fill(Me.ProductsDataSet.Products)

            'TODO: This line of code loads data into the 'SNFDatabaseDataSet.Branch' table. You can move, or remove it, as needed.
            Me.BranchTableAdapter.Fill(Me.SNFDatabaseDataSet.Branch)
            'TODO: This line of code loads data into the 'ProductsDataSet.StartingInventoryInfo' table. You can move, or remove it, as needed.
            Me.StartingInventoryInfoTableAdapter.Fill(Me.ProductsDataSet.StartingInventoryInfo)
            'TODO: This line of code loads data into the 'ProductsDataSet.StartingInventoryLineItems' table. You can move, or remove it, as needed.
            Me.StartingInventoryLineItemsTableAdapter.Fill(Me.ProductsDataSet.StartingInventoryLineItems)
            Me.AddNew()
        Catch ex As Exception

        End Try

        'Me.StartingInventoryLineItemsDataGridView.Columns(5).DefaultCellStyle.Format = "MM/dd/yyyy"


    End Sub

#End Region

#Region "DataGridView"

    Private Sub StartingInventoryLineItemsDataGridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles StartingInventoryLineItemsDataGridView.CellValidating
        Me.StartingInventoryLineItemsDataGridView.Rows(e.RowIndex).ErrorText = ""
        Dim newInteger As Integer

        ' Don't try to validate the 'new row' until finished  
        ' editing since there 
        ' is not any point in validating its initial value. 
        If StartingInventoryLineItemsDataGridView.Rows(e.RowIndex).IsNewRow Then Return
        If e.ColumnIndex = 1 Then
            If Not Integer.TryParse(e.FormattedValue.ToString(), newInteger) _
            OrElse newInteger < 0 Then

                e.Cancel = True
                Me.StartingInventoryLineItemsDataGridView.Rows(e.RowIndex).ErrorText = "the value must be a non-negative integer"

            End If

        ElseIf e.ColumnIndex = 6 Then
            If Not IsDate(e.FormattedValue.ToString) _
                OrElse e.FormattedValue.ToString.Equals("") Then
                e.Cancel = True
                Me.StartingInventoryLineItemsDataGridView.Rows(e.RowIndex).ErrorText = "Invalid Date"
            End If
        End If


    End Sub
    Private Sub StartingInventoryLineItemsDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles StartingInventoryLineItemsDataGridView.CellValueChanged
        Try
            If e.RowIndex >= 0 Then
                Dim prodTable As DataTable = Me.ProductsDataSet.Tables("Products")
                Dim qProdRow() As DataRow
                'Dim prodID As Integer = Val(Me.StartingInventoryLineItemsDataGridView(0, e.RowIndex).Value)
                'MsgBox(prodID)
                qProdRow = prodTable.Select("ProductID=" & Val(Me.StartingInventoryLineItemsDataGridView(0, e.RowIndex).Value))

                If e.ColumnIndex = 0 Then
                    Dim dTable As DataTable = Me.ProductsDataSet.Tables("ProductPricing")
                    Dim qPriceRow() As DataRow
                    'MsgBox(e.ColumnIndex & " " & e.RowIndex)
                    qPriceRow = dTable.Select("ProductID=" & Val(Me.StartingInventoryLineItemsDataGridView(e.ColumnIndex, e.RowIndex).Value) & "AND BranchID=" & branchID)

                    If qPriceRow.Count > 0 Then
                        Me.StartingInventoryLineItemsDataGridView("UnitPrice", e.RowIndex).Value = qPriceRow(0)("UnitPrice")

                        If Not Me.StartingInventoryLineItemsDataGridView("Quantity", e.RowIndex).Value Is Nothing And _
                            Not IsDBNull(Me.StartingInventoryLineItemsDataGridView("Quantity", e.RowIndex).Value) Then
                            Me.StartingInventoryLineItemsDataGridView("Amount", e.RowIndex).Value = Me.StartingInventoryLineItemsDataGridView("Quantity", e.RowIndex).Value * Me.StartingInventoryLineItemsDataGridView("UnitPrice", e.RowIndex).Value
                        End If
                    End If
                    If qProdRow.Count > 0 Then
                        If Not Me.StartingInventoryLineItemsDataGridView("qtyInCase", e.RowIndex).Value Is Nothing And _
                        Not IsDBNull(Me.StartingInventoryLineItemsDataGridView(0, e.RowIndex).Value) Then
                            Me.StartingInventoryLineItemsDataGridView("Quantity", e.RowIndex).Value = qProdRow(0)("Packaging") * _
                               Me.StartingInventoryLineItemsDataGridView("qtyInCase", e.RowIndex).Value + Me.StartingInventoryLineItemsDataGridView("QtyInPC", e.RowIndex).Value
                        End If
                    End If

                ElseIf e.ColumnIndex = 3 Then
                    If Not Me.StartingInventoryLineItemsDataGridView("Quantity", e.RowIndex).Value Is Nothing And _
                        Not IsDBNull(Me.StartingInventoryLineItemsDataGridView("UnitPrice", e.RowIndex).Value) Then
                        Me.StartingInventoryLineItemsDataGridView("Amount", e.RowIndex).Value = Me.StartingInventoryLineItemsDataGridView("Quantity", e.RowIndex).Value * Me.StartingInventoryLineItemsDataGridView("UnitPrice", e.RowIndex).Value
                    End If
                ElseIf e.ColumnIndex = 1 And Not IsDBNull(Me.StartingInventoryLineItemsDataGridView(0, e.RowIndex).Value) Then

                    If qProdRow.Count > 0 Then
                        If Not Me.StartingInventoryLineItemsDataGridView("qtyInCase", e.RowIndex).Value Is Nothing And _
                        Not IsDBNull(Me.StartingInventoryLineItemsDataGridView(0, e.RowIndex).Value) Then
                            Me.StartingInventoryLineItemsDataGridView("Quantity", e.RowIndex).Value = qProdRow(0)("Packaging") * _
                                Me.StartingInventoryLineItemsDataGridView("qtyInCase", e.RowIndex).Value + Me.StartingInventoryLineItemsDataGridView("QtyInPC", e.RowIndex).Value
                        End If
                    End If
                ElseIf e.ColumnIndex = 2 And Not IsDBNull(Me.StartingInventoryLineItemsDataGridView(0, e.RowIndex).Value) Then

                    If qProdRow.Count > 0 Then
                        If Not Me.StartingInventoryLineItemsDataGridView("qtyInCase", e.RowIndex).Value Is Nothing And _
                        Not IsDBNull(Me.StartingInventoryLineItemsDataGridView(0, e.RowIndex).Value) Then
                            Me.StartingInventoryLineItemsDataGridView("Quantity", e.RowIndex).Value = qProdRow(0)("Packaging") * _
                                Me.StartingInventoryLineItemsDataGridView("qtyInCase", e.RowIndex).Value + Me.StartingInventoryLineItemsDataGridView("QtyInPC", e.RowIndex).Value
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub StartingInventoryLineItemsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles StartingInventoryLineItemsDataGridView.DataError
        If e.ColumnIndex = 6 Then
            MsgBox("Invalid Date")

            'ElseIf e.ColumnIndex = 0 Then
            '    MsgBox("Pick a Product")
        End If

    End Sub



    Private Sub StartingInventoryLineItemsDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles StartingInventoryLineItemsDataGridView.EditingControlShowing
        Dim cb As ComboBox

        If TypeOf e.Control Is ComboBox Then
            cb = e.Control
            cb.DropDownWidth = 550
            cb.DropDownStyle = ComboBoxStyle.DropDown
            cb.AutoCompleteMode = AutoCompleteMode.Suggest
            cb.AutoCompleteSource = AutoCompleteSource.ListItems
        End If
    End Sub

    Private Sub StartingInventoryLineItemsDataGridView_Enter(sender As Object, e As EventArgs) Handles StartingInventoryLineItemsDataGridView.Enter
        Me.ValidateChildren()
        Me.StartingInventoryInfoBindingSource.EndEdit()
        'Me.StartingInventoryLineItemsBindingSource.CancelEdit()

        ' Me.StartingInventoryInfoTableAdapter.Update(Me.ProductsDataSet.StartingInventoryInfo)
    End Sub

    Private Sub StartingInventoryInfoBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles StartingInventoryInfoBindingSource.PositionChanged, StartingInventoryInfoBindingSource.CurrentChanged, StartingInventoryLineItemsBindingSource.PositionChanged
        If Me.StartingInventoryLineItemsBindingSource.Position > -1 Then
            Dim total As Double = 0
            Dim totalPC As Integer = 0

            For Each row As DataRowView In Me.StartingInventoryLineItemsBindingSource.List
                total += row!Amount
                totalPC += row!Quantity
            Next
            Me.tbTotalAmount.Text = Format(total, "c")
            Me.tbTotalPcs.Text = Format(totalPC, "N0")
        Else
            Me.tbTotalAmount.Text = ""
            Me.tbTotalPcs.Text = ""
        End If
    End Sub

#End Region

#Region "Buttons"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Me.Validate()
        Try
            Me.StartingInventoryInfoBindingSource.EndEdit()
            Me.StartingInventoryInfoTableAdapter.Update(Me.ProductsDataSet.StartingInventoryInfo)
            Me.StartingInventoryLineItemsBindingSource.EndEdit()
            Me.StartingInventoryLineItemsTableAdapter.Update(Me.ProductsDataSet.StartingInventoryLineItems)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Me.AddNew()
    End Sub

#End Region

#Region "Form CLosing"
    Private Sub NewMonthlyInvForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As Integer = MsgBox("Close without saving?", MsgBoxStyle.OkCancel, "Closing")
        If result = MsgBoxResult.Ok Then
            ' StartingInventoryInfoBindingSource.RemoveCurrent()
            Me.StartingInventoryInfoBindingSource.CancelEdit()
            Me.StartingInventoryLineItemsBindingSource.CancelEdit()
            'Me.StartingInventoryInfoTableAdapter.Update(Me.ProductsDataSet.StartingInventoryInfo)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
#End Region

    'Private Sub StartingInventoryLineItemsDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles StartingInventoryLineItemsDataGridView.EditingControlShowing

    '    If Me.StartingInventoryLineItemsDataGridView.CurrentCell.ColumnIndex = 1 Then
    '        Dim txtQty As TextBox = e.Control
    '        RemoveHandler txtQty.KeyPress, AddressOf Keypress_GridViewCell
    '        AddHandler txtQty.KeyPress, AddressOf Keypress_GridViewCell
    '    Else
    '        Dim ctrl As Control = e.Control
    '        If (ctrl.GetType) Is GetType(TextBox) Then
    '            Dim txtQty As TextBox = e.Control
    '            RemoveHandler txtQty.KeyPress, AddressOf Keypress_GridViewCell
    '            'RemoveHandler txtQty.Click, AddressOf Keypress_GridViewCell
    '        End If
    '    End If

    'End Sub



    'Private Sub Keypress_GridViewCell(ByVal sender As Object, ByVal e As KeyPressEventArgs)
    '    Me.functions.KeyPressNumeric(e)
    'End Sub
    'Private Sub StartingInventoryLineItemsDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles StartingInventoryLineItemsDataGridView.EditingControlShowing
    '    Dim cb As ComboBox
    '    Dim tb As TextBox



    '    If TypeOf e.Control Is ComboBox Then
    '        cb = e.Control

    '        cb.DropDownStyle = ComboBoxStyle.DropDownList
    '        'cb.DropDownWidth =
    '        cb.AutoCompleteMode = AutoCompleteMode.Suggest
    '        cb.AutoCompleteSource = AutoCompleteSource.ListItems

    '        RemoveHandler cb.SelectedIndexChanged, _
    '        New EventHandler(AddressOf ComboBox_SelectedIndexChanged)

    '        ' Add the event handler. 
    '        AddHandler cb.SelectedIndexChanged, _
    '            New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
    '        'ElseIf TypeOf e.Control Is TextBox Then
    '        '    tb = e.Control

    '        '    tb.AutoCompleteMode = AutoCompleteMode.Suggest

    '        '    RemoveHandler tb.MouseClick, New MouseEventHandler(AddressOf TextBox_MouseClick)
    '        '    AddHandler tb.MouseClick, New MouseEventHandler(AddressOf TextBox_MouseClick)

    '    End If
    'End Sub

    'Private Sub TextBox_MouseClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim tb1 As TextBox = CType(sender, TextBox)
    '    Dim cb01 As DataGridViewComboBoxCell

    '    RemoveHandler tb1.MouseClick, New MouseEventHandler(AddressOf TextBox_MouseClick)

    '    cb01 = Me.StartingInventoryLineItemsDataGridView.CurrentRow.Cells("dgvcbProductID")
    '    MsgBox(cb01.Value)

    '    'Dim pricelist As New AutoCompleteStringCollection()
    '    'For Each itemPrice As LookupPricingDataSet.ItemPricingRow In Me.LookupPricingDataSet.ItemPricing
    '    '    If itemPrice.ItemID.Equals(CType(cb01.ColumnIndex, Integer)) Then
    '    '        pricelist.Add(itemPrice.Price)
    '    '    End If
    '    'Next

    'End Sub

    'Private Sub ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim cb1 As ComboBox = CType(sender, ComboBox)
    '    'MsgBox(cb1.SelectedValue)
    '    RemoveHandler cb1.SelectedIndexChanged, _
    '       New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
    '    Dim tbcPrice As DataGridViewTextBoxCell
    '    tbcPrice = Me.StartingInventoryLineItemsDataGridView.CurrentRow.Cells("ColumnPrice")



    '    'Dim tbPrice As TextBox
    '    'tbPrice = DirectCast(tbcPrice, TextBox)



    '    Dim pricelist As New AutoCompleteStringCollection()
    '    For Each itemPrice As ProductsDataSet.ProductPricingRow In Me.ProductsDataSet.ProductPricing
    '        If itemPrice.ProductID.Equals(CType(cb1.SelectedValue, Integer)) Then
    '            pricelist.Add(itemPrice.UnitPrice)
    '        End If
    '    Next
    '    MsgBox(pricelist.Count)
    '    'Me.TextBox1.AutoCompleteCustomSource = pricelist
    '    'Me.TextBox1.Text = pricelist.Item(0)
    '    'tbcPrice.
    '    tbcPrice.Value = CType(pricelist.Item(0), Double)

    '    'tbcPrice.Value = 123
    'End Sub

#Region "Create New Inventory"
    Private Sub AddNew()
        ' Me.StartingInventoryLineItemsDataGridView.TabStop = False
        If Me.ProductsDataSet.HasChanges() Then
            Dim result As Integer = MsgBox("Discard Changes?", MsgBoxStyle.OkCancel, "Notice")
            If result = MsgBoxResult.Ok Then
                Me.StartingInventoryInfoBindingSource.CancelEdit()
                Me.StartingInventoryLineItemsBindingSource.CancelEdit()
                Me.StartingInventoryInfoBindingSource.AddNew()
            End If

        Else
            Me.StartingInventoryInfoBindingSource.AddNew()
            Try
                'If getCurrentBranch().IsNull("BranchID") Then
                '    branchID = 1
                'Else
                '    branchID = getCurrentBranch.BranchID
                'End If
                Me.BranchIDComboBox.SelectedValue = branchID
                Me.BranchIDComboBox.Enabled = False
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            Me.InventoryDateDateTimePicker.Value = DateTime.Today
            Me.InventoryMonthDateTimePicker.Value = DateTime.Today
        End If


    End Sub
#End Region
   

    Private Sub InventoryDateDateTimePicker_Enter(sender As Object, e As EventArgs) Handles InventoryDateDateTimePicker.Enter
        Me.StartingInventoryLineItemsDataGridView.TabStop = True
    End Sub

    Private Function IsDateGood(ByRef cell As DataGridViewCell) As Boolean

        If cell.Value Is Nothing Then
            cell.ErrorText = "Missing date"
            Me.StartingInventoryLineItemsDataGridView.Rows(cell.RowIndex).ErrorText = _
                "Missing date"
            Return False
        Else
            Try
                DateTime.Parse(cell.Value.ToString())
            Catch ex As FormatException

                cell.ErrorText = "Invalid format"
                Me.StartingInventoryLineItemsDataGridView.Rows(cell.RowIndex).ErrorText = _
                    "Invalid format"

                Return False
            End Try
        End If
        Return True
    End Function


 
End Class