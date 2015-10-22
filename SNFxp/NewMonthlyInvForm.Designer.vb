<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMonthlyInvForm
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
            SingleFormClass.newMonthlyInvForm = Nothing
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
        Dim InventoryDateLabel As System.Windows.Forms.Label
        Dim InventoryMonthLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewMonthlyInvForm))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ProductsDataSet = New SNFxp.ProductsDataSet()
        Me.StartingInventoryInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StartingInventoryInfoTableAdapter = New SNFxp.ProductsDataSetTableAdapters.StartingInventoryInfoTableAdapter()
        Me.TableAdapterManager = New SNFxp.ProductsDataSetTableAdapters.TableAdapterManager()
        Me.StartingInventoryInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StartingInventoryInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InventoryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.InventoryMonthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SNFDatabaseDataSet = New SNFxp.SNFDatabaseDataSet()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.BranchTableAdapter = New SNFxp.SNFDatabaseDataSetTableAdapters.BranchTableAdapter()
        Me.StartingInventoryLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StartingInventoryLineItemsTableAdapter = New SNFxp.ProductsDataSetTableAdapters.StartingInventoryLineItemsTableAdapter()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter()
        Me.StartingInventoryLineItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgvcbProductID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.qtyInCase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyInPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ProductPricingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductPricingTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductPricingTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbTotalAmount = New System.Windows.Forms.TextBox()
        Me.tbTotalPcs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        InventoryDateLabel = New System.Windows.Forms.Label()
        InventoryMonthLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartingInventoryInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartingInventoryInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StartingInventoryInfoBindingNavigator.SuspendLayout()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SNFDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartingInventoryLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartingInventoryLineItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPricingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'InventoryDateLabel
        '
        InventoryDateLabel.AutoSize = True
        InventoryDateLabel.Location = New System.Drawing.Point(12, 24)
        InventoryDateLabel.Name = "InventoryDateLabel"
        InventoryDateLabel.Size = New System.Drawing.Size(80, 13)
        InventoryDateLabel.TabIndex = 3
        InventoryDateLabel.Text = "Inventory Date:"
        '
        'InventoryMonthLabel
        '
        InventoryMonthLabel.AutoSize = True
        InventoryMonthLabel.Location = New System.Drawing.Point(12, 53)
        InventoryMonthLabel.Name = "InventoryMonthLabel"
        InventoryMonthLabel.Size = New System.Drawing.Size(52, 13)
        InventoryMonthLabel.TabIndex = 5
        InventoryMonthLabel.Text = "Month of:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(12, 78)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(44, 13)
        BranchIDLabel.TabIndex = 7
        BranchIDLabel.Text = "Branch:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(346, 24)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 9
        RemarksLabel.Text = "Remarks:"
        '
        'ProductsDataSet
        '
        Me.ProductsDataSet.DataSetName = "ProductsDataSet"
        Me.ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StartingInventoryInfoBindingSource
        '
        Me.StartingInventoryInfoBindingSource.DataMember = "StartingInventoryInfo"
        Me.StartingInventoryInfoBindingSource.DataSource = Me.ProductsDataSet
        '
        'StartingInventoryInfoTableAdapter
        '
        Me.StartingInventoryInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Nothing
        Me.TableAdapterManager.PriceLevelTableAdapter = Nothing
        Me.TableAdapterManager.ProductDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.ProductGroupTableAdapter = Nothing
        Me.TableAdapterManager.ProductPricingTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.StartingInventoryInfoTableAdapter = Me.StartingInventoryInfoTableAdapter
        Me.TableAdapterManager.StartingInventoryLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.ProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StartingInventoryInfoBindingNavigator
        '
        Me.StartingInventoryInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StartingInventoryInfoBindingNavigator.BindingSource = Me.StartingInventoryInfoBindingSource
        Me.StartingInventoryInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StartingInventoryInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StartingInventoryInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StartingInventoryInfoBindingNavigatorSaveItem})
        Me.StartingInventoryInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StartingInventoryInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StartingInventoryInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StartingInventoryInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StartingInventoryInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StartingInventoryInfoBindingNavigator.Name = "StartingInventoryInfoBindingNavigator"
        Me.StartingInventoryInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StartingInventoryInfoBindingNavigator.Size = New System.Drawing.Size(725, 25)
        Me.StartingInventoryInfoBindingNavigator.TabIndex = 0
        Me.StartingInventoryInfoBindingNavigator.Text = "BindingNavigator1"
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
        'StartingInventoryInfoBindingNavigatorSaveItem
        '
        Me.StartingInventoryInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StartingInventoryInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("StartingInventoryInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StartingInventoryInfoBindingNavigatorSaveItem.Name = "StartingInventoryInfoBindingNavigatorSaveItem"
        Me.StartingInventoryInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StartingInventoryInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InventoryDateDateTimePicker
        '
        Me.InventoryDateDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.InventoryDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StartingInventoryInfoBindingSource, "InventoryDate", True))
        Me.InventoryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InventoryDateDateTimePicker.Location = New System.Drawing.Point(146, 20)
        Me.InventoryDateDateTimePicker.Name = "InventoryDateDateTimePicker"
        Me.InventoryDateDateTimePicker.Size = New System.Drawing.Size(153, 20)
        Me.InventoryDateDateTimePicker.TabIndex = 0
        Me.InventoryDateDateTimePicker.Value = New Date(2015, 9, 4, 8, 53, 27, 0)
        '
        'InventoryMonthDateTimePicker
        '
        Me.InventoryMonthDateTimePicker.CustomFormat = "MMMM yyyy"
        Me.InventoryMonthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StartingInventoryInfoBindingSource, "InventoryMonth", True))
        Me.InventoryMonthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InventoryMonthDateTimePicker.Location = New System.Drawing.Point(146, 49)
        Me.InventoryMonthDateTimePicker.Name = "InventoryMonthDateTimePicker"
        Me.InventoryMonthDateTimePicker.Size = New System.Drawing.Size(153, 20)
        Me.InventoryMonthDateTimePicker.TabIndex = 6
        Me.InventoryMonthDateTimePicker.Value = New Date(2015, 9, 3, 9, 57, 14, 0)
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StartingInventoryInfoBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(146, 75)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(153, 21)
        Me.BranchIDComboBox.TabIndex = 8
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.SNFDatabaseDataSet
        '
        'SNFDatabaseDataSet
        '
        Me.SNFDatabaseDataSet.DataSetName = "SNFDatabaseDataSet"
        Me.SNFDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StartingInventoryInfoBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(371, 40)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(261, 56)
        Me.RemarksTextBox.TabIndex = 10
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'StartingInventoryLineItemsBindingSource
        '
        Me.StartingInventoryLineItemsBindingSource.DataMember = "FK_StartingInventoryLineItems_StartingInventoryInfo"
        Me.StartingInventoryLineItemsBindingSource.DataSource = Me.StartingInventoryInfoBindingSource
        '
        'StartingInventoryLineItemsTableAdapter
        '
        Me.StartingInventoryLineItemsTableAdapter.ClearBeforeFill = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.ProductsDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'StartingInventoryLineItemsDataGridView
        '
        Me.StartingInventoryLineItemsDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartingInventoryLineItemsDataGridView.AutoGenerateColumns = False
        Me.StartingInventoryLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StartingInventoryLineItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcbProductID, Me.qtyInCase, Me.QtyInPC, Me.Quantity, Me.UnitPrice, Me.Amount, Me.ExpirationDate, Me.Remarks})
        Me.StartingInventoryLineItemsDataGridView.DataSource = Me.StartingInventoryLineItemsBindingSource
        Me.StartingInventoryLineItemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.StartingInventoryLineItemsDataGridView.Location = New System.Drawing.Point(39, 179)
        Me.StartingInventoryLineItemsDataGridView.MultiSelect = False
        Me.StartingInventoryLineItemsDataGridView.Name = "StartingInventoryLineItemsDataGridView"
        Me.StartingInventoryLineItemsDataGridView.Size = New System.Drawing.Size(654, 156)
        Me.StartingInventoryLineItemsDataGridView.TabIndex = 11
        '
        'dgvcbProductID
        '
        Me.dgvcbProductID.DataPropertyName = "ProductID"
        Me.dgvcbProductID.DataSource = Me.ProductsBindingSource
        Me.dgvcbProductID.DisplayMember = "ProductDescription"
        Me.dgvcbProductID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.dgvcbProductID.HeaderText = "ProductID"
        Me.dgvcbProductID.Name = "dgvcbProductID"
        Me.dgvcbProductID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcbProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgvcbProductID.ValueMember = "ProductID"
        Me.dgvcbProductID.Width = 125
        '
        'qtyInCase
        '
        Me.qtyInCase.DataPropertyName = "QtyInCase"
        Me.qtyInCase.HeaderText = "Qty(CS)"
        Me.qtyInCase.Name = "qtyInCase"
        Me.qtyInCase.Width = 50
        '
        'QtyInPC
        '
        Me.QtyInPC.DataPropertyName = "QtyInPiece"
        Me.QtyInPC.HeaderText = "Qty(PC)"
        Me.QtyInPC.Name = "QtyInPC"
        Me.QtyInPC.Width = 50
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle6
        Me.Quantity.HeaderText = "Total Qty(PC)"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 50
        '
        'UnitPrice
        '
        Me.UnitPrice.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.UnitPrice.DefaultCellStyle = DataGridViewCellStyle7
        Me.UnitPrice.HeaderText = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Width = 70
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle8
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 70
        '
        'ExpirationDate
        '
        Me.ExpirationDate.DataPropertyName = "ExpirationDate"
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ExpirationDate.DefaultCellStyle = DataGridViewCellStyle9
        Me.ExpirationDate.HeaderText = "ExpirationDate"
        Me.ExpirationDate.Name = "ExpirationDate"
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Remarks.DefaultCellStyle = DataGridViewCellStyle10
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(19, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 39)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ProductPricingBindingSource
        '
        Me.ProductPricingBindingSource.DataMember = "ProductPricing"
        Me.ProductPricingBindingSource.DataSource = Me.ProductsDataSet
        '
        'ProductPricingTableAdapter
        '
        Me.ProductPricingTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(InventoryDateLabel)
        Me.Panel1.Controls.Add(Me.InventoryDateDateTimePicker)
        Me.Panel1.Controls.Add(InventoryMonthLabel)
        Me.Panel1.Controls.Add(Me.InventoryMonthDateTimePicker)
        Me.Panel1.Controls.Add(BranchIDLabel)
        Me.Panel1.Controls.Add(Me.BranchIDComboBox)
        Me.Panel1.Controls.Add(RemarksLabel)
        Me.Panel1.Controls.Add(Me.RemarksTextBox)
        Me.Panel1.Location = New System.Drawing.Point(40, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 117)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Location = New System.Drawing.Point(36, 355)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 99)
        Me.Panel2.TabIndex = 14
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(19, 61)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(211, 25)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "Create New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(125, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 39)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tbTotalAmount)
        Me.Panel3.Controls.Add(Me.tbTotalPcs)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(420, 355)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(273, 98)
        Me.Panel3.TabIndex = 15
        '
        'tbTotalAmount
        '
        Me.tbTotalAmount.Location = New System.Drawing.Point(112, 57)
        Me.tbTotalAmount.Name = "tbTotalAmount"
        Me.tbTotalAmount.ReadOnly = True
        Me.tbTotalAmount.Size = New System.Drawing.Size(148, 20)
        Me.tbTotalAmount.TabIndex = 14
        Me.tbTotalAmount.TabStop = False
        '
        'tbTotalPcs
        '
        Me.tbTotalPcs.Location = New System.Drawing.Point(112, 21)
        Me.tbTotalPcs.Name = "tbTotalPcs"
        Me.tbTotalPcs.ReadOnly = True
        Me.tbTotalPcs.Size = New System.Drawing.Size(148, 20)
        Me.tbTotalPcs.TabIndex = 15
        Me.tbTotalPcs.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(20, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Amount: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MintCream
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Case: "
        '
        'NewMonthlyInvForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 475)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StartingInventoryLineItemsDataGridView)
        Me.Controls.Add(Me.StartingInventoryInfoBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "NewMonthlyInvForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewMonthlyInvForm"
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartingInventoryInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartingInventoryInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StartingInventoryInfoBindingNavigator.ResumeLayout(False)
        Me.StartingInventoryInfoBindingNavigator.PerformLayout()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SNFDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartingInventoryLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartingInventoryLineItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPricingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductsDataSet As SNFxp.ProductsDataSet
    Friend WithEvents StartingInventoryInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StartingInventoryInfoTableAdapter As SNFxp.ProductsDataSetTableAdapters.StartingInventoryInfoTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.ProductsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StartingInventoryInfoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StartingInventoryInfoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InventoryDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents InventoryMonthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SNFDatabaseDataSet As SNFxp.SNFDatabaseDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.SNFDatabaseDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents StartingInventoryLineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StartingInventoryLineItemsTableAdapter As SNFxp.ProductsDataSetTableAdapters.StartingInventoryLineItemsTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ProductPricingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductPricingTableAdapter As SNFxp.ProductsDataSetTableAdapters.ProductPricingTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tbTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalPcs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvcbProductID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents qtyInCase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyInPC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpirationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents StartingInventoryLineItemsDataGridView As System.Windows.Forms.DataGridView
End Class
