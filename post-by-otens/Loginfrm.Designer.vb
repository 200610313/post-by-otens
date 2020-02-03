<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginfrm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AlphaBlendTextBox2 = New ZBobb.AlphaBlendTextBox()
        Me.AlphaBlendTextBox1 = New ZBobb.AlphaBlendTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me.AlphaBlendTextBox1
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 30
        Me.BunifuElipse2.TargetControl = Me.AlphaBlendTextBox2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.post_by_otens.My.Resources.Resources.Pewter_Engineers
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(715, 642)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.AlphaBlendTextBox2)
        Me.BunifuGradientPanel1.Controls.Add(Me.AlphaBlendTextBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.WhiteSmoke
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(705, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(373, 674)
        Me.BunifuGradientPanel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.post_by_otens.My.Resources.Resources.icons8_user_301
        Me.PictureBox2.Location = New System.Drawing.Point(35, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'AlphaBlendTextBox2
        '
        Me.AlphaBlendTextBox2.BackAlpha = 25
        Me.AlphaBlendTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlphaBlendTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlphaBlendTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlphaBlendTextBox2.Location = New System.Drawing.Point(94, 165)
        Me.AlphaBlendTextBox2.Multiline = True
        Me.AlphaBlendTextBox2.Name = "AlphaBlendTextBox2"
        Me.AlphaBlendTextBox2.Size = New System.Drawing.Size(229, 37)
        Me.AlphaBlendTextBox2.TabIndex = 1
        Me.AlphaBlendTextBox2.Text = "Password"
        '
        'AlphaBlendTextBox1
        '
        Me.AlphaBlendTextBox1.BackAlpha = 25
        Me.AlphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlphaBlendTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlphaBlendTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlphaBlendTextBox1.Location = New System.Drawing.Point(94, 102)
        Me.AlphaBlendTextBox1.Multiline = True
        Me.AlphaBlendTextBox1.Name = "AlphaBlendTextBox1"
        Me.AlphaBlendTextBox1.Size = New System.Drawing.Size(229, 37)
        Me.AlphaBlendTextBox1.TabIndex = 1
        Me.AlphaBlendTextBox1.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(145, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'Loginfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 641)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loginfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loginfrm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents AlphaBlendTextBox2 As ZBobb.AlphaBlendTextBox
    Friend WithEvents AlphaBlendTextBox1 As ZBobb.AlphaBlendTextBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox2 As PictureBox
End Class
