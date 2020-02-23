Module EditStock
    Public bName As String

    Public Sub setName(businessName As String)
        bName = businessName
    End Sub

    Function getName()
        Return bName
    End Function

End Module
