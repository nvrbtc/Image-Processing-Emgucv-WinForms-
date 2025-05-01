using APO_Tsarehradskiy.Enums;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Services
{
    public class ImageLoadResult
    {
        public Mat img;
        public string fileName = string.Empty;
        public Enums.Enums imageType;
        public ImageLoadResult(Mat input,string name, Enums.Enums type) 
        {
            img = input;
            fileName = name;
            imageType = type;
        }
    }
}
