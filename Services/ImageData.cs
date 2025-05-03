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
        public void Restore(ImageData restoredData)
        {
            this.Image = restoredData.Image;
            this.Type = restoredData.Type;
            UpdateEvent?.Invoke(this);
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
            this.Image?.Dispose();
            this.Image = data.Image.Clone();
            this.Type = data.Type;
            this.fileName = data.fileName;
            this.parent = data.parent;
        }


    }
}
