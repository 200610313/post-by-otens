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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.dateStart = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BunifuSlider1 = New Bunifu.Framework.UI.BunifuSlider()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateStart
        '
        Me.dateStart.BackColor = System.Drawing.Color.SeaGreen
        Me.dateStart.BorderRadius = 0
        Me.dateStart.ForeColor = System.Drawing.Color.White
        Me.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateStart.FormatCustom = Nothing
        Me.dateStart.Location = New System.Drawing.Point(390, 3)
        Me.dateStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(404, 44)
        Me.dateStart.TabIndex = 0
        Me.dateStart.Value = New Date(2020, 2, 20, 11, 31, 0, 0)
        '
        'Chart1
        '
        ChartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisX.Title = "DATE"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.Title = "Quantity"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(12, 90)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(782, 300)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'BunifuSlider1
        '
        Me.BunifuSlider1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray
        Me.BunifuSlider1.BorderRadius = 0
        Me.BunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen
        Me.BunifuSlider1.Location = New System.Drawing.Point(135, 456)
        Me.BunifuSlider1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSlider1.MaximumValue = 15
        Me.BunifuSlider1.Name = "BunifuSlider1"
        Me.BunifuSlider1.Size = New System.Drawing.Size(553, 30)
        Me.BunifuSlider1.TabIndex = 2
        Me.BunifuSlider1.Value = 6
        '
        'tempForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.BunifuSlider1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.dateStart)
        Me.Name = "tempForm"
        Me.Text = "tempForm"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dateStart As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents BunifuSlider1 As Bunifu.Framework.UI.BunifuSlider
End Class
