using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Interfaces.InputReturn;

namespace APO_Tsarehradskiy.InputArguments.EdgeDetection
{
    public record CannyInput 
    {
        public int Threshold1 { get; set; } =  100;
        public int Threshold2 { get; set; } = 200;
        public int Sz { get; set; } = 3;
        public bool GradientEnabled { get; set; } = false;
    }
}
