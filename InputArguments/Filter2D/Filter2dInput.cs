using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.InputArguments

{
    public class Filter2dInput
    {
        public float[,] Kernel = new float[3, 3];
        public double Delta{get;set;} = 0;
        public BorderType Border { get; set; } = BorderType.Reflect;
        public Point Point = new Point(-1, -1);

        public bool NormalizeKernel()
        {
            float sum = 0;
            foreach(float i  in Kernel) { sum += i; }
            if (sum == 0) return false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Kernel[i, j] /= sum;
                }
            }
            return true;
        }
    }
}
