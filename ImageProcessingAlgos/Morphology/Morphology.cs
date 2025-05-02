using APO_Tsarehradskiy.InputArguments.Morphology;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Morphology
{
    public class Morphology : IStrategy
    {
        public string name => "Morphology";
        private MorphologyInput input;

        public ImageData ImageData { get; set; }

        private bool Validate (ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not MorphologyInput input) return false;

            this.ImageData = img;
            this.input = input;
            return true;
        }

        public async Task Run(ImageData img, object parameters)
        {
            if ( !Validate(img,parameters) ) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.MorphologyEx(ImageData.Image, result, input.Operation, input.StructElement, input.Anchor, input.Iterations, input.BorderType, CvInvoke.MorphologyDefaultBorderValue);
            ImageData.updateImage(result);
        }

    }
}
