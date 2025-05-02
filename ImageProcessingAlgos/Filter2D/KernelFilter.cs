using APO_Tsarehradskiy.InputArguments.Filter2D;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Filter
{
    public class KernelFilter : IStrategy
    {
        private Filter2dInput input;
        private ConvolutionKernelF inputKernel;
        public string name => "Linear Sharpening ( filter2d )";

        public ImageData ImageData { get; set; }

        public bool Validate (ImageData img,object parameters)
        {
            if ( img?.ValidateValuesAreNull() == true || parameters is not Filter2dInput)  return false;
            this.ImageData = img;
            this.input = parameters as Filter2dInput;

            if (this.input?.NormalizeKernel() == false) return false; // in case sum of kernel == 0 

            this.inputKernel = new ConvolutionKernelF(this.input.Kernel);
            return true;
        }

        public async Task Run(ImageData img, object parameters)
        {
            if (!Validate(img, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.Filter2D(ImageData.Image, result, inputKernel, new Point(-1, -1));

            ImageData.updateImage(result);
        }
    }
}
