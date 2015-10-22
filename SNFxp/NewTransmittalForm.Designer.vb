<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTransmittalForm
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
            SingleFormClass.newTransmittalForm = Nothing
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
        Dim TransmittalNoLabel As System.Windows.Forms.Label
        Dim TruckPlateNoLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim BranchToIDLabel As System.Windows.Forms.Label
        Dim DateOfTransmitLabel As System.Windows.Forms.Label
        Dim DateOfReceiveLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewTransmittalForm))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TransmittalDataSet = New SNFxp.TransmittalDataSet()
        Me.TransmittalInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransmittalInfoTableAdapter = New SNFxp.TransmittalDataSetTableAdapters.TransmittalInfoTableAdapter()
        Me.TableAdapterManager = New SNFxp.TransmittalDataSetTableAdapters.TableAdapterManager()
        Me.BranchTableAdapter = New SNFxp.TransmittalDataSetTableAdapters.BranchTableAdapter()
        Me.TransmittalLineItemsTableAdapter = New SNFxp.TransmittalDataSetTableAdapters.TransmittalLineItemsTableAdapter()
        Me.TransmittalInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TransmittalInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TransmittalNoTextBox = New System.Windows.Forms.TextBox()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesAgentDataSet = New SNFxp.SalesAgentDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchToIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DateOfTransmitDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateOfReceiveDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.ReceivedCheckBox = New System.Windows.Forms.CheckBox()
        Me.TransmittalLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransmittalLineItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LookupProductsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LookupProductsDataSet = New SNFxp.LookupProductsDataSet()
        Me.QtyCase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsTableAdapter = New SNFxp.LookupProductsDataSetTableAdapters.ProductsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTotalPiece = New System.Windows.Forms.TextBox()
        Me.tbTotalAmount = New System.Windows.Forms.TextBox()
        Me.tbTotalCase = New System.Windows.Forms.TextBox()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.BranchTableAdapter1 = New SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter()
        Me.ProductPricingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductPricingTableAdapter = New SNFxp.LookupProductsDataSetTableAdapters.ProductPricingTableAdapter()
        Me.TableAdapterManager1 = New SNFxp.LookupProductsDataSetTableAdapters.TableAdapterManager()
        Me.TruckIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TrucksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnNewTruck = New System.Windows.Forms.Button()
        Me.TrucksTableAdapter = New SNFxp.TransmittalDataSetTableAdapters.TrucksTableAdapter()
        TransmittalNoLabel = New System.Windows.Forms.Label()
        TruckPlateNoLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        BranchToIDLabel = New System.Windows.Forms.Label()
        DateOfTransmitLabel = New System.Windows.Forms.Label()
        DateOfReceiveLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        CType(Me.TransmittalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransmittalInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransmittalInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransmittalInfoBindingNavigator.SuspendLayout()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransmittalLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransmittalLineItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupProductsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductPricingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransmittalNoLabel
        '
        TransmittalNoLabel.AutoSize = True
        TransmittalNoLabel.Location = New System.Drawing.Point(30, 44)
        TransmittalNoLabel.Name = "TransmittalNoLabel"
        TransmittalNoLabel.Size = New System.Drawing.Size(78, 13)
        TransmittalNoLabel.TabIndex = 3
        TransmittalNoLabel.Text = "Transmittal No:"
        '
        'TruckPlateNoLabel
        '
        TruckPlateNoLabel.AutoSize = True
        TruckPlateNoLabel.Location = New System.Drawing.Point(403, 44)
        TruckPlateNoLabel.Name = "TruckPlateNoLabel"
        TruckPlateNoLabel.Size = New System.Drawing.Size(82, 13)
        TruckPlateNoLabel.TabIndex = 5
        TruckPlateNoLabel.Text = "Truck Plate No:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(30, 70)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(36, 13)
        BranchIDLabel.TabIndex = 7
        BranchIDLabel.Text = "From: "
        '
        'BranchToIDLabel
        '
        BranchToIDLabel.AutoSize = True
        BranchToIDLabel.Location = New System.Drawing.Point(403, 70)
        BranchToIDLabel.Name = "BranchToIDLabel"
        BranchToIDLabel.Size = New System.Drawing.Size(23, 13)
        BranchToIDLabel.TabIndex = 9
        BranchToIDLabel.Text = "To:"
        '
        'DateOfTransmitLabel
        '
        DateOfTransmitLabel.AutoSize = True
        DateOfTransmitLabel.Location = New System.Drawing.Point(30, 99)
        DateOfTransmitLabel.Name = "DateOfTransmitLabel"
        DateOfTransmitLabel.Size = New System.Drawing.Size(90, 13)
        DateOfTransmitLabel.TabIndex = 11
        DateOfTransmitLabel.Text = "Date Of Transmit:"
        '
        'DateOfReceiveLabel
        '
        DateOfReceiveLabel.AutoSize = True
        DateOfReceiveLabel.Location = New System.Drawing.Point(403, 99)
        DateOfReceiveLabel.Name = "DateOfReceiveLabel"
        DateOfReceiveLabel.Size = New System.Drawing.Size(90, 13)
        DateOfReceiveLabel.TabIndex = 13
        DateOfReceiveLabel.Text = "Date Of Receive:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(30, 307)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 15
        RemarksLabel.Text = "Remarks:"
        '
        'TransmittalDataSet
        '
        Me.TransmittalDataSet.DataSetName = "TransmittalDataSet"
        Me.TransmittalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransmittalInfoBindingSource
        '
        Me.TransmittalInfoBindingSource.DataMember = "TransmittalInfo"
        Me.TransmittalInfoBindingSource.DataSource = Me.TransmittalDataSet
        '
        'TransmittalInfoTableAdapter
        '
        Me.TransmittalInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Me.BranchTableAdapter
        Me.TableAdapterManager.TransmittalInfoTableAdapter = Me.TransmittalInfoTableAdapter
        Me.TableAdapterManager.TransmittalLineItemsTableAdapter = Me.TransmittalLineItemsTableAdapter
        Me.TableAdapterManager.TrucksTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.TransmittalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'TransmittalLineItemsTableAdapter
        '
        Me.TransmittalLineItemsTableAdapter.ClearBeforeFill = True
        '
        'TransmittalInfoBindingNavigator
        '
        Me.TransmittalInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TransmittalInfoBindingNavigator.BindingSource = Me.TransmittalInfoBindingSource
        Me.TransmittalInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TransmittalInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TransmittalInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TransmittalInfoBindingNavigatorSaveItem})
        Me.TransmittalInfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TransmittalInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TransmittalInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TransmittalInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TransmittalInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TransmittalInfoBindingNavigator.Name = "TransmittalInfoBindingNavigator"
        Me.TransmittalInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TransmittalInfoBindingNavigator.Size = New System.Drawing.Size(743, 25)
        Me.TransmittalInfoBindingNavigator.TabIndex = 0
        Me.TransmittalInfoBindingNavigator.Text = "BindingNavigator1"
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
        'TransmittalInfoBindingNavigatorSaveItem
        '
        Me.TransmittalInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TransmittalInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("TransmittalInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TransmittalInfoBindingNavigatorSaveItem.Name = "TransmittalInfoBindingNavigatorSaveItem"
        Me.TransmittalInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TransmittalInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TransmittalNoTextBox
        '
        Me.TransmittalNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransmittalInfoBindingSource, "TransmittalNo", True))
        Me.TransmittalNoTextBox.Location = New System.Drawing.Point(132, 41)
        Me.TransmittalNoTextBox.Name = "TransmittalNoTextBox"
        Me.TransmittalNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TransmittalNoTextBox.TabIndex = 1
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TransmittalInfoBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource1
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(132, 67)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.BranchIDComboBox.TabIndex = 3
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource1
        '
        Me.BranchBindingSource1.DataMember = "Branch"
        Me.BranchBindingSource1.DataSource = Me.SalesAgentDataSet
        '
        'SalesAgentDataSet
        '
        Me.SalesAgentDataSet.DataSetName = "SalesAgentDataSet"
        Me.SalesAgentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.TransmittalDataSet
        '
        'BranchToIDComboBox
        '
        Me.BranchToIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TransmittalInfoBindingSource, "BranchToID", True))
        Me.BranchToIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchToIDComboBox.DisplayMember = "BranchName"
        Me.BranchToIDComboBox.FormattingEnabled = True
        Me.BranchToIDComboBox.Location = New System.Drawing.Point(505, 67)
        Me.BranchToIDComboBox.Name = "BranchToIDComboBox"
        Me.BranchToIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.BranchToIDComboBox.TabIndex = 4
        Me.BranchToIDComboBox.ValueMember = "BranchID"
        '
        'DateOfTransmitDateTimePicker
        '
        Me.DateOfTransmitDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransmittalInfoBindingSource, "DateOfTransmit", True))
        Me.DateOfTransmitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOfTransmitDateTimePicker.Location = New System.Drawing.Point(132, 95)
        Me.DateOfTransmitDateTimePicker.Name = "DateOfTransmitDateTimePicker"
        Me.DateOfTransmitDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfTransmitDateTimePicker.TabIndex = 5
        '
        'DateOfReceiveDateTimePicker
        '
        Me.DateOfReceiveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransmittalInfoBindingSource, "DateOfReceive", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "<none>"))
        Me.DateOfReceiveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOfReceiveDateTimePicker.Location = New System.Drawing.Point(505, 95)
        Me.DateOfReceiveDateTimePicker.Name = "DateOfReceiveDateTimePicker"
        Me.DateOfReceiveDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfReceiveDateTimePicker.TabIndex = 6
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransmittalInfoBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(85, 304)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(247, 48)
        Me.RemarksTextBox.TabIndex = 8
        '
        'ReceivedCheckBox
        '
        Me.ReceivedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TransmittalInfoBindingSource, "Received", True))
        Me.ReceivedCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceivedCheckBox.Location = New System.Drawing.Point(110, 358)
        Me.ReceivedCheckBox.Name = "ReceivedCheckBox"
        Me.ReceivedCheckBox.Size = New System.Drawing.Size(222, 30)
        Me.ReceivedCheckBox.TabIndex = 9
        Me.ReceivedCheckBox.Text = "Check if received"
        Me.ReceivedCheckBox.UseVisualStyleBackColor = True
        '
        'TransmittalLineItemsBindingSource
        '
        Me.TransmittalLineItemsBindingSource.DataMember = "FK_TransmittalLineItems_TransmittalInfo"
        Me.TransmittalLineItemsBindingSource.DataSource = Me.TransmittalInfoBindingSource
        '
        'TransmittalLineItemsDataGridView
        '
        Me.TransmittalLineItemsDataGridView.AutoGenerateColumns = False
        Me.TransmittalLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransmittalLineItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.QtyCase, Me.QtyPiece, Me.UnitPrice, Me.Amount})
        Me.TransmittalLineItemsDataGridView.DataSource = Me.TransmittalLineItemsBindingSource
        Me.TransmittalLineItemsDataGridView.Location = New System.Drawing.Point(32, 135)
        Me.TransmittalLineItemsDataGridView.Name = "TransmittalLineItemsDataGridView"
        Me.TransmittalLineItemsDataGridView.Size = New System.Drawing.Size(673, 155)
        Me.TransmittalLineItemsDataGridView.TabIndex = 7
        '
        'ProductID
        '
        Me.ProductID.DataPropertyName = "ProductID"
        Me.ProductID.DataSource = Me.ProductsBindingSource
        Me.ProductID.DisplayMember = "ProductName"
        Me.ProductID.HeaderText = "ProductID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductID.ValueMember = "ProductID"
        Me.ProductID.Width = 200
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.LookupProductsDataSetBindingSource
        '
        'LookupProductsDataSetBindingSource
        '
        Me.LookupProductsDataSetBindingSource.DataSource = Me.LookupProductsDataSet
        Me.LookupProductsDataSetBindingSource.Position = 0
        '
        'LookupProductsDataSet
        '
        Me.LookupProductsDataSet.DataSetName = "LookupProductsDataSet"
        Me.LookupProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QtyCase
        '
        Me.QtyCase.DataPropertyName = "QtyCase"
        Me.QtyCase.HeaderText = "QtyCase"
        Me.QtyCase.Name = "QtyCase"
        '
        'QtyPiece
        '
        Me.QtyPiece.DataPropertyName = "QtyPiece"
        Me.QtyPiece.HeaderText = "QtyPiece"
        Me.QtyPiece.Name = "QtyPiece"
        Me.QtyPiece.ReadOnly = True
        '
        'UnitPrice
        '
        Me.UnitPrice.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle3.Format = "N2"
        Me.UnitPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.UnitPrice.HeaderText = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle4.Format = "N2"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbTotalPiece)
        Me.Panel1.Controls.Add(Me.tbTotalAmount)
        Me.Panel1.Controls.Add(Me.tbTotalCase)
        Me.Panel1.Location = New System.Drawing.Point(349, 304)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 92)
        Me.Panel1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Pieces: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Cases: "
        '
        'tbTotalPiece
        '
        Me.tbTotalPiece.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalPiece.Location = New System.Drawing.Point(280, 19)
        Me.tbTotalPiece.Name = "tbTotalPiece"
        Me.tbTotalPiece.ReadOnly = True
        Me.tbTotalPiece.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTotalPiece.Size = New System.Drawing.Size(70, 26)
        Me.tbTotalPiece.TabIndex = 0
        Me.tbTotalPiece.TabStop = False
        '
        'tbTotalAmount
        '
        Me.tbTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalAmount.Location = New System.Drawing.Point(135, 58)
        Me.tbTotalAmount.Name = "tbTotalAmount"
        Me.tbTotalAmount.ReadOnly = True
        Me.tbTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTotalAmount.Size = New System.Drawing.Size(174, 26)
        Me.tbTotalAmount.TabIndex = 0
        Me.tbTotalAmount.TabStop = False
        '
        'tbTotalCase
        '
        Me.tbTotalCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalCase.Location = New System.Drawing.Point(97, 19)
        Me.tbTotalCase.Name = "tbTotalCase"
        Me.tbTotalCase.ReadOnly = True
        Me.tbTotalCase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTotalCase.Size = New System.Drawing.Size(74, 26)
        Me.tbTotalCase.TabIndex = 0
        Me.tbTotalCase.TabStop = False
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(607, 414)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(98, 21)
        Me.btnSaveNew.TabIndex = 13
        Me.btnSaveNew.Text = "Save and New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(428, 414)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 21)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(349, 414)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 21)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(503, 414)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(98, 21)
        Me.btnSaveClose.TabIndex = 12
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'BranchTableAdapter1
        '
        Me.BranchTableAdapter1.ClearBeforeFill = True
        '
        'ProductPricingBindingSource
        '
        Me.ProductPricingBindingSource.DataMember = "ProductPricing"
        Me.ProductPricingBindingSource.DataSource = Me.LookupProductsDataSet
        '
        'ProductPricingTableAdapter
        '
        Me.ProductPricingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PriceLevelTableAdapter = Nothing
        Me.TableAdapterManager1.ProductDepartmentTableAdapter = Nothing
        Me.TableAdapterManager1.ProductGroupTableAdapter = Nothing
        Me.TableAdapterManager1.ProductPricingTableAdapter = Me.ProductPricingTableAdapter
        Me.TableAdapterManager1.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = SNFxp.LookupProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TruckIDComboBox
        '
        Me.TruckIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TransmittalInfoBindingSource, "TruckID", True))
        Me.TruckIDComboBox.DataSource = Me.TrucksBindingSource
        Me.TruckIDComboBox.DisplayMember = "PlateNumber"
        Me.TruckIDComboBox.FormattingEnabled = True
        Me.TruckIDComboBox.Location = New System.Drawing.Point(505, 36)
        Me.TruckIDComboBox.Name = "TruckIDComboBox"
        Me.TruckIDComboBox.Size = New System.Drawing.Size(164, 21)
        Me.TruckIDComboBox.TabIndex = 22
        Me.TruckIDComboBox.ValueMember = "TruckID"
        '
        'TrucksBindingSource
        '
        Me.TrucksBindingSource.DataMember = "Trucks"
        Me.TrucksBindingSource.DataSource = Me.TransmittalDataSet
        '
        'btnNewTruck
        '
        Me.btnNewTruck.Location = New System.Drawing.Point(675, 35)
        Me.btnNewTruck.Name = "btnNewTruck"
        Me.btnNewTruck.Size = New System.Drawing.Size(30, 23)
        Me.btnNewTruck.TabIndex = 23
        Me.btnNewTruck.Text = "..."
        Me.btnNewTruck.UseVisualStyleBackColor = True
        '
        'TrucksTableAdapter
        '
        Me.TrucksTableAdapter.ClearBeforeFill = True
        '
        'NewTransmittalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 455)
        Me.Controls.Add(Me.btnNewTruck)
        Me.Controls.Add(Me.TruckIDComboBox)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TransmittalLineItemsDataGridView)
        Me.Controls.Add(TransmittalNoLabel)
        Me.Controls.Add(Me.TransmittalNoTextBox)
        Me.Controls.Add(TruckPlateNoLabel)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Controls.Add(BranchToIDLabel)
        Me.Controls.Add(Me.BranchToIDComboBox)
        Me.Controls.Add(DateOfTransmitLabel)
        Me.Controls.Add(Me.DateOfTransmitDateTimePicker)
        Me.Controls.Add(DateOfReceiveLabel)
        Me.Controls.Add(Me.DateOfReceiveDateTimePicker)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.ReceivedCheckBox)
        Me.Controls.Add(Me.TransmittalInfoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewTransmittalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewTransmittalForm"
        CType(Me.TransmittalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransmittalInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransmittalInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransmittalInfoBindingNavigator.ResumeLayout(False)
        Me.TransmittalInfoBindingNavigator.PerformLayout()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransmittalLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransmittalLineItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupProductsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductPricingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransmittalDataSet As SNFxp.TransmittalDataSet
    Friend WithEvents TransmittalInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransmittalInfoTableAdapter As SNFxp.TransmittalDataSetTableAdapters.TransmittalInfoTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.TransmittalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransmittalInfoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TransmittalInfoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransmittalLineItemsTableAdapter As SNFxp.TransmittalDataSetTableAdapters.TransmittalLineItemsTableAdapter
    Friend WithEvents TransmittalNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BranchToIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateOfTransmitDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateOfReceiveDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReceivedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TransmittalLineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransmittalLineItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LookupProductsDataSet As SNFxp.LookupProductsDataSet
    Friend WithEvents LookupProductsDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As SNFxp.LookupProductsDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbTotalPiece As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalCase As System.Windows.Forms.TextBox
    Friend WithEvents BranchTableAdapter As SNFxp.TransmittalDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents btnSaveNew As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesAgentDataSet As SNFxp.SalesAgentDataSet
    Friend WithEvents BranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter1 As SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ProductPricingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductPricingTableAdapter As SNFxp.LookupProductsDataSetTableAdapters.ProductPricingTableAdapter
    Friend WithEvents TableAdapterManager1 As SNFxp.LookupProductsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QtyCase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyPiece As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TruckIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewTruck As System.Windows.Forms.Button
    Friend WithEvents TrucksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrucksTableAdapter As SNFxp.TransmittalDataSetTableAdapters.TrucksTableAdapter
End Class
