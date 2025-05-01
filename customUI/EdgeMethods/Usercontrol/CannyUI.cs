using APO_Tsarehradskiy.InputArguments.EdgeDetection;
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
        private CannyInput input = new CannyInput();

        public CannyUI()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            if(numTr1 != null)
            {
                numTr1.DataBindings.Add(nameof(numTr1.Value),input,nameof(input.Threshold1),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if(numTr2 != null)
            {
                numTr2.DataBindings.Add(nameof(numTr2.Value),input,nameof(input.Threshold2),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if(numSz != null)
            {
                numSz.DataBindings.Add(nameof(numSz.Value),input,nameof(input.Sz),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if (boxGradient != null)
            {
                boxGradient.DataBindings.Add(nameof(boxGradient.Checked),input,nameof(input.GradientEnabled),false,DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        public IAlgorithmStrategy GetAlgoInstance()
        {
            return input.createInstace();
        }
    }
}
