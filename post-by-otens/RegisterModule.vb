Module RegisterModule
    Public Sub loadProductsOf(loggedInBusinessName As String, ByRef products As List(Of product))
        Dim adapter As New POSDataSetTableAdapters.product1TableAdapter
        Dim i, rows As Integer
        rows = CInt(adapter.getProductsOf(loggedInBusinessName).Rows.Count)
        For i = 0 To rows - 1
            Dim prodName = adapter.getProductsOf(loggedInBusinessName).Rows(i).Item(0)
            Dim prodPrice = adapter.getProductsOf(loggedInBusinessName).Rows(i).Item(1)
            Dim prodStock = adapter.getProductsOf(loggedInBusinessName).Rows(i).Item(2)
            Dim prodNumber = adapter.getProductsOf(loggedInBusinessName).Rows(i).Item(3)
            products.Add(New product(prodName, prodNumber, prodPrice, prodStock))
        Next
    End Sub

    Public Sub updateProductsView()
        'get names of like what's in the textbox
        Dim adapter As New POSDataSetTableAdapters.product1TableAdapter
        Dim i, rows As Integer
        rows = CInt(adapter.getProductsLike(RegisterTab.searchBox.Text, RegisterTab.loggedInBusinessName).Rows.Count) 'getProductsOf(loggedInBusinessName).Rows.Count)
        'clear the flowlayout panel
        RegisterTab.FlowLayoutPanel1.Controls.Clear()
        For i = 0 To rows - 1
            For j = 0 To RegisterTab.products.Count - 1
                If RegisterTab.products.Item(j).getProdName = adapter.getProductsLike(RegisterTab.searchBox.Text, RegisterTab.loggedInBusinessName).Rows(i).Item(0) Then
                    'if result.get(i) = products.getprodname.j then add to flowlayout panel
                    RegisterTab.FlowLayoutPanel1.Controls.Add(RegisterTab.products.Item(j))
                End If
            Next
        Next
        'at the end, refresh flow layout panel
        RegisterTab.FlowLayoutPanel1.Refresh()
    End Sub
    'Insert customer data
    Public Sub registerCustomer()

    End Sub
    'Generate invoice for the customer
    Public Sub generateInvoiceForCustomer()
        'get the ID of the most recent customer


    End Sub
    'Compute the totals of the cart items
    Public Sub computeSubtotals()

        Dim total As Double

        total = 0
        For Each shoppingcartitem In RegisterTab.shoppingCartItems
            total = +shoppingcartitem.getSubtotal
        Next
    End Sub
End Module
