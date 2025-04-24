using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.SingleArgument
{
    public class Treshold : IAlgorithmStrategy
    {
        private int lvl;
        public string name => "Treshold";

        public ImageData ImageData { get; set; }

        public Treshold(int level = 127)
        {
            lvl = level;
        }

        public void Run()
        {
            byte[] updatedData = ImageData.Image.GetData(false) as byte[];
            for (int i = 0; i < updatedData.Length; i++)
            {
                updatedData[i] = updatedData[i] > lvl ? (byte)255 : (byte)0;
            }
            Marshal.Copy(updatedData, 0, ImageData.Image.DataPointer, updatedData.Length);
            ImageData.updateImage(ImageData.Image);
        }

        public void SetDataImage(ImageData img)
        {
            ImageData = img;
        }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not int) return false;
            lvl = (int)parameters;
            return true;
        }
    }
}
