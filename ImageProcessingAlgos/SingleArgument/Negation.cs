using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;

namespace APO_Tsarehradskiy.ImageProcessingAlgos
{
    public class Negation : IStrategy
    {

        public string name { get; set; } = "Negation";

        public ImageData ImageData { get; set; }


        public async Task Run(ImageData img, object parameters = null)
        {
            if ( img?.ValidateValuesAreNull() == true ) throw new ArgumentException("Input or image values are invalid.");

            this.ImageData = img;
            byte[] updatedValues = ImageData.Image.GetData(false) as byte[];

            for (int i = 0; i < updatedValues.Length; i++)
            {
                updatedValues[i] = (byte)(255 - updatedValues[i]);
            }
            ImageData.Image.SetTo(updatedValues);

            ImageData.updateImage(ImageData.Image);
        }

    }
}
