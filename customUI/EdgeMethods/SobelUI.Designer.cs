namespace APO_Tsarehradskiy.customUI.Edgecontrol
{
    partial class SobelUI
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbDepth = new ComboBox();
            txtX = new TextBox();
            txtY = new TextBox();
            txtScale = new TextBox();
            txtDelta = new TextBox();
            kSize = new NumericUpDown();
            cbBorder = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)kSize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Depth :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 66);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Order(x) :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 132);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 2;
            label3.Text = "Order(y) :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(290, 15);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "kSize :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(290, 66);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Scale :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(290, 132);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 5;
            label6.Text = "Delta :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 206);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 6;
            label7.Text = "BorderType :";
            // 
            // cbDepth
            // 
            cbDepth.Anchor = AnchorStyles.Left;
            cbDepth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepth.FormattingEnabled = true;
            cbDepth.Location = new Point(80, 11);
            cbDepth.Name = "cbDepth";
            cbDepth.Size = new Size(125, 28);
            cbDepth.TabIndex = 7;
            // 
            // txtX
            // 
            txtX.Anchor = AnchorStyles.Left;
            txtX.Location = new Point(80, 63);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 8;
            // 
            // txtY
            // 
            txtY.Anchor = AnchorStyles.Left;
            txtY.Location = new Point(80, 129);
            txtY.Name = "txtY";
            txtY.Size = new Size(125, 27);
            txtY.TabIndex = 9;
            // 
            // txtScale
            // 
            txtScale.Anchor = AnchorStyles.Right;
            txtScale.Location = new Point(348, 63);
            txtScale.Name = "txtScale";
            txtScale.Size = new Size(125, 27);
            txtScale.TabIndex = 10;
            // 
            // txtDelta
            // 
            txtDelta.Anchor = AnchorStyles.Right;
            txtDelta.Location = new Point(348, 129);
            txtDelta.Name = "txtDelta";
            txtDelta.Size = new Size(125, 27);
            txtDelta.TabIndex = 11;
            // 
            // kSize
            // 
            kSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kSize.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            kSize.Location = new Point(348, 12);
            kSize.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            kSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            kSize.Name = "kSize";
            kSize.ReadOnly = true;
            kSize.Size = new Size(125, 27);
            kSize.TabIndex = 12;
            kSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbBorder
            // 
            cbBorder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbBorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBorder.FormattingEnabled = true;
            cbBorder.Location = new Point(101, 203);
            cbBorder.Name = "cbBorder";
            cbBorder.Size = new Size(126, 28);
            cbBorder.TabIndex = 13;
            // 
            // SobelUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(cbBorder);
            Controls.Add(kSize);
            Controls.Add(txtDelta);
            Controls.Add(txtScale);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(cbDepth);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SobelUI";
            Size = new Size(476, 234);
            ((System.ComponentModel.ISupportInitialize)kSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbDepth;
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtScale;
        private TextBox txtDelta;
        private NumericUpDown kSize;
        private ComboBox cbBorder;
    }
}
