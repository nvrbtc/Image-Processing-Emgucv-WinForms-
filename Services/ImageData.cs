using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.Enums;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Services
{
    public class ImageData
    {
        private Mat img;


        public string fileName = string.Empty;
        public event ImageUpdated UpdateEvent;
        public ImageType Type { get; private set; }
        public Mat Image
        {
            get
            {
                return img;
            }
            private set
            {
                img = value;
            }
        }
        public ImageData(Mat img, ImageType type,string fileName) 
        {
            this.Image = img;
            this.Type = type;
            this.fileName = fileName;
        }

        public void changeType(ImageType newType)
        {
            Type = newType;
        }
        public void updateImage(Mat img)
        {
            if ( !Image.Equals(img) )
            {
                Image = img;
            }
            UpdateEvent?.Invoke(img);
        }

    }
}
