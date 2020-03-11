Partial Class POSDataSet
    Partial Public Class businessDataTable
        Private Sub businessDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging


        End Sub

        Private Sub businessDataTable_businessRowChanging(sender As Object, e As businessRowChangeEvent) Handles Me.businessRowChanging

        End Sub

    End Class

    Partial Public Class DataTable3DataTable
        Private Sub DataTable3DataTable_DataTable3RowChanging(sender As Object, e As DataTable3RowChangeEvent) Handles Me.DataTable3RowChanging

        End Sub

    End Class

    Partial Public Class DataTable4DataTable
        Private Sub DataTable4DataTable_DataTable4RowChanging(sender As Object, e As DataTable4RowChangeEvent) Handles Me.DataTable4RowChanging

        End Sub

    End Class

    Partial Public Class productDataTable
        Private Sub productDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.pNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

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
    Partial Public Class invoiceTableAdapter

    End Class



    Partial Public Class product1TableAdapter
    End Class
End Namespace

Namespace POSDataSetTableAdapters
    Partial Public Class businessTableAdapter
    End Class
End Namespace
