<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popUpBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popUpBox))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitForm = New System.Windows.Forms.PictureBox()
        Me.existingbtn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.newbtn = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.exitForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 5.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CUSTOMER TYPE"
        '
        'exitForm
        '
        Me.exitForm.Image = Global.post_by_otens.My.Resources.Resources.icons8_filled_circle_16
        Me.exitForm.Location = New System.Drawing.Point(292, 2)
        Me.exitForm.Name = "exitForm"
        Me.exitForm.Size = New System.Drawing.Size(16, 16)
        Me.exitForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.exitForm.TabIndex = 2
        Me.exitForm.TabStop = False
        '
        'existingbtn
        '
        Me.existingbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.existingbtn.color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.existingbtn.colorActive = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.existingbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.existingbtn.Font = New System.Drawing.Font("Roboto Th", 13.2!, System.Drawing.FontStyle.Italic)
        Me.existingbtn.ForeColor = System.Drawing.Color.White
        Me.existingbtn.Image = CType(resources.GetObject("existingbtn.Image"), System.Drawing.Image)
        Me.existingbtn.ImagePosition = 17
        Me.existingbtn.ImageZoom = 50
        Me.existingbtn.LabelPosition = 35
        Me.existingbtn.LabelText = "Existing"
        Me.existingbtn.Location = New System.Drawing.Point(148, 22)
        Me.existingbtn.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.existingbtn.Name = "existingbtn"
        Me.existingbtn.Size = New System.Drawing.Size(163, 43)
        Me.existingbtn.TabIndex = 0
        '
        'newbtn
        '
        Me.newbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.newbtn.color = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.newbtn.colorActive = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.Font = New System.Drawing.Font("Roboto Th", 13.2!, System.Drawing.FontStyle.Italic)
        Me.newbtn.ForeColor = System.Drawing.Color.White
        Me.newbtn.Image = CType(resources.GetObject("newbtn.Image"), System.Drawing.Image)
        Me.newbtn.ImagePosition = 17
        Me.newbtn.ImageZoom = 50
        Me.newbtn.LabelPosition = 35
        Me.newbtn.LabelText = "New"
        Me.newbtn.Location = New System.Drawing.Point(0, 22)
        Me.newbtn.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(148, 43)
        Me.newbtn.TabIndex = 0
        '
        'popUpBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(310, 79)
        Me.Controls.Add(Me.exitForm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.existingbtn)
        Me.Controls.Add(Me.newbtn)
        Me.Font = New System.Drawing.Font("Roboto Cn", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "popUpBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.exitForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newbtn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents existingbtn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label1 As Label
    Friend WithEvents exitForm As PictureBox
End Class
