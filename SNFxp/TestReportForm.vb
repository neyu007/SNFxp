Imports Microsoft.Reporting.WinForms
Public Class TestReportForm

    Private Sub TestReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PriceListDataset.PriceList' table. You can move, or remove it, as needed.
        Me.PriceListTableAdapter.Fill(Me.PriceListDataset.PriceList, getCurrentBranch.BranchID)
        'TODO: This line of code loads data into the 'InvoiceDataSet.SalesInvoiceInfo' table. You can move, or remove it, as needed.
        Me.SalesInvoiceInfoTableAdapter.Fill(Me.InvoiceDataSet.SalesInvoiceInfo)
        'TODO: This line of code loads data into the 'ProductsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.ProductsDataSet.Products)


        Dim branchName As New ReportParameter("BranchName", getCurrentBranch.BranchName)
        ReportViewer1.LocalReport.SetParameters(branchName)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class