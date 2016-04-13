<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BranchNewForm
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
        Dim BranchIDLabel As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BranchNewForm))
        Me.SNFDatabaseDataSet = New SNFxp.SNFDatabaseDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchTableAdapter = New SNFxp.SNFDatabaseDataSetTableAdapters.BranchTableAdapter()
        Me.TableAdapterManager = New SNFxp.SNFDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BranchIDTextBox = New System.Windows.Forms.TextBox()
        Me.BranchNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        BranchIDLabel = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        CType(Me.SNFDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(39, 51)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(58, 13)
        BranchIDLabel.TabIndex = 1
        BranchIDLabel.Text = "Branch ID:"
        '
        'BranchNameLabel
        '
        BranchNameLabel.AutoSize = True
        BranchNameLabel.Location = New System.Drawing.Point(39, 77)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(75, 13)
        BranchNameLabel.TabIndex = 3
        BranchNameLabel.Text = "Branch Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(39, 103)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(39, 173)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(64, 13)
        ContactNoLabel.TabIndex = 7
        ContactNoLabel.Text = "Contact No:"
        '
        'SNFDatabaseDataSet
        '
        Me.SNFDatabaseDataSet.DataSetName = "SNFDatabaseDataSet"
        Me.SNFDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.SNFDatabaseDataSet
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Me.BranchTableAdapter
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.SNFDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'BranchIDTextBox
        '
        Me.BranchIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBindingSource, "BranchID", True))
        Me.BranchIDTextBox.Location = New System.Drawing.Point(120, 48)
        Me.BranchIDTextBox.Name = "BranchIDTextBox"
        Me.BranchIDTextBox.ReadOnly = True
        Me.BranchIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BranchIDTextBox.TabIndex = 2
        '
        'BranchNameTextBox
        '
        Me.BranchNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBindingSource, "BranchName", True))
        Me.BranchNameTextBox.Location = New System.Drawing.Point(120, 74)
        Me.BranchNameTextBox.Name = "BranchNameTextBox"
        Me.BranchNameTextBox.Size = New System.Drawing.Size(207, 20)
        Me.BranchNameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(120, 100)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(207, 64)
        Me.AddressTextBox.TabIndex = 6
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Location = New System.Drawing.Point(120, 170)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(207, 20)
        Me.ContactNoTextBox.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(251, 208)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(120, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BranchNewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 262)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDTextBox)
        Me.Controls.Add(BranchNameLabel)
        Me.Controls.Add(Me.BranchNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(ContactNoLabel)
        Me.Controls.Add(Me.ContactNoTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BranchNewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BranchNewForm"
        CType(Me.SNFDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SNFDatabaseDataSet As SNFxp.SNFDatabaseDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.SNFDatabaseDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.SNFDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BranchIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
