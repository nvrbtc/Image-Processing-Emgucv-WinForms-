using Emgu.CV;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.InputArguments.Morphology
{
    public class MorphologyInput
    {
        public MorphOp Operation { get; set; }
        public Mat StructElement { get; set; }
        public Point Anchor { get; set; }
        public int Iterations { get; set; }
        public BorderType BorderType
        {
            get;
            set;
        }

        public MorphologyInput()
        {
            Operation = MorphOp.Erode;
            StructElement = new Mat();
            Anchor = new Point(-1, -1);
            Iterations = 1;
            BorderType = BorderType.Replicate;
        }

    }
}
