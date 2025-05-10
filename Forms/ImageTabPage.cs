using Apo.DTO;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;
using System.Drawing;

namespace Apo.customUI
{
    public class ImageTabPage : TabPage
    {
        private ImageAndHistory picBox;
        private ImageData imageData;
        public ImageTabPage(Mat img, ImageType type, string fileName)
        {
            imageData = new ImageData(img, type, fileName);
            Initialize();
        }
        public ImageData GetImageData() => imageData;

        public void Initialize()
        {
            picBox = new ImageAndHistory() { Dock = DockStyle.Fill };
            picBox.RedrawImage(imageData);

            picBox.NodeDoubleClick += imageData.Restore;//If node in tree is double-clicked, image from node is restored ( Jpeg restore with 10% loses ) 

            imageData.UpdateHistoryEvent += picBox.UpdateLog; // history tree updated after successful strategy execution  <| it differs from data updated bc it serves for live updates (for example histogram)

            imageData.DataUpdated += picBox.RedrawImage; // image updated => picBox redraw image

            imageData.UpdateHistory("Input"); // Register input ( initial ) operation in history ( stored image is JPEG 90% )
            Controls.Add(picBox);
        }

        public ImageTabPage Clone()
        {
            ImageTabPage clone = new ImageTabPage(imageData.Image.Clone(), imageData.Type, "_" + imageData.fileName) { Name = Name, Text = Text };
            return clone;
        }
    }
}
