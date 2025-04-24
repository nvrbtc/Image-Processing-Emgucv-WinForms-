using APO_Tsarehradskiy.customUI;
using APO_Tsarehradskiy.Enums;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Tsarehradskiy.Services
{
    public class ImageManager
    {
        public ImageLoadResult? OpenRGBImage()
        {
            OpenFileDialog dialog = new () { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" };
            if (dialog.ShowDialog() != DialogResult.OK) return null;

            return new ImageLoadResult(new Mat(dialog.FileName, ImreadModes.Color),dialog.SafeFileName,Enums.ImageType.Rgb);
        }
        public ImageLoadResult? OpenGrayImage()
        {
            OpenFileDialog dialog = new () { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" };
            if (dialog.ShowDialog() != DialogResult.OK) return null;

            return new ImageLoadResult(new Mat(dialog.FileName, ImreadModes.Grayscale),dialog.SafeFileName,Enums.ImageType.Gray);
        }
        public ColorConversion GetQuery(ImageType sourceType, ImageType destinationType)
        {
            string query = $"{sourceType}2{destinationType}";
            if ( Enum.TryParse(typeof(ColorConversion),query,out Object result))
            {
                return (ColorConversion)result;
            }
            return default;
        }
        public void UpdateImageType(ImageTabPage tab,ImageType destinationType)
        {
            tab.Type = destinationType;
        }
        public void ChangeImageType(ImageTabPage tab,ColorConversion destinationType)
        {
            Mat result = new ();
            CvInvoke.CvtColor(tab.Img, result, destinationType);
            tab.Img = result;
        }

    }
}
