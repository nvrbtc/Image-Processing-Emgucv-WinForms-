using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using APO_Tsarehradskiy.InputArguments;
using Emgu.CV.CvEnum;
using System.Data;

namespace APO_Tsarehradskiy.customUI
{
    public partial class SimpleHoughUI : UserControl, IGetInput
    {
        private HoughSimpleInput input = new HoughSimpleInput();
        private IInputHandler _usrInputHandler = new UserInputHandler();
        public SimpleHoughUI()
        {
            InitializeComponent();
            Bind();
        }
        

        private void Bind()
        {
            if (tbRho != null)
            {
                tbRho.KeyPress += _usrInputHandler.HandlePositiveDoubleTextBox;
                tbRho.DataBindings.Add(nameof(tbRho.Text),input,nameof(input.Rho),false,DataSourceUpdateMode.OnValidation);
            }
            if ( tbTheta != null)
            {
                tbTheta.KeyPress += _usrInputHandler.HandlePositiveIntegerTextBox;
                tbTheta.DataBindings.Add(nameof(tbTheta.Text),input, nameof(input.Theta),false,DataSourceUpdateMode.OnValidation);
            }
            if ( tbThrsh != null)
            {
                tbThrsh.KeyPress += _usrInputHandler.HandlePositiveIntegerTextBox;
                tbThrsh.DataBindings.Add(nameof(tbThrsh.Text), input, nameof(input.Threshold), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbSrn != null)
            {
                tbSrn.KeyPress += _usrInputHandler.HandlePositiveDoubleTextBox;
                tbSrn.DataBindings.Add(nameof(tbSrn.Text), input, nameof(input.Srn), false, DataSourceUpdateMode.OnValidation);
            }
            if ( tbStn != null)
            {
                tbStn.KeyPress += _usrInputHandler.HandlePositiveDoubleTextBox;
                tbStn.DataBindings.Add(nameof(tbStn.Text),input, nameof(input.Stn),false, DataSourceUpdateMode.OnValidation);
            }
            if (tbThic != null)
            {
                tbThic.KeyPress += _usrInputHandler.HandlePositiveIntegerTextBox;
                tbThic.DataBindings.Add(nameof(tbThic.Text),input,nameof(input.LineThickness),false, DataSourceUpdateMode.OnValidation);
            }
            if (cbLine != null)
            {
                cbLine.DataSource = Enum.GetValues(typeof(LineType)).Cast<LineType>();
                cbLine.DataBindings.Add(nameof(cbLine.SelectedItem),input,nameof(input.LineType),false,DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        object IGetInput.ReturnInput()
        {
            return input;
        }
        public Strategies ReturnStrategy()
        {
            return Strategies.Hough;
        }
    }
}
