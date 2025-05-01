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
            lbValue = new Label();
            btnAccept = new Button();
            numLevels = new NumericUpDown();
            panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLevels).BeginInit();
            SuspendLayout();
            // 
            // panelBtns
            // 
            panelBtns.Controls.Add(numLevels);
            panelBtns.Controls.Add(lbValue);
            panelBtns.Controls.Add(btnAccept);
            panelBtns.Cursor = Cursors.Hand;
            panelBtns.Dock = DockStyle.Fill;
            panelBtns.Location = new Point(0, 0);
            panelBtns.Name = "panelBtns";
            panelBtns.Size = new Size(387, 73);
            panelBtns.TabIndex = 0;
            panelBtns.TabStop = true;
            // 
            // lbValue
            // 
            lbValue.AutoSize = true;
            lbValue.Location = new Point(12, 21);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(56, 20);
            lbValue.TabIndex = 3;
            lbValue.Text = "Levels :";
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAccept.Location = new Point(281, 17);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // numLevels
            // 
            numLevels.Location = new Point(74, 19);
            numLevels.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numLevels.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLevels.Name = "numLevels";
            numLevels.ReadOnly = true;
            numLevels.Size = new Size(84, 27);
            numLevels.TabIndex = 4;
            numLevels.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PosterizationWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 73);
            Controls.Add(panelBtns);
            MaximizeBox = false;
            MaximumSize = new Size(415, 120);
            MinimumSize = new Size(405, 120);
            Name = "PosterizationWindow";
            Text = "TresholdWindow";
            panelBtns.ResumeLayout(false);
            panelBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLevels).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBtns;
        private Button btnAccept;
        private Label lbValue;
        private NumericUpDown numLevels;
    }
}