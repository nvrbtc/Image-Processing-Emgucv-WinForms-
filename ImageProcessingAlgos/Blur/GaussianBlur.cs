using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class GaussianBlur : IStrategy
    {
        private BlurInput? input;

        public string Name { get; set; } = "Gaussian Blur";

        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new ();
            await Task.Run ( () => CvInvoke.GaussianBlur(imageData.Image, result, input.Size, 0, 0, input.BorderType));

            imageData.UpdateImage(result);
            Name = $"{Name}:{input?.Size},{input?.BorderType}";
        }
        private bool Validate(ImageData imageData, object parameters)
        {
            if (imageData?.ValidateValuesAreNull() == true || parameters is not BlurInput blurInput) return false;
            this.input = blurInput;
            return true;
        }
    }
}
