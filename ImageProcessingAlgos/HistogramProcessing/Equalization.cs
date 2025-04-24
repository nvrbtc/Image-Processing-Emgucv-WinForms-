using APO_Tsarehradskiy.Extensions;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.HistogramProcessing
{
    public class Equalization : IAlgorithmStrategy
    {
        public string name => "Equalization";

        public ImageData ImageData { get; set; }

        public Equalization()
        {
        }

        public void Run()
        {
            Mat currentImage = ImageData.Image;
            int[] distribution = currentImage.GetDistributionValues();
            int pixels = currentImage.Height * currentImage.Width;
            ReadOnlySpan<byte> data = currentImage.GetData(false) as byte[];
            Span<byte> updatedData = new byte[pixels];
            int minValue = currentImage.GetMinValue();

            double result = 0;
            for (int i = 0,
                 pixelValue = 0; i < data.Length; i++)
            {
                pixelValue = data[i];
                result = ((distribution[pixelValue] - minValue) / (double)(pixels - 1)) * 255;
                updatedData[i] = (byte)Math.Round(result);
            }
            Marshal.Copy(updatedData.ToArray(), 0, ImageData.Image.DataPointer, updatedData.Length);
            ImageData.updateImage(ImageData.Image);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }

        public bool GetParameters(object parameters)
        {
            return true;
        }
    }
}
