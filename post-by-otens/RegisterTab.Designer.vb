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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterTab))
        Me.windowShape = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.register_pnl = New System.Windows.Forms.Panel()
        Me.shoppingCard_pnl = New System.Windows.Forms.Panel()
        Me.BunifuTileButton4 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.shoppingCart_flow = New System.Windows.Forms.FlowLayoutPanel()
        Me.product_pnl = New System.Windows.Forms.Panel()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.rightSidebar_pnl = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BunifuTileButton3 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton2 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.register_pnl.SuspendLayout()
        Me.shoppingCard_pnl.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.product_pnl.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.totals.SuspendLayout()
        Me.card.SuspendLayout()
        Me.rightSidebar_pnl.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.register_pnl.Size = New System.Drawing.Size(1232, 665)
        Me.register_pnl.TabIndex = 2
        '
        'shoppingCard_pnl
        '
        Me.shoppingCard_pnl.Controls.Add(Me.BunifuTileButton4)
        Me.shoppingCard_pnl.Controls.Add(Me.BunifuCards1)
        Me.shoppingCard_pnl.Location = New System.Drawing.Point(976, 0)
        Me.shoppingCard_pnl.Name = "shoppingCard_pnl"
        Me.shoppingCard_pnl.Size = New System.Drawing.Size(256, 665)
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
        Me.BunifuCards1.Size = New System.Drawing.Size(256, 543)
        Me.BunifuCards1.TabIndex = 0
        '
        'shoppingCart_flow
        '
        Me.shoppingCart_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.shoppingCart_flow.Location = New System.Drawing.Point(9, 52)
        Me.shoppingCart_flow.Name = "shoppingCart_flow"
        Me.shoppingCart_flow.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.shoppingCart_flow.Size = New System.Drawing.Size(244, 429)
        Me.shoppingCart_flow.TabIndex = 1
        '
        'product_pnl
        '
        Me.product_pnl.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.product_pnl.Controls.Add(Me.PictureBox4)
        Me.product_pnl.Controls.Add(Me.FlowLayoutPanel1)
        Me.product_pnl.Controls.Add(Me.totals)
        Me.product_pnl.Location = New System.Drawing.Point(0, 0)
        Me.product_pnl.Name = "product_pnl"
        Me.product_pnl.Size = New System.Drawing.Size(979, 665)
        Me.product_pnl.TabIndex = 0
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(382, -1)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.MaxLength = 32767
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(224, 30)
        Me.BunifuMaterialTextbox1.TabIndex = 4
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 31)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(964, 460)
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
        Me.card.Location = New System.Drawing.Point(12, 3)
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
        Me.amtRecvd.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Label4.Location = New System.Drawing.Point(12, 104)
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
        Me.Label3.Location = New System.Drawing.Point(12, 23)
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
        'rightSidebar_pnl
        '
        Me.rightSidebar_pnl.BackColor = System.Drawing.Color.Transparent
        Me.rightSidebar_pnl.BackgroundImage = CType(resources.GetObject("rightSidebar_pnl.BackgroundImage"), System.Drawing.Image)
        Me.rightSidebar_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rightSidebar_pnl.Controls.Add(Me.PictureBox3)
        Me.rightSidebar_pnl.Controls.Add(Me.BunifuTileButton3)
        Me.rightSidebar_pnl.Controls.Add(Me.BunifuTileButton2)
        Me.rightSidebar_pnl.Controls.Add(Me.BunifuTileButton1)
        Me.rightSidebar_pnl.GradientBottomLeft = System.Drawing.Color.White
        Me.rightSidebar_pnl.GradientBottomRight = System.Drawing.Color.White
        Me.rightSidebar_pnl.GradientTopLeft = System.Drawing.Color.White
        Me.rightSidebar_pnl.GradientTopRight = System.Drawing.Color.White
        Me.rightSidebar_pnl.Location = New System.Drawing.Point(1250, 53)
        Me.rightSidebar_pnl.Name = "rightSidebar_pnl"
        Me.rightSidebar_pnl.Quality = 10
        Me.rightSidebar_pnl.Size = New System.Drawing.Size(263, 665)
        Me.rightSidebar_pnl.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.post_by_otens.My.Resources.Resources.pos21
        Me.PictureBox3.Location = New System.Drawing.Point(0, 490)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(263, 175)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'BunifuTileButton3
        '
        Me.BunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton3.color = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton3.Font = New System.Drawing.Font("Roboto Th", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTileButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton3.Image = Global.post_by_otens.My.Resources.Resources.icons8_depot_64px_1
        Me.BunifuTileButton3.ImagePosition = 65
        Me.BunifuTileButton3.ImageZoom = 10
        Me.BunifuTileButton3.LabelPosition = 41
        Me.BunifuTileButton3.LabelText = "MANAGE STOCKS"
        Me.BunifuTileButton3.Location = New System.Drawing.Point(0, 327)
        Me.BunifuTileButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuTileButton3.Name = "BunifuTileButton3"
        Me.BunifuTileButton3.Size = New System.Drawing.Size(263, 164)
        Me.BunifuTileButton3.TabIndex = 2
        '
        'BunifuTileButton2
        '
        Me.BunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton2.color = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton2.Font = New System.Drawing.Font("Roboto Th", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTileButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton2.Image = Global.post_by_otens.My.Resources.Resources.icons8_report_file_32px
        Me.BunifuTileButton2.ImagePosition = 70
        Me.BunifuTileButton2.ImageZoom = 10
        Me.BunifuTileButton2.LabelPosition = 41
        Me.BunifuTileButton2.LabelText = "SALES REPORT"
        Me.BunifuTileButton2.Location = New System.Drawing.Point(0, 163)
        Me.BunifuTileButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuTileButton2.Name = "BunifuTileButton2"
        Me.BunifuTileButton2.Size = New System.Drawing.Size(263, 164)
        Me.BunifuTileButton2.TabIndex = 2
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton1.color = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Roboto Th", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Global.post_by_otens.My.Resources.Resources.icons8_cash_register_32px
        Me.BunifuTileButton1.ImagePosition = 70
        Me.BunifuTileButton1.ImageZoom = 10
        Me.BunifuTileButton1.LabelPosition = 41
        Me.BunifuTileButton1.LabelText = "REGISTER"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(0, -1)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(263, 164)
        Me.BunifuTileButton1.TabIndex = 2
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Lt", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(75, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Shopping Cart"
        '
        'RegisterTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1513, 718)
        Me.Controls.Add(Me.register_pnl)
        Me.Controls.Add(Me.rightSidebar_pnl)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
        Me.rightSidebar_pnl.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowShape As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents rightSidebar_pnl As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton3 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton2 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents PictureBox3 As PictureBox
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
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents shoppingCart_flow As FlowLayoutPanel
    Friend WithEvents Label7 As Label
End Class
