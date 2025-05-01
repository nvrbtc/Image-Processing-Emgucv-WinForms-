using APO_Tsarehradskiy.Extensions;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.HistogramProcessing
{
    public class LinearStretching : IAlgorithmStrategy
    {
        public string name => "Linear Stretching";

        private object parameters;
        public ImageData ImageData { get; set; }

        public LinearStretching()
        {
        }

        public void Run()
        {
            if ( ImageData.Type != Enums.Enums.Gray || ImageData.Image == null) return;
            Mat img = ImageData.Image;
            int min = img.GetMinValue(),
                max = img.GetMaxValue();

            Span<byte> data = img.GetData(false) as byte[];
            for ( int i = 0; i < data.Length; i++ )
            {
                data[i] =(byte)Math.Round((double)((data[i] - min ) * ( 255 / ( max - min))),MidpointRounding.AwayFromZero) ;
            }
            Marshal.Copy(data.ToArray(), 0, ImageData.Image.DataPointer, data.Length);

            ImageData.updateImage(ImageData.Image);

            //_mat.MinMax(out double Mn, out double Mx, _, _);
            // _mat.ConvertTo()
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }


        public bool GetParameters(object parameters)
        {
            this.parameters = parameters;
            return true;
        }
    }
}
