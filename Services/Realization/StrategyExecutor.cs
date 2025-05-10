using Apo.DTO;
using Apo.ImageProcessingAlgos;
using APO_Tsarehradskiy.Services.Interfaces;

namespace APO_Tsarehradskiy.Services.Realization
{
    public class StrategyExecutor
    {
        private readonly Dictionary<Strategies, Func<IStrategy>> strategiesPool = new Dictionary<Strategies, Func<IStrategy>>()
        {
            { Strategies.Blur,() => new Blur() },
            { Strategies.GaussianBlur,() => new GaussianBlur() },
            { Strategies.MedianBlur,() => new MedianBlur() },
            { Strategies.Canny, () => new Canny() },
            { Strategies.Laplacian,() => new Laplacian() },
            { Strategies.Sobel, () => new Sobel() },
            { Strategies.KernelFilter, () => new KernelFilter() },
            { Strategies.Equalization, () => new Equalization() },
            { Strategies.LinearStretching ,() => new LinearStretching() },
            { Strategies.HoughProbabilistic, () => new HoughP() },
            { Strategies.Hough,() => new HoughSimple() },
            { Strategies.MorphologyOperations ,() => new Morphology() },
            { Strategies.Skeletonization ,() => new Skeletonization() },
            { Strategies.Negation, () => new Negation() },
            { Strategies.Posterization ,() => new Posterization() },
            { Strategies.Threshold,() => new Threshold() },
            { Strategies.Pyramid,() => new Pyramid() }
        };

        public async Task PerformStrategy(Strategies s, ImageData imageData, object parameters)
        {
            var strategy = strategiesPool[s].Invoke();
            ImageData copyOfSource = imageData.DeepClone();
            try
            {
                await strategy.Run(imageData, parameters);
                imageData.UpdateHistory(strategy.Name);
            }
            catch (Exception e)
            {
                imageData.CopyFrom(copyOfSource);
                MessageBox.Show(e.Message, "Error while execution.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                copyOfSource.Image?.Dispose();
            }
        }
    }
}
