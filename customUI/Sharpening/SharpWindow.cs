using APO_Tsarehradskiy.ImageProcessingAlgos.Filter;
using APO_Tsarehradskiy.InputArguments.Filter2D;
using APO_Tsarehradskiy.InputArguments.Usercontrols;
using APO_Tsarehradskiy.InputTypes.ComboBoxGeneric;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.customUI
{
    public partial class SharpWindow : Form
    {
        private readonly List<MatrixRow> option1 = new List<MatrixRow>
        {
            new MatrixRow ( 0,-1, 0),
            new MatrixRow (-1, 5,-1),
            new MatrixRow ( 0,-1,-0)
        };
        private readonly List<MatrixRow> option2 = new List<MatrixRow>
        {
            new MatrixRow (-1,-1,-1),
            new MatrixRow (-1, 9,-1),
            new MatrixRow ( 0,-1,-0)
        };
        private readonly List<MatrixRow> option3 = new List<MatrixRow>
        {
            new MatrixRow ( 1,-2, 1),
            new MatrixRow (-2, 5,-2),
            new MatrixRow ( 1,-2, 1)
        };

        private ImageData imageData;
        private Filter2dInput input = new();
        public SharpWindow()
        {
            InitializeComponent();
            Bind();
            SelectedValueUpdated(this, EventArgs.Empty);

        }
        public void SetImageData(ImageData imageData)
        {
            this.imageData = imageData;
        }
        private void Bind()
        {
            if (cbOptions != null)
            {
                cbOptions.DataSource = new[]
                {
                    new ComboBoxInput<List<MatrixRow>> { Text = "Option 1", Value = option1 },
                    new ComboBoxInput<List<MatrixRow>> { Text = "Option 2", Value = option2 },
                    new ComboBoxInput<List<MatrixRow>> { Text = "Option 3", Value = option3 }
                };
                cbOptions.DisplayMember = "Text";
                cbOptions.SelectedIndexChanged += SelectedValueUpdated;
                cbOptions.SelectedIndex = 0;
            }
            if (cbBorder != null)
            {
                cbBorder.DataSource = new[]
                {
                    new ComboBoxInput<BorderType>{Text = "Reflect", Value = BorderType.Reflect},
                    new ComboBoxInput<BorderType>{Text = "Replicate", Value = BorderType.Replicate},
                    new ComboBoxInput<BorderType>{Text = "Isolated", Value = BorderType.Isolated}
                };
                cbBorder.DisplayMember = "Text";
                cbBorder.ValueMember = "Value";
                cbBorder.DataBindings.Add(nameof(cbBorder.SelectedValue), this.input, nameof(this.input.Border), false, DataSourceUpdateMode.OnPropertyChanged);
                cbBorder.SelectedIndex = 0;
            }
        }

        private void SelectedValueUpdated(object? sender, EventArgs e)
        {

            gridMatrix.Rows.Clear();
            var result = cbOptions.SelectedItem as ComboBoxInput<List<MatrixRow>>;
            for (int i = 0; i < 3; i++)
            {
                input.Kernel[i, 0] = result.Value[i].X1;
                input.Kernel[i, 1] = result.Value[i].X2;
                input.Kernel[i, 2] = result.Value[i].X3;
                gridMatrix.Rows.Add(result.Value[i].X1, result.Value[i].X2, result.Value[i].X3);
            }

        }

        private void btRun_Click(object sender, EventArgs e)
        {
            IAlgorithmStrategy strategy = new KernelFilter();

            strategy.SetDataImage(imageData);
            if (strategy.GetParameters(input))
                strategy.Run();
        }
    }
}
