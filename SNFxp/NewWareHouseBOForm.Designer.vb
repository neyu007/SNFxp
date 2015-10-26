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
        Dim DateLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewWareHouseBOForm))
        Me.WarehouseBODataSet = New SNFxp.WarehouseBODataSet()
        Me.WareHouseBOInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WareHouseBOInfoTableAdapter = New SNFxp.WarehouseBODataSetTableAdapters.WareHouseBOInfoTableAdapter()
        Me.TableAdapterManager = New SNFxp.WarehouseBODataSetTableAdapters.TableAdapterManager()
        Me.WarehouseBOLineItemsTableAdapter = New SNFxp.WarehouseBODataSetTableAdapters.WarehouseBOLineItemsTableAdapter()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesAgentDataSet = New SNFxp.SalesAgentDataSet()
        Me.WarehouseBOLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WarehouseBOLineItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New SNFxp.ProductsDataSet()
        Me.BranchTableAdapter = New SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter()
        Me.ProductsTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tbTotalAmount = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tbtotalQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LookupProductsDataSet = New SNFxp.LookupProductsDataSet()
        Me.ProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductListTableAdapter = New SNFxp.LookupProductsDataSetTableAdapters.ProductListTableAdapter()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DateLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        CType(Me.WarehouseBODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WareHouseBOInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseBOLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseBOLineItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(25, 54)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(360, 54)
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
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WareHouseBOInfoBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(90, 50)
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
        Me.BranchIDComboBox.Location = New System.Drawing.Point(424, 48)
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
        Me.WarehouseBOLineItemsDataGridView.Location = New System.Drawing.Point(25, 96)
        Me.WarehouseBOLineItemsDataGridView.Name = "WarehouseBOLineItemsDataGridView"
        Me.WarehouseBOLineItemsDataGridView.Size = New System.Drawing.Size(644, 237)
        Me.WarehouseBOLineItemsDataGridView.TabIndex = 7
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
        Me.btnSave.Location = New System.Drawing.Point(594, 396)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(499, 396)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tbTotalAmount
        '
        Me.tbTotalAmount.Location = New System.Drawing.Point(541, 352)
        Me.tbTotalAmount.Name = "tbTotalAmount"
        Me.tbTotalAmount.Size = New System.Drawing.Size(128, 20)
        Me.tbTotalAmount.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(28, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(640, 19)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "WAREHOUSE BO"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbtotalQty
        '
        Me.tbtotalQty.Location = New System.Drawing.Point(326, 352)
        Me.tbtotalQty.Name = "tbtotalQty"
        Me.tbtotalQty.Size = New System.Drawing.Size(128, 20)
        Me.tbtotalQty.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(460, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Total Quantity:"
        '
        'LookupProductsDataSet
        '
        Me.LookupProductsDataSet.DataSetName = "LookupProductsDataSet"
        Me.LookupProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductListBindingSource
        '
        Me.ProductListBindingSource.DataMember = "ProductList"
        Me.ProductListBindingSource.DataSource = Me.LookupProductsDataSet
        '
        'ProductListTableAdapter
        '
        Me.ProductListTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ProductListBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "ProductName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ProductID"
        Me.DataGridViewTextBoxColumn3.Width = 150
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
        'NewWareHouseBOForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(693, 463)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbtotalQty)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tbTotalAmount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.WarehouseBOLineItemsDataGridView)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewWareHouseBOForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse BO Form"
        CType(Me.WarehouseBODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WareHouseBOInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseBOLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseBOLineItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WarehouseBODataSet As SNFxp.WarehouseBODataSet
    Friend WithEvents WareHouseBOInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WareHouseBOInfoTableAdapter As SNFxp.WarehouseBODataSetTableAdapters.WareHouseBOInfoTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.WarehouseBODataSetTableAdapters.TableAdapterManager
    Friend WithEvents WarehouseBOLineItemsTableAdapter As SNFxp.WarehouseBODataSetTableAdapters.WarehouseBOLineItemsTableAdapter
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tbTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tbtotalQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ProductListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LookupProductsDataSet As SNFxp.LookupProductsDataSet
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductListTableAdapter As SNFxp.LookupProductsDataSetTableAdapters.ProductListTableAdapter
End Class
