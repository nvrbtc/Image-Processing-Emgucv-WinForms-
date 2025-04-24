using APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Tsarehradskiy.customUI
{
    public partial class PosterizationWindow : Form
    {
        private int levels;
        private ImageData imageData; // original image is stays without changes
        public int Levels
        {
            get
            {
                return levels;
            }
            set
            {
                levels = value;
            }
        }
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
            if (this.trackLevels != null)
            {
                textLevels.DataBindings.Add(nameof(textLevels.Text), trackLevels, nameof(trackLevels.Value), false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (imageData.Type != Enums.ImageType.Gray) return;
            double levels = int.Parse(textLevels.Text);
            IAlgorithmStrategy strategy = new Posterization();
            strategy.SetDataImage(imageData);
            strategy.GetParameters(levels);
            strategy.Run();

        }
    }
}
