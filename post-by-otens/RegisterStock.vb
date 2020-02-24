Public Class RegisterStock




    Private Sub ProductName_txt_MouseLeave(sender As Object, e As EventArgs) Handles ProductName_txt.MouseLeave
        If ProductName_txt.Text = "" Then
            ProductName_txt.Text = "Product Name"
        End If
    End Sub

    Private Sub ProductName_txt_MouseEnter(sender As Object, e As EventArgs) Handles ProductName_txt.MouseEnter
        If ProductName_txt.Text = "Product Name" Then
            ProductName_txt.Text = ""
        End If
    End Sub

    Private Sub ProductName_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductName_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            If ProductName_txt.Text = "Product Name" Then
                ProductName_txt.Text = ""

            End If

        End If
    End Sub



    Private Sub Qty_txt_MouseEnter(sender As Object, e As EventArgs) Handles Qty_txt.MouseEnter, imgurl.MouseEnter
        If Qty_txt.Text = "Qty." Then
            Qty_txt.Text = ""
        End If
    End Sub

    Private Sub Qty_txt_MouseLeave(sender As Object, e As EventArgs) Handles Qty_txt.MouseLeave, imgurl.MouseLeave
        If Qty_txt.Text = "" Then
            Qty_txt.Text = "Qty."
        End If
    End Sub

    Private Sub Qty_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Qty_txt.KeyPress, imgurl.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            If Qty_txt.Text = "Qty." Then
                Qty_txt.Text = ""
            End If

        End If
    End Sub

    Private Sub Price_txt_MouseEnter(sender As Object, e As EventArgs) Handles Price_txt.MouseEnter
        If Price_txt.Text = "Price." Then
            Price_txt.Text = ""
        End If
    End Sub

    Private Sub Price_txt_MouseLeave(sender As Object, e As EventArgs) Handles Price_txt.MouseLeave
        If Price_txt.Text = "" Then
            Price_txt.Text = "Price."
        End If

    End Sub

    Private Sub Price_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Price_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            If Price_txt.Text = "Price." Then
                Price_txt.Text = ""

            End If

        End If
    End Sub

    Private Sub AddStock_bttn_Click(sender As Object, e As EventArgs) Handles AddStock_bttn.Click

        Dim adapter As New POSDataSetTableAdapters.productTableAdapter
        Dim up As New POSDataSet.productDataTable

        Dim imageUrl As String = imgurl.Text
        Dim bName As String = EditStock.getName()
        adapter.AddStock(ProductName_txt.Text, Val(Price_txt.Text), CInt(Price_txt.Text), bName, imageUrl)
        adapter.Update(up)
        'pls fix I modified main manage vb to accept businessName as parameter in new to save the businessName
        'MainManagevb.ProductDataGrid.DataSource = adapter.GetProductData(bName)
        Me.Hide()
        Refresh()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Price_txt.Text = "Price."
        Qty_txt.Text = "Qty."
        ProductName_txt.Text = "Product Name"

    End Sub

    Private Sub RegisterStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub imgurl_mouseleave(sender As Object, e As EventArgs) Handles imgurl.MouseLeave
        Try
            pImage.Load(imgurl.Text)
            pImage.Refresh()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Exit_bttn_Click(sender As Object, e As EventArgs) Handles Exit_bttn.Click
        Me.Close()
    End Sub

    Private Sub imgurl_TextChanged(sender As Object, e As EventArgs) Handles imgurl.TextChanged

    End Sub
End Class