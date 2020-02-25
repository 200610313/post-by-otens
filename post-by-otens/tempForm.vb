Public Class tempForm
    Private Sub tempForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bName As String = "Boboy's Refreshers"
        loadAnalytics(bName, dateStart.Value)
    End Sub
End Class