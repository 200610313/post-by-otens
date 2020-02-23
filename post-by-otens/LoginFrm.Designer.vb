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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Username_txt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Password_txt = New System.Windows.Forms.TextBox()
        Me.SignIn_bttm = New System.Windows.Forms.Button()
        Me.Elipse_SignIn = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Elipse_Username = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Elipse_Password = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.asManager = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bName = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.post_by_otens.My.Resources.Resources.Pewter_Engineers
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-25, -64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(607, 437)
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
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(206, 313)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(144, 44)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "Sign In"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Username_txt)
        Me.Panel1.Location = New System.Drawing.Point(92, 435)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 47)
        Me.Panel1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(325, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 7)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "USERNAME"
        '
        'Username_txt
        '
        Me.Username_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Username_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_txt.Location = New System.Drawing.Point(15, 9)
        Me.Username_txt.Name = "Username_txt"
        Me.Username_txt.Size = New System.Drawing.Size(340, 20)
        Me.Username_txt.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Password_txt)
        Me.Panel2.Location = New System.Drawing.Point(92, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 47)
        Me.Panel2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(324, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 7)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "PASSWORD"
        '
        'Password_txt
        '
        Me.Password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Password_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txt.Location = New System.Drawing.Point(16, 8)
        Me.Password_txt.Name = "Password_txt"
        Me.Password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
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
        Me.SignIn_bttm.Location = New System.Drawing.Point(92, 548)
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
        'asManager
        '
        Me.asManager.AutoSize = True
        Me.asManager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.asManager.Location = New System.Drawing.Point(92, 601)
        Me.asManager.Name = "asManager"
        Me.asManager.Size = New System.Drawing.Size(153, 21)
        Me.asManager.TabIndex = 8
        Me.asManager.Text = "Sign In As Manager"
        Me.asManager.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Location = New System.Drawing.Point(-2, 629)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(553, 66)
        Me.Panel3.TabIndex = 9
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.bName)
        Me.Panel4.Location = New System.Drawing.Point(92, 379)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(373, 47)
        Me.Panel4.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(309, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 7)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BUSINESS NAME"
        '
        'bName
        '
        Me.bName.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.bName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bName.Location = New System.Drawing.Point(15, 8)
        Me.bName.Name = "bName"
        Me.bName.Size = New System.Drawing.Size(340, 20)
        Me.bName.TabIndex = 6
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'LoginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(548, 694)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.asManager)
        Me.Controls.Add(Me.SignIn_bttm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents asManager As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel4 As Panel
    Friend WithEvents bName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
