<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductListForm
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
            SingleFormClass.newMonthlyInvForm = Nothing
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
        Dim ProductDescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductListForm))
        Me.ProductsListBox = New System.Windows.Forms.ListBox()
        Me.ViewProductListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewProdList = New SNFxp.ViewProdList()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New SNFxp.ProductsDataSet()
        Me.ProductDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ProductsTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New SNFxp.ProductsDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.tbOut = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.cbOthers = New System.Windows.Forms.CheckBox()
        Me.cbTPS = New System.Windows.Forms.CheckBox()
        Me.cbMayo = New System.Windows.Forms.CheckBox()
        Me.cbCatsup = New System.Windows.Forms.CheckBox()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.View_ProductListTableAdapter = New SNFxp.ViewProdListTableAdapters.View_ProductListTableAdapter()
        ProductDescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.ViewProductListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewProdList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductDescriptionLabel
        '
        ProductDescriptionLabel.AutoSize = True
        ProductDescriptionLabel.Location = New System.Drawing.Point(290, 123)
        ProductDescriptionLabel.Name = "ProductDescriptionLabel"
        ProductDescriptionLabel.Size = New System.Drawing.Size(103, 13)
        ProductDescriptionLabel.TabIndex = 2
        ProductDescriptionLabel.Text = "Product Description:"
        '
        'ProductsListBox
        '
        Me.ProductsListBox.DataSource = Me.ViewProductListBindingSource
        Me.ProductsListBox.DisplayMember = "ProductName"
        Me.ProductsListBox.FormattingEnabled = True
        Me.ProductsListBox.Location = New System.Drawing.Point(91, 106)
        Me.ProductsListBox.Name = "ProductsListBox"
        Me.ProductsListBox.Size = New System.Drawing.Size(184, 264)
        Me.ProductsListBox.TabIndex = 1
        Me.ProductsListBox.ValueMember = "ProductID"
        '
        'ViewProductListBindingSource
        '
        Me.ViewProductListBindingSource.DataMember = "View_ProductList"
        Me.ViewProductListBindingSource.DataSource = Me.ViewProdList
        '
        'ViewProdList
        '
        Me.ViewProdList.DataSetName = "ViewProdList"
        Me.ViewProdList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.ProductsDataSet
        '
        'ProductsDataSet
        '
        Me.ProductsDataSet.DataSetName = "ProductsDataSet"
        Me.ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductDescriptionTextBox
        '
        Me.ProductDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductDescription", True))
        Me.ProductDescriptionTextBox.Location = New System.Drawing.Point(399, 120)
        Me.ProductDescriptionTextBox.Multiline = True
        Me.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox"
        Me.ProductDescriptionTextBox.ReadOnly = True
        Me.ProductDescriptionTextBox.Size = New System.Drawing.Size(156, 49)
        Me.ProductDescriptionTextBox.TabIndex = 3
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Nothing
        Me.TableAdapterManager.PriceLevelTableAdapter = Nothing
        Me.TableAdapterManager.ProductDepartmentTableAdapter = Nothing
        Me.TableAdapterManager.ProductGroupTableAdapter = Nothing
        Me.TableAdapterManager.ProductPricingTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.StartingInventoryInfoTableAdapter = Nothing
        Me.TableAdapterManager.StartingInventoryLineItemsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SNFxp.ProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CityBase:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OutBase:"
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(78, 31)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(100, 20)
        Me.tbCity.TabIndex = 5
        '
        'tbOut
        '
        Me.tbOut.Location = New System.Drawing.Point(78, 60)
        Me.tbOut.Name = "tbOut"
        Me.tbOut.Size = New System.Drawing.Size(100, 20)
        Me.tbOut.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbCity)
        Me.GroupBox1.Controls.Add(Me.tbOut)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(355, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pricing"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(503, 325)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(62, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(367, 325)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(433, 325)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(62, 23)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'cbOthers
        '
        Me.cbOthers.AutoSize = True
        Me.cbOthers.Location = New System.Drawing.Point(406, 5)
        Me.cbOthers.Name = "cbOthers"
        Me.cbOthers.Size = New System.Drawing.Size(57, 17)
        Me.cbOthers.TabIndex = 15
        Me.cbOthers.Text = "Others"
        Me.cbOthers.UseVisualStyleBackColor = True
        '
        'cbTPS
        '
        Me.cbTPS.AutoSize = True
        Me.cbTPS.Location = New System.Drawing.Point(308, 5)
        Me.cbTPS.Name = "cbTPS"
        Me.cbTPS.Size = New System.Drawing.Size(47, 17)
        Me.cbTPS.TabIndex = 14
        Me.cbTPS.Text = "TPS"
        Me.cbTPS.UseVisualStyleBackColor = True
        '
        'cbMayo
        '
        Me.cbMayo.AutoSize = True
        Me.cbMayo.Location = New System.Drawing.Point(185, 5)
        Me.cbMayo.Name = "cbMayo"
        Me.cbMayo.Size = New System.Drawing.Size(83, 17)
        Me.cbMayo.TabIndex = 13
        Me.cbMayo.Text = "Mayonnaise"
        Me.cbMayo.UseVisualStyleBackColor = True
        '
        'cbCatsup
        '
        Me.cbCatsup.AutoSize = True
        Me.cbCatsup.Location = New System.Drawing.Point(80, 5)
        Me.cbCatsup.Name = "cbCatsup"
        Me.cbCatsup.Size = New System.Drawing.Size(59, 17)
        Me.cbCatsup.TabIndex = 12
        Me.cbCatsup.Text = "Catsup"
        Me.cbCatsup.UseVisualStyleBackColor = True
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.Location = New System.Drawing.Point(14, 5)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(37, 17)
        Me.cbAll.TabIndex = 11
        Me.cbAll.Text = "All"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbAll)
        Me.Panel1.Controls.Add(Me.cbOthers)
        Me.Panel1.Controls.Add(Me.cbCatsup)
        Me.Panel1.Controls.Add(Me.cbTPS)
        Me.Panel1.Controls.Add(Me.cbMayo)
        Me.Panel1.Location = New System.Drawing.Point(91, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 27)
        Me.Panel1.TabIndex = 16
        '
        'View_ProductListTableAdapter
        '
        Me.View_ProductListTableAdapter.ClearBeforeFill = True
        '
        'ProductListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 407)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(ProductDescriptionLabel)
        Me.Controls.Add(Me.ProductDescriptionTextBox)
        Me.Controls.Add(Me.ProductsListBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProductListForm"
        CType(Me.ViewProductListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewProdList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ProductDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductsDataSet As SNFxp.ProductsDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.ProductsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents tbOut As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents cbOthers As System.Windows.Forms.CheckBox
    Friend WithEvents cbTPS As System.Windows.Forms.CheckBox
    Friend WithEvents cbMayo As System.Windows.Forms.CheckBox
    Friend WithEvents cbCatsup As System.Windows.Forms.CheckBox
    Friend WithEvents cbAll As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ViewProdList As SNFxp.ViewProdList
    Friend WithEvents ViewProductListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_ProductListTableAdapter As SNFxp.ViewProdListTableAdapters.View_ProductListTableAdapter
End Class
