using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.InputArguments
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
