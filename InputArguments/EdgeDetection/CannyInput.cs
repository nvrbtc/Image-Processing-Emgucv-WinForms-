using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputArguments.EdgeDetection
{
    public class CannyInput : IEdgeInput
    {
        public int Threshold1 { get; set; } =  100;
        public int Threshold2 { get; set; } = 200;
        public int Sz { get; set; } = 3;
        public bool GradientEnabled { get; set; } = false;

        public IAlgorithmStrategy createInstace()
        {
            IAlgorithmStrategy temp = new Canny();
            temp.GetParameters(this);
            return temp;
        }

    }
}
