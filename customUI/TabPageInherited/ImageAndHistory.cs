using APO_Tsarehradskiy.Services;
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

namespace APO_Tsarehradskiy.customUI.TabPageInherited
{
    public partial class ImageAndHistory : UserControl
    {
        private List<LogImageStorage> logImages = new List<LogImageStorage>();
        public ImageAndHistory()
        {
            InitializeComponent();
        }
        public void RedrawImage(ImageData imageData)
        {
            this.picBox.Image?.Dispose();
            this.picBox.Image = imageData.Image.ToBitmap();
            this.picBox.Refresh();

        }
        public void UpdateLog(ImageData img, string op)
        {
            TreeNode tn = new TreeNode(op);
            treeHistory.Nodes.Add(tn);
            treeHistory.SelectedNode = tn;
            logImages.Add(new LogImageStorage(img, op, tn));
        }
        private void Bind()
        {

        }
    }
    public record LogImageStorage
    {
        public ImageData ImageData { get; init; }
        public string Operation { get; init; }
        public TreeNode Node { get; init; }
        public LogImageStorage(ImageData img, string operation, TreeNode node)
        {
            this.ImageData = img;
            this.Operation = operation;
            this.Node = node;
        }
    }
}
