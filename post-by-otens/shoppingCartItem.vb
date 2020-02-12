Public Class shoppingCartItem
    Private shoppingCartIsIncluded As Boolean
    Private prodName As String
    Private prodNum As String
    Private shoppingCartCount As Integer
    Private shoppingCartSubtotal As Double
    Private prodItem As product
    Public Sub New(ByRef prodName As String, ByRef prodNum As String, ByRef shoppingCartCount As Integer, ByRef shoppingCartSubtotal As Double, ByRef prodItem As product)
        ' This call is required by the designer.
        InitializeComponent()
        Me.prodName = prodName
        Me.prodNum = prodNum
        Me.shoppingCartCount = shoppingCartCount
        Me.shoppingCartSubtotal = shoppingCartSubtotal
        Me.shoppingCartIsIncluded = True
        Me.prodItem = prodItem
        updateVisuals()

        pName.Font = New Font("Roboto Lt", pName.Font.Size)
        pNum.Font = New Font("Roboto Lt", pNum.Font.Size)
        pCount.Font = New Font("Roboto Lt", pCount.Font.Size)
        pSubTotal.Font = New Font("Roboto Lt", pSubTotal.Font.Size)
    End Sub
    Function getShoppingCartCount() As Integer
        Return shoppingCartCount
    End Function
    Function getShoppingCartSubtotal() As Double
        Return shoppingCartSubtotal
    End Function
    Function getProdNum() As String
        Return prodNum
    End Function
    Function getSubtotal() As Double
        Return shoppingCartSubtotal
    End Function

    Private Sub updateVisuals()
        pNum.Text = "#" + prodNum.ToString
        pName.Text = prodName.ToString
        pCount.Text = shoppingCartCount.ToString + "x"
        pSubTotal.Text = "PHP" + shoppingCartSubtotal.ToString
    End Sub
#Region "Properties"
    Public Property Is_InShoppingCart() As Boolean
        Get
            Return shoppingCartIsIncluded
        End Get
        Set(value As Boolean)
            shoppingCartIsIncluded = value
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
    Public Property Product_Number() As String
        Get
            Return prodNum
        End Get
        Set(value As String)
            prodNum = value
        End Set
    End Property

    Public Property ShoppingCart_Count() As String
        Get
            Return shoppingCartCount
        End Get
        Set(value As String)
            shoppingCartCount = value
            updateVisuals()
        End Set
    End Property
    Public Property ShoppingCart_Subtotal() As String
        Get
            Return shoppingCartSubtotal
        End Get
        Set(value As String)
            shoppingCartSubtotal = value
            updateVisuals()
        End Set
    End Property

    Private Sub included_OnChange(sender As Object, e As EventArgs) Handles included.OnChange
        If included.Checked = False Then
            prodItem.tryRemoveFromShoppingCart()
        End If
    End Sub
#End Region
End Class
