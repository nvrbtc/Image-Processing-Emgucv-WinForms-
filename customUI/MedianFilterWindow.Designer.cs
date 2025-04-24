namespace APO_Tsarehradskiy.customUI
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
            trSize = new TrackBar();
            tbSize = new TextBox();
            btRun = new Button();
            lbInput = new Label();
            pnArguments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trSize).BeginInit();
            SuspendLayout();
            // 
            // pnArguments
            // 
            pnArguments.BorderStyle = BorderStyle.Fixed3D;
            pnArguments.Controls.Add(trSize);
            pnArguments.Controls.Add(tbSize);
            pnArguments.Controls.Add(btRun);
            pnArguments.Controls.Add(lbInput);
            pnArguments.Dock = DockStyle.Fill;
            pnArguments.Location = new Point(0, 0);
            pnArguments.Name = "pnArguments";
            pnArguments.Size = new Size(426, 170);
            pnArguments.TabIndex = 0;
            // 
            // trSize
            // 
            trSize.Dock = DockStyle.Bottom;
            trSize.Location = new Point(0, 110);
            trSize.Minimum = 1;
            trSize.Name = "trSize";
            trSize.Size = new Size(422, 56);
            trSize.TabIndex = 6;
            trSize.Value = 1;
            // 
            // tbSize
            // 
            tbSize.Location = new Point(95, 28);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(151, 27);
            tbSize.TabIndex = 5;
            // 
            // btRun
            // 
            btRun.Location = new Point(318, 27);
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
            lbInput.Location = new Point(10, 31);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(79, 20);
            lbInput.TabIndex = 1;
            lbInput.Text = "Mask size :";
            // 
            // MedianFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(426, 170);
            Controls.Add(pnArguments);
            Name = "MedianFilter";
            Text = "LaplacianSharp";
            pnArguments.ResumeLayout(false);
            pnArguments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnArguments;
        private Button btRun;
        private Label lbInput;
        private TrackBar trSize;
        private TextBox tbSize;
    }
}