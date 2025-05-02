using APO_Tsarehradskiy.Enums;
using APO_Tsarehradskiy.InputArguments.Hough;
using APO_Tsarehradskiy.Interfaces.InputReturn;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;
using System.Data;

namespace APO_Tsarehradskiy.customUI.Hough.Usercontrols
{
    public partial class ProbHoughUI : UserControl, IGetInput
    {
        private IInputHandler inputHandler = new InputHandler();
        private HoughProbInput input = new();
        public ProbHoughUI()
        {
            InitializeComponent();
            Bind();
        }


        private void Bind()
        {
            if ( tbRho != null )
            {
                tbRho.KeyPress += inputHandler.HandlePositiveDoubleTextBox;
                tbRho.DataBindings.Add(nameof(tbRho.Text), input, nameof(input.Rho), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbTheta != null )
            {
                tbTheta.KeyPress += inputHandler.HandlePositiveIntegerTextBox;
                tbTheta.DataBindings.Add(nameof(tbTheta.Text),input, nameof(input.Theta), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbThrsh != null )
            {
                tbThrsh.KeyPress += inputHandler.HandlePositiveIntegerTextBox;
                tbThrsh.DataBindings.Add(nameof(tbThrsh.Text),input,nameof(input.Threshold), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbLength != null )
            {
                tbLength.KeyPress += inputHandler.HandlePositiveIntegerTextBox;
                tbLength.DataBindings.Add(nameof(tbLength.Text),input,nameof(input.MinLineLength), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbGap != null)
            {
                tbGap.KeyPress += inputHandler.HandlePositiveIntegerTextBox;
                tbGap.DataBindings.Add(nameof(tbGap.Text),input,nameof(input.MaxLineGap), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbThickness != null)
            {
                tbThickness.KeyPress += inputHandler.HandlePositiveIntegerTextBox;
                tbThickness.DataBindings.Add(nameof(tbThickness.Text),input,nameof(input.LineThickness), false, DataSourceUpdateMode.OnValidation);
            }
            if (cbLine != null)
            {
                cbLine.DataSource = Enum.GetValues(typeof(LineType)).Cast<LineType>();
                cbLine.DataBindings.Add(nameof(cbLine.SelectedItem),input,nameof(input.LineType),false, DataSourceUpdateMode.OnValidation);
            }
        }
        public Strategies ReturnStrategy()
        {
            return Strategies.HoughProbabilistic;
        }

        object IGetInput.ReturnInput()
        {
            return input;
        }
    }
}
