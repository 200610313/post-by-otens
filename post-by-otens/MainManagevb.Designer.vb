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
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainManagevb))
        Me.Elipse_Form = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Exit_bttn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PanelTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.StockPanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SearchBar = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.PNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POSDataSet = New post_by_otens.POSDataSet()
        Me.Panel_Save_btn = New System.Windows.Forms.Panel()
        Me.Save_btn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel_Edit_btn = New System.Windows.Forms.Panel()
        Me.Edit_btn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel_AddStock_btn = New System.Windows.Forms.Panel()
        Me.AddStock_bttn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LogoPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MessagePanel = New System.Windows.Forms.Panel()
        Me.Send_bttn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxApiCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.SlidingPanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Menu_bttn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Stocks_bttn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SendSMS = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelTransition2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Elipse_AddStock = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Elipse_Delete = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Elipse_Edit = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Elipse_Save_btn = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ProductBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New post_by_otens.POSDataSetTableAdapters.productTableAdapter()
        Me.POSDataSet1 = New post_by_otens.POSDataSet()
        Me.POSDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Search_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelTop.SuspendLayout()
        CType(Me.Exit_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.StockPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Save_btn.SuspendLayout()
        CType(Me.Save_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Edit_btn.SuspendLayout()
        CType(Me.Edit_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_AddStock_btn.SuspendLayout()
        CType(Me.AddStock_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogoPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessagePanel.SuspendLayout()
        Me.SlidingPanel.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Elipse_Form
        '
        Me.Elipse_Form.ElipseRadius = 5
        Me.Elipse_Form.TargetControl = Me
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
        Me.PanelTransition.SetDecoration(Me.PanelTop, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.PanelTop, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.PanelTop, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.GradientBottomLeft = System.Drawing.Color.White
        Me.PanelTop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PanelTop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PanelTop.GradientTopRight = System.Drawing.Color.White
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Quality = 10
        Me.PanelTop.Size = New System.Drawing.Size(1101, 51)
        Me.PanelTop.TabIndex = 3
        '
        'Exit_bttn
        '
        Me.Exit_bttn.BackColor = System.Drawing.Color.Transparent
        Me.PanelTransition.SetDecoration(Me.Exit_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Exit_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Exit_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.Exit_bttn.Image = CType(resources.GetObject("Exit_bttn.Image"), System.Drawing.Image)
        Me.Exit_bttn.ImageActive = Nothing
        Me.Exit_bttn.Location = New System.Drawing.Point(1069, 12)
        Me.Exit_bttn.Name = "Exit_bttn"
        Me.Exit_bttn.Size = New System.Drawing.Size(20, 20)
        Me.Exit_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Exit_bttn.TabIndex = 4
        Me.Exit_bttn.TabStop = False
        Me.Exit_bttn.Zoom = 10
        '
        'PanelTransition
        '
        Me.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.PanelTransition.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 1
        Animation3.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 2.0!
        Animation3.TransparencyCoeff = 0!
        Me.PanelTransition.DefaultAnimation = Animation3
        Me.PanelTransition.Interval = 20
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.Controls.Add(Me.StockPanel)
        Me.MainPanel.Controls.Add(Me.LogoPanel)
        Me.MainPanel.Controls.Add(Me.MessagePanel)
        Me.PanelTransition.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.MainPanel.Location = New System.Drawing.Point(307, 51)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(791, 730)
        Me.MainPanel.TabIndex = 3
        '
        'StockPanel
        '
        Me.StockPanel.BackColor = System.Drawing.Color.White
        Me.StockPanel.Controls.Add(Me.Search_btn)
        Me.StockPanel.Controls.Add(Me.Label7)
        Me.StockPanel.Controls.Add(Me.Label6)
        Me.StockPanel.Controls.Add(Me.PictureBox2)
        Me.StockPanel.Controls.Add(Me.Panel2)
        Me.StockPanel.Controls.Add(Me.Label5)
        Me.StockPanel.Controls.Add(Me.SearchBar)
        Me.StockPanel.Controls.Add(Me.Panel1)
        Me.StockPanel.Controls.Add(Me.ProductDataGrid)
        Me.StockPanel.Controls.Add(Me.Panel_Save_btn)
        Me.StockPanel.Controls.Add(Me.Panel_Edit_btn)
        Me.StockPanel.Controls.Add(Me.Panel_AddStock_btn)
        Me.StockPanel.Controls.Add(Me.Label4)
        Me.PanelTransition.SetDecoration(Me.StockPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.StockPanel, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.StockPanel, BunifuAnimatorNS.DecorationType.None)
        Me.StockPanel.Location = New System.Drawing.Point(0, 0)
        Me.StockPanel.Name = "StockPanel"
        Me.StockPanel.Size = New System.Drawing.Size(851, 730)
        Me.StockPanel.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 26)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Edit Stocks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Add Product"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(533, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(251, 116)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelTransition.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(517, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 211)
        Me.Panel2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Roboto Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 39)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Product"
        '
        'SearchBar
        '
        Me.SearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.SearchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.SearchBar.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PanelTransition2.SetDecoration(Me.SearchBar, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.SearchBar, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.SearchBar, BunifuAnimatorNS.DecorationType.None)
        Me.SearchBar.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.SearchBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchBar.HintForeColor = System.Drawing.Color.Empty
        Me.SearchBar.HintText = ""
        Me.SearchBar.isPassword = False
        Me.SearchBar.LineFocusedColor = System.Drawing.Color.Blue
        Me.SearchBar.LineIdleColor = System.Drawing.Color.Gray
        Me.SearchBar.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.SearchBar.LineThickness = 3
        Me.SearchBar.Location = New System.Drawing.Point(10, 142)
        Me.SearchBar.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBar.MaxLength = 32767
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(345, 33)
        Me.SearchBar.TabIndex = 5
        Me.SearchBar.Text = "Search"
        Me.SearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelTransition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(9, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 10)
        Me.Panel1.TabIndex = 4
        '
        'ProductDataGrid
        '
        Me.ProductDataGrid.AllowUserToAddRows = False
        Me.ProductDataGrid.AllowUserToDeleteRows = False
        Me.ProductDataGrid.AllowUserToResizeColumns = False
        Me.ProductDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProductDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductDataGrid.AutoGenerateColumns = False
        Me.ProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.ProductDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.ProductDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductDataGrid.ColumnHeadersHeight = 29
        Me.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ProductDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNumberDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.PPriceDataGridViewTextBoxColumn, Me.PStockDataGridViewTextBoxColumn})
        Me.ProductDataGrid.DataSource = Me.ProductBindingSource
        Me.BunifuTransition1.SetDecoration(Me.ProductDataGrid, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.ProductDataGrid, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.ProductDataGrid, BunifuAnimatorNS.DecorationType.None)
        Me.ProductDataGrid.DoubleBuffered = True
        Me.ProductDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ProductDataGrid.EnableHeadersVisualStyles = False
        Me.ProductDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ProductDataGrid.HeaderBgColor = System.Drawing.Color.Gainsboro
        Me.ProductDataGrid.HeaderForeColor = System.Drawing.Color.Black
        Me.ProductDataGrid.Location = New System.Drawing.Point(3, 225)
        Me.ProductDataGrid.Name = "ProductDataGrid"
        Me.ProductDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ProductDataGrid.RowHeadersWidth = 18
        Me.ProductDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ProductDataGrid.RowTemplate.Height = 24
        Me.ProductDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ProductDataGrid.Size = New System.Drawing.Size(791, 474)
        Me.ProductDataGrid.TabIndex = 3
        '
        'PNumberDataGridViewTextBoxColumn
        '
        Me.PNumberDataGridViewTextBoxColumn.DataPropertyName = "pNumber"
        Me.PNumberDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.PNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PNumberDataGridViewTextBoxColumn.Name = "PNumberDataGridViewTextBoxColumn"
        Me.PNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.PNumberDataGridViewTextBoxColumn.Width = 52
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "pName"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.PNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.PNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        Me.PNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PPriceDataGridViewTextBoxColumn
        '
        Me.PPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PPriceDataGridViewTextBoxColumn.DataPropertyName = "pPrice"
        Me.PPriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PPriceDataGridViewTextBoxColumn.Name = "PPriceDataGridViewTextBoxColumn"
        Me.PPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PStockDataGridViewTextBoxColumn
        '
        Me.PStockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PStockDataGridViewTextBoxColumn.DataPropertyName = "pStock"
        Me.PStockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.PStockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PStockDataGridViewTextBoxColumn.Name = "PStockDataGridViewTextBoxColumn"
        Me.PStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "product"
        Me.ProductBindingSource.DataSource = Me.POSDataSetBindingSource
        '
        'POSDataSetBindingSource
        '
        Me.POSDataSetBindingSource.DataSource = Me.POSDataSet
        Me.POSDataSetBindingSource.Position = 0
        '
        'POSDataSet
        '
        Me.POSDataSet.DataSetName = "POSDataSet"
        Me.POSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel_Save_btn
        '
        Me.Panel_Save_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel_Save_btn.Controls.Add(Me.Save_btn)
        Me.PanelTransition.SetDecoration(Me.Panel_Save_btn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Panel_Save_btn, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel_Save_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_Save_btn.Location = New System.Drawing.Point(582, 150)
        Me.Panel_Save_btn.Name = "Panel_Save_btn"
        Me.Panel_Save_btn.Size = New System.Drawing.Size(147, 59)
        Me.Panel_Save_btn.TabIndex = 2
        '
        'Save_btn
        '
        Me.PanelTransition.SetDecoration(Me.Save_btn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Save_btn, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Save_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Save_btn.Image = Global.post_by_otens.My.Resources.Resources.icons8_save_641
        Me.Save_btn.ImageActive = Nothing
        Me.Save_btn.Location = New System.Drawing.Point(38, 6)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(69, 48)
        Me.Save_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Save_btn.TabIndex = 1
        Me.Save_btn.TabStop = False
        Me.Save_btn.Zoom = 10
        '
        'Panel_Edit_btn
        '
        Me.Panel_Edit_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel_Edit_btn.Controls.Add(Me.Edit_btn)
        Me.PanelTransition.SetDecoration(Me.Panel_Edit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Panel_Edit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel_Edit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_Edit_btn.Location = New System.Drawing.Point(157, 74)
        Me.Panel_Edit_btn.Name = "Panel_Edit_btn"
        Me.Panel_Edit_btn.Size = New System.Drawing.Size(86, 48)
        Me.Panel_Edit_btn.TabIndex = 2
        '
        'Edit_btn
        '
        Me.PanelTransition.SetDecoration(Me.Edit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Edit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Edit_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Edit_btn.Image = Global.post_by_otens.My.Resources.Resources.icons8_edit_property_26
        Me.Edit_btn.ImageActive = Nothing
        Me.Edit_btn.Location = New System.Drawing.Point(26, 8)
        Me.Edit_btn.Name = "Edit_btn"
        Me.Edit_btn.Size = New System.Drawing.Size(36, 32)
        Me.Edit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Edit_btn.TabIndex = 1
        Me.Edit_btn.TabStop = False
        Me.Edit_btn.Zoom = 10
        '
        'Panel_AddStock_btn
        '
        Me.Panel_AddStock_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel_AddStock_btn.Controls.Add(Me.AddStock_bttn)
        Me.PanelTransition.SetDecoration(Me.Panel_AddStock_btn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Panel_AddStock_btn, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel_AddStock_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_AddStock_btn.Location = New System.Drawing.Point(27, 74)
        Me.Panel_AddStock_btn.Name = "Panel_AddStock_btn"
        Me.Panel_AddStock_btn.Size = New System.Drawing.Size(86, 48)
        Me.Panel_AddStock_btn.TabIndex = 2
        '
        'AddStock_bttn
        '
        Me.PanelTransition.SetDecoration(Me.AddStock_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.AddStock_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.AddStock_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.AddStock_bttn.Image = Global.post_by_otens.My.Resources.Resources.icons8_box_64
        Me.AddStock_bttn.ImageActive = Nothing
        Me.AddStock_bttn.Location = New System.Drawing.Point(20, 0)
        Me.AddStock_bttn.Name = "AddStock_bttn"
        Me.AddStock_bttn.Size = New System.Drawing.Size(44, 40)
        Me.AddStock_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddStock_bttn.TabIndex = 1
        Me.AddStock_bttn.TabStop = False
        Me.AddStock_bttn.Zoom = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Roboto Condensed", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Inventory Management"
        '
        'LogoPanel
        '
        Me.LogoPanel.Controls.Add(Me.PictureBox1)
        Me.PanelTransition.SetDecoration(Me.LogoPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.LogoPanel, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.LogoPanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoPanel.Location = New System.Drawing.Point(0, -1)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.Size = New System.Drawing.Size(794, 734)
        Me.LogoPanel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(80, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.PanelTransition.SetDecoration(Me.MessagePanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.MessagePanel, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.MessagePanel, BunifuAnimatorNS.DecorationType.None)
        Me.MessagePanel.Location = New System.Drawing.Point(0, 0)
        Me.MessagePanel.Name = "MessagePanel"
        Me.MessagePanel.Size = New System.Drawing.Size(794, 733)
        Me.MessagePanel.TabIndex = 1
        '
        'Send_bttn
        '
        Me.BunifuTransition1.SetDecoration(Me.Send_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Send_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Send_bttn, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Location = New System.Drawing.Point(111, 318)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ApiCode"
        '
        'TextBoxApiCode
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBoxApiCode, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Location = New System.Drawing.Point(107, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Message"
        '
        'TextBoxMessage
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBoxMessage, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Location = New System.Drawing.Point(111, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Number"
        '
        'TextBoxNumber
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBoxNumber, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.TextBoxNumber, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.TextBoxNumber, BunifuAnimatorNS.DecorationType.None)
        Me.TextBoxNumber.Location = New System.Drawing.Point(173, 118)
        Me.TextBoxNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxNumber.TabIndex = 13
        '
        'SlidingPanel
        '
        Me.SlidingPanel.BackgroundImage = CType(resources.GetObject("SlidingPanel.BackgroundImage"), System.Drawing.Image)
        Me.SlidingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SlidingPanel.Controls.Add(Me.Logo)
        Me.SlidingPanel.Controls.Add(Me.Menu_bttn)
        Me.SlidingPanel.Controls.Add(Me.Stocks_bttn)
        Me.SlidingPanel.Controls.Add(Me.BunifuFlatButton1)
        Me.SlidingPanel.Controls.Add(Me.SendSMS)
        Me.PanelTransition.SetDecoration(Me.SlidingPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.SlidingPanel, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.SlidingPanel, BunifuAnimatorNS.DecorationType.None)
        Me.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidingPanel.GradientBottomLeft = System.Drawing.Color.White
        Me.SlidingPanel.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SlidingPanel.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SlidingPanel.GradientTopRight = System.Drawing.Color.White
        Me.SlidingPanel.Location = New System.Drawing.Point(0, 51)
        Me.SlidingPanel.Name = "SlidingPanel"
        Me.SlidingPanel.Quality = 10
        Me.SlidingPanel.Size = New System.Drawing.Size(310, 733)
        Me.SlidingPanel.TabIndex = 2
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
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
        Me.PanelTransition.SetDecoration(Me.Menu_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Menu_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Menu_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.Menu_bttn.Image = CType(resources.GetObject("Menu_bttn.Image"), System.Drawing.Image)
        Me.Menu_bttn.ImageActive = Nothing
        Me.Menu_bttn.Location = New System.Drawing.Point(268, 6)
        Me.Menu_bttn.Name = "Menu_bttn"
        Me.Menu_bttn.Size = New System.Drawing.Size(33, 29)
        Me.Menu_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Menu_bttn.TabIndex = 1
        Me.Menu_bttn.TabStop = False
        Me.Menu_bttn.Zoom = 10
        '
        'Stocks_bttn
        '
        Me.Stocks_bttn.Active = False
        Me.Stocks_bttn.Activecolor = System.Drawing.Color.Transparent
        Me.Stocks_bttn.BackColor = System.Drawing.Color.Transparent
        Me.Stocks_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Stocks_bttn.BorderRadius = 0
        Me.Stocks_bttn.ButtonText = "       Inventory"
        Me.Stocks_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.Stocks_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Stocks_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Stocks_bttn, BunifuAnimatorNS.DecorationType.None)
        Me.Stocks_bttn.DisabledColor = System.Drawing.Color.Gray
        Me.Stocks_bttn.Iconcolor = System.Drawing.Color.Transparent
        Me.Stocks_bttn.Iconimage = CType(resources.GetObject("Stocks_bttn.Iconimage"), System.Drawing.Image)
        Me.Stocks_bttn.Iconimage_right = Nothing
        Me.Stocks_bttn.Iconimage_right_Selected = Nothing
        Me.Stocks_bttn.Iconimage_Selected = Nothing
        Me.Stocks_bttn.IconMarginLeft = 0
        Me.Stocks_bttn.IconMarginRight = 0
        Me.Stocks_bttn.IconRightVisible = True
        Me.Stocks_bttn.IconRightZoom = 0R
        Me.Stocks_bttn.IconVisible = True
        Me.Stocks_bttn.IconZoom = 50.0R
        Me.Stocks_bttn.IsTab = False
        Me.Stocks_bttn.Location = New System.Drawing.Point(0, 263)
        Me.Stocks_bttn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Stocks_bttn.Name = "Stocks_bttn"
        Me.Stocks_bttn.Normalcolor = System.Drawing.Color.Transparent
        Me.Stocks_bttn.OnHovercolor = System.Drawing.Color.Transparent
        Me.Stocks_bttn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Stocks_bttn.selected = False
        Me.Stocks_bttn.Size = New System.Drawing.Size(349, 59)
        Me.Stocks_bttn.TabIndex = 2
        Me.Stocks_bttn.Text = "       Inventory"
        Me.Stocks_bttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Stocks_bttn.Textcolor = System.Drawing.Color.White
        Me.Stocks_bttn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.SendSMS, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.SendSMS, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.SendSMS, BunifuAnimatorNS.DecorationType.None)
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
        'ProductBindingSource1
        '
        Me.ProductBindingSource1.DataMember = "product"
        Me.ProductBindingSource1.DataSource = Me.POSDataSetBindingSource
        '
        'PanelTransition2
        '
        Me.PanelTransition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelTransition2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.PanelTransition2.DefaultAnimation = Animation2
        Me.PanelTransition2.Interval = 14
        '
        'Elipse_AddStock
        '
        Me.Elipse_AddStock.ElipseRadius = 15
        Me.Elipse_AddStock.TargetControl = Me.Panel_AddStock_btn
        '
        'Elipse_Delete
        '
        Me.Elipse_Delete.ElipseRadius = 15
        Me.Elipse_Delete.TargetControl = Me
        '
        'Elipse_Edit
        '
        Me.Elipse_Edit.ElipseRadius = 15
        Me.Elipse_Edit.TargetControl = Me.Panel_Edit_btn
        '
        'Elipse_Save_btn
        '
        Me.Elipse_Save_btn.ElipseRadius = 15
        Me.Elipse_Save_btn.TargetControl = Me.Panel_Save_btn
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(30)
        Animation1.RotateCoeff = 0.5!
        Animation1.RotateLimit = 0.2!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'ProductBindingSource2
        '
        Me.ProductBindingSource2.DataMember = "product"
        Me.ProductBindingSource2.DataSource = Me.POSDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'POSDataSet1
        '
        Me.POSDataSet1.DataSetName = "POSDataSet"
        Me.POSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'POSDataSet1BindingSource
        '
        Me.POSDataSet1BindingSource.DataSource = Me.POSDataSet1
        Me.POSDataSet1BindingSource.Position = 0
        '
        'Search_btn
        '
        Me.Search_btn.Active = False
        Me.Search_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Search_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Search_btn.BorderRadius = 0
        Me.Search_btn.ButtonText = "Search Filter"
        Me.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.Search_btn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me.Search_btn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Search_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Search_btn.DisabledColor = System.Drawing.Color.Gray
        Me.Search_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.Search_btn.Iconimage = Nothing
        Me.Search_btn.Iconimage_right = Nothing
        Me.Search_btn.Iconimage_right_Selected = Nothing
        Me.Search_btn.Iconimage_Selected = Nothing
        Me.Search_btn.IconMarginLeft = 0
        Me.Search_btn.IconMarginRight = 0
        Me.Search_btn.IconRightVisible = True
        Me.Search_btn.IconRightZoom = 0R
        Me.Search_btn.IconVisible = True
        Me.Search_btn.IconZoom = 90.0R
        Me.Search_btn.IsTab = False
        Me.Search_btn.Location = New System.Drawing.Point(363, 145)
        Me.Search_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Search_btn.Name = "Search_btn"
        Me.Search_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Search_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Search_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.Search_btn.selected = False
        Me.Search_btn.Size = New System.Drawing.Size(133, 33)
        Me.Search_btn.TabIndex = 8
        Me.Search_btn.Text = "Search Filter"
        Me.Search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Search_btn.Textcolor = System.Drawing.Color.White
        Me.Search_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.Search_btn
        '
        'MainManagevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 784)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SlidingPanel)
        Me.Controls.Add(Me.PanelTop)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainManagevb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainManagevb"
        Me.PanelTop.ResumeLayout(False)
        CType(Me.Exit_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.StockPanel.ResumeLayout(False)
        Me.StockPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Save_btn.ResumeLayout(False)
        CType(Me.Save_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Edit_btn.ResumeLayout(False)
        CType(Me.Edit_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_AddStock_btn.ResumeLayout(False)
        CType(Me.AddStock_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogoPanel.ResumeLayout(False)
        Me.LogoPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessagePanel.ResumeLayout(False)
        Me.MessagePanel.PerformLayout()
        Me.SlidingPanel.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Elipse_Form As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents SlidingPanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents PanelTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Menu_bttn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SendSMS As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Exit_bttn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Stocks_bttn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelTransition2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents MainPanel As Panel
    Friend WithEvents LogoPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MessagePanel As Panel
    Friend WithEvents StockPanel As Panel
    Friend WithEvents Panel_AddStock_btn As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Elipse_AddStock As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel_Save_btn As Panel
    Friend WithEvents Save_btn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel_Edit_btn As Panel
    Friend WithEvents Edit_btn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Elipse_Delete As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Elipse_Edit As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Elipse_Save_btn As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents AddStock_bttn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents POSDataSetBindingSource As BindingSource
    Friend WithEvents POSDataSet As POSDataSet
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchBar As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents ProductDataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As POSDataSetTableAdapters.productTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ProductBindingSource1 As BindingSource
    Friend WithEvents POSDataSet1BindingSource As BindingSource
    Friend WithEvents POSDataSet1 As POSDataSet
    Friend WithEvents ProductBindingSource2 As BindingSource
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Send_bttn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxApiCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMessage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Search_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
End Class
