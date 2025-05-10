namespace Apo.InputArguments
{
    public record CannyInput 
    {
        public int Threshold1 { get; set; } =  100;
        public int Threshold2 { get; set; } = 200;
        public int Sz { get; set; } = 3;
        public bool GradientEnabled { get; set; } = false;
    }
}
