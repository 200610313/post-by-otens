<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class managerVerifier
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
        Me.exitForm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchBox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.exitForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitForm
        '
        Me.exitForm.Image = Global.post_by_otens.My.Resources.Resources.icons8_filled_circle_16
        Me.exitForm.Location = New System.Drawing.Point(292, 2)
        Me.exitForm.Name = "exitForm"
        Me.exitForm.Size = New System.Drawing.Size(16, 16)
        Me.exitForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.exitForm.TabIndex = 6
        Me.exitForm.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 5.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MANAGER PASSWORD"
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
        Me.searchBox.Location = New System.Drawing.Point(43, 24)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.searchBox.MaxLength = 32767
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(224, 30)
        Me.searchBox.TabIndex = 7
        Me.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'managerVerifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 79)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.exitForm)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "managerVerifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "managerVerifier"
        CType(Me.exitForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitForm As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents searchBox As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
