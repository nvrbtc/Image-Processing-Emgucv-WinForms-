using Emgu.CV.CvEnum;

namespace Apo.InputArguments;

public record PyramidInput(BorderType BorderType,bool IsDown,int Iterations);