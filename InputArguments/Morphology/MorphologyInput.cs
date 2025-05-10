using Emgu.CV;
using Emgu.CV.CvEnum;

namespace Apo.InputArguments
{
    public class MorphologyInput
    {
        public MorphOp Operation { get; set; } = MorphOp.Erode;
        public Mat StructElement { get; set; } = new Mat();
        public Point Anchor { get; set; } = new Point(-1, -1);
        public int Iterations { get; set; } = 1;
        public BorderType BorderType { get; set; } =  BorderType.Replicate;

    }
}
