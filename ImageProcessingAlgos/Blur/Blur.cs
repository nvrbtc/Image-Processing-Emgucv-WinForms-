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
    public class Blur : IAlgorithmStrategy
    {
        public string name => "Blur";

        public ImageData ImageData { get; set ; }
        private BlurInput parameters;
        public Blur()
        {
            
        }
        public void Run()
        {
            Mat result = new();
            CvInvoke.Blur(ImageData.Image, result, parameters.sz, new Point(-1, -1), parameters.borderType);
            ImageData.updateImage(result);
        }
        public override string ToString()
        {
            return name;
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not BlurInput)
            {
                ///TODO:Handle error
                return false;
            }
            this.parameters = parameters as BlurInput;
            return true;
        }
    }
}

