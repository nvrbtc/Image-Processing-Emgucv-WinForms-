namespace APO_Tsarehradskiy.InputArguments.Usercontrols
{
    public class MatrixRow
    {
        public float X1 { get; set; }
        public float X2 { get; set; }
        public float X3 { get; set; }
        public MatrixRow(float x1, float x2, float x3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
        }
        public float[] ReturnValues()
        {
            return new[] { X1, X2, X3 };
        }
    }
}
