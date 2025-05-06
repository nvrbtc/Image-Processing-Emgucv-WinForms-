using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using Emgu.CV;
using System.Windows.Forms.DataVisualization.Charting;

namespace APO_Tsarehradskiy.customUI
{
    public partial class DrawLineExample : Form
    {

        private readonly RoiHandler roiHandler;
        private readonly ImageData imageData;
        private Series hist;
        public DrawLineExample(ImageData imageData)
        {
            InitializeComponent();
            this.imageData = imageData;
            roiHandler = new RoiHandler(this.pcBox);
            roiHandler.NotifyLineMoved += UpdateROI;

            Bind();
        }
        private void Bind()
        {


            chROI.Series?.Clear();
            chROI.Legends?.Clear();
            chROI.ChartAreas?.Clear();

            chROI.ChartAreas.Add(new ChartArea("Histogram") { });

            Series hist = new Series("Histogram")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Black,

            };
            this.hist = hist;
            chROI.Series.Add(hist);
            pcBox.Image = imageData.Image.ToBitmap();
            pcBox.MouseDown += roiHandler.MouseDownEvent;
            pcBox.MouseUp += roiHandler.MouseUpEvent;
            pcBox.MouseMove += roiHandler.MouseMoveEvent;
            pcBox.Paint += roiHandler.PaintEvent;
            this.KeyPress += roiHandler.KeyPressEvent;

        }
       

        public async void UpdateROI(List<Point> points)
        {
            if (imageData.Type != Enums.Gray || points?.Count == 0) return;

            byte[,] data = imageData.Image.GetData() as byte[,];
            List<int> values2Display = new();

            await Task.Run(() =>
            {
                foreach (Point p in points)
                {
                    if (p.X <= 0 || p.Y <= 0 || p.X > imageData.Image.Cols || p.Y > imageData.Image.Rows) continue;
                    values2Display.Add(data[p.Y - 1, p.X -1 ]);
                }
            });
            hist.Points.DataBindXY(Enumerable.Range(0, values2Display.Count).ToArray(), values2Display);

            chROI.ChartAreas["Histogram"].AxisX.Minimum = 0;
            chROI.ChartAreas["Histogram"].AxisX.Maximum = values2Display.Count - 1;



        }
    }
}
