using APO_Tsarehradskiy.InputArguments.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

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
                CvInvoke.Sobel(ImageData.Image, result, parameters.Depth, parameters.dX, parameters.dY, parameters.Sz, parameters.Scale, parameters.Delta, parameters.BorderType); 
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
