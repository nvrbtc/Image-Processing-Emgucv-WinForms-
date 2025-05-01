using APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale;
using APO_Tsarehradskiy.InputTypes.Blur;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;
using APO_Tsarehradskiy.customUI.TabPageInherited;
using APO_Tsarehradskiy.InputTypes.ComboBoxGeneric;

namespace APO_Tsarehradskiy.customUI
{
    public partial class BlurWindow : Form
    {
        private ImageData imageData;

        private BlurInput input;

        public int BoxSize
        {
            get
            {
                return input.sz.Width;
            }
            set
            {

                input.sz.Width = 2 * value + 1;
                input.sz.Height = 2 * value + 1;
                textBoxSize.Text = input.sz.Height.ToString();
            }
        }
        public BlurWindow()
        {
            InitializeComponent();
            Bind();
        }

        private void ApplyBlur(object sender, EventArgs e)
        {


            IAlgorithmStrategy? strategy = comboMethod.SelectedValue as IAlgorithmStrategy;
            if (strategy == null)
            {
                MessageBox.Show("No value selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            strategy.SetDataImage(imageData);
            if (strategy.GetParameters(input))
                strategy.Run();
        }

        public void Bind()
        {
            input = new BlurInput(BorderType.Reflect, new Size(3, 3));
            //createInstance = () => new Blur(BorderType.Default, new Size(3, 3));
            if (trackSize != null)
            {
                this.DataBindings.Add(nameof(this.BoxSize), trackSize, nameof(trackSize.Value), false, DataSourceUpdateMode.OnPropertyChanged);
            }
            if (comboBorder != null)
            {
                comboBorder.DataSource = new[]
                {
                    new {Text = "Reflect", Value = BorderType.Reflect},
                    new {Text = "Isolated",Value = BorderType.Isolated},
                    new {Text = "Replicate", Value = BorderType.Replicate}
                };
                comboBorder.DisplayMember = "Text";
                comboBorder.ValueMember = "Value";
                this.DataBindings.Add(nameof(input.borderType), comboBorder, nameof(comboBorder.SelectedValue), false, DataSourceUpdateMode.OnPropertyChanged);
            }

            if (comboMethod != null)
            {
                var methods = new[]
                {
                    new ComboBoxInput<IAlgorithmStrategy>{ Text = "Blur",Value = new Blur()},
                    new ComboBoxInput<IAlgorithmStrategy>{ Text = "Gaussian Blur",Value = new GaussianBlur()}
                };
                comboMethod.DataSource = methods;
                comboMethod.DisplayMember = "Name";
                comboMethod.ValueMember = "Create";

            };

        }
        public void SetImageData(ImageData imageData)
        {
            this.imageData = imageData;
        }
    }
}

