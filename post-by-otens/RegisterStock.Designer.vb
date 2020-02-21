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
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Clear_Panel.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Add_Panel.SuspendLayout()
        CType(Me.AddStock_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductName_Panel.SuspendLayout()
        Me.Quantity_Panel.SuspendLayout()
        Me.Price_Panel.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
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
        Me.Clear_Panel.Location = New System.Drawing.Point(777, 107)
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
        Me.Add_Panel.Location = New System.Drawing.Point(777, 12)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(-7, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(763, 10)
        Me.Panel3.TabIndex = 2
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
        Me.ProductName_Panel.Location = New System.Drawing.Point(25, 42)
        Me.ProductName_Panel.Name = "ProductName_Panel"
        Me.ProductName_Panel.Size = New System.Drawing.Size(352, 45)
        Me.ProductName_Panel.TabIndex = 5
        '
        'ProductName_txt
        '
        Me.ProductName_txt.BackColor = System.Drawing.Color.Gainsboro
        Me.ProductName_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductName_txt.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName_txt.Location = New System.Drawing.Point(16, 9)
        Me.ProductName_txt.Name = "ProductName_txt"
        Me.ProductName_txt.Size = New System.Drawing.Size(316, 27)
        Me.ProductName_txt.TabIndex = 0
        Me.ProductName_txt.Text = "Product Name"
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
        Me.Quantity_Panel.Location = New System.Drawing.Point(423, 42)
        Me.Quantity_Panel.Name = "Quantity_Panel"
        Me.Quantity_Panel.Size = New System.Drawing.Size(108, 45)
        Me.Quantity_Panel.TabIndex = 5
        '
        'Qty_txt
        '
        Me.Qty_txt.BackColor = System.Drawing.Color.Gainsboro
        Me.Qty_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Qty_txt.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qty_txt.Location = New System.Drawing.Point(18, 9)
        Me.Qty_txt.MaxLength = 3
        Me.Qty_txt.Name = "Qty_txt"
        Me.Qty_txt.Size = New System.Drawing.Size(67, 27)
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
        Me.Price_Panel.Location = New System.Drawing.Point(537, 42)
        Me.Price_Panel.Name = "Price_Panel"
        Me.Price_Panel.Size = New System.Drawing.Size(108, 45)
        Me.Price_Panel.TabIndex = 5
        '
        'Price_txt
        '
        Me.Price_txt.BackColor = System.Drawing.Color.Gainsboro
        Me.Price_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Price_txt.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price_txt.Location = New System.Drawing.Point(22, 9)
        Me.Price_txt.Name = "Price_txt"
        Me.Price_txt.Size = New System.Drawing.Size(67, 27)
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
        Me.BunifuGradientPanel1.Controls.Add(Me.Quantity_Panel)
        Me.BunifuGradientPanel1.Controls.Add(Me.Price_Panel)
        Me.BunifuGradientPanel1.Controls.Add(Me.ProductName_Panel)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-3, 85)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(757, 138)
        Me.BunifuGradientPanel1.TabIndex = 4
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add Stock"
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me
        Me.BunifuDragControl2.Vertical = True
        '
        'RegisterStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(941, 216)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Clear_Panel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Add_Panel As Panel
    Friend WithEvents Price_Panel As Panel
    Friend WithEvents Quantity_Panel As Panel
    Friend WithEvents ProductName_Panel As Panel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ProductName_txt As TextBox
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Qty_txt As TextBox
    Friend WithEvents Price_txt As TextBox
    Friend WithEvents AddStock_bttn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
End Class
