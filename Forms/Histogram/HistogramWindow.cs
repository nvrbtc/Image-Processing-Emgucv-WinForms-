using Apo.DTO;

namespace Apo.customUI
{
    public partial class HistogramWindow : Form
    {
        private ImageData? imageData;
        public HistogramWindow()
        {
            InitializeComponent();
        }

        public void SetImageData(ImageData imgData)
        {
            imageData = imgData;
            imageData.DataUpdated += UpdateHistogram;
            UpdateHistogram(imgData);
        }

        private void UpdateHistogram(ImageData imgData)
        {
            if (IsDisposed || imgData?.ValidateValuesAreNull() == true || imgData?.Type != ImageType.Gray) return;
            dataGrid.Rows.Clear();
            distSeries.Points.Clear();
            histSeries.Points.Clear();
            int[] histogramValues = imgData.Image.GetHistogramValues();
            int[] distribution = imgData.Image.GetDistributionValues();
            distSeries.Points.DataBindXY(Enumerable.Range(0, 256).ToArray(), distribution);
            histSeries.Points.DataBindXY(Enumerable.Range(0, 256).ToArray(), histogramValues);

            for (int i = 0; i < 256; i++)
            {
                dataGrid.Rows.Add(i, histogramValues[i]);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (imageData != null)
            {
                imageData.DataUpdated -= UpdateHistogram;
                imageData = null;
            }
            base.OnFormClosing(e);
        }
    }
}