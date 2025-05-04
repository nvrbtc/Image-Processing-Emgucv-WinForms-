namespace APO_Tsarehradskiy.customUI
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
            pnBox = new Panel();
            pcBox = new PictureBox();
            panelHist = new Panel();
            chROI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBox).BeginInit();
            panelHist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chROI).BeginInit();
            SuspendLayout();
            // 
            // pnBox
            // 
            pnBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnBox.AutoScroll = true;
            pnBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnBox.Controls.Add(pcBox);
            pnBox.Location = new Point(12, 12);
            pnBox.Name = "pnBox";
            pnBox.Size = new Size(647, 500);
            pnBox.TabIndex = 0;
            // 
            // pcBox
            // 
            pcBox.BorderStyle = BorderStyle.Fixed3D;
            pcBox.Location = new Point(3, 3);
            pcBox.Name = "pcBox";
            pcBox.Size = new Size(125, 62);
            pcBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pcBox.TabIndex = 0;
            pcBox.TabStop = false;
            // 
            // panelHist
            // 
            panelHist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHist.Controls.Add(chROI);
            panelHist.Location = new Point(665, 12);
            panelHist.Name = "panelHist";
            panelHist.Size = new Size(424, 275);
            panelHist.TabIndex = 1;
            // 
            // chROI
            // 
            chartArea1.Name = "ChartArea1";
            chROI.ChartAreas.Add(chartArea1);
            chROI.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chROI.Legends.Add(legend1);
            chROI.Location = new Point(0, 0);
            chROI.Name = "chROI";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chROI.Series.Add(series1);
            chROI.Size = new Size(424, 275);
            chROI.TabIndex = 0;
            chROI.Text = "Roi";
            // 
            // DrawLineExample
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 524);
            Controls.Add(panelHist);
            Controls.Add(pnBox);
            Name = "DrawLineExample";
            Text = "DrawLineExample";
            pnBox.ResumeLayout(false);
            pnBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBox).EndInit();
            panelHist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chROI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBox;
        private PictureBox pcBox;
        private Panel panelHist;
        private System.Windows.Forms.DataVisualization.Charting.Chart chROI;
    }
}