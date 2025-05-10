using Emgu.CV.CvEnum;

namespace Apo.InputArguments
{
    public record BlurInput
    {
        public BorderType BorderType { get; set; } = BorderType.Reflect;
        public Size Size  =  new Size(3,3);
    }
}
