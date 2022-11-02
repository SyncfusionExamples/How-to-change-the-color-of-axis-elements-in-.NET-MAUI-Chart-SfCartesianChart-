# How-to-change-the-color-of-axis-elements-in-.NET-MAUI-Chart-SfCartesianChart-

This article explains how to change the color of the axis elements in the [.NET MAUI charts](https://www.syncfusion.com/maui-controls/maui-charts).

The MAUI Cartesian chart provides support to customize the color of axis elements with the help of the [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html?tabs=tabid-1#Syncfusion_Maui_Charts_ChartAxis_LabelStyle), [AxisLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html?tabs=tabid-1#Syncfusion_Maui_Charts_ChartAxis_AxisLineStyle), [MajorGridLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MajorGridLineStyle), [MinorGridLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorGridLineStyle), [MajorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MajorTickStyle), and [MinorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorTickStyle) properties in the chart axis as shown in the following code example.

**[XAML]**
```
<chart:SfCartesianChart>
    <chart:SfCartesianChart.BindingContext>
        <viewModel:ViewModel />
    </chart:SfCartesianChart.BindingContext>

    <chart:SfCartesianChart.Resources>
        <chart:ChartAxisLabelStyle x:Key="axisLableStyle" TextColor="Red"/>
        <chart:ChartLineStyle x:Key="axisLineStyle" Stroke="Yellow" />
        <chart:ChartLineStyle x:Key="majorLineStyle" Stroke="Brown"/>
        <chart:ChartAxisTickStyle x:Key="majorTickStyle" Stroke="Brown"/>
        <chart:ChartLineStyle x:Key="minorLineStyle" Stroke="Gray"/>
        <chart:ChartAxisTickStyle x:Key="minorTickStyle" Stroke="Gray"/>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis  AxisLineStyle="{StaticResource axisLineStyle}"
                                              LabelStyle="{StaticResource axisLableStyle}"
                                              MajorGridLineStyle="{StaticResource majorLineStyle}"
                                              MajorTickStyle="{StaticResource majorTickStyle}" />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis MinorTicksPerInterval="2"
                                               AxisLineStyle="{StaticResource axisLineStyle}"
                                               LabelStyle="{StaticResource axisLableStyle}"
                                               MajorGridLineStyle="{StaticResource majorLineStyle}"
                                               MajorTickStyle="{StaticResource majorTickStyle}"
                                               MinorGridLineStyle="{StaticResource minorLineStyle}"
                                               MinorTickStyle="{StaticResource minorTickStyle}"  />
    </chart:SfCartesianChart.YAxes>

    <chart:SplineSeries XBindingPath="XValue"
                        YBindingPath="YValue"
                        ItemsSource="{Binding Data}"/>

</chart:SfCartesianChart>

```
**[C#]**
```
var chart = new SfCartesianChart();
ViewModel viewModel = new ViewModel();

//Initializing new style for the axis line, grid lines, tick lines and labels.
var axisLableStyle = new ChartAxisLabelStyle { TextColor = Colors.Red };
var axisLineStyle = new ChartLineStyle { Stroke = Colors.Yellow };
var majorLineStyle = new ChartLineStyle { Stroke = Colors.Brown };
var minorLineStyle = new ChartLineStyle { Stroke = Colors.Gray };
var majorTickStyle = new ChartAxisTickStyle { Stroke = Colors.Brown };
var minorTickStyle = new ChartAxisTickStyle { Stroke = Colors.Gray };

//Initializing XAxes
var xAxis = new CategoryAxis()
{
	LabelStyle = axisLableStyle,
	AxisLineStyle = axisLineStyle,
	MajorGridLineStyle = majorLineStyle,
	MajorTickStyle = majorTickStyle,
};
chart.XAxes.Add(xAxis);

//Initializing YAxes
var yAxis = new NumericalAxis()
{
              MinorTicksPerInterval = 2,
	LabelStyle = axisLableStyle,
	AxisLineStyle = axisLineStyle,
	MajorGridLineStyle = majorLineStyle,
	MinorGridLineStyle = minorLineStyle,
	MajorTickStyle = majorTickStyle,
	MinorTickStyle = minorTickStyle,
};
chart.YAxes.Add(yAxis);

var series = new SplineSeries()
{
	ItemsSource = viewModel.Data,
	XBindingPath = "XValue",
	YBindingPath = "YValue",
};

chart.Series.Add(series);

```

![Axis elements customization](https://user-images.githubusercontent.com/61832185/199484950-6b067835-2313-49ca-9829-8f264c1344e4.png)

This user guide [Documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started) helps you to acquire more knowledge on the MAUI cartesian charts and their features. You can also refer to the [Feature Tour](https://www.syncfusion.com/maui-controls/maui-charts) site to get an overview of all the features in the   chart.

KB article - [How to change the color of axis elements in .NET MAUI Chart (SfCartesianChart)?]( )