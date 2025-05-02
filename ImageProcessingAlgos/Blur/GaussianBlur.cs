using APO_Tsarehradskiy.InputTypes.Blur;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale
{
    public class GaussianBlur : IStrategy
    {
        private BlurInput input;

        public string name => "Gaussian Blur";

        public ImageData ImageData { get ; set ; }

        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new ();
            await Task.Run ( () => CvInvoke.GaussianBlur(ImageData.Image, result,input.sz, 0, 0,input.BorderType));

            ImageData.updateImage(result);
        }
        private bool Validate(ImageData imageData, object parameters)
        {
            if (imageData?.ValidateValuesAreNull() == true || parameters is not BlurInput) return false;
            this.ImageData = imageData;
            this.input = parameters as BlurInput;
            return true;
        }
    }
}
