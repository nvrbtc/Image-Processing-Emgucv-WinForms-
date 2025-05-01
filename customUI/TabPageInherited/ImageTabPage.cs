using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.customUI.TabPageInherited
{
    public delegate void ImageUpdated(Mat img);
    public class ImageTabPage : TabPage
    {
        Panel pnMain;
        PictureBox pictureBox;
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

        //image to view on screen 
        //Image boxImage;
        public ImageTabPage(Mat img, Enums.Enums type, string fileName) : base()
        {
            SetTabUI();

            imageData = new ImageData(img, type, fileName);
            pictureBox.Image = imageData.Image.ToBitmap();

            imageData.UpdateEvent += RefreshImg; // triger all subs
        }
        private void SetTabUI()
        {
            pnMain = new Panel() { Dock = DockStyle.Fill, AutoScroll = true };
            pictureBox = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.AutoSize
            };

            pnMain.Controls.Add(pictureBox);
            Controls.Add(pnMain);
        }
        public void RefreshImg()
        {
            pictureBox.Image?.Dispose();
            pictureBox.Image = imageData.Image.ToBitmap();
            pictureBox.Refresh();
            //onNotify?.Invoke(imageData.Image);//inform all subs ( f.e. update histogram values )
        }
        public void RefreshImg(Mat img)
        {
            pictureBox.Image?.Dispose();
            pictureBox.Image = img.ToBitmap();
            pictureBox.Refresh();
            //onNotify?.Invoke(imageData.Image);
        }
        public ImageTabPage clone()
        {
            ImageTabPage clone = new ImageTabPage(imageData.Image, imageData.Type, "_" + imageData.fileName) { Name = $"_{Name}", Text = $"_{Text}" };
            return clone;
        }
    }
}
