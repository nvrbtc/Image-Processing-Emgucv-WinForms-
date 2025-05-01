using APO_Tsarehradskiy.ImageProcessingAlgos.Blur;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;

namespace APO_Tsarehradskiy.customUI
{
    public partial class MedianFilterWindow : Form
    {
        private ImageData imageData;
        public int Sz { get; set; } = 3;
        

        public MedianFilterWindow()
        {
            InitializeComponent();
            Bind();
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

        private void RunMethod(object sender, EventArgs e)
        {
            IAlgorithmStrategy strategy = new MedianBlur();
            if (strategy.GetParameters(Sz))
            {
                strategy.SetDataImage(imageData);
                strategy.Run();
            }
            
        }
    }
}
