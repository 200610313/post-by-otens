<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tempForm
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
        Me.dateStart = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.SuspendLayout()
        '
        'dateStart
        '
        Me.dateStart.BackColor = System.Drawing.Color.SeaGreen
        Me.dateStart.BorderRadius = 0
        Me.dateStart.ForeColor = System.Drawing.Color.White
        Me.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateStart.FormatCustom = Nothing
        Me.dateStart.Location = New System.Drawing.Point(350, 54)
        Me.dateStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(404, 44)
        Me.dateStart.TabIndex = 0
        Me.dateStart.Value = New Date(2020, 2, 25, 11, 31, 58, 558)
        '
        'tempForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dateStart)
        Me.Name = "tempForm"
        Me.Text = "tempForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dateStart As Bunifu.Framework.UI.BunifuDatepicker
End Class
