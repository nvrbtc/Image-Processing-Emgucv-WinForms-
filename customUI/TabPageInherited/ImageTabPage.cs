using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.customUI.TabPageInherited
{
    public delegate void ImageUpdated(ImageData img);
    public class ImageTabPage : TabPage
    {
        ImageAndHistory picBox;
        public ImageData imageData;
        public Enums.Enums Type
        {
            get
            {
                return imageData.Type;
            }
            set
            {
                imageData.changeType(value);
            }
        }
        public Mat Img
        {
            get
            {
                return imageData.Image;
            }
            set
            {
                imageData.updateImage(value);
            }
        }
        public ImageTabPage(Mat img, Enums.Enums type, string fileName) : base()
        {
            SetTabUI();

            imageData = new ImageData(img, type, fileName,this);
            picBox?.RedrawImage(imageData);

            imageData.UpdateEvent += picBox.RedrawImage; // triger all subs

            UpdateLogTree(imageData, "Input");
           
        }
        private void SetTabUI()
        {
            picBox = new ImageAndHistory() { Dock = DockStyle.Fill };
            Controls.Add(picBox);
        }
        public void UpdateLogTree(ImageData imageData,string operation)
        {
            picBox.UpdateLog(imageData, operation);
        }
        public ImageTabPage clone()
        {
            ImageTabPage clone = new ImageTabPage(imageData.Image, imageData.Type, "_" + imageData.fileName) { Name = $"_{Name}", Text = $"_{Text}" };
            return clone;
        }
    }
}
