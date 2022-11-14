# How-to-change-the-color-of-axis-elements-in-.NET-MAUI-Chart-SfCartesianChart-

This article explains how to change the color of the axis elements in the [.NET MAUI charts](https://www.syncfusion.com/maui-controls/maui-charts).

The MAUI Cartesian chart provides support to customize the color of axis elements with the help of the [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html?tabs=tabid-1#Syncfusion_Maui_Charts_ChartAxis_LabelStyle), [AxisLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html?tabs=tabid-1#Syncfusion_Maui_Charts_ChartAxis_AxisLineStyle), [MajorGridLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MajorGridLineStyle), [MinorGridLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorGridLineStyle), [MajorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MajorTickStyle), [MinorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorTickStyle), and [CrossesAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_CrossesAt) properties in the chart axis as shown in the following code example.

**[XAML]**
```
<chart:SfCartesianChart>
    <chart:SfCartesianChart.BindingContext>
        <viewModel:ViewModel />
    </chart:SfCartesianChart.BindingContext>

    <!--Initializing new style for the axis line, grid lines, tick lines and labels.-->
    <chart:SfCartesianChart.Resources>
            <chart:ChartAxisLabelStyle x:Key="xAxisLableStyle" LabelFormat="HH"/>
            <chart:ChartAxisLabelStyle x:Key="yAxis1LableStyle" TextColor="Blue" LabelFormat="0rpm"/>
            <chart:ChartAxisLabelStyle x:Key="yAxis2LableStyle" TextColor="Green" LabelFormat="0psi"/>
            <chart:ChartLineStyle x:Key="majorLineStyle" Stroke="Gray"/>
            <chart:ChartAxisTickStyle x:Key="majorTickStyle" Stroke="Gray"/>
            <chart:ChartLineStyle x:Key="minorLineStyle" Stroke="Gray" StrokeDashArray="2 2"/>
            <chart:ChartLineStyle x:Key="yAxis1LineStyle" Stroke="Blue"/>
            <chart:ChartLineStyle x:Key="yAxis2LineStyle" Stroke="Green"/>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.Legend>
        <chart:ChartLegend />
    </chart:SfCartesianChart.Legend>

    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis ShowMajorGridLines="False"
                            Interval="1" IntervalType="Hours"
                            LabelStyle="{StaticResource xAxisLableStyle}" >
            <chart:DateTimeAxis.Title>
                <chart:ChartAxisTitle Text="Time in hours" />
            </chart:DateTimeAxis.Title>
        </chart:DateTimeAxis>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis Name="yAxis1" MinorTicksPerInterval="1"
                             Minimum="0" Maximum="6000" Interval="1000"
                             LabelStyle="{StaticResource yAxis1LableStyle}"
                             MajorGridLineStyle="{StaticResource majorLineStyle}"
                             MajorTickStyle="{StaticResource majorTickStyle}"
                             MinorGridLineStyle="{StaticResource minorLineStyle}"
                             AxisLineStyle="{StaticResource yAxis1LineStyle}">
       </chart:NumericalAxis>

       <chart:NumericalAxis Name="yAxis2"
                            Minimum="55" Maximum="85" Interval="5" 
                            AxisLineStyle="{StaticResource yAxis2LineStyle}"
                            LabelStyle="{StaticResource yAxis2LableStyle}"
                            ShowMajorGridLines="False"
                            CrossesAt="{Static x:Double.MaxValue}">
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>

    <chart:LineSeries ItemsSource="{Binding Data}"
                      XBindingPath="Time"
                      YBindingPath="Speed"
                      Label="Speed" Fill="Blue" />

        <chart:SplineSeries ItemsSource="{Binding Data}"
                            XBindingPath="Time" 
                            YBindingPath="Pressure" 
                            Label="Pressure" Fill="Green"
                             YAxisName="yAxis2"/>

</chart:SfCartesianChart>

```
**[C#]**
```
var chart = new SfCartesianChart();
ViewModel viewModel = new ViewModel();

//Initializing new style for the axis line, grid lines, tick lines and labels.
var xAxisLabelStyle = new ChartAxisLabelStyle { LabelFormat = "HH" };
var xAxisTitle = new ChartAxisTitle { Text = "Time in hours" };
var yAxis1LableStyle = new ChartAxisLabelStyle { TextColor = Colors.Blue, LabelFormat = "0rpm" };
var yAxis2LableStyle = new ChartAxisLabelStyle { TextColor = Colors.Green, LabelFormat = "0psi" };
var majorLineStyle = new ChartLineStyle { Stroke = Colors.Gray };
var minorLineStyle = new ChartLineStyle { Stroke = Colors.Gray, StrokeDashArray = new DoubleCollection() { 2, 2 } };
var majorTickStyle = new ChartAxisTickStyle { Stroke = Colors.Gray };
var yAxis1LineStyle = new ChartLineStyle { Stroke = Colors.Blue };
var yAxis2LineStyle = new ChartLineStyle { Stroke = Colors.Green };

//Initializing XAxes
var xAxis = new DateTimeAxis()
{
	LabelStyle = xAxisLabelStyle,
	Title = xAxisTitle,
	ShowMajorGridLines = false,
};
chart.XAxes.Add(xAxis);

//Initializing YAxes
var yAxis1 = new NumericalAxis()
{
	Name = "yAxis1",
	Minimum = 0, Maximum = 6000, Interval = 1000,
	MinorTicksPerInterval = 2,
	LabelStyle = yAxis1LableStyle,
	MajorGridLineStyle = majorLineStyle,
	MinorGridLineStyle = minorLineStyle,
	MajorTickStyle = majorTickStyle,
	AxisLineStyle = yAxis1LineStyle,
};

var yAxis2 = new NumericalAxis()
{
	Name = "yAxis2",
	Minimum = 55, Maximum = 85, Interval = 5,
	AxisLineStyle = yAxis2LineStyle,
	LabelStyle = yAxis2LableStyle,
	ShowMajorGridLines = false,
	CrossesAt = double.MaxValue,
};

chart.YAxes.Add(yAxis1);
chart.YAxes.Add(yAxis2);

var series1 = new LineSeries()
{
	ItemsSource = viewModel.Data,
	XBindingPath = "Time",
	YBindingPath = "Speed",
	Label = "Speed",
	Fill = Colors.Blue
};

var series2 = new LineSeries()
{
	ItemsSource = viewModel.Data,
	XBindingPath = "Time",
	YBindingPath = "Pressure",
	Label = "Pressure",
	Fill = Colors.Green,
	YAxisName = "yAxis2"
};

chart.Series.Add(series1);
chart.Series.Add(series2);

this.Content = chart;

```

![Axis elements customization](https://user-images.githubusercontent.com/61832185/201659851-54e4fa22-6abc-4402-b6c9-8bef371bc3eb.png)

This user guide [Documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started) helps you to acquire more knowledge on the MAUI cartesian charts and their features. You can also refer to the [Feature Tour](https://www.syncfusion.com/maui-controls/maui-charts) site to get an overview of all the features in the   chart.
