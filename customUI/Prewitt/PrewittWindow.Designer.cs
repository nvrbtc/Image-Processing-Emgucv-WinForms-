namespace APO_Tsarehradskiy.customUI
{
    partial class PrewittWindow
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
            pnArgs = new Panel();
            btRun = new Button();
            cbBorder = new ComboBox();
            cbKernel = new ComboBox();
            lbBorder = new Label();
            lbKernel = new Label();
            pnMain = new Panel();
            pnArgs.SuspendLayout();
            SuspendLayout();
            // 
            // pnArgs
            // 
            pnArgs.Controls.Add(btRun);
            pnArgs.Controls.Add(cbBorder);
            pnArgs.Controls.Add(cbKernel);
            pnArgs.Controls.Add(lbBorder);
            pnArgs.Controls.Add(lbKernel);
            pnArgs.Dock = DockStyle.Top;
            pnArgs.Location = new Point(0, 0);
            pnArgs.Name = "pnArgs";
            pnArgs.Size = new Size(800, 77);
            pnArgs.TabIndex = 0;
            // 
            // btRun
            // 
            btRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btRun.Location = new Point(694, 20);
            btRun.Name = "btRun";
            btRun.Size = new Size(94, 29);
            btRun.TabIndex = 4;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += RunStrategy;
            // 
            // cbBorder
            // 
            cbBorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBorder.FormattingEnabled = true;
            cbBorder.Location = new Point(360, 21);
            cbBorder.Name = "cbBorder";
            cbBorder.Size = new Size(151, 28);
            cbBorder.TabIndex = 3;
            // 
            // cbKernel
            // 
            cbKernel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKernel.FormattingEnabled = true;
            cbKernel.Location = new Point(95, 21);
            cbKernel.Name = "cbKernel";
            cbKernel.Size = new Size(151, 28);
            cbKernel.TabIndex = 2;
            // 
            // lbBorder
            // 
            lbBorder.AutoSize = true;
            lbBorder.Location = new Point(260, 24);
            lbBorder.Name = "lbBorder";
            lbBorder.Size = new Size(94, 20);
            lbBorder.TabIndex = 1;
            lbBorder.Text = "Border type :";
            // 
            // lbKernel
            // 
            lbKernel.AutoSize = true;
            lbKernel.Location = new Point(12, 24);
            lbKernel.Name = "lbKernel";
            lbKernel.Size = new Size(77, 20);
            lbKernel.TabIndex = 0;
            lbKernel.Text = "Direction :";
            // 
            // pnMain
            // 
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 77);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(800, 364);
            pnMain.TabIndex = 1;
            // 
            // PrewittWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 441);
            Controls.Add(pnMain);
            Controls.Add(pnArgs);
            Name = "PrewittWindow";
            Text = "PrewittWindow";
            pnArgs.ResumeLayout(false);
            pnArgs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnArgs;
        private ComboBox cbBorder;
        private ComboBox cbKernel;
        private Label lbBorder;
        private Label lbKernel;
        private Panel pnMain;
        private Button btRun;
    }
}