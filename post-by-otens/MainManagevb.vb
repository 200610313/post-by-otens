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


    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles Exit_bttn.Click
        Me.Close()
    End Sub

    Private Sub Menu_bttn_Click(sender As Object, e As EventArgs)

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

        'clear first

        'ContactsDataGrid.DataSource = adapter.GetContacts(businessName)
        loadContacts()
    End Sub

    Private Sub loadContacts()
        Dim wadwAdpater As New POSDataSetTableAdapters.DataTable5TableAdapter
        ContactsDataGrid.Rows.Clear()
        For xD = 0 To wadwAdpater.GetContacts(businessName).Rows.Count - 1
            ContactsDataGrid.Rows.Add(wadwAdpater.GetContacts(businessName).Rows(xD).Item(2), wadwAdpater.GetContacts(businessName).Rows(xD).Item(1)) '(xD).Cells(0).Value = adapter.GetContacts(businessName).Rows(xD).Item(0)
            '(xD).Cells(1).Value = adapter.GetContacts(businessName).Rows(xD).Item(0)
        Next
    End Sub

    Private Sub Stocks_bttn_Click(sender As Object, e As EventArgs) Handles Stocks_bttn.Click, Elipse_Edit.TargetControlResized
        custIDPrompter.Visible = False
        sales_panel.Visible = False
        genInvoice.Visible = False
        LogoPanel.Visible = False
        MessagePanel.Visible = False
        StockPanel.Visible = True



        Dim adapter As New POSDataSetTableAdapters.productTableAdapter
        'Dim bName As String = EditStock.getName
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
        MessagePanel.Visible = False
        StockPanel.Visible = False
    End Sub

    Private Sub AddStock_bttn_Click(sender As Object, e As EventArgs) Handles AddStock_bttn.Click
        RegisterStock.Show()
    End Sub


    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles Edit_btn.Click

        BunifuTransition1.ShowSync(Panel_Save_btn)

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
        BunifuTransition1.ShowSync(Panel_Save_btn)
        Panel_Save_btn.Visible = False



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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles stock_tb.TextChanged

    End Sub



    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        custIDPrompter.Visible = False
    End Sub

    Private Sub MessagePanel_Paint(sender As Object, e As PaintEventArgs) Handles MessagePanel.Paint

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

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub genInvoice_Paint(sender As Object, e As PaintEventArgs) Handles genInvoice.Paint

    End Sub

    Private Sub savePath_TextChanged(sender As Object, e As EventArgs) Handles savePath.TextChanged

    End Sub

    Private Sub custIDPrompter_Paint(sender As Object, e As PaintEventArgs) Handles custIDPrompter.Paint

    End Sub

    Private Sub newowner_Click(sender As Object, e As EventArgs) Handles newowner.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub CustomerDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGrid1.CellContentClick

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub LogoPanel_Paint(sender As Object, e As PaintEventArgs) Handles LogoPanel.Paint

    End Sub

    Private Sub sales_panel_Paint(sender As Object, e As PaintEventArgs) Handles sales_panel.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub ContactsDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ContactsDataGrid.CellContentClick

    End Sub

    Private Sub Message_tb_TextChanged(sender As Object, e As EventArgs) Handles Message_tb.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub StockPanel_Paint(sender As Object, e As PaintEventArgs) Handles StockPanel.Paint

    End Sub

    Private Sub Panel_Add_Stocks_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Add_Stocks.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Panel_Save_btn_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Save_btn.Paint

    End Sub

    Private Sub Label_Delete_Click(sender As Object, e As EventArgs) Handles Label_Delete.Click

    End Sub

    Private Sub Label_EditStocks_Click(sender As Object, e As EventArgs) Handles Label_EditStocks.Click

    End Sub

    Private Sub Label_AddProduct_Click(sender As Object, e As EventArgs) Handles Label_AddProduct.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub



    Private Sub ProductBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ProductBindingSource.CurrentChanged

    End Sub

    Private Sub POSDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles POSDataSetBindingSource.CurrentChanged

    End Sub

    Private Sub Panel_Delete_btn_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Delete_btn.Paint

    End Sub

    Private Sub Panel_Edit_btn_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Edit_btn.Paint

    End Sub

    Private Sub Panel_AddStock_btn_Paint(sender As Object, e As PaintEventArgs) Handles Panel_AddStock_btn.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ProductBindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles ProductBindingSource1.CurrentChanged

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub CustomerBindingSource2_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerBindingSource2.CurrentChanged

    End Sub

    Private Sub CustomerBindingSource3_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerBindingSource3.CurrentChanged

    End Sub

    Private Sub DataTable5BindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DataTable5BindingSource.CurrentChanged

    End Sub

    Private Sub CustomerBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerBindingSource.CurrentChanged

    End Sub

    Private Sub ProductBindingSource2_CurrentChanged(sender As Object, e As EventArgs) Handles ProductBindingSource2.CurrentChanged

    End Sub

    Private Sub POSDataSet1BindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles POSDataSet1BindingSource.CurrentChanged

    End Sub

    Private Sub CustomerBindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerBindingSource1.CurrentChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SlidingPanel_Paint(sender As Object, e As PaintEventArgs) Handles SlidingPanel.Paint

    End Sub

    Private Sub monthlysalesPNL_Paint(sender As Object, e As PaintEventArgs) Handles monthlysalesPNL.Paint

    End Sub

    Private Sub reportPath_TextChanged(sender As Object, e As EventArgs) Handles reportPath.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PanelTop_Paint(sender As Object, e As PaintEventArgs) Handles PanelTop.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel_prod.Paint

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles prod_tb.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel_price.Paint

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles price_tb.TextChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel_image.Paint

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles image_tb.TextChanged

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