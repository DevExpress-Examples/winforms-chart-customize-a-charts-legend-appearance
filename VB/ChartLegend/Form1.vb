Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace ChartLegend
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create an empty chart.
            Dim chartControl1 As New ChartControl()

            ' Create a series and add points to it.
            Dim series1 As New Series("Series 1", ViewType.Bar)
            series1.Points.Add(New SeriesPoint("A", New Double() { 4 }))
            series1.Points.Add(New SeriesPoint("B", New Double() { 2 }))
            series1.Points.Add(New SeriesPoint("C", New Double() { 17 }))
            series1.Points.Add(New SeriesPoint("D", New Double() { 4 }))
            series1.Points.Add(New SeriesPoint("E", New Double() { 17 }))
            series1.Points.Add(New SeriesPoint("F", New Double() { 12 }))
            series1.Points.Add(New SeriesPoint("G", New Double() { 15 }))

            ' Add the series to the chart.
            chartControl1.Series.Add(series1)

            ' Create a constant line (optional).
            Dim constantLine1 As New ConstantLine("Constant Line 1")
            CType(chartControl1.Diagram, XYDiagram).AxisY.ConstantLines.Add(constantLine1)
            constantLine1.AxisValue = 4.5

            ' Create a strip (optional).
            Dim strip1 As New Strip("Strip 1")
            CType(chartControl1.Diagram, XYDiagram).AxisY.Strips.Add(strip1)
            strip1.MaxLimit.AxisValue = 15
            strip1.MinLimit.AxisValue = 7.5

            ' Customize the strip's and constant line's legend appearance.
            strip1.ShowInLegend = True
            constantLine1.ShowInLegend = True
            constantLine1.LegendText = "Some Threshold"

            ' Display the chart control's legend.
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True

            ' Define its horizontal and vertical alignment.
            chartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
            chartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.Top

            ' Define the layout of items within the legend.
            chartControl1.Legend.Direction = LegendDirection.LeftToRight
            chartControl1.Legend.EquallySpacedItems = True
            chartControl1.Legend.HorizontalIndent = 4
            chartControl1.Legend.VerticalIndent = 4
            chartControl1.Legend.TextOffset = 4

            ' Define the limits for the legend to occupy the chart's space.
            chartControl1.Legend.MaxHorizontalPercentage = 50
            chartControl1.Legend.MaxVerticalPercentage = 50

            ' Define the legend markers' options.
            chartControl1.Legend.MarkerVisible = True
            chartControl1.Legend.MarkerSize = New Size(20, 20)

            ' Customize the legend appearance.
            chartControl1.Legend.BackColor = Color.LightBlue
            chartControl1.Legend.FillStyle.FillMode = FillMode.Empty

            chartControl1.Legend.Border.Color = Color.DarkBlue
            chartControl1.Legend.Border.Thickness = 2
            chartControl1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True

            chartControl1.Legend.Shadow.Visible = True
            chartControl1.Legend.Shadow.Color = Color.LightGray
            chartControl1.Legend.Shadow.Size = 2

            ' Customize the legend text properties.
            chartControl1.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.False
            chartControl1.Legend.Font = New Font(Me.Font.FontFamily.Name, 9, FontStyle.Bold)
            chartControl1.Legend.TextColor = Color.DarkBlue

            ' Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill
            Me.Controls.Add(chartControl1)
        End Sub

    End Class
End Namespace