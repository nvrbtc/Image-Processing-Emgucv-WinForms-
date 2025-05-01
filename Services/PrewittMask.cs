using APO_Tsarehradskiy.Enums;

namespace APO_Tsarehradskiy.Services
{
    public class PrewittMaskProvider
    {
        private Dictionary<Prewitt, float[,]> options = new Dictionary<Prewitt, float[,]>
        {
            [Prewitt.North] = new float[,]
    {
        {  1,  1,  1 },
        {  1, -2,  1 },
        { -1, -1, -1 }
    },

            [Prewitt.NorthEast] = new float[,]
    {
        {  1,  1,  1 },
        { -1, -2,  1 },
        { -1, -1,  1 }
    },

            [Prewitt.East] = new float[,]
    {
        { -1,  1,  1 },
        { -1, -2,  1 },
        { -1,  1,  1 }
    },

            [Prewitt.SouthEast] = new float[,]
    {
        { -1, -1,  1 },
        { -1, -2,  1 },
        {  1,  1,  1 }
    },

            [Prewitt.South] = new float[,]
    {
        { -1, -1, -1 },
        {  1, -2,  1 },
        {  1,  1,  1 }
    },

            [Prewitt.SouthWest] = new float[,]
    {
        {  1, -1, -1 },
        {  1, -2, -1 },
        {  1,  1,  1 }
    },

            [Prewitt.West] = new float[,]
    {
        {  1,  1, -1 },
        {  1, -2, -1 },
        {  1,  1, -1 }
    },

            [Prewitt.NorthWest] = new float[,]
    {
        {  1,  1,  1 },
        {  1, -2, -1 },
        {  1, -1, -1 }
    }
        };
        public float[,]? GetKernel (Prewitt direction)
        {
            return options.GetValueOrDefault(direction);
        }
    }
}
