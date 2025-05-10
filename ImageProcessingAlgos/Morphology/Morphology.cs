using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class Morphology : IStrategy
    {
        public string Name { get; set; } = "Morphology";
        private MorphologyInput input;

        public ImageData ImageData { get; set; }

        private bool Validate (ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not MorphologyInput input) return false;

            this.ImageData = img;
            this.input = input;
            return true;
        }

        public async Task Run(ImageData imageData, object parameters)
        {
            if ( !Validate(imageData,parameters) ) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.MorphologyEx(ImageData.Image, result, input.Operation, input.StructElement, input.Anchor, input.Iterations, input.BorderType, CvInvoke.MorphologyDefaultBorderValue);
            ImageData.UpdateImage(result);
        }

    }
}
