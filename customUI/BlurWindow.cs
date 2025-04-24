using APO_Tsarehradskiy.ImageProcessingAlgos.BinaryOrGrayscale;
using APO_Tsarehradskiy.InputTypes;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace APO_Tsarehradskiy.customUI
{
    public partial class BlurWindow : Form
    {
        private ImageData input;

        private BlurInput parameters;
        public BorderType Border
        {
            get
            {
                return parameters.borderType;
            }
            set
            {
                parameters.borderType = value;
            }
        }
        public int BoxSize
        {
            get
            {
                return parameters.sz.Width;
            }
            set
            {   

                parameters.sz.Width = 2 * value + 1;
                parameters.sz.Height = 2 * value + 1;
                textBoxSize.Text = parameters.sz.Height.ToString();
            }
        }
        public BlurWindow()
        {
            InitializeComponent();
            Bind();
        }

        private void ApplyBlur(object sender, EventArgs e)
        {
            
            Func<IAlgorithmStrategy> create = comboMethod.SelectedValue as Func<IAlgorithmStrategy>;
            IAlgorithmStrategy strategy = create?.Invoke();
            if (strategy == null)
            {
                MessageBox.Show("No value selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            strategy.SetDataImage(input);
            strategy.GetParameters(parameters);
            strategy.Run();
        }

        public void Bind()
        {
            parameters = new BlurInput(BorderType.Reflect, new Size(3, 3));
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
                this.DataBindings.Add(nameof(this.Border), comboBorder, nameof(comboBorder.SelectedValue), false, DataSourceUpdateMode.OnPropertyChanged);
            }

            if (comboMethod != null)
            {
                var methods = new[]
                {
                    new { Name = "Blur",Create = new Func<IAlgorithmStrategy>(() => new Blur())},
                    new { Name = "Gaussian Blur",Create = new Func<IAlgorithmStrategy>( () => new GaussianBlur())}
                };
                comboMethod.DataSource = methods;
                comboMethod.DisplayMember = "Name";
                comboMethod.ValueMember = "Create";

            };

        }
        public void AddSubcriber(ImageUpdated callback)
        {
            
            if (callback != null)
            {
                input.UpdateEvent += callback;
            }
        }
        public void SetImageData(ImageData imageData)
        {
            this.input = imageData;
        }
    }
}

