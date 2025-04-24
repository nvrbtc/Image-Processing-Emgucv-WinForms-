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

namespace APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection
{
    public class Canny : IAlgorithmStrategy
    {
        public string name => "canny";

        public ImageData ImageData { get; set; }

        //params to call method 
        private CannyInput parameters;
        public Canny()
        {
        }
        public void Run()
        {
            Mat temp = new Mat();
            try
            {
                CvInvoke.Canny(ImageData.Image, temp, parameters.threshold1, parameters.threshold2,parameters.apertureSize,parameters.L2gradient);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            ImageData.updateImage(temp);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not CannyInput) return false;

            this.parameters = parameters as CannyInput; 
            return true;
        }
    }
}
