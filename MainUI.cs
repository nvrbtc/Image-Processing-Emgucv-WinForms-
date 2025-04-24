using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.Enums;
using APO_Tsarehradskiy.ImageProcessingAlgos;
using APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale;
using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.ImageProcessingAlgos.HistogramProcessing;
using APO_Tsarehradskiy.ImageProcessingAlgos.SingleArgument;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Reg;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace APO_Tsarehradskiy
{
    public partial class MainForm : Form
    {
        private readonly ImageManager imageManager;
        private readonly ITabManager tabManager;

        private readonly ImageProcessService imageProccesService = new();

        public MainForm(ImageManager imgMgr, ITabManager tbMgr)
        {
            InitializeComponent();

            imageManager = imgMgr;
            tabManager = tbMgr;
            tbMgr.tabControl = this.tabControl;
        }

        /// <summary>
        /// Opens new RGB image with dialog window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenRgbImage(object sender, EventArgs e)
        {
            var RGBimage = imageManager.OpenRGBImage();
            if (RGBimage == null) return;

            tabManager.AddPage(RGBimage);
        }

        private void SaveImage(object sender, EventArgs e)
        {
            return;
            // to do later
            if (false)
            {
                MessageBox.Show("No picture selected", "Warning", MessageBoxButtons.OK);
                // throw new ArgumentException("No image detected");
                return;
            }
            // Panel img = (Panel)tabControl.SelectedTab.Controls[];
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "JPG|*.jpg,BMP|*.bmp,JPEG|*.jpeg,PNG|*.png",
                RestoreDirectory = true,
                FileName = tabControl.SelectedTab?.Text,
                ValidateNames = true
            };
            if (DialogResult.OK == dialog.ShowDialog())
            {
                FileStream stream;
                if ((stream = (FileStream)dialog.OpenFile()) != null)
                {
                    switch (dialog.FilterIndex)
                    {


                    }
                }
            }
        }


        /// <summary>
        /// Opens histogram window for grayscale images.
        /// Updates values when image is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenHistogramWindow(object sender, EventArgs e)
        {
            var currentTab = tabManager.GetSelectedTab();

            if (currentTab == null || currentTab.Type != ImageType.Gray) return;

            var tab = new HistogramWindow();
            tab.SetImageData(currentTab.imageData);
            tab.Show();
        }


        /// <summary>
        /// Tries to convert current image type to grayscale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromTypeToGrayscale(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            var result = imageManager.GetQuery(currentTab.Type, ImageType.Gray);
            if (currentTab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(currentTab, result);
            imageManager.UpdateImageType(currentTab, ImageType.Gray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyLinearStretching(object sender, EventArgs e)
        {
            ImageTabPage? currentTab = tabManager.GetSelectedTab();

            imageProccesService.SetAlgo(new LinearStretching());
            imageProccesService.SetImageData(currentTab.imageData);
            imageProccesService.Process();
        }


        private void ApplyEqualization(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null || currentTab.Type != ImageType.Gray)
            {
                // show dialog box;
                return;
            }
            imageProccesService.SetAlgo(new Equalization());
            imageProccesService.SetImageData(currentTab.imageData);
            imageProccesService.Process();
        }



        private void OpenPosterizationWindow(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var window = new PosterizationWindow();
            window.SetImageData(currentTab.imageData);
            window.Show();
        }


        private void OpenBlurWindow(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                // show dialog;
                return;
            }

            var blurWindow = new BlurWindow();
            blurWindow.SetImageData(currentTab.imageData);
            blurWindow.Show();
        }

        private void DuplicateImageTab(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tabManager.AddPage(currentTab.clone());
        }

        private void OpenEdgeDetectionWindow(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var win = new EdgeDetectionWindow();
            win.SetImageData(currentTab.imageData);
            win.Show();
        }

        private void ApplyNegation(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                //show dialog ;
                return;
            }
            IAlgorithmStrategy strategy = new Negation();
            strategy.SetDataImage(currentTab.imageData);
            strategy.Run();
        }

        private void ApplyTemp(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                return;
            }
            IAlgorithmStrategy strategy = new Treshold();
            Mat copy = currentTab.Img.Clone();
            //strategy.Run(ref copy);
            //tabManager.UpdateImage(currentTab, copy);
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                return;
            }
            var win = new MedianFilterWindow();
            win.SetImageData(currentTab.imageData);
            win.Show();


        }

        private void OpenGrayscaleImage(object sender, EventArgs e)
        {
            var result = imageManager.OpenGrayImage();
            if (result == null)
            {
                // show dialog ;
                return;
            }
            tabManager.AddPage(result);
        }

        private void FromTypeToRGB(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            var result = imageManager.GetQuery(currentTab.Type, ImageType.Rgb);
            if (currentTab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(currentTab, result);
            imageManager.UpdateImageType(currentTab, ImageType.Rgb);
        }

        private void FromTypeToHSV(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            var result = imageManager.GetQuery(currentTab.Type, ImageType.Hsv);
            if (currentTab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(currentTab, result);
            imageManager.UpdateImageType(currentTab, ImageType.Hsv);
        }

        private void FromTypeToLab(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            var result = imageManager.GetQuery(currentTab.Type, ImageType.Lab);
            if (currentTab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(currentTab, result);
            imageManager.UpdateImageType(currentTab, ImageType.Lab);
        }

        private void TestNew(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            var win = new SharpWindow();
            win.SetImageData(currentTab.imageData);
            win.Show();
        }

        private void universalFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var win = new UniversalFilterWindow();
            win.Show();
        }
    }
}