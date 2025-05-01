using APO_Tsarehradskiy.InputArguments.Filter2D;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Filter
{
    public class KernelFilter : IAlgorithmStrategy
    {
        private Filter2dInput parameters;
        private ConvolutionKernelF kernel;
        public string name => "Linear Sharpening ( filter2d )";

        public ImageData ImageData { get; set; }

        public bool GetParameters(object parameters)
        {
            if ( parameters == null || parameters is not Filter2dInput) {  return false; }

            this.parameters = parameters as Filter2dInput;
            if (!this.parameters.NormalizeKernel()) return false;
            this.kernel = new ConvolutionKernelF(this.parameters.Kernel);
            return true;
        }

        public void Run()
        {
            Mat temp = new Mat();
            try
            {
                CvInvoke.Filter2D(ImageData.Image, temp, kernel, new Point(-1, -1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            ImageData.updateImage(temp);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }
    }
}
