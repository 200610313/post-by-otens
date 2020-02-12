Public Class product
    Private prodName As String
    Private prodNum As String
    Private prodPrice As Double
    Private prodStock As Integer
    Private prodImage As Image
    Private shoppingCartCount As Integer
    Private shoppingCartSubtotal As Double
    Private shoppingCartIsIncluded As Boolean

    Private item As shoppingCartItem 'Product can only be added once in shopping cart, so only one instance of this is created
    Private visualProductStock As Integer

    Public Sub New(prodName As String, prodNum As String, prodPrice As Double, prodStock As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.prodName = prodName 'from DB
        Me.prodNum = prodNum 'from DB
        Me.prodPrice = prodPrice 'from DB
        Me.prodStock = prodStock 'from DB

        Me.visualProductStock = Me.prodStock 'This is a copy of prodStock; edit of prodStock is illegal
        shoppingCartCount = 0
        shoppingCartSubtotal = 0
        shoppingCartIsIncluded = False
        updateRenders()
    End Sub

    Public Function getProdName()
        Return prodName
    End Function
    'Update what the user can see
    Private Sub updateRenders()
        pName.Text = prodName
        pNum.Text = "#" + prodNum.ToString
        pStock.Text = visualProductStock.ToString + " left"
        'Setting the correct colors of stocks
        If visualProductStock = 0 Then
            pStock.ForeColor = Color.FromArgb(235, 76, 52)
        Else
            pStock.ForeColor = Color.FromArgb(192, 255, 192)
        End If

        pPrice.Text = "PHP" + prodPrice.ToString
    End Sub
#Region "Properties"
    Public Property Product_Price() As Double
        Get
            Return prodPrice
        End Get
        Set(value As Double)
            prodPrice = value
        End Set
    End Property
    Public Property Product_Number() As String
        Get
            Return prodNum
        End Get
        Set(value As String)
            prodNum = value
        End Set
    End Property
    Public Property Product_Name() As String
        Get
            Return prodName
        End Get
        Set(value As String)
            prodName = value
        End Set
    End Property
    Public Property Product_Stock() As Integer
        Get
            Return prodStock
        End Get
        Set(value As Integer)
            prodStock = value
        End Set
    End Property
    Public Property Product_Image() As Image
        Get
            Return prodImage
        End Get
        Set(value As Image)
            prodImage = value
        End Set
    End Property
#End Region
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If prodStock > 0 Then
            'If not yed added to shopping cart, add it.
            If Not shoppingCartIsIncluded Then
                decrementVisualStock()
                shoppingCartIsIncluded = True
                shoppingCartCount = +1

                'Make new shopping cart item
                item = New shoppingCartItem(Me.prodName, Me.prodNum, Me.shoppingCartCount, Me.shoppingCartSubtotal, Me)

                item.ShoppingCart_Count = shoppingCartCount 'update count on shopping cart
                item.ShoppingCart_Subtotal = CDbl(Val(shoppingCartCount * prodPrice)) 'update subtotal on shopping cart

                'Add to shopping cart view
                RegisterTab.addToShoppingCart(item)
                RegisterTab.updateTotals()
            Else
                If shoppingCartCount + 1 <= prodStock Then
                    decrementVisualStock()
                    shoppingCartCount = shoppingCartCount + 1
                    item.ShoppingCart_Count = shoppingCartCount 'update count on shopping cart
                    item.ShoppingCart_Subtotal = CDbl(Val(shoppingCartCount * prodPrice)) 'update subtotal on shopping cart
                    RegisterTab.updateTotals()
                End If
            End If
        End If


    End Sub
    Private Sub decrement_btn_Click(sender As Object, e As EventArgs) Handles decrement_btn.Click
        If shoppingCartCount - 1 > 0 Then
            incrementVisualStock()
            shoppingCartCount = shoppingCartCount - 1
            item.ShoppingCart_Count = shoppingCartCount 'update count on shopping cart
            item.ShoppingCart_Subtotal = CDbl(Val(shoppingCartCount * prodPrice)) 'update subtotal on shopping cart
            RegisterTab.updateTotals()
        Else
            tryRemoveFromShoppingCart()
        End If
    End Sub
    Public Sub tryRemoveFromShoppingCart()
        If shoppingCartIsIncluded Then
            item.ShoppingCart_Count = 0
            If item.ShoppingCart_Count = 0 Then
                shoppingCartIsIncluded = False
                item.Is_InShoppingCart = False

                visualProductStock = prodStock
                pStock.Text = visualProductStock.ToString + " left" 'Update label
                pStock.ForeColor = Color.FromArgb(192, 255, 192)
                RegisterTab.removeFromShoppingCart(item.Product_Number) 'get its index from the list
                RegisterTab.updateTotals()
            End If
        End If

    End Sub
    Private Sub decrementVisualStock()
        visualProductStock = visualProductStock - 1 'Decrement visual stock
        pStock.Text = visualProductStock.ToString + " left" 'Update label
        If CInt(visualProductStock) = 0 Then 'Change color if empty
            pStock.ForeColor = Color.FromArgb(235, 76, 52)
        End If
    End Sub

    Private Sub incrementVisualStock()
        visualProductStock = visualProductStock + 1 'Decrement visual stock
        pStock.Text = visualProductStock.ToString + " left" 'Update label
        If CInt(visualProductStock) > 0 Then 'Change color if empty
            pStock.ForeColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub remove_btn_Click(sender As Object, e As EventArgs) Handles remove_btn.Click
        If shoppingCartIsIncluded Then
            item.ShoppingCart_Count = 0
            tryRemoveFromShoppingCart()
        End If

    End Sub
End Class
