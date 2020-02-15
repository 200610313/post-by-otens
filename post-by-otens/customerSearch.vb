Public Class customerSearch
    Public businessName As String
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        businessName = "Boboy's Refreshers"
    End Sub

    Private Sub searchBox_OnValueChanged(sender As Object, e As EventArgs) Handles searchBox.OnValueChanged
        DataGridView1.Rows.Clear()
        Dim adapter As New POSDataSetTableAdapters.DataTable1TableAdapter
        Dim rows As Integer
        rows = adapter.getCustomersOf("Boboy's Refreshers", searchBox.Text).Rows.Count
        'adapter.getCustomersOf(businessName, searchBox.Text).Rows(i).Item(3) = custId of the customer
        For i = 0 To rows - 1
            'get all invoices of the specific customer from the company
            Dim adapter2 As New POSDataSetTableAdapters.invoice1TableAdapter
            Dim cID, numberOfPurchases As Integer
            cID = adapter.getCustomersOf(businessName, searchBox.Text).Rows(i).Item(3)
            numberOfPurchases = adapter2.getRecentDateOfPurchase(businessName, cID).Rows.Count
            'get the last the date from the last index
            DataGridView1.Rows.Add(cID, adapter.getCustomersOf(businessName, searchBox.Text).Rows(i).Item(0) + " " + adapter.getCustomersOf(businessName, searchBox.Text).Rows(i).Item(1) + " " + adapter.getCustomersOf(businessName, searchBox.Text).Rows(i).Item(2), adapter2.getRecentDateOfPurchase(businessName, cID).Rows(numberOfPurchases - 1).Item(0), numberOfPurchases)

        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Dim x As Integer    
        'x = dgvName.Rows(yourRowIndex).Cells(yourColumnIndex).Value


        'There Is the RowIndex property for the CurrentCell property for the DataGridView.

        'DataGridView.CurrentCell.RowIndex
        'Handle the SelectionChanged event And find the index of the selected row as above.
    End Sub
End Class