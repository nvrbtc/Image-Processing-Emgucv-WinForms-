using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.InputTypes;
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
    public class GaussianBlur : IAlgorithmStrategy
    {
        private BlurInput parameters;

        public string name => "Gaussian Blur";

        public ImageData ImageData { get ; set ; }

        public GaussianBlur()
        {
        }

        public void Run()
        {
            Mat copy = new ();
            CvInvoke.GaussianBlur(ImageData.Image, copy,parameters.sz, 0, 0,parameters.borderType);
            ImageData.updateImage(copy);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }

        public bool GetParameters(object parameters)
        {
            if ( parameters == null || parameters is not BlurInput)
            {
                return false;
            }
            this.parameters = parameters as BlurInput;
            return true;
        }
    }
}
