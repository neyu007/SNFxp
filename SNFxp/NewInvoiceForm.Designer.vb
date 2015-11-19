<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewInvoiceForm
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
            SingleFormClass.newInvoiceForm = Nothing
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
        Dim DRNoLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim DRDateLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim NameOfOwnerLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim TermsIDLabel As System.Windows.Forms.Label
        Dim SalesAgentIDLabel As System.Windows.Forms.Label
        Dim TruckIDLabel As System.Windows.Forms.Label
        Dim AreaIDLabel As System.Windows.Forms.Label
        Dim DueDateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim TotalDiscountLabel As System.Windows.Forms.Label
        Dim BOAmountLabel As System.Windows.Forms.Label
        Dim TotalInvoiceAmountLabel As System.Windows.Forms.Label
        Me.InvoiceDataSet = New SNFxp.InvoiceDataSet()
        Me.SalesInvoiceInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesInvoiceInfoTableAdapter = New SNFxp.InvoiceDataSetTableAdapters.SalesInvoiceInfoTableAdapter()
        Me.TableAdapterManager = New SNFxp.InvoiceDataSetTableAdapters.TableAdapterManager()
        Me.DRNoTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet = New SNFxp.CustomersDataSet()
        Me.DRDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NameOfOwnerTextBox = New System.Windows.Forms.TextBox()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TermsIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TermsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesAgentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SalesAgentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesAgentDataSet = New SNFxp.SalesAgentDataSet()
        Me.TruckIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TrucksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrucksDataSet = New SNFxp.TrucksDataSet()
        Me.AreaIDComboBox = New System.Windows.Forms.ComboBox()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.BOAmountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalInvoiceAmountTextBox = New System.Windows.Forms.TextBox()
        Me.SalesInvoiceLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesInvoiceLineItemsTableAdapter = New SNFxp.InvoiceDataSetTableAdapters.SalesInvoiceLineItemsTableAdapter()
        Me.SalesInvoiceLineItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSaveAndNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddBO = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CustomersTableAdapter = New SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter()
        Me.TermsTableAdapter = New SNFxp.CustomersDataSetTableAdapters.TermsTableAdapter()
        Me.BranchTableAdapter = New SNFxp.CustomersDataSetTableAdapters.BranchTableAdapter()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnNewTerms = New System.Windows.Forms.Button()
        Me.btnNewTruck = New System.Windows.Forms.Button()
        Me.SalesAgentTableAdapter = New SNFxp.SalesAgentDataSetTableAdapters.SalesAgentTableAdapter()
        Me.TrucksTableAdapter = New SNFxp.TrucksDataSetTableAdapters.TrucksTableAdapter()
        Me.btnNewSalesman = New System.Windows.Forms.Button()
        Me.AreasTableAdapter = New SNFxp.CustomersDataSetTableAdapters.AreasTableAdapter()
        DRNoLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        DRDateLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NameOfOwnerLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        TermsIDLabel = New System.Windows.Forms.Label()
        SalesAgentIDLabel = New System.Windows.Forms.Label()
        TruckIDLabel = New System.Windows.Forms.Label()
        AreaIDLabel = New System.Windows.Forms.Label()
        DueDateLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        TotalDiscountLabel = New System.Windows.Forms.Label()
        BOAmountLabel = New System.Windows.Forms.Label()
        TotalInvoiceAmountLabel = New System.Windows.Forms.Label()
        CType(Me.InvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInvoiceInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrucksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInvoiceLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInvoiceLineItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DRNoLabel
        '
        DRNoLabel.AutoSize = True
        DRNoLabel.Location = New System.Drawing.Point(573, 38)
        DRNoLabel.Name = "DRNoLabel"
        DRNoLabel.Size = New System.Drawing.Size(40, 13)
        DRNoLabel.TabIndex = 3
        DRNoLabel.Text = "DRNo:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(30, 38)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 5
        CustomerIDLabel.Text = "Customer ID:"
        '
        'DRDateLabel
        '
        DRDateLabel.AutoSize = True
        DRDateLabel.Location = New System.Drawing.Point(353, 40)
        DRDateLabel.Name = "DRDateLabel"
        DRDateLabel.Size = New System.Drawing.Size(49, 13)
        DRDateLabel.TabIndex = 7
        DRDateLabel.Text = "DRDate:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(30, 67)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'NameOfOwnerLabel
        '
        NameOfOwnerLabel.AutoSize = True
        NameOfOwnerLabel.Location = New System.Drawing.Point(30, 95)
        NameOfOwnerLabel.Name = "NameOfOwnerLabel"
        NameOfOwnerLabel.Size = New System.Drawing.Size(86, 13)
        NameOfOwnerLabel.TabIndex = 11
        NameOfOwnerLabel.Text = "Name Of Owner:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(573, 62)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(58, 13)
        BranchIDLabel.TabIndex = 13
        BranchIDLabel.Text = "Branch ID:"
        '
        'TermsIDLabel
        '
        TermsIDLabel.AutoSize = True
        TermsIDLabel.Location = New System.Drawing.Point(353, 66)
        TermsIDLabel.Name = "TermsIDLabel"
        TermsIDLabel.Size = New System.Drawing.Size(53, 13)
        TermsIDLabel.TabIndex = 15
        TermsIDLabel.Text = "Terms ID:"
        '
        'SalesAgentIDLabel
        '
        SalesAgentIDLabel.AutoSize = True
        SalesAgentIDLabel.Location = New System.Drawing.Point(573, 92)
        SalesAgentIDLabel.Name = "SalesAgentIDLabel"
        SalesAgentIDLabel.Size = New System.Drawing.Size(56, 13)
        SalesAgentIDLabel.TabIndex = 17
        SalesAgentIDLabel.Text = "Salesman:"
        '
        'TruckIDLabel
        '
        TruckIDLabel.AutoSize = True
        TruckIDLabel.Location = New System.Drawing.Point(353, 124)
        TruckIDLabel.Name = "TruckIDLabel"
        TruckIDLabel.Size = New System.Drawing.Size(38, 13)
        TruckIDLabel.TabIndex = 19
        TruckIDLabel.Text = "Truck:"
        '
        'AreaIDLabel
        '
        AreaIDLabel.AutoSize = True
        AreaIDLabel.Location = New System.Drawing.Point(30, 122)
        AreaIDLabel.Name = "AreaIDLabel"
        AreaIDLabel.Size = New System.Drawing.Size(46, 13)
        AreaIDLabel.TabIndex = 21
        AreaIDLabel.Text = "Area ID:"
        '
        'DueDateLabel
        '
        DueDateLabel.AutoSize = True
        DueDateLabel.Location = New System.Drawing.Point(353, 97)
        DueDateLabel.Name = "DueDateLabel"
        DueDateLabel.Size = New System.Drawing.Size(56, 13)
        DueDateLabel.TabIndex = 23
        DueDateLabel.Text = "Due Date:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(30, 388)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 25
        RemarksLabel.Text = "Remarks:"
        '
        'TotalDiscountLabel
        '
        TotalDiscountLabel.AutoSize = True
        TotalDiscountLabel.Location = New System.Drawing.Point(497, 376)
        TotalDiscountLabel.Name = "TotalDiscountLabel"
        TotalDiscountLabel.Size = New System.Drawing.Size(79, 13)
        TotalDiscountLabel.TabIndex = 27
        TotalDiscountLabel.Text = "Total Discount:"
        '
        'BOAmountLabel
        '
        BOAmountLabel.AutoSize = True
        BOAmountLabel.Location = New System.Drawing.Point(497, 402)
        BOAmountLabel.Name = "BOAmountLabel"
        BOAmountLabel.Size = New System.Drawing.Size(61, 13)
        BOAmountLabel.TabIndex = 29
        BOAmountLabel.Text = "BOAmount:"
        '
        'TotalInvoiceAmountLabel
        '
        TotalInvoiceAmountLabel.AutoSize = True
        TotalInvoiceAmountLabel.Location = New System.Drawing.Point(497, 428)
        TotalInvoiceAmountLabel.Name = "TotalInvoiceAmountLabel"
        TotalInvoiceAmountLabel.Size = New System.Drawing.Size(111, 13)
        TotalInvoiceAmountLabel.TabIndex = 31
        TotalInvoiceAmountLabel.Text = "Total Invoice Amount:"
        '
        'InvoiceDataSet
        '
        Me.InvoiceDataSet.DataSetName = "InvoiceDataSet"
        Me.InvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesInvoiceInfoBindingSource
        '
        Me.SalesInvoiceInfoBindingSource.DataMember = "SalesInvoiceInfo"
        Me.SalesInvoiceInfoBindingSource.DataSource = Me.InvoiceDataSet
        '
        'SalesInvoiceInfoTableAdapter
        '
        Me.SalesInvoiceInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesInvoiceInfoTableAdapter = Me.SalesInvoiceInfoTableAdapter
        Me.TableAdapterManager.SalesInvoiceLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.InvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DRNoTextBox
        '
        Me.DRNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoiceInfoBindingSource, "DRNo", True))
        Me.DRNoTextBox.Location = New System.Drawing.Point(637, 35)
        Me.DRNoTextBox.Name = "DRNoTextBox"
        Me.DRNoTextBox.Size = New System.Drawing.Size(141, 20)
        Me.DRNoTextBox.TabIndex = 4
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustomerIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerIDComboBox.DataSource = Me.CustomersBindingSource
        Me.CustomerIDComboBox.DisplayMember = "StoreName"
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(147, 35)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(163, 21)
        Me.CustomerIDComboBox.TabIndex = 6
        Me.CustomerIDComboBox.ValueMember = "CustomerID"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.CustomersDataSetBindingSource
        '
        'CustomersDataSetBindingSource
        '
        Me.CustomersDataSetBindingSource.DataSource = Me.CustomersDataSet
        Me.CustomersDataSetBindingSource.Position = 0
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DRDateDateTimePicker
        '
        Me.DRDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesInvoiceInfoBindingSource, "DRDate", True))
        Me.DRDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DRDateDateTimePicker.Location = New System.Drawing.Point(408, 36)
        Me.DRDateDateTimePicker.Name = "DRDateDateTimePicker"
        Me.DRDateDateTimePicker.Size = New System.Drawing.Size(159, 20)
        Me.DRDateDateTimePicker.TabIndex = 8
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoiceInfoBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(147, 64)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 10
        '
        'NameOfOwnerTextBox
        '
        Me.NameOfOwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoiceInfoBindingSource, "NameOfOwner", True))
        Me.NameOfOwnerTextBox.Location = New System.Drawing.Point(147, 92)
        Me.NameOfOwnerTextBox.Name = "NameOfOwnerTextBox"
        Me.NameOfOwnerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameOfOwnerTextBox.TabIndex = 12
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SalesInvoiceInfoBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(637, 59)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(141, 21)
        Me.BranchIDComboBox.TabIndex = 14
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.CustomersDataSetBindingSource
        '
        'TermsIDComboBox
        '
        Me.TermsIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SalesInvoiceInfoBindingSource, "TermsID", True))
        Me.TermsIDComboBox.DataSource = Me.TermsBindingSource
        Me.TermsIDComboBox.DisplayMember = "Term"
        Me.TermsIDComboBox.FormattingEnabled = True
        Me.TermsIDComboBox.Location = New System.Drawing.Point(408, 61)
        Me.TermsIDComboBox.Name = "TermsIDComboBox"
        Me.TermsIDComboBox.Size = New System.Drawing.Size(122, 21)
        Me.TermsIDComboBox.TabIndex = 16
        Me.TermsIDComboBox.ValueMember = "TermsID"
        '
        'TermsBindingSource
        '
        Me.TermsBindingSource.DataMember = "Terms"
        Me.TermsBindingSource.DataSource = Me.CustomersDataSetBindingSource
        '
        'SalesAgentIDComboBox
        '
        Me.SalesAgentIDComboBox.DataSource = Me.SalesAgentBindingSource
        Me.SalesAgentIDComboBox.DisplayMember = "Name"
        Me.SalesAgentIDComboBox.FormattingEnabled = True
        Me.SalesAgentIDComboBox.Location = New System.Drawing.Point(637, 87)
        Me.SalesAgentIDComboBox.Name = "SalesAgentIDComboBox"
        Me.SalesAgentIDComboBox.Size = New System.Drawing.Size(105, 21)
        Me.SalesAgentIDComboBox.TabIndex = 18
        Me.SalesAgentIDComboBox.ValueMember = "SalesAgentID"
        '
        'SalesAgentBindingSource
        '
        Me.SalesAgentBindingSource.DataMember = "SalesAgent"
        Me.SalesAgentBindingSource.DataSource = Me.SalesAgentDataSet
        '
        'SalesAgentDataSet
        '
        Me.SalesAgentDataSet.DataSetName = "SalesAgentDataSet"
        Me.SalesAgentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TruckIDComboBox
        '
        Me.TruckIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SalesInvoiceInfoBindingSource, "TruckID", True))
        Me.TruckIDComboBox.DataSource = Me.TrucksBindingSource
        Me.TruckIDComboBox.DisplayMember = "PlateNumber"
        Me.TruckIDComboBox.FormattingEnabled = True
        Me.TruckIDComboBox.Location = New System.Drawing.Point(408, 121)
        Me.TruckIDComboBox.Name = "TruckIDComboBox"
        Me.TruckIDComboBox.Size = New System.Drawing.Size(122, 21)
        Me.TruckIDComboBox.TabIndex = 20
        Me.TruckIDComboBox.ValueMember = "TruckID"
        '
        'TrucksBindingSource
        '
        Me.TrucksBindingSource.DataMember = "Trucks"
        Me.TrucksBindingSource.DataSource = Me.TrucksDataSet
        '
        'TrucksDataSet
        '
        Me.TrucksDataSet.DataSetName = "TrucksDataSet"
        Me.TrucksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AreaIDComboBox
        '
        Me.AreaIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "AreaID", True))
        Me.AreaIDComboBox.DataSource = Me.AreasBindingSource
        Me.AreaIDComboBox.DisplayMember = "AreaName"
        Me.AreaIDComboBox.FormattingEnabled = True
        Me.AreaIDComboBox.Location = New System.Drawing.Point(147, 122)
        Me.AreaIDComboBox.Name = "AreaIDComboBox"
        Me.AreaIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AreaIDComboBox.TabIndex = 22
        Me.AreaIDComboBox.ValueMember = "AreaID"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "Areas"
        Me.AreasBindingSource.DataSource = Me.CustomersDataSetBindingSource
        '
        'DueDateDateTimePicker
        '
        Me.DueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesInvoiceInfoBindingSource, "DueDate", True))
        Me.DueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DueDateDateTimePicker.Location = New System.Drawing.Point(408, 91)
        Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
        Me.DueDateDateTimePicker.Size = New System.Drawing.Size(159, 20)
        Me.DueDateDateTimePicker.TabIndex = 24
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoiceInfoBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(147, 385)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(285, 42)
        Me.RemarksTextBox.TabIndex = 26
        '
        'TotalDiscountTextBox
        '
        Me.TotalDiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoiceInfoBindingSource, "TotalDiscount", True))
        Me.TotalDiscountTextBox.Location = New System.Drawing.Point(614, 373)
        Me.TotalDiscountTextBox.Name = "TotalDiscountTextBox"
        Me.TotalDiscountTextBox.Size = New System.Drawing.Size(167, 20)
        Me.TotalDiscountTextBox.TabIndex = 28
        '
        'BOAmountTextBox
        '
        Me.BOAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoiceInfoBindingSource, "BOAmount", True))
        Me.BOAmountTextBox.Location = New System.Drawing.Point(614, 399)
        Me.BOAmountTextBox.Name = "BOAmountTextBox"
        Me.BOAmountTextBox.Size = New System.Drawing.Size(167, 20)
        Me.BOAmountTextBox.TabIndex = 30
        '
        'TotalInvoiceAmountTextBox
        '
        Me.TotalInvoiceAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesInvoiceInfoBindingSource, "TotalInvoiceAmount", True))
        Me.TotalInvoiceAmountTextBox.Location = New System.Drawing.Point(614, 425)
        Me.TotalInvoiceAmountTextBox.Name = "TotalInvoiceAmountTextBox"
        Me.TotalInvoiceAmountTextBox.Size = New System.Drawing.Size(167, 20)
        Me.TotalInvoiceAmountTextBox.TabIndex = 32
        '
        'SalesInvoiceLineItemsBindingSource
        '
        Me.SalesInvoiceLineItemsBindingSource.DataMember = "FK_SalesInvoiceLineItems_SalesInvoiceInfo"
        Me.SalesInvoiceLineItemsBindingSource.DataSource = Me.SalesInvoiceInfoBindingSource
        '
        'SalesInvoiceLineItemsTableAdapter
        '
        Me.SalesInvoiceLineItemsTableAdapter.ClearBeforeFill = True
        '
        'SalesInvoiceLineItemsDataGridView
        '
        Me.SalesInvoiceLineItemsDataGridView.AutoGenerateColumns = False
        Me.SalesInvoiceLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesInvoiceLineItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SalesInvoiceLineItemsDataGridView.DataSource = Me.SalesInvoiceLineItemsBindingSource
        Me.SalesInvoiceLineItemsDataGridView.Location = New System.Drawing.Point(33, 160)
        Me.SalesInvoiceLineItemsDataGridView.Name = "SalesInvoiceLineItemsDataGridView"
        Me.SalesInvoiceLineItemsDataGridView.Size = New System.Drawing.Size(748, 192)
        Me.SalesInvoiceLineItemsDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Discount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'btnSaveAndNew
        '
        Me.btnSaveAndNew.Location = New System.Drawing.Point(703, 468)
        Me.btnSaveAndNew.Name = "btnSaveAndNew"
        Me.btnSaveAndNew.Size = New System.Drawing.Size(75, 36)
        Me.btnSaveAndNew.TabIndex = 33
        Me.btnSaveAndNew.Text = "Save and New"
        Me.btnSaveAndNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(450, 468)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddBO
        '
        Me.btnAddBO.Location = New System.Drawing.Point(538, 468)
        Me.btnAddBO.Name = "btnAddBO"
        Me.btnAddBO.Size = New System.Drawing.Size(75, 36)
        Me.btnAddBO.TabIndex = 34
        Me.btnAddBO.Text = "BO Pull-out"
        Me.btnAddBO.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(619, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Receive Payment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TermsTableAdapter
        '
        Me.TermsTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(316, 35)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(31, 23)
        Me.btnNewCustomer.TabIndex = 35
        Me.btnNewCustomer.Text = "..."
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnNewTerms
        '
        Me.btnNewTerms.Location = New System.Drawing.Point(536, 59)
        Me.btnNewTerms.Name = "btnNewTerms"
        Me.btnNewTerms.Size = New System.Drawing.Size(31, 23)
        Me.btnNewTerms.TabIndex = 35
        Me.btnNewTerms.Text = "..."
        Me.btnNewTerms.UseVisualStyleBackColor = True
        '
        'btnNewTruck
        '
        Me.btnNewTruck.Location = New System.Drawing.Point(535, 120)
        Me.btnNewTruck.Name = "btnNewTruck"
        Me.btnNewTruck.Size = New System.Drawing.Size(31, 23)
        Me.btnNewTruck.TabIndex = 35
        Me.btnNewTruck.Text = "..."
        Me.btnNewTruck.UseVisualStyleBackColor = True
        '
        'SalesAgentTableAdapter
        '
        Me.SalesAgentTableAdapter.ClearBeforeFill = True
        '
        'TrucksTableAdapter
        '
        Me.TrucksTableAdapter.ClearBeforeFill = True
        '
        'btnNewSalesman
        '
        Me.btnNewSalesman.Location = New System.Drawing.Point(748, 87)
        Me.btnNewSalesman.Name = "btnNewSalesman"
        Me.btnNewSalesman.Size = New System.Drawing.Size(31, 23)
        Me.btnNewSalesman.TabIndex = 35
        Me.btnNewSalesman.Text = "..."
        Me.btnNewSalesman.UseVisualStyleBackColor = True
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'NewInvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(814, 538)
        Me.Controls.Add(Me.btnNewSalesman)
        Me.Controls.Add(Me.btnNewTruck)
        Me.Controls.Add(Me.btnNewTerms)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.btnAddBO)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSaveAndNew)
        Me.Controls.Add(Me.SalesInvoiceLineItemsDataGridView)
        Me.Controls.Add(DRNoLabel)
        Me.Controls.Add(Me.DRNoTextBox)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDComboBox)
        Me.Controls.Add(DRDateLabel)
        Me.Controls.Add(Me.DRDateDateTimePicker)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NameOfOwnerLabel)
        Me.Controls.Add(Me.NameOfOwnerTextBox)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Controls.Add(TermsIDLabel)
        Me.Controls.Add(Me.TermsIDComboBox)
        Me.Controls.Add(SalesAgentIDLabel)
        Me.Controls.Add(Me.SalesAgentIDComboBox)
        Me.Controls.Add(TruckIDLabel)
        Me.Controls.Add(Me.TruckIDComboBox)
        Me.Controls.Add(AreaIDLabel)
        Me.Controls.Add(Me.AreaIDComboBox)
        Me.Controls.Add(DueDateLabel)
        Me.Controls.Add(Me.DueDateDateTimePicker)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(TotalDiscountLabel)
        Me.Controls.Add(Me.TotalDiscountTextBox)
        Me.Controls.Add(BOAmountLabel)
        Me.Controls.Add(Me.BOAmountTextBox)
        Me.Controls.Add(TotalInvoiceAmountLabel)
        Me.Controls.Add(Me.TotalInvoiceAmountTextBox)
        Me.Name = "NewInvoiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Invoice"
        CType(Me.InvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesInvoiceInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrucksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesInvoiceLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesInvoiceLineItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InvoiceDataSet As SNFxp.InvoiceDataSet
    Friend WithEvents SalesInvoiceInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesInvoiceInfoTableAdapter As SNFxp.InvoiceDataSetTableAdapters.SalesInvoiceInfoTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.InvoiceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DRNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DRDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameOfOwnerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TermsIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SalesAgentIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TruckIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AreaIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DueDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BOAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalInvoiceAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesInvoiceLineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesInvoiceLineItemsTableAdapter As SNFxp.InvoiceDataSetTableAdapters.SalesInvoiceLineItemsTableAdapter
    Friend WithEvents SalesInvoiceLineItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSaveAndNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddBO As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CustomersDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersDataSet As SNFxp.CustomersDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TermsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TermsTableAdapter As SNFxp.CustomersDataSetTableAdapters.TermsTableAdapter
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.CustomersDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents btnNewTerms As System.Windows.Forms.Button
    Friend WithEvents btnNewTruck As System.Windows.Forms.Button
    Friend WithEvents SalesAgentDataSet As SNFxp.SalesAgentDataSet
    Friend WithEvents SalesAgentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesAgentTableAdapter As SNFxp.SalesAgentDataSetTableAdapters.SalesAgentTableAdapter
    Friend WithEvents TrucksDataSet As SNFxp.TrucksDataSet
    Friend WithEvents TrucksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrucksTableAdapter As SNFxp.TrucksDataSetTableAdapters.TrucksTableAdapter
    Friend WithEvents btnNewSalesman As System.Windows.Forms.Button
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As SNFxp.CustomersDataSetTableAdapters.AreasTableAdapter
End Class
