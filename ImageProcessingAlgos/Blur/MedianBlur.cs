using APO_Tsarehradskiy.InputTypes;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Blur
{
    public class MedianBlur : IStrategy
    {
        public string name => "Median Blur";

        private int input;
        public ImageData ImageData { get; set; }

        public async Task Run(ImageData img, object parameters)
        {
            if ( !Validate(img,parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            CvInvoke.MedianBlur(ImageData.Image, result, input);
            
            ImageData.updateImage(result);
        }
        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not int i) return false;
            this.ImageData = img;
            this.input = i ;
            return true;
        }
    }
}
