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
        <chart:ChartAxisLabelStyle x:Key="xAxisLableStyle" TextColor="Red"/>
        <chart:ChartAxisLabelStyle x:Key="yAxisLableStyle" TextColor="Blue"/>
        <chart:ChartLineStyle x:Key="majorLineStyle" Stroke="Gray"/>
        <chart:ChartAxisTickStyle x:Key="majorTickStyle" Stroke="Gray"/>
        <chart:ChartLineStyle x:Key="minorLineStyle" Stroke="Gray" StrokeDashArray="2 2"/>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.XAxes>
           <chart:CategoryAxis LabelStyle="{StaticResource xAxisLableStyle}"
                               ShowMajorGridLines="False">
          <chart:CategoryAxis.Title>
               <chart:ChartAxisTitle Text="Brand" TextColor="Red"/>
          </chart:CategoryAxis.Title>
      </chart:CategoryAxis>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis MinorTicksPerInterval="1"
                                 LabelStyle="{StaticResource yAxisLableStyle}"
                                 MajorGridLineStyle="{StaticResource majorLineStyle}
                                 MajorTickStyle="{StaticResource majorTickStyle}"
                                 MinorGridLineStyle="{StaticResource minorLineStyle}">
                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle Text="Number of items sold" TextColor="Blue"/>
                </chart:NumericalAxis.Title>
            </chart:NumericalAxis>/>
    </chart:SfCartesianChart.YAxes>

    <chart:ColumnSeries XBindingPath="XValue"
                        YBindingPath="YValue"
                        ItemsSource="{Binding Data}"/>

</chart:SfCartesianChart>

```
**[C#]**
```
var chart = new SfCartesianChart();
ViewModel viewModel = new ViewModel();

//Initializing new style for the axis line, grid lines, tick lines and labels.
var xAxisLableStyle = new ChartAxisLabelStyle { TextColor = Colors.Red };
var yAxisLableStyle = new ChartAxisLabelStyle { TextColor = Colors.Blue };
var majorLineStyle = new ChartLineStyle { Stroke = Colors.Gray };
var minorLineStyle = new ChartLineStyle { Stroke = Colors.Gray, StrokeDashArray = new DoubleCollection() { 2, 2 } };
var majorTickStyle = new ChartAxisTickStyle { Stroke = Colors.Gray };
var xAxisTitle = new ChartAxisTitle() { Text = "Brand", TextColor = Colors.Red,};
var yAxisTitle = new ChartAxisTitle() { Text = " Number of items sold", TextColor = Colors.Blue,};

//Initializing XAxes
var xAxis = new CategoryAxis()
{
	LabelStyle = xAxisLableStyle,
    Title = xAxisTitle,
    ShowMajorGridLines = false,
};
chart.XAxes.Add(xAxis);

//Initializing YAxes
var yAxis = new NumericalAxis()
{
    MinorTicksPerInterval = 2,
	LabelStyle = yAxisLableStyle,
	MajorGridLineStyle = majorLineStyle,
	MinorGridLineStyle = minorLineStyle,
	MajorTickStyle = majorTickStyle,
    Title = yAxisTitle,
};
chart.YAxes.Add(yAxis);

var series = new ColumnSeries()
{
    ItemsSource = viewModel.Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
};

chart.Series.Add(series);

```

![Axis elements customization](https://user-images.githubusercontent.com/61832185/201011516-954e603f-eb74-42ee-812c-e3ca0a376813.png)

This user guide [Documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started) helps you to acquire more knowledge on the MAUI cartesian charts and their features. You can also refer to the [Feature Tour](https://www.syncfusion.com/maui-controls/maui-charts) site to get an overview of all the features in the   chart.

KB article - [How to change the color of axis elements in .NET MAUI Chart (SfCartesianChart)?]( )