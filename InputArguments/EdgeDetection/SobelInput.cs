using Emgu.CV.CvEnum;

namespace Apo.InputArguments
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
