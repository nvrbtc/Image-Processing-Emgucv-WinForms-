using APO_Tsarehradskiy.InputTypes.Blur;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale
{
    public class GaussianBlur : IStrategy
    {
        private BlurInput? input;

        public string name { get; set; } = "Gaussian Blur";

        public async Task Run(ImageData ImageData, object parameters)
        {
            if (!Validate(ImageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new ();
            await Task.Run ( () => CvInvoke.GaussianBlur(ImageData.Image, result, input.sz, 0, 0, input.BorderType));

            ImageData.updateImage(result);
            name = $"{name}:{input?.sz},{input?.BorderType}";
        }
        private bool Validate(ImageData imageData, object parameters)
        {
            if (imageData?.ValidateValuesAreNull() == true || parameters is not BlurInput input) return false;
            this.input = input;
            return true;
        }
    }
}
