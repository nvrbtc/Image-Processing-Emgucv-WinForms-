namespace APO_Tsarehradskiy.customUI
{
    partial class BlurWindow
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
            pnMain = new Panel();
            labelMethod = new Label();
            comboMethod = new ComboBox();
            labelBorder = new Label();
            comboBorder = new ComboBox();
            labelSize = new Label();
            textBoxSize = new TextBox();
            trackSize = new TrackBar();
            Start = new Button();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackSize).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(labelMethod);
            pnMain.Controls.Add(comboMethod);
            pnMain.Controls.Add(labelBorder);
            pnMain.Controls.Add(comboBorder);
            pnMain.Controls.Add(labelSize);
            pnMain.Controls.Add(textBoxSize);
            pnMain.Controls.Add(trackSize);
            pnMain.Controls.Add(Start);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(582, 253);
            pnMain.TabIndex = 0;
            // 
            // labelMethod
            // 
            labelMethod.AutoSize = true;
            labelMethod.Location = new Point(12, 109);
            labelMethod.Name = "labelMethod";
            labelMethod.Size = new Size(94, 20);
            labelMethod.TabIndex = 7;
            labelMethod.Text = "Blur method:";
            // 
            // comboMethod
            // 
            comboMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMethod.FormattingEnabled = true;
            comboMethod.Location = new Point(131, 106);
            comboMethod.Name = "comboMethod";
            comboMethod.Size = new Size(151, 28);
            comboMethod.TabIndex = 6;
            // 
            // labelBorder
            // 
            labelBorder.AutoSize = true;
            labelBorder.Location = new Point(12, 60);
            labelBorder.Name = "labelBorder";
            labelBorder.Size = new Size(90, 20);
            labelBorder.TabIndex = 5;
            labelBorder.Text = "Border type:";
            // 
            // comboBorder
            // 
            comboBorder.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBorder.Location = new Point(131, 57);
            comboBorder.Name = "comboBorder";
            comboBorder.Size = new Size(151, 28);
            comboBorder.TabIndex = 4;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(12, 16);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(113, 20);
            labelSize.TabIndex = 3;
            labelSize.Text = "Box size ( KxK ):";
            // 
            // textBoxSize
            // 
            textBoxSize.Enabled = false;
            textBoxSize.Location = new Point(131, 14);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.ReadOnly = true;
            textBoxSize.Size = new Size(125, 27);
            textBoxSize.TabIndex = 2;
            // 
            // trackSize
            // 
            trackSize.Dock = DockStyle.Bottom;
            trackSize.LargeChange = 2;
            trackSize.Location = new Point(0, 197);
            trackSize.Maximum = 7;
            trackSize.Minimum = 1;
            trackSize.Name = "trackSize";
            trackSize.Size = new Size(582, 56);
            trackSize.SmallChange = 2;
            trackSize.TabIndex = 1;
            trackSize.TabStop = false;
            trackSize.Value = 1;
            // 
            // Start
            // 
            Start.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Start.Location = new Point(481, 14);
            Start.Margin = new Padding(3, 10, 3, 3);
            Start.Name = "Start";
            Start.Size = new Size(94, 29);
            Start.TabIndex = 0;
            Start.Text = "Blur";
            Start.UseVisualStyleBackColor = true;
            Start.Click += ApplyBlur;
            // 
            // BlurWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 253);
            Controls.Add(pnMain);
            MaximizeBox = false;
            MaximumSize = new Size(605, 300);
            MinimumSize = new Size(600, 300);
            Name = "BlurWindow";
            Text = "BlurWindow";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Button Start;
        private TrackBar trackSize;
        private Label labelSize;
        private TextBox textBoxSize;
        private ComboBox comboBorder;
        private Label labelBorder;
        private Label labelMethod;
        private ComboBox comboMethod;
    }
}