<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPaymentForm
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
            SingleFormClass.newAddPayment = Nothing
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim DRNoLabel As System.Windows.Forms.Label
        Dim PRNoLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPaymentForm))
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet = New SNFxp.CustomersDataSet()
        Me.DRNoComboBox = New System.Windows.Forms.ComboBox()
        Me.PRNoTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.tbPrevBalance = New System.Windows.Forms.TextBox()
        Me.CustomersTableAdapter = New SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        CustomerIDLabel = New System.Windows.Forms.Label()
        DRNoLabel = New System.Windows.Forms.Label()
        PRNoLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(22, 28)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(84, 13)
        CustomerIDLabel.TabIndex = 3
        CustomerIDLabel.Text = "Customer/Store:"

        '
        'DRNoLabel
        '
        DRNoLabel.AutoSize = True
        DRNoLabel.Location = New System.Drawing.Point(397, 25)
        DRNoLabel.Name = "DRNoLabel"
        DRNoLabel.Size = New System.Drawing.Size(40, 13)
        DRNoLabel.TabIndex = 5
        DRNoLabel.Text = "DRNo:"
        '
        'PRNoLabel
        '
        PRNoLabel.AutoSize = True
        PRNoLabel.Location = New System.Drawing.Point(22, 55)
        PRNoLabel.Name = "PRNoLabel"
        PRNoLabel.Size = New System.Drawing.Size(39, 13)
        PRNoLabel.TabIndex = 7
        PRNoLabel.Text = "PRNo:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(22, 82)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(70, 13)
        AmountLabel.TabIndex = 9
        AmountLabel.Text = "Paid Amount:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(397, 52)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 13
        DateLabel.Text = "Date:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(22, 108)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 15
        RemarksLabel.Text = "Remarks:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(397, 82)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(96, 13)
        Label1.TabIndex = 9
        Label1.Text = "Previous Balance: "
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CustomerIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CustomerIDComboBox.DataSource = Me.CustomersBindingSource
        Me.CustomerIDComboBox.DisplayMember = "StoreName"
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(136, 25)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(167, 21)
        Me.CustomerIDComboBox.TabIndex = 4
        Me.CustomerIDComboBox.ValueMember = "CustomerID"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.CustomersDataSetBindingSource
        '
        'CustomersDataSetBindingSource
        '
        Me.CustomersDataSetBindingSource.DataSource = Me.CustomersDataSet
        Me.CustomersDataSetBindingSource.Position = 0
        '
        'CustomersDataSet
        '
        Me.CustomersDataSet.DataSetName = "CustomersDataSet"
        Me.CustomersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DRNoComboBox
        '
        Me.DRNoComboBox.FormattingEnabled = True
        Me.DRNoComboBox.Location = New System.Drawing.Point(452, 22)
        Me.DRNoComboBox.Name = "DRNoComboBox"
        Me.DRNoComboBox.Size = New System.Drawing.Size(200, 21)
        Me.DRNoComboBox.TabIndex = 6
        '
        'PRNoTextBox
        '
        Me.PRNoTextBox.Location = New System.Drawing.Point(136, 52)
        Me.PRNoTextBox.Name = "PRNoTextBox"
        Me.PRNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRNoTextBox.TabIndex = 8
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(136, 79)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox.TabIndex = 10
        Me.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Location = New System.Drawing.Point(452, 49)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 14
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.Location = New System.Drawing.Point(136, 105)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(200, 64)
        Me.RemarksTextBox.TabIndex = 16
        '
        'tbPrevBalance
        '
        Me.tbPrevBalance.Location = New System.Drawing.Point(499, 79)
        Me.tbPrevBalance.Name = "tbPrevBalance"
        Me.tbPrevBalance.Size = New System.Drawing.Size(153, 20)
        Me.tbPrevBalance.TabIndex = 10
        Me.tbPrevBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(576, 123)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 35)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save and Close"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(400, 123)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 35)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(490, 123)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(75, 35)
        Me.btnSaveNew.TabIndex = 17
        Me.btnSaveNew.Text = "Save and New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(310, 24)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(26, 23)
        Me.btnNewCustomer.TabIndex = 18
        Me.btnNewCustomer.Text = "..."
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'AddPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 203)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDComboBox)
        Me.Controls.Add(DRNoLabel)
        Me.Controls.Add(Me.DRNoComboBox)
        Me.Controls.Add(PRNoLabel)
        Me.Controls.Add(Me.PRNoTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.tbPrevBalance)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddPaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Payment"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DRNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PRNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tbPrevBalance As System.Windows.Forms.TextBox
    Friend WithEvents CustomersDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersDataSet As SNFxp.CustomersDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As SNFxp.CustomersDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSaveNew As System.Windows.Forms.Button
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
End Class
