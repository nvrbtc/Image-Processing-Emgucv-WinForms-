using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Apo.ImageProcessingAlgos
{
    public class Sobel : IStrategy
    {
        
        public string Name { get; set; } = "Sobel";

        private ImageData imageData;

        //params to call method 
        private SobelInput input;
        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            //imageData.Image.Rows,imageData.Image.Cols,input.Depth,imageData.Image.NumberOfChannels
            Mat result = new Mat();
            CvInvoke.Sobel(this.imageData.Image, result, input.Depth, input.dX, input.dY, input.Sz, input.Scale, input.Delta, input.BorderType);
            Image<Gray,double> img = result.ToImage<Gray,double>();
            
            this.imageData.UpdateImage(result);
        }

        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not SobelInput sobelInput) return false;

            this.imageData = img;
            this.input = sobelInput;
            return true;
        }
    }
}
