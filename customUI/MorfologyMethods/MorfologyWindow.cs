using APO_Tsarehradskiy.ImageProcessingAlgos.Morphology;
using APO_Tsarehradskiy.InputArguments.Morphology;
using APO_Tsarehradskiy.InputTypes.ComboBoxGeneric;
using APO_Tsarehradskiy.Interfaces;
using APO_Tsarehradskiy.Services;
using Emgu.CV.CvEnum;
using System.Data;

namespace APO_Tsarehradskiy.customUI.MorfologyMethods
{
    public partial class MorfologyWindow : Form
    {
        private MorphologyInput input = new ();
        private StructuringElement structuringElement = new();
        private ImageData imageData;
        public MorfologyWindow()
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
            if (cbBorder != null)
            {

                cbBorder.DataBindings.Add(nameof(cbBorder.SelectedValue), input, nameof(input.BorderType), false, DataSourceUpdateMode.OnPropertyChanged);

                cbBorder.DataSource = new[]
                {
                    new ComboBoxInput<BorderType>{Text = "Reflect", Value = BorderType.Reflect},
                    new ComboBoxInput<BorderType>{Text = "Replicate", Value = BorderType.Replicate},
                    new ComboBoxInput<BorderType>{Text = "Isolated", Value = BorderType.Isolated}
                };
                cbBorder.DisplayMember = "Text";
                cbBorder.ValueMember = "Value";
            }
            if (cbMethod != null)
            {

                cbMethod.DataBindings.Add(nameof(cbMethod.SelectedValue), input, nameof(input.Operation), false, DataSourceUpdateMode.OnPropertyChanged);

                List<ComboBoxInput<MorphOp>> tmp = new();

                foreach (MorphOp t in Enum.GetValues(typeof(MorphOp)))
                {
                    tmp.Add(new ComboBoxInput<MorphOp> { Text = t.ToString(), Value = t });
                }

                cbMethod.DataSource = tmp;
                cbMethod.DisplayMember = "Text";
                cbMethod.ValueMember = "Value";
            }
            if (cbShape != null)
            {

                cbShape.DataBindings.Add(nameof(cbShape.SelectedValue), structuringElement, nameof(structuringElement.Shape), false, DataSourceUpdateMode.OnPropertyChanged);

                cbShape.DataSource = Enum.GetValues(typeof(ElementShape))
                                        .Cast<ElementShape>()
                                        .Select(m => new ComboBoxInput<ElementShape>
                                        {
                                            Text = m != ElementShape.Custom ? m.ToString() : "Rhombus",
                                            Value = m
                                        }).ToList();

                cbShape.DisplayMember = "Text";
                cbShape.ValueMember = "Value";
            }
            if (numElmSize != null)
            {
                numElmSize.DataBindings.Add(nameof(numElmSize.Value), structuringElement, nameof(structuringElement.Size), false, DataSourceUpdateMode.OnPropertyChanged);
                helper.SetHelpString(numElmSize, "Rohmbus ( 'custom' option ) only take odd values");

            }
            if (numIterations != null)
            {
                numIterations.DataBindings.Add(nameof(numIterations.Value), input, nameof(input.Iterations), false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void RunOperation(object sender, EventArgs e)
        {
            if ( structuringElement.Shape == ElementShape.Custom && structuringElement.Size % 2 != 1)
            {
                MessageBox.Show("This type does not suppot even values","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            input.StructElement = structuringElement.GetStructuringElement();

            IAlgorithmStrategy strategy = new Morphology();
            strategy.SetDataImage(imageData);
            if (strategy.GetParameters(input))
                strategy.Run();

        }
    }
}
