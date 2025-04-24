using APO_Tsarehradskiy.Extensions;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO_Tsarehradskiy.customUI
{
    public partial class HistogramWindow : Form
    {
        private ImageData imageData;

        public HistogramWindow()
        {
            InitializeComponent();
            //UpdateHistogram(img);
        }

        public void SetImageData(ImageData imageData)
        {
            this.imageData = imageData;
            imageData.UpdateEvent += UpdateHistogram;
            UpdateHistogram(imageData.Image);
        }
        public void UpdateHistogram(Mat img)
        {
            chartImg.Series.Clear();
            chartImg.Legends.Clear();
            chartImg.ChartAreas.Clear();

            dataGrid.Rows.Clear();

            int[] histogramValues = img.GetHistogramValues();
            int[] distribution = img.GetDistributionValues();


            Series hist = new Series("Histogram")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Black,

            };

            Series dist = new Series("Distribution")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Red
            };

            dist.Points.DataBindXY(Enumerable.Range(0, 256).ToArray(), distribution);
            hist.Points.DataBindXY(Enumerable.Range(0, 256).ToArray(), histogramValues);

            for ( int i = 0; i < 256; i++ )
            {
                dataGrid.Rows.Add(i, histogramValues[i]);
            }

            chartImg.ChartAreas.Add(new ChartArea("Histogram"));
            chartImg.ChartAreas["Histogram"].AxisX.Minimum = 0;
            chartImg.ChartAreas["Histogram"].AxisX.Maximum = 255;
            chartImg.ChartAreas["Histogram"].AxisY2.Enabled = AxisEnabled.True;

            dist.YAxisType = AxisType.Secondary;

            chartImg.Series.Add(dist);
            chartImg.Series.Add(hist);
        }

        

    }
}
