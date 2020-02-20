<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Elipse_loginfrm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Username_txt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Password_txt = New System.Windows.Forms.TextBox()
        Me.SignIn_bttm = New System.Windows.Forms.Button()
        Me.Elipse_SignIn = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Elipse_Username = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Elipse_Password = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Remember_ME = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.post_by_otens.My.Resources.Resources.Pewter_Engineers
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-25, -64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(607, 468)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Elipse_loginfrm
        '
        Me.Elipse_loginfrm.ElipseRadius = 20
        Me.Elipse_loginfrm.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.PictureBox1
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(206, 313)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(144, 44)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "Sign In"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Username_txt)
        Me.Panel1.Location = New System.Drawing.Point(92, 393)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 47)
        Me.Panel1.TabIndex = 5
        '
        'Username_txt
        '
        Me.Username_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Username_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_txt.Location = New System.Drawing.Point(15, 13)
        Me.Username_txt.Name = "Username_txt"
        Me.Username_txt.Size = New System.Drawing.Size(340, 20)
        Me.Username_txt.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Password_txt)
        Me.Panel2.Location = New System.Drawing.Point(92, 459)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 47)
        Me.Panel2.TabIndex = 7
        '
        'Password_txt
        '
        Me.Password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Password_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txt.Location = New System.Drawing.Point(16, 14)
        Me.Password_txt.Name = "Password_txt"
        Me.Password_txt.Size = New System.Drawing.Size(340, 20)
        Me.Password_txt.TabIndex = 6
        '
        'SignIn_bttm
        '
        Me.SignIn_bttm.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SignIn_bttm.FlatAppearance.BorderSize = 0
        Me.SignIn_bttm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignIn_bttm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignIn_bttm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SignIn_bttm.Location = New System.Drawing.Point(92, 525)
        Me.SignIn_bttm.Name = "SignIn_bttm"
        Me.SignIn_bttm.Size = New System.Drawing.Size(373, 47)
        Me.SignIn_bttm.TabIndex = 7
        Me.SignIn_bttm.Text = "Sign In"
        Me.SignIn_bttm.UseVisualStyleBackColor = False
        '
        'Elipse_SignIn
        '
        Me.Elipse_SignIn.ElipseRadius = 20
        Me.Elipse_SignIn.TargetControl = Me.SignIn_bttm
        '
        'Elipse_Username
        '
        Me.Elipse_Username.ElipseRadius = 20
        Me.Elipse_Username.TargetControl = Me.Panel1
        '
        'Elipse_Password
        '
        Me.Elipse_Password.ElipseRadius = 20
        Me.Elipse_Password.TargetControl = Me.Panel2
        '
        'Remember_ME
        '
        Me.Remember_ME.AutoSize = True
        Me.Remember_ME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Remember_ME.Location = New System.Drawing.Point(92, 578)
        Me.Remember_ME.Name = "Remember_ME"
        Me.Remember_ME.Size = New System.Drawing.Size(122, 21)
        Me.Remember_ME.TabIndex = 8
        Me.Remember_ME.Text = "Remember Me"
        Me.Remember_ME.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(-2, 629)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(553, 66)
        Me.Panel3.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(272, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Create Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(161, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Not a Member?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(347, 578)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ForgotPassword?"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LoginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(548, 694)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Remember_ME)
        Me.Controls.Add(Me.SignIn_bttm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginFrm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Elipse_loginfrm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Password_txt As TextBox
    Friend WithEvents Username_txt As TextBox
    Friend WithEvents SignIn_bttm As Button
    Friend WithEvents Elipse_SignIn As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Elipse_Username As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Elipse_Password As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Remember_ME As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
