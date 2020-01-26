<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pName = New System.Windows.Forms.Label()
        Me.pStock = New System.Windows.Forms.Label()
        Me.pPrice = New System.Windows.Forms.Label()
        Me.pNum = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.remove_btn = New System.Windows.Forms.PictureBox()
        Me.decrement_btn = New System.Windows.Forms.PictureBox()
        Me.add_btn = New System.Windows.Forms.PictureBox()
        Me.pImage = New System.Windows.Forms.PictureBox()
        CType(Me.remove_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decrement_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.add_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'pName
        '
        Me.pName.AutoSize = True
        Me.pName.Font = New System.Drawing.Font("Roboto Lt", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pName.ForeColor = System.Drawing.Color.White
        Me.pName.Location = New System.Drawing.Point(206, 71)
        Me.pName.Name = "pName"
        Me.pName.Size = New System.Drawing.Size(117, 39)
        Me.pName.TabIndex = 2
        Me.pName.Text = "Burger"
        '
        'pStock
        '
        Me.pStock.AutoSize = True
        Me.pStock.Font = New System.Drawing.Font("Roboto Lt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pStock.Location = New System.Drawing.Point(209, 111)
        Me.pStock.Name = "pStock"
        Me.pStock.Size = New System.Drawing.Size(66, 24)
        Me.pStock.TabIndex = 2
        Me.pStock.Text = "10 left"
        '
        'pPrice
        '
        Me.pPrice.AutoSize = True
        Me.pPrice.Font = New System.Drawing.Font("Roboto Lt", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pPrice.Location = New System.Drawing.Point(206, 34)
        Me.pPrice.Name = "pPrice"
        Me.pPrice.Size = New System.Drawing.Size(194, 39)
        Me.pPrice.TabIndex = 2
        Me.pPrice.Text = "PHP 100.00"
        '
        'pNum
        '
        Me.pNum.AutoSize = True
        Me.pNum.Font = New System.Drawing.Font("Roboto Lt", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pNum.ForeColor = System.Drawing.Color.White
        Me.pNum.Location = New System.Drawing.Point(-1, 1)
        Me.pNum.Name = "pNum"
        Me.pNum.Size = New System.Drawing.Size(77, 24)
        Me.pNum.TabIndex = 2
        Me.pNum.Text = "#12315"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me
        '
        'remove_btn
        '
        Me.remove_btn.BackgroundImage = Global.post_by_otens.My.Resources.Resources.icons8_cancel_48px1
        Me.remove_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.remove_btn.Location = New System.Drawing.Point(401, 111)
        Me.remove_btn.Name = "remove_btn"
        Me.remove_btn.Size = New System.Drawing.Size(58, 38)
        Me.remove_btn.TabIndex = 3
        Me.remove_btn.TabStop = False
        '
        'decrement_btn
        '
        Me.decrement_btn.BackgroundImage = Global.post_by_otens.My.Resources.Resources.newminus
        Me.decrement_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.decrement_btn.Location = New System.Drawing.Point(406, 68)
        Me.decrement_btn.Name = "decrement_btn"
        Me.decrement_btn.Size = New System.Drawing.Size(47, 30)
        Me.decrement_btn.TabIndex = 3
        Me.decrement_btn.TabStop = False
        '
        'add_btn
        '
        Me.add_btn.BackgroundImage = Global.post_by_otens.My.Resources.Resources.add_48px
        Me.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.add_btn.Location = New System.Drawing.Point(406, 17)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(47, 39)
        Me.add_btn.TabIndex = 3
        Me.add_btn.TabStop = False
        '
        'pImage
        '
        Me.pImage.BackColor = System.Drawing.Color.White
        Me.pImage.Image = Global.post_by_otens.My.Resources.Resources.burger
        Me.pImage.Location = New System.Drawing.Point(0, 0)
        Me.pImage.Name = "pImage"
        Me.pImage.Size = New System.Drawing.Size(185, 166)
        Me.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pImage.TabIndex = 1
        Me.pImage.TabStop = False
        '
        'product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Controls.Add(Me.remove_btn)
        Me.Controls.Add(Me.decrement_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.pNum)
        Me.Controls.Add(Me.pStock)
        Me.Controls.Add(Me.pPrice)
        Me.Controls.Add(Me.pName)
        Me.Controls.Add(Me.pImage)
        Me.Name = "product"
        Me.Size = New System.Drawing.Size(464, 166)
        CType(Me.remove_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decrement_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.add_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pImage As PictureBox
    Friend WithEvents pName As Label
    Friend WithEvents pStock As Label
    Friend WithEvents pPrice As Label
    Friend WithEvents pNum As Label
    Friend WithEvents add_btn As PictureBox
    Friend WithEvents decrement_btn As PictureBox
    Friend WithEvents remove_btn As PictureBox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
End Class
