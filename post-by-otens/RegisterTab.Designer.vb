<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterTab
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
        Me.windowShape = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.register_pnl = New System.Windows.Forms.Panel()
        Me.shoppingCard_pnl = New System.Windows.Forms.Panel()
        Me.BunifuTileButton4 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.shoppingCart_flow = New System.Windows.Forms.FlowLayoutPanel()
        Me.product_pnl = New System.Windows.Forms.Panel()
        Me.searchBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.totals = New System.Windows.Forms.Panel()
        Me.card = New Bunifu.Framework.UI.BunifuCards()
        Me.amtRecvd = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.changeAmt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalAmt = New System.Windows.Forms.Label()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.register_pnl.SuspendLayout()
        Me.shoppingCard_pnl.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.product_pnl.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.totals.SuspendLayout()
        Me.card.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'windowShape
        '
        Me.windowShape.ElipseRadius = 20
        Me.windowShape.TargetControl = Me
        '
        'register_pnl
        '
        Me.register_pnl.BackColor = System.Drawing.SystemColors.Control
        Me.register_pnl.Controls.Add(Me.shoppingCard_pnl)
        Me.register_pnl.Controls.Add(Me.product_pnl)
        Me.register_pnl.Location = New System.Drawing.Point(0, 53)
        Me.register_pnl.Name = "register_pnl"
        Me.register_pnl.Size = New System.Drawing.Size(1512, 665)
        Me.register_pnl.TabIndex = 2
        '
        'shoppingCard_pnl
        '
        Me.shoppingCard_pnl.Controls.Add(Me.BunifuTileButton4)
        Me.shoppingCard_pnl.Controls.Add(Me.BunifuCards1)
        Me.shoppingCard_pnl.Location = New System.Drawing.Point(976, 0)
        Me.shoppingCard_pnl.Name = "shoppingCard_pnl"
        Me.shoppingCard_pnl.Size = New System.Drawing.Size(536, 665)
        Me.shoppingCard_pnl.TabIndex = 1
        '
        'BunifuTileButton4
        '
        Me.BunifuTileButton4.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton4.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton4.Font = New System.Drawing.Font("Roboto Lt", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTileButton4.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton4.Image = Nothing
        Me.BunifuTileButton4.ImagePosition = 21
        Me.BunifuTileButton4.ImageZoom = 50
        Me.BunifuTileButton4.LabelPosition = 100
        Me.BunifuTileButton4.LabelText = "CONFIRM"
        Me.BunifuTileButton4.Location = New System.Drawing.Point(0, 490)
        Me.BunifuTileButton4.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton4.Name = "BunifuTileButton4"
        Me.BunifuTileButton4.Size = New System.Drawing.Size(256, 175)
        Me.BunifuTileButton4.TabIndex = 1
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.shoppingCart_flow)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(536, 491)
        Me.BunifuCards1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Lt", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(222, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Shopping Cart"
        '
        'shoppingCart_flow
        '
        Me.shoppingCart_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.shoppingCart_flow.Location = New System.Drawing.Point(9, 52)
        Me.shoppingCart_flow.Name = "shoppingCart_flow"
        Me.shoppingCart_flow.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.shoppingCart_flow.Size = New System.Drawing.Size(516, 429)
        Me.shoppingCart_flow.TabIndex = 1
        '
        'product_pnl
        '
        Me.product_pnl.Controls.Add(Me.searchBox)
        Me.product_pnl.Controls.Add(Me.PictureBox4)
        Me.product_pnl.Controls.Add(Me.FlowLayoutPanel1)
        Me.product_pnl.Controls.Add(Me.totals)
        Me.product_pnl.Location = New System.Drawing.Point(0, 0)
        Me.product_pnl.Name = "product_pnl"
        Me.product_pnl.Size = New System.Drawing.Size(979, 665)
        Me.product_pnl.TabIndex = 0
        '
        'searchBox
        '
        Me.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.searchBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.searchBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.searchBox.HintForeColor = System.Drawing.Color.Empty
        Me.searchBox.HintText = ""
        Me.searchBox.isPassword = False
        Me.searchBox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBox.LineIdleColor = System.Drawing.Color.Gray
        Me.searchBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchBox.LineThickness = 3
        Me.searchBox.Location = New System.Drawing.Point(382, -1)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.searchBox.MaxLength = 32767
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(224, 30)
        Me.searchBox.TabIndex = 4
        Me.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.post_by_otens.My.Resources.Resources.icons8_search_50px
        Me.PictureBox4.Location = New System.Drawing.Point(343, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(11, 31)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(965, 460)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'totals
        '
        Me.totals.Controls.Add(Me.card)
        Me.totals.Location = New System.Drawing.Point(0, 490)
        Me.totals.Name = "totals"
        Me.totals.Size = New System.Drawing.Size(976, 175)
        Me.totals.TabIndex = 0
        '
        'card
        '
        Me.card.BackColor = System.Drawing.Color.White
        Me.card.BorderRadius = 5
        Me.card.BottomSahddow = True
        Me.card.color = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.card.Controls.Add(Me.amtRecvd)
        Me.card.Controls.Add(Me.Label4)
        Me.card.Controls.Add(Me.Label3)
        Me.card.Controls.Add(Me.Label1)
        Me.card.Controls.Add(Me.Label2)
        Me.card.Controls.Add(Me.Label6)
        Me.card.Controls.Add(Me.changeAmt)
        Me.card.Controls.Add(Me.Label5)
        Me.card.Controls.Add(Me.totalAmt)
        Me.card.LeftSahddow = False
        Me.card.Location = New System.Drawing.Point(11, 3)
        Me.card.Name = "card"
        Me.card.RightSahddow = True
        Me.card.ShadowDepth = 20
        Me.card.Size = New System.Drawing.Size(955, 172)
        Me.card.TabIndex = 1
        '
        'amtRecvd
        '
        Me.amtRecvd.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amtRecvd.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.amtRecvd.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amtRecvd.BorderThickness = 3
        Me.amtRecvd.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.amtRecvd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.amtRecvd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.amtRecvd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.amtRecvd.isPassword = False
        Me.amtRecvd.Location = New System.Drawing.Point(112, 54)
        Me.amtRecvd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.amtRecvd.MaxLength = 32767
        Me.amtRecvd.Name = "amtRecvd"
        Me.amtRecvd.Size = New System.Drawing.Size(370, 44)
        Me.amtRecvd.TabIndex = 2
        Me.amtRecvd.Text = "0"
        Me.amtRecvd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Th", 13.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CHANGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Th", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "AMOUNT RECEIVED"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Th", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(583, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Lt", 28.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PHP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Lt", 15.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 30)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "PHP"
        '
        'changeAmt
        '
        Me.changeAmt.AutoSize = True
        Me.changeAmt.Font = New System.Drawing.Font("Roboto Lt", 15.0!)
        Me.changeAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.changeAmt.Location = New System.Drawing.Point(65, 131)
        Me.changeAmt.Name = "changeAmt"
        Me.changeAmt.Size = New System.Drawing.Size(27, 30)
        Me.changeAmt.TabIndex = 1
        Me.changeAmt.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Lt", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(578, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 61)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PHP"
        '
        'totalAmt
        '
        Me.totalAmt.AutoSize = True
        Me.totalAmt.Font = New System.Drawing.Font("Roboto Lt", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalAmt.Location = New System.Drawing.Point(690, 70)
        Me.totalAmt.Name = "totalAmt"
        Me.totalAmt.Size = New System.Drawing.Size(55, 61)
        Me.totalAmt.TabIndex = 1
        Me.totalAmt.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.post_by_otens.My.Resources.Resources.icons8_filled_circle_30px_3
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(1447, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.post_by_otens.My.Resources.Resources.icons8_filled_circle_30px_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1477, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RegisterTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1513, 719)
        Me.Controls.Add(Me.register_pnl)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1513, 719)
        Me.Name = "RegisterTab"
        Me.Text = "Form1"
        Me.register_pnl.ResumeLayout(False)
        Me.shoppingCard_pnl.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.product_pnl.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.totals.ResumeLayout(False)
        Me.card.ResumeLayout(False)
        Me.card.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowShape As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents register_pnl As Panel
    Friend WithEvents product_pnl As Panel
    Friend WithEvents shoppingCard_pnl As Panel
    Friend WithEvents totals As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuTileButton4 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents card As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents totalAmt As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents amtRecvd As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents changeAmt As Label
    Friend WithEvents searchBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents shoppingCart_flow As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TableBindingSource As BindingSource

End Class
