Imports System.Data.DataTable

Public Class MainManagevb
    Public adp As Odbc.OdbcDataAdapter
    Public products As List(Of product)
    Public shoppingCartItems As List(Of shoppingCartItem)
    Public businessName As String

    Public Sub New(businessName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.businessName = Me.businessName
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



    Private Sub MainManagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POSDataSet.product' table. You can move, or remove it, as needed.
        Refresh()
        LogoPanel.Visible = True
        MessagePanel.Visible = False
        StockPanel.Visible = False
        Panel_Save_btn.Visible = False
        Panel_AddStock_btn.Visible = False
        Panel_Edit_btn.Visible = False
        Panel_Delete_btn.Visible = False
        Label_AddProduct.Visible = False
        Label_EditStocks.Visible = False
        Label_Delete.Visible = False

        Dim adapter As New POSDataSetTableAdapters.productTableAdapter
        Dim bName As String = EditStock.getName
        ProductDataGrid.DataSource = adapter.GetProductData(bName)


    End Sub

    Private Sub SendSMS_Click(sender As Object, e As EventArgs) Handles SendSMS.Click
        LogoPanel.Visible = False
        MessagePanel.Visible = True
        StockPanel.Visible = False
        Panel_AddStock_btn.Visible = False
        Panel_Edit_btn.Visible = False
        Panel_Delete_btn.Visible = False
        Label_AddProduct.Visible = False
        Label_EditStocks.Visible = False
        Label_Delete.Visible = False
    End Sub

    Private Sub Stocks_bttn_Click(sender As Object, e As EventArgs) Handles Stocks_bttn.Click, Elipse_Edit.TargetControlResized
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


    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles Edit_btn.Click, BunifuImageButton1.Click

        BunifuTransition1.ShowSync(Panel_Save_btn)

        ProductDataGrid.Columns(4).ReadOnly = False
    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click
        Dim adapter As New POSDataSetTableAdapters.productTableAdapter
        Dim bName As String = EditStock.getName
        Dim up As New POSDataSet.productDataTable
        Dim nStock As Integer
        Dim prodId

        For i As Integer = 0 To ProductDataGrid.Rows.Count - 1
            ProductDataGrid.BeginEdit(i)
            ProductDataGrid.Rows(i).Cells(4).Value = ProductDataGrid.Rows(i).Cells(3).Value
            nStock = ProductDataGrid.Rows(i).Cells(4).Value
            prodId = ProductDataGrid.Rows(i).Cells(0).Value
            adapter.UpdateStock(nStock, bName, prodId)
            ProductDataGrid.EndEdit(i)
        Next

        adapter.Update(up)
        ProductDataGrid.DataSource = adapter.GetProductData(bName)
        BunifuTransition1.ShowSync(Panel_Save_btn)
        Panel_Save_btn.Visible = False
        ProductDataGrid.Columns(4).ReadOnly = True


    End Sub



    Public Sub FilterData()

        Dim str As String = SearchBar.Text
        Try
            If SearchBar.Text.Trim(" ") = " " Then
            Else
                For i As Integer = 0 To ProductDataGrid.Rows.Count - 1
                    For j As Integer = 0 To ProductDataGrid.Rows(i).Cells.Count - 1
                        If ProductDataGrid.Item(j, i).Value.ToString().ToLower.StartsWith(str.ToLower) Then
                            ProductDataGrid.Rows(i).Selected = True
                            ProductDataGrid.CurrentCell = ProductDataGrid.Rows(i).Cells(j)
                            Exit Try
                        End If
                    Next
                Next i
            End If
        Catch abc As Exception
            MessageBox.Show("Sorry!")
        End Try

    End Sub

    Private Sub Search_btn_Click(sender As Object, e As EventArgs) Handles Search_btn.Click
        FilterData()
    End Sub

    Private Sub Send_btn_Click(sender As Object, e As EventArgs) Handles Send_btn.Click
        Dim aPiCode As String = "TR-ONETR657728_JVZWJ"
        'Disable Button while processing. . .
        Send_btn.Enabled = False
        'Try to send http Web request
        Try
            Dim res As String = itexmo(Number_tb.Text, Message_tb.Text, aPiCode)
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
        'RE enable button
        Search_btn.Enabled = True
    End Sub

    Private Sub genInvoices_Click(sender As Object, e As EventArgs) Handles genInvoices.Click
        LogoPanel.Visible = False
        MessagePanel.Visible = False
        StockPanel.Visible = False
        genInvoice.Visible = True

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

            CustomerDataGrid1.Rows.Add(invoiceNum, dateP, total, entry)
        Next
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