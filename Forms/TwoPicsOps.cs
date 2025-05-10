using Apo.DTO;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Tsarehradskiy.Forms
{
    public partial class TwoPicsOps : Form
    {
        private ImageData first, second;
        public TwoPicsOps(ImageData img)
        {
            InitializeComponent();
            first = img;
            second = MakeSecondImage();
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = first.Image.ToBitmap();
            pictureBox1.Refresh();

        }
        private ImageData MakeSecondImage()
        {
            Mat result = new Mat();
            CvInvoke.PyrDown(first.Image, result);
            return new ImageData(result, ImageType.Gray, "zapula");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alpha = 0.5;
            Mat result = new Mat();
            var res = first.Image.ToImage<Bgr,byte >(true);

        }
    }
}
