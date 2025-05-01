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
            int width = currentImage.Width;
            int height = currentImage.Height;
            int pixels = width * height;

            ReadOnlySpan<byte> data = currentImage.GetData(false) as byte[];
            Span<byte> updatedData = new byte[pixels];

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

            Marshal.Copy(updatedData.ToArray(), 0, currentImage.DataPointer, updatedData.Length);
            ImageData.updateImage(currentImage);
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
