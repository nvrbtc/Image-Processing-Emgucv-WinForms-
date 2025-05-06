using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos
{
    public class Equalization : IStrategy
    {
        private Mat resultImg;
        public string name { get; set; } = "Equalization";
        public ImageData ImageData { get; set; }

        public async Task Run(ImageData img, object parameters = null)
        {
            if (img?.ValidateValuesAreNull() == true) throw new ArgumentException("Input or image values are invalid.");
            this.ImageData = img;
            await Task.Run(() => PerformLogic());

            ImageData?.updateImage(resultImg);
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

            //Marshal.Copy(updatedData.ToArray(), 0, resultImg.DataPointer, updatedData.Length); <= dangerous
            resultImg.SetTo(updatedData);
        }
    }
}
