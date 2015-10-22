<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewShipmentsForm
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
            SingleFormClass.newShipmentsForm = Nothing
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
        Dim ShipmentInfoIDLabel As System.Windows.Forms.Label
        Dim FromBranchLabel As System.Windows.Forms.Label
        Dim PONumberLabel As System.Windows.Forms.Label
        Dim ShipmentDateLabel As System.Windows.Forms.Label
        Dim ReceivedDateLabel As System.Windows.Forms.Label
        Dim VanNumberLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewShipmentsForm))
        Me.TableAdapterManager = New SNFxp.ShipmentsDataSetTableAdapters.TableAdapterManager()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New SNFxp.ProductsDataSet()
        Me.ProductsTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter()
        Me.ProductPricingTableAdapter1 = New SNFxp.ProductsDataSetTableAdapters.ProductPricingTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTotalPiece = New System.Windows.Forms.TextBox()
        Me.tbTotalAmount = New System.Windows.Forms.TextBox()
        Me.tbTotalCase = New System.Windows.Forms.TextBox()
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ShipmentsDataSet = New SNFxp.ShipmentsDataSet()
        Me.ShipmentInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipmentInfoTableAdapter = New SNFxp.ShipmentsDataSetTableAdapters.ShipmentInfoTableAdapter()
        Me.ShipmentInfoIDTextBox = New System.Windows.Forms.TextBox()
        Me.FromBranchTextBox = New System.Windows.Forms.TextBox()
        Me.PONumberTextBox = New System.Windows.Forms.TextBox()
        Me.ShipmentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReceivedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VanNumberTextBox = New System.Windows.Forms.TextBox()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipmentLineItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipmentLineItemsTableAdapter = New SNFxp.ShipmentsDataSetTableAdapters.ShipmentLineItemsTableAdapter()
        Me.ShipmentLineItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QtyCase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchTableAdapter = New SNFxp.ShipmentsDataSetTableAdapters.BranchTableAdapter()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        ShipmentInfoIDLabel = New System.Windows.Forms.Label()
        FromBranchLabel = New System.Windows.Forms.Label()
        PONumberLabel = New System.Windows.Forms.Label()
        ShipmentDateLabel = New System.Windows.Forms.Label()
        ReceivedDateLabel = New System.Windows.Forms.Label()
        VanNumberLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ShipmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentLineItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentLineItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShipmentInfoIDLabel
        '
        ShipmentInfoIDLabel.AutoSize = True
        ShipmentInfoIDLabel.Location = New System.Drawing.Point(24, 24)
        ShipmentInfoIDLabel.Name = "ShipmentInfoIDLabel"
        ShipmentInfoIDLabel.Size = New System.Drawing.Size(89, 13)
        ShipmentInfoIDLabel.TabIndex = 17
        ShipmentInfoIDLabel.Text = "Shipment Info ID:"
        '
        'FromBranchLabel
        '
        FromBranchLabel.AutoSize = True
        FromBranchLabel.Location = New System.Drawing.Point(24, 50)
        FromBranchLabel.Name = "FromBranchLabel"
        FromBranchLabel.Size = New System.Drawing.Size(70, 13)
        FromBranchLabel.TabIndex = 19
        FromBranchLabel.Text = "From Branch:"
        '
        'PONumberLabel
        '
        PONumberLabel.AutoSize = True
        PONumberLabel.Location = New System.Drawing.Point(24, 76)
        PONumberLabel.Name = "PONumberLabel"
        PONumberLabel.Size = New System.Drawing.Size(62, 13)
        PONumberLabel.TabIndex = 21
        PONumberLabel.Text = "PONumber:"
        '
        'ShipmentDateLabel
        '
        ShipmentDateLabel.AutoSize = True
        ShipmentDateLabel.Location = New System.Drawing.Point(24, 103)
        ShipmentDateLabel.Name = "ShipmentDateLabel"
        ShipmentDateLabel.Size = New System.Drawing.Size(80, 13)
        ShipmentDateLabel.TabIndex = 23
        ShipmentDateLabel.Text = "Shipment Date:"
        '
        'ReceivedDateLabel
        '
        ReceivedDateLabel.AutoSize = True
        ReceivedDateLabel.Location = New System.Drawing.Point(366, 103)
        ReceivedDateLabel.Name = "ReceivedDateLabel"
        ReceivedDateLabel.Size = New System.Drawing.Size(82, 13)
        ReceivedDateLabel.TabIndex = 25
        ReceivedDateLabel.Text = "Received Date:"
        '
        'VanNumberLabel
        '
        VanNumberLabel.AutoSize = True
        VanNumberLabel.Location = New System.Drawing.Point(366, 76)
        VanNumberLabel.Name = "VanNumberLabel"
        VanNumberLabel.Size = New System.Drawing.Size(69, 13)
        VanNumberLabel.TabIndex = 27
        VanNumberLabel.Text = "Van Number:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(366, 47)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(58, 13)
        BranchIDLabel.TabIndex = 29
        BranchIDLabel.Text = "Branch ID:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(34, 314)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 29
        RemarksLabel.Text = "Remarks:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PriceLevelTableAdapter = Nothing
        Me.TableAdapterManager.ProductPricingTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.ShipmentInfoTableAdapter = Nothing
        Me.TableAdapterManager.ShipmentLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.ShipmentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'ProductPricingTableAdapter1
        '
        Me.ProductPricingTableAdapter1.ClearBeforeFill = True
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
        Me.Panel1.Location = New System.Drawing.Point(301, 311)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 120)
        Me.Panel1.TabIndex = 16
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
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(59, 364)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(115, 33)
        Me.btnSaveClose.TabIndex = 8
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(180, 364)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(115, 33)
        Me.btnSaveNew.TabIndex = 9
        Me.btnSaveNew.Text = "Save and New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(59, 398)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 33)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(180, 398)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 33)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ShipmentsDataSet
        '
        Me.ShipmentsDataSet.DataSetName = "ShipmentsDataSet"
        Me.ShipmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShipmentInfoBindingSource
        '
        Me.ShipmentInfoBindingSource.DataMember = "ShipmentInfo"
        Me.ShipmentInfoBindingSource.DataSource = Me.ShipmentsDataSet
        '
        'ShipmentInfoTableAdapter
        '
        Me.ShipmentInfoTableAdapter.ClearBeforeFill = True
        '
        'ShipmentInfoIDTextBox
        '
        Me.ShipmentInfoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipmentInfoBindingSource, "ShipmentInfoID", True))
        Me.ShipmentInfoIDTextBox.Location = New System.Drawing.Point(119, 21)
        Me.ShipmentInfoIDTextBox.Name = "ShipmentInfoIDTextBox"
        Me.ShipmentInfoIDTextBox.ReadOnly = True
        Me.ShipmentInfoIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipmentInfoIDTextBox.TabIndex = 18
        '
        'FromBranchTextBox
        '
        Me.FromBranchTextBox.AutoCompleteCustomSource.AddRange(New String() {"SNF PLANT"})
        Me.FromBranchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FromBranchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.FromBranchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipmentInfoBindingSource, "FromBranch", True))
        Me.FromBranchTextBox.Location = New System.Drawing.Point(119, 47)
        Me.FromBranchTextBox.Name = "FromBranchTextBox"
        Me.FromBranchTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FromBranchTextBox.TabIndex = 1
        '
        'PONumberTextBox
        '
        Me.PONumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipmentInfoBindingSource, "PONumber", True))
        Me.PONumberTextBox.Location = New System.Drawing.Point(119, 73)
        Me.PONumberTextBox.Name = "PONumberTextBox"
        Me.PONumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PONumberTextBox.TabIndex = 3
        '
        'ShipmentDateDateTimePicker
        '
        Me.ShipmentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ShipmentInfoBindingSource, "ShipmentDate", True))
        Me.ShipmentDateDateTimePicker.Location = New System.Drawing.Point(119, 99)
        Me.ShipmentDateDateTimePicker.Name = "ShipmentDateDateTimePicker"
        Me.ShipmentDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ShipmentDateDateTimePicker.TabIndex = 5
        '
        'ReceivedDateDateTimePicker
        '
        Me.ReceivedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ShipmentInfoBindingSource, "ReceivedDate", True))
        Me.ReceivedDateDateTimePicker.Location = New System.Drawing.Point(461, 99)
        Me.ReceivedDateDateTimePicker.Name = "ReceivedDateDateTimePicker"
        Me.ReceivedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ReceivedDateDateTimePicker.TabIndex = 6
        '
        'VanNumberTextBox
        '
        Me.VanNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipmentInfoBindingSource, "VanNumber", True))
        Me.VanNumberTextBox.Location = New System.Drawing.Point(461, 73)
        Me.VanNumberTextBox.Name = "VanNumberTextBox"
        Me.VanNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VanNumberTextBox.TabIndex = 4
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ShipmentInfoBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(461, 44)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.BranchIDComboBox.TabIndex = 2
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.ShipmentsDataSet
        '
        'ShipmentLineItemsBindingSource
        '
        Me.ShipmentLineItemsBindingSource.DataMember = "FK_ShipmentLineItems_ShipmentInfo"
        Me.ShipmentLineItemsBindingSource.DataSource = Me.ShipmentInfoBindingSource
        '
        'ShipmentLineItemsTableAdapter
        '
        Me.ShipmentLineItemsTableAdapter.ClearBeforeFill = True
        '
        'ShipmentLineItemsDataGridView
        '
        Me.ShipmentLineItemsDataGridView.AutoGenerateColumns = False
        Me.ShipmentLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShipmentLineItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.QtyCase, Me.QtyPiece, Me.UnitPrice, Me.Amount})
        Me.ShipmentLineItemsDataGridView.DataSource = Me.ShipmentLineItemsBindingSource
        Me.ShipmentLineItemsDataGridView.Location = New System.Drawing.Point(30, 136)
        Me.ShipmentLineItemsDataGridView.Name = "ShipmentLineItemsDataGridView"
        Me.ShipmentLineItemsDataGridView.Size = New System.Drawing.Size(630, 166)
        Me.ShipmentLineItemsDataGridView.TabIndex = 7
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
        '
        'UnitPrice
        '
        Me.UnitPrice.DataPropertyName = "UnitPrice"
        Me.UnitPrice.HeaderText = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShipmentInfoBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(92, 311)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(203, 47)
        Me.RemarksTextBox.TabIndex = 30
        '
        'NewShipmentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 451)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.ShipmentLineItemsDataGridView)
        Me.Controls.Add(ShipmentInfoIDLabel)
        Me.Controls.Add(Me.ShipmentInfoIDTextBox)
        Me.Controls.Add(FromBranchLabel)
        Me.Controls.Add(Me.FromBranchTextBox)
        Me.Controls.Add(PONumberLabel)
        Me.Controls.Add(Me.PONumberTextBox)
        Me.Controls.Add(ShipmentDateLabel)
        Me.Controls.Add(Me.ShipmentDateDateTimePicker)
        Me.Controls.Add(ReceivedDateLabel)
        Me.Controls.Add(Me.ReceivedDateDateTimePicker)
        Me.Controls.Add(VanNumberLabel)
        Me.Controls.Add(Me.VanNumberTextBox)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewShipmentsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewShipmentsForm"
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ShipmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentLineItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentLineItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableAdapterManager As SNFxp.ShipmentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductsDataSet As SNFxp.ProductsDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductPricingTableAdapter1 As SNFxp.ProductsDataSetTableAdapters.ProductPricingTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbTotalPiece As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalCase As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents btnSaveNew As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ShipmentsDataSet As SNFxp.ShipmentsDataSet
    Friend WithEvents ShipmentInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShipmentInfoTableAdapter As SNFxp.ShipmentsDataSetTableAdapters.ShipmentInfoTableAdapter
    Friend WithEvents ShipmentInfoIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FromBranchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PONumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipmentDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReceivedDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VanNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ShipmentLineItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShipmentLineItemsTableAdapter As SNFxp.ShipmentsDataSetTableAdapters.ShipmentLineItemsTableAdapter
    Friend WithEvents ShipmentLineItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.ShipmentsDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ProductID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QtyCase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyPiece As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
End Class
