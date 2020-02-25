Module salesAnalyzer
    Public Sub loadAnalytics(bName As String, value As Date)
        Dim adapter1 As POSDataSetTableAdapters.productTableAdapter
        Dim adapter2 As POSDataSetTableAdapters.invoiceTableAdapter
        Dim dayEnd As Integer

        dayEnd = 6
        Dim finalStartDate As String = Format(value, "yyyy-MM-dd")
        Dim finalEndDate As String = Format(DateAdd("d", dayEnd, value), "yyyy-MM-dd")

        'days contain the sequential days
        Dim days As New List(Of String)
        days.Add(finalStartDate)
        For i = 1 To dayEnd
            days.Add(Format(DateAdd("d", i, value), "yyyy-MM-dd"))
        Next

        'First, get the number of products that the business sells
        'AKA get all unique product numbers of the business
        Dim productNums As New List(Of Integer)
        For i = 0 To adapter1.getProdNumAndNames(bName).Rows.Count - 1
            productNums.Add(adapter1.getProdNumAndNames(bName).Rows(i).Item(0))
        Next

        'Get invoices for each day
        Dim numOfInvoices As Integer

        For i = 0 To dayEnd
            numOfInvoices = adapter2.getInvoicesWithinDay(days.Item(i), bName).Count
            For j = 0 To numOfInvoices - 1

            Next
        Next

        'For i = 0 To 





        'For each products each day, 

        'calculate the total count sold
        'calculate total sales for the product
    End Sub
End Module
