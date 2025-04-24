using APO_Tsarehradskiy.ImageProcessingAlgos.EdgeDetection;
using APO_Tsarehradskiy.InputTypes;
using APO_Tsarehradskiy.Interfaces;
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

namespace APO_Tsarehradskiy.customUI.EdgeMethodHandling
{
    public partial class LaplacianUI : UserControl,IGetStrategy
    {
        private LaplacianInput input;

        public DepthType Depth
        {
            get
            {
                return input.ddepth;
            }
            set
            {
                input.ddepth = value;
            }
        }
        public string Sz
        {
            get
            {
                return input.kSize.ToString();
            }
            set
            {
                if (int.TryParse(value, out int kSize))
                    input.kSize = kSize;
            }
        }
        public string ScaleVal
        {
            get
            {
                return input.scale.ToString();
            }
            set
            {
                if ( double.TryParse(value,out double kScale) )
                    input.scale = kScale;
            }
        }
        public BorderType BorderType
        {
            get
            {
                return input.borderType;
            }
            set
            {
                input.borderType = value;
            }
        }
        public string Delta
        {
            get
            {
                return input.delta.ToString();
            }
            set
            {
                if ( double.TryParse(value,out double kDelta) )
                    input.delta = kDelta;
            }
        }
        public LaplacianUI()
        {
            InitializeComponent();
            Bind();
            input = new LaplacianInput(DepthType.Cv8S, 3, 1, 0, BorderType.Reflect);
        }

        public void Bind()
        {
            if (cbBorder != null)
            {
                cbBorder.DataSource = new[]
                {
                    new ComboBoxInput<BorderType>{Text = "Reflect",Value = BorderType.Reflect },
                    new ComboBoxInput<BorderType>{Text = "Isolated",Value = BorderType.Isolated },
                    new ComboBoxInput<BorderType>{Text = "Replicate",Value = BorderType.Replicate }
                };
                cbBorder.DisplayMember = "Text";
                cbBorder.ValueMember = "Value";
                cbBorder.DataBindings.Add(nameof(cbBorder.SelectedValue),this,nameof(BorderType),false,DataSourceUpdateMode.OnPropertyChanged);
                cbBorder.SelectedIndex = 0;
            }
            if (cbDepth != null)
            {
                cbDepth.DataSource = Enum.GetValues(typeof(DepthType));
                cbDepth.DataBindings.Add(nameof(cbDepth.SelectedItem),this,nameof(Depth),false,DataSourceUpdateMode.OnPropertyChanged) ;
            }
            if ( numSize != null )
            {
                numSize.DataBindings.Add(nameof(numSize.Value),this,nameof(this.Sz),false,DataSourceUpdateMode.OnPropertyChanged) ;
            }
            if ( tbScale != null)
            {
                tbScale.DataBindings.Add(nameof(tbScale.Text),this,nameof(this.ScaleVal),false, DataSourceUpdateMode.OnPropertyChanged) ;
            }
            if (tbDelta != null)
            {
                tbDelta.DataBindings.Add(nameof(tbDelta.Text),this,nameof(this.Delta),false, DataSourceUpdateMode.OnPropertyChanged) ;
            }
        }
        public IAlgorithmStrategy GetInstance()
        {
            return input.createInstace();
        }

        private void checkIfDigit(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else if ( !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
