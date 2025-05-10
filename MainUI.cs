using Apo.customUI;
using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Forms;
using APO_Tsarehradskiy.Services.Interfaces;
using APO_Tsarehradskiy.Services.Realization;
using Emgu.CV.CvEnum;

namespace Apo
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
            var rgbImage = imageManager.OpenRgbImage();
            if (rgbImage == null) return;

            tabManager.AddPage(rgbImage);
        }

        private void SaveImage(object sender, EventArgs e)
        {
            return;
            // todo: later
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

            if (data?.Type != ImageType.Gray) return;

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
            var data = tabManager.GetImageDataFromTab();
            var result = imageManager.GetQuery(data.Type, ImageType.Gray);
            if (data?.Image == null || result == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            imageManager.ChangeImageType(data, result);
            imageManager.UpdateImageType(data, ImageType.Gray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ApplyLinearStretching(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();

            if (data != null) await executor.PerformStrategy(Strategies.LinearStretching, data, null);
        }


        private async void ApplyEqualizationAsync(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data?.Type != ImageType.Gray)
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
            if (result == null) return;
            tabManager.AddPage(result);
        }

        private void FromTypeToRgb(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            var queryResult = imageManager.GetQuery(data.Type, ImageType.Rgb);
            if (data == null || queryResult == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            imageManager.ChangeImageType(data, queryResult);
            imageManager.UpdateImageType(data, ImageType.Rgb);
        }

        private void FromTypeToHsv(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            var queryResult = imageManager.GetQuery(data.Type, ImageType.Hsv);
            if (data == null || queryResult == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            imageManager.ChangeImageType(data, queryResult);
            imageManager.UpdateImageType(data, ImageType.Hsv);
        }

        private void FromTypeToLab(object sender, EventArgs e)
        {
            var tab = tabManager.GetImageDataFromTab();
            var queryResult = imageManager.GetQuery(tab.Type, ImageType.Lab);
            if (tab == null || queryResult == default)
            {
                MessageBox.Show("No image selected or prohibit query", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            imageManager.ChangeImageType(tab, queryResult);
            imageManager.UpdateImageType(tab, ImageType.Lab);
        }

        private void TestNew(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null) return;
            var input = new TwoPicsOps(data);
            input.Show();

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

        private void OpenProfileLineWindow(object? sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data?.Type != ImageType.Gray) return;

            var win = new DrawLineExample(data);
            win.Show();
        }

        private void houghMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = tabManager.GetImageDataFromTab();
            if (data == null) return;

            var win = MyServiceProvider.TryGetService<HoughWindow>();
            win?.SetImageData(data);
            win?.Show();
        }
    }
}