<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.searchBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastPurchase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPurchases = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Open Sans Light", 5.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cID, Me.custFullName, Me.lastPurchase, Me.totalPurchases})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(800, 243)
        Me.DataGridView1.TabIndex = 0
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
        Me.searchBox.Location = New System.Drawing.Point(304, 50)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.searchBox.MaxLength = 32767
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(224, 30)
        Me.searchBox.TabIndex = 6
        Me.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.post_by_otens.My.Resources.Resources.icons8_search_50px
        Me.PictureBox4.Location = New System.Drawing.Point(264, 51)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'cID
        '
        Me.cID.HeaderText = "ID"
        Me.cID.MinimumWidth = 6
        Me.cID.Name = "cID"
        Me.cID.ReadOnly = True
        Me.cID.Width = 125
        '
        'custFullName
        '
        Me.custFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.custFullName.HeaderText = "Full Name"
        Me.custFullName.MinimumWidth = 6
        Me.custFullName.Name = "custFullName"
        Me.custFullName.ReadOnly = True
        '
        'lastPurchase
        '
        Me.lastPurchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lastPurchase.HeaderText = "Date of Recent Purchase"
        Me.lastPurchase.MinimumWidth = 6
        Me.lastPurchase.Name = "lastPurchase"
        Me.lastPurchase.ReadOnly = True
        '
        'totalPurchases
        '
        Me.totalPurchases.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.totalPurchases.HeaderText = "Total Purchases Made"
        Me.totalPurchases.MinimumWidth = 6
        Me.totalPurchases.Name = "totalPurchases"
        Me.totalPurchases.ReadOnly = True
        '
        'customerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customerSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customerSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchBox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cID As DataGridViewTextBoxColumn
    Friend WithEvents custFullName As DataGridViewTextBoxColumn
    Friend WithEvents lastPurchase As DataGridViewTextBoxColumn
    Friend WithEvents totalPurchases As DataGridViewTextBoxColumn
End Class
