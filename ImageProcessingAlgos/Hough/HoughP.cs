using APO_Tsarehradskiy.InputArguments.Hough;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APO_Tsarehradskiy.Extensions;

namespace APO_Tsarehradskiy.ImageProcessingAlgos.Hough
{
    public class HoughP : IStrategy
    {
        private HoughProbInput input {get;set;}
        public string name => "Prob Hough";

        public ImageData ImageData { get; set; }

        private bool Validate( ImageData imageData ,object parameters)
        {
            if (imageData?.ValidateValuesAreNull() == true || parameters is not HoughProbInput) return false;
            this.input = parameters as HoughProbInput;
            this.ImageData = imageData;
            return true;
        }

        public async Task Run(ImageData imageData,object parameters)
        {
            if (!Validate(imageData,parameters) || !EnsureImageIsBinary()) throw new ArgumentException("Input or image values are invalid.");
            Mat resultBGR = new Mat();
            await Task.Run(() =>
            {
                Mat source = ImageData.Image.Clone();
                ///TODO:
                ///Ask about if canny is required here 
                Mat edgesOutput = new();
                CvInvoke.Canny(source, edgesOutput, 50, 200);

               
                CvInvoke.CvtColor(edgesOutput, resultBGR, ColorConversion.Gray2Bgr);
                LineSegment2D[] linesOutput = CvInvoke.HoughLinesP(edgesOutput, input.Rho,
                                                              Math.PI / input.Theta,
                                                              input.Threshold,
                                                              input.MinLineLength,
                                                              input.MaxLineGap);

                foreach(var line in linesOutput)
                {
                    CvInvoke.Line(resultBGR, line.P1, line.P2, new MCvScalar(0, 0, 255), input.LineThickness, input.LineType);
                }
            });

            ImageData.changeType(Enums.Enums.Rgb); // result => Grayscale img + Red lines
            ImageData.updateImage( resultBGR );
        }

        private bool EnsureImageIsBinary()
        {
            if (ImageData.ImageIsBinary()) return true;

            if (MessageBox.Show($"Image is not binary.{Environment.NewLine}Apply Otsu Thresholding?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return false;

            if (ImageData.Type != Enums.Enums.Gray && !ImageData.TryConvertType(Enums.Enums.Gray)) return false;

            Mat mat = new Mat();
            CvInvoke.Threshold(ImageData.Image, mat, 0, 255, ThresholdType.Binary | ThresholdType.Otsu);
            ImageData.updateImage(mat);

            if (MessageBox.Show("Invert values ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ImageData.Negation();

            return true;
        }
    }
}
