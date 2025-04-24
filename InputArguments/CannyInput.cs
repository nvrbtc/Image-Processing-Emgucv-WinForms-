using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputTypes
{
    public class CannyInput : IEdgeInput
    {
        public double threshold1 = 100;
        public double threshold2 = 200;
        public int apertureSize = 3;
        public bool L2gradient = false;

        public CannyInput()
        {

        }

        public IAlgorithmStrategy createInstace()
        {
            IAlgorithmStrategy temp = new Canny();
            temp.GetParameters(this);
            return temp;
        }

    }
}
