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
        Me.actualpass = New System.Windows.Forms.TextBox()
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MANAGER PIN"
        '
        'actualpass
        '
        Me.actualpass.Location = New System.Drawing.Point(37, 32)
        Me.actualpass.Name = "actualpass"
        Me.actualpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.actualpass.Size = New System.Drawing.Size(240, 22)
        Me.actualpass.TabIndex = 8
        Me.actualpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'managerVerifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 79)
        Me.Controls.Add(Me.actualpass)
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
    Friend WithEvents actualpass As TextBox
End Class
