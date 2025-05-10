using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Apo.DTO
{
    public static class ImageExtensions
    {
        public static Bitmap UpdatePicBoxImage(this ImageData data)
        {
            //todo: implement switch return
            return null;
        }

        public static int[] GetHistogramValues(this Mat img)
        {
            byte[]? data = img.GetData(false) as byte[];
            int[] histogramValues = new int[256];

            foreach (var t in data)
            {
                histogramValues[t]++;
            }
            return histogramValues;
        }
        public static int[] GetDistributionValues(this Mat img)
        {
            int[] distributionValues = new int[256];
            int[] histogramValues = img.GetHistogramValues();

            for (int i = 0, sum = 0; i < 256; i++)
            {
                sum += histogramValues[i];
                distributionValues[i] = sum;
            }
            return distributionValues;
        }
        public static int GetMinValue(this Mat img)
        {
            int[] data = img.GetHistogramValues();
            return Array.FindIndex(data, value => value > 0);
        }
        public static int GetMaxValue(this Mat img)
        {
            int[] data = img.GetHistogramValues();
            return Array.FindLastIndex(data, value => value > 0);
        }
        public static Mat GetStructuringElement(this Mat img, ElementShape shape, Size sz)
        {
            if (sz.Width < 0 || sz.Height < 0) throw new ArgumentException("Wrong size");
            if (shape != ElementShape.Custom)
            {
                return CvInvoke.GetStructuringElement(shape, sz, new Point(-1, 1));
            }
            if (sz.Width != sz.Height && sz.Width % 2 != 1) throw new ArgumentException("Wrong size");

            int radius = sz.Width / 2;
            var image = new Image<Gray, byte>(sz.Width, sz.Width);
            
            for (int i = 0; i < sz.Width; i++)
            {
                for (int j = 0; j < sz.Width; j++)
                {
                    int dx = Math.Abs(i - radius);
                    int dy = Math.Abs(j - radius);
                    image.Data[i, j, 0] = (byte)(dx + dy <= radius ? 1 : 0);
                }
            }

            return image.Mat;
        }
        public static bool ImageIsBinary(this ImageData data)
        {
            if (data.Type != ImageType.Gray) return false;

            var values = data.Image.GetHistogramValues();

            for (int i = 1; i < 255; i++)
            {
                if (values[i] != 0) return false;
            }
            return true;

        }
        public static bool TryConvertType(this ImageData imageData, ImageType destinationType)
        {
            string query = $"{imageData.Type}2{destinationType}";

            if (!Enum.TryParse(query, out ColorConversion result)) return false;

            Mat mat = new Mat();
            CvInvoke.CvtColor(imageData.Image, mat, result);
            imageData.UpdateImage(mat);
            imageData.ChangeType(destinationType);
            return true;
        }
        public static void Negation(this ImageData imageData)
        {
            
            byte[]? updatedValues = imageData.Image.GetData(false) as byte[];
            
            for (int i = 0; i < updatedValues!.Length; i++)
            {
                updatedValues[i] = (byte)(255 - updatedValues[i]);
            }
            Mat afterNegation =imageData.Image.Clone();
            afterNegation.SetTo(updatedValues);
            imageData.UpdateImage(afterNegation);
        }
    }
}
