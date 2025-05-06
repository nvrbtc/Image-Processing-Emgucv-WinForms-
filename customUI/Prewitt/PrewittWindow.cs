using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using APO_Tsarehradskiy.InputArguments;
using Emgu.CV.CvEnum;

namespace APO_Tsarehradskiy.customUI
{
    public partial class PrewittWindow : Form
    {
        private Filter2dInput input = new();
        private PrewittMaskProvider provider = new();
        private ImageData imageData;
        private readonly StrategyExecutor executor;

        public Prewitt Direction { get; set; } = Prewitt.North;
        public PrewittWindow(StrategyExecutor executor)
        {
            InitializeComponent();
            Bind();
            this.executor = executor;
        }
        public void SetImageData(ImageData imageData)
        {
            this.imageData = imageData;
        }
        private void Bind()
        {
            if (cbKernel != null)
            {
                cbKernel.DataSource = new[]
                {
                    new ComboBoxInput<Prewitt>{ Text = "North",
                                                Value = Prewitt.North},
                    new ComboBoxInput<Prewitt>{ Text = "NorthWest",
                                                Value = Prewitt.NorthWest},
                    new ComboBoxInput<Prewitt>{ Text = "West",
                                                Value = Prewitt.West},
                    new ComboBoxInput<Prewitt>{ Text = "SouthWest",
                                                Value = Prewitt.SouthWest},
                    new ComboBoxInput<Prewitt>{ Text = "South",
                                                Value = Prewitt.South},
                    new ComboBoxInput<Prewitt>{ Text = "SouthEast",
                                                Value = Prewitt.SouthEast},
                    new ComboBoxInput<Prewitt>{ Text = "East",
                                                Value = Prewitt.East},
                    new ComboBoxInput<Prewitt>{ Text = "NorthEast",
                                                Value = Prewitt.NorthEast},
                };
                cbKernel.DisplayMember = "Text";
                cbKernel.ValueMember = "Value";
                cbKernel.DataBindings.Add(nameof(cbKernel.SelectedValue), this, nameof(this.Direction), false, DataSourceUpdateMode.OnValidation);
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
        }

        private async void RunStrategy(object sender, EventArgs e)
        {
            input.Kernel = provider.GetKernel(Direction);
            await executor.PerformStrategy(Strategies.KernelFilter, this.imageData, this.input);
        }
    }
}
