Public Class Home
    Private myuser As New Role
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox(getUserRole().RoleName)
        'Me.Text.("Home - " & getCurrentBranch.BranchName)
        Me.Text = "Home - " & getCurrentBranch.BranchName
        Me.tbBranchName.Text = getCurrentBranch.BranchName
    End Sub



    Private Sub btnProductList_Click(sender As Object, e As EventArgs) Handles btnProdList.Click
        Dim prodList As New ProductListForm
        prodList.MdiParent = Me.MdiParent
        prodList.Show()
        prodList.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button8.Click, Button7.Click, Button6.Click
        Dim testRp As New TestReportForm
        testRp.Show()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim usernew As New UserNewForm
        If getLoggedUser().RoleID = 1 Then
            usernew.ShowDialog()
        Else
            MsgBox("Access Denied.", MsgBoxStyle.Exclamation, "Insufficient Access")
        End If

    End Sub

    Private Sub btnMonthlyInventory_Click(sender As Object, e As EventArgs) Handles btnMonthlyInventory.Click
        If SingleFormClass.newMonthlyInvForm Is Nothing Then
            SingleFormClass.newMonthlyInvForm = New NewMonthlyInvForm
        End If
        SingleFormClass.newMonthlyInvForm.MdiParent = Me.MdiParent
        SingleFormClass.newMonthlyInvForm.Show()
        SingleFormClass.newMonthlyInvForm.Focus()
    End Sub

    Private Sub btnSalesAgent_Click(sender As Object, e As EventArgs) Handles btnSalesAgent.Click
        If SingleFormClass.newSalesAgentForm Is Nothing Then
            SingleFormClass.newSalesAgentForm = New NewSalesAgentForm
        End If
        SingleFormClass.newSalesAgentForm.MdiParent = Me.MdiParent
        SingleFormClass.newSalesAgentForm.Show()
        SingleFormClass.newSalesAgentForm.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim branchForm As New BranchForm
        branchForm.MdiParent = Me.MdiParent
        branchForm.Show()
        Me.Close()
    End Sub

    Private Sub btnShipments_Click(sender As Object, e As EventArgs) Handles btnShipments.Click
        If SingleFormClass.newShipmentsForm Is Nothing Then
            SingleFormClass.newShipmentsForm = New NewShipmentsForm
        End If
        SingleFormClass.newShipmentsForm.MdiParent = Me.MdiParent
        SingleFormClass.newShipmentsForm.Show()
        SingleFormClass.newShipmentsForm.Focus()
    End Sub

    Private Sub btnTransmittal_Click(sender As Object, e As EventArgs) Handles btnTransmittal.Click
        If SingleFormClass.newTransmittalForm Is Nothing Then
            SingleFormClass.newTransmittalForm = New NewTransmittalForm
        End If
        SingleFormClass.newTransmittalForm.MdiParent = Me.MdiParent
        SingleFormClass.newTransmittalForm.Show()
        SingleFormClass.newTransmittalForm.Focus()
    End Sub


    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        If SingleFormClass.newCustomerForm Is Nothing Then
            SingleFormClass.newCustomerForm = New NewCustomerForm
        End If
        SingleFormClass.newCustomerForm.MdiParent = Me.MdiParent
        SingleFormClass.newCustomerForm.Show()
        SingleFormClass.newCustomerForm.Focus()
    End Sub

    Private Sub btnSalesPerProd_Click(sender As Object, e As EventArgs) Handles btnSalesPerProd.Click
        Dim reportSPP As New ReportSalesPerProd
        reportSPP.Show()
    End Sub

    Private Sub btnAddWHBO_Click(sender As Object, e As EventArgs) Handles btnAddWHBO.Click
        If SingleFormClass.newWarehouseBOForm Is Nothing Then
            SingleFormClass.newWarehouseBOForm = New NewWareHouseBOForm
        End If
        SingleFormClass.newWarehouseBOForm.MdiParent = Me.MdiParent
        SingleFormClass.newWarehouseBOForm.Show()
        SingleFormClass.newWarehouseBOForm.Focus()
    End Sub

    Private Sub btnNewProduct_Click(sender As Object, e As EventArgs) Handles btnNewProduct.Click
        If SingleFormClass.prodForm Is Nothing Then
            SingleFormClass.prodForm = New ProductForm
        End If
        SingleFormClass.prodForm.MdiParent = Me.MdiParent
        SingleFormClass.prodForm.Show()
        SingleFormClass.prodForm.Focus()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New Login
        login.Show()
        Me.MdiParent.Close()
    End Sub


    Private Sub btnUserList_Click(sender As Object, e As EventArgs) Handles btnUserList.Click
        MsgBox("Not yet implemented.")
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim editPass As New EditUserForm
        editPass.ShowDialog()
    End Sub

    Private Sub btnNewInvoice_Click(sender As Object, e As EventArgs) Handles btnNewInvoice.Click
        UserModule.isNewInvoice = True
        If SingleFormClass.newInvoiceForm Is Nothing Then
            SingleFormClass.newInvoiceForm = New NewInvoiceForm
        End If
        SingleFormClass.newInvoiceForm.MdiParent = Me.MdiParent
        SingleFormClass.newInvoiceForm.Show()
        SingleFormClass.newInvoiceForm.Focus()
    End Sub
End Class