namespace APO_Tsarehradskiy.customUI
{
    partial class HoughWindow
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
            layoutInput = new TableLayoutPanel();
            panel1 = new Panel();
            chBoxSeparate = new CheckBox();
            lbResult = new Label();
            cbMethod = new ComboBox();
            lbMethod = new Label();
            btRun = new Button();
            pnUsrctnrl = new Panel();
            layoutInput.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // layoutInput
            // 
            layoutInput.AutoSize = true;
            layoutInput.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutInput.ColumnCount = 1;
            layoutInput.ColumnStyles.Add(new ColumnStyle());
            layoutInput.Controls.Add(panel1, 0, 0);
            layoutInput.Controls.Add(pnUsrctnrl, 0, 1);
            layoutInput.Dock = DockStyle.Fill;
            layoutInput.Location = new Point(0, 0);
            layoutInput.Name = "layoutInput";
            layoutInput.RowCount = 2;
            layoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            layoutInput.RowStyles.Add(new RowStyle());
            layoutInput.Size = new Size(622, 353);
            layoutInput.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(chBoxSeparate);
            panel1.Controls.Add(lbResult);
            panel1.Controls.Add(cbMethod);
            panel1.Controls.Add(lbMethod);
            panel1.Controls.Add(btRun);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 64);
            panel1.TabIndex = 1;
            // 
            // chBoxSeparate
            // 
            chBoxSeparate.AutoSize = true;
            chBoxSeparate.Location = new Point(405, 26);
            chBoxSeparate.Name = "chBoxSeparate";
            chBoxSeparate.Size = new Size(18, 17);
            chBoxSeparate.TabIndex = 4;
            chBoxSeparate.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(240, 23);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(159, 20);
            lbResult.TabIndex = 3;
            lbResult.Text = "Result in separate tab :";
            // 
            // cbMethod
            // 
            cbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMethod.FormattingEnabled = true;
            cbMethod.Location = new Point(83, 20);
            cbMethod.Name = "cbMethod";
            cbMethod.Size = new Size(151, 28);
            cbMethod.TabIndex = 2;
            // 
            // lbMethod
            // 
            lbMethod.AutoSize = true;
            lbMethod.Location = new Point(9, 23);
            lbMethod.Name = "lbMethod";
            lbMethod.Size = new Size(68, 20);
            lbMethod.TabIndex = 1;
            lbMethod.Text = "Method :";
            // 
            // btRun
            // 
            btRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btRun.Location = new Point(513, 19);
            btRun.Name = "btRun";
            btRun.Size = new Size(94, 29);
            btRun.TabIndex = 0;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += RunAlgo;
            // 
            // pnUsrctnrl
            // 
            pnUsrctnrl.AutoSize = true;
            pnUsrctnrl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnUsrctnrl.Dock = DockStyle.Fill;
            pnUsrctnrl.Location = new Point(3, 73);
            pnUsrctnrl.Name = "pnUsrctnrl";
            pnUsrctnrl.Size = new Size(616, 277);
            pnUsrctnrl.TabIndex = 2;
            // 
            // HoughWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(622, 353);
            Controls.Add(layoutInput);
            MaximizeBox = false;
            MinimumSize = new Size(640, 400);
            Name = "HoughWindow";
            Text = "HoughWindow";
            layoutInput.ResumeLayout(false);
            layoutInput.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel layoutInput;
        private Panel panel1;
        private ComboBox cbMethod;
        private Label lbMethod;
        private Button btRun;
        private CheckBox chBoxSeparate;
        private Label lbResult;
        private Panel pnUsrctnrl;
    }
}