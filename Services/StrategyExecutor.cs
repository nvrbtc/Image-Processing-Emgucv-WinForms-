using APO_Tsarehradskiy.customUI.TabPageInherited;
using APO_Tsarehradskiy.Enums;
using APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale;
using APO_Tsarehradskiy.ImageProcessingAlgos.Blur;
using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.ImageProcessingAlgos.Filter;
using APO_Tsarehradskiy.ImageProcessingAlgos.HistogramProcessing;
using APO_Tsarehradskiy.ImageProcessingAlgos.Hough;
using APO_Tsarehradskiy.ImageProcessingAlgos.Morphology;
using APO_Tsarehradskiy.ImageProcessingAlgos.SingleArgument;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services.Interfaces;

namespace APO_Tsarehradskiy.Services
{
    public class StrategyExecutor
    {
        private readonly Dictionary<Enums.Strategies, Func<APO_Tsarehradskiy.Interfaces.IStrategy>> strategiesPool = new Dictionary<Enums.Strategies, Func<APO_Tsarehradskiy.Interfaces.IStrategy>>()
        {
            { Enums.Strategies.Blur,() => new Blur() },
            { Enums.Strategies.GaussianBlur,() => new GaussianBlur() },
            { Enums.Strategies.MedianBlur,() => new MedianBlur() },
            { Enums.Strategies.Canny, () => new Canny() },
            { Enums.Strategies.Laplacian,() => new Laplacian() },
            { Enums.Strategies.Sobel, () => new Sobel() },
            { Enums.Strategies.KernelFilter, () => new KernelFilter() },
            { Enums.Strategies.Equalization, () => new Equalization() },
            { Enums.Strategies.LinearStretching ,() => new LinearStretching() },
            { Enums.Strategies.HoughProbabilistic, () => new HoughP() },
            { Enums.Strategies.Hough,() => new HoughSimple() },
            { Enums.Strategies.MorphologyOperations ,() => new Morphology() },
            { Enums.Strategies.Skeletonization ,() => new Skeletonization() },
            { Enums.Strategies.Negation, () => new Negation() },
            { Enums.Strategies.Posterization ,() => new Posterization() },
            { Enums.Strategies.Threshold,() => new Threshold() }
        };
        private readonly ITabManager manager;

        public StrategyExecutor(ITabManager manager)
        {
            this.manager = manager;
        }
        public async Task PerformStrategy(Enums.Strategies s, ImageData imageData, object parameters)
        {
            var tab = imageData.parent;
            var strategy = strategiesPool[s].Invoke();
            ImageData copyOfSource = imageData.DeepClone();
            try
            {
                await strategy.Run(imageData, parameters);
                tab?.UpdateLogTree(imageData, strategy.name);
            }
            catch (Exception e)
            {
                copyOfSource.CopyTo(imageData);
                MessageBox.Show(e.Message, "Error while execution.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                copyOfSource.Image.Dispose();
            }
        }
    }
}
