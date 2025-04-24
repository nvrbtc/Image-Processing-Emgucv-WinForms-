using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.customUI.EdgeMethodHandling
{
    public class LaplacianInput : IEdgeInput
    {
        public DepthType ddepth;
        public int kSize = 1;
        public double scale = 1;
        public double delta = 0;
        public BorderType borderType = BorderType.Default;
        public LaplacianInput(DepthType d, int sz,double sc, double dlt, BorderType border)
        {
            this.ddepth = d;
            this.kSize = sz;
            this.scale = sc;
            this.delta = dlt;
            this.borderType = border;

        }

        public IAlgorithmStrategy createInstace()
        {
            IAlgorithmStrategy strategy = new Laplacian();
            strategy.GetParameters(this);
            return strategy; 
        }

    }
}
