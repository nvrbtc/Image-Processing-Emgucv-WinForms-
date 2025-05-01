using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using APO_Tsarehradskiy.InputArguments.Hough;
using APO_Tsarehradskiy.Extensions;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Hough
{
    public class HoughSimple : IAlgorithmStrategy
    {
        
        public string name => "Hough Lines";

        public ImageData ImageData { get; set; }
        private HoughSimpleInput parameters;

        public bool GetParameters(object parameters)
        {
            if (parameters == null || parameters is not HoughSimpleInput)
            {
                return false;
            }
            this.parameters = parameters as HoughSimpleInput;
            return true;
        }

        public void Run()
        {
            if (!RequireBinaryImage()) return;
            Mat source = ImageData.Image.Clone();

            Mat edgesOutput = new();
            CvInvoke.Canny(source, edgesOutput, 50, 200);

            Mat resultBGR = new Mat();
            CvInvoke.CvtColor(edgesOutput, resultBGR, ColorConversion.Gray2Bgr); 

            var linesOutput = new Mat();
            CvInvoke.HoughLines(edgesOutput, linesOutput, ///TODO: research if its possible to pass LineSegment2DF somehow
                                parameters.Rho, 
                                Math.PI / parameters.Theta, 
                                parameters.Theta,
                                parameters.Srn,parameters.Stn);

            float[,,] pointsData = linesOutput.GetData() as float[,,];
            for (int i = 0; i < pointsData?.GetLength(0); i++)
            {

                float rho = pointsData[i, 0, 0];
                float theta = pointsData[i, 0, 1];

                double a = Math.Cos(theta);
                double b = Math.Sin(theta);

                double x0 = a * rho;
                double y0 = b * rho;

                Point pt1 = new Point((int)Math.Round(x0 + 1000 * -b), (int)Math.Round(y0 + 1000 * a));
                Point pt2 = new Point((int)Math.Round(x0 - 1000 * -b), (int)Math.Round(y0 - 1000 * a));


                CvInvoke.Line(resultBGR, pt1, pt2, new MCvScalar(0, 0, 255), parameters.LineThickness, parameters.LineType);
            }

            ImageData.changeType(Enums.Enums.Rgb); // result => Grayscale src image + Red lines
            ImageData.updateImage(resultBGR);

        }

        public void SetDataImage(ImageData img)
        {
            ImageData = img;
        }
        private bool RequireBinaryImage()
        {
            if (ImageData.ImageIsBinary()) return true;

            if (MessageBox.Show($"Image is not binary.{Environment.NewLine}Apply Otsu Thresholding?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return false;

            Mat mat = new Mat();
            if (ImageData.Type != Enums.Enums.Gray && ImageData.TryConvertType(Enums.Enums.Gray)) return false;

            CvInvoke.Threshold(ImageData.Image, mat, 0, 255, ThresholdType.Binary | ThresholdType.Otsu);
            ImageData.updateImage(mat);
            if (MessageBox.Show("Invert values ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ImageData.Negation();

            return true;
        }
    }
}
