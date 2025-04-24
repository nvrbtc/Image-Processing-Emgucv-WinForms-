using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Interfaces
{
    public interface IAlgorithmStrategy
    {
        string name { get; }
        ImageData ImageData { get; set; }
        void Run();
        void SetDataImage(ImageData img);
        bool GetParameters(object parameters);
    }
}
