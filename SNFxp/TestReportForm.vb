Public Class TestReportForm

    Private Sub TestReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.ProductsDataSet.Products)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class