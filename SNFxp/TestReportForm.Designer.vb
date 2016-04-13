<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestReportForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestReportForm))
        Me.PriceListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceListDataset = New SNFxp.PriceListDataset()
        Me.SalesInvoiceInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceDataSet = New SNFxp.InvoiceDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataSet = New SNFxp.ProductsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProductsTableAdapter = New SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter()
        Me.SalesInvoiceInfoTableAdapter = New SNFxp.InvoiceDataSetTableAdapters.SalesInvoiceInfoTableAdapter()
        Me.PriceListTableAdapter = New SNFxp.PriceListDatasetTableAdapters.PriceListTableAdapter()
        CType(Me.PriceListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceListDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesInvoiceInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PriceListBindingSource
        '
        Me.PriceListBindingSource.DataMember = "PriceList"
        Me.PriceListBindingSource.DataSource = Me.PriceListDataset
        '
        'PriceListDataset
        '
        Me.PriceListDataset.DataSetName = "PriceListDataset"
        Me.PriceListDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesInvoiceInfoBindingSource
        '
        Me.SalesInvoiceInfoBindingSource.DataMember = "SalesInvoiceInfo"
        Me.SalesInvoiceInfoBindingSource.DataSource = Me.InvoiceDataSet
        '
        'InvoiceDataSet
        '
        Me.InvoiceDataSet.DataSetName = "InvoiceDataSet"
        Me.InvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.PriceListBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SNFxp.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(802, 412)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'SalesInvoiceInfoTableAdapter
        '
        Me.SalesInvoiceInfoTableAdapter.ClearBeforeFill = True
        '
        'PriceListTableAdapter
        '
        Me.PriceListTableAdapter.ClearBeforeFill = True
        '
        'TestReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 412)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TestReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PriceList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PriceListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceListDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesInvoiceInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsDataSet As SNFxp.ProductsDataSet
    Friend WithEvents ProductsTableAdapter As SNFxp.ProductsDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents SalesInvoiceInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceDataSet As SNFxp.InvoiceDataSet
    Friend WithEvents SalesInvoiceInfoTableAdapter As SNFxp.InvoiceDataSetTableAdapters.SalesInvoiceInfoTableAdapter
    Friend WithEvents PriceListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceListDataset As SNFxp.PriceListDataset
    Friend WithEvents PriceListTableAdapter As SNFxp.PriceListDatasetTableAdapters.PriceListTableAdapter
End Class
