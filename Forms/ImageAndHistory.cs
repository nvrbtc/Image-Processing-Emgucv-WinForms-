using Apo.DTO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Apo.customUI

{
    public partial class ImageAndHistory : UserControl
    {
        public event Action<Mat, ImageType>? NodeDoubleClick;

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
            var log = img.Type == ImageType.Gray
                ? new LogImageStorage(img.Image.ToImage<Gray, byte>().ToJpegData(90), true)
                : new LogImageStorage(img.Image.ToImage<Bgr, byte>().ToJpegData(90));
            tn.Tag = log;
            treeHistory.Nodes.Add(tn);
            treeHistory.SelectedNode = tn;
            if (treeHistory.Nodes.Count > 10)
            {
                var temp = treeHistory.Nodes[0];
                treeHistory.Nodes.Remove(temp);
            }
        }

        private void NodeDoubleClickEvent(object sender, TreeNodeMouseClickEventArgs e)
        {
            var loggedData = e.Node;
            if (loggedData.Tag is LogImageStorage log)
            {
                treeHistory.Nodes.Remove(e.Node);
                Mat restoreMat = new Mat();
                CvInvoke.Imdecode(log.JpegData,
                    log.IsGray ? ImreadModes.Grayscale : ImreadModes.Color, restoreMat);
                treeHistory.Nodes.Add(loggedData);
                treeHistory.SelectedNode = loggedData;
                NodeDoubleClick?.Invoke(restoreMat,
                    log.IsGray ? ImageType.Gray : ImageType.Rgb);
            }
        }
    }
}