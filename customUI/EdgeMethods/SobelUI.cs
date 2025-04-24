using APO_Tsarehradskiy.customUI.EdgeMethodHandling;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace APO_Tsarehradskiy.customUI.Edgecontrol
{
    public partial class SobelUI : UserControl,IGetStrategy
    {
        //params
        private SobelInput input;
        public string xValue
        {
            get
            {
                return input.dX.ToString();
            }
            set
            {
                if (int.TryParse(value, out int temp))
                {
                    input.dX = temp >= 0 ? temp : input.dX;
                }

            }
        }
        public string yValue
        {
            get
            {
                return input.dY.ToString();
            }
            set
            {
                if (int.TryParse(value, out int temp))
                {
                    input.dY = temp >= 0 ? temp : input.dY;
                }
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
                if (double.TryParse(value, out double temp))
                    input.scale = temp;
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
                if (double.TryParse(value, out double temp))
                    input.delta = temp;
            }
        }

        public int boxSize
        {
            get
            {
                return input.kSize;
            }
            set
            {
                input.kSize = value >= 1 && value <= 7 ? (int)value : input.kSize;
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

        public DepthType DepthType
        {
            get
            {
                return input.depthType;
            }
            set
            {
                input.depthType = value;
            }
        }
        public SobelUI()
        {
            InitializeComponent();
            Bind();
            input = new SobelInput(DepthType.Cv8S, 1, 1, 3, 1, 0, BorderType.Reflect);
            
        }
        private void Bind()
        {
            if (cbBorder != null)
            {
                cbBorder.DataSource = new[]
                {
                    new ComboBoxInput<BorderType>{Text = "Replicate",Value = BorderType.Replicate },
                    new ComboBoxInput<BorderType>{Text = "Isolated",Value = BorderType.Isolated },
                    new ComboBoxInput<BorderType>{Text = "Reflect",Value = BorderType.Reflect },
                };
                cbBorder.DisplayMember = "Text";
                cbBorder.ValueMember = "Value";
                cbBorder.DataBindings.Add(nameof(cbBorder.SelectedValue), this, nameof(this.BorderType), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (cbDepth != null)
            {
                cbDepth.DataSource = Enum.GetValues(typeof(DepthType));
                cbDepth.DataBindings.Add(nameof(cbDepth.SelectedItem), this, nameof(this.DepthType), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (kSize != null)
            {
                kSize.DataBindings.Add(nameof(kSize.Value), this, nameof(this.boxSize), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (txtX != null)
            {
                txtX.DataBindings.Add(nameof(txtX.Text), this, nameof(this.xValue), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (txtY != null)
            {
                txtY.DataBindings.Add(nameof(txtY.Text), this, nameof(this.yValue), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (txtScale != null)
            {
                txtScale.DataBindings.Add(nameof(txtScale.Text), this, nameof(this.ScaleVal), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (txtDelta != null)
            {
                txtDelta.DataBindings.Add(nameof(txtDelta.Text), this, nameof(this.Delta), false, DataSourceUpdateMode.OnPropertyChanged);
            }

        }
        public IAlgorithmStrategy GetInstance() 
        {
            return input.createInstace();
        }
    }
}
