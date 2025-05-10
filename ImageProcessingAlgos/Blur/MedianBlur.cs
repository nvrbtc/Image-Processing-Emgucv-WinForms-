using Apo.DTO;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class MedianBlur : IStrategy
    {
        public string Name { get; set; } = "Median Blur";

        private int input;

        public async Task Run(ImageData imageData, object parameters)
        {
            if ( !Validate(imageData,parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.MedianBlur(imageData.Image, result, input);

            imageData.UpdateImage(result);
            Name = $"{Name}:{input}x{input}";
        }
        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not int i) return false;
            this.input = i ;
            return true;
        }
    }
}
