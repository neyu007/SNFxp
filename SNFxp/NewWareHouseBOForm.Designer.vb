<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewWareHouseBOForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
            SingleFormClass.newWarehouseBOForm = Nothing
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim WarehouseBOInfoIDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewWareHouseBOForm))
        Me.WarehouseBODataSet = New SNFxp.WarehouseBODataSet()
        Me.WareHouseBOInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WareHouseBOInfoTableAdapter = New SNFxp.WarehouseBODataSetTableAdapters.WareHouseBOInfoTableAdapter()
        Me.TableAdapterManager = New SNFxp.WarehouseBODataSetTableAdapters.TableAdapterManager()
        Me.WarehouseBOLineItemsTableAdapter = New SNFxp.WarehouseBODataSetTableAdapters.WarehouseBOLineItemsTableAdapter()
        Me.WareHouseBOInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.WareHouseBOInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WarehouseBOInfoIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesAgentDataSet = New SNFxp.SalesAgentDataSet()
        Me.WarehouseBOLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WarehouseBOLineItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New SNFxp.ProductsDataSet()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchTableAdapter = New SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter()
        Me.ProductsTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        WarehouseBOInfoIDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        CType(Me.WarehouseBODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WareHouseBOInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WareHouseBOInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WareHouseBOInfoBindingNavigator.SuspendLayout()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseBOLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseBOLineItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WarehouseBOInfoIDLabel
        '
        WarehouseBOInfoIDLabel.AutoSize = True
        WarehouseBOInfoIDLabel.Location = New System.Drawing.Point(25, 43)
        WarehouseBOInfoIDLabel.Name = "WarehouseBOInfoIDLabel"
        WarehouseBOInfoIDLabel.Size = New System.Drawing.Size(115, 13)
        WarehouseBOInfoIDLabel.TabIndex = 1
        WarehouseBOInfoIDLabel.Text = "Warehouse BOInfo ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(25, 70)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(360, 70)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(58, 13)
        BranchIDLabel.TabIndex = 5
        BranchIDLabel.Text = "Branch ID:"
        '
        'WarehouseBODataSet
        '
        Me.WarehouseBODataSet.DataSetName = "WarehouseBODataSet"
        Me.WarehouseBODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WareHouseBOInfoBindingSource
        '
        Me.WareHouseBOInfoBindingSource.DataMember = "WareHouseBOInfo"
        Me.WareHouseBOInfoBindingSource.DataSource = Me.WarehouseBODataSet
        '
        'WareHouseBOInfoTableAdapter
        '
        Me.WareHouseBOInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = SNFxp.WarehouseBODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WareHouseBOInfoTableAdapter = Me.WareHouseBOInfoTableAdapter
        Me.TableAdapterManager.WarehouseBOLineItemsTableAdapter = Me.WarehouseBOLineItemsTableAdapter
        '
        'WarehouseBOLineItemsTableAdapter
        '
        Me.WarehouseBOLineItemsTableAdapter.ClearBeforeFill = True
        '
        'WareHouseBOInfoBindingNavigator
        '
        Me.WareHouseBOInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WareHouseBOInfoBindingNavigator.BindingSource = Me.WareHouseBOInfoBindingSource
        Me.WareHouseBOInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WareHouseBOInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WareHouseBOInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WareHouseBOInfoBindingNavigatorSaveItem})
        Me.WareHouseBOInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WareHouseBOInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WareHouseBOInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WareHouseBOInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WareHouseBOInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WareHouseBOInfoBindingNavigator.Name = "WareHouseBOInfoBindingNavigator"
        Me.WareHouseBOInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WareHouseBOInfoBindingNavigator.Size = New System.Drawing.Size(693, 25)
        Me.WareHouseBOInfoBindingNavigator.TabIndex = 0
        Me.WareHouseBOInfoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'WareHouseBOInfoBindingNavigatorSaveItem
        '
        Me.WareHouseBOInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WareHouseBOInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("WareHouseBOInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WareHouseBOInfoBindingNavigatorSaveItem.Name = "WareHouseBOInfoBindingNavigatorSaveItem"
        Me.WareHouseBOInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WareHouseBOInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WarehouseBOInfoIDTextBox
        '
        Me.WarehouseBOInfoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WareHouseBOInfoBindingSource, "WarehouseBOInfoID", True))
        Me.WarehouseBOInfoIDTextBox.Location = New System.Drawing.Point(146, 40)
        Me.WarehouseBOInfoIDTextBox.Name = "WarehouseBOInfoIDTextBox"
        Me.WarehouseBOInfoIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WarehouseBOInfoIDTextBox.TabIndex = 2
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WareHouseBOInfoBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(90, 66)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 4
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WareHouseBOInfoBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(424, 64)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.BranchIDComboBox.TabIndex = 6
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.SalesAgentDataSet
        '
        'SalesAgentDataSet
        '
        Me.SalesAgentDataSet.DataSetName = "SalesAgentDataSet"
        Me.SalesAgentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WarehouseBOLineItemsBindingSource
        '
        Me.WarehouseBOLineItemsBindingSource.DataMember = "FK_WarehouseBOLineItems_WarehouseBOLineItems"
        Me.WarehouseBOLineItemsBindingSource.DataSource = Me.WareHouseBOInfoBindingSource
        '
        'WarehouseBOLineItemsDataGridView
        '
        Me.WarehouseBOLineItemsDataGridView.AutoGenerateColumns = False
        Me.WarehouseBOLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WarehouseBOLineItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.WarehouseBOLineItemsDataGridView.DataSource = Me.WarehouseBOLineItemsBindingSource
        Me.WarehouseBOLineItemsDataGridView.Location = New System.Drawing.Point(25, 112)
        Me.WarehouseBOLineItemsDataGridView.Name = "WarehouseBOLineItemsDataGridView"
        Me.WarehouseBOLineItemsDataGridView.Size = New System.Drawing.Size(644, 237)
        Me.WarehouseBOLineItemsDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ProductsBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "ProductName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ProductID"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.ProductsDataSet
        '
        'ProductsDataSet
        '
        Me.ProductsDataSet.DataSetName = "ProductsDataSet"
        Me.ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ExpireDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ExpireDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(594, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(499, 375)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'NewWareHouseBOForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(693, 463)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.WarehouseBOLineItemsDataGridView)
        Me.Controls.Add(WarehouseBOInfoIDLabel)
        Me.Controls.Add(Me.WarehouseBOInfoIDTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Controls.Add(Me.WareHouseBOInfoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewWareHouseBOForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse BO Form"
        CType(Me.WarehouseBODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WareHouseBOInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WareHouseBOInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WareHouseBOInfoBindingNavigator.ResumeLayout(False)
        Me.WareHouseBOInfoBindingNavigator.PerformLayout()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseBOLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseBOLineItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WarehouseBODataSet As SNFxp.WarehouseBODataSet
    Friend WithEvents WareHouseBOInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WareHouseBOInfoTableAdapter As SNFxp.WarehouseBODataSetTableAdapters.WareHouseBOInfoTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.WarehouseBODataSetTableAdapters.TableAdapterManager
    Friend WithEvents WareHouseBOInfoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WareHouseBOInfoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WarehouseBOLineItemsTableAdapter As SNFxp.WarehouseBODataSetTableAdapters.WarehouseBOLineItemsTableAdapter
    Friend WithEvents WarehouseBOInfoIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WarehouseBOLineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WarehouseBOLineItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SalesAgentDataSet As SNFxp.SalesAgentDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ProductsDataSet As SNFxp.ProductsDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
