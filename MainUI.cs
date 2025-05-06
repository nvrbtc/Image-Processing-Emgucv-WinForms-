using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.DTO;
using APO_Tsarehradskiy.InputArguments;

namespace APO_Tsarehradskiy
{
    public partial class MainUI : Form
    {
        private readonly ImageManager imageManager;
        private readonly ITabManager tabManager;
        private readonly StrategyExecutor executor;

        public MainUI(ImageManager imgMgr, ITabManager tbMgr, StrategyExecutor exctor)
        {
            InitializeComponent();
            imageManager = imgMgr;
            tabManager = tbMgr;
            tbMgr.SetTab(tabControl);
            executor = exctor;
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
            var data = tabManager.GetImageDataFromTab();

            if (data?.Type != Enums.Gray) return;

            var tab = MyServiceProvider.TryGetService<HistogramWindow>();
            tab?.SetImageData(data);
            tab?.Show();
        }


        /// <summary>
        /// Tries to convert current image type to grayscale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromTypeToGrayscale(object sender, EventArgs e)
        {
            var tab = tabManager.GetImageDataFromTab();
            var result = imageManager.GetQuery(tab.Type, Enums.Gray);
            if (tab == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(tab, result);
            imageManager.UpdateImageType(tab, Enums.Gray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ApplyLinearStretching(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();

            await executor.PerformStrategy(Strategies.LinearStretching, data, null);
        }


        private async void ApplyEqualizationAsync(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data?.Type != Enums.Gray)
            {
                // show dialog box;
                return;
            }
            await executor.PerformStrategy(Strategies.Equalization, data, null);
        }



        private void OpenPosterizationWindow(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null)
            {
                MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var window = MyServiceProvider.TryGetService<PosterizationWindow>();
            window?.SetImageData(data);
            window?.Show();
        }


        private void OpenBlurWindow(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null)
            {
                // show dialog;
                return;
            }

            var blurWindow = MyServiceProvider.TryGetService<BlurWindow>();
            blurWindow?.SetImageData(data);
            blurWindow?.Show();
        }

        private void DuplicateImageTab(object sender, EventArgs e)
        {
            var tab = tabManager.GetImageDataFromTab();
            if (tab == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //tabManager.AddPage();
        }

        private void OpenEdgeDetectionWindow(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null)
            {
                MessageBox.Show("No image selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var win = MyServiceProvider.TryGetService<EdgeDetectionWindow>();
            win?.SetImageData(data);
            win?.Show();
        }

        private async void ApplyNegation(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null)
            {
                //show dialog ;
                return;
            }

            await executor.PerformStrategy(Strategies.Negation, data, null);
        }

        private async void ApplyTemp(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null)
            {
                return;
            }

            await executor.PerformStrategy(Strategies.Threshold, data, 127);
        }

        private void OpenMedianFilterWindow(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null)
            {
                return;
            }
            var win = MyServiceProvider.TryGetService<MedianFilterWindow>();
            win?.SetImageData(data);
            win?.Show();


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
            var tab = tabManager.GetImageDataFromTab();
            var queryResult = imageManager.GetQuery(tab.Type, Enums.Rgb);
            if (tab == null || queryResult == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(tab, queryResult);
            imageManager.UpdateImageType(tab, Enums.Rgb);
        }

        private void FromTypeToHSV(object sender, EventArgs e)
        {
            var tab = tabManager.GetImageDataFromTab();
            var queryResult = imageManager.GetQuery(tab.Type, Enums.Hsv);
            if (tab == null || queryResult == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(tab, queryResult);
            imageManager.UpdateImageType(tab, Enums.Hsv);
        }

        private void FromTypeToLab(object sender, EventArgs e)
        {
            var tab = tabManager.GetImageDataFromTab();
            var queryResult = imageManager.GetQuery(tab.Type, Enums.Lab);
            if (tab == null || queryResult == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imageManager.ChangeImageType(tab, queryResult);
            imageManager.UpdateImageType(tab, Enums.Lab);
        }

        private void TestNew(object sender, EventArgs e)
        {
            var tab = tabManager.GetImageDataFromTab();
            if (tab == null) return;
            var win = new DrawLineExample(tab);
            win?.Show();
        }

        private void OpenUniversalFilterWindow(object sender, EventArgs e)
        {
            var tab = tabManager.GetImageDataFromTab();
            if (tab == null) return;
            var win = MyServiceProvider.TryGetService<UniversalFilterWindow>();
            win?.SetImageData(tab);
            win?.Show();
        }

        private async void ApplySkeletonization(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null) return;


            await executor.PerformStrategy(Strategies.Skeletonization, data, new SkeletonizationInput());
        }

        private void OpenMorphologyWindow(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null) return;
            var win = MyServiceProvider.TryGetService<MorfologyWindow>();
            win?.SetImageData(data);
            win?.Show();
        }
    }
}