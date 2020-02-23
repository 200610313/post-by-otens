<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterStock))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Clear_Panel = New System.Windows.Forms.Panel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Add_Panel = New System.Windows.Forms.Panel()
        Me.AddStock_bttn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ProductName_Panel = New System.Windows.Forms.Panel()
        Me.ProductName_txt = New System.Windows.Forms.TextBox()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Quantity_Panel = New System.Windows.Forms.Panel()
        Me.Qty_txt = New System.Windows.Forms.TextBox()
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Price_Panel = New System.Windows.Forms.Panel()
        Me.Price_txt = New System.Windows.Forms.TextBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.pImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imgurl = New System.Windows.Forms.TextBox()
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Exit_bttn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse7 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Clear_Panel.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Add_Panel.SuspendLayout()
        CType(Me.AddStock_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductName_Panel.SuspendLayout()
        Me.Quantity_Panel.SuspendLayout()
        Me.Price_Panel.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.pImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Exit_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'Clear_Panel
        '
        Me.Clear_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Clear_Panel.Controls.Add(Me.BunifuImageButton3)
        Me.Clear_Panel.Location = New System.Drawing.Point(773, 119)
        Me.Clear_Panel.Name = "Clear_Panel"
        Me.Clear_Panel.Size = New System.Drawing.Size(138, 80)
        Me.Clear_Panel.TabIndex = 1
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.Image = Global.post_by_otens.My.Resources.Resources.icons8_delete_301
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(44, 13)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(55, 52)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 0
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'Add_Panel
        '
        Me.Add_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Add_Panel.Controls.Add(Me.AddStock_bttn)
        Me.Add_Panel.Location = New System.Drawing.Point(773, 24)
        Me.Add_Panel.Name = "Add_Panel"
        Me.Add_Panel.Size = New System.Drawing.Size(138, 80)
        Me.Add_Panel.TabIndex = 1
        '
        'AddStock_bttn
        '
        Me.AddStock_bttn.Image = Global.post_by_otens.My.Resources.Resources.icons8_add_property_80
        Me.AddStock_bttn.ImageActive = Nothing
        Me.AddStock_bttn.Location = New System.Drawing.Point(44, 12)
        Me.AddStock_bttn.Name = "AddStock_bttn"
        Me.AddStock_bttn.Size = New System.Drawing.Size(55, 52)
        Me.AddStock_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddStock_bttn.TabIndex = 0
        Me.AddStock_bttn.TabStop = False
        Me.AddStock_bttn.Zoom = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(746, -6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 229)
        Me.Panel4.TabIndex = 3
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.ProductName_Panel
        '
        'ProductName_Panel
        '
        Me.ProductName_Panel.BackColor = System.Drawing.Color.Gainsboro
        Me.ProductName_Panel.Controls.Add(Me.ProductName_txt)
        Me.ProductName_Panel.Location = New System.Drawing.Point(340, 46)
        Me.ProductName_Panel.Name = "ProductName_Panel"
        Me.ProductName_Panel.Size = New System.Drawing.Size(352, 45)
        Me.ProductName_Panel.TabIndex = 5
        '
        'ProductName_txt
        '
        Me.ProductName_txt.BackColor = System.Drawing.Color.Gainsboro
        Me.ProductName_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductName_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName_txt.ForeColor = System.Drawing.Color.Silver
        Me.ProductName_txt.Location = New System.Drawing.Point(16, 9)
        Me.ProductName_txt.Name = "ProductName_txt"
        Me.ProductName_txt.Size = New System.Drawing.Size(316, 23)
        Me.ProductName_txt.TabIndex = 0
        Me.ProductName_txt.Text = "Product Name"
        Me.ProductName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 20
        Me.BunifuElipse3.TargetControl = Me.Quantity_Panel
        '
        'Quantity_Panel
        '
        Me.Quantity_Panel.BackColor = System.Drawing.Color.Gainsboro
        Me.Quantity_Panel.Controls.Add(Me.Qty_txt)
        Me.Quantity_Panel.Location = New System.Drawing.Point(341, 98)
        Me.Quantity_Panel.Name = "Quantity_Panel"
        Me.Quantity_Panel.Size = New System.Drawing.Size(167, 45)
        Me.Quantity_Panel.TabIndex = 5
        '
        'Qty_txt
        '
        Me.Qty_txt.BackColor = System.Drawing.Color.Gainsboro
        Me.Qty_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Qty_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_txt.ForeColor = System.Drawing.Color.Silver
        Me.Qty_txt.Location = New System.Drawing.Point(18, 9)
        Me.Qty_txt.MaxLength = 3
        Me.Qty_txt.Name = "Qty_txt"
        Me.Qty_txt.Size = New System.Drawing.Size(126, 23)
        Me.Qty_txt.TabIndex = 0
        Me.Qty_txt.Text = "Qty."
        Me.Qty_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 20
        Me.BunifuElipse4.TargetControl = Me.Price_Panel
        '
        'Price_Panel
        '
        Me.Price_Panel.BackColor = System.Drawing.Color.Gainsboro
        Me.Price_Panel.Controls.Add(Me.Price_txt)
        Me.Price_Panel.Location = New System.Drawing.Point(514, 97)
        Me.Price_Panel.Name = "Price_Panel"
        Me.Price_Panel.Size = New System.Drawing.Size(178, 45)
        Me.Price_Panel.TabIndex = 5
        '
        'Price_txt
        '
        Me.Price_txt.BackColor = System.Drawing.Color.Gainsboro
        Me.Price_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Price_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price_txt.ForeColor = System.Drawing.Color.Silver
        Me.Price_txt.Location = New System.Drawing.Point(22, 9)
        Me.Price_txt.Name = "Price_txt"
        Me.Price_txt.Size = New System.Drawing.Size(137, 23)
        Me.Price_txt.TabIndex = 0
        Me.Price_txt.Text = "Price."
        Me.Price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.BunifuGradientPanel1
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.pImage)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Quantity_Panel)
        Me.BunifuGradientPanel1.Controls.Add(Me.Price_Panel)
        Me.BunifuGradientPanel1.Controls.Add(Me.ProductName_Panel)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-3, -3)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(757, 226)
        Me.BunifuGradientPanel1.TabIndex = 4
        '
        'pImage
        '
        Me.pImage.BackColor = System.Drawing.Color.White
        Me.pImage.Image = Global.post_by_otens.My.Resources.Resources.invalid
        Me.pImage.Location = New System.Drawing.Point(47, 3)
        Me.pImage.Name = "pImage"
        Me.pImage.Size = New System.Drawing.Size(237, 220)
        Me.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pImage.TabIndex = 6
        Me.pImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.imgurl)
        Me.Panel1.Location = New System.Drawing.Point(340, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 31)
        Me.Panel1.TabIndex = 5
        '
        'imgurl
        '
        Me.imgurl.BackColor = System.Drawing.Color.Gainsboro
        Me.imgurl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.imgurl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.imgurl.ForeColor = System.Drawing.Color.Silver
        Me.imgurl.Location = New System.Drawing.Point(3, 8)
        Me.imgurl.Name = "imgurl"
        Me.imgurl.Size = New System.Drawing.Size(346, 16)
        Me.imgurl.TabIndex = 0
        Me.imgurl.Text = "Image URL"
        Me.imgurl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 20
        Me.BunifuElipse5.TargetControl = Me.Add_Panel
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 20
        Me.BunifuElipse6.TargetControl = Me.Clear_Panel
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me
        Me.BunifuDragControl2.Vertical = True
        '
        'Exit_bttn
        '
        Me.Exit_bttn.BackColor = System.Drawing.Color.Transparent
        Me.Exit_bttn.Image = CType(resources.GetObject("Exit_bttn.Image"), System.Drawing.Image)
        Me.Exit_bttn.ImageActive = Nothing
        Me.Exit_bttn.Location = New System.Drawing.Point(917, 4)
        Me.Exit_bttn.Name = "Exit_bttn"
        Me.Exit_bttn.Size = New System.Drawing.Size(20, 20)
        Me.Exit_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Exit_bttn.TabIndex = 5
        Me.Exit_bttn.TabStop = False
        Me.Exit_bttn.Zoom = 10
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 20
        Me.BunifuElipse7.TargetControl = Me.pImage
        '
        'RegisterStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 216)
        Me.Controls.Add(Me.Exit_bttn)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Add_Panel)
        Me.Controls.Add(Me.Clear_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "RegisterStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterStock"
        Me.Clear_Panel.ResumeLayout(False)
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Add_Panel.ResumeLayout(False)
        CType(Me.AddStock_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductName_Panel.ResumeLayout(False)
        Me.ProductName_Panel.PerformLayout()
        Me.Quantity_Panel.ResumeLayout(False)
        Me.Quantity_Panel.PerformLayout()
        Me.Price_Panel.ResumeLayout(False)
        Me.Price_Panel.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.pImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Exit_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Clear_Panel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Add_Panel As Panel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents AddStock_bttn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents pImage As PictureBox
    Friend WithEvents Quantity_Panel As Panel
    Friend WithEvents Qty_txt As TextBox
    Friend WithEvents Price_Panel As Panel
    Friend WithEvents Price_txt As TextBox
    Friend WithEvents ProductName_Panel As Panel
    Friend WithEvents ProductName_txt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents imgurl As TextBox
    Friend WithEvents Exit_bttn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse7 As Bunifu.Framework.UI.BunifuElipse
End Class
