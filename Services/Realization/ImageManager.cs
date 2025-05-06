using APO_Tsarehradskiy.DTO;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.Services
{
    public class ImageManager
    {
        public ImageLoadResult? OpenRGBImage()
        {
            OpenFileDialog dialog = new() { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif" };
            if (dialog.ShowDialog() != DialogResult.OK) return null;

            return new ImageLoadResult(new Mat(dialog.FileName, ImreadModes.Color), dialog.SafeFileName, Enums.Rgb);
        }
        public ImageLoadResult? OpenGrayImage()
        {
            OpenFileDialog dialog = new() { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif" };
            if (dialog.ShowDialog() != DialogResult.OK) return null;

            return new ImageLoadResult(new Mat(dialog.FileName, ImreadModes.Grayscale), dialog.SafeFileName, Enums.Gray);
        }
        public ColorConversion GetQuery(Enums sourceType, Enums destinationType)
        {
            string query = $"{sourceType}2{destinationType}";
            ColorConversion result;
            return Enum.TryParse(query, out result) ? result : default;
        }
        public void UpdateImageType(ImageData data, Enums destinationType)
        {
            data.changeType(destinationType);
        }
        public void ChangeImageType(ImageData data, ColorConversion destinationType)
        {
            Mat result = new();
            CvInvoke.CvtColor(data.Image, result, destinationType);
            data.updateImage(result);

        }


    }
}
