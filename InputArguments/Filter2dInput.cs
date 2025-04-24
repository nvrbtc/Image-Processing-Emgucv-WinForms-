using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputArguments
{
    public class Filter2dInput
    {
        public float[,] kernel = new float[3,3];
        public double delta = 0;
        public BorderType border { get; set; }
        public Point point = new Point(-1,-1);

        public Filter2dInput(ConvolutionKernelF kernel, double delta, BorderType border, Point point)
        {
            //this.kernel = kernel;
            this.delta = delta;
            this.border = border;
            this.point = point;
        }
        public Filter2dInput(float[,] kernel, double delta, BorderType border, Point point)
        {
            this.kernel = kernel;
            this.delta = delta;
            this.border = border;
            this.point = point;
        }
        public Filter2dInput()
        {
            border = BorderType.Reflect;
        }
    }
}
