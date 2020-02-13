
Public Class Manage
    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        'Disable Button while processing. . .
        ButtonSend.Enabled = False
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
        ButtonSend.Enabled = True
    End Sub

    Private Sub MainManagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class