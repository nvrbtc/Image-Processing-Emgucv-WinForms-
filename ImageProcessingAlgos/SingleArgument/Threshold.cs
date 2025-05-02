using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.SingleArgument
{
    public class Threshold : IStrategy
    {
        private int input;
        public string name => "Treshold";

        public ImageData ImageData { get; set; }


        public async Task Run(ImageData img, object parameters )
        {
            if ( !Validate(img, parameters) ) throw new ArgumentException("Input or image values are invalid.");

            Mat source = ImageData.Image.Clone();
            byte[] updatedData = source.GetData(false) as byte[];
            for (int i = 0; i < updatedData.Length; i++)
            {
                updatedData[i] = updatedData[i] > input ? (byte)255 : (byte)0;
            }
            ImageData.Image.SetTo(updatedData);

            ImageData.updateImage(ImageData.Image);
        }

        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not int value) return false;
            this.input = value ;
            this.ImageData = img;
            return true;
        }
    }
}
