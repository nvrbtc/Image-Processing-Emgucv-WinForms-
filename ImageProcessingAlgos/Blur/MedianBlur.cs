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
    public class MedianBlur : IAlgorithmStrategy
    {
        public string name => "Median Blur";

        private int parameters;
        public ImageData ImageData { get; set; }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not int)
            {
                return false;
            }
            this.parameters = (int)parameters;
            return true;
        }

        public void Run()
        {
            Mat temp = new Mat();
            try
            {
                CvInvoke.MedianBlur(ImageData.Image, temp, parameters);
            }
            catch (Exception e)
            {
                return;
            }
            ImageData.updateImage(temp);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }
    }
}
