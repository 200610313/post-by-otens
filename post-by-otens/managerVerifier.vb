Public Class managerVerifier
    Public currPass As List(Of Char)
    Public endIndexOfString As Integer
    Public managerPW As String
    Private invoiceNum As String
    Private caller As invoiceSearch
    Public Sub New(invoiceNum As String, businessName As String, invoiceSearch As invoiceSearch)

        ' This call is required by the designer.
        InitializeComponent()
        Me.Show()
        ' Add any initialization after the InitializeComponent() call.
        Me.caller = invoiceSearch
        Me.invoiceNum = invoiceNum
        Dim adapter As New POSDataSetTableAdapters.businessTableAdapter
        managerPW = adapter.getManagerPW(businessName)
    End Sub

    Private Sub exitForm_Click(sender As Object, e As EventArgs) Handles exitForm.Click
        Me.Close()
    End Sub

    Private Sub actualpass_TextChanged(sender As Object, e As EventArgs) Handles actualpass.TextChanged
        actualpass.PasswordChar = ""
        If managerPW = actualpass.Text Then
            Dim adapter2 As New POSDataSetTableAdapters.invoiceTableAdapter
            Dim x As Integer
            'delete invoice
            x = adapter2.deleteInvoiceNumber(invoiceNum)
            caller.loadInvoices()

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
            Me.Close()
        End If
        actualpass.PasswordChar = "*"
    End Sub
End Class