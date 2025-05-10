using Emgu.CV.CvEnum;

namespace Apo.InputArguments
{
    public record HoughProbInput 
    {
        public double Rho { get; set; } = 1;
        public int Theta { get; 
            set; } = 180;
        public int Threshold { get; set; } = 150;
        public double MinLineLength { get; set; } = 0;
        public double MaxLineGap { get; set; } = 0;
        public int LineThickness { get; set; } = 1;
        public LineType LineType { get; set; } = LineType.AntiAlias;

    }
    public record HoughSimpleInput 
    {
        public double Rho { get; 
            set; } = 1;
        public int Theta { get; set; } = 180;
        public int Threshold { get; set; } = 150;
        public double Srn { get; set; } = 0;
        public double Stn { get; set; } = 0;
        public int LineThickness { get; set; } = 1;
        public LineType LineType { get; set; } = LineType.AntiAlias;

       
    }
}
