using APO_Tsarehradskiy.InputTypes.Blur;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale
{
    public class Blur : IStrategy
    {
        public string name { get; set; } = "Blur";
        private BlurInput? input;
        public async Task Run(ImageData ImageData, object parameters)
        {
            if (!Validate(ImageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new();
            await Task.Run(() => CvInvoke.Blur(ImageData.Image, result, this.input.sz, new Point(-1, -1), this.input.BorderType));

            ImageData.updateImage(result);
            name = $"{name}:{input?.sz},{input?.BorderType}";
        }
        public bool Validate(ImageData imageData, object parameters)
        {
            if (imageData?.ValidateValuesAreNull() == true || parameters is not BlurInput input) return false;
            this.input = input;
            return true;
        }
    }
}

