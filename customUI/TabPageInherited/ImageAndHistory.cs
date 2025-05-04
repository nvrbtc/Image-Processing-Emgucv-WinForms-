using APO_Tsarehradskiy.Services;
using Emgu.CV;
using Emgu.CV.Structure;

namespace APO_Tsarehradskiy.customUI.TabPageInherited
{
    public partial class ImageAndHistory : UserControl
    {
        private Queue<LogImageStorage> logImages = new Queue<LogImageStorage> ();
        public event ImageUpdated NodeDoubleClic;
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
            LogImageStorage log;
            if (img.Type == Enums.Enums.Gray)
            {
                log = new LogImageStorage(img.Image.ToImage<Gray, byte>().ToJpegData(90), op,true);
            }
            else
            {
                log = new LogImageStorage(img.Image.ToImage<Bgr, byte>().ToJpegData(90), op);
            }
            tn.Tag = log;
            treeHistory.Nodes.Add(tn);
            treeHistory.SelectedNode = tn;
            if ( treeHistory.Nodes.Count > 10 )
            {
                var temp = treeHistory.Nodes[0];
                treeHistory.Nodes.Remove(temp);
            }
        }
        private void NodeDoubleClickEvent(object sender, TreeNodeMouseClickEventArgs e)
        {
            var loggedData = e.Node;
            if ( loggedData.Tag is LogImageStorage log)
            {
                treeHistory.Nodes.Remove(e.Node);
                Mat restoreMat = new Mat();
                if (log.IsGray)
                {
                    CvInvoke.Imdecode(log.JpegData, Emgu.CV.CvEnum.ImreadModes.Grayscale, restoreMat);
                }
                else
                {
                    CvInvoke.Imdecode(log.JpegData, Emgu.CV.CvEnum.ImreadModes.Color, restoreMat);
                }

                ImageData restoredData = new ImageData( restoreMat,
                                                        log.IsGray ? Enums.Enums.Gray : Enums.Enums.Rgb ,
                                                        null, null); // Restore method in ImageTab is not touching FileName and Parent
                treeHistory.Nodes.Add(loggedData);
                treeHistory.SelectedNode = loggedData;
                NodeDoubleClic?.Invoke(restoredData);
            }
        }
    }
    public record LogImageStorage
    {
        public byte[] JpegData { get; init; }
        public string Operation { get; init; }
        public bool IsGray { get; init; }
        public LogImageStorage(byte[] JpegData, string operation, bool IsGray = false)
        {
            this.JpegData = JpegData;
            this.Operation = operation;
            this.IsGray = IsGray;
        }
    }
}
