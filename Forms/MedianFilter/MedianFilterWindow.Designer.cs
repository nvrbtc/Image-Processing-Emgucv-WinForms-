namespace Apo.customUI
{
    partial class MedianFilterWindow
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
            pnArguments = new Panel();
            btRun = new Button();
            lbInput = new Label();
            numSize = new NumericUpDown();
            pnArguments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            SuspendLayout();
            // 
            // pnArguments
            // 
            pnArguments.BorderStyle = BorderStyle.Fixed3D;
            pnArguments.Controls.Add(numSize);
            pnArguments.Controls.Add(btRun);
            pnArguments.Controls.Add(lbInput);
            pnArguments.Dock = DockStyle.Fill;
            pnArguments.Location = new Point(0, 0);
            pnArguments.Name = "pnArguments";
            pnArguments.Size = new Size(322, 68);
            pnArguments.TabIndex = 0;
            // 
            // btRun
            // 
            btRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btRun.Location = new Point(214, 13);
            btRun.Name = "btRun";
            btRun.Size = new Size(94, 29);
            btRun.TabIndex = 2;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += RunMethod;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(10, 17);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(79, 20);
            lbInput.TabIndex = 1;
            lbInput.Text = "Mask size :";
            // 
            // numSize
            // 
            numSize.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numSize.Location = new Point(95, 15);
            numSize.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.ReadOnly = true;
            numSize.Size = new Size(81, 27);
            numSize.TabIndex = 3;
            numSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MedianFilterWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(322, 68);
            Controls.Add(pnArguments);
            MaximizeBox = false;
            MaximumSize = new Size(400, 120);
            MinimumSize = new Size(340, 115);
            Name = "MedianFilterWindow";
            Text = "LaplacianSharp";
            pnArguments.ResumeLayout(false);
            pnArguments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnArguments;
        private Button btRun;
        private Label lbInput;
        private NumericUpDown numSize;
    }
}