<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custRegistrationForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.submitbutton = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.phone = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.zip = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.state = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.city = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lN = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.mI = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.fN = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.submitbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel1.Controls.Add(Me.submitbutton)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.phone)
        Me.Panel1.Controls.Add(Me.zip)
        Me.Panel1.Controls.Add(Me.state)
        Me.Panel1.Controls.Add(Me.city)
        Me.Panel1.Controls.Add(Me.lN)
        Me.Panel1.Controls.Add(Me.mI)
        Me.Panel1.Controls.Add(Me.fN)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 457)
        Me.Panel1.TabIndex = 0
        '
        'submitbutton
        '
        Me.submitbutton.Image = Global.post_by_otens.My.Resources.Resources.icons8_ok_48px
        Me.submitbutton.Location = New System.Drawing.Point(114, 404)
        Me.submitbutton.Name = "submitbutton"
        Me.submitbutton.Size = New System.Drawing.Size(47, 43)
        Me.submitbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.submitbutton.TabIndex = 4
        Me.submitbutton.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(20, 393)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "PHONE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ZIP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "STATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "LAST NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MIDDLE INITIAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 30)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Customer Registration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FIRST NAME"
        '
        'phone
        '
        Me.phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.phone.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phone.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.ForeColor = System.Drawing.Color.White
        Me.phone.HintForeColor = System.Drawing.Color.Empty
        Me.phone.HintText = ""
        Me.phone.isPassword = False
        Me.phone.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.phone.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.phone.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.phone.LineThickness = 3
        Me.phone.Location = New System.Drawing.Point(20, 355)
        Me.phone.Margin = New System.Windows.Forms.Padding(4)
        Me.phone.MaxLength = 32767
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(190, 36)
        Me.phone.TabIndex = 2
        Me.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'zip
        '
        Me.zip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.zip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.zip.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.zip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.zip.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zip.ForeColor = System.Drawing.Color.White
        Me.zip.HintForeColor = System.Drawing.Color.Empty
        Me.zip.HintText = ""
        Me.zip.isPassword = False
        Me.zip.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.zip.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.zip.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.zip.LineThickness = 3
        Me.zip.Location = New System.Drawing.Point(20, 302)
        Me.zip.Margin = New System.Windows.Forms.Padding(4)
        Me.zip.MaxLength = 32767
        Me.zip.Name = "zip"
        Me.zip.Size = New System.Drawing.Size(190, 36)
        Me.zip.TabIndex = 2
        Me.zip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'state
        '
        Me.state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.state.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.state.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.state.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.state.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.state.ForeColor = System.Drawing.Color.White
        Me.state.HintForeColor = System.Drawing.Color.Empty
        Me.state.HintText = ""
        Me.state.isPassword = False
        Me.state.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.state.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.state.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.state.LineThickness = 3
        Me.state.Location = New System.Drawing.Point(20, 249)
        Me.state.Margin = New System.Windows.Forms.Padding(4)
        Me.state.MaxLength = 32767
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(190, 36)
        Me.state.TabIndex = 2
        Me.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'city
        '
        Me.city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.city.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.city.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.city.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city.ForeColor = System.Drawing.Color.White
        Me.city.HintForeColor = System.Drawing.Color.Empty
        Me.city.HintText = ""
        Me.city.isPassword = False
        Me.city.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.city.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.city.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.city.LineThickness = 3
        Me.city.Location = New System.Drawing.Point(20, 196)
        Me.city.Margin = New System.Windows.Forms.Padding(4)
        Me.city.MaxLength = 32767
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(190, 36)
        Me.city.TabIndex = 2
        Me.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lN
        '
        Me.lN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.lN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.lN.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lN.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lN.ForeColor = System.Drawing.Color.White
        Me.lN.HintForeColor = System.Drawing.Color.Empty
        Me.lN.HintText = ""
        Me.lN.isPassword = False
        Me.lN.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lN.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lN.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lN.LineThickness = 3
        Me.lN.Location = New System.Drawing.Point(20, 143)
        Me.lN.Margin = New System.Windows.Forms.Padding(4)
        Me.lN.MaxLength = 32767
        Me.lN.Name = "lN"
        Me.lN.Size = New System.Drawing.Size(190, 36)
        Me.lN.TabIndex = 2
        Me.lN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mI
        '
        Me.mI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.mI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.mI.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.mI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mI.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mI.ForeColor = System.Drawing.Color.White
        Me.mI.HintForeColor = System.Drawing.Color.Empty
        Me.mI.HintText = ""
        Me.mI.isPassword = False
        Me.mI.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mI.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mI.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mI.LineThickness = 3
        Me.mI.Location = New System.Drawing.Point(20, 90)
        Me.mI.Margin = New System.Windows.Forms.Padding(4)
        Me.mI.MaxLength = 32767
        Me.mI.Name = "mI"
        Me.mI.Size = New System.Drawing.Size(70, 36)
        Me.mI.TabIndex = 2
        Me.mI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fN
        '
        Me.fN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.fN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.fN.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.fN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fN.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fN.ForeColor = System.Drawing.Color.White
        Me.fN.HintForeColor = System.Drawing.Color.Empty
        Me.fN.HintText = ""
        Me.fN.isPassword = False
        Me.fN.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fN.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fN.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fN.LineThickness = 3
        Me.fN.Location = New System.Drawing.Point(20, 37)
        Me.fN.Margin = New System.Windows.Forms.Padding(4)
        Me.fN.MaxLength = 32767
        Me.fN.Name = "fN"
        Me.fN.Size = New System.Drawing.Size(190, 36)
        Me.fN.TabIndex = 2
        Me.fN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'custRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 481)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "custRegistrationForm"
        Me.Text = "custRegistrationForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.submitbutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents fN As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mI As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents lN As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents state As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents city As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents zip As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents phone As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents submitbutton As PictureBox
End Class
