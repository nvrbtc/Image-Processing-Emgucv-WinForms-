using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputTypes.Blur
{
    public record BlurInput
    {
        public BorderType BorderType { get; set; } = BorderType.Reflect;
        public Size sz = new Size(3,3);
    }
}
