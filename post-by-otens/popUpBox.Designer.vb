<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popUpBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popUpBox))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuTileButton2 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 5.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CUSTOMER TYPE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.post_by_otens.My.Resources.Resources.icons8_filled_circle_16
        Me.PictureBox1.Location = New System.Drawing.Point(292, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BunifuTileButton2
        '
        Me.BunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton2.color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton2.Font = New System.Drawing.Font("Roboto Th", 13.2!, System.Drawing.FontStyle.Italic)
        Me.BunifuTileButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton2.Image = CType(resources.GetObject("BunifuTileButton2.Image"), System.Drawing.Image)
        Me.BunifuTileButton2.ImagePosition = 17
        Me.BunifuTileButton2.ImageZoom = 50
        Me.BunifuTileButton2.LabelPosition = 35
        Me.BunifuTileButton2.LabelText = "Existing"
        Me.BunifuTileButton2.Location = New System.Drawing.Point(148, 22)
        Me.BunifuTileButton2.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BunifuTileButton2.Name = "BunifuTileButton2"
        Me.BunifuTileButton2.Size = New System.Drawing.Size(163, 43)
        Me.BunifuTileButton2.TabIndex = 0
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton1.color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Roboto Th", 13.2!, System.Drawing.FontStyle.Italic)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = CType(resources.GetObject("BunifuTileButton1.Image"), System.Drawing.Image)
        Me.BunifuTileButton1.ImagePosition = 17
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 35
        Me.BunifuTileButton1.LabelText = "New"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(0, 22)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(148, 43)
        Me.BunifuTileButton1.TabIndex = 0
        '
        'popUpBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 79)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuTileButton2)
        Me.Controls.Add(Me.BunifuTileButton1)
        Me.Font = New System.Drawing.Font("Roboto Cn", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "popUpBox"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton2 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
