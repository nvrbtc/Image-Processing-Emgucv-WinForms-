using APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;

namespace APO_Tsarehradskiy.customUI
{
    public partial class PosterizationWindow : Form
    {
      
        private ImageData imageData;
        public int Levels
        {
            get;
            set;
        } = 8;

        public PosterizationWindow()
        {
            InitializeComponent();
            BindData();
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            IStrategy? strategy = new Posterization();
            strategy?.Run(imageData,Levels);
        }
    }
}
