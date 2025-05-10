using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class Canny : IStrategy
    {
        public string Name { get; set; } = "Canny";

        //params to call method 
        private CannyInput? input;
        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            await Task.Run( () => CvInvoke.Canny(imageData.Image, result, input.Threshold1, input.Threshold2, input.Sz, input.GradientEnabled));

            imageData.UpdateImage(result);

            Name = $"{Name}:{input.Threshold1},{input.Threshold2},{input.Sz}";
        }

        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not CannyInput input) return false;
            this.input = input;
            return true;
        }
    }
}
