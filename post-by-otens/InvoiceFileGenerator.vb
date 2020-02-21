﻿Imports Excel = Microsoft.Office.Interop.Excel
Module InvoiceFileGenerator
    Public xlApp As Excel.Application, xlWorkBook As Excel.Workbook, xlWorkSheet As Excel.Worksheet
    Private cID As Integer
    Private iNum As Integer
    Private bName As String
    Public Sub generate(customerID As Integer, invoiceNumber As Integer, loggedInBusinessName As String)
        cID = customerID
        iNum = invoiceNumber
        bName = loggedInBusinessName

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open("C:\Users\angelu.angelu-PC\Desktop\sales-invoice.xlsx")
        xlWorkSheet = xlWorkBook.Worksheets("Invoice1a")
        ''display the cells value B2
        'MsgBox(xlWorkSheet.Cells(2, 2).value)
        'edit the cell with new value

        fillUpForm()
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub fillUpForm()
        Try
            fillUpCompanyFields()
            fillUPCustomerData()
            fillUpProductDetails()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fillUpProductDetails()
        Dim adapter As New POSDataSetTableAdapters.DataTable3TableAdapter
        Dim rows As Integer
        rows = adapter.getInvoiceData(cID, iNum, bName).Rows.Count

        Dim pNum, pName, pQty, pPrice, pSub, pTotal As String

        'getProductLinesOfInvoice(InvoiceNumber) 'just this??

        'For Each productLine
        'cell(x, x) = productLine.getX
        'cell(x, y) = productLine.getY


        pTotal = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(16)
    End Sub

    Private Sub fillUPCustomerData()
        Dim adapter As New POSDataSetTableAdapters.DataTable3TableAdapter
        'Customer Full Name
        Dim fullName, addr As String
        fullName = ""
        fullName = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(5)
        fullName = fullName & " " & adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(6)
        fullName = fullName & " " & adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(7)
        xlWorkSheet.Cells(10, 1) = fullName
        addr = ""
        addr = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(8)
        addr = addr & ", " & adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(9)
        addr = addr & " " & adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(10)
        xlWorkSheet.Cells(11, 1) = addr
        'Customer Phone
        xlWorkSheet.Cells(12, 1) = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(11)
    End Sub

    Private Sub fillUpCompanyFields()
        Dim adapter As New POSDataSetTableAdapters.DataTable3TableAdapter
        'Company Name
        xlWorkSheet.Cells(1, 1) = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(0)
        'Phone
        xlWorkSheet.Cells(4, 1) = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(1)
        'Date
        xlWorkSheet.Cells(2, 8) = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(2)
        'Invoice Number
        xlWorkSheet.Cells(3, 8) = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(3)
        'cID
        xlWorkSheet.Cells(4, 8) = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(4)
        'Contact Name
        Dim fullName, eMail As String
        fullName = ""
        fullName = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(18)
        fullName = fullName & " " & adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(19)
        fullName = fullName & " " & adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(20)
        eMail = ""
        'Email
        eMail = adapter.getInvoiceData(cID, iNum, bName).Rows(0).Item(21)
        'Fill contact details
        xlWorkSheet.Cells(36, 4) = fullName & ", " & eMail

    End Sub
End Module