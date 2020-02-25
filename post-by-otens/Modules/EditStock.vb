Module EditStock
    Public businessName As String
    Public Sub setName(businessName As String)
        EditStock.businessName = businessName
    End Sub

    Function getName() As String
        Return businessName
    End Function



End Module
