<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomerForm
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
            SingleFormClass.newCustomerForm = Nothing
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
        Dim StoreNameLabel As System.Windows.Forms.Label
        Dim NameOfOwnerLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim PriceLevelIDLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim TermsIDLabel As System.Windows.Forms.Label
        Dim AreaIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCustomerForm))
        Me.CustomersDataSet = New SNFxp.CustomersDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New SNFxp.CustomersDataSetTableAdapters.TableAdapterManager()
        Me.NameOfOwnerTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceLevelIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceLevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.TermsIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TermsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreaIDComboBox = New System.Windows.Forms.ComboBox()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BranchTableAdapter = New SNFxp.CustomersDataSetTableAdapters.BranchTableAdapter()
        Me.AreasTableAdapter = New SNFxp.CustomersDataSetTableAdapters.AreasTableAdapter()
        Me.TermsTableAdapter = New SNFxp.CustomersDataSetTableAdapters.TermsTableAdapter()
        Me.PriceLevelTableAdapter = New SNFxp.CustomersDataSetTableAdapters.PriceLevelTableAdapter()
        Me.btnNewArea = New System.Windows.Forms.Button()
        Me.btnNewTerm = New System.Windows.Forms.Button()
        Me.StoreNameTextBox = New System.Windows.Forms.TextBox()
        StoreNameLabel = New System.Windows.Forms.Label()
        NameOfOwnerLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        PriceLevelIDLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        TermsIDLabel = New System.Windows.Forms.Label()
        AreaIDLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceLevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StoreNameLabel
        '
        StoreNameLabel.AutoSize = True
        StoreNameLabel.Location = New System.Drawing.Point(16, 93)
        StoreNameLabel.Name = "StoreNameLabel"
        StoreNameLabel.Size = New System.Drawing.Size(66, 13)
        StoreNameLabel.TabIndex = 3
        StoreNameLabel.Text = "Store Name:"
        '
        'NameOfOwnerLabel
        '
        NameOfOwnerLabel.AutoSize = True
        NameOfOwnerLabel.Location = New System.Drawing.Point(16, 119)
        NameOfOwnerLabel.Name = "NameOfOwnerLabel"
        NameOfOwnerLabel.Size = New System.Drawing.Size(86, 13)
        NameOfOwnerLabel.TabIndex = 5
        NameOfOwnerLabel.Text = "Name Of Owner:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(16, 174)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 7
        AddressLabel.Text = "Address:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(363, 93)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(58, 13)
        BranchIDLabel.TabIndex = 9
        BranchIDLabel.Text = "Branch ID:"
        '
        'PriceLevelIDLabel
        '
        PriceLevelIDLabel.AutoSize = True
        PriceLevelIDLabel.Location = New System.Drawing.Point(363, 121)
        PriceLevelIDLabel.Name = "PriceLevelIDLabel"
        PriceLevelIDLabel.Size = New System.Drawing.Size(77, 13)
        PriceLevelIDLabel.TabIndex = 11
        PriceLevelIDLabel.Text = "Price Level ID:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(363, 176)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 13
        RemarksLabel.Text = "Remarks:"
        '
        'TermsIDLabel
        '
        TermsIDLabel.AutoSize = True
        TermsIDLabel.Location = New System.Drawing.Point(363, 150)
        TermsIDLabel.Name = "TermsIDLabel"
        TermsIDLabel.Size = New System.Drawing.Size(53, 13)
        TermsIDLabel.TabIndex = 15
        TermsIDLabel.Text = "Terms ID:"
        '
        'AreaIDLabel
        '
        AreaIDLabel.AutoSize = True
        AreaIDLabel.Location = New System.Drawing.Point(18, 145)
        AreaIDLabel.Name = "AreaIDLabel"
        AreaIDLabel.Size = New System.Drawing.Size(46, 13)
        AreaIDLabel.TabIndex = 17
        AreaIDLabel.Text = "Area ID:"
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.CustomersDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.PriceLevelTableAdapter = Nothing
        Me.TableAdapterManager.TermsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameOfOwnerTextBox
        '
        Me.NameOfOwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "NameOfOwner", True))
        Me.NameOfOwnerTextBox.Location = New System.Drawing.Point(108, 116)
        Me.NameOfOwnerTextBox.Name = "NameOfOwnerTextBox"
        Me.NameOfOwnerTextBox.Size = New System.Drawing.Size(218, 20)
        Me.NameOfOwnerTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(108, 171)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(218, 43)
        Me.AddressTextBox.TabIndex = 4
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.ItemHeight = 13
        Me.BranchIDComboBox.Location = New System.Drawing.Point(455, 90)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(191, 21)
        Me.BranchIDComboBox.TabIndex = 5
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.CustomersDataSet
        '
        'PriceLevelIDComboBox
        '
        Me.PriceLevelIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "PriceLevelID", True))
        Me.PriceLevelIDComboBox.DataSource = Me.PriceLevelBindingSource
        Me.PriceLevelIDComboBox.DisplayMember = "PriceLevelName"
        Me.PriceLevelIDComboBox.FormattingEnabled = True
        Me.PriceLevelIDComboBox.Location = New System.Drawing.Point(455, 118)
        Me.PriceLevelIDComboBox.Name = "PriceLevelIDComboBox"
        Me.PriceLevelIDComboBox.Size = New System.Drawing.Size(191, 21)
        Me.PriceLevelIDComboBox.TabIndex = 6
        Me.PriceLevelIDComboBox.ValueMember = "PriceLevelID"
        '
        'PriceLevelBindingSource
        '
        Me.PriceLevelBindingSource.DataMember = "PriceLevel"
        Me.PriceLevelBindingSource.DataSource = Me.CustomersDataSet
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(455, 174)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(191, 40)
        Me.RemarksTextBox.TabIndex = 8
        '
        'TermsIDComboBox
        '
        Me.TermsIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TermsIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TermsIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "TermsID", True))
        Me.TermsIDComboBox.DataSource = Me.TermsBindingSource
        Me.TermsIDComboBox.DisplayMember = "Term"
        Me.TermsIDComboBox.FormattingEnabled = True
        Me.TermsIDComboBox.Location = New System.Drawing.Point(455, 147)
        Me.TermsIDComboBox.Name = "TermsIDComboBox"
        Me.TermsIDComboBox.Size = New System.Drawing.Size(155, 21)
        Me.TermsIDComboBox.TabIndex = 7
        Me.TermsIDComboBox.ValueMember = "TermsID"
        '
        'TermsBindingSource
        '
        Me.TermsBindingSource.DataMember = "Terms"
        Me.TermsBindingSource.DataSource = Me.CustomersDataSet
        '
        'AreaIDComboBox
        '
        Me.AreaIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AreaIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AreaIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "AreaID", True))
        Me.AreaIDComboBox.DataSource = Me.AreasBindingSource
        Me.AreaIDComboBox.DisplayMember = "AreaName"
        Me.AreaIDComboBox.FormattingEnabled = True
        Me.AreaIDComboBox.Location = New System.Drawing.Point(110, 142)
        Me.AreaIDComboBox.Name = "AreaIDComboBox"
        Me.AreaIDComboBox.Size = New System.Drawing.Size(181, 21)
        Me.AreaIDComboBox.TabIndex = 3
        Me.AreaIDComboBox.ValueMember = "AreaID"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "Areas"
        Me.AreasBindingSource.DataSource = Me.CustomersDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Customer Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveClose
        '
        Me.btnSaveClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSaveClose.Location = New System.Drawing.Point(542, 235)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(104, 36)
        Me.btnSaveClose.TabIndex = 11
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(432, 235)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(104, 36)
        Me.btnSaveNew.TabIndex = 10
        Me.btnSaveNew.Text = "Save and New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(322, 235)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 36)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'TermsTableAdapter
        '
        Me.TermsTableAdapter.ClearBeforeFill = True
        '
        'PriceLevelTableAdapter
        '
        Me.PriceLevelTableAdapter.ClearBeforeFill = True
        '
        'btnNewArea
        '
        Me.btnNewArea.Location = New System.Drawing.Point(295, 141)
        Me.btnNewArea.Name = "btnNewArea"
        Me.btnNewArea.Size = New System.Drawing.Size(29, 23)
        Me.btnNewArea.TabIndex = 21
        Me.btnNewArea.Text = "..."
        Me.btnNewArea.UseVisualStyleBackColor = True
        '
        'btnNewTerm
        '
        Me.btnNewTerm.Location = New System.Drawing.Point(617, 147)
        Me.btnNewTerm.Name = "btnNewTerm"
        Me.btnNewTerm.Size = New System.Drawing.Size(29, 23)
        Me.btnNewTerm.TabIndex = 21
        Me.btnNewTerm.Text = "..."
        Me.btnNewTerm.UseVisualStyleBackColor = True
        '
        'StoreNameTextBox
        '
        Me.StoreNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StoreName", True))
        Me.StoreNameTextBox.Location = New System.Drawing.Point(108, 90)
        Me.StoreNameTextBox.Name = "StoreNameTextBox"
        Me.StoreNameTextBox.Size = New System.Drawing.Size(218, 20)
        Me.StoreNameTextBox.TabIndex = 1
        '
        'NewCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(677, 317)
        Me.Controls.Add(Me.btnNewTerm)
        Me.Controls.Add(Me.btnNewArea)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(StoreNameLabel)
        Me.Controls.Add(Me.StoreNameTextBox)
        Me.Controls.Add(NameOfOwnerLabel)
        Me.Controls.Add(Me.NameOfOwnerTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Controls.Add(PriceLevelIDLabel)
        Me.Controls.Add(Me.PriceLevelIDComboBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(TermsIDLabel)
        Me.Controls.Add(Me.TermsIDComboBox)
        Me.Controls.Add(AreaIDLabel)
        Me.Controls.Add(Me.AreaIDComboBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewCustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceLevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomersDataSet As SNFxp.CustomersDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.CustomersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameOfOwnerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PriceLevelIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TermsIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AreaIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents btnSaveNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.CustomersDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As SNFxp.CustomersDataSetTableAdapters.AreasTableAdapter
    Friend WithEvents TermsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TermsTableAdapter As SNFxp.CustomersDataSetTableAdapters.TermsTableAdapter
    Friend WithEvents PriceLevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceLevelTableAdapter As SNFxp.CustomersDataSetTableAdapters.PriceLevelTableAdapter
    Friend WithEvents btnNewArea As System.Windows.Forms.Button
    Friend WithEvents btnNewTerm As System.Windows.Forms.Button
    Friend WithEvents StoreNameTextBox As System.Windows.Forms.TextBox
End Class
