using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using APO_Tsarehradskiy.InputArguments;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos
{
    public class KernelFilter : IStrategy
    {
        private Filter2dInput input;
        private ConvolutionKernelF inputKernel;
        public string name { get; set; } = "Linear Sharpening ( filter2d )";

        public bool Validate (ImageData ImageData, object parameters)
        {
            if ( ImageData?.ValidateValuesAreNull() == true || parameters is not Filter2dInput input)  return false;
            this.input = input;

            if (this.input?.NormalizeKernel() == false) return false; // in case sum of kernel == 0 

            this.inputKernel = new ConvolutionKernelF(this.input.Kernel);
            return true;
        }

        public async Task Run(ImageData ImageData, object parameters)
        {
            if (!Validate(ImageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat state = ImageData.Image.Clone();
            Mat result = Mat.Zeros(state.Rows, state.Cols, state.Depth, state.NumberOfChannels);

            CvInvoke.Filter2D(state, result, inputKernel, new Point(-1, -1));

            ImageData.updateImage(result);
        }
    }
}
