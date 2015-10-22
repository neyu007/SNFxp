<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTermForm
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
            SingleFormClass.newTermForm = Nothing
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
        Dim TermLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim DaysDueLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewTermForm))
        Me.TermsDataSet = New SNFxp.TermsDataSet()
        Me.TermsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TermsTableAdapter = New SNFxp.TermsDataSetTableAdapters.TermsTableAdapter()
        Me.TableAdapterManager = New SNFxp.TermsDataSetTableAdapters.TableAdapterManager()
        Me.TermTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DaysDueTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        TermLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        DaysDueLabel = New System.Windows.Forms.Label()
        CType(Me.TermsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TermLabel
        '
        TermLabel.AutoSize = True
        TermLabel.Location = New System.Drawing.Point(32, 58)
        TermLabel.Name = "TermLabel"
        TermLabel.Size = New System.Drawing.Size(34, 13)
        TermLabel.TabIndex = 3
        TermLabel.Text = "Term:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(32, 117)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'DaysDueLabel
        '
        DaysDueLabel.AutoSize = True
        DaysDueLabel.Location = New System.Drawing.Point(32, 87)
        DaysDueLabel.Name = "DaysDueLabel"
        DaysDueLabel.Size = New System.Drawing.Size(57, 13)
        DaysDueLabel.TabIndex = 7
        DaysDueLabel.Text = "Days Due:"
        '
        'TermsDataSet
        '
        Me.TermsDataSet.DataSetName = "TermsDataSet"
        Me.TermsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TermsBindingSource
        '
        Me.TermsBindingSource.DataMember = "Terms"
        Me.TermsBindingSource.DataSource = Me.TermsDataSet
        '
        'TermsTableAdapter
        '
        Me.TermsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TermsTableAdapter = Me.TermsTableAdapter
        Me.TableAdapterManager.UpdateOrder = SNFxp.TermsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TermTextBox
        '
        Me.TermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TermsBindingSource, "Term", True))
        Me.TermTextBox.Location = New System.Drawing.Point(101, 55)
        Me.TermTextBox.Name = "TermTextBox"
        Me.TermTextBox.Size = New System.Drawing.Size(147, 20)
        Me.TermTextBox.TabIndex = 4
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TermsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(101, 114)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(147, 45)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'DaysDueTextBox
        '
        Me.DaysDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TermsBindingSource, "DaysDue", True))
        Me.DaysDueTextBox.Location = New System.Drawing.Point(101, 84)
        Me.DaysDueTextBox.Name = "DaysDueTextBox"
        Me.DaysDueTextBox.Size = New System.Drawing.Size(147, 20)
        Me.DaysDueTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Terms Details"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(173, 180)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(80, 180)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'NewTermForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 241)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(TermLabel)
        Me.Controls.Add(Me.TermTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(DaysDueLabel)
        Me.Controls.Add(Me.DaysDueTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewTermForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terms"
        CType(Me.TermsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TermsDataSet As SNFxp.TermsDataSet
    Friend WithEvents TermsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TermsTableAdapter As SNFxp.TermsDataSetTableAdapters.TermsTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.TermsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TermTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DaysDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
