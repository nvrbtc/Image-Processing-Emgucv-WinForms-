using APO_Tsarehradskiy.ImageProcessingAlgos.Filter;
using APO_Tsarehradskiy.InputArguments.Filter2D;
using APO_Tsarehradskiy.InputTypes.ComboBoxGeneric;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;
using System.Text.RegularExpressions;

namespace APO_Tsarehradskiy.customUI
{
    public partial class UniversalFilterWindow : Form
    {
        private Filter2dInput input = new Filter2dInput();
        private ImageData imageData;
        private IInputHandler _inputHandler = new InputHandler();
        public UniversalFilterWindow()
        {
            InitializeComponent();
            Bind();
        }
        public void SetImageData(ImageData imageData)
        {
            this.imageData = imageData;
        }
        private void Bind()
        {
            if (gridMatrix != null)
            {
                gridMatrix.Rows.Add(0, 0, 0);
                gridMatrix.Rows.Add(0, 0, 0);
                gridMatrix.Rows.Add(0, 0, 0);

            }
            if (cbBorder != null)
            {
                cbBorder.DataSource = new[]
                {
                    new ComboBoxInput<BorderType>{Text = "Reflect", Value = BorderType.Reflect },
                    new ComboBoxInput<BorderType>{Text = "Replicate", Value = BorderType.Replicate },
                    new ComboBoxInput<BorderType>{Text = "Isolated", Value = BorderType.Isolated }
                };
                cbBorder.DisplayMember = "Text";
                cbBorder.ValueMember = "Value";
                cbBorder.DataBindings.Add(nameof(cbBorder.SelectedValue), input, nameof(input.Border), false, DataSourceUpdateMode.OnValidation);
            }
            if (tbDelta != null)
            {
                tbDelta.DataBindings.Add(nameof(tbDelta.Text), this.input, nameof(input.Delta), false, DataSourceUpdateMode.OnPropertyChanged);
                tbDelta.KeyPress += _inputHandler.HandleSignedDoubleTextBox;
            }

        }

        private void cellInputHandle(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox box)
            {
                box.KeyPress -= _inputHandler.HandleSignedIntegerTextBox;
                box.KeyPress += _inputHandler.HandleSignedIntegerTextBox;
            }
        }


        private void RunButton(object sender, EventArgs e)
        {
            GetKernelValues();
            IAlgorithmStrategy strategy = new KernelFilter();

            strategy.SetDataImage(imageData);
            if (strategy.GetParameters(input))
                strategy.Run();
        }
        private void GetKernelValues()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (float.TryParse(gridMatrix.Rows[i].Cells[j].Value.ToString(), out float result))
                        input.Kernel[i, j] = result;
                }
            }
        }

    }
}
