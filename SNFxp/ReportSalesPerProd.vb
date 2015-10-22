Public Class ReportSalesPerProd



    Private Sub ReportSalesPerProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.ProductsTest' table. You can move, or remove it, as needed.
        Me.ProductsTestTableAdapter.Fill(Me.CustomersDataSet.ProductsTest)


        Dim rp As New Microsoft.Reporting.WinForms.ReportParameter("BranchName", "ILOILO BRANCH")
        Me.ReportViewer1.LocalReport.SetParameters(rp)


        Me.ReportViewer1.RefreshReport()
        'Dim branchName, branchAddress As String

        'branchName = getCurrentBranch.BranchName
        'branchAddress = getCurrentBranch.Address


    End Sub
End Class