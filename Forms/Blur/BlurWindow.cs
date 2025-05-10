using Emgu.CV.CvEnum;
using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Realization;

namespace Apo.customUI
{
    public partial class BlurWindow : Form
    {
        private ImageData imageData;
        private readonly StrategyExecutor executor;

        private readonly BlurInput input = new();

        public int BoxSize
        {
            get => input.Size.Width;
            set
            {

                input.Size.Width = 2 * value + 1;
                input.Size.Height = 2 * value + 1;
                textBoxSize.Text = input.Size.Height.ToString();
            }
        }
        public BlurWindow(StrategyExecutor executor)
        {
            InitializeComponent();
            Bind();
            this.executor = executor;
        }

        private async void ApplyBlur(object sender, EventArgs e)
        {
            Strategies strategy = (Strategies)comboMethod.SelectedValue;
            await executor.PerformStrategy(strategy,imageData,input);
        }

        private void Bind()
        {
            if (trackSize != null)
            {
                this.DataBindings.Add(nameof(this.BoxSize), trackSize, nameof(trackSize.Value), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (comboBorder != null)
            {
                comboBorder.DataSource = new[]
                {
                    new ComboBoxInput<BorderType>{Text = "Reflect", Value = BorderType.Reflect},
                    new ComboBoxInput<BorderType>{Text = "Isolated",Value = BorderType.Isolated},
                    new ComboBoxInput<BorderType>{Text = "Replicate", Value = BorderType.Replicate}
                };
                comboBorder.DisplayMember = "Text";
                comboBorder.ValueMember = "Value";
                comboBorder.DataBindings.Add(nameof(comboBorder.SelectedValue), input, nameof(input.BorderType), false, DataSourceUpdateMode.OnPropertyChanged);

                comboBorder.SelectedIndex = 0;
            }

            if (comboMethod != null)
            {
                var methods = new[]
                {
                    new ComboBoxInput<Strategies>{ Text = "Blur",Value = Strategies.Blur},
                    new ComboBoxInput<Strategies>{ Text = "Gaussian Blur",Value = Strategies.GaussianBlur}
                };
                comboMethod.DataSource = methods;
                comboMethod.DisplayMember = "Text";
                comboMethod.ValueMember = "Value";

                comboMethod.SelectedIndex = 0;
            }
        }
        public void SetImageData(ImageData data)
        {
            this.imageData = data;
        }
    }
}

