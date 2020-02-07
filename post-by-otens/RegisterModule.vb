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
    Public Sub registerCustomer(cFname As String, cLName As String, cMinit As Char, cCity As String, cState As String, cZip As String, cPhone As String)
        Dim adapter As New POSDataSetTableAdapters.customerTableAdapter
        Try
            Dim customerID As Integer
            adapter.InsertQuery(cFname, cLName, cMinit, cCity, cState, cZip, cPhone)
            customerID = adapter.getCustID
            generateInvoiceForCustomer(customerID)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Generate invoice for the customer
    Public Sub generateInvoiceForCustomer(customerID As Integer)
        Dim adapter As New POSDataSetTableAdapters.invoiceTableAdapter
        Dim total As Double
        Dim customerInvoiceNumber As Integer

        total = 0

        'compute total of subtotals
        For Each shoppingcartitem In RegisterTab.shoppingCartItems
            total = total + shoppingcartitem.getSubtotal
        Next

        'then fill invoice
        adapter.fillInvoiceForRecentCustomer(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), total, RegisterTab.loggedInBusinessName, customerID)
        customerInvoiceNumber = adapter.getCustomerInvoice
        generateProductLine(customerID, customerInvoiceNumber)

    End Sub

    Public Sub generateProductLine(customerID As Integer, InvoiceNumber As Integer)
        Dim adapter As New POSDataSetTableAdapters.productDetailTableAdapter
        For Each shoppingcartitem In RegisterTab.shoppingCartItems
            'insert row in product detail
            adapter.newProductLine(shoppingcartitem.getShoppingCartCount, shoppingcartitem.getShoppingCartSubtotal, RegisterTab.loggedInBusinessName, InvoiceNumber, shoppingcartitem.getProdNum, RegisterTab.loggedInBusinessName)
        Next
    End Sub
    'And then correct renders in products list
End Module
