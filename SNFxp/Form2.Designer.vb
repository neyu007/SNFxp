<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.View_ProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewProdList = New SNFxp.ViewProdList()
        Me.View_ProductListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_ProductListTableAdapter = New SNFxp.ViewProdListTableAdapters.View_ProductListTableAdapter()
        Me.TableAdapterManager = New SNFxp.ViewProdListTableAdapters.TableAdapterManager()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        Me.cbCatsup = New System.Windows.Forms.CheckBox()
        Me.cbMayo = New System.Windows.Forms.CheckBox()
        Me.cbTPS = New System.Windows.Forms.CheckBox()
        Me.cbOthers = New System.Windows.Forms.CheckBox()
        CType(Me.View_ProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewProdList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_ProductListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_ProductListBindingSource
        '
        Me.View_ProductListBindingSource.DataMember = "View_ProductList"
        Me.View_ProductListBindingSource.DataSource = Me.ViewProdList
        '
        'ViewProdList
        '
        Me.ViewProdList.DataSetName = "ViewProdList"
        Me.ViewProdList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_ProductListDataGridView
        '
        Me.View_ProductListDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.View_ProductListDataGridView.AutoGenerateColumns = False
        Me.View_ProductListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_ProductListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.View_ProductListDataGridView.DataSource = Me.View_ProductListBindingSource
        Me.View_ProductListDataGridView.Location = New System.Drawing.Point(12, 112)
        Me.View_ProductListDataGridView.Name = "View_ProductListDataGridView"
        Me.View_ProductListDataGridView.Size = New System.Drawing.Size(773, 274)
        Me.View_ProductListDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GroupID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GroupID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "GroupName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "GroupName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DepartmentID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DepartmentID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DepartmentName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DepartmentName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Packaging"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Packaging"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ProductDescription"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ProductDescription"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'View_ProductListTableAdapter
        '
        Me.View_ProductListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.ViewProdListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.Location = New System.Drawing.Point(21, 41)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(37, 17)
        Me.cbAll.TabIndex = 6
        Me.cbAll.Text = "All"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'cbCatsup
        '
        Me.cbCatsup.AutoSize = True
        Me.cbCatsup.Location = New System.Drawing.Point(21, 65)
        Me.cbCatsup.Name = "cbCatsup"
        Me.cbCatsup.Size = New System.Drawing.Size(59, 17)
        Me.cbCatsup.TabIndex = 7
        Me.cbCatsup.Text = "Catsup"
        Me.cbCatsup.UseVisualStyleBackColor = True
        '
        'cbMayo
        '
        Me.cbMayo.AutoSize = True
        Me.cbMayo.Location = New System.Drawing.Point(21, 89)
        Me.cbMayo.Name = "cbMayo"
        Me.cbMayo.Size = New System.Drawing.Size(83, 17)
        Me.cbMayo.TabIndex = 8
        Me.cbMayo.Text = "Mayonnaise"
        Me.cbMayo.UseVisualStyleBackColor = True
        '
        'cbTPS
        '
        Me.cbTPS.AutoSize = True
        Me.cbTPS.Location = New System.Drawing.Point(143, 41)
        Me.cbTPS.Name = "cbTPS"
        Me.cbTPS.Size = New System.Drawing.Size(47, 17)
        Me.cbTPS.TabIndex = 9
        Me.cbTPS.Text = "TPS"
        Me.cbTPS.UseVisualStyleBackColor = True
        '
        'cbOthers
        '
        Me.cbOthers.AutoSize = True
        Me.cbOthers.Location = New System.Drawing.Point(143, 65)
        Me.cbOthers.Name = "cbOthers"
        Me.cbOthers.Size = New System.Drawing.Size(57, 17)
        Me.cbOthers.TabIndex = 10
        Me.cbOthers.Text = "Others"
        Me.cbOthers.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 398)
        Me.Controls.Add(Me.cbOthers)
        Me.Controls.Add(Me.cbTPS)
        Me.Controls.Add(Me.cbMayo)
        Me.Controls.Add(Me.cbCatsup)
        Me.Controls.Add(Me.cbAll)
        Me.Controls.Add(Me.View_ProductListDataGridView)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.View_ProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewProdList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_ProductListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewProdList As SNFxp.ViewProdList
    Friend WithEvents View_ProductListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_ProductListTableAdapter As SNFxp.ViewProdListTableAdapters.View_ProductListTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.ViewProdListTableAdapters.TableAdapterManager
    Friend WithEvents View_ProductListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbAll As System.Windows.Forms.CheckBox
    Friend WithEvents cbCatsup As System.Windows.Forms.CheckBox
    Friend WithEvents cbMayo As System.Windows.Forms.CheckBox
    Friend WithEvents cbTPS As System.Windows.Forms.CheckBox
    Friend WithEvents cbOthers As System.Windows.Forms.CheckBox
End Class
