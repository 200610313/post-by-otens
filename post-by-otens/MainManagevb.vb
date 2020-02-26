Imports System.ComponentModel
Imports System.Data.DataTable

Public Class MainManagevb
    Public adp As Odbc.OdbcDataAdapter
    Public products As List(Of product)
    Public shoppingCartItems As List(Of shoppingCartItem)
    Public businessName As String = "Boboy's Refreshers" 'EditStock.getName
    Public targetInvoiceNum As Integer
    Public cIDOld As Integer
    Private Sub MainManagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POSDataSet21.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter2.Fill(Me.POSDataSet21.customer)
        'TODO: This line of code loads data into the 'POSDataSet11.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me.POSDataSet11.customer)


        'TODO: This line of code loads data into the 'POSDataSet.product' table. You can move, or remove it, as needed.
        Refresh()
        LogoPanel.Visible = True
        MessagePanel.Visible = False
        genInvoice.Visible = False
        StockPanel.Visible = False
        Panel_Save_btn.Visible = False
        Panel_AddStock_btn.Visible = False
        Panel_Edit_btn.Visible = False
        Panel_Delete_btn.Visible = False
        Label_AddProduct.Visible = False
        Label_EditStocks.Visible = False
        Label_Delete.Visible = False

        Dim adapter As New POSDataSetTableAdapters.productTableAdapter
        'Dim bName As String = EditStock.getName
        ProductDataGrid.DataSource = adapter.GetProductData(businessName)
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles Exit_bttn.Click
        Me.Close()
    End Sub

    Private Sub Menu_bttn_Click(sender As Object, e As EventArgs) Handles Menu_bttn.Click

        If SlidingPanel.Width = 50 Then
            SlidingPanel.Visible = False
            SlidingPanel.Width = 240
            Logo.Show()
            PanelTransition2.ShowSync(SlidingPanel)
        Else
            Logo.Hide()
            SlidingPanel.Visible = False
            SlidingPanel.Width = 50
            PanelTransition.ShowSync(SlidingPanel)
            MainPanel.Dock = DockStyle.Fill
        End If


    End Sub



    Private Sub savePathbtn_Click(sender As Object, e As EventArgs) Handles savePathbtn.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            savePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub SendSMS_Click(sender As Object, e As EventArgs) Handles SendSMS.Click
        custIDPrompter.Visible = False
        sales_panel.Visible = False
        genInvoice.Visible = False
        LogoPanel.Visible = False
        MessagePanel.Visible = True
        StockPanel.Visible = False
        Panel_AddStock_btn.Visible = False
        Panel_Edit_btn.Visible = False
        Panel_Delete_btn.Visible = False
        Label_AddProduct.Visible = False
        Label_EditStocks.Visible = False
        Label_Delete.Visible = False
        Dim adapter As New POSDataSetTableAdapters.DataTable5TableAdapter
        'clear first
        ContactsDataGrid.Rows.Clear()
        For xD = 0 To adapter.GetContacts(businessName).Rows.Count - 1
            ContactsDataGrid.Rows.Add(adapter.GetContacts(businessName).Rows(xD).Item(2), adapter.GetContacts(businessName).Rows(xD).Item(1)) '(xD).Cells(0).Value = adapter.GetContacts(businessName).Rows(xD).Item(0)
            '(xD).Cells(1).Value = adapter.GetContacts(businessName).Rows(xD).Item(0)
        Next

        'ContactsDataGrid.DataSource = adapter.GetContacts(businessName)
    End Sub

    Private Sub Stocks_bttn_Click(sender As Object, e As EventArgs) Handles Stocks_bttn.Click, Elipse_Edit.TargetControlResized
        custIDPrompter.Visible = False
        sales_panel.Visible = False
        genInvoice.Visible = False
        LogoPanel.Visible = False
        MessagePanel.Visible = False
        StockPanel.Visible = True

        BunifuTransition1.ShowSync(Panel_AddStock_btn)
        BunifuTransition1.ShowSync(Panel_Edit_btn)
        BunifuTransition1.ShowSync(Panel_Delete_btn)
        BunifuTransition1.ShowSync(Label_AddProduct)
        BunifuTransition1.ShowSync(Label_EditStocks)
        BunifuTransition1.ShowSync(Label_Delete)


    End Sub

    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click
        LogoPanel.Visible = True
        MessagePanel.Visible = False
        StockPanel.Visible = False
    End Sub

    Private Sub AddStock_bttn_Click(sender As Object, e As EventArgs) Handles AddStock_bttn.Click
        RegisterStock.Show()

    End Sub


    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles Edit_btn.Click

        BunifuTransition1.ShowSync(Panel_Save_btn)

        If ProductDataGrid.SelectedRows.Count > 0 Then
            Dim i As Integer = ProductDataGrid.CurrentRow.Index

        Else
            MessageBox.Show("Select 1 row before you hit Edit")
        End If
        stock_tb.ReadOnly = False
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
        Dim nStock As Integer
        Dim prodId
        If ProductDataGrid.SelectedRows.Count > 0 Then
            Dim i = ProductDataGrid.CurrentRow.Index
            prodId = ProductDataGrid.Rows(i).Cells(0).Value

            nStock = stock_tb.Text

            adapter.UpdateStock(nStock, businessName, prodId)
            ProductDataGrid.DataSource = adapter.GetProductData(businessName)
            ProductDataGrid.EndEdit()

        Else
            MessageBox.Show("Select 1 Stock Cell before you hit save")
        End If

        stock_tb.ReadOnly = True

        adapter.Update(up)
        ProductDataGrid.DataSource = adapter.GetProductData(businessName)
        BunifuTransition1.ShowSync(Panel_Save_btn)
        Panel_Save_btn.Visible = False
        ProductDataGrid.Columns(3).ReadOnly = True


    End Sub




    Private Sub SearchBar_OnValueChanged(sender As Object, e As EventArgs) Handles SearchBar.OnValueChanged
        Dim adapter As New POSDataSetTableAdapters.productTableAdapter
        If SearchBar.Text = "Search" Then
            ProductDataGrid.DataSource = adapter.GetProductData(businessName)
        Else
            ProductDataGrid.DataSource = adapter.SearchProduct(SearchBar.Text, businessName)
        End If

    End Sub

    Private Sub SearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBar.KeyPress
        If SearchBar.Text = "" Then
            SearchBar.Text = "Search"

        End If
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then


            If SearchBar.Text = "Search" Then
                SearchBar.Text = ""

            End If
        End If
    End Sub

    Private Sub Send_btn_Click(sender As Object, e As EventArgs) Handles Send_btn.Click
        Dim aPiCode As String = "TR-ONETR657728_JVZWJ"
        'Disable Button while processing. . .
        Send_btn.Enabled = False
        'Try to send http Web request

        For i As Integer = 0 To ContactsDataGrid.Rows.Count - 1
            Dim num = ContactsDataGrid.Rows(i).Cells(1).Value
            Try
                Dim res As String = itexmo(num, Message_tb.Text, aPiCode)
                If res = "0" Then
                    'If result = 0 then show a success messagebox
                    MsgBox("Success! Message is now on its way...")
                Else
                    'Oops error. . .
                    MsgBox("Error """ & res & """ encountered..." & Environment.NewLine & Environment.NewLine & "Visit ""www.itexmo.com/Developers"" for more details...")
                End If
            Catch ex As Exception
                'Oops TRY error. . .
                MsgBox("Error """ & ex.ToString & """ encountered...")
            End Try
        Next

        'RE enable button
        Send_btn.Enabled = True
    End Sub

    Private Sub genInvoices_Click(sender As Object, e As EventArgs) Handles genInvoices.Click
        custIDPrompter.Visible = False
        sales_panel.Visible = False
        LogoPanel.Visible = False
        MessagePanel.Visible = False
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
                    Dim cName As String = CustomerDataGrid1.Rows(9).Cells(5).Value
                    If cName.Trim.Length <> 1 Then
                        Dim index As Integer = selectedRow.Index
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
        custIDPrompter.Visible = False
        sales_panel.Visible = False
        LogoPanel.Visible = False
        MessagePanel.Visible = False
        StockPanel.Visible = False
        genInvoice.Visible = False
        sales_panel.Visible = True
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -90
        loadAnalytics(businessName, Date.Now.ToString("yyyy/MM/dd HH:mm:ss"), Chart1, CInt(Val(TextBox1.Text)))
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            loadAnalytics(businessName, dateStart.Value, Chart1, CInt(Val(TextBox1.Text)))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dateStart_ValueChanged(sender As Object, e As EventArgs) Handles dateStart.ValueChanged
        Try
            loadAnalytics(businessName, dateStart.Value, Chart1, CInt(Val(TextBox1.Text)))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles stock_tb.TextChanged

    End Sub



    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        custIDPrompter.Visible = False
    End Sub

    Private Sub MessagePanel_Paint(sender As Object, e As PaintEventArgs) Handles MessagePanel.Paint

    End Sub












    ' Private Sub Label4_Click(sender As Object, e As EventArgs)
    '   Label4.Text = RegisterTab.loggedInBusinessName
    '  End Sub





    ' Private Sub stock_combotext_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load
    'Dim adapter As New POSDataSetTableAdapters.product2TableAdapter
    'Dim userBusinessName As String = "Boboy's Refreshers"
    'If RegisterTab.loggedInBusinessName = userBusinessName Then
    '       stock_combotext.DataSource = adapter.GetDataProduct(userBusinessName)
    '       stock_combotext.DisplayMember = "pName"
    '        stock_combotext.ValueMember = "pStock"
    'End If
    ' End Sub





    ' Private Sub stock_combotext_SelectionChangeCommitted(sender As Object, e As EventArgs)
    '    qty_txt.Text = stock_combotext.SelectedValue.ToString()
    ' End Sub

    ' Private Sub Add_Stock_Click(sender As Object, e As EventArgs)

    ' Dim adapter As New POSDataSetTableAdapters.product2TableAdapter
    ' Dim adapterupdate As New POSDataSetTableAdapters.TableAdapterManager
    'Dim POS As New POSDataSet
    '
    'Dim userBusinessName As String = "Boboy's Refreshers"
    'RegisterTab.loggedInBusinessName = userBusinessName Then
    '      adapter.AddStock(AddStock_txt.Text, stock_combotext.Text)
    '    adapter.Update(POS)
    '  End If
    '   End Sub

    ' Private Sub StockPanel_Paint(sender As Object, e As PaintEventArgs) Handles StockPanel.Paint

    ' End Sub
End Class