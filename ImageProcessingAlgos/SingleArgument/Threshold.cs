using Apo.DTO;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class Threshold : IStrategy
    {
        private int input;
        public string Name { get; set; } = "Treshold";

        public ImageData ImageData;


        public async Task Run(ImageData imageData, object parameters )
        {
            if ( !Validate(imageData, parameters) ) throw new ArgumentException("Input or image values are invalid.");

            Mat source = ImageData.Image.Clone();
            byte[] updatedData = source.GetData(false) as byte[];
            for (int i = 0; i < updatedData.Length; i++)
            {
                updatedData[i] = updatedData[i] > input ? (byte)255 : (byte)0;
            }
            source.SetTo(updatedData);

            ImageData.UpdateImage(source);
        }

        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not int value) return false;
            this.input = value ;
            this.ImageData = img!;
            return true;
        }
    }
}
