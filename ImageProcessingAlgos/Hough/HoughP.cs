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
    public class HoughP : IAlgorithmStrategy
    {
        private HoughProbInput parameters {get;set;}
        public string name => "Prob Hough";

        public ImageData ImageData { get; set; }

        public bool GetParameters(object parameters)
        {
            if ( parameters == null || parameters is not HoughProbInput) return false;
            this.parameters = parameters as HoughProbInput;
            return true;
        }

        public void Run()
        {
            if (!RequireBinaryImage()) return;
            Mat source = ImageData.Image.Clone();

            ///TODO:
            ///Ask about if canny is required here 
            Mat edgesOutput = new();
            CvInvoke.Canny(source, edgesOutput, 50, 200);

            Mat resultBGR = new Mat();
            CvInvoke.CvtColor(edgesOutput, resultBGR, ColorConversion.Gray2Bgr);

            LineSegment2D[] linesOutput =CvInvoke.HoughLinesP(edgesOutput, parameters.Rho, 
                                                              Math.PI / parameters.Theta, 
                                                              parameters.Threshold, 
                                                              parameters.MinLineLength, 
                                                              parameters.MaxLineGap);

            for (int i = 0; i < linesOutput.Length; i++)
            {
                CvInvoke.Line(resultBGR, linesOutput[i].P1, linesOutput[i].P2, new MCvScalar(0, 0, 255), parameters.LineThickness, parameters.LineType);
            }

            ImageData.changeType(Enums.Enums.Rgb); // result => Grayscale img + Red lines
            ImageData.updateImage( resultBGR );
        }

        public void SetDataImage(ImageData img)
        {
            this.ImageData = img;
        }
        private bool RequireBinaryImage()
        {
            if (ImageData.ImageIsBinary()) return true;

            if (MessageBox.Show($"Image is not binary.{Environment.NewLine}Apply Otsu Thresholding?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return false;

            if (ImageData.Type != Enums.Enums.Gray && ImageData.TryConvertType(Enums.Enums.Gray)) return false;

            Mat mat = new Mat();
            CvInvoke.Threshold(ImageData.Image, mat, 0, 255, ThresholdType.Binary | ThresholdType.Otsu);
            ImageData.updateImage(mat);

            if (MessageBox.Show("Invert values ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ImageData.Negation();

            return true;
        }
    }
}
