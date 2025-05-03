using APO_Tsarehradskiy.Services;

namespace APO_Tsarehradskiy.customUI
{
    public partial class MedianFilterWindow : Form
    {
        private ImageData imageData;
        private readonly StrategyExecutor executor;

        public int Sz { get; set; } = 3;
        

        public MedianFilterWindow(StrategyExecutor executor)
        {
            InitializeComponent();
            Bind();
            this.executor = executor;
        }
        private void Bind()
        {
            
            if (numSize != null)
            {
                numSize.DataBindings.Add(nameof(numSize.Value), this, nameof(this.Sz), false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        
        public void SetImageData(ImageData imageData)
        {
            this.imageData = imageData;
        }

        private async void RunMethod(object sender, EventArgs e)
        {
            await executor.PerformStrategy(Enums.Strategies.MedianBlur,this.imageData,this.Sz);
        }
    }
}
