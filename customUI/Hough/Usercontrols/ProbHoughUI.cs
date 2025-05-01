using APO_Tsarehradskiy.ImageProcessingAlgos.Hough;
using APO_Tsarehradskiy.InputArguments.Hough;
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

namespace APO_Tsarehradskiy.customUI.Hough.Usercontrols
{
    public partial class ProbHoughUI : UserControl, IGetStrategy
    {
        private IInputHandler _inputHandler = new InputHandler();
        private HoughProbInput _input = new();
        public ProbHoughUI()
        {
            InitializeComponent();
            Bind();
        }

        public IAlgorithmStrategy GetAlgoInstance()
        {
            IAlgorithmStrategy strategy = new HoughP();
            return strategy.GetParameters(this._input) ? strategy : null;
        }

        private void Bind()
        {
            if ( tbRho != null )
            {
                tbRho.KeyPress += _inputHandler.HandlePositiveDoubleTextBox;
                tbRho.DataBindings.Add(nameof(tbRho.Text), _input, nameof(_input.Rho), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbTheta != null )
            {
                tbTheta.KeyPress += _inputHandler.HandlePositiveIntegerTextBox;
                tbTheta.DataBindings.Add(nameof(tbTheta.Text),_input, nameof(_input.Theta), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbThrsh != null )
            {
                tbThrsh.KeyPress += _inputHandler.HandlePositiveIntegerTextBox;
                tbThrsh.DataBindings.Add(nameof(tbThrsh.Text),_input,nameof(_input.Threshold), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbLength != null )
            {
                tbLength.KeyPress += _inputHandler.HandlePositiveIntegerTextBox;
                tbLength.DataBindings.Add(nameof(tbLength.Text),_input,nameof(_input.MinLineLength), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbGap != null)
            {
                tbGap.KeyPress += _inputHandler.HandlePositiveIntegerTextBox;
                tbGap.DataBindings.Add(nameof(tbGap.Text),_input,nameof(_input.MaxLineGap), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbThickness != null)
            {
                tbThickness.KeyPress += _inputHandler.HandlePositiveIntegerTextBox;
                tbThickness.DataBindings.Add(nameof(tbThickness.Text),_input,nameof(_input.LineThickness), false, DataSourceUpdateMode.OnValidation);
            }
            if (cbLine != null)
            {
                cbLine.DataSource = Enum.GetValues(typeof(LineType)).Cast<LineType>();
                cbLine.DataBindings.Add(nameof(cbLine.SelectedItem),_input,nameof(_input.LineType),false, DataSourceUpdateMode.OnValidation);
            }
        }
    }
}
