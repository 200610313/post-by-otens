<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class shoppingCartItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.included = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.pSubTotal = New System.Windows.Forms.Label()
        Me.pCount = New System.Windows.Forms.Label()
        Me.pName = New System.Windows.Forms.Label()
        Me.pNum = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'included
        '
        Me.included.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.included.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.included.Checked = True
        Me.included.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.included.ForeColor = System.Drawing.Color.White
        Me.included.Location = New System.Drawing.Point(462, 5)
        Me.included.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.included.Name = "included"
        Me.included.Size = New System.Drawing.Size(20, 20)
        Me.included.TabIndex = 1
        '
        'pSubTotal
        '
        Me.pSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.pSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pSubTotal.Location = New System.Drawing.Point(289, 32)
        Me.pSubTotal.Name = "pSubTotal"
        Me.pSubTotal.Size = New System.Drawing.Size(193, 23)
        Me.pSubTotal.TabIndex = 2
        Me.pSubTotal.Text = "PHP100.00"
        Me.pSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pCount
        '
        Me.pCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.pCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pCount.Location = New System.Drawing.Point(-34, 32)
        Me.pCount.Name = "pCount"
        Me.pCount.Size = New System.Drawing.Size(101, 23)
        Me.pCount.TabIndex = 2
        Me.pCount.Text = "123x"
        Me.pCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pName
        '
        Me.pName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.pName.ForeColor = System.Drawing.Color.White
        Me.pName.Location = New System.Drawing.Point(61, 27)
        Me.pName.Name = "pName"
        Me.pName.Size = New System.Drawing.Size(206, 34)
        Me.pName.TabIndex = 2
        Me.pName.Text = "gw"
        Me.pName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pNum
        '
        Me.pNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.pNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pNum.Location = New System.Drawing.Point(17, 7)
        Me.pNum.Name = "pNum"
        Me.pNum.Size = New System.Drawing.Size(127, 23)
        Me.pNum.TabIndex = 2
        Me.pNum.Text = "#213"
        Me.pNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(-15, -13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(30, 120)
        Me.Panel1.TabIndex = 3
        '
        'shoppingCartItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pName)
        Me.Controls.Add(Me.pCount)
        Me.Controls.Add(Me.pNum)
        Me.Controls.Add(Me.pSubTotal)
        Me.Controls.Add(Me.included)
        Me.Name = "shoppingCartItem"
        Me.Size = New System.Drawing.Size(487, 82)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents included As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents pName As Label
    Friend WithEvents pCount As Label
    Friend WithEvents pSubTotal As Label
    Friend WithEvents pNum As Label
    Friend WithEvents Panel1 As Panel
End Class
