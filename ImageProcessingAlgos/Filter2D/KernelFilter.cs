using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class KernelFilter : IStrategy
    {
        private Filter2dInput input;
        private ConvolutionKernelF inputKernel;
        public string Name { get; set; } = "Linear Sharpening ( filter2d )";

        private bool Validate (ImageData imageData, object parameters)
        {
            if ( imageData?.ValidateValuesAreNull() == true || parameters is not Filter2dInput filter2dInput)  return false;
            this.input = filter2dInput;

            if (this.input?.NormalizeKernel() == false) return false; // in case sum of kernel == 0 

            this.inputKernel = new ConvolutionKernelF(filter2dInput.Kernel);
            return true;
        }

        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData, parameters)) throw new ArgumentException("Input or image values are invalid.");
            Mat result = new();

            CvInvoke.Filter2D(imageData.Image, result, inputKernel, new Point(-1, -1));
            inputKernel?.Dispose();
            imageData.UpdateImage(result);
        }
    }
}
