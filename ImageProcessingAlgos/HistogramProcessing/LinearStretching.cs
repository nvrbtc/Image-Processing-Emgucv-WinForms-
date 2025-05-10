using Apo.DTO;
using APO_Tsarehradskiy.Services.Interfaces;

namespace Apo.ImageProcessingAlgos
{
    public class LinearStretching : IStrategy
    {
        public string Name { get; set; } = "Linear Stretching";
        public ImageData ImageData { get; set; }

        public async Task Run(ImageData imageData, object parameters = null)
        {
            if ( ImageData?.ValidateValuesAreNull() == true || ImageData?.Type != ImageType.Gray) throw new ArgumentException("Input or image values are invalid.");
            this.ImageData = imageData;
            int min = ImageData.Image.GetMinValue(),
                max = ImageData.Image.GetMaxValue();

            byte[] data = ImageData.Image.GetData(false) as byte[];
            double scale = 255.0 / (max - min);
            for ( int i = 0; i < data.Length; i++ )
            {
                data[i] =(byte)Math.Round((data[i] - min ) * scale) ;
            }
            ImageData.Image.SetTo(data);
            ImageData.UpdateImage(ImageData.Image);
        }
    }
}
