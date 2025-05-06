using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using Emgu.CV;

namespace APO_Tsarehradskiy.customUI
{
    public class ImageTabPage : TabPage
    {
        private ImageAndHistory picBox;
        public ImageData imageData;
        public ImageTabPage(Mat img, Enums type, string fileName) : base()
        {
            imageData = new ImageData(img, type, fileName);
            InitializeBoxAndSetEvents();
        }
        private void InitializeBoxAndSetEvents()
        {
            picBox = new ImageAndHistory() { Dock = DockStyle.Fill };
            Controls.Add(picBox);
            picBox.RedrawImage(imageData);

            picBox.NodeDoubleClic += imageData.Restore;//If node in tree is double clicked, image from node is restored ( Jpeg restore with 10% loses ) 

            imageData.UpdateHistoryEvent += picBox.UpdateLog; // history tree updated after succesfull strategy execution  <| it differs from data updated bc it serves for live updates (for example histogram)

            imageData.DataUpdated += picBox.RedrawImage; // image updated => picBox redraw image

            imageData.UpdateHistory("Input"); // Register input ( initial ) operation in history ( stored image is JPEG 90% )
        }
        public ImageTabPage Clone()
        {
            ImageTabPage clone = new ImageTabPage(imageData.Image.Clone(), imageData.Type, "_" + imageData.fileName) { Name = $"_{Name}", Text = $"_{Text}" };
            return clone;
        }
    }
}
