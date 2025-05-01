using APO_Tsarehradskiy.Interfaces;

namespace APO_Tsarehradskiy.Services
{
    public class StrategyService
    {
        private IAlgorithmStrategy _algorithmStrategy;
        public StrategyService()
        {

        }
        public StrategyService(IAlgorithmStrategy algorithmStrategy)
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
