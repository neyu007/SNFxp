Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ViewProdList.View_ProductList' table. You can move, or remove it, as needed.
        Me.View_ProductListTableAdapter.Fill(Me.ViewProdList.View_ProductList)
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
       
    End Sub
End Class