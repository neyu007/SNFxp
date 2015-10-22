Imports System.Data.SqlClient

Public Class ProductListForm

    Dim conn As SqlConnection
    Private prodID As Integer = 1
    Private ctPriceCount As Integer = 0
    Private outPriceCount As Integer = 0


    Private Sub ProductListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ViewProdList.View_ProductList' table. You can move, or remove it, as needed.
        Me.View_ProductListTableAdapter.Fill(Me.ViewProdList.View_ProductList)
        'TODO: This line of code loads data into the 'ProductsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.ProductsDataSet.Products)
        prodID = ProductsListBox.SelectedValue
        Me.InitPrice()
        Me.cbAll.Checked = True

    End Sub
    Sub InitPrice()
        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SNFDatabase.mdf;Initial Catalog=snfdbxp;Integrated Security=True")
        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        conn.Open()
        Dim cmd = conn.CreateCommand
        cmd.CommandText = String.Format("SELECT * FROM ProductPricing WHERE ProductID = '{0}' AND BranchID = '{1}'", prodID, getCurrentBranch().BranchID)
        Dim qStr = String.Format("")

        Dim dr As SqlDataReader = cmd.ExecuteReader()
        Dim dtPricing As New DataTable
        dtPricing.Load(dr)
        tbCity.Text = ""
        tbOut.Text = ""
        'MsgBox("Rows: " & dtPricing.Rows.Count)
        For Each row As DataRow In dtPricing.Rows
            If row("PricingLevelID") = 1 Then
                ' MsgBox("PriceID: " & row("PricingLevelID"))
                tbCity.Text = Format(row("UnitPrice"), "N2")
                ctPriceCount = 1
            ElseIf row("PricingLevelID") = 2 Then
                ' MsgBox("PriceID: " & row("PricingLevelID"))
                tbOut.Text = Format(row("UnitPrice"), "N2")
                outPriceCount = 1
            End If
        Next
        'Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        'If rowsAffected > 0 Then
        '    MsgBox("Success")
        'Else
        '    MsgBox("Fail")
        'End If
        dr.Close()
        conn.Close()
    End Sub

    Private Sub ProductsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductsListBox.SelectedIndexChanged, ProductsListBox.SelectedValueChanged
        prodID = ProductsListBox.SelectedValue
        InitPrice()
    End Sub



    Private Sub ProductsBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ProductsBindingSource.CurrentChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim conString = My.Settings.Item("snfdbxpConnectionString")
        conn = New SqlConnection(conString)
        'Dim cityPrice As Double
        'Dim outPrice As Double
        'If Double.TryParse(tbCity.Text, cityPrice) Then

        'End If
        'If Double.TryParse(tbOut.Text, outPrice) Then

        'End If
        Try
            conn.Open()
            Dim cmd = conn.CreateCommand

            If ctPriceCount = 0 And outPriceCount = 0 Then
                cmd.CommandText = String.Format("INSERT INTO ProductPricing(ProductID, PricingLevelID, UnitPrice, " &
                                                "BranchID)" &
                                                "VALUES('{0}', '{1}', '{2}', '{3}'), ('{4}', '{5}', '{6}', '{7}')",
                                                ProductsListBox.SelectedValue,
                                                1,
                                                tbCity.Text,
                                                getCurrentBranch.BranchID,
                                                ProductsListBox.SelectedValue,
                                                2,
                                                tbOut.Text,
                                                getCurrentBranch.BranchID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox(rowsAffected & " rows inserted successfully")
                Else
                    MsgBox("Fail")
                End If
            Else
                For i = 1 To 2
                    Dim UnitPrice As Double

                    If i = 1 Then
                        'Double.TryParse(tbCity.Text, UnitPrice)
                        UnitPrice = tbCity.Text
                    Else
                        'Double.TryParse(tbOut.Text, UnitPrice)
                        UnitPrice = tbOut.Text
                    End If
                    cmd.CommandText = String.Format("UPDATE ProductPricing SET " &
                                                "UnitPrice='{0}' " &
                                                "WHERE ProductID='{1}' AND PricingLevelID='{2}' " &
                                                "AND BranchID='{3}'",
                                                UnitPrice,
                                                ProductsListBox.SelectedValue,
                                                i,
                                                getCurrentBranch.BranchID)

                    cmd.ExecuteNonQuery()
                Next

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If SingleFormClass.prodForm Is Nothing Then
            SingleFormClass.prodForm = New ProductForm
        End If
        SingleFormClass.prodForm.MdiParent = Me.MdiParent
        SingleFormClass.prodForm.Show()
        SingleFormClass.prodForm.Focus()
        Me.Close()
    End Sub

    Private Sub cbCatsup_CheckedChanged(sender As Object, e As EventArgs) Handles cbCatsup.CheckedChanged
        If Me.cbCatsup.Checked Then
            Me.cbAll.Checked = False
            Me.cbMayo.Checked = False
            Me.cbTPS.Checked = False
            Me.cbOthers.Checked = False
            Me.FilterProducts(Me.cbCatsup)
        End If
    End Sub

    Private Sub cbAll_CheckStateChanged(sender As Object, e As EventArgs) Handles cbAll.CheckStateChanged
        If Me.cbAll.Checked Then
            'MsgBox("checked")
            Me.cbCatsup.Checked = False
            Me.cbMayo.Checked = False
            Me.cbOthers.Checked = False
            Me.cbTPS.Checked = False
            Me.FilterProducts(Me.cbAll)
        End If
    End Sub


    Private Sub cbMayo_CheckedChanged(sender As Object, e As EventArgs) Handles cbMayo.CheckedChanged
        If Me.cbMayo.Checked Then
            Me.cbAll.Checked = False
            Me.cbCatsup.Checked = False
            Me.cbTPS.Checked = False
            Me.cbOthers.Checked = False
            Me.FilterProducts(Me.cbMayo)
        End If
    End Sub

    Private Sub cbOthers_CheckedChanged(sender As Object, e As EventArgs) Handles cbOthers.CheckedChanged
        If Me.cbOthers.Checked Then
            Me.cbAll.Checked = False
            Me.cbMayo.Checked = False
            Me.cbTPS.Checked = False
            Me.cbCatsup.Checked = False
            Me.FilterProducts(Me.cbOthers)
        End If
    End Sub


    Private Sub cbTPS_CheckedChanged(sender As Object, e As EventArgs) Handles cbTPS.CheckedChanged
        If Me.cbTPS.Checked Then
            Me.cbAll.Checked = False
            Me.cbMayo.Checked = False
            Me.cbOthers.Checked = False
            Me.cbCatsup.Checked = False
            Me.FilterProducts(Me.cbTPS)
        End If
    End Sub
    Private Sub FilterProducts(ByVal cb As CheckBox)
        Try
            If cb.Equals(cbAll) Then
                Me.View_ProductListTableAdapter.Fill(Me.ViewProdList.View_ProductList)
            ElseIf cb.Equals(cbCatsup) Then
                Me.View_ProductListTableAdapter.FillByDepartment(Me.ViewProdList.View_ProductList, 1)
            ElseIf cb.Equals(cbMayo) Then
                Me.View_ProductListTableAdapter.FillByDepartment(Me.ViewProdList.View_ProductList, 2)
            ElseIf cb.Equals(cbOthers) Then
                Me.View_ProductListTableAdapter.FillByDepartment(Me.ViewProdList.View_ProductList, 5)
            ElseIf cb.Equals(cbTPS) Then
                Me.View_ProductListTableAdapter.FillByDepartment(Me.ViewProdList.View_ProductList, 3)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.InitPrice()
    End Sub
End Class