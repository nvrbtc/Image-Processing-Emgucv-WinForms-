using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Extensions
{
    public static class MatExtension
    {
        public static int[] GetHistogramValues(this Mat img)
        {
            ReadOnlySpan<byte> data = img.GetData(false) as byte[];
            int[] histogramValues = new int[256];

            for (int i = 0; i < data.Length; i++)
            {
                histogramValues[data[i]]++;
            }
            return histogramValues;
        }
        public static int[] GetDistributionValues(this Mat img)
        {
            int[] distributionValues = new int[256];
            int[] histagramValues = img.GetHistogramValues();

            for ( int i = 0,sum = 0; i < 256; i++)
            {
                sum+= histagramValues[i];
                distributionValues[i] = sum;
            }
            return distributionValues;
        }
        public static int GetMinValue(this Mat img)
        {
            int[] data = img.GetHistogramValues();
            return Array.FindIndex(data,value => value>0);
        }
        public static int GetMaxValue(this Mat img)
        {
            int[] data = img.GetHistogramValues();
            return Array.FindLastIndex(data,value => value>0);
        }
    }
}
