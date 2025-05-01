using APO_Tsarehradskiy.customUI.TabPageInherited;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Drawing;

namespace APO_Tsarehradskiy.Services
{
    public class ImageManager
    {
        public ImageLoadResult? OpenRGBImage()
        {
            OpenFileDialog dialog = new () { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif" };
            if (dialog.ShowDialog() != DialogResult.OK) return null;

            return new ImageLoadResult(new Mat(dialog.FileName, ImreadModes.Color),dialog.SafeFileName,Enums.Enums.Rgb);
        }
        public ImageLoadResult? OpenGrayImage()
        {
            OpenFileDialog dialog = new () { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif" };
            if (dialog.ShowDialog() != DialogResult.OK) return null;

            return new ImageLoadResult(new Mat(dialog.FileName, ImreadModes.Grayscale),dialog.SafeFileName,Enums.Enums.Gray);
        }
        public ColorConversion GetQuery(Enums.Enums sourceType, Enums.Enums destinationType)
        {
            string query = $"{sourceType}2{destinationType}";
            if (Enum.TryParse(typeof(ColorConversion), query, out Object result))
            {
                return (ColorConversion)result;
            }
            
            

            return default;
        }
        public void UpdateImageType(ImageTabPage tab, Enums.Enums destinationType)
        {
            tab.Type = destinationType;
        }
        public void ChangeImageType(ImageTabPage tab,ColorConversion destinationType)
        {
            Mat result = new ();
            CvInvoke.CvtColor(tab.Img, result, destinationType);
            tab.imageData.updateImage( result);
            
        }
       

    }
}
