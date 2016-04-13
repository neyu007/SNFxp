Public Class CustomersList



    Private Sub CustomersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.PriceLevel' table. You can move, or remove it, as needed.
        Me.PriceLevelTableAdapter.Fill(Me.CustomersDataSet.PriceLevel)
        'TODO: This line of code loads data into the 'CustomersDataSet.Terms' table. You can move, or remove it, as needed.
        Me.TermsTableAdapter.Fill(Me.CustomersDataSet.Terms)
        'TODO: This line of code loads data into the 'CustomersDataSet.Areas' table. You can move, or remove it, as needed.
        Me.AreasTableAdapter.FillByBranchID(Me.CustomersDataSet.Areas, getCurrentBranch.BranchID)

        'TODO: This line of code loads data into the 'CustomersDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.FillByBranchID(Me.CustomersDataSet.Customers, getCurrentBranch.BranchID)
        If Not lbCustomers.SelectedIndex = -1 Then
            lbCustomers.SelectedIndex = 0
        End If

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MsgBox("Access Denied.")

        'Dim CustomerID As Integer = Me.lbCustomers.SelectedValue
        'Dim StoreName As String = Me.tbStoreName.Text
        'Dim Address As String = Me.tbAddress.Text
        'Dim TermsID As Integer = Me.cbTerms.SelectedValue
        'Dim PriceLevelID As Integer = Me.cbTerms.SelectedValue
        'Console.WriteLine(StoreName & ", " & CustomerID & ", " & TermsID & ", " & PriceLevelID)
        'Call updateCustomer(CustomerID, StoreName, Address, TermsID, PriceLevelID)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CustomersTableAdapter.FillByBranchID(Me.CustomersDataSet.Customers, getCurrentBranch.BranchID)
    End Sub


    Private Sub lbCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCustomers.SelectedIndexChanged
        Try
            Call SQLconnect()
            Dim balance As Double = 0
            balance = checkCustomerBalance(lbCustomers.SelectedValue)
            tbBalance.Text = FormatNumber(balance, 2)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class