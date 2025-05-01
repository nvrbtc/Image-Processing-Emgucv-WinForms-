using APO_Tsarehradskiy.ImageProcessingAlgos.Hough;
using APO_Tsarehradskiy.Interfaces;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputArguments.Hough
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
