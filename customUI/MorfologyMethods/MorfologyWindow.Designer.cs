namespace APO_Tsarehradskiy.customUI
{
    partial class MorfologyWindow
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
            layoutMain = new TableLayoutPanel();
            pnBtn = new Panel();
            btRun = new Button();
            gpParams = new GroupBox();
            lbIteration = new Label();
            cbBorder = new ComboBox();
            lbBorder = new Label();
            numIterations = new NumericUpDown();
            cbMethod = new ComboBox();
            lbMethod = new Label();
            gpStrElmnt = new GroupBox();
            lbSz = new Label();
            numElmSize = new NumericUpDown();
            lbShape = new Label();
            cbShape = new ComboBox();
            helper = new HelpProvider();
            layoutMain.SuspendLayout();
            pnBtn.SuspendLayout();
            gpParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIterations).BeginInit();
            gpStrElmnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numElmSize).BeginInit();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutMain.ColumnCount = 1;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMain.Controls.Add(pnBtn, 0, 0);
            layoutMain.Controls.Add(gpParams, 0, 1);
            layoutMain.Controls.Add(gpStrElmnt, 0, 2);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 3;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutMain.Size = new Size(522, 353);
            layoutMain.TabIndex = 0;
            // 
            // pnBtn
            // 
            pnBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnBtn.Controls.Add(btRun);
            pnBtn.Dock = DockStyle.Fill;
            pnBtn.Location = new Point(3, 3);
            pnBtn.Name = "pnBtn";
            pnBtn.Size = new Size(516, 54);
            pnBtn.TabIndex = 0;
            // 
            // btRun
            // 
            btRun.Anchor = AnchorStyles.Right;
            btRun.Location = new Point(419, 12);
            btRun.Margin = new Padding(3, 15, 3, 15);
            btRun.Name = "btRun";
            btRun.Size = new Size(94, 30);
            btRun.TabIndex = 0;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += RunOperation;
            // 
            // gpParams
            // 
            gpParams.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpParams.Controls.Add(lbIteration);
            gpParams.Controls.Add(cbBorder);
            gpParams.Controls.Add(lbBorder);
            gpParams.Controls.Add(numIterations);
            gpParams.Controls.Add(cbMethod);
            gpParams.Controls.Add(lbMethod);
            gpParams.Dock = DockStyle.Fill;
            gpParams.Location = new Point(3, 63);
            gpParams.Name = "gpParams";
            gpParams.Size = new Size(516, 140);
            gpParams.TabIndex = 3;
            gpParams.TabStop = false;
            gpParams.Text = "Method";
            // 
            // lbIteration
            // 
            lbIteration.AutoSize = true;
            lbIteration.Location = new Point(9, 90);
            lbIteration.Name = "lbIteration";
            lbIteration.Size = new Size(56, 20);
            lbIteration.TabIndex = 5;
            lbIteration.Text = "Loops :";
            // 
            // cbBorder
            // 
            cbBorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBorder.FormattingEnabled = true;
            cbBorder.Location = new Point(360, 30);
            cbBorder.Name = "cbBorder";
            cbBorder.Size = new Size(151, 28);
            cbBorder.TabIndex = 4;
            // 
            // lbBorder
            // 
            lbBorder.AutoSize = true;
            lbBorder.Location = new Point(293, 33);
            lbBorder.Name = "lbBorder";
            lbBorder.Size = new Size(61, 20);
            lbBorder.TabIndex = 3;
            lbBorder.Text = "Border :";
            // 
            // numIterations
            // 
            numIterations.Location = new Point(73, 90);
            numIterations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIterations.Name = "numIterations";
            numIterations.ReadOnly = true;
            numIterations.Size = new Size(85, 27);
            numIterations.TabIndex = 2;
            numIterations.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbMethod
            // 
            cbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMethod.FormattingEnabled = true;
            cbMethod.Location = new Point(73, 30);
            cbMethod.Name = "cbMethod";
            cbMethod.Size = new Size(151, 28);
            cbMethod.TabIndex = 1;
            // 
            // lbMethod
            // 
            lbMethod.AutoSize = true;
            lbMethod.Location = new Point(9, 33);
            lbMethod.Name = "lbMethod";
            lbMethod.Size = new Size(68, 20);
            lbMethod.TabIndex = 0;
            lbMethod.Text = "Method :";
            // 
            // gpStrElmnt
            // 
            gpStrElmnt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpStrElmnt.Controls.Add(lbSz);
            gpStrElmnt.Controls.Add(numElmSize);
            gpStrElmnt.Controls.Add(lbShape);
            gpStrElmnt.Controls.Add(cbShape);
            gpStrElmnt.Dock = DockStyle.Fill;
            gpStrElmnt.Location = new Point(3, 209);
            gpStrElmnt.Name = "gpStrElmnt";
            gpStrElmnt.Size = new Size(516, 141);
            gpStrElmnt.TabIndex = 4;
            gpStrElmnt.TabStop = false;
            gpStrElmnt.Text = "Sturcturing Element";
            // 
            // lbSz
            // 
            lbSz.AutoSize = true;
            lbSz.Location = new Point(9, 92);
            lbSz.Name = "lbSz";
            lbSz.Size = new Size(78, 20);
            lbSz.TabIndex = 3;
            lbSz.Text = "Size(KxK) :";
            // 
            // numElmSize
            // 
            numElmSize.Location = new Point(93, 90);
            numElmSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numElmSize.Name = "numElmSize";
            numElmSize.ReadOnly = true;
            numElmSize.Size = new Size(65, 27);
            numElmSize.TabIndex = 2;
            numElmSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbShape
            // 
            lbShape.AutoSize = true;
            lbShape.Location = new Point(9, 40);
            lbShape.Name = "lbShape";
            lbShape.Size = new Size(57, 20);
            lbShape.TabIndex = 1;
            lbShape.Text = "Shape :";
            // 
            // cbShape
            // 
            cbShape.DropDownStyle = ComboBoxStyle.DropDownList;
            cbShape.FormattingEnabled = true;
            cbShape.Location = new Point(72, 37);
            cbShape.Name = "cbShape";
            cbShape.Size = new Size(151, 28);
            cbShape.TabIndex = 0;
            // 
            // MorfologyWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(522, 353);
            Controls.Add(layoutMain);
            ForeColor = SystemColors.ActiveCaptionText;
            MinimumSize = new Size(540, 400);
            Name = "MorfologyWindow";
            Text = "MorfologyWindow";
            layoutMain.ResumeLayout(false);
            pnBtn.ResumeLayout(false);
            gpParams.ResumeLayout(false);
            gpParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIterations).EndInit();
            gpStrElmnt.ResumeLayout(false);
            gpStrElmnt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numElmSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutMain;
        private Panel pnBtn;
        private GroupBox gpParams;
        private GroupBox gpStrElmnt;
        private Button btRun;
        private Label lbShape;
        private ComboBox cbShape;
        private Label lbMethod;
        private Label lbSz;
        private NumericUpDown numElmSize;
        private ComboBox cbMethod;
        private ComboBox cbBorder;
        private Label lbBorder;
        private NumericUpDown numIterations;
        private Label lbIteration;
        private HelpProvider helper;
    }
}