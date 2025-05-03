using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.customUI.TabPageInherited
{
    public delegate void ImageUpdated(ImageData img);
    public class ImageTabPage : TabPage
    {
        private ImageAndHistory picBox;
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
            imageData = new ImageData(img, type, fileName, this);
            SetTabUI();

            imageData.UpdateEvent += picBox.RedrawImage; // triger all subs
            
            UpdateLogTree(imageData, "Input");
           
        }
        private void SetTabUI()
        {
            picBox = new ImageAndHistory() { Dock = DockStyle.Fill};
            
            Controls.Add(picBox);
            picBox?.RedrawImage(imageData); //If node in tree is double clicked, image from node is restored ( Jpeg restore with 10% loses, BGR ) 
            picBox.NodeDoubleClic += imageData.Restore;
        }
        public void UpdateLogTree(ImageData imageData,string operation)
        {
            picBox.UpdateLog(imageData, operation);
            
        }
        public ImageTabPage Clone()
        {
            ImageTabPage clone = new ImageTabPage(imageData.Image.Clone(), imageData.Type, "_" + imageData.fileName) { Name = $"_{Name}", Text = $"_{Text}" };
            return clone;
        }
    }
}
