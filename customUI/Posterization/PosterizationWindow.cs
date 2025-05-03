using APO_Tsarehradskiy.Services;

namespace APO_Tsarehradskiy.customUI
{
    public partial class PosterizationWindow : Form
    {
      
        private ImageData imageData;
        private readonly StrategyExecutor executor;

        public int Levels
        {
            get;
            set;
        } = 8;

        public PosterizationWindow(StrategyExecutor executor)
        {
            InitializeComponent();
            BindData();
            this.executor = executor;
        }
        public void SetImageData(ImageData imageData)
        {
            this.imageData = imageData;
        }
        public void BindData()
        {
            
            if ( numLevels != null  )
            {
                numLevels.DataBindings.Add(nameof ( numLevels.Value),this,nameof(this.Levels),false,DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private async void RunStrategy(object sender, EventArgs e)
        {
            await executor.PerformStrategy(Enums.Strategies.Posterization, this.imageData, Levels);
        }
    }
}
