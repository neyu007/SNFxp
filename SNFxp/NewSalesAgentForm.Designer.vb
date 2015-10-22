<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSalesAgentForm
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
            SingleFormClass.newSalesAgentForm = Nothing
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
        Dim SalesAgentIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DateHiredLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim IsActiveLabel As System.Windows.Forms.Label
        Dim BranchIDLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewSalesAgentForm))
        Me.SalesAgentDataSet = New SNFxp.SalesAgentDataSet()
        Me.SalesAgentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesAgentTableAdapter = New SNFxp.SalesAgentDataSetTableAdapters.SalesAgentTableAdapter()
        Me.TableAdapterManager = New SNFxp.SalesAgentDataSetTableAdapters.TableAdapterManager()
        Me.SalesAgentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalesAgentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesAgentListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SalesAgentIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.DateHiredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IsActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchTableAdapter = New SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        SalesAgentIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DateHiredLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        IsActiveLabel = New System.Windows.Forms.Label()
        BranchIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesAgentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesAgentBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesAgentIDLabel
        '
        SalesAgentIDLabel.AutoSize = True
        SalesAgentIDLabel.Location = New System.Drawing.Point(252, 105)
        SalesAgentIDLabel.Name = "SalesAgentIDLabel"
        SalesAgentIDLabel.Size = New System.Drawing.Size(81, 13)
        SalesAgentIDLabel.TabIndex = 18
        SalesAgentIDLabel.Text = "Sales Agent ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(252, 131)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 20
        NameLabel.Text = "Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(252, 157)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 22
        GenderLabel.Text = "Gender:"
        '
        'DateHiredLabel
        '
        DateHiredLabel.AutoSize = True
        DateHiredLabel.Location = New System.Drawing.Point(252, 184)
        DateHiredLabel.Name = "DateHiredLabel"
        DateHiredLabel.Size = New System.Drawing.Size(61, 13)
        DateHiredLabel.TabIndex = 24
        DateHiredLabel.Text = "Date Hired:"
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Location = New System.Drawing.Point(252, 210)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(48, 13)
        BirthdayLabel.TabIndex = 26
        BirthdayLabel.Text = "Birthday:"
        '
        'IsActiveLabel
        '
        IsActiveLabel.AutoSize = True
        IsActiveLabel.Location = New System.Drawing.Point(252, 237)
        IsActiveLabel.Name = "IsActiveLabel"
        IsActiveLabel.Size = New System.Drawing.Size(50, 13)
        IsActiveLabel.TabIndex = 28
        IsActiveLabel.Text = "is Active:"
        '
        'BranchIDLabel1
        '
        BranchIDLabel1.AutoSize = True
        BranchIDLabel1.Location = New System.Drawing.Point(252, 269)
        BranchIDLabel1.Name = "BranchIDLabel1"
        BranchIDLabel1.Size = New System.Drawing.Size(58, 13)
        BranchIDLabel1.TabIndex = 30
        BranchIDLabel1.Text = "Branch ID:"
        '
        'SalesAgentDataSet
        '
        Me.SalesAgentDataSet.DataSetName = "SalesAgentDataSet"
        Me.SalesAgentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesAgentBindingSource
        '
        Me.SalesAgentBindingSource.DataMember = "SalesAgent"
        Me.SalesAgentBindingSource.DataSource = Me.SalesAgentDataSet
        '
        'SalesAgentTableAdapter
        '
        Me.SalesAgentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Nothing
        Me.TableAdapterManager.SalesAgentTableAdapter = Me.SalesAgentTableAdapter
        Me.TableAdapterManager.UpdateOrder = SNFxp.SalesAgentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesAgentBindingNavigator
        '
        Me.SalesAgentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesAgentBindingNavigator.BindingSource = Me.SalesAgentBindingSource
        Me.SalesAgentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesAgentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesAgentBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SalesAgentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesAgentBindingNavigatorSaveItem})
        Me.SalesAgentBindingNavigator.Location = New System.Drawing.Point(0, 425)
        Me.SalesAgentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesAgentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesAgentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesAgentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesAgentBindingNavigator.Name = "SalesAgentBindingNavigator"
        Me.SalesAgentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesAgentBindingNavigator.Size = New System.Drawing.Size(572, 25)
        Me.SalesAgentBindingNavigator.TabIndex = 0
        Me.SalesAgentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SalesAgentBindingNavigatorSaveItem
        '
        Me.SalesAgentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesAgentBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesAgentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesAgentBindingNavigatorSaveItem.Name = "SalesAgentBindingNavigatorSaveItem"
        Me.SalesAgentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SalesAgentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SalesAgentListBox
        '
        Me.SalesAgentListBox.DataSource = Me.SalesAgentBindingSource
        Me.SalesAgentListBox.DisplayMember = "Name"
        Me.SalesAgentListBox.FormattingEnabled = True
        Me.SalesAgentListBox.Location = New System.Drawing.Point(26, 85)
        Me.SalesAgentListBox.Name = "SalesAgentListBox"
        Me.SalesAgentListBox.Size = New System.Drawing.Size(189, 212)
        Me.SalesAgentListBox.TabIndex = 15
        Me.SalesAgentListBox.ValueMember = "SalesAgentID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 27)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sales Agent List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(206, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(111, 13)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(21, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Location = New System.Drawing.Point(245, 330)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 75)
        Me.Panel1.TabIndex = 18
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(111, 42)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'SalesAgentIDTextBox
        '
        Me.SalesAgentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesAgentBindingSource, "SalesAgentID", True))
        Me.SalesAgentIDTextBox.Location = New System.Drawing.Point(339, 102)
        Me.SalesAgentIDTextBox.Name = "SalesAgentIDTextBox"
        Me.SalesAgentIDTextBox.ReadOnly = True
        Me.SalesAgentIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalesAgentIDTextBox.TabIndex = 19
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesAgentBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(339, 128)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 21
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesAgentBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(339, 154)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 23
        '
        'DateHiredDateTimePicker
        '
        Me.DateHiredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesAgentBindingSource, "DateHired", True))
        Me.DateHiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHiredDateTimePicker.Location = New System.Drawing.Point(339, 180)
        Me.DateHiredDateTimePicker.Name = "DateHiredDateTimePicker"
        Me.DateHiredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateHiredDateTimePicker.TabIndex = 25
        '
        'BirthdayDateTimePicker
        '
        Me.BirthdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesAgentBindingSource, "Birthday", True))
        Me.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthdayDateTimePicker.Location = New System.Drawing.Point(339, 206)
        Me.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        Me.BirthdayDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BirthdayDateTimePicker.TabIndex = 27
        '
        'IsActiveCheckBox
        '
        Me.IsActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalesAgentBindingSource, "isActive", True))
        Me.IsActiveCheckBox.Location = New System.Drawing.Point(339, 232)
        Me.IsActiveCheckBox.Name = "IsActiveCheckBox"
        Me.IsActiveCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.IsActiveCheckBox.TabIndex = 29
        Me.IsActiveCheckBox.UseVisualStyleBackColor = True
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
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SalesAgentBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "BranchName"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(339, 266)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.BranchIDComboBox.TabIndex = 31
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'NewSalesAgentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(572, 450)
        Me.Controls.Add(BranchIDLabel1)
        Me.Controls.Add(Me.BranchIDComboBox)
        Me.Controls.Add(SalesAgentIDLabel)
        Me.Controls.Add(Me.SalesAgentIDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(DateHiredLabel)
        Me.Controls.Add(Me.DateHiredDateTimePicker)
        Me.Controls.Add(BirthdayLabel)
        Me.Controls.Add(Me.BirthdayDateTimePicker)
        Me.Controls.Add(IsActiveLabel)
        Me.Controls.Add(Me.IsActiveCheckBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SalesAgentListBox)
        Me.Controls.Add(Me.SalesAgentBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewSalesAgentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewSalesAgentForm"
        CType(Me.SalesAgentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesAgentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesAgentBindingNavigator.ResumeLayout(False)
        Me.SalesAgentBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalesAgentDataSet As SNFxp.SalesAgentDataSet
    Friend WithEvents SalesAgentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesAgentTableAdapter As SNFxp.SalesAgentDataSetTableAdapters.SalesAgentTableAdapter
    Friend WithEvents TableAdapterManager As SNFxp.SalesAgentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesAgentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalesAgentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalesAgentListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents SalesAgentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateHiredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BirthdayDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IsActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.SalesAgentDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
End Class
