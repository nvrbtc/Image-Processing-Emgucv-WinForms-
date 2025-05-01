using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using System.Runtime.InteropServices;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale
{
    public class Negation : IAlgorithmStrategy
    {

        public string name => "Negation";

        public ImageData ImageData { get; set; }

        public bool GetParameters(object parameters = default)
        {
            return true; // no need for params 
        }

        public void Run()
        {
            byte[] updatedValues = ImageData.Image.GetData(false) as byte[];

            for (int i = 0; i < updatedValues.Length; i++)
            {
                updatedValues[i] = (byte)(255 - updatedValues[i]);
            }
            Marshal.Copy(updatedValues, 0, ImageData.Image.DataPointer, updatedValues.Length);
            ImageData.updateImage(ImageData.Image);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }
    }
}
