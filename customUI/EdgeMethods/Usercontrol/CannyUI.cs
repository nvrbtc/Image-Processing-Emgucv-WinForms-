using APO_Tsarehradskiy.Services;
using APO_Tsarehradskiy.DTO;
using APO_Tsarehradskiy.InputArguments;

namespace APO_Tsarehradskiy.customUI
{
    public partial class CannyUI : UserControl, IGetInput
    {
        private readonly CannyInput input = new CannyInput();

        public CannyUI()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            if(numTr1 != null)
            {
                numTr1.DataBindings.Add(nameof(numTr1.Value),input,nameof(input.Threshold1),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if(numTr2 != null)
            {
                numTr2.DataBindings.Add(nameof(numTr2.Value),input,nameof(input.Threshold2),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if(numSz != null)
            {
                numSz.DataBindings.Add(nameof(numSz.Value),input,nameof(input.Sz),false,DataSourceUpdateMode.OnPropertyChanged);
            }
            if (boxGradient != null)
            {
                boxGradient.DataBindings.Add(nameof(boxGradient.Checked),input,nameof(input.GradientEnabled),false,DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        public Strategies ReturnStrategy()
        {
            return Strategies.Canny;
        }

        public object ReturnInput()
        {
            return input;
        }
    }
}
