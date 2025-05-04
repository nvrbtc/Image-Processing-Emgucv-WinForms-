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
    public class Posterization : IStrategy
    {
        private int levels;

        public string name { get; set; } = "Posterization";
        public ImageData ImageData { get;set; }

        public async Task Run(ImageData img, object parameters = null)
        {
            if (!Validate(img,parameters)) throw new ArgumentException("Input image or values are invalid.");
            Mat source = ImageData.Image.Clone();

            await Task.Run(() =>
            {
                double step = 256d / levels;
                int[] levelValues = new int[levels];
                for (int i = 0; i < levels; i++)
                {

                    levelValues[i] = (int)Math.Round(i * step, MidpointRounding.ToEven);
                }

                byte[] updatedPixels = source.GetData(false) as byte[];
                for (int i = 0; i < updatedPixels.Length; i++)
                {
                    for (int j = levels - 1; j >= 0; j--)
                    {
                        if (updatedPixels[i] >= levelValues[j])
                        {
                            updatedPixels[i] = (byte)levelValues[j];
                            break;
                        }
                    }
                }
                source.SetTo(updatedPixels);
            });

            ImageData.updateImage(source);
        }
        private bool Validate(ImageData img,object parameters) 
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not int levels) return false;

            this.levels = levels;
            this.ImageData = img;
            return true;
        }
    }
}
