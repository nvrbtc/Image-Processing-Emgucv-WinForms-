using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class Laplacian : IStrategy
    {
        public string Name { get; set; } = "Laplacian";

        private LaplacianInput input;

        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData,parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.Laplacian(imageData.Image, result, input.Depth, input.Sz, input.Scale, input.Delta, input.BorderType);

            imageData.UpdateImage(result);
            Name = $"{Name}:{input.Sz},{input.Scale}";
        }
        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not LaplacianInput input) return false;
            this.input = input;
            return true;
        }
    }
}
