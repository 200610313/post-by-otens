Public Class LoginFrm

    Private Sub Username_txt_MouseEnter(sender As Object, e As EventArgs) Handles Username_txt.MouseEnter
        Dim colorHint As Color
        Dim colorText As Color
        colorHint = Color.FromArgb(210, 210, 210)
        colorText = Color.FromArgb(97, 177, 242)

        If Username_txt.Text = "Type your Username" Then
            Username_txt.Text = ""
            Username_txt.ForeColor = colorText
        End If

    End Sub

    Private Sub Username_txt_MouseLeave(sender As Object, e As EventArgs) Handles Username_txt.MouseLeave
        Dim colorHint As Color
        Dim colorText As Color
        colorHint = Color.FromArgb(210, 210, 210)
        colorText = Color.FromArgb(97, 177, 242)

        If Username_txt.Text = "" Then
            Username_txt.Text = "Type your Username"
            Username_txt.ForeColor = colorHint
        End If
    End Sub

    Private Sub Password_txt_MouseEnter(sender As Object, e As EventArgs) Handles Password_txt.MouseEnter
        Dim colorHint As Color
        Dim colorText As Color
        colorHint = Color.FromArgb(210, 210, 210)
        colorText = Color.FromArgb(97, 177, 242)

        If Password_txt.Text = "Type your Password" Then
            Password_txt.Text = ""
            Password_txt.PasswordChar = "•"
            Password_txt.ForeColor = colorText
        End If

    End Sub

    Private Sub Password_txt_MouseLeave(sender As Object, e As EventArgs) Handles Password_txt.MouseLeave
        Dim colorHint As Color
        Dim colorText As Color
        colorHint = Color.FromArgb(210, 210, 210)
        colorText = Color.FromArgb(97, 177, 242)

        If Password_txt.Text = "" Then
            Password_txt.Text = "Type your Password"
            Password_txt.ForeColor = colorHint

        End If
    End Sub



    Private Sub SignIn_bttm_Click(sender As Object, e As EventArgs) Handles SignIn_bttm.Click
        Dim u As String
        Dim p As String
        u = "admin"
        p = "admin123"

        If Not Username_txt.Text.Equals(u) Or Not Password_txt.Text.Equals(p) Then
            ErrorProvider1.SetError(SignIn_bttm, "Wrong Username or Password")
        Else
            RegisterTab.Show()
            Me.Close()
        End If



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class