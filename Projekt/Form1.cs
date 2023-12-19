using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Reflection;

namespace Projekt
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void ClearChartBtn_Click(object sender, EventArgs e)
        {
            Chart.Series.Clear();
            progressBar.Value = 0;
        }
        private void AddToChartBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(PointsBox.Text, out int points);
            int.TryParse(ElementsBox.Text, out int maxElements);

            Stopwatch sortTime = new Stopwatch();
            GenerateNumbers numbers;
            ChartSeries chart = new ChartSeries(Chart);

            int elements = maxElements / points;
            string series;

            // generate chart
            for (int i = 1; i <= points; i++)
            {
                numbers = new GenerateNumbers(elements * i);

                // elements in array order
                if (DescendingOrderBtn.Checked)
                {
                    series = "Desc";
                    numbers.Descending();
                }
                else if (AscendingOrderBtn.Checked)
                {
                    series = "Asc";
                    numbers.Ascending();
                }
                else
                {
                    series = "Rand";
                    numbers.Random();
                }

                sortTime.Restart();

                // Sort type
                if (BubbleBtn.Checked)
                {
                    series += "Bubble";
                    new BubbleSort(numbers.Array);
                }
                else if (MergeBtn.Checked)
                {
                    series += "Merge";
                    new MergeSort(numbers.Array);
                }
                else if (QuickBtn.Checked)
                {
                    series += "Quick";
                    new QuickSort(numbers.Array);
                }
                else if (SelectionBtn.Checked)
                {
                    series += "Selection";
                    new SelectionSort(numbers.Array);
                }
                else
                {
                    series += "Insertion";
                    new InsertionSort(numbers.Array);
                }

                Console.WriteLine($"TIME: {sortTime.ElapsedMilliseconds} | ELEMENTS: {elements * i}");
                progressBar.Increment(100/points);
                chart.AddPoint($"{series + counter}", elements * i, sortTime.ElapsedMilliseconds);
            }

            progressBar.Value = 0;
            counter++;
        }
    }
}
