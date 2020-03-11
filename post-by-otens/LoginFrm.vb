Public Class LoginFrm

    Public businessName As String

    Private Sub SignIn_bttm_Click(sender As Object, e As EventArgs) Handles SignIn_bttm.Click
        businessName = bName.Text
        '   If logging in as manager
        EditStock.setName(businessName)

        Password_txt.PasswordChar = ""

        Dim un = Username_txt.Text

        Dim pw = Password_txt.Text

        Dim adapter As New POSDataSetTableAdapters.businessTableAdapter

        If adapter.checkManager(businessName, un, pw) = 1 Then
            'success login mngr
            MainManagevb.Show()
            Me.Close()
        ElseIf adapter.checkRegister(businessName, un, pw) = 1 Then
            'success login register
            RegisterTab.Show()
            Me.Close()
        End If
        '  End If
        'Else
        '  Password_txt.PasswordChar = ""
        'Dim registerU = Username_txt.Text
        'Dim registerP = Password_txt.Text
        '  Dim adapter As New POSDataSetTableAdapters.businessTableAdapter
        '   If adapter.validateRegister(businessName, registerU, registerP) <> 0 Then
        'Dim managerView As New MainManagevb(businessName)
        'RegisterTab.Show()
        'Me.Close()
        ' End If
        'End If
        'Password_txt.PasswordChar = "*"
        'If Not Username_txt.Text.Equals(u) Or Not Password_txt.Text.Equals(p) Then
        '    ErrorProvider1.SetError(SignIn_bttm, "Wrong Username or Password")
        'Else
        '    RegisterTab.Show()
        '    Me.Close()
        'End If



    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            verify(new_BName.Text, new_BPhone.Text, bmail_txtbx.Text, new_BFName.Text, new_BMinit.Text, new_BLName.Text, mun_txtbx.Text, mpw_txtbx.Text, run_txtbx.Text, rpw_txtbx.Text, mpin_txtbx.Text)
            bReg_pnl.Visible = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub signup_btn_Click(sender As Object, e As EventArgs) Handles signup_btn.Click
        bReg_pnl.Visible = True
    End Sub

    Private Sub exitBreg_btn_Click(sender As Object, e As EventArgs) Handles exitBreg_btn.Click
        bReg_pnl.Visible = False
    End Sub

    Private Sub exitLogn_Click(sender As Object, e As EventArgs) Handles exitLogn.Click
        Me.Close()
    End Sub
End Class