using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale
{
    public class Posterization : IAlgorithmStrategy
    {
        private double levels;

        public string name => "Posterization";
        public ImageData ImageData { get;set; }

        public Posterization()
        {
        }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not double)
            {
                return false;
            }
            this.levels = (double)parameters;
            return true;    
        }

        public void Run()
        {
            double step = 256 / levels;
            int[] levelValues = new int[(int)levels];
            for (int i = 0; i < levels; i++)
            {
                double temp = i * step;
                levelValues[i] = (int)Math.Round(temp,MidpointRounding.ToEven);
            }
            Span<byte> updatedPixels = ImageData.Image.GetData(false) as byte[];
            for (int i = 0;i < updatedPixels.Length;i++)
            {
                for ( int j = (int)levels - 1; j >= 0; j--) 
                {
                    if (updatedPixels[i] >= levelValues[j])
                    {
                        updatedPixels[i] = (byte)levelValues[j];
                        break;
                    }
                }
            }
            Marshal.Copy(updatedPixels.ToArray(),0,ImageData.Image.DataPointer,updatedPixels.Length);
            ImageData.updateImage(ImageData.Image);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }
    }
}
