<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserNewForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserNewForm))
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SNFDatabaseDataSet = New SNFxp.SNFDatabaseDataSet()
        Me.cbBranch = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.RolesTableAdapter = New SNFxp.SNFDatabaseDataSetTableAdapters.RolesTableAdapter()
        Me.BranchTableAdapter = New SNFxp.SNFDatabaseDataSetTableAdapters.BranchTableAdapter()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SNFDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(127, 67)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(199, 20)
        Me.tbUsername.TabIndex = 1
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(127, 93)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(199, 20)
        Me.tbPassword.TabIndex = 2
        '
        'tbConfirmPass
        '
        Me.tbConfirmPass.Location = New System.Drawing.Point(127, 119)
        Me.tbConfirmPass.Name = "tbConfirmPass"
        Me.tbConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirmPass.Size = New System.Drawing.Size(199, 20)
        Me.tbConfirmPass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Role:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Branch:"
        '
        'cbRole
        '
        Me.cbRole.DataSource = Me.RolesBindingSource
        Me.cbRole.DisplayMember = "RoleName"
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Location = New System.Drawing.Point(127, 146)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(199, 21)
        Me.cbRole.TabIndex = 4
        Me.cbRole.ValueMember = "RoleID"
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "Roles"
        Me.RolesBindingSource.DataSource = Me.SNFDatabaseDataSet
        '
        'SNFDatabaseDataSet
        '
        Me.SNFDatabaseDataSet.DataSetName = "SNFDatabaseDataSet"
        Me.SNFDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbBranch
        '
        Me.cbBranch.DataSource = Me.BranchBindingSource
        Me.cbBranch.DisplayMember = "BranchName"
        Me.cbBranch.FormattingEnabled = True
        Me.cbBranch.Location = New System.Drawing.Point(127, 176)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(199, 21)
        Me.cbBranch.TabIndex = 5
        Me.cbBranch.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.SNFDatabaseDataSet
        '
        'btnAdd
        '
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Location = New System.Drawing.Point(251, 221)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(170, 221)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'RolesTableAdapter
        '
        Me.RolesTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'UserNewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(378, 303)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cbBranch)
        Me.Controls.Add(Me.cbRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbConfirmPass)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserNewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SNFDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbRole As System.Windows.Forms.ComboBox
    Friend WithEvents cbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents SNFDatabaseDataSet As SNFxp.SNFDatabaseDataSet
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RolesTableAdapter As SNFxp.SNFDatabaseDataSetTableAdapters.RolesTableAdapter
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As SNFxp.SNFDatabaseDataSetTableAdapters.BranchTableAdapter
End Class
