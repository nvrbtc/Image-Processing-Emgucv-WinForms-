namespace APO_Tsarehradskiy.customUI
{
    partial class PosterizationWindow
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
            panelBtns = new Panel();
            textLevels = new TextBox();
            trackLevels = new TrackBar();
            btnAccept = new Button();
            panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackLevels).BeginInit();
            SuspendLayout();
            // 
            // panelBtns
            // 
            panelBtns.Controls.Add(btnAccept);
            panelBtns.Controls.Add(textLevels);
            panelBtns.Controls.Add(trackLevels);
            panelBtns.Cursor = Cursors.Hand;
            panelBtns.Dock = DockStyle.Fill;
            panelBtns.Location = new Point(0, 0);
            panelBtns.Name = "panelBtns";
            panelBtns.Size = new Size(613, 298);
            panelBtns.TabIndex = 0;
            panelBtns.TabStop = true;
            // 
            // textLevels
            // 
            textLevels.Enabled = false;
            textLevels.Location = new Point(12, 12);
            textLevels.Name = "textLevels";
            textLevels.Size = new Size(125, 27);
            textLevels.TabIndex = 1;
            // 
            // trackLevels
            // 
            trackLevels.Dock = DockStyle.Bottom;
            trackLevels.LargeChange = 1;
            trackLevels.Location = new Point(0, 242);
            trackLevels.Margin = new Padding(10);
            trackLevels.Maximum = 256;
            trackLevels.Minimum = 2;
            trackLevels.Name = "trackLevels";
            trackLevels.Size = new Size(613, 56);
            trackLevels.TabIndex = 0;
            trackLevels.TabStop = false;
            trackLevels.TickStyle = TickStyle.Both;
            trackLevels.Value = 2;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(516, 10);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // TresholdWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 298);
            Controls.Add(panelBtns);
            Name = "TresholdWindow";
            Text = "TresholdWindow";
            panelBtns.ResumeLayout(false);
            panelBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackLevels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBtns;
        private TrackBar trackLevels;
        private TextBox textLevels;
        private Button btnAccept;
    }
}