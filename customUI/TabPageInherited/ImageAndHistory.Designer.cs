namespace APO_Tsarehradskiy.customUI.TabPageInherited
{
    partial class ImageAndHistory
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            layoutTab = new TableLayoutPanel();
            pnImg = new Panel();
            treeHistory = new TreeView();
            picBox = new Emgu.CV.UI.PanAndZoomPictureBox();
            layoutTab.SuspendLayout();
            pnImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // layoutTab
            // 
            layoutTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutTab.ColumnCount = 2;
            layoutTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutTab.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            layoutTab.Controls.Add(pnImg, 0, 0);
            layoutTab.Controls.Add(treeHistory, 1, 0);
            layoutTab.Dock = DockStyle.Fill;
            layoutTab.Location = new Point(0, 0);
            layoutTab.Margin = new Padding(10);
            layoutTab.Name = "layoutTab";
            layoutTab.Padding = new Padding(15);
            layoutTab.RowCount = 1;
            layoutTab.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTab.Size = new Size(1080, 542);
            layoutTab.TabIndex = 0;
            // 
            // pnImg
            // 
            pnImg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnImg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnImg.BorderStyle = BorderStyle.Fixed3D;
            pnImg.Controls.Add(picBox);
            pnImg.Location = new Point(18, 18);
            pnImg.Name = "pnImg";
            pnImg.Size = new Size(644, 506);
            pnImg.TabIndex = 0;
            // 
            // treeHistory
            // 
            treeHistory.Location = new Point(668, 18);
            treeHistory.Name = "treeHistory";
            treeHistory.Size = new Size(394, 506);
            treeHistory.TabIndex = 1;
            treeHistory.NodeMouseDoubleClick += NodeDoubleClickEvent;

            // 
            // picBox
            // 
            picBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBox.Location = new Point(3, 3);
            picBox.Name = "picBox";
            picBox.Size = new Size(634, 496);
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            // 
            // ImageAndHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layoutTab);
            Name = "ImageAndHistory";
            Size = new Size(1080, 542);
            layoutTab.ResumeLayout(false);
            pnImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        

        #endregion

        private TableLayoutPanel layoutTab;
        private Panel pnImg;
        private TreeView treeHistory;
        private Emgu.CV.UI.PanAndZoomPictureBox picBox;
    }
}
