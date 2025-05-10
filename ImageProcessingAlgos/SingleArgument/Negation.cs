using Apo.DTO;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class Negation : IStrategy
    {
        public string Name { get; set; } = "Negation";
        public async Task Run(ImageData imageData, object parameters = null)
        {
            if ( imageData?.ValidateValuesAreNull() == true ) throw new ArgumentException("Input or image values are invalid.");
            byte[] updatedValues = imageData.Image.GetData(false) as byte[];
            Mat result = imageData.Image.Clone();
            for (int i = 0; i < updatedValues.Length; i++)
            {
                updatedValues[i] = (byte)(255 - updatedValues[i]);
            }
            result.SetTo(updatedValues);

            imageData.UpdateImage(result);
        }

    }
}
