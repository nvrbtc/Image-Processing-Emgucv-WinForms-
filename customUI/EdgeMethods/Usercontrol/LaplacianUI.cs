using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using APO_Tsarehradskiy.InputArguments;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.customUI
{
    public partial class LaplacianUI : UserControl, IGetInput
    {
        private LaplacianInput input = new LaplacianInput();
        private IInputHandler _inputHandler = new UserInputHandler();

        public LaplacianUI()
        {
            InitializeComponent();
            Bind();
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
                cbBorder.DataBindings.Add(nameof(cbBorder.SelectedValue),input,nameof(input.BorderType),false,DataSourceUpdateMode.OnPropertyChanged);
                cbBorder.SelectedIndex = 0;
            }
            if (cbDepth != null)
            {
                cbDepth.DataSource = Enum.GetValues(typeof(DepthType));
                cbDepth.DataBindings.Add(nameof(cbDepth.SelectedItem),input,nameof(input.Depth),false,DataSourceUpdateMode.OnPropertyChanged) ;
            }
            if ( numSize != null )
            {
                numSize.DataBindings.Add(nameof(numSize.Value),input,nameof(input.Sz),false,DataSourceUpdateMode.OnPropertyChanged) ;
            }
            if ( tbScale != null)
            {
                tbScale.DataBindings.Add(nameof(tbScale.Text),input,nameof(input.Scale),false, DataSourceUpdateMode.OnPropertyChanged) ;
                tbScale.KeyPress += _inputHandler.HandlePositiveIntegerTextBox;
            }
            if (tbDelta != null)
            {
                tbDelta.DataBindings.Add(nameof(tbDelta.Text),input,nameof(input.Delta),false, DataSourceUpdateMode.OnPropertyChanged) ;
                tbDelta.KeyPress += _inputHandler.HandleSignedDoubleTextBox;
            }
        }

        object IGetInput.ReturnInput()
        {
            return input;
        }

        Strategies IGetInput.ReturnStrategy()
        {
            return Strategies.Laplacian;
        }
    }
}
