<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAccountsReceivable
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
            SingleFormClass.addAR = Nothing
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim DRNoLabel As System.Windows.Forms.Label
        Dim TermsIDLabel As System.Windows.Forms.Label
        Dim DueDateLabel As System.Windows.Forms.Label
        Dim SalesAgentIDLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAccountsReceivable))
        Me.TableAdapterManager = New SNFxp.AccountsReceivableDataSetTableAdapters.TableAdapterManager()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet = New SNFxp.CustomersDataSet()
        Me.DRNoTextBox = New System.Windows.Forms.TextBox()
        Me.TermsIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TermsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TermsDataSet = New SNFxp.TermsDataSet()
        Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SalesAgentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SalesAgentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesAgentDataSet = New SNFxp.SalesAgentDataSet()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.SalesAgentTableAdapter = New SNFxp.SalesAgentDataSetTableAdapters.SalesAgentTableAdapter()
        Me.TermsTableAdapter = New SNFxp.TermsDataSetTableAdapters.TermsTableAdapter()
        Me.CustomersTableAdapter = New SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnNewTerms = New System.Windows.Forms.Button()
        Me.btnNewSalesAgent = New System.Windows.Forms.Button()
        CustomerIDLabel = New System.Windows.Forms.Label()
        DRNoLabel = New System.Windows.Forms.Label()
        TermsIDLabel = New System.Windows.Forms.Label()
        DueDateLabel = New System.Windows.Forms.Label()
        SalesAgentIDLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(146, 82)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(54, 13)
        CustomerIDLabel.TabIndex = 3
        CustomerIDLabel.Text = "Customer:"
        '
        'DRNoLabel
        '
        DRNoLabel.AutoSize = True
        DRNoLabel.Location = New System.Drawing.Point(146, 107)
        DRNoLabel.Name = "DRNoLabel"
        DRNoLabel.Size = New System.Drawing.Size(40, 13)
        DRNoLabel.TabIndex = 7
        DRNoLabel.Text = "DRNo:"
        '
        'TermsIDLabel
        '
        TermsIDLabel.AutoSize = True
        TermsIDLabel.Location = New System.Drawing.Point(146, 133)
        TermsIDLabel.Name = "TermsIDLabel"
        TermsIDLabel.Size = New System.Drawing.Size(39, 13)
        TermsIDLabel.TabIndex = 9
        TermsIDLabel.Text = "Terms:"
        '
        'DueDateLabel
        '
        DueDateLabel.AutoSize = True
        DueDateLabel.Location = New System.Drawing.Point(146, 161)
        DueDateLabel.Name = "DueDateLabel"
        DueDateLabel.Size = New System.Drawing.Size(74, 13)
        DueDateLabel.TabIndex = 11
        DueDateLabel.Text = "Delivery Date:"
        '
        'SalesAgentIDLabel
        '
        SalesAgentIDLabel.AutoSize = True
        SalesAgentIDLabel.Location = New System.Drawing.Point(146, 185)
        SalesAgentIDLabel.Name = "SalesAgentIDLabel"
        SalesAgentIDLabel.Size = New System.Drawing.Size(67, 13)
        SalesAgentIDLabel.TabIndex = 17
        SalesAgentIDLabel.Text = "Sales Agent:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(146, 212)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 19
        AmountLabel.Text = "Amount:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsReceivableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PaymentsReceiveTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.AccountsReceivableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustomerIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerIDComboBox.DataSource = Me.CustomersBindingSource
        Me.CustomerIDComboBox.DisplayMember = "StoreName"
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(273, 79)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(168, 21)
        Me.CustomerIDComboBox.TabIndex = 4
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
        'DRNoTextBox
        '
        Me.DRNoTextBox.Location = New System.Drawing.Point(273, 104)
        Me.DRNoTextBox.Name = "DRNoTextBox"
        Me.DRNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DRNoTextBox.TabIndex = 8
        '
        'TermsIDComboBox
        '
        Me.TermsIDComboBox.DataSource = Me.TermsBindingSource
        Me.TermsIDComboBox.DisplayMember = "Term"
        Me.TermsIDComboBox.FormattingEnabled = True
        Me.TermsIDComboBox.Location = New System.Drawing.Point(273, 130)
        Me.TermsIDComboBox.Name = "TermsIDComboBox"
        Me.TermsIDComboBox.Size = New System.Drawing.Size(168, 21)
        Me.TermsIDComboBox.TabIndex = 10
        Me.TermsIDComboBox.ValueMember = "TermsID"
        '
        'TermsBindingSource
        '
        Me.TermsBindingSource.DataMember = "Terms"
        Me.TermsBindingSource.DataSource = Me.TermsDataSet
        '
        'TermsDataSet
        '
        Me.TermsDataSet.DataSetName = "TermsDataSet"
        Me.TermsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DueDateDateTimePicker
        '
        Me.DueDateDateTimePicker.Location = New System.Drawing.Point(273, 157)
        Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
        Me.DueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DueDateDateTimePicker.TabIndex = 12
        '
        'SalesAgentIDComboBox
        '
        Me.SalesAgentIDComboBox.DataSource = Me.SalesAgentBindingSource
        Me.SalesAgentIDComboBox.DisplayMember = "Name"
        Me.SalesAgentIDComboBox.FormattingEnabled = True
        Me.SalesAgentIDComboBox.Location = New System.Drawing.Point(273, 182)
        Me.SalesAgentIDComboBox.Name = "SalesAgentIDComboBox"
        Me.SalesAgentIDComboBox.Size = New System.Drawing.Size(168, 21)
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
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(273, 209)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox.TabIndex = 20
        Me.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesAgentTableAdapter
        '
        Me.SalesAgentTableAdapter.ClearBeforeFill = True
        '
        'TermsTableAdapter
        '
        Me.TermsTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(397, 261)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(273, 261)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(448, 79)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(25, 23)
        Me.btnNewCustomer.TabIndex = 22
        Me.btnNewCustomer.Text = "..."
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnNewTerms
        '
        Me.btnNewTerms.Location = New System.Drawing.Point(447, 130)
        Me.btnNewTerms.Name = "btnNewTerms"
        Me.btnNewTerms.Size = New System.Drawing.Size(25, 23)
        Me.btnNewTerms.TabIndex = 22
        Me.btnNewTerms.Text = "..."
        Me.btnNewTerms.UseVisualStyleBackColor = True
        '
        'btnNewSalesAgent
        '
        Me.btnNewSalesAgent.Location = New System.Drawing.Point(448, 181)
        Me.btnNewSalesAgent.Name = "btnNewSalesAgent"
        Me.btnNewSalesAgent.Size = New System.Drawing.Size(25, 23)
        Me.btnNewSalesAgent.TabIndex = 22
        Me.btnNewSalesAgent.Text = "..."
        Me.btnNewSalesAgent.UseVisualStyleBackColor = True
        '
        'AddAccountsReceivable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 388)
        Me.Controls.Add(Me.btnNewSalesAgent)
        Me.Controls.Add(Me.btnNewTerms)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDComboBox)
        Me.Controls.Add(DRNoLabel)
        Me.Controls.Add(Me.DRNoTextBox)
        Me.Controls.Add(TermsIDLabel)
        Me.Controls.Add(Me.TermsIDComboBox)
        Me.Controls.Add(DueDateLabel)
        Me.Controls.Add(Me.DueDateDateTimePicker)
        Me.Controls.Add(SalesAgentIDLabel)
        Me.Controls.Add(Me.SalesAgentIDComboBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddAccountsReceivable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Accounts Receivable"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableAdapterManager As SNFxp.AccountsReceivableDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DRNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TermsIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DueDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalesAgentIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesAgentDataSet As SNFxp.SalesAgentDataSet
    Friend WithEvents SalesAgentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesAgentTableAdapter As SNFxp.SalesAgentDataSetTableAdapters.SalesAgentTableAdapter
    Friend WithEvents TermsDataSet As SNFxp.TermsDataSet
    Friend WithEvents TermsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TermsTableAdapter As SNFxp.TermsDataSetTableAdapters.TermsTableAdapter
    Friend WithEvents CustomersDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersDataSet As SNFxp.CustomersDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents btnNewTerms As System.Windows.Forms.Button
    Friend WithEvents btnNewSalesAgent As System.Windows.Forms.Button
End Class
