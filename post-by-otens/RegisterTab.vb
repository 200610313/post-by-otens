Public Class RegisterTab
    Private products As List(Of product)
    Private shoppingCartItems As List(Of shoppingCartItem)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'POSDBDS.Table' table. You can move, or remove it, as needed.
        products = New List(Of product)
        shoppingCartItems = New List(Of shoppingCartItem)
        'Load products from DB, display in panel
        loadProducts()
        initShoppingCart()

        Dim DB As New POSDataSetTableAdapters.productTableAdapter
        'DB.GetData.Columns.Count
        'DB.GetData.Rows.Count
        'DB.GetData.Rows(0).Item(1) = get field at first row, second column



    End Sub

    Private Sub initShoppingCart()
        shoppingCart_flow.FlowDirection = FlowDirection.LeftToRight
        shoppingCart_flow.AutoScroll = True
    End Sub

    Private Sub loadProducts()
        For i = 1 To 20
            products.Add(New product("Default", i.ToString, 10.23 * i, i * 3)) 'product name/product number/product price/product stock = Load these from DB
        Next

        FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        For Each product In products
            FlowLayoutPanel1.Controls.Add(product)
        Next
    End Sub

    Private Sub amtReceivedKeyPress(sender As Object, e As EventArgs) Handles amtRecvd.KeyPress
        validateInput(e)
    End Sub

    Private Sub validateInput(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
        Else
            e.Handled = True
        End If
    End Sub
    'to correct change value
    Private Sub renderChange()
        Dim x, y As Double
        If Double.TryParse(amtRecvd.Text.ToString, x) And Double.TryParse(totalAmt.Text.ToString, y) Then
            changeAmt.Text = (x - y)
        End If
    End Sub

    Private Sub amtRecvd_OnValueChanged(sender As Object, e As EventArgs) Handles amtRecvd.OnValueChanged
        If String.IsNullOrEmpty(amtRecvd.Text) Then
            changeAmt.Text = totalAmt.Text
        End If
        renderChange()
    End Sub

    Private Sub ShoppingCartItem1_Load(sender As Object, e As EventArgs)

    End Sub
    'Parameters are received by reference to simplify updates of values
    Friend Shared Sub addToShoppingCart(ByRef item)
        'Add to list
        RegisterTab.shoppingCartItems.Add(item)
        'Add the last element of the list to the shopping cart
        RegisterTab.shoppingCart_flow.Controls.Add(RegisterTab.shoppingCartItems.Item(RegisterTab.shoppingCartItems.Count - 1))
    End Sub

    Friend Shared Sub updateShoppingCart()
        RegisterTab.shoppingCart_flow.Controls.Clear()
        For Each shoppingCartItem In RegisterTab.shoppingCartItems
            RegisterTab.shoppingCart_flow.Controls.Add(shoppingCartItem)
        Next
    End Sub

    Friend Shared Sub updateTotals()
        Dim x As Double
        'x receives the sum of all the subtotals in the shoppingCart
        For Each shoppingCartItem In RegisterTab.shoppingCartItems
            x = x + CDbl(Val(shoppingCartItem.ShoppingCart_Subtotal))
        Next
        'update text
        RegisterTab.totalAmt.Text = x.ToString
    End Sub

    Friend Shared Sub removeFromShoppingCart(product_Number As String)
        'Finding identical product number
        For i = 0 To RegisterTab.shoppingCartItems.Count - 1
            If String.Compare(product_Number, RegisterTab.shoppingCartItems(i).Product_Number) = 0 Then
                RegisterTab.shoppingCartItems.RemoveAt(i)
                Exit For
            End If
        Next
        RegisterTab.updateShoppingCart()
    End Sub
End Class
