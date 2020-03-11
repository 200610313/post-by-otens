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
        Me.void = New Bunifu.Framework.UI.BunifuTileButton()
        Me.confirmWreceipt = New Bunifu.Framework.UI.BunifuTileButton()
        Me.confirm = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.shoppingCart_flow = New System.Windows.Forms.FlowLayoutPanel()
        Me.product_pnl = New System.Windows.Forms.Panel()
        Me.searchBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.totals = New System.Windows.Forms.Panel()
        Me.card = New Bunifu.Framework.UI.BunifuCards()
        Me.amtRecvd = New System.Windows.Forms.TextBox()
        Me.change = New System.Windows.Forms.Label()
        Me.amountreceived = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.php = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.changeAmt = New System.Windows.Forms.Label()
        Me.phptotal = New System.Windows.Forms.Label()
        Me.totalAmt = New System.Windows.Forms.Label()
        Me.savePath = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.logout_btn = New System.Windows.Forms.PictureBox()
        Me.savePathbtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.register_pnl.SuspendLayout()
        Me.shoppingCard_pnl.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.product_pnl.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.totals.SuspendLayout()
        Me.card.SuspendLayout()
        CType(Me.logout_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.savePathbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.shoppingCard_pnl.Controls.Add(Me.void)
        Me.shoppingCard_pnl.Controls.Add(Me.confirmWreceipt)
        Me.shoppingCard_pnl.Controls.Add(Me.confirm)
        Me.shoppingCard_pnl.Controls.Add(Me.BunifuCards1)
        Me.shoppingCard_pnl.Location = New System.Drawing.Point(976, 0)
        Me.shoppingCard_pnl.Name = "shoppingCard_pnl"
        Me.shoppingCard_pnl.Size = New System.Drawing.Size(536, 665)
        Me.shoppingCard_pnl.TabIndex = 1
        '
        'void
        '
        Me.void.BackColor = System.Drawing.Color.DarkGray
        Me.void.color = System.Drawing.Color.DarkGray
        Me.void.colorActive = System.Drawing.Color.Silver
        Me.void.Cursor = System.Windows.Forms.Cursors.Hand
        Me.void.Font = New System.Drawing.Font("Roboto Condensed Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.void.ForeColor = System.Drawing.Color.White
        Me.void.Image = Nothing
        Me.void.ImagePosition = 17
        Me.void.ImageZoom = 50
        Me.void.LabelPosition = 30
        Me.void.LabelText = "VOID"
        Me.void.Location = New System.Drawing.Point(9, 624)
        Me.void.Margin = New System.Windows.Forms.Padding(6)
        Me.void.Name = "void"
        Me.void.Size = New System.Drawing.Size(516, 48)
        Me.void.TabIndex = 1
        '
        'confirmWreceipt
        '
        Me.confirmWreceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.confirmWreceipt.color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.confirmWreceipt.colorActive = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.confirmWreceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmWreceipt.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmWreceipt.ForeColor = System.Drawing.Color.White
        Me.confirmWreceipt.Image = Global.post_by_otens.My.Resources.Resources.icons8_cash_register_32px2
        Me.confirmWreceipt.ImagePosition = 25
        Me.confirmWreceipt.ImageZoom = 20
        Me.confirmWreceipt.LabelPosition = 120
        Me.confirmWreceipt.LabelText = "Confirm | Invoice"
        Me.confirmWreceipt.Location = New System.Drawing.Point(265, 490)
        Me.confirmWreceipt.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.confirmWreceipt.Name = "confirmWreceipt"
        Me.confirmWreceipt.Size = New System.Drawing.Size(260, 217)
        Me.confirmWreceipt.TabIndex = 1
        '
        'confirm
        '
        Me.confirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.confirm.color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.confirm.colorActive = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirm.Font = New System.Drawing.Font("Roboto Condensed Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm.ForeColor = System.Drawing.Color.White
        Me.confirm.Image = Global.post_by_otens.My.Resources.Resources.norecepticons8_cash_register_32px
        Me.confirm.ImagePosition = 25
        Me.confirm.ImageZoom = 20
        Me.confirm.LabelPosition = 120
        Me.confirm.LabelText = "Confirm"
        Me.confirm.Location = New System.Drawing.Point(9, 490)
        Me.confirm.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(256, 217)
        Me.confirm.TabIndex = 1
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.PictureBox3)
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
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.post_by_otens.My.Resources.Resources.icons8_multiply_32px
        Me.PictureBox3.Location = New System.Drawing.Point(497, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(222, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
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
        Me.searchBox.Location = New System.Drawing.Point(382, 5)
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
        Me.PictureBox4.Location = New System.Drawing.Point(343, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(11, 52)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(965, 439)
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
        Me.card.Controls.Add(Me.change)
        Me.card.Controls.Add(Me.amountreceived)
        Me.card.Controls.Add(Me.total)
        Me.card.Controls.Add(Me.php)
        Me.card.Controls.Add(Me.Label6)
        Me.card.Controls.Add(Me.changeAmt)
        Me.card.Controls.Add(Me.phptotal)
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
        Me.amtRecvd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.amtRecvd.Font = New System.Drawing.Font("Roboto Light", 18.0!)
        Me.amtRecvd.Location = New System.Drawing.Point(121, 56)
        Me.amtRecvd.Name = "amtRecvd"
        Me.amtRecvd.Size = New System.Drawing.Size(163, 37)
        Me.amtRecvd.TabIndex = 3
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Roboto Light", 13.0!)
        Me.change.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.change.Location = New System.Drawing.Point(11, 104)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(100, 27)
        Me.change.TabIndex = 1
        Me.change.Text = "CHANGE"
        '
        'amountreceived
        '
        Me.amountreceived.AutoSize = True
        Me.amountreceived.Font = New System.Drawing.Font("Roboto Light", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountreceived.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amountreceived.Location = New System.Drawing.Point(11, 23)
        Me.amountreceived.Name = "amountreceived"
        Me.amountreceived.Size = New System.Drawing.Size(209, 27)
        Me.amountreceived.TabIndex = 1
        Me.amountreceived.Text = "AMOUNT RECEIVED"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Roboto Light", 15.0!)
        Me.total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.total.Location = New System.Drawing.Point(583, 47)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(88, 30)
        Me.total.TabIndex = 1
        Me.total.Text = "TOTAL"
        '
        'php
        '
        Me.php.AutoSize = True
        Me.php.Font = New System.Drawing.Font("Roboto Light", 28.0!)
        Me.php.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.php.Location = New System.Drawing.Point(3, 47)
        Me.php.Name = "php"
        Me.php.Size = New System.Drawing.Size(116, 57)
        Me.php.TabIndex = 1
        Me.php.Text = "PHP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Light", 15.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 30)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "PHP"
        '
        'changeAmt
        '
        Me.changeAmt.AutoSize = True
        Me.changeAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.changeAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.changeAmt.Location = New System.Drawing.Point(75, 131)
        Me.changeAmt.Name = "changeAmt"
        Me.changeAmt.Size = New System.Drawing.Size(27, 29)
        Me.changeAmt.TabIndex = 1
        Me.changeAmt.Text = "0"
        '
        'phptotal
        '
        Me.phptotal.AutoSize = True
        Me.phptotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.phptotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phptotal.Location = New System.Drawing.Point(575, 73)
        Me.phptotal.Name = "phptotal"
        Me.phptotal.Size = New System.Drawing.Size(127, 58)
        Me.phptotal.TabIndex = 1
        Me.phptotal.Text = "PHP"
        '
        'totalAmt
        '
        Me.totalAmt.AutoSize = True
        Me.totalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalAmt.Location = New System.Drawing.Point(732, 73)
        Me.totalAmt.Name = "totalAmt"
        Me.totalAmt.Size = New System.Drawing.Size(53, 58)
        Me.totalAmt.TabIndex = 1
        Me.totalAmt.Text = "0"
        Me.totalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'savePath
        '
        Me.savePath.BackColor = System.Drawing.SystemColors.ControlLight
        Me.savePath.ForeColor = System.Drawing.Color.Silver
        Me.savePath.Location = New System.Drawing.Point(1002, 25)
        Me.savePath.Name = "savePath"
        Me.savePath.ReadOnly = True
        Me.savePath.Size = New System.Drawing.Size(239, 22)
        Me.savePath.TabIndex = 5
        '
        'logout_btn
        '
        Me.logout_btn.BackgroundImage = Global.post_by_otens.My.Resources.Resources.icons8_exit_32
        Me.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logout_btn.Location = New System.Drawing.Point(1416, 12)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(24, 26)
        Me.logout_btn.TabIndex = 6
        Me.logout_btn.TabStop = False
        '
        'savePathbtn
        '
        Me.savePathbtn.Image = Global.post_by_otens.My.Resources.Resources.icons8_save_24px1
        Me.savePathbtn.ImageActive = Nothing
        Me.savePathbtn.Location = New System.Drawing.Point(975, 20)
        Me.savePathbtn.Name = "savePathbtn"
        Me.savePathbtn.Size = New System.Drawing.Size(21, 31)
        Me.savePathbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.savePathbtn.TabIndex = 4
        Me.savePathbtn.TabStop = False
        Me.savePathbtn.Zoom = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.post_by_otens.My.Resources.Resources.icons8_filled_circle_30px_3
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(1446, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.post_by_otens.My.Resources.Resources.icons8_filled_circle_30px_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1476, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 26)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'RegisterTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1513, 719)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.savePath)
        Me.Controls.Add(Me.savePathbtn)
        Me.Controls.Add(Me.register_pnl)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1513, 719)
        Me.Name = "RegisterTab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.register_pnl.ResumeLayout(False)
        Me.shoppingCard_pnl.ResumeLayout(False)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.product_pnl.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.totals.ResumeLayout(False)
        Me.card.ResumeLayout(False)
        Me.card.PerformLayout()
        CType(Me.logout_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.savePathbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents confirm As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents card As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents totalAmt As Label
    Friend WithEvents amountreceived As Label
    Friend WithEvents total As Label
    Friend WithEvents php As Label
    Friend WithEvents change As Label
    Friend WithEvents changeAmt As Label
    Friend WithEvents searchBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents phptotal As Label
    Friend WithEvents shoppingCart_flow As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents void As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents confirmWreceipt As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents savePathbtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents savePath As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents logout_btn As PictureBox
    Friend WithEvents amtRecvd As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
