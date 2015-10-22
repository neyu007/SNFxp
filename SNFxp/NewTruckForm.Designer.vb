<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTruckForm
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
        Dim PlateNumberLabel As System.Windows.Forms.Label
        Dim BranchIDLabel As System.Windows.Forms.Label
        Me.TransmittalDataSet = New SNFxp.TransmittalDataSet()
        Me.TrucksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrucksTableAdapter = New SNFxp.TransmittalDataSetTableAdapters.TrucksTableAdapter()
        Me.TableAdapterManager = New SNFxp.TransmittalDataSetTableAdapters.TableAdapterManager()
        Me.PlateNumberTextBox = New System.Windows.Forms.TextBox()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SalesAgentDataSet = New SNFxp.SalesAgentDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchTableAdapter = New SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        PlateNumberLabel = New System.Windows.Forms.Label()
        BranchIDLabel = New System.Windows.Forms.Label()
        CType(Me.TransmittalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlateNumberLabel
        '
        PlateNumberLabel.AutoSize = True
        PlateNumberLabel.Location = New System.Drawing.Point(41, 96)
        PlateNumberLabel.Name = "PlateNumberLabel"
        PlateNumberLabel.Size = New System.Drawing.Size(74, 13)
        PlateNumberLabel.TabIndex = 3
        PlateNumberLabel.Text = "Plate Number:"
        '
        'BranchIDLabel
        '
        BranchIDLabel.AutoSize = True
        BranchIDLabel.Location = New System.Drawing.Point(41, 122)
        BranchIDLabel.Name = "BranchIDLabel"
        BranchIDLabel.Size = New System.Drawing.Size(58, 13)
        BranchIDLabel.TabIndex = 5
        BranchIDLabel.Text = "Branch ID:"
        '
        'TransmittalDataSet
        '
        Me.TransmittalDataSet.DataSetName = "TransmittalDataSet"
        Me.TransmittalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrucksBindingSource
        '
        Me.TrucksBindingSource.DataMember = "Trucks"
        Me.TrucksBindingSource.DataSource = Me.TransmittalDataSet
        '
        'TrucksTableAdapter
        '
        Me.TrucksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Nothing
        Me.TableAdapterManager.TransmittalInfoTableAdapter = Nothing
        Me.TableAdapterManager.TransmittalLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.TrucksTableAdapter = Me.TrucksTableAdapter
        Me.TableAdapterManager.UpdateOrder = SNFxp.TransmittalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PlateNumberTextBox
        '
        Me.PlateNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrucksBindingSource, "PlateNumber", True))
        Me.PlateNumberTextBox.Location = New System.Drawing.Point(121, 93)
        Me.PlateNumberTextBox.Name = "PlateNumberTextBox"
        Me.PlateNumberTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PlateNumberTextBox.TabIndex = 4
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(121, 119)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BranchIDComboBox.TabIndex = 6
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'SalesAgentDataSet
        '
        Me.SalesAgentDataSet.DataSetName = "SalesAgentDataSet"
        Me.SalesAgentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.SalesAgentDataSet
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(167, 168)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(70, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NewTruckForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(PlateNumberLabel)
        Me.Controls.Add(Me.PlateNumberTextBox)
        Me.Controls.Add(BranchIDLabel)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Name = "NewTruckForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Truck"
        CType(Me.TransmittalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrucksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransmittalDataSet As SNFxp.TransmittalDataSet
    Friend WithEvents TrucksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrucksTableAdapter As SNFxp.TransmittalDataSetTableAdapters.TrucksTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.TransmittalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlateNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SalesAgentDataSet As SNFxp.SalesAgentDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
