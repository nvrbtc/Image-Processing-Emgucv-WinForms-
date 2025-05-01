using APO_Tsarehradskiy.customUI.Edgecontrol;
using APO_Tsarehradskiy.customUI.EdgeMethodHandling;
using APO_Tsarehradskiy.customUI.EdgeMethods;
using APO_Tsarehradskiy.customUI.TabPageInherited;
using APO_Tsarehradskiy.InputTypes.ComboBoxGeneric;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;

namespace APO_Tsarehradskiy.customUI
{
    public partial class EdgeDetectionWindow : Form
    {

        private ImageData input;

        public ImageUpdated onNotify;
        public EdgeDetectionWindow()
        {
            InitializeComponent();
            Bind();
            changeUiHandler(this,null);
        }
        private void Bind()
        {
            if (cbMethod != null)
            {
                cbMethod.DataSource = new[]
                {
                    new ComboBoxInput<UserControl>{Text = "Sobel",Value = new SobelUI()  },
                    new ComboBoxInput<UserControl>{ Text = "Laplacian", Value = new LaplacianUI() },
                    new ComboBoxInput<UserControl>{ Text = "canny", Value = new CannyUI() }
                    //new EdgeMethodInput(){Text = "canny",Value = (input) => input.createInstace() }
                };
                cbMethod.DisplayMember = "Text";
                cbMethod.SelectedValueChanged += changeUiHandler;
            }

        }
        private void changeUiHandler(object sender, EventArgs? eventArgs)
        {
            ComboBoxInput<UserControl> temp = (ComboBoxInput<UserControl>)cbMethod.SelectedItem;
            if ( temp == null || temp.Value == null)
            {
                MessageBox.Show("Invalid ui","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            LoadUI(temp.Value);

        }
        private void LoadUI(UserControl control)
        {
            if (grpParams != null)
            {
                grpParams.Controls.Clear();
                grpParams.Controls.Add(control);
                control.Dock = DockStyle.Fill;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ComboBoxInput<UserControl> temp = cbMethod.SelectedItem as ComboBoxInput<UserControl>;
            IAlgorithmStrategy strategy = (temp.Value as IGetStrategy).GetAlgoInstance();

            if ( temp == null || strategy == null) return;

            strategy.SetDataImage(input);
            strategy.Run();
        }
        public void SetImageData(ImageData imageData)
        {
            this.input = imageData;
        }
    }
}
