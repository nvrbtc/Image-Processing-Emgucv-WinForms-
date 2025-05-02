using APO_Tsarehradskiy.InputArguments;
using APO_Tsarehradskiy.InputTypes;
using APO_Tsarehradskiy.InputTypes.Blur;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale
{
    public class Blur : IStrategy
    {
        public string name => "Blur";

        public ImageData ImageData { get; set ; }
        private BlurInput? input;
        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData, parameters)) throw new ArgumentException("Input or image values are invalid.");

            Mat result = new();
            await Task.Run(() => CvInvoke.Blur(ImageData.Image, result, this.input.sz, new Point(-1, -1), this.input.BorderType));

            ImageData.updateImage(result);
        }
        public bool Validate(ImageData imageData, object parameters)
        {
            if (imageData?.ValidateValuesAreNull() == true || parameters is not BlurInput) return false;
            this.ImageData = imageData;
            this.input = parameters as BlurInput;
            return true;
        }
    }
}

