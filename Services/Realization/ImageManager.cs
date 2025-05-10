using Apo.DTO;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.Services.Realization
{
    public class ImageManager
    {
        public ImageLoadResult? OpenRgbImage()
        {
            using OpenFileDialog dialog = new();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif";
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    return new ImageLoadResult(new Mat(dialog.FileName, ImreadModes.Color), dialog.SafeFileName,
                        ImageType.Rgb);
            }
            catch (Exception ex)
            {
                //TODO: Logger
            }

            return null;
        }

        public ImageLoadResult? OpenGrayImage()
        {
            using OpenFileDialog dialog = new();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif";

            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    return new ImageLoadResult(new Mat(dialog.FileName, ImreadModes.Grayscale), dialog.SafeFileName,
                        ImageType.Gray);
            }
            catch (Exception e)
            {
                //TODO: Logger
            }

            return null;
        }

        public ColorConversion GetQuery(ImageType sourceType, ImageType destinationType)
        {
            string query = $"{sourceType}2{destinationType}";
            return Enum.TryParse(query, out ColorConversion result) ? result : default;
        }

        public void UpdateImageType(ImageData data, ImageType destinationType)
        {
            data.ChangeType(destinationType);
        }

        public void ChangeImageType(ImageData data, ColorConversion destinationType)
        {
            Mat result = new();
            CvInvoke.CvtColor(data.Image, result, destinationType);
            data.UpdateImage(result);
        }
    }
}