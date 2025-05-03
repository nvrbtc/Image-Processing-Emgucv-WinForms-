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
        public string name { get; set; } = "Laplacian";

        private LaplacianInput input;

        public async Task Run(ImageData ImageData, object parameters)
        {
            if (!Validate(ImageData,parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.Laplacian(ImageData.Image, result, input.Depth, input.Sz, input.Scale, input.Delta, input.BorderType);

            ImageData.updateImage(result);
            name = $"{name}:{input.Sz},{input.Scale}";
        }
        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not LaplacianInput input) return false;
            this.input = input;
            return true;
        }
    }
}
