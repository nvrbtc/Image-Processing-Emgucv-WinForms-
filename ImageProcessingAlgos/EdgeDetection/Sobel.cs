using APO_Tsarehradskiy.InputArguments.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection
{
    public class Sobel : IStrategy
    {
        public string name { get; set; } = "Sobel";

        public ImageData ImageData { get; set; }

        //params to call method 
        private SobelInput input;
        public async Task Run(ImageData data, object parameters)
        {
            if (!Validate(data, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat(data.Image.Rows,data.Image.Cols,input.Depth,data.Image.NumberOfChannels);
            CvInvoke.Sobel(ImageData.Image, result, input.Depth, input.dX, input.dY, input.Sz, input.Scale, input.Delta, input.BorderType);

            ImageData.updateImage(result);
        }

        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not SobelInput) return false;

            this.ImageData = img;
            this.input = parameters as SobelInput;
            return true;
        }
    }
}
