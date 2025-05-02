using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputArguments.EdgeDetection
{
    public record LaplacianInput 
    {
        public DepthType Depth { get; set; } = DepthType.Cv8U;
        public int Sz { get; set; } = 1;
        public double Scale { get; set; } = 1;
        public double Delta { get; set; } = 0;
        public BorderType BorderType { get; set; } =  BorderType.Reflect;

    }
}
