using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.InputArguments.EdgeDetection
{
    public record SobelInput 
    {
        public DepthType Depth { get; set; } = DepthType.Cv8U;
        public int dX { get; set; } = 1;
        public int dY { get; set; } = 1;
        public int Sz { get; set; } = 3;
        public double Scale{get;set;} = 1;
        public double Delta { get; set; } = 0;
        public BorderType BorderType { get; set; } = BorderType.Reflect;

    }
}
