using APO_Tsarehradskiy.InputArguments.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection
{
    public class Canny : IStrategy
    {
        public string name { get; set; } = "Canny";

        //params to call method 
        private CannyInput? input;
        public async Task Run(ImageData ImageData, object parameters)
        {
            if (!Validate(ImageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            await Task.Run( () => CvInvoke.Canny(ImageData.Image, result, input.Threshold1, input.Threshold2, input.Sz, input.GradientEnabled));

            ImageData.updateImage(result);

            name = $"{name}:{input.Threshold1},{input.Threshold2},{input.Sz}";
        }

        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not CannyInput input) return false;
            this.input = input;
            return true;
        }
    }
}
