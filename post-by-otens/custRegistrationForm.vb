Imports Bunifu.Framework.UI

Public Class custRegistrationForm
    Private cFName, cLName, cMInit, cCity, cState, cZip, cPhone
    Private Sub zip_OnValueChanged(sender As Object, e As EventArgs) Handles zip.OnValueChanged
        If String.IsNullOrEmpty(zip.Text) Or Not IsNumeric(zip.Text) Then
            zip.LineFocusedColor = Color.FromArgb(192, 255, 192)
            zip.LineIdleColor = Color.FromArgb(255, 128, 128)
            zip.LineMouseHoverColor = Color.FromArgb(255, 128, 128)
        Else
            zip.LineFocusedColor = Color.FromArgb(192, 255, 192)
            zip.LineIdleColor = Color.FromArgb(192, 255, 192)
            zip.LineMouseHoverColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub phone_OnValueChanged(sender As Object, e As EventArgs) Handles phone.OnValueChanged
        If String.IsNullOrEmpty(phone.Text) Or Not IsNumeric(phone.Text) Or phone.Text.Length <> 11 Then
            phone.LineFocusedColor = Color.FromArgb(192, 255, 192)
            phone.LineIdleColor = Color.FromArgb(255, 128, 128)

            phone.LineMouseHoverColor = Color.FromArgb(255, 128, 128)
        Else
            phone.LineFocusedColor = Color.FromArgb(192, 255, 192)
            phone.LineIdleColor = Color.FromArgb(192, 255, 192)

            phone.LineMouseHoverColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub submitbutton_Click(sender As Object, e As EventArgs) Handles submitbutton.Click
        If fN.LineIdleColor <> Color.FromArgb(192, 255, 192) Or mI.LineIdleColor <> Color.FromArgb(192, 255, 192) Or lN.LineIdleColor <> Color.FromArgb(192, 255, 192) Or city.LineIdleColor <> Color.FromArgb(192, 255, 192) Or state.LineIdleColor <> Color.FromArgb(192, 255, 192) Or zip.LineIdleColor <> Color.FromArgb(192, 255, 192) Or phone.LineIdleColor <> Color.FromArgb(192, 255, 192) Then
        Else
            registerCustomer(fN.Text, lN.Text, mI.Text, city.Text, state.Text, zip.Text, phone.Text)
            RegisterTab.Show()
            updateDBStock()
            RegisterTab.resetView()
            Me.Close()
        End If
    End Sub

    Private Sub custRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        RegisterTab.Show()


        Me.Close()
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Show()
    End Sub

    Private Sub managerClose_btn_Click(sender As Object, e As EventArgs) Handles managerClose_btn.Click
        Me.Close()
    End Sub

    Private Sub fN_OnValueChanged(sender As Object, e As EventArgs) Handles fN.OnValueChanged
        If String.IsNullOrEmpty(fN.Text) Then
            fN.LineFocusedColor = Color.FromArgb(192, 255, 192)
            fN.LineIdleColor = Color.FromArgb(255, 128, 128)
            fN.LineMouseHoverColor = Color.FromArgb(255, 128, 128)
        Else
            fN.LineFocusedColor = Color.FromArgb(192, 255, 192)
            fN.LineIdleColor = Color.FromArgb(192, 255, 192)
            fN.LineMouseHoverColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub mI_OnValueChanged(sender As Object, e As EventArgs) Handles mI.OnValueChanged
        If String.IsNullOrEmpty(mI.Text) Or mI.Text.Length <> 1 Then
            mI.LineFocusedColor = Color.FromArgb(192, 255, 192)
            mI.LineIdleColor = Color.FromArgb(255, 128, 128)
            mI.LineMouseHoverColor = Color.FromArgb(255, 128, 128)
        Else
            mI.LineFocusedColor = Color.FromArgb(192, 255, 192)
            mI.LineIdleColor = Color.FromArgb(192, 255, 192)
            mI.LineMouseHoverColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub lN_OnValueChanged(sender As Object, e As EventArgs) Handles lN.OnValueChanged
        If String.IsNullOrEmpty(lN.Text) Then
            lN.LineFocusedColor = Color.FromArgb(192, 255, 192)
            lN.LineIdleColor = Color.FromArgb(255, 128, 128)
            lN.LineMouseHoverColor = Color.FromArgb(255, 128, 128)
        Else
            lN.LineFocusedColor = Color.FromArgb(192, 255, 192)
            lN.LineIdleColor = Color.FromArgb(192, 255, 192)
            lN.LineMouseHoverColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub
    Private Sub city_OnValueChanged(sender As Object, e As EventArgs) Handles city.OnValueChanged
        If String.IsNullOrEmpty(city.Text) Then
            city.LineFocusedColor = Color.FromArgb(192, 255, 192)
            city.LineIdleColor = Color.FromArgb(255, 128, 128)
            city.LineMouseHoverColor = Color.FromArgb(255, 128, 128)
        Else
            city.LineFocusedColor = Color.FromArgb(192, 255, 192)
            city.LineIdleColor = Color.FromArgb(192, 255, 192)
            city.LineMouseHoverColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub state_OnValueChanged(sender As Object, e As EventArgs) Handles state.OnValueChanged
        If String.IsNullOrEmpty(state.Text) Then
            state.LineFocusedColor = Color.FromArgb(192, 255, 192)
            state.LineIdleColor = Color.FromArgb(255, 128, 128)
            state.LineMouseHoverColor = Color.FromArgb(255, 128, 128)
        Else
            state.LineFocusedColor = Color.FromArgb(192, 255, 192)
            state.LineIdleColor = Color.FromArgb(192, 255, 192)
            state.LineMouseHoverColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Private Sub submit_managerbtn_Click(sender As Object, e As EventArgs) Handles submit_managerbtn.Click
        If fN.LineIdleColor <> Color.FromArgb(192, 255, 192) Or mI.LineIdleColor <> Color.FromArgb(192, 255, 192) Or lN.LineIdleColor <> Color.FromArgb(192, 255, 192) Or city.LineIdleColor <> Color.FromArgb(192, 255, 192) Or state.LineIdleColor <> Color.FromArgb(192, 255, 192) Or zip.LineIdleColor <> Color.FromArgb(192, 255, 192) Or phone.LineIdleColor <> Color.FromArgb(192, 255, 192) Then

        Else
            queryUpdate(fN.Text, lN.Text, mI.Text, city.Text, state.Text, zip.Text, phone.Text)
            Me.Close()
        End If
    End Sub
End Class