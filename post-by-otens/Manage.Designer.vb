<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manage
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
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxApiCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(327, 313)
        Me.ButtonSend.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(113, 52)
        Me.ButtonSend.TabIndex = 10
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 275)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ApiCode"
        '
        'TextBoxApiCode
        '
        Me.TextBoxApiCode.Location = New System.Drawing.Point(248, 272)
        Me.TextBoxApiCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxApiCode.Name = "TextBoxApiCode"
        Me.TextBoxApiCode.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxApiCode.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Number"
        '
        'TextBoxMessage
        '
        Me.TextBoxMessage.Location = New System.Drawing.Point(248, 107)
        Me.TextBoxMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxMessage.Multiline = True
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.Size = New System.Drawing.Size(268, 157)
        Me.TextBoxMessage.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Number"
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Location = New System.Drawing.Point(248, 75)
        Me.TextBoxNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(268, 22)
        Me.TextBoxNumber.TabIndex = 6
        '
        'Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxApiCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Manage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSend As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxApiCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMessage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNumber As TextBox
End Class
