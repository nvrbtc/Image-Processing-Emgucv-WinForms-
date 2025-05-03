using APO_Tsarehradskiy.Extensions;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.HistogramProcessing
{
    public class LinearStretching : IStrategy
    {
        public string name { get; set; } = "Linear Stretching";
        public ImageData ImageData { get; set; }

        public async Task Run(ImageData imageData, object parameters = null)
        {
            if ( ImageData?.ValidateValuesAreNull() == true || ImageData?.Type != Enums.Enums.Gray) throw new ArgumentException("Input or image values are invalid.");
            this.ImageData = imageData;
            Mat img = ImageData.Image;
            int min = img.GetMinValue(),
                max = img.GetMaxValue();

            byte[] data = img.GetData(false) as byte[];
            double scale = 255.0 / (max - min);
            for ( int i = 0; i < data.Length; i++ )
            {
                data[i] =(byte)Math.Round((data[i] - min ) * scale) ;
            }
            ImageData.Image.SetTo(data);
            ImageData.updateImage(ImageData.Image);
        }
    }
}
