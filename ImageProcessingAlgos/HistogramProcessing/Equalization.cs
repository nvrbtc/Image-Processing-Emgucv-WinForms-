using Apo.DTO;
using APO_Tsarehradskiy.Services.Interfaces;
using Emgu.CV;

namespace Apo.ImageProcessingAlgos
{
    public class Equalization : IStrategy
    {
        private Mat resultImg;
        public string Name { get; set; } = "Equalization";
        private ImageData ImageData;

        public async Task Run(ImageData imageData, object parameters = null)
        {
            if (imageData?.ValidateValuesAreNull() == true) throw new ArgumentException("Input or image values are invalid.");
            this.ImageData = imageData;
            await Task.Run(() => PerformLogic());

            ImageData?.UpdateImage(resultImg);
        }
        private void PerformLogic()
        {
            resultImg = ImageData.Image.Clone();
            int width = resultImg.Width;
            int height = resultImg.Height;
            int pixels = width * height;

            byte[] data = resultImg.GetData(false) as byte[];
            byte[] updatedData = new byte[pixels];

            int[] histogram = new int[256];
            for (int i = 0; i < data.Length; i++)
            {
                histogram[data[i]]++;
            }

            int[] cdf = new int[256];
            cdf[0] = histogram[0];
            for (int i = 1; i < 256; i++)
            {
                cdf[i] = cdf[i - 1] + histogram[i];
            }

            int cdfMin = cdf.First(v => v > 0);

            byte[] lut = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                lut[i] = (byte)Math.Round(((cdf[i] - cdfMin) / (double)(pixels - 1)) * 255);
            }

            for (int i = 0; i < data.Length; i++)
            {
                updatedData[i] = lut[data[i]];
            }
            resultImg.SetTo(updatedData);
        }
    }
}
