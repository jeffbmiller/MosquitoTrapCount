using System;

using Xamarin.Forms;
using Syncfusion.SfChart.XForms;
using System.Collections.ObjectModel;
using System.Linq;
using MosquitoTrapCount.PCL;

namespace MosquitoTrapCount
{
    public class YTDTrapsChartView : ContentPage
    {
        public YTDTrapsChartView()
        {
            Title = "Charts";
            Trap1DataPoints = new ObservableCollection<ChartDataPoint>();
            Trap2DataPoints = new ObservableCollection<ChartDataPoint>();
            Trap3DataPoints = new ObservableCollection<ChartDataPoint>();
            Trap4DataPoints = new ObservableCollection<ChartDataPoint>();
            Trap5DataPoints = new ObservableCollection<ChartDataPoint>();
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
//                            Interval = 2,
//                            IntervalType = DateTimeIntervalType.Months,
                            LabelRotationAngle = -45,
                            LabelStyle = {LabelFormat = "MM/dd/yyyy"},
                            Title = {Text = "Sampling Date"},
                        },
                    SecondaryAxis = new NumericalAxis {Title = {Text = "Trap Count"}}
                };

           
            chart.Series.Add(new LineSeries()
                {
                    Label = "Trap 1 Count",
                    ItemsSource = Trap1DataPoints
                });
            chart.Series.Add(new LineSeries()
                {
                    Label = "Trap 2 Count",
                    ItemsSource = Trap2DataPoints
                });
            chart.Series.Add(new LineSeries()
                {
                    Label = "Trap 3 Count",
                    ItemsSource = Trap3DataPoints
                });
            chart.Series.Add(new LineSeries()
                {
                    Label = "Trap 4 Count",
                    ItemsSource = Trap4DataPoints
                });
            chart.Series.Add(new LineSeries()
                {
                    Label = "Trap 5 Count",
                    ItemsSource = Trap5DataPoints
                });
            return chart;
        }

        public ObservableCollection<ChartDataPoint> Trap1DataPoints { get; set;}
        public ObservableCollection<ChartDataPoint> Trap2DataPoints { get; set;}
        public ObservableCollection<ChartDataPoint> Trap3DataPoints { get; set;}
        public ObservableCollection<ChartDataPoint> Trap4DataPoints { get; set;}
        public ObservableCollection<ChartDataPoint> Trap5DataPoints { get; set;}

        public async void GetData()
        {
            var results = await CityOfBrandonApi.GetAll2015();

            foreach (var record in results)
            {                
                Trap1DataPoints.Add(new ChartDataPoint(record.SamplingDate, record.Trap1));
                Trap2DataPoints.Add(new ChartDataPoint(record.SamplingDate, record.Trap2));
                Trap3DataPoints.Add(new ChartDataPoint(record.SamplingDate, record.Trap3));
                Trap4DataPoints.Add(new ChartDataPoint(record.SamplingDate, record.Trap4));
                Trap5DataPoints.Add(new ChartDataPoint(record.SamplingDate, record.Trap5));
            }
                    

            Content = GetChart();
        }
    }
}


