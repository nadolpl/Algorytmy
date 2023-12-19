using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Projekt
{
    internal class ChartSeries
    {
        private Chart chart;
        public ChartSeries(Chart chart)
        {
            this.chart = chart;
        }

        private void AddSeries(string name)
        {
            Series series = new Series(name)
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 3
            };

            chart.Series.Add(series);
        }

        public void AddPoint(string series, int index, long time)
        {
            if (chart.Series.FindByName(series) == null) AddSeries(series);

            chart.Series[series].Points.AddXY(index, time);
        }
    }
}
