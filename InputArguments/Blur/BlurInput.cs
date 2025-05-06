using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.InputArguments
{
    public record BlurInput
    {
        public BorderType BorderType { get; set; } = BorderType.Reflect;
        public Size Size  =  new Size(3,3);
    }
}
