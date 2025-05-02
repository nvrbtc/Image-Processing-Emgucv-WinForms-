using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.customUI.TabPageInherited;
using APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale;
using APO_Tsarehradskiy.ImageProcessingAlgos.HistogramProcessing;
using APO_Tsarehradskiy.ImageProcessingAlgos.Morphology;
using APO_Tsarehradskiy.ImageProcessingAlgos.SingleArgument;
using APO_Tsarehradskiy.InputArguments;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.Services.Interfaces;

namespace APO_Tsarehradskiy
{
    public partial class MainUI : Form
    {
        private readonly ImageManager imageManager;
        private readonly ITabManager tabManager;

        private readonly StrategyExecutor executor;

        public MainUI(ImageManager imgMgr, ITabManager tbMgr,StrategyExecutor executor)
        {
            InitializeComponent();
            this.imageManager = imgMgr;
            this.tabManager = tbMgr;
            tbMgr.tabControl = this.tabControl;
            this.executor = executor;
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

            if (currentTab == null || currentTab.Type != Enums.Enums.Gray) return;

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
            var result = imageManager.GetQuery(currentTab.Type, Enums.Enums.Gray);
            if (currentTab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(currentTab, result);
            imageManager.UpdateImageType(currentTab, Enums.Enums.Gray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyLinearStretching(object sender, EventArgs e)
        {
            ImageTabPage? currentTab = tabManager.GetSelectedTab();

            IStrategy strategy = new  LinearStretching();
            strategy.Run(currentTab.imageData,null);
        }


        private void ApplyEqualization(object sender, EventArgs e)
        {
            var tab = tabManager.GetSelectedTab();
            if (tab == null || tab.Type != Enums.Enums.Gray)
            {
                // show dialog box;
                return;
            }
            executor.PerformStrategy(Enums.Strategies.Equalization, tab.imageData, null);
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

            var blurWindow = MyServiceProvider.TryGetService<BlurWindow>();
            blurWindow?.SetImageData(currentTab.imageData);
            blurWindow?.Show();
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
            var win = MyServiceProvider.TryGetService<EdgeDetectionWindow>();
            win?.SetImageData(currentTab.imageData);
            win?.Show();
        }

        private void ApplyNegation(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                //show dialog ;
                return;
            }
            IStrategy strategy = new Negation();
            strategy.Run(currentTab.imageData, null) ;
        }

        private void ApplyTemp(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null)
            {
                return;
            }
            IStrategy strategy = new Threshold();
            strategy.Run(currentTab.imageData, 127);
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
            var result = imageManager.GetQuery(currentTab.Type, Enums.Enums.Rgb);
            if (currentTab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(currentTab, result);
            imageManager.UpdateImageType(currentTab, Enums.Enums.Rgb);
        }

        private void FromTypeToHSV(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            var result = imageManager.GetQuery(currentTab.Type, Enums.Enums.Hsv);
            if (currentTab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(currentTab, result);
            imageManager.UpdateImageType(currentTab, Enums.Enums.Hsv);
        }

        private void FromTypeToLab(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            var result = imageManager.GetQuery(currentTab.Type, Enums.Enums.Lab);
            if (currentTab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(currentTab, result);
            imageManager.UpdateImageType(currentTab, Enums.Enums.Lab);
        }

        private void TestNew(object sender, EventArgs e)
        {
            
        }

        private void universalFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageTabPage currentTab = tabManager.GetSelectedTab();
            if (currentTab == null) return;
            var win = MyServiceProvider.TryGetService<UniversalFilterWindow>();
            win?.SetImageData(currentTab.imageData);
            win?.Show();
        }

        private void ApplySkeletonization(object sender, EventArgs e)
        {
            ImageTabPage win = tabManager.GetSelectedTab();
            if ( win == null || win.imageData == null) return;

            IStrategy strategy = new Skeletonization();
            strategy.Run(win.imageData, new SkeletonizationInput());
        }
    }
}