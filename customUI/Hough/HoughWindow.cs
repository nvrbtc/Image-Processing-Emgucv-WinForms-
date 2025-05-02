using APO_Tsarehradskiy.customUI.Hough.Usercontrols;
using APO_Tsarehradskiy.InputTypes.ComboBoxGeneric;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Interfaces.InputReturn;
using APO_Tsarehradskiy.Services;

namespace APO_Tsarehradskiy.customUI.Hough
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

        private void RunAlgo(object sender, EventArgs e)
        {
            var strategyInfo = cbMethod.SelectedValue as IGetInput;
            executor.PerformStrategy(strategyInfo.ReturnStrategy(), ImageData, strategyInfo.ReturnInput());
        }
    }
}
