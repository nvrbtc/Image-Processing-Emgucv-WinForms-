using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputTypes
{
    public class SobelInput : IEdgeInput
    {
        public DepthType depthType;
        public int dX;
        public int dY;
        public int kSize;
        public double scale;
        public double delta;
        public BorderType borderType;

        public SobelInput(DepthType depthType, int dX, int dY, int kSize, double scale, double delta, BorderType borderType)
        {
            this.depthType = depthType;
            this.dX = dX;
            this.dY = dY;
            this.kSize = kSize;
            this.scale = scale;
            this.delta = delta;
            this.borderType = borderType;
        }

        public IAlgorithmStrategy createInstace()
        {
            IAlgorithmStrategy strategy = new Sobel();
            strategy.GetParameters(this);
            return strategy;
        }

    }
}
