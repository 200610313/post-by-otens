Public Class tempForm
    Public bName As String
    Private Sub tempForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bName = "Boboy's Refreshers"
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -90

        loadAnalytics(bName, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Chart1, BunifuSlider1.Value)
    End Sub

    Private Sub BunifuSlider1_ValueChanged(sender As Object, e As EventArgs) Handles BunifuSlider1.ValueChanged
        loadAnalytics(bName, dateStart.Value, Chart1, BunifuSlider1.Value)
    End Sub

    Private Sub dateStart_onValueChanged(sender As Object, e As EventArgs) Handles dateStart.onValueChanged
        Try
            loadAnalytics(bName, dateStart.Value, Chart1, BunifuSlider1.Value)
        Catch ex As Exception

        End Try
    End Sub
End Class