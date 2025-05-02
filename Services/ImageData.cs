using APO_Tsarehradskiy.customUI.TabPageInherited;
using APO_Tsarehradskiy.Enums;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Services
{
    public record ImageData 
    {
        private Mat img;
        public ImageTabPage? parent;
        public string fileName = string.Empty;
        public event ImageUpdated UpdateEvent;
        public Enums.Enums Type { get; private set; }
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
        public ImageData(Mat img, Enums.Enums type, string fileName, ImageTabPage parent)
        {
            this.Image = img;
            this.Type = type;
            this.fileName = fileName;
            this.parent = parent;
        }

        public void changeType(Enums.Enums newType)
        {
            Type = newType;
        }
        public void updateImage(Mat img)
        {
            if (!Image.Equals(img))
            {
                Image = img;
            }
            UpdateEvent?.Invoke(this);
        }
        public bool ValidateValuesAreNull()
        {
            return img == null || string.IsNullOrWhiteSpace(fileName) || Type == default;
        }
        public ImageData DeepClone()
        {

            return new ImageData(this.Image.Clone(), this.Type, this.fileName, this.parent);
        }
        public void CopyTo(ImageData data)
        {
            data.Image = this.Image;
            data.Type = this.Type;
            data.fileName = this.fileName;
            data.parent = this.parent;
        }


    }
}
