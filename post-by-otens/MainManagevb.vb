Public Class MainManagevb
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles Exit_bttn.Click
        Me.Close()
    End Sub

    Private Sub Menu_bttn_Click(sender As Object, e As EventArgs) Handles Menu_bttn.Click

        If SlidingPanel.Width = 50 Then
            SlidingPanel.Visible = False
            SlidingPanel.Width = 240
            Logo.Show()
            PanelTransition2.ShowSync(SlidingPanel)
        Else
            Logo.Hide()
            SlidingPanel.Visible = False
            SlidingPanel.Width = 50
            PanelTransition.ShowSync(SlidingPanel)
            MainPanel.Dock = DockStyle.Fill
        End If


    End Sub




    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles Send_bttn.Click

        'Disable Button while processing. . .
        Send_bttn.Enabled = False
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
        Send_bttn.Enabled = True
    End Sub

    Private Sub MainManagevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogoPanel.Visible = True
        MessagePanel.Visible = False
    End Sub

    Private Sub SendSMS_Click(sender As Object, e As EventArgs) Handles SendSMS.Click
        LogoPanel.Visible = False
        MessagePanel.Visible = True
    End Sub
End Class