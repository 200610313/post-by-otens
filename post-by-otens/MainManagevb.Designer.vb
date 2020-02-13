<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainManagevb
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
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainManagevb))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Exit_bttn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SlidingPanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Menu_bttn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SendSMS = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.LogoPanel = New System.Windows.Forms.Panel()
        Me.MessagePanel = New System.Windows.Forms.Panel()
        Me.Send_bttn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxApiCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTransition2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelTop.SuspendLayout()
        CType(Me.Exit_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SlidingPanel.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.LogoPanel.SuspendLayout()
        Me.MessagePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelTop
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelTop
        '
        Me.PanelTop.BackgroundImage = CType(resources.GetObject("PanelTop.BackgroundImage"), System.Drawing.Image)
        Me.PanelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelTop.Controls.Add(Me.Exit_bttn)
        Me.PanelTransition2.SetDecoration(Me.PanelTop, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.PanelTop, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.GradientBottomLeft = System.Drawing.Color.White
        Me.PanelTop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PanelTop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PanelTop.GradientTopRight = System.Drawing.Color.White
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Quality = 10
        Me.PanelTop.Size = New System.Drawing.Size(859, 51)
        Me.PanelTop.TabIndex = 3
        '
        'Exit_bttn
        '
        Me.Exit_bttn.BackColor = System.Drawing.Color.Transparent
        Me.PanelTransition2.SetDecoration(Me.Exit_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Exit_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.Exit_bttn.Image = CType(resources.GetObject("Exit_bttn.Image"), System.Drawing.Image)
        Me.Exit_bttn.ImageActive = Nothing
        Me.Exit_bttn.Location = New System.Drawing.Point(827, 12)
        Me.Exit_bttn.Name = "Exit_bttn"
        Me.Exit_bttn.Size = New System.Drawing.Size(20, 20)
        Me.Exit_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Exit_bttn.TabIndex = 4
        Me.Exit_bttn.TabStop = False
        Me.Exit_bttn.Zoom = 10
        '
        'SlidingPanel
        '
        Me.SlidingPanel.BackgroundImage = CType(resources.GetObject("SlidingPanel.BackgroundImage"), System.Drawing.Image)
        Me.SlidingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlidingPanel.Controls.Add(Me.Logo)
        Me.SlidingPanel.Controls.Add(Me.Menu_bttn)
        Me.SlidingPanel.Controls.Add(Me.BunifuFlatButton2)
        Me.SlidingPanel.Controls.Add(Me.BunifuFlatButton1)
        Me.SlidingPanel.Controls.Add(Me.SendSMS)
        Me.PanelTransition2.SetDecoration(Me.SlidingPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.SlidingPanel, BunifuAnimatorNS.DecorationType.None)
        Me.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidingPanel.GradientBottomLeft = System.Drawing.Color.White
        Me.SlidingPanel.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SlidingPanel.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SlidingPanel.GradientTopRight = System.Drawing.Color.White
        Me.SlidingPanel.Location = New System.Drawing.Point(0, 51)
        Me.SlidingPanel.Name = "SlidingPanel"
        Me.SlidingPanel.Quality = 10
        Me.SlidingPanel.Size = New System.Drawing.Size(310, 526)
        Me.SlidingPanel.TabIndex = 2
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.PanelTransition.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(12, -1)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(239, 123)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Menu_bttn
        '
        Me.Menu_bttn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Menu_bttn.BackColor = System.Drawing.Color.Transparent
        Me.PanelTransition2.SetDecoration(Me.Menu_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Menu_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.Menu_bttn.Image = CType(resources.GetObject("Menu_bttn.Image"), System.Drawing.Image)
        Me.Menu_bttn.ImageActive = Nothing
        Me.Menu_bttn.Location = New System.Drawing.Point(259, 3)
        Me.Menu_bttn.Name = "Menu_bttn"
        Me.Menu_bttn.Size = New System.Drawing.Size(33, 29)
        Me.Menu_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Menu_bttn.TabIndex = 1
        Me.Menu_bttn.TabStop = False
        Me.Menu_bttn.Zoom = 10
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Active = False
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "       Stocks"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 263)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(349, 59)
        Me.BunifuFlatButton2.TabIndex = 2
        Me.BunifuFlatButton2.Text = "       Stocks"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Active = False
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "       Invoice"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 196)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(349, 59)
        Me.BunifuFlatButton1.TabIndex = 2
        Me.BunifuFlatButton1.Text = "       Invoice"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SendSMS
        '
        Me.SendSMS.Active = False
        Me.SendSMS.Activecolor = System.Drawing.Color.Transparent
        Me.SendSMS.BackColor = System.Drawing.Color.Transparent
        Me.SendSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SendSMS.BorderRadius = 0
        Me.SendSMS.ButtonText = "       Message"
        Me.SendSMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.SendSMS, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.SendSMS, BunifuAnimatorNS.DecorationType.None)
        Me.SendSMS.DisabledColor = System.Drawing.Color.Gray
        Me.SendSMS.Iconcolor = System.Drawing.Color.Transparent
        Me.SendSMS.Iconimage = CType(resources.GetObject("SendSMS.Iconimage"), System.Drawing.Image)
        Me.SendSMS.Iconimage_right = Nothing
        Me.SendSMS.Iconimage_right_Selected = Nothing
        Me.SendSMS.Iconimage_Selected = Nothing
        Me.SendSMS.IconMarginLeft = 0
        Me.SendSMS.IconMarginRight = 0
        Me.SendSMS.IconRightVisible = True
        Me.SendSMS.IconRightZoom = 0R
        Me.SendSMS.IconVisible = True
        Me.SendSMS.IconZoom = 50.0R
        Me.SendSMS.IsTab = False
        Me.SendSMS.Location = New System.Drawing.Point(0, 129)
        Me.SendSMS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SendSMS.Name = "SendSMS"
        Me.SendSMS.Normalcolor = System.Drawing.Color.Transparent
        Me.SendSMS.OnHovercolor = System.Drawing.Color.Transparent
        Me.SendSMS.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.SendSMS.selected = False
        Me.SendSMS.Size = New System.Drawing.Size(349, 59)
        Me.SendSMS.TabIndex = 2
        Me.SendSMS.Text = "       Message"
        Me.SendSMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SendSMS.Textcolor = System.Drawing.Color.White
        Me.SendSMS.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelTransition
        '
        Me.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.PanelTransition.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 1
        Animation4.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 2.0!
        Animation4.TransparencyCoeff = 0!
        Me.PanelTransition.DefaultAnimation = Animation4
        Me.PanelTransition.Interval = 20
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.Controls.Add(Me.MessagePanel)
        Me.MainPanel.Controls.Add(Me.LogoPanel)
        Me.PanelTransition2.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.MainPanel.Location = New System.Drawing.Point(307, 51)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(549, 523)
        Me.MainPanel.TabIndex = 3
        '
        'LogoPanel
        '
        Me.LogoPanel.Controls.Add(Me.PictureBox1)
        Me.PanelTransition2.SetDecoration(Me.LogoPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.LogoPanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoPanel.Location = New System.Drawing.Point(0, -1)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.Size = New System.Drawing.Size(552, 527)
        Me.LogoPanel.TabIndex = 0
        '
        'MessagePanel
        '
        Me.MessagePanel.Controls.Add(Me.Send_bttn)
        Me.MessagePanel.Controls.Add(Me.Label3)
        Me.MessagePanel.Controls.Add(Me.TextBoxApiCode)
        Me.MessagePanel.Controls.Add(Me.Label2)
        Me.MessagePanel.Controls.Add(Me.TextBoxMessage)
        Me.MessagePanel.Controls.Add(Me.Label1)
        Me.MessagePanel.Controls.Add(Me.TextBoxNumber)
        Me.PanelTransition2.SetDecoration(Me.MessagePanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.MessagePanel, BunifuAnimatorNS.DecorationType.None)
        Me.MessagePanel.Location = New System.Drawing.Point(0, 0)
        Me.MessagePanel.Name = "MessagePanel"
        Me.MessagePanel.Size = New System.Drawing.Size(552, 527)
        Me.MessagePanel.TabIndex = 1
        '
        'Send_bttn
        '
        Me.PanelTransition.SetDecoration(Me.Send_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Send_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.Send_bttn.Location = New System.Drawing.Point(252, 356)
        Me.Send_bttn.Margin = New System.Windows.Forms.Padding(4)
        Me.Send_bttn.Name = "Send_bttn"
        Me.Send_bttn.Size = New System.Drawing.Size(113, 52)
        Me.Send_bttn.TabIndex = 17
        Me.Send_bttn.Text = "Send"
        Me.Send_bttn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.PanelTransition.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Location = New System.Drawing.Point(111, 318)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ApiCode"
        '
        'TextBoxApiCode
        '
        Me.PanelTransition.SetDecoration(Me.TextBoxApiCode, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.TextBoxApiCode, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxApiCode.Location = New System.Drawing.Point(173, 315)
        Me.TextBoxApiCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxApiCode.Name = "TextBoxApiCode"
        Me.TextBoxApiCode.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxApiCode.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.PanelTransition.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Location = New System.Drawing.Point(107, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Message"
        '
        'TextBoxMessage
        '
        Me.PanelTransition.SetDecoration(Me.TextBoxMessage, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.TextBoxMessage, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxMessage.Location = New System.Drawing.Point(173, 150)
        Me.TextBoxMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxMessage.Multiline = True
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.Size = New System.Drawing.Size(268, 157)
        Me.TextBoxMessage.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.PanelTransition.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Location = New System.Drawing.Point(111, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Number"
        '
        'TextBoxNumber
        '
        Me.PanelTransition.SetDecoration(Me.TextBoxNumber, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.TextBoxNumber, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxNumber.Location = New System.Drawing.Point(173, 118)
        Me.TextBoxNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxNumber.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PanelTransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(80, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelTransition2
        '
        Me.PanelTransition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelTransition2.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.PanelTransition2.DefaultAnimation = Animation3
        Me.PanelTransition2.Interval = 14
        '
        'MainManagevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(859, 577)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SlidingPanel)
        Me.Controls.Add(Me.PanelTop)
        Me.PanelTransition2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainManagevb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainManagevb"
        Me.PanelTop.ResumeLayout(False)
        CType(Me.Exit_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SlidingPanel.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.LogoPanel.ResumeLayout(False)
        Me.LogoPanel.PerformLayout()
        Me.MessagePanel.ResumeLayout(False)
        Me.MessagePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents SlidingPanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents PanelTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Menu_bttn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SendSMS As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Exit_bttn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelTransition2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents MainPanel As Panel
    Friend WithEvents LogoPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MessagePanel As Panel
    Friend WithEvents Send_bttn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxApiCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMessage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNumber As TextBox
End Class
