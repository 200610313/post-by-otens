﻿Public Class invoiceSearch
    Public businessName As String
    Public curRowIndex As Integer
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.Show()
        businessName = "Boboy's Refreshers"

        loadInvoices()

    End Sub

    Private Sub loadInvoices()

        DataGridView1.Rows.Clear()

        Dim adapter As New POSDataSetTableAdapters.invoiceTableAdapter
        Dim adapter2 As New POSDataSetTableAdapters.DataTable2TableAdapter
        For i = 0 To adapter.getAllInvoice(businessName).Rows.Count - 1
            Dim invoiceNum, dateP, total As String
            invoiceNum = adapter.getAllInvoice(businessName).Rows(i).Item(0)
            dateP = adapter.getAllInvoice(businessName).Rows(i).Item(1)
            total = adapter.getAllInvoice(businessName).Rows(i).Item(2)

            Dim j As Integer
            Dim entry As String
            entry = ""

            For j = 0 To adapter2.getProductsOfInvoice(businessName, invoiceNum).Rows.Count - 1
                Dim pCount As String
                Dim pName As String

                pCount = adapter2.getProductsOfInvoice(businessName, invoiceNum).Rows(j).Item(0)
                pName = adapter2.getProductsOfInvoice(businessName, invoiceNum).Rows(j).Item(1)

                If j <> adapter2.getProductsOfInvoice(businessName, invoiceNum).Rows.Count - 1 Then
                    entry = entry & pCount & "x" & " " & pName & ","
                Else
                    entry = entry & pCount & "x" & " " & pName & vbCrLf & "dwadawdawdad"
                End If
            Next

            DataGridView1.Rows.Add(invoiceNum, dateP, total, entry)
        Next
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        curRowIndex = DataGridView1.CurrentCell.RowIndex


    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim invoiceNum, bName As String
        invoiceNum = DataGridView1.Rows(curRowIndex).Cells(0).Value
        bName = businessName

        'POSDataSetTableAdapters.invoiceTableAdapter

        'adapter3.deleteInvoice(CInt(Val(invoiceNum)), businessName)


        'generateInvoiceForCustomer(DataGridView1.Rows(curRowIndex).Cells(0).Value)
        'updateDBStock()
        'RegisterTab.resetView()
        'Me.Close()
        'RegisterTab.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        RegisterTab.Show()
    End Sub
End Class