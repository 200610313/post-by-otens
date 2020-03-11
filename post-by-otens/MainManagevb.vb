Imports System.ComponentModel
Imports System.Data.DataTable

Public Class MainManagevb
    Public adp As Odbc.OdbcDataAdapter
    Public products As List(Of product)
    Public shoppingCartItems As List(Of shoppingCartItem)
    Public businessName As String = EditStock.getName
    Public targetInvoiceNum As Integer
    Public cIDOld As Integer
    Private Sub MainManagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POSDataSet21.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter2.Fill(Me.POSDataSet21.customer)
        'TODO: This line of code loads data into the 'POSDataSet11.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me.POSDataSet11.customer)


        'TODO: This line of code loads data into the 'POSDataSet.product' table. You can move, or remove it, as needed.

        LogoPanel.Visible = True

        genInvoice.Visible = False
        StockPanel.Visible = False
        Save_btn.Visible = False


    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles Exit_bttn.Click
        Close()
    End Sub



    Private Sub savePathbtn_Click(sender As Object, e As EventArgs) Handles savePathbtn.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            savePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub



    Private Sub Stocks_bttn_Click(sender As Object, e As EventArgs) Handles Stocks_bttn.Click, Elipse_Edit.TargetControlResized
        monthlysalesPNL.Visible = False
        custIDPrompter.Visible = False
        sales_panel.Visible = False
        genInvoice.Visible = False
        LogoPanel.Visible = False
        StockPanel.Visible = True
        Save_btn.Visible = False
        X_btn.Visible = False



        Dim adapter As New POSDataSetTableAdapters.productTableAdapter

        ProductDataGrid.DataSource = adapter.GetProductData(businessName)

    End Sub

    Private Sub ProductDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGrid.CellContentClick
        If ProductDataGrid.SelectedRows.Count > 0 Then
            Dim i As Integer = ProductDataGrid.CurrentRow.Index
            prod_tb.Text = ProductDataGrid.Rows(i).Cells(1).Value
            price_tb.Text = ProductDataGrid.Rows(i).Cells(2).Value
            stock_tb.Text = ProductDataGrid.Rows(i).Cells(3).Value
            image_tb.Text = ProductDataGrid.Rows(i).Cells(4).Value


        Else
            MessageBox.Show("Select 1 row before you hit Edit")
        End If
    End Sub

    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click
        LogoPanel.Visible = True

        StockPanel.Visible = False
    End Sub

    Private Sub AddStock_bttn_Click(sender As Object, e As EventArgs) Handles AddStock_bttn.Click
        RegisterStock.Show()
    End Sub


    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles Edit_btn.Click

        BunifuTransition1.Show(Save_btn)
        BunifuTransition1.Show(X_btn)

        If ProductDataGrid.SelectedRows.Count > 0 Then
            Dim i As Integer = ProductDataGrid.SelectedRows(0).Index

        Else
            MessageBox.Show("Select 1 row before you hit Edit")
        End If
        stock_tb.ReadOnly = False
        prod_tb.ReadOnly = False
        price_tb.ReadOnly = False
        image_tb.ReadOnly = False
    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Dim adapter As New POSDataSetTableAdapters.productTableAdapter
        Dim i As Integer = ProductDataGrid.CurrentRow.Index
        If ProductDataGrid.SelectedCells.Count > 0 Then
            Dim prodID = ProductDataGrid.Rows(i).Cells(0).Value
            adapter.DeleteProduct(prodID)
            ProductDataGrid.DataSource = adapter.GetProductData(businessName)
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If

    End Sub


    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click
        Dim adapter As New POSDataSetTableAdapters.productTableAdapter

        Dim up As New POSDataSet.productDataTable

        Dim prodId
        If ProductDataGrid.SelectedRows.Count > 0 Then
            Dim i = ProductDataGrid.CurrentRow.Index
            prodId = ProductDataGrid.Rows(i).Cells(0).Value

            adapter.UpdateStock(Val(stock_tb.Text), prod_tb.Text, CDec(price_tb.Text), image_tb.Text, businessName, prodId)
            ProductDataGrid.DataSource = adapter.GetProductData(businessName)
            ProductDataGrid.EndEdit()

        Else
            MessageBox.Show("Select 1 Stock Cell before you hit save")
        End If

        stock_tb.ReadOnly = True
        prod_tb.ReadOnly = True
        price_tb.ReadOnly = True
        image_tb.ReadOnly = True

        adapter.Update(up)
        ProductDataGrid.DataSource = adapter.GetProductData(businessName)

        Save_btn.Visible = False



    End Sub

    Private Sub genInvoices_Click(sender As Object, e As EventArgs) Handles genInvoices.Click
        monthlysalesPNL.Visible = False
        custIDPrompter.Visible = False
        sales_panel.Visible = False
        LogoPanel.Visible = False

        StockPanel.Visible = False
        genInvoice.Visible = True
        loadTable()


    End Sub

    Public Sub loadTable()

        CustomerDataGrid1.Rows.Clear()

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
                    entry = entry & pCount & "x" & " " & pName & vbCrLf
                Else
                    entry = entry & pCount & "x" & " " & pName
                End If
            Next
            Dim adap As New POSDataSetTableAdapters.invoiceTableAdapter

            Dim cID As String
            cID = adap.getCID(invoiceNum)
            CustomerDataGrid1.Rows.Add(invoiceNum, dateP, total, entry, getFullNameOf(cID, invoiceNum, businessName), cID)
        Next
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening
        Try
            Dim rowIndex = CustomerDataGrid1.CurrentCell.RowIndex
            Dim selectedRowCount As Integer
            selectedRowCount = CustomerDataGrid1.Rows.GetRowCount(DataGridViewElementStates.Selected)
            Dim nameCharCount = CustomerDataGrid1.Rows(rowIndex).Cells(4).Value.ToString.Trim.Length

            If selectedRowCount = 1 And nameCharCount = 1 Then
                targetInvoiceNum = CustomerDataGrid1.Rows(rowIndex).Cells(0).Value
                cIDOld = CustomerDataGrid1.Rows(rowIndex).Cells(5).Value
            Else
                SendKeys.Send("{ESC}")
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub TransferOwnershipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferOwnershipToolStripMenuItem.Click
        custIDPrompter.Visible = True
        custIDPrompter.BringToFront()
    End Sub

    Private Sub custId_txtbox_TextChanged(sender As Object, e As EventArgs) Handles custId_txtbox.TextChanged
        Dim custID As Integer
        Dim adapter As New POSDataSetTableAdapters.customerTableAdapter
        Try
            custID = custId_txtbox.Text
            newowner.Text = adapter.getFullName(custID, businessName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub custId_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles custId_txtbox.KeyDown
        Try
            If e.KeyCode = Keys.Enter And newowner.Text.Trim.Length <> 0 Then
                Dim cIDNew As Integer
                cIDNew = custId_txtbox.Text

                replaceOwner(cIDOld, cIDNew, targetInvoiceNum, businessName)
                custIDPrompter.Visible = False
                loadTable()
                e.Handled = True
            Else
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FillinBasicInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FillinBasicInfoToolStripMenuItem.Click
        updateCustInfo(cIDOld, Me)
    End Sub

    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        Dim mySelectedRows As List(Of Integer) = New List(Of Integer)
        Try
            If IsValidFileNameOrPath(savePath.Text) Then

                For Each selectedRow As DataGridViewRow In CustomerDataGrid1.SelectedRows
                    Dim Index As Integer = selectedRow.Index
                    Dim cName As String = CustomerDataGrid1.Rows(Index).Cells(4).Value
                    If cName.Trim.Length <> 1 Then
                        'Dim index As Integer = selectedRow.Index
                        Dim custID = CustomerDataGrid1.Rows(index).Cells(5).Value
                        Dim iNum = CustomerDataGrid1.Rows(index).Cells(0).Value
                        generate(custID, iNum, businessName, savePath.Text)
                    End If
                Next selectedRow
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function IsValidFileNameOrPath(ByVal name As String) As Boolean
        ' Determines if the name is Nothing.
        If name Is Nothing Then
            Return False
        End If

        ' Determines if there are bad characters in the name.
        For Each badChar As Char In System.IO.Path.GetInvalidPathChars
            If InStr(name, badChar) > 0 Then
                Return False
            End If
        Next

        ' The name passes basic validation.
        Return True
    End Function

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        monthlysalesPNL.Visible = False
        custIDPrompter.Visible = False
        sales_panel.Visible = False
        LogoPanel.Visible = False

        StockPanel.Visible = False
        genInvoice.Visible = False
        sales_panel.Visible = True
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -90
        loadAnalytics(businessName, Date.Now.ToString("yyyy/MM/dd HH:mm:ss"), Chart1, CInt(Val(TextBox1.Text) - 1))
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            loadAnalytics(businessName, dateStart.Value, Chart1, CInt(Val(TextBox1.Text) - 1))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dateStart_ValueChanged(sender As Object, e As EventArgs) Handles dateStart.ValueChanged
        Try
            loadAnalytics(businessName, dateStart.Value, Chart1, CInt(Val(TextBox1.Text) - 1))
        Catch ex As Exception

        End Try
    End Sub




    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        custIDPrompter.Visible = False
    End Sub



    Private Sub pathFinder_Click(sender As Object, e As EventArgs) Handles pathFinder.Click
        Try
            Process.Start(savePath.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub deleteInvoiceBTN_Click(sender As Object, e As EventArgs) Handles deleteInvoiceBTN.Click
        Dim adapter As New POSDataSetTableAdapters.invoiceTableAdapter
        Dim rowsAffected As Integer

        Try
            For Each RW As DataGridViewRow In CustomerDataGrid1.Rows
                If RW.Selected = True Then
                    rowsAffected = adapter.DeleteQuery(RW.Cells(0).Value)
                End If
            Next
            loadTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub monthlySales_Click(sender As Object, e As EventArgs) Handles monthlySales.Click
        monthlysalesPNL.Visible = True
    End Sub

    Private Sub genBTN_Click(sender As Object, e As EventArgs) Handles genBTN.Click
        Try
            If Not String.IsNullOrEmpty(ComboBox1.Text) Then
                generateSales(ComboBox1.Text, Me, businessName, reportPath.Text)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BunifuImageButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            reportPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub


    Private Sub Logut_bttn_Click(sender As Object, e As EventArgs) Handles Logut_bttn.Click

        LoginFrm.Show()
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles X_btn.Click

    End Sub
End Class