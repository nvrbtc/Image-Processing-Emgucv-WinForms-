using APO_Tsarehradskiy.InputTypes;
using APO_Tsarehradskiy.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Tsarehradskiy.customUI.EdgeMethods
{
    public partial class CannyUI : UserControl, IGetStrategy
    {
        private CannyInput input;

        public double Tr1
        {
            get
            {
                return input.threshold1;
            }
            set
            {
                input.threshold1 = (double)value;
            }
        }
        public double Tr2
        {
            get
            {
                return input.threshold2;
            }
            set
            {
                input.threshold2 = (double)value;
            }
        }
        public double ApSize
        {
            get
            {
                return input.apertureSize;
            }
            set
            {
                input.apertureSize = (int)value;
            }
        }
        public bool Gradient
        {
            get
            {
                return input.L2gradient;
            }
            set
            {
                input.L2gradient = value;
            }
        }

        public CannyUI()
        {
            InitializeComponent();
            Bind();
            input = new CannyInput();
        }
        private void Bind()
        {
            if(numTr1 != null)
            {
                numTr1.DataBindings.Add(nameof(numTr1.Value),this,nameof(this.Tr1),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if(numTr2 != null)
            {
                numTr2.DataBindings.Add(nameof(numTr2.Value),this,nameof(this.Tr2),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if(numSz != null)
            {
                numSz.DataBindings.Add(nameof(numSz.Value),this,nameof(this.ApSize),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if (boxGradient != null)
            {
                boxGradient.DataBindings.Add(nameof(boxGradient.Checked),this,nameof(this.Gradient),false,DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        public IAlgorithmStrategy GetInstance()
        {
            return input.createInstace();
        }
    }
}
