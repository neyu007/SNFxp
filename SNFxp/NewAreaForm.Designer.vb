<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAreaForm
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
            SingleFormClass.newAreaForm = Nothing
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
        Dim AreaNameLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim TownLabel As System.Windows.Forms.Label
        Dim ProvinceLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewAreaForm))
        Me.CustomersDataSet = New SNFxp.CustomersDataSet()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreasTableAdapter = New SNFxp.CustomersDataSetTableAdapters.AreasTableAdapter()
        Me.TableAdapterManager = New SNFxp.CustomersDataSetTableAdapters.TableAdapterManager()
        Me.BranchTableAdapter = New SNFxp.CustomersDataSetTableAdapters.BranchTableAdapter()
        Me.AreaNameTextBox = New System.Windows.Forms.TextBox()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TownTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        AreaNameLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        TownLabel = New System.Windows.Forms.Label()
        ProvinceLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AreaNameLabel
        '
        AreaNameLabel.AutoSize = True
        AreaNameLabel.Location = New System.Drawing.Point(18, 23)
        AreaNameLabel.Name = "AreaNameLabel"
        AreaNameLabel.Size = New System.Drawing.Size(63, 13)
        AreaNameLabel.TabIndex = 3
        AreaNameLabel.Text = "Area Name:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(18, 49)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(44, 13)
        BranchIDLabel.TabIndex = 5
        BranchIDLabel.Text = "Branch:"
        '
        'TownLabel
        '
        TownLabel.AutoSize = True
        TownLabel.Location = New System.Drawing.Point(18, 76)
        TownLabel.Name = "TownLabel"
        TownLabel.Size = New System.Drawing.Size(37, 13)
        TownLabel.TabIndex = 7
        TownLabel.Text = "Town:"
        '
        'ProvinceLabel
        '
        ProvinceLabel.AutoSize = True
        ProvinceLabel.Location = New System.Drawing.Point(18, 102)
        ProvinceLabel.Name = "ProvinceLabel"
        ProvinceLabel.Size = New System.Drawing.Size(52, 13)
        ProvinceLabel.TabIndex = 9
        ProvinceLabel.Text = "Province:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(18, 128)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 11
        CityLabel.Text = "City:"
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "Areas"
        Me.AreasBindingSource.DataSource = Me.CustomersDataSet
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AreasTableAdapter = Me.AreasTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Me.BranchTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.PriceLevelTableAdapter = Nothing
        Me.TableAdapterManager.TermsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'AreaNameTextBox
        '
        Me.AreaNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AreasBindingSource, "AreaName", True))
        Me.AreaNameTextBox.Location = New System.Drawing.Point(87, 20)
        Me.AreaNameTextBox.Name = "AreaNameTextBox"
        Me.AreaNameTextBox.Size = New System.Drawing.Size(247, 20)
        Me.AreaNameTextBox.TabIndex = 4
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AreasBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(87, 46)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(247, 21)
        Me.BranchIDComboBox.TabIndex = 6
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.CustomersDataSet
        '
        'TownTextBox
        '
        Me.TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AreasBindingSource, "Town", True))
        Me.TownTextBox.Location = New System.Drawing.Point(87, 73)
        Me.TownTextBox.Name = "TownTextBox"
        Me.TownTextBox.Size = New System.Drawing.Size(247, 20)
        Me.TownTextBox.TabIndex = 8
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AreasBindingSource, "Province", True))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(87, 99)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(247, 20)
        Me.ProvinceTextBox.TabIndex = 10
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AreasBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(87, 125)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(247, 20)
        Me.CityTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Area Details"
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(244, 246)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(75, 37)
        Me.btnSaveClose.TabIndex = 14
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(128, 246)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 37)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(AreaNameLabel)
        Me.Panel1.Controls.Add(Me.AreaNameTextBox)
        Me.Panel1.Controls.Add(BranchIDLabel)
        Me.Panel1.Controls.Add(Me.BranchIDComboBox)
        Me.Panel1.Controls.Add(TownLabel)
        Me.Panel1.Controls.Add(Me.TownTextBox)
        Me.Panel1.Controls.Add(ProvinceLabel)
        Me.Panel1.Controls.Add(Me.ProvinceTextBox)
        Me.Panel1.Controls.Add(CityLabel)
        Me.Panel1.Controls.Add(Me.CityTextBox)
        Me.Panel1.Location = New System.Drawing.Point(40, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 168)
        Me.Panel1.TabIndex = 15
        '
        'NewAreaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewAreaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area"
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomersDataSet As SNFxp.CustomersDataSet
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As SNFxp.CustomersDataSetTableAdapters.AreasTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.CustomersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BranchTableAdapter As SNFxp.CustomersDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents AreaNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
