using Apo.DTO;
using Apo.InputArguments;
using APO_Tsarehradskiy.Services.Interfaces;
using APO_Tsarehradskiy.Services.Realization;

namespace Apo.customUI
{
    public partial class HoughWindow : Form
    {
        private readonly StrategyExecutor executor;

        private ImageData ImageData { get; set; }
        public HoughWindow(StrategyExecutor executor)
        {
            InitializeComponent();
            Bind();
            UpdateArgsSection(this, EventArgs.Empty);
            this.executor = executor;
        }
        private void Bind()
        {
            if (cbMethod != null)
            {
                cbMethod.DataSource = new[]
                {
                    new ComboBoxInput<UserControl> { Text = "Simple Hough", Value = new SimpleHoughUI()},
                    new ComboBoxInput<UserControl> { Text = "Probabilistic Hough", Value = new ProbHoughUI()}
                };

                cbMethod.DisplayMember = "Text";
                cbMethod.ValueMember = "Value";

                cbMethod.SelectedValueChanged += UpdateArgsSection;
            }

        }
        public void SetImageData(ImageData imageData)
        {
            this.ImageData = imageData;
        }

        private void UpdateArgsSection(object? sender, EventArgs e)
        {
            UserControl? argSection = cbMethod.SelectedValue as UserControl;

            pnUsrctnrl.Controls.Clear();
            pnUsrctnrl.Controls.Add(argSection);

            pnUsrctnrl.Controls[0].Dock = DockStyle.Fill;
        }
         
        private async void RunAlgo(object sender, EventArgs e)
        {
            var strategyInfo = cbMethod.SelectedValue as IGetInput;
            await executor.PerformStrategy(strategyInfo.ReturnStrategy(), ImageData, strategyInfo.ReturnInput());
        }
    }
}
