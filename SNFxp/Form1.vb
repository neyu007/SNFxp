Public Class Form1

    Private Sub StartingInventoryInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StartingInventoryInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StartingInventoryInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductsDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  
        Try
           
            'TODO: This line of code loads data into the 'ProductsDataSet.StartingInventoryInfo' table. You can move, or remove it, as needed.
            Me.StartingInventoryInfoTableAdapter.Fill(Me.ProductsDataSet.StartingInventoryInfo)
            'TODO: This line of code loads data into the 'ProductsDataSet.StartingInventoryLineItems' table. You can move, or remove it, as needed.
            Me.StartingInventoryLineItemsTableAdapter.Fill(Me.ProductsDataSet.StartingInventoryLineItems)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub StartingInventoryLineItemsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles StartingInventoryLineItemsDataGridView.DataError

        If e.ColumnIndex = 5 Then
            MsgBox("Enter valid date")
        End If
    End Sub
End Class