Module salesAnalyzer
    Public Sub loadAnalytics(bName As String, value As Date, chart1 As DataVisualization.Charting.Chart, daysC As Integer)
        Dim adapter1 As New POSDataSetTableAdapters.productTableAdapter
        Dim adapter2 As New POSDataSetTableAdapters.invoiceTableAdapter
        Dim adapter3 As New POSDataSetTableAdapters.invoiceTableAdapter
        Dim adapter4 As New POSDataSetTableAdapters.DataTable2TableAdapter
        Dim dayEnd As Integer
        chart1.Series.Clear()
        dayEnd = daysC
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

        Dim productNums As New List(Of Integer) 'pNums
        Dim adapapter As New POSDataSetTableAdapters.productTableAdapter
        For i = 0 To adapter1.getProdNumAndNames(bName).Rows.Count - 1
            productNums.Add(adapter1.getProdNumAndNames(bName).Rows(i).Item(3))
            chart1.Series.Add(adapapter.getProdName(productNums.Item(i)))
            chart1.Series(i).ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        Next
        'Show chart labels
        For z = 0 To chart1.Series.Count - 1
            'coloring labels
            chart1.Series.Item(z).IsValueShownAsLabel = True
            chart1.Series.Item(z).LabelBackColor = Color.Black
            chart1.Series.Item(z).LabelForeColor = Color.White


        Next

        chart1.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0
        chart1.ChartAreas(0).AxisY.MajorGrid.LineWidth = 0


        'Get invoices for each day
        Dim numOfInvoices As Integer
        Dim currInvoiceNum As Integer
        For i = 0 To dayEnd
            Dim productTotalCount(productNums.Count - 1) As Integer 'count per pNum
            numOfInvoices = adapter2.getInvoicesWithinDay(days.Item(i), bName).Count
            For j = 0 To productNums.Count - 1
                'for each invoice
                For k = 0 To numOfInvoices - 1
                    currInvoiceNum = adapter2.getInvoicesWithinDay(days.Item(i), bName).Rows(k).Item(0)
                    'for each productLine that belongs to invoice
                    Dim countProductLineOfInvoice As Integer = adapter4.getProductsOfInvoice(bName, currInvoiceNum).Rows.Count
                    For l = 0 To countProductLineOfInvoice - 1
                        Dim productNumInProductLine, productQtyInProductLine As Integer
                        productNumInProductLine = adapter4.getProductsOfInvoice(bName, currInvoiceNum).Rows(l).Item(6)
                        productQtyInProductLine = adapter4.getProductsOfInvoice(bName, currInvoiceNum).Rows(l).Item(0)
                        'for each product number that appears in invoice
                        If productNums.Item(j) = productNumInProductLine Then
                            productTotalCount(j) = productTotalCount(j) + productQtyInProductLine
                        End If
                    Next l
                Next k
            Next j
            For m = 0 To productNums.Count - 1
                chart1.Series(adapapter.getProdName(productNums.Item(m))).Points.AddXY(days.Item(i), productTotalCount(m))
            Next m

        Next i

        'For i = 0 To 

        'For each products each day, 

        'calculate the total count sold
        'calculate total sales for the product
    End Sub
End Module
