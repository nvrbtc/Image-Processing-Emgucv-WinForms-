namespace APO_Tsarehradskiy.Enums
{
    public enum Enums
    {
        Default,
        Rgb,
        Gray,
        Hsv,
        Lab,
        Null
    }
    public enum Prewitt
    {
        North,
        NorthWest,
        West,
        SouthWest,
        South,
        SouthEast,
        East,
        NorthEast
    }
    public enum Strategies
    {
        None,
        Blur,
        GaussianBlur,
        MedianBlur,
        Canny,
        Laplacian,
        Sobel,
        KernelFilter,
        Equalization,
        LinearStretching,
        HoughProbabilistic,
        Hough,
        MorphologyOperations,
        Skeletonization,
        Negation,
        Posterization,
        Threshold
    }
}
