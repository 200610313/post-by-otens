Module replaceInvoiceOwner
    Private cIDOld As Integer
    Private cIDNew As Integer
    Private invoiceNumber As Integer
    Private bName As String
    Public Sub replaceOwner(cIDOld As Integer, cIDNew As Integer, targetInvoiceNum As Integer, businessName As String)
        replaceInvoiceOwner.cIDOld = cIDOld
        replaceInvoiceOwner.cIDNew = cIDNew
        replaceInvoiceOwner.invoiceNumber = targetInvoiceNum
        replaceInvoiceOwner.bName = businessName

        Dim adapter As New POSDataSetTableAdapters.invoiceTableAdapter
        Dim rowsaffected As Integer
        'update invoiceNumber CID to cIDNew
        rowsaffected = adapter.updateOwner(cIDNew, invoiceNumber)

        'Delete customers with no invoices
        checkInvalidCustomers()
    End Sub

    Private Sub checkInvalidCustomers()
        'check if cID has no invoices
        'if no invoices, delete the customer
        Dim adapter3 As New POSDataSetTableAdapters.customer1TableAdapter
        Dim adapter4 As New POSDataSetTableAdapters.invoiceTableAdapter
        Dim adapter5 As New POSDataSetTableAdapters.customerTableAdapter
        Dim rowCount As Integer
        rowCount = adapter3.getAllCid.Rows.Count - 1
        Dim listOfCid As New List(Of Integer)
        For i = 0 To rowCount
            listOfCid.Add(adapter3.getAllCid.Rows(i).Item(0))
        Next
        For j = 0 To rowCount
            If adapter4.getNumOfInvoicesAssociatedWith(listOfCid.Item(j)) = 0 Then
                adapter5.removeCustomer(listOfCid.Item(j))
            End If
        Next
    End Sub
End Module
