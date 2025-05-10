using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;

namespace Apo.ImageProcessingAlgos
{
    public class HoughP : IStrategy
    {
        private HoughProbInput input;
        public string Name { get; set; } = "Prob Hough";

        private ImageData ImageData;

        private bool Validate( ImageData imageData ,object parameters)
        {
            if (imageData?.ValidateValuesAreNull() == true || parameters is not HoughProbInput probInput) return false;
            this.input = probInput;
            this.ImageData = imageData;
            return true;
        }

        public async Task Run(ImageData imageData,object parameters)
        {
            if (!Validate(imageData,parameters) || !EnsureImageIsBinary()) throw new ArgumentException("Input or image values are invalid.");
            var resultBgr = new Mat();
            await Task.Run(() =>
            {
                var source = ImageData.Image.Clone();
                
                //TODO:
                //Ask about if canny is required here 
                Mat edgesOutput = new();
                CvInvoke.Canny(source, edgesOutput, 50, 200);

               
                CvInvoke.CvtColor(edgesOutput, resultBgr, ColorConversion.Gray2Bgr);
                var linesOutput = CvInvoke.HoughLinesP(edgesOutput, input.Rho,
                                                              Math.PI / input.Theta,
                                                              input.Threshold,
                                                              input.MinLineLength,
                                                              input.MaxLineGap);

                foreach(var line in linesOutput)
                {
                    CvInvoke.Line(resultBgr, line.P1, line.P2, new MCvScalar(0, 0, 255), input.LineThickness, input.LineType);
                }
                DisposeAllMats(source,edgesOutput);
            });

            ImageData.ChangeType(ImageType.Rgb); // result => Grayscale img + Red lines
            ImageData.UpdateImage( resultBgr );
        }

        private bool EnsureImageIsBinary()
        {
            if (ImageData.ImageIsBinary()) return true;

            if (MessageBox.Show($"Image is not binary.{Environment.NewLine}Apply Otsu Thresholding?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return false;

            if (ImageData.Type != ImageType.Gray && !ImageData.TryConvertType(ImageType.Gray)) return false;

            var mat = new Mat();
            CvInvoke.Threshold(ImageData.Image, mat, 0, 255, ThresholdType.Binary | ThresholdType.Otsu);
            ImageData.UpdateImage(mat);

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
