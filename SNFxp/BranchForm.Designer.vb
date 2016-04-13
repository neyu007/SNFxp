<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BranchForm
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
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BranchForm))
        Me.SNFDatabaseDataSet = New SNFxp.SNFDatabaseDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchTableAdapter = New SNFxp.SNFDatabaseDataSetTableAdapters.BranchTableAdapter()
        Me.TableAdapterManager = New SNFxp.SNFDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BranchListBox = New System.Windows.Forms.ListBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        AddressLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        CType(Me.SNFDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(234, 60)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 2
        AddressLabel.Text = "Address:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(234, 149)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(64, 13)
        ContactNoLabel.TabIndex = 4
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
        'BranchListBox
        '
        Me.BranchListBox.DataSource = Me.BranchBindingSource
        Me.BranchListBox.DisplayMember = "BranchName"
        Me.BranchListBox.FormattingEnabled = True
        Me.BranchListBox.Location = New System.Drawing.Point(29, 54)
        Me.BranchListBox.Name = "BranchListBox"
        Me.BranchListBox.Size = New System.Drawing.Size(193, 108)
        Me.BranchListBox.TabIndex = 1
        Me.BranchListBox.ValueMember = "BranchID"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(308, 54)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(174, 86)
        Me.AddressTextBox.TabIndex = 3
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BranchBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Location = New System.Drawing.Point(308, 146)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.ReadOnly = True
        Me.ContactNoTextBox.Size = New System.Drawing.Size(174, 20)
        Me.ContactNoTextBox.TabIndex = 5
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(29, 193)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "New..."
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(147, 193)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 6
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'BranchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 264)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(ContactNoLabel)
        Me.Controls.Add(Me.ContactNoTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.BranchListBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BranchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select/Create Branch"
        CType(Me.SNFDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SNFDatabaseDataSet As SNFxp.SNFDatabaseDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.SNFDatabaseDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.SNFDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BranchListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
End Class
