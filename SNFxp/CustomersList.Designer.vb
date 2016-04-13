<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersList
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
            SingleFormClass.customerListForm = Nothing
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
        Me.lbCustomers = New System.Windows.Forms.ListBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet = New SNFxp.CustomersDataSet()
        Me.CustomersTableAdapter = New SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter()
        Me.tbStoreName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreasTableAdapter = New SNFxp.CustomersDataSetTableAdapters.AreasTableAdapter()
        Me.cbTerms = New System.Windows.Forms.ComboBox()
        Me.TermsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbPriceLevel = New System.Windows.Forms.ComboBox()
        Me.PriceLevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TermsTableAdapter = New SNFxp.CustomersDataSetTableAdapters.TermsTableAdapter()
        Me.PriceLevelTableAdapter = New SNFxp.CustomersDataSetTableAdapters.PriceLevelTableAdapter()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.FKCustomersAreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbBalance = New System.Windows.Forms.TextBox()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceLevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKCustomersAreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCustomers
        '
        Me.lbCustomers.DataSource = Me.CustomersBindingSource
        Me.lbCustomers.DisplayMember = "StoreName"
        Me.lbCustomers.FormattingEnabled = True
        Me.lbCustomers.Location = New System.Drawing.Point(45, 63)
        Me.lbCustomers.Name = "lbCustomers"
        Me.lbCustomers.Size = New System.Drawing.Size(152, 329)
        Me.lbCustomers.TabIndex = 0
        Me.lbCustomers.ValueMember = "CustomerID"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.CustomersDataSet
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'tbStoreName
        '
        Me.tbStoreName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StoreName", True))
        Me.tbStoreName.Location = New System.Drawing.Point(266, 86)
        Me.tbStoreName.Name = "tbStoreName"
        Me.tbStoreName.ReadOnly = True
        Me.tbStoreName.Size = New System.Drawing.Size(237, 20)
        Me.tbStoreName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Store/Customer Name: "
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "StoreName", True))
        Me.TextBox1.Location = New System.Drawing.Point(266, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(237, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Area: "
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(266, 173)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(237, 20)
        Me.TextBox4.TabIndex = 1
        '
        'tbAddress
        '
        Me.tbAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.tbAddress.Location = New System.Drawing.Point(266, 173)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.ReadOnly = True
        Me.tbAddress.Size = New System.Drawing.Size(237, 63)
        Me.tbAddress.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Terms:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Price Level:"
        '
        'cbArea
        '
        Me.cbArea.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "AreaID", True))
        Me.cbArea.DataSource = Me.AreasBindingSource
        Me.cbArea.DisplayMember = "AreaName"
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(266, 128)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(237, 21)
        Me.cbArea.TabIndex = 3
        Me.cbArea.ValueMember = "AreaID"
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
        'cbTerms
        '
        Me.cbTerms.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "TermsID", True))
        Me.cbTerms.DataSource = Me.TermsBindingSource
        Me.cbTerms.DisplayMember = "Term"
        Me.cbTerms.FormattingEnabled = True
        Me.cbTerms.Location = New System.Drawing.Point(266, 255)
        Me.cbTerms.Name = "cbTerms"
        Me.cbTerms.Size = New System.Drawing.Size(237, 21)
        Me.cbTerms.TabIndex = 3
        Me.cbTerms.ValueMember = "TermsID"
        '
        'TermsBindingSource
        '
        Me.TermsBindingSource.DataMember = "Terms"
        Me.TermsBindingSource.DataSource = Me.CustomersDataSet
        '
        'cbPriceLevel
        '
        Me.cbPriceLevel.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "PriceLevelID", True))
        Me.cbPriceLevel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PriceLevelBindingSource, "PriceLevelName", True))
        Me.cbPriceLevel.DataSource = Me.PriceLevelBindingSource
        Me.cbPriceLevel.DisplayMember = "PriceLevelName"
        Me.cbPriceLevel.FormattingEnabled = True
        Me.cbPriceLevel.Location = New System.Drawing.Point(266, 295)
        Me.cbPriceLevel.Name = "cbPriceLevel"
        Me.cbPriceLevel.Size = New System.Drawing.Size(237, 21)
        Me.cbPriceLevel.TabIndex = 3
        Me.cbPriceLevel.ValueMember = "PriceLevelID"
        '
        'PriceLevelBindingSource
        '
        Me.PriceLevelBindingSource.DataMember = "PriceLevel"
        Me.PriceLevelBindingSource.DataSource = Me.CustomersDataSet
        '
        'TermsTableAdapter
        '
        Me.TermsTableAdapter.ClearBeforeFill = True
        '
        'PriceLevelTableAdapter
        '
        Me.PriceLevelTableAdapter.ClearBeforeFill = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(233, 369)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'FKCustomersAreasBindingSource
        '
        Me.FKCustomersAreasBindingSource.DataMember = "FK_Customers_Areas"
        Me.FKCustomersAreasBindingSource.DataSource = Me.AreasBindingSource
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Update List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(233, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Balance: "
        '
        'tbBalance
        '
        Me.tbBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBalance.ForeColor = System.Drawing.Color.DarkRed
        Me.tbBalance.Location = New System.Drawing.Point(370, 330)
        Me.tbBalance.Name = "tbBalance"
        Me.tbBalance.ReadOnly = True
        Me.tbBalance.Size = New System.Drawing.Size(133, 26)
        Me.tbBalance.TabIndex = 6
        Me.tbBalance.Text = "0.00"
        Me.tbBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CustomersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 429)
        Me.Controls.Add(Me.tbBalance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cbPriceLevel)
        Me.Controls.Add(Me.cbTerms)
        Me.Controls.Add(Me.cbArea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tbStoreName)
        Me.Controls.Add(Me.lbCustomers)
        Me.Name = "CustomersList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomersList"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceLevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKCustomersAreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCustomers As System.Windows.Forms.ListBox
    Friend WithEvents CustomersDataSet As SNFxp.CustomersDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents tbStoreName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As SNFxp.CustomersDataSetTableAdapters.AreasTableAdapter
    Friend WithEvents cbTerms As System.Windows.Forms.ComboBox
    Friend WithEvents cbPriceLevel As System.Windows.Forms.ComboBox
    Friend WithEvents TermsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TermsTableAdapter As SNFxp.CustomersDataSetTableAdapters.TermsTableAdapter
    Friend WithEvents PriceLevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceLevelTableAdapter As SNFxp.CustomersDataSetTableAdapters.PriceLevelTableAdapter
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents FKCustomersAreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbBalance As System.Windows.Forms.TextBox
End Class
