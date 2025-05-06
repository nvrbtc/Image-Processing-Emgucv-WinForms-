using APO_Tsarehradskiy.DTO;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.InputArguments
{
    public class StructuringElement
    {
        public ElementShape Shape { get; set; }
        public int Size { get; set; }
        public StructuringElement()
        {
            Shape = ElementShape.Rectangle;
            Size = 3;
        }
        public Mat GetStructuringElement()
        {
            Mat temp = new Mat().GetStructuringElement(Shape, new Size(Size, Size));
            return temp;
        }
    }
}
