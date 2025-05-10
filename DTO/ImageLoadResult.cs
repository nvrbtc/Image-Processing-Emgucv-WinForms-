using Emgu.CV;

namespace Apo.DTO
{
    public record ImageLoadResult(Mat Image, string FileName, ImageType ImageType)
    {
        public readonly Mat Image = Image;
        public readonly string FileName = FileName;
        public readonly ImageType ImageType = ImageType;
    }
}
