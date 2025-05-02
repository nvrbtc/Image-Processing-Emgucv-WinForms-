using APO_Tsarehradskiy.InputArguments.EdgeDetection;
using APO_Tsarehradskiy.InputTypes;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection
{
    public class Laplacian : IStrategy
    {
        public string name => "Laplacian";

        public ImageData ImageData { get; set; }

        private LaplacianInput input;

        public async Task Run(ImageData img, object parameters)
        {
            if (!Validate(img,parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.Laplacian(ImageData.Image, result, input.Depth, input.Sz, input.Scale, input.Delta, input.BorderType);

            ImageData.updateImage(result);
        }
        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not LaplacianInput) return false;
            this.input = parameters as LaplacianInput;
            this.ImageData = img;
            return true;
        }
    }
}
