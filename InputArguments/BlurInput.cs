using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.InputTypes
{
    public class BlurInput
    {
        public BorderType borderType = BorderType.Reflect;
        public Size sz = new Size(3,3);
        public BlurInput(BorderType borderType, Size sz)
        {
            this.borderType = borderType;
            this.sz = sz;
        }
    }
}
