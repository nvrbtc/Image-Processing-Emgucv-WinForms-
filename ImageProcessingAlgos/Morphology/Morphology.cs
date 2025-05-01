using APO_Tsarehradskiy.InputArguments.Morphology;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Morphology
{
    public class Morphology : IAlgorithmStrategy
    {
        public string name => "Morphology";
        private MorphologyInput parameters;

        public ImageData ImageData { get; set; }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not MorphologyInput) return false;
            this.parameters = parameters as MorphologyInput;
            return true;
        }

        public void Run()
        {
            Mat result = new Mat();
            try
            {
                CvInvoke.MorphologyEx(ImageData.Image, result, parameters.Operation, parameters.StructElement, parameters.Anchor, parameters.Iterations, parameters.BorderType, CvInvoke.MorphologyDefaultBorderValue);
                ImageData.updateImage(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show(name, ex.Message);
            }

        }

        public void SetDataImage(ImageData img)
        {
            ImageData = img;
        }
    }
}
