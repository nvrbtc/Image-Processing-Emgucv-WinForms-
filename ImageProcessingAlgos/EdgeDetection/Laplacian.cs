using APO_Tsarehradskiy.customUI.EdgeMethodHandling;
using APO_Tsarehradskiy.InputTypes;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection
{
    public class Laplacian : IAlgorithmStrategy
    {
        public string name => "Laplacian";

        public ImageData ImageData { get; set; }

        private LaplacianInput parameters;

        public Laplacian()
        {
        }

        public void Run()
        {
            Mat copy = new Mat();
            try
            {

                CvInvoke.Laplacian(ImageData.Image, copy, parameters.ddepth, parameters.kSize, parameters.scale, parameters.delta, parameters.borderType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Fatal error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ImageData.updateImage(copy);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not LaplacianInput) return false;

            this.parameters = parameters as LaplacianInput;
            return true;
        }
    }
}
