using System.ComponentModel;
using Emgu.CV;
using System.Windows.Forms.DataVisualization.Charting;
using Apo.DTO;
using APO_Tsarehradskiy.Services.Realization;

namespace Apo.customUI
{
    public partial class DrawLineExample : Form
    {

        private readonly byte[,]? data ;
        private readonly RoiHandler roiHandler;
        private readonly ImageData imageData;
        private Series hist;
        public DrawLineExample(ImageData imageData)
        {
            InitializeComponent();
            this.imageData = imageData;
            data = imageData.Image.GetData() as  byte[,];
            roiHandler = new RoiHandler(this.pcBox);
            roiHandler.NotifyLineMoved += UpdateRoi;

            Bind();
        }
        private void Bind()
        {


            chROI.Series?.Clear();
            chROI.Legends?.Clear();
            chROI.ChartAreas?.Clear();

            chROI.ChartAreas?.Add(new ChartArea("Histogram"));

            Series seriesHist = new Series("Histogram")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Black,

            };
            this.hist = seriesHist;
            chROI?.Series?.Add(seriesHist);
            pcBox.Image = imageData.Image.ToBitmap();
            pcBox.MouseDown += roiHandler.MouseDownEvent;
            pcBox.MouseUp += roiHandler.MouseUpEvent;
            pcBox.MouseMove += roiHandler.MouseMoveEvent;
            pcBox.Paint += roiHandler.PaintEvent;
            this.KeyPress += roiHandler.KeyPressEvent;

        }


        private async void UpdateRoi(List<Point> points)
        {
            if (imageData.Type != ImageType.Gray || points?.Count == 0) return;

            List<int> values2Display = new();

            await Task.Run(() =>
            {
                foreach (Point p in points)
                {
                    if (p.X <= 0 || p.Y <= 0 || p.X > imageData.Image.Cols || p.Y > imageData.Image.Rows) continue;
                    values2Display.Add(data![p.Y - 1, p.X - 1]);
                }
            });
            hist.Points.Clear();
            hist.Points.DataBindXY(Enumerable.Range(0, values2Display.Count).ToArray(), values2Display);
            chROI.ChartAreas["Histogram"].AxisX.Minimum = 0;
            chROI.ChartAreas["Histogram"].AxisX.Maximum = values2Display.Count - 1;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (roiHandler != null)
            {
                roiHandler.NotifyLineMoved -= UpdateRoi;
                pcBox.MouseDown -= roiHandler.MouseDownEvent;
                pcBox.MouseUp -= roiHandler.MouseUpEvent;
                pcBox.MouseMove -= roiHandler.MouseMoveEvent;
                pcBox.Paint -= roiHandler.PaintEvent;
                this.KeyPress -= roiHandler.KeyPressEvent;
            }

            base.OnClosing(e);
        }

    }
}
