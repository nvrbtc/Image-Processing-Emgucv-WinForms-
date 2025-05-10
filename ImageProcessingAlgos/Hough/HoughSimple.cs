using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;

namespace Apo.ImageProcessingAlgos
{
    public class HoughSimple : IStrategy
    {
        public string Name { get; set; } = "Hough Lines";

        public ImageData ImageData { get; set; }
        private HoughSimpleInput input;

        private bool Validate(ImageData img, object parameters)
        {
            if (img?.ValidateValuesAreNull() == true || parameters is not HoughSimpleInput) return false;

            this.ImageData = img;
            this.input = parameters as HoughSimpleInput;
            return true;
        }

        public async Task Run(ImageData imageData, object parameters)
        {
            if (!Validate(imageData, parameters) || !EnsureImageIsBinary()) throw new ArgumentException("Input or image values are invalid.");

            Mat resultBgr = new Mat();
            await Task.Run(() =>
            {
                Mat source = ImageData.Image.Clone();

                Mat edgesOutput = new();
                CvInvoke.Canny(source, edgesOutput, 50, 200);
                CvInvoke.CvtColor(edgesOutput, resultBgr, ColorConversion.Gray2Bgr);
                var linesOutput = new Mat();
                CvInvoke.HoughLines(edgesOutput, linesOutput, //TODO: research if its possible to pass LineSegment2DF somehow
                                    input.Rho,
                                    Math.PI / input.Theta,
                                    input.Theta,
                                    input.Srn, input.Stn);

                var pointsData = linesOutput?.GetData() as float[,,];
                for (int i = 0; i < pointsData?.GetLength(0); i++)
                {

                    float rho = pointsData[i, 0, 0];
                    float theta = pointsData[i, 0, 1];

                    double a = Math.Cos(theta);
                    double b = Math.Sin(theta);

                    double x0 = a * rho;
                    double y0 = b * rho;

                    var pt1 = new Point((int)Math.Round(x0 + 1000 * -b), (int)Math.Round(y0 + 1000 * a));
                    var pt2 = new Point((int)Math.Round(x0 - 1000 * -b), (int)Math.Round(y0 - 1000 * a));


                    CvInvoke.Line(resultBgr, pt1, pt2, new MCvScalar(0, 0, 255), input.LineThickness, input.LineType);
                }
                DisposeAllMats(source,edgesOutput,linesOutput);
            });

            ImageData.ChangeType(ImageType.Rgb); // result => Grayscale source image + Red lines
            ImageData.UpdateImage(resultBgr);

        }
        private bool EnsureImageIsBinary()
        {
            if (ImageData.ImageIsBinary()) return true;

            if (MessageBox.Show($"Image is not binary.{Environment.NewLine}Apply Otsu Thresholding?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return false;

            
            if (ImageData.Type != ImageType.Gray && !ImageData.TryConvertType(ImageType.Gray)) return false;

            Mat afterThreshold = new Mat();
            CvInvoke.Threshold(ImageData.Image, afterThreshold, 0, 255, ThresholdType.Binary | ThresholdType.Otsu);
            ImageData.UpdateImage(afterThreshold);
            if (MessageBox.Show("Invert values ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ImageData.Negation();

            return true;
        }

        private void DisposeAllMats(params Mat[] mats)
        {
            foreach (var mat in mats)
            {
                mat?.Dispose();
            }
        } 
    }
}
