using APO_Tsarehradskiy.customUI.Edgecontrol;
using APO_Tsarehradskiy.customUI.EdgeMethodHandling;
using APO_Tsarehradskiy.ImageProcessingAlgos.Blur;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APO_Tsarehradskiy.customUI
{
    public partial class MedianFilterWindow : Form
    {
        private ImageData imageData;
        private int size = 3;
        public int Sz
        {
            get
            {
                return size;
            }
            set
            {
                size =  value * 2 + 1;
            }
        }

        public MedianFilterWindow()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            if (tbSize != null)
            {
                tbSize.DataBindings.Add(nameof(tbSize.Text), this, nameof(this.Sz), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (trSize != null)
            {
                this.DataBindings.Add(nameof(this.Sz), trSize, nameof(trSize.Value), false, DataSourceUpdateMode.OnPropertyChanged);
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
