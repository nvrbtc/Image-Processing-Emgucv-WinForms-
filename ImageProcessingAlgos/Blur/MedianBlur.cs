using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Blur
{
    public class MedianBlur : IStrategy
    {
        public string name { get; set; } = "Median Blur";

        private int input;

        public async Task Run(ImageData ImageData, object parameters)
        {
            if ( !Validate(ImageData,parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.MedianBlur(ImageData.Image, result, input);

            ImageData.updateImage(result);
            name = $"{name}:{input}x{input}";
        }
        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not int i) return false;
            this.input = i ;
            return true;
        }
    }
}
