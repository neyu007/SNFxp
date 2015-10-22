<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
            SingleFormClass.prodForm = Nothing
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
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim PackagingLabel As System.Windows.Forms.Label
        Dim IsActiveLabel As System.Windows.Forms.Label
        Dim ReorderLevelLabel As System.Windows.Forms.Label
        Dim GroupIDLabel As System.Windows.Forms.Label
        Dim ProductDescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductForm))
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.PackagingTextBox = New System.Windows.Forms.TextBox()
        Me.IsActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReorderLevelTextBox = New System.Windows.Forms.TextBox()
        Me.GroupIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New SNFxp.ProductsDataSet()
        Me.ProductDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.btnNewGroup = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbOutPrice = New System.Windows.Forms.TextBox()
        Me.tbCityPrice = New System.Windows.Forms.TextBox()
        Me.ProductGroupTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductGroupTableAdapter()
        ProductNameLabel = New System.Windows.Forms.Label()
        PackagingLabel = New System.Windows.Forms.Label()
        IsActiveLabel = New System.Windows.Forms.Label()
        ReorderLevelLabel = New System.Windows.Forms.Label()
        GroupIDLabel = New System.Windows.Forms.Label()
        ProductDescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(60, 42)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(78, 13)
        ProductNameLabel.TabIndex = 3
        ProductNameLabel.Text = "Product Name:"
        '
        'PackagingLabel
        '
        PackagingLabel.AutoSize = True
        PackagingLabel.Location = New System.Drawing.Point(60, 68)
        PackagingLabel.Name = "PackagingLabel"
        PackagingLabel.Size = New System.Drawing.Size(61, 13)
        PackagingLabel.TabIndex = 5
        PackagingLabel.Text = "Packaging:"
        '
        'IsActiveLabel
        '
        IsActiveLabel.AutoSize = True
        IsActiveLabel.Location = New System.Drawing.Point(309, 68)
        IsActiveLabel.Name = "IsActiveLabel"
        IsActiveLabel.Size = New System.Drawing.Size(40, 13)
        IsActiveLabel.TabIndex = 7
        IsActiveLabel.Text = "Active:"
        '
        'ReorderLevelLabel
        '
        ReorderLevelLabel.AutoSize = True
        ReorderLevelLabel.Location = New System.Drawing.Point(60, 95)
        ReorderLevelLabel.Name = "ReorderLevelLabel"
        ReorderLevelLabel.Size = New System.Drawing.Size(77, 13)
        ReorderLevelLabel.TabIndex = 9
        ReorderLevelLabel.Text = "Reorder Level:"
        '
        'GroupIDLabel
        '
        GroupIDLabel.AutoSize = True
        GroupIDLabel.Location = New System.Drawing.Point(60, 121)
        GroupIDLabel.Name = "GroupIDLabel"
        GroupIDLabel.Size = New System.Drawing.Size(39, 13)
        GroupIDLabel.TabIndex = 11
        GroupIDLabel.Text = "Group:"
        '
        'ProductDescriptionLabel
        '
        ProductDescriptionLabel.AutoSize = True
        ProductDescriptionLabel.Location = New System.Drawing.Point(60, 148)
        ProductDescriptionLabel.Name = "ProductDescriptionLabel"
        ProductDescriptionLabel.Size = New System.Drawing.Size(103, 13)
        ProductDescriptionLabel.TabIndex = 13
        ProductDescriptionLabel.Text = "Product Description:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Location = New System.Drawing.Point(169, 39)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(235, 20)
        Me.ProductNameTextBox.TabIndex = 4
        '
        'PackagingTextBox
        '
        Me.PackagingTextBox.Location = New System.Drawing.Point(169, 65)
        Me.PackagingTextBox.Name = "PackagingTextBox"
        Me.PackagingTextBox.Size = New System.Drawing.Size(102, 20)
        Me.PackagingTextBox.TabIndex = 6
        '
        'IsActiveCheckBox
        '
        Me.IsActiveCheckBox.Checked = True
        Me.IsActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IsActiveCheckBox.Location = New System.Drawing.Point(355, 63)
        Me.IsActiveCheckBox.Name = "IsActiveCheckBox"
        Me.IsActiveCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.IsActiveCheckBox.TabIndex = 8
        Me.IsActiveCheckBox.UseVisualStyleBackColor = True
        '
        'ReorderLevelTextBox
        '
        Me.ReorderLevelTextBox.Location = New System.Drawing.Point(169, 92)
        Me.ReorderLevelTextBox.Name = "ReorderLevelTextBox"
        Me.ReorderLevelTextBox.Size = New System.Drawing.Size(102, 20)
        Me.ReorderLevelTextBox.TabIndex = 10
        '
        'GroupIDComboBox
        '
        Me.GroupIDComboBox.DataSource = Me.ProductGroupBindingSource
        Me.GroupIDComboBox.DisplayMember = "GroupName"
        Me.GroupIDComboBox.FormattingEnabled = True
        Me.GroupIDComboBox.Location = New System.Drawing.Point(169, 118)
        Me.GroupIDComboBox.Name = "GroupIDComboBox"
        Me.GroupIDComboBox.Size = New System.Drawing.Size(149, 21)
        Me.GroupIDComboBox.TabIndex = 12
        Me.GroupIDComboBox.ValueMember = "GroupID"
        '
        'ProductGroupBindingSource
        '
        Me.ProductGroupBindingSource.DataMember = "ProductGroup"
        Me.ProductGroupBindingSource.DataSource = Me.ProductsDataSet
        '
        'ProductsDataSet
        '
        Me.ProductsDataSet.DataSetName = "ProductsDataSet"
        Me.ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductDescriptionTextBox
        '
        Me.ProductDescriptionTextBox.Location = New System.Drawing.Point(169, 145)
        Me.ProductDescriptionTextBox.Multiline = True
        Me.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox"
        Me.ProductDescriptionTextBox.Size = New System.Drawing.Size(235, 56)
        Me.ProductDescriptionTextBox.TabIndex = 14
        '
        'btnNewGroup
        '
        Me.btnNewGroup.Location = New System.Drawing.Point(329, 116)
        Me.btnNewGroup.Name = "btnNewGroup"
        Me.btnNewGroup.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGroup.TabIndex = 15
        Me.btnNewGroup.Text = "New..."
        Me.btnNewGroup.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(178, 326)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(314, 326)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbOutPrice)
        Me.GroupBox1.Controls.Add(Me.tbCityPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(169, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 97)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pricing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Out Base:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "City Base:"
        '
        'tbOutPrice
        '
        Me.tbOutPrice.Location = New System.Drawing.Point(90, 59)
        Me.tbOutPrice.Name = "tbOutPrice"
        Me.tbOutPrice.Size = New System.Drawing.Size(112, 20)
        Me.tbOutPrice.TabIndex = 0
        Me.tbOutPrice.Text = "0"
        Me.tbOutPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCityPrice
        '
        Me.tbCityPrice.Location = New System.Drawing.Point(90, 33)
        Me.tbCityPrice.Name = "tbCityPrice"
        Me.tbCityPrice.Size = New System.Drawing.Size(112, 20)
        Me.tbCityPrice.TabIndex = 0
        Me.tbCityPrice.Text = "0"
        Me.tbCityPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProductGroupTableAdapter
        '
        Me.ProductGroupTableAdapter.ClearBeforeFill = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(480, 374)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNewGroup)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(PackagingLabel)
        Me.Controls.Add(Me.PackagingTextBox)
        Me.Controls.Add(IsActiveLabel)
        Me.Controls.Add(Me.IsActiveCheckBox)
        Me.Controls.Add(ReorderLevelLabel)
        Me.Controls.Add(Me.ReorderLevelTextBox)
        Me.Controls.Add(GroupIDLabel)
        Me.Controls.Add(Me.GroupIDComboBox)
        Me.Controls.Add(ProductDescriptionLabel)
        Me.Controls.Add(Me.ProductDescriptionTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductForm"
        CType(Me.ProductGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PackagingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ReorderLevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNewGroup As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbOutPrice As System.Windows.Forms.TextBox
    Friend WithEvents tbCityPrice As System.Windows.Forms.TextBox
    Friend WithEvents ProductsDataSet As SNFxp.ProductsDataSet
    Friend WithEvents ProductGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductGroupTableAdapter As SNFxp.ProductsDataSetTableAdapters.ProductGroupTableAdapter
End Class
