using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class Blur : IStrategy
    {
        public string Name { get; set; } = "Blur";
        private BlurInput input;
        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new();
            await Task.Run(() => CvInvoke.Blur(imageData.Image, result, input.Size, new Point(-1, -1), input.BorderType));

            imageData.UpdateImage(result);
            Name = $"{Name}:{input?.Size},{input?.BorderType}";
        }
        public bool Validate(ImageData imageData, object parameters)
        {
            if (imageData?.ValidateValuesAreNull() == true || parameters is not BlurInput blurInput) return false;
            this.input = blurInput;
            return true;
        }
    }
}

