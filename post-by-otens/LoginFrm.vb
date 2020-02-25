Public Class LoginFrm

    Public businessName As String

    Private Sub SignIn_bttm_Click(sender As Object, e As EventArgs) Handles SignIn_bttm.Click
        businessName = bName.Text
        '   If logging in as manager
        EditStock.setName(businessName)
        If asManager.Checked = True Then
            Password_txt.PasswordChar = ""
            MessageBox.Show(Password_txt.Text)
            Dim managerUsername = Username_txt.Text
            Dim managerPword = Password_txt.Text
            Dim adapter As New POSDataSetTableAdapters.businessTableAdapter

            If adapter.validateManager(businessName, managerUsername, managerPword) = 1 Then
                MainManagevb.Show()
                Me.Close()
            End If
        Else
            Password_txt.PasswordChar = ""
            Dim registerU = Username_txt.Text
            Dim registerP = Password_txt.Text
            Dim adapter As New POSDataSetTableAdapters.businessTableAdapter
            If adapter.validateRegister(businessName, registerU, registerP) <> 0 Then
                'Dim managerView As New MainManagevb(businessName)
                RegisterTab.Show()
                Me.Close()
            End If
        End If
        Password_txt.PasswordChar = "*"
        'If Not Username_txt.Text.Equals(u) Or Not Password_txt.Text.Equals(p) Then
        '    ErrorProvider1.SetError(SignIn_bttm, "Wrong Username or Password")
        'Else
        '    RegisterTab.Show()
        '    Me.Close()
        'End If



    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class