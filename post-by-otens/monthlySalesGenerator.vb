Imports Excel = Microsoft.Office.Interop.Excel
Module monthlySalesGenerator
    Private xlApp As Excel.Application, xlWorkBook As Excel.Workbook, xlWorkSheet As Excel.Worksheet
    Private monthN As String
    Private filePath As String
    Public Sub generateSales(monthName As String, mainManagevb As MainManagevb, bName As String, savePath As String)
        monthN = monthName

        xlApp = New Excel.Application

        Dim templatePath As String
        templatePath = My.Application.Info.DirectoryPath
        templatePath = templatePath & "\salesReportTemplate.xlsx"

        xlWorkBook = xlApp.Workbooks.Open(templatePath)
        xlWorkSheet = xlWorkBook.Worksheets("month")
        Dim year As String
        year = System.DateTime.Now.Year
        fillUpSalesReport(year, bName)

        Dim fileName As String

        fileName = monthName & " " & year
        filePath = savePath + "\" '"C:\Users\angelu.angelu-PC\Desktop\"
        filePath = filePath & fileName
        xlWorkBook.SaveAs(filePath)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
    End Sub

    Private Sub fillUpSalesReport(year As String, bName As String)
        Dim adapter As New POSDataSetTableAdapters.invoiceTableAdapter
        Dim currMonth As Integer = convertToMonthNum(monthN)
        Dim rows As Integer = adapter.getINVbyMONTH(currMonth, year, bName).Rows.Count
        Dim adapter2 As New POSDataSetTableAdapters.DataTable2TableAdapter
        Dim currRow As Integer = 3
        'fill date
        xlWorkSheet.Cells(1, 2) = monthN & " " & year
        'fill business name
        Dim totalSales As Double
        totalSales = 0.0
        For i = 0 To rows - 1
            'Date
            xlWorkSheet.Cells(currRow, 1) = adapter.getINVbyMONTH(currMonth, year, bName).Rows(i).Item(1)
            'Invoice number
            xlWorkSheet.Cells(currRow, 2) = adapter.getINVbyMONTH(currMonth, year, bName).Rows(i).Item(0)

            Dim invoiceNum As Integer = adapter.getINVbyMONTH(currMonth, year, bName).Rows(i).Item(0)

            Dim entry As String
            entry = ""

            For j = 0 To adapter2.getProductsOfInvoice(bName, invoiceNum).Rows.Count - 1
                Dim pCount As String
                Dim pName As String

                pCount = adapter2.getProductsOfInvoice(bName, invoiceNum).Rows(j).Item(0)
                pName = adapter2.getProductsOfInvoice(businessName, invoiceNum).Rows(j).Item(1)

                If j <> adapter2.getProductsOfInvoice(businessName, invoiceNum).Rows.Count - 1 Then
                    entry = entry & pCount & "x" & " " & pName & vbCrLf
                Else
                    entry = entry & pCount & "x" & " " & pName
                End If
            Next

            xlWorkSheet.Cells(currRow, 3) = entry

            xlWorkSheet.Cells(currRow, 4) = adapter.getINVbyMONTH(currMonth, year, bName).Rows(i).Item(2)
            totalSales = totalSales + adapter.getINVbyMONTH(currMonth, year, bName).Rows(i).Item(2)
            currRow = currRow + 1
        Next
        xlWorkSheet.Cells(currRow, 4) = totalSales
        MainManagevb.monthlysalesPNL.Visible = False
        xlWorkSheet.Cells(1, 3) = bName
    End Sub

    Private Function convertToMonthNum(monthN As String) As Integer
        Select Case monthN
            Case "January"
                Return 1
            Case "February"
                Return 2
            Case "March"
                Return 3
            Case "April"
                Return 4
            Case "May"
                Return 5
            Case "June"
                Return 6
            Case "July"
                Return 7
            Case "August"
                Return 8
            Case "September"
                Return 9
            Case "October"
                Return 10
            Case "November"
                Return 11
            Case "December"
                Return 12
        End Select
    End Function


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

End Module
