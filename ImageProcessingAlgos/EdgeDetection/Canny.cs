using APO_Tsarehradskiy.InputArguments.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection
{
    public class Canny : IStrategy
    {
        public string name => "canny";

        public ImageData ImageData { get; set; }

        //params to call method 
        private CannyInput input;
        public async Task Run(ImageData img, object parameters)
        {
            if (!Validate(img, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new Mat();
            await Task.Run( () => CvInvoke.Canny(ImageData.Image, result, input.Threshold1, input.Threshold2, input.Sz, input.GradientEnabled));

            ImageData.updateImage(result);
        }

        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not CannyInput) return false;
            this.ImageData = img;
            this.input = parameters as CannyInput;
            return true;
        }
    }
}
