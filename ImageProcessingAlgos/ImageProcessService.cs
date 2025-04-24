using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.Dai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.ImageProcessingAlgos
{
    public class ImageProcessService
    {
        private IAlgorithmStrategy _algorithmStrategy;
        public ImageProcessService()
        {

        }
        public ImageProcessService(IAlgorithmStrategy algorithmStrategy)
        {
            _algorithmStrategy = algorithmStrategy;
        }
        public void SetAlgo(IAlgorithmStrategy strategy)
        {
            _algorithmStrategy = strategy;
        }
        public void Process()
        {
            _algorithmStrategy?.Run();
        }
        public void GetParameters(object parameters)
        {
            _algorithmStrategy.GetParameters(parameters);

        }
        public void SetImageData(ImageData imageData)
        {
            _algorithmStrategy.SetDataImage(imageData);
        }
    }
}
