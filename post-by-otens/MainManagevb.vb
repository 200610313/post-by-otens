Imports System.Data.DataTable
Public Class MainManagevb
    Public products As List(Of product)
    Public shoppingCartItems As List(Of shoppingCartItem)
    Public loggedInBusinessName As String
    Public table As New DataTable("product")
    Public index As Integer = 0
    Public ck As Integer = 0
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




    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles Send_bttn.Click

        'Disable Button while processing. . .
        Send_bttn.Enabled = False
        'Try to send http Web request
        Try
            Dim res As String = itexmo(TextBoxNumber.Text, TextBoxMessage.Text, TextBoxApiCode.Text)
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
        Send_bttn.Enabled = True
    End Sub

    Private Sub MainManagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POSDataSet.product' table. You can move, or remove it, as needed.

        LogoPanel.Visible = True
        MessagePanel.Visible = False
        StockPanel.Visible = False

        'Add header in datagridview
        ' ProductDataGrid.DataSource = table
        '   With ProductDataGrid
        '.RowHeadersVisible = False
        '  .Columns(0).HeaderCell.Value = "Product Name"
        '   .Columns(1).HeaderCell.Value = "Stock"
        ' .Columns(2).HeaderCell.Value = "Price"
        'olumns(3).HeaderCell.Value = "ID"
        ' .Columns(4).HeaderCell.Value = "Owner"
        ' End With





    End Sub

    Private Sub SendSMS_Click(sender As Object, e As EventArgs) Handles SendSMS.Click
        LogoPanel.Visible = False
        MessagePanel.Visible = True
        StockPanel.Visible = False
    End Sub

    Private Sub Stocks_bttn_Click(sender As Object, e As EventArgs) Handles Stocks_bttn.Click, Elipse_Edit.TargetControlResized
        LogoPanel.Visible = False
        MessagePanel.Visible = False
        StockPanel.Visible = True
    End Sub

    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click
        LogoPanel.Visible = True
        MessagePanel.Visible = False
        StockPanel.Visible = False
    End Sub

    Private Sub AddStock_bttn_Click(sender As Object, e As EventArgs) Handles AddStock_bttn.Click
        '  Dim adapter As New POSDataSet.productDataTable
        ' ProductBindingSource.DataSource = adapter
        ' ProductDataGrid.DataSource = ProductBindingSource
        ' Dim newRow As DataRow
        ' newRow = adapter.NewRow
        ' With newRow
        '.Item(0) = "NewProduct"
        '.Item(1) = 0
        '   .Item(2) = 0
        '.Item(3) = 12345678911
        '  .Item(4) = "Boboy's Refreshers"
        ' End With
        ' adapter.Rows.Add(newRow)
        '  adapter.AcceptChanges()
        index += 1
        Me.ProductDataGrid.Rows.Add("", 0, 0, index, "Check")

    End Sub

    Private Sub ProductDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGrid.CellContentClick

    End Sub

    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles Edit_btn.Click

        If ProductDataGrid.SelectedRows.ToString Then


        End If

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