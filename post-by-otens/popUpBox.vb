Public Class popUpBox
    Private choice As String
    Private crf As custRegistrationForm
    Public Function getChoice() As String
        Return choice
    End Function
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.Show()
        Me.BringToFront()
    End Sub

    Private Sub existingbtn_Click(sender As Object, e As EventArgs) Handles existingbtn.Click
        MessageBox.Show("Implement me")
        Me.Close()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        crf = New custRegistrationForm
        Me.Close()
    End Sub

    Private Sub exitForm_Click(sender As Object, e As EventArgs) Handles exitForm.Click
        RegisterTab.Show()
        Me.Close()
    End Sub
End Class