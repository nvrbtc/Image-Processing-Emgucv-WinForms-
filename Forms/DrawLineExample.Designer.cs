namespace Apo.customUI
{
    partial class DrawLineExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            layoutTb = new TableLayoutPanel();
            pnBox = new Panel();
            pcBox = new PictureBox();
            chROI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            layoutTb.SuspendLayout();
            pnBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chROI).BeginInit();
            SuspendLayout();
            // 
            // layoutTb
            // 
            layoutTb.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutTb.ColumnCount = 2;
            layoutTb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutTb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutTb.Controls.Add(pnBox, 0, 0);
            layoutTb.Controls.Add(chROI, 1, 0);
            layoutTb.Dock = DockStyle.Fill;
            layoutTb.Location = new Point(0, 0);
            layoutTb.Name = "layoutTb";
            layoutTb.RowCount = 1;
            layoutTb.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTb.Size = new Size(1068, 524);
            layoutTb.TabIndex = 0;
            // 
            // pnBox
            // 
            pnBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnBox.AutoScroll = true;
            pnBox.BorderStyle = BorderStyle.FixedSingle;
            pnBox.Controls.Add(pcBox);
            pnBox.Location = new Point(3, 3);
            pnBox.Name = "pnBox";
            pnBox.Size = new Size(528, 518);
            pnBox.TabIndex = 0;
            // 
            // pcBox
            // 
            pcBox.BorderStyle = BorderStyle.Fixed3D;
            pcBox.Location = new Point(9, 9);
            pcBox.Name = "pcBox";
            pcBox.Size = new Size(125, 62);
            pcBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pcBox.TabIndex = 0;
            pcBox.TabStop = false;
            // 
            // chROI
            // 
            chROI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chROI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chROI.Legends.Add(legend1);
            chROI.Location = new Point(537, 3);
            chROI.Name = "chROI";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chROI.Series.Add(series1);
            chROI.Size = new Size(528, 518);
            chROI.TabIndex = 1;
            chROI.Text = "chart1";
            // 
            // DrawLineExample
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 524);
            Controls.Add(layoutTb);
            Name = "DrawLineExample";
            Text = "DrawLineExample";
            layoutTb.ResumeLayout(false);
            pnBox.ResumeLayout(false);
            pnBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)chROI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutTb;
        private Panel pnBox;
        private PictureBox pcBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chROI;
    }
}