Imports System.Data.SqlClient

Public Class ProductForm

    Dim conn As SqlConnection
    Private prodName As String
    Private description As String
    Private packaging As Integer
    Private groupID As Integer
    Private cityPrice As Double
    Private outPrice As Double
    Private productID As Integer
    Private reorderLevel As Integer
    Private branchID As Integer



    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.ProductGroup' table. You can move, or remove it, as needed.
        Me.ProductGroupTableAdapter.Fill(Me.ProductsDataSet.ProductGroup)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        prodName = ProductNameTextBox.Text
        description = ProductDescriptionTextBox.Text
        Integer.TryParse(PackagingTextBox.Text, packaging)
        groupID = GroupIDComboBox.SelectedValue
        MsgBox(groupID)
        Integer.TryParse(ReorderLevelTextBox.Text, reorderLevel)
        branchID = getCurrentBranch.BranchID
        Double.TryParse(tbCityPrice.Text, cityPrice)
        Double.TryParse(tbOutPrice.Text, outPrice)
        Try

            conn.Open()
            Dim cmd = conn.CreateCommand
            cmd.CommandText = String.Format("INSERT INTO Products(ProductName, Packaging, " &
                                            "ProductDescription, isActive, ReorderLevel, GroupID)" &
                                            "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}') SELECT SCOPE_IDENTITY()",
                                            prodName,
                                            packaging,
                                            description,
                                            IsActiveCheckBox.Checked,
                                            reorderLevel,
                                            groupID)
            ' Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            Dim id As Object = cmd.ExecuteScalar()
            'MsgBox(CInt(id.ToString))
            productID = CInt(id.ToString)

            cmd.CommandText = String.Format("INSERT INTO ProductPricing(ProductID, PricingLevelID, UnitPrice, " &
                                            "BranchID)" &
                                            "VALUES('{0}', '{1}', '{2}', '{3}'), ('{4}', '{5}', '{6}', '{7}')",
                                            productID,
                                            1,
                                            cityPrice,
                                            branchID,
                                            productID,
                                            2,
                                            outPrice,
                                            branchID)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox(rowsAffected & " rows inserted successfully")
            Else
                MsgBox("Fail")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Me.Close()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnNewGroup_Click(sender As Object, e As EventArgs) Handles btnNewGroup.Click
        Dim newGroupForm As New NewGroupForm
        If newGroupForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.ProductGroupTableAdapter.Fill(Me.ProductsDataSet.ProductGroup)
        End If
    End Sub
End Class