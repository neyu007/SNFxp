<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim StartingInventoryInfoIDLabel As System.Windows.Forms.Label
        Dim InventoryDateLabel As System.Windows.Forms.Label
        Dim InventoryMonthLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ExpirationDateLabel As System.Windows.Forms.Label
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
        Me.StartingInventoryInfoIDTextBox = New System.Windows.Forms.TextBox()
        Me.InventoryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.InventoryMonthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.StartingInventoryLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StartingInventoryLineItemsTableAdapter = New SNFxp.ProductsDataSetTableAdapters.StartingInventoryLineItemsTableAdapter()
        Me.StartingInventoryLineItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        StartingInventoryInfoIDLabel = New System.Windows.Forms.Label()
        InventoryDateLabel = New System.Windows.Forms.Label()
        InventoryMonthLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        ExpirationDateLabel = New System.Windows.Forms.Label()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartingInventoryInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartingInventoryInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StartingInventoryInfoBindingNavigator.SuspendLayout()
        CType(Me.StartingInventoryLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartingInventoryLineItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartingInventoryInfoIDLabel
        '
        StartingInventoryInfoIDLabel.AutoSize = True
        StartingInventoryInfoIDLabel.Location = New System.Drawing.Point(54, 42)
        StartingInventoryInfoIDLabel.Name = "StartingInventoryInfoIDLabel"
        StartingInventoryInfoIDLabel.Size = New System.Drawing.Size(128, 13)
        StartingInventoryInfoIDLabel.TabIndex = 1
        StartingInventoryInfoIDLabel.Text = "Starting Inventory Info ID:"
        '
        'InventoryDateLabel
        '
        InventoryDateLabel.AutoSize = True
        InventoryDateLabel.Location = New System.Drawing.Point(54, 69)
        InventoryDateLabel.Name = "InventoryDateLabel"
        InventoryDateLabel.Size = New System.Drawing.Size(80, 13)
        InventoryDateLabel.TabIndex = 3
        InventoryDateLabel.Text = "Inventory Date:"
        '
        'InventoryMonthLabel
        '
        InventoryMonthLabel.AutoSize = True
        InventoryMonthLabel.Location = New System.Drawing.Point(54, 95)
        InventoryMonthLabel.Name = "InventoryMonthLabel"
        InventoryMonthLabel.Size = New System.Drawing.Size(87, 13)
        InventoryMonthLabel.TabIndex = 5
        InventoryMonthLabel.Text = "Inventory Month:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(54, 120)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(58, 13)
        BranchIDLabel.TabIndex = 7
        BranchIDLabel.Text = "Branch ID:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(54, 147)
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
        Me.StartingInventoryInfoBindingNavigator.Size = New System.Drawing.Size(680, 25)
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
        'StartingInventoryInfoIDTextBox
        '
        Me.StartingInventoryInfoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StartingInventoryInfoBindingSource, "StartingInventoryInfoID", True))
        Me.StartingInventoryInfoIDTextBox.Location = New System.Drawing.Point(188, 39)
        Me.StartingInventoryInfoIDTextBox.Name = "StartingInventoryInfoIDTextBox"
        Me.StartingInventoryInfoIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StartingInventoryInfoIDTextBox.TabIndex = 2
        '
        'InventoryDateDateTimePicker
        '
        Me.InventoryDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StartingInventoryInfoBindingSource, "InventoryDate", True))
        Me.InventoryDateDateTimePicker.Location = New System.Drawing.Point(188, 65)
        Me.InventoryDateDateTimePicker.Name = "InventoryDateDateTimePicker"
        Me.InventoryDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.InventoryDateDateTimePicker.TabIndex = 4
        '
        'InventoryMonthDateTimePicker
        '
        Me.InventoryMonthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StartingInventoryInfoBindingSource, "InventoryMonth", True))
        Me.InventoryMonthDateTimePicker.Location = New System.Drawing.Point(188, 91)
        Me.InventoryMonthDateTimePicker.Name = "InventoryMonthDateTimePicker"
        Me.InventoryMonthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.InventoryMonthDateTimePicker.TabIndex = 6
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StartingInventoryInfoBindingSource, "BranchID", True))
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(188, 117)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.BranchIDComboBox.TabIndex = 8
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StartingInventoryInfoBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(188, 144)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RemarksTextBox.TabIndex = 10
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
        'StartingInventoryLineItemsDataGridView
        '
        Me.StartingInventoryLineItemsDataGridView.AutoGenerateColumns = False
        Me.StartingInventoryLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StartingInventoryLineItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.StartingInventoryLineItemsDataGridView.DataSource = Me.StartingInventoryLineItemsBindingSource
        Me.StartingInventoryLineItemsDataGridView.Location = New System.Drawing.Point(53, 178)
        Me.StartingInventoryLineItemsDataGridView.Name = "StartingInventoryLineItemsDataGridView"
        Me.StartingInventoryLineItemsDataGridView.Size = New System.Drawing.Size(585, 220)
        Me.StartingInventoryLineItemsDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StartingInventoryLineItemsID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StartingInventoryLineItemsID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StartingInventoryInfoID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StartingInventoryInfoID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ExpirationDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ExpirationDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ExpirationDateLabel
        '
        ExpirationDateLabel.AutoSize = True
        ExpirationDateLabel.Location = New System.Drawing.Point(472, 42)
        ExpirationDateLabel.Name = "ExpirationDateLabel"
        ExpirationDateLabel.Size = New System.Drawing.Size(82, 13)
        ExpirationDateLabel.TabIndex = 12
        ExpirationDateLabel.Text = "Expiration Date:"
        '
        'ExpirationDateMaskedTextBox
        '
        Me.ExpirationDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StartingInventoryLineItemsBindingSource, "ExpirationDate", True))
        Me.ExpirationDateMaskedTextBox.Location = New System.Drawing.Point(560, 39)
        Me.ExpirationDateMaskedTextBox.Mask = "00/00/0000"
        Me.ExpirationDateMaskedTextBox.Name = "ExpirationDateMaskedTextBox"
        Me.ExpirationDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExpirationDateMaskedTextBox.TabIndex = 13
        Me.ExpirationDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 445)
        Me.Controls.Add(ExpirationDateLabel)
        Me.Controls.Add(Me.ExpirationDateMaskedTextBox)
        Me.Controls.Add(Me.StartingInventoryLineItemsDataGridView)
        Me.Controls.Add(StartingInventoryInfoIDLabel)
        Me.Controls.Add(Me.StartingInventoryInfoIDTextBox)
        Me.Controls.Add(InventoryDateLabel)
        Me.Controls.Add(Me.InventoryDateDateTimePicker)
        Me.Controls.Add(InventoryMonthLabel)
        Me.Controls.Add(Me.InventoryMonthDateTimePicker)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.StartingInventoryInfoBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartingInventoryInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartingInventoryInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StartingInventoryInfoBindingNavigator.ResumeLayout(False)
        Me.StartingInventoryInfoBindingNavigator.PerformLayout()
        CType(Me.StartingInventoryLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartingInventoryLineItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StartingInventoryInfoIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InventoryDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents InventoryMonthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartingInventoryLineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StartingInventoryLineItemsTableAdapter As SNFxp.ProductsDataSetTableAdapters.StartingInventoryLineItemsTableAdapter
    Friend WithEvents StartingInventoryLineItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpirationDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
