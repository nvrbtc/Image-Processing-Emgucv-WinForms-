using Emgu.CV;

namespace APO_Tsarehradskiy.DTO
{
    public class ImageLoadResult
    {
        public Mat img;
        public string fileName = string.Empty;
        public Enums imageType;
        public ImageLoadResult(Mat input, string name, Enums type)
        {
            img = input;
            fileName = name;
            imageType = type;
        }
    }
}
