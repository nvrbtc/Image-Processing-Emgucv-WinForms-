using APO_Tsarehradskiy.InputArguments;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Filter
{
    public class LinearSharpening : IAlgorithmStrategy
    {
        private Filter2dInput parameters;
        private ConvolutionKernelF kernel;
        public string name => "Linear Sharpening";

        public ImageData ImageData { get; set; }

        public bool GetParameters(object parameters)
        {
            if ( parameters == null || parameters is not Filter2dInput) {  return false; }

            this.parameters = parameters as Filter2dInput;
            this.kernel = new ConvolutionKernelF(this.parameters.kernel);
            return true;
        }

        public void Run()
        {
            Mat temp = ImageData.Image.Clone();
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
