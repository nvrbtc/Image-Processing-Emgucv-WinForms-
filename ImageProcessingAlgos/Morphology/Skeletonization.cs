using APO_Tsarehradskiy.Extensions;
using APO_Tsarehradskiy.InputArguments;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Morphology
{
    public class Skeletonization : IAlgorithmStrategy
    {

        public string name => "Skeletonization";

        public SkeletonizationInput parameters { get; set; }
        public ImageData ImageData { get; set; }

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not SkeletonizationInput)
            {
                MessageBox.Show("Wrong input type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            this.parameters = parameters as SkeletonizationInput;
            return true;
        }

        public void Run()
        {
            if (!RequireBinaryImage()) return;
            // Копируем исходное изображение
            Mat img = ImageData.Image.Clone();


            // Убираем мелкий шум морфологическим открытием
            Mat noiseKernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
            CvInvoke.MorphologyEx(img, img, MorphOp.Open, noiseKernel, new Point(-1, -1), 1, BorderType.Reflect, new MCvScalar());


            // --- Шаг 2: Скелетонизация ---
            Mat skeleton = new Mat(img.Size, DepthType.Cv8U, 1);
            skeleton.SetTo(new MCvScalar(0)); // Инициализация черным фоном

            Mat temp = new Mat();
            Mat eroded = new Mat();

            Mat element = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(3, 3), new Point(-1, -1));

            do
            {
                // Морфологическое открытие
                CvInvoke.MorphologyEx(img, temp, MorphOp.Open, element, new Point(-1, -1), 1, BorderType.Reflect, new MCvScalar());

                // Вычисляем разницу: оригинал - открытие
                CvInvoke.Subtract(img, temp, temp);

                // Накладываем на скелет
                CvInvoke.BitwiseOr(skeleton, temp, skeleton);

                // Эрозия
                CvInvoke.Erode(img, eroded, element, new Point(-1, -1), 1, BorderType.Reflect, new MCvScalar());

                img = eroded.Clone();
            }
            while (CvInvoke.CountNonZero(img) > 0);

            ImageData.updateImage(skeleton);
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
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
