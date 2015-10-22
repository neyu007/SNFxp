<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGroupForm
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
        Dim GroupNameLabel As System.Windows.Forms.Label
        Dim GroupDescriptionLabel As System.Windows.Forms.Label
        Dim DepartmentIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewGroupForm))
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.btnNewDept = New System.Windows.Forms.Button()
        Me.DepartmentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New SNFxp.ProductsDataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ProductDepartmentTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductDepartmentTableAdapter()
        GroupNameLabel = New System.Windows.Forms.Label()
        GroupDescriptionLabel = New System.Windows.Forms.Label()
        DepartmentIDLabel = New System.Windows.Forms.Label()
        CType(Me.ProductDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupNameLabel
        '
        GroupNameLabel.AutoSize = True
        GroupNameLabel.Location = New System.Drawing.Point(31, 29)
        GroupNameLabel.Name = "GroupNameLabel"
        GroupNameLabel.Size = New System.Drawing.Size(70, 13)
        GroupNameLabel.TabIndex = 3
        GroupNameLabel.Text = "Group Name:"
        '
        'GroupDescriptionLabel
        '
        GroupDescriptionLabel.AutoSize = True
        GroupDescriptionLabel.Location = New System.Drawing.Point(31, 55)
        GroupDescriptionLabel.Name = "GroupDescriptionLabel"
        GroupDescriptionLabel.Size = New System.Drawing.Size(95, 13)
        GroupDescriptionLabel.TabIndex = 5
        GroupDescriptionLabel.Text = "Group Description:"
        '
        'DepartmentIDLabel
        '
        DepartmentIDLabel.AutoSize = True
        DepartmentIDLabel.Location = New System.Drawing.Point(31, 116)
        DepartmentIDLabel.Name = "DepartmentIDLabel"
        DepartmentIDLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentIDLabel.TabIndex = 9
        DepartmentIDLabel.Text = "Department:"
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.Location = New System.Drawing.Point(132, 26)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(182, 20)
        Me.GroupNameTextBox.TabIndex = 4
        '
        'GroupDescriptionTextBox
        '
        Me.GroupDescriptionTextBox.Location = New System.Drawing.Point(132, 52)
        Me.GroupDescriptionTextBox.Multiline = True
        Me.GroupDescriptionTextBox.Name = "GroupDescriptionTextBox"
        Me.GroupDescriptionTextBox.Size = New System.Drawing.Size(182, 55)
        Me.GroupDescriptionTextBox.TabIndex = 6
        '
        'btnNewDept
        '
        Me.btnNewDept.Location = New System.Drawing.Point(255, 113)
        Me.btnNewDept.Name = "btnNewDept"
        Me.btnNewDept.Size = New System.Drawing.Size(59, 23)
        Me.btnNewDept.TabIndex = 9
        Me.btnNewDept.Text = "New..."
        Me.btnNewDept.UseVisualStyleBackColor = True
        '
        'DepartmentIDComboBox
        '
        Me.DepartmentIDComboBox.DataSource = Me.ProductDepartmentBindingSource
        Me.DepartmentIDComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentIDComboBox.FormattingEnabled = True
        Me.DepartmentIDComboBox.Location = New System.Drawing.Point(132, 113)
        Me.DepartmentIDComboBox.Name = "DepartmentIDComboBox"
        Me.DepartmentIDComboBox.Size = New System.Drawing.Size(105, 21)
        Me.DepartmentIDComboBox.TabIndex = 10
        Me.DepartmentIDComboBox.ValueMember = "DepartmentID"
        '
        'ProductDepartmentBindingSource
        '
        Me.ProductDepartmentBindingSource.DataMember = "ProductDepartment"
        Me.ProductDepartmentBindingSource.DataSource = Me.ProductsDataSet
        '
        'ProductsDataSet
        '
        Me.ProductsDataSet.DataSetName = "ProductsDataSet"
        Me.ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(239, 176)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(132, 176)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ProductDepartmentTableAdapter
        '
        Me.ProductDepartmentTableAdapter.ClearBeforeFill = True
        '
        'NewGroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 229)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(DepartmentIDLabel)
        Me.Controls.Add(Me.DepartmentIDComboBox)
        Me.Controls.Add(Me.btnNewDept)
        Me.Controls.Add(GroupNameLabel)
        Me.Controls.Add(Me.GroupNameTextBox)
        Me.Controls.Add(GroupDescriptionLabel)
        Me.Controls.Add(Me.GroupDescriptionTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewGroupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Group"
        CType(Me.ProductDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNewDept As System.Windows.Forms.Button
    Friend WithEvents DepartmentIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ProductsDataSet As SNFxp.ProductsDataSet
    Friend WithEvents ProductDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDepartmentTableAdapter As SNFxp.ProductsDataSetTableAdapters.ProductDepartmentTableAdapter
End Class
