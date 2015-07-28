using System;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using Syncfusion.SfChart.XForms;
using System.Collections.Generic;

namespace MosquitoTrapCount
{
    public class YTDAvgChartView : ContentPage
    {
        public YTDAvgChartView()
        {
            Title = "Charts";
            DailyAvgDataPoints = new ObservableCollection<ChartDataPoint>();
            GetData();
        }

        private SfChart GetChart()
        {

            var chart = new SfChart
                {
                    Legend = new ChartLegend {ToggleSeriesVisibility = true},
                    PrimaryAxis = new DateTimeAxis
                        {
                            EdgeLabelsDrawingMode = EdgeLabelsDrawingMode.Shift,
                            LabelRotationAngle = -45,
                            LabelStyle = {LabelFormat = "MM/dd/yyyy"},
                            Title = {Text = "Sampling Date"},
                        },
                    SecondaryAxis = new NumericalAxis {Title = {Text = "Trap Count"}}
                };

            chart.Series.Add(new LineSeries()
                {
                    Label = "Daily Avg Count",
                    ItemsSource = DailyAvgDataPoints
                });
           
            return chart;
        }

        public ObservableCollection<ChartDataPoint> DailyAvgDataPoints { get; set;}
               
        public async void GetData()
        {
            var results = await CityOfBrandonApi.GetAll2015();

            foreach (var record in results)
            {
                DailyAvgDataPoints.Add(new ChartDataPoint(record.SamplingDate, record.DailyAvgCount));
            }


            Content = GetChart();
        }
    }
}


