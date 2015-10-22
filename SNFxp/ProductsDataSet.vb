Partial Class ProductsDataSet
    'Partial Class StartingInventoryLineItemsDataTable

    '    Private Sub StartingInventoryLineItemsDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
    '        e.Row.Table.Columns("ExpirationDate").DefaultValue = Format(Now, "s")
    '    End Sub
    'End Class

    Partial Class StartingInventoryInfoDataTable
        Private Sub StartingInventoryInfoDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            e.Row.Table.Columns("InventoryDate").DefaultValue = Now.ToString()
        End Sub
    End Class

End Class

