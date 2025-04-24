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

namespace APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection
{
    public class Sobel : IAlgorithmStrategy
    {
        public string name => "Sobel";

        public ImageData ImageData { get; set; }

        //params to call method 
        private SobelInput parameters;

        public Sobel()
        {
            
        }
        public void Run()
        {
            Mat result = new Mat();
            try
            {
                CvInvoke.Sobel(ImageData.Image, result, parameters.depthType, parameters.dX, parameters.dY, parameters.kSize, parameters.scale, parameters.delta, parameters.borderType); 
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message,"Fatal error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ImageData.updateImage(result);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not SobelInput) return false;

            this.parameters = parameters as SobelInput;
            return true;
        }
    }
}
