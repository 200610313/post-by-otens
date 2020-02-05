Partial Class POSDataSet
    Partial Public Class productDetailDataTable
        Private Sub productDetailDataTable_productDetailRowChanging(sender As Object, e As productDetailRowChangeEvent) Handles Me.productDetailRowChanging

        End Sub

    End Class

    Partial Public Class ProductDetailDataTable
        Private Sub ProductDetailDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.pQuantityColumn.ColumnName) Then

            End If

        End Sub

    End Class
End Class

Namespace POSDataSetTableAdapters

    Partial Public Class product1TableAdapter
    End Class
End Namespace
