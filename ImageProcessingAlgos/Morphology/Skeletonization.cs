using APO_Tsarehradskiy.Extensions;
using APO_Tsarehradskiy.InputArguments;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Morphology
{
    public class Skeletonization : IStrategy
    {

        public string name  { get; set; } = "Skeletonization";

        public SkeletonizationInput input { get; set; }
        public ImageData ImageData { get; set; }

        private bool Validate( ImageData img,object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not SkeletonizationInput) return false;
            this.input = parameters as SkeletonizationInput;
            this.ImageData = img;
            return true;
        }

        public async Task Run(ImageData image, object parameters)
        {
            if (!Validate(image,parameters) || !RequireBinaryImage()) throw new ArgumentException("Input or image values are invalid.");
            Mat img = ImageData.Image.Clone();

            Mat skeleton = new Mat(img.Size, DepthType.Cv8U, 1);
            await Task.Run(() =>
            {
                Mat noiseKernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                CvInvoke.MorphologyEx(img, img, MorphOp.Open, noiseKernel, new Point(-1, -1), 1, BorderType.Reflect, new MCvScalar());

                skeleton.SetTo(new MCvScalar(0)); // Black background

                Mat temp = new Mat();
                Mat eroded = new Mat();

                Mat element = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(-1, -1));

                do
                {
                    CvInvoke.MorphologyEx(img, temp, MorphOp.Open, element, new Point(-1, -1), 1, BorderType.Reflect, new MCvScalar());

                    CvInvoke.Subtract(img, temp, temp);

                    CvInvoke.BitwiseOr(skeleton, temp, skeleton);

                    CvInvoke.Erode(img, eroded, element, new Point(-1, -1), 1, BorderType.Reflect, new MCvScalar());

                    img = eroded.Clone();
                }
                while (CvInvoke.CountNonZero(img) > 0);
            });

            ImageData.updateImage(skeleton);
        }

        private bool RequireBinaryImage()
        {
            if (ImageData.ImageIsBinary()) return true;

            if (MessageBox.Show($"Image is not binary.{Environment.NewLine}Apply Otsu Thresholding + Median Blur?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return false;

            Mat temp = new Mat();
            if (ImageData.Type != Enums.Enums.Gray && ImageData.TryConvertType(Enums.Enums.Gray)) return false;

            CvInvoke.MedianBlur(ImageData.Image, temp, 3);
            ImageData.updateImage(temp);

            CvInvoke.Threshold(ImageData.Image, temp, 0, 255, ThresholdType.Binary | ThresholdType.Otsu);
            ImageData.updateImage(temp);

            if (MessageBox.Show("Invert values ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ImageData.Negation();

            return true;

        }
    }
}
