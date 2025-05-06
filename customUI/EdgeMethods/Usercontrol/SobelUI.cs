using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using APO_Tsarehradskiy.InputArguments;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.customUI
{
    public partial class SobelUI : UserControl, IGetInput
    {
        
        private IInputHandler _inputHandler = new UserInputHandler();
        private SobelInput input = new SobelInput();

        public SobelUI()
        {
            InitializeComponent();
            Bind();
            
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
                cbBorder.DataBindings.Add(nameof(cbBorder.SelectedValue), input, nameof(input.BorderType), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (cbDepth != null)
            {
                cbDepth.DataSource = Enum.GetValues(typeof(DepthType));
                cbDepth.DataBindings.Add(nameof(cbDepth.SelectedItem), input, nameof(input.Depth), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (kSize != null)
            {
                kSize.DataBindings.Add(nameof(kSize.Value), input, nameof(input.Sz), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (txtX != null)
            {
                txtX.DataBindings.Add(nameof(txtX.Text), input, nameof(input.dX), false, DataSourceUpdateMode.OnPropertyChanged);
                txtX.KeyPress += _inputHandler.HandlePositiveIntegerTextBox;
            }
            if (txtY != null)
            {
                txtY.DataBindings.Add(nameof(txtY.Text), input, nameof(input.dY), false, DataSourceUpdateMode.OnPropertyChanged);
                txtY.KeyPress += _inputHandler.HandlePositiveIntegerTextBox;
            }
            if (txtScale != null)
            {
                txtScale.DataBindings.Add(nameof(txtScale.Text), input, nameof(input.Scale), false, DataSourceUpdateMode.OnPropertyChanged);
                txtScale.KeyPress += _inputHandler.HandleSignedIntegerTextBox;
            }
            if (txtDelta != null)
            {
                txtDelta.DataBindings.Add(nameof(txtDelta.Text), input, nameof(input.Delta), false, DataSourceUpdateMode.OnPropertyChanged);
                txtDelta.KeyPress += _inputHandler.HandleSignedDoubleTextBox;
            }

        }
        public Strategies ReturnStrategy()
        {
            return Strategies.Sobel;
        }

        object IGetInput.ReturnInput()
        {
           return input;
        }
    }
}
