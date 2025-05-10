namespace Apo.customUI
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
            lbDepth = new Label();
            lbX = new Label();
            lbY = new Label();
            lbSize = new Label();
            lbS = new Label();
            lbDelta = new Label();
            lbBorder = new Label();
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
            // lbDepth
            // 
            lbDepth.AutoSize = true;
            lbDepth.Location = new Point(3, 14);
            lbDepth.Name = "lbDepth";
            lbDepth.Size = new Size(57, 20);
            lbDepth.TabIndex = 0;
            lbDepth.Text = "Depth :";
            // 
            // lbX
            // 
            lbX.AutoSize = true;
            lbX.Location = new Point(3, 66);
            lbX.Name = "lbX";
            lbX.Size = new Size(71, 20);
            lbX.TabIndex = 0;
            lbX.Text = "Order(x) :";
            // 
            // lbY
            // 
            lbY.AutoSize = true;
            lbY.Location = new Point(3, 132);
            lbY.Name = "lbY";
            lbY.Size = new Size(71, 20);
            lbY.TabIndex = 0;
            lbY.Text = "Order(y) :";
            // 
            // lbSize
            // 
            lbSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbSize.AutoSize = true;
            lbSize.Location = new Point(290, 15);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(50, 20);
            lbSize.TabIndex = 0;
            lbSize.Text = "kSize :";
            // 
            // lbS
            // 
            lbS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbS.AutoSize = true;
            lbS.Location = new Point(290, 66);
            lbS.Name = "lbS";
            lbS.Size = new Size(51, 20);
            lbS.TabIndex = 0;
            lbS.Text = "Scale :";
            // 
            // lbDelta
            // 
            lbDelta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbDelta.AutoSize = true;
            lbDelta.Location = new Point(290, 132);
            lbDelta.Name = "lbDelta";
            lbDelta.Size = new Size(52, 20);
            lbDelta.TabIndex = 0;
            lbDelta.Text = "Delta :";
            // 
            // lbBorder
            // 
            lbBorder.AutoSize = true;
            lbBorder.Location = new Point(3, 206);
            lbBorder.Name = "lbBorder";
            lbBorder.Size = new Size(92, 20);
            lbBorder.TabIndex = 0;
            lbBorder.Text = "BorderType :";
            // 
            // cbDepth
            // 
            cbDepth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepth.FormattingEnabled = true;
            cbDepth.Location = new Point(80, 11);
            cbDepth.Name = "cbDepth";
            cbDepth.Size = new Size(125, 28);
            cbDepth.TabIndex = 1;
            // 
            // txtX
            // 
            txtX.Location = new Point(80, 63);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 2;
            // 
            // txtY
            // 
            txtY.Location = new Point(80, 129);
            txtY.Name = "txtY";
            txtY.Size = new Size(125, 27);
            txtY.TabIndex = 3;
            // 
            // txtScale
            // 
            txtScale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtScale.Location = new Point(348, 63);
            txtScale.Name = "txtScale";
            txtScale.Size = new Size(125, 27);
            txtScale.TabIndex = 6;
            // 
            // txtDelta
            // 
            txtDelta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDelta.Location = new Point(348, 129);
            txtDelta.Name = "txtDelta";
            txtDelta.Size = new Size(125, 27);
            txtDelta.TabIndex = 7;
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
            kSize.TabIndex = 5;
            kSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbBorder
            // 
            cbBorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBorder.FormattingEnabled = true;
            cbBorder.Location = new Point(101, 203);
            cbBorder.Name = "cbBorder";
            cbBorder.Size = new Size(126, 28);
            cbBorder.TabIndex = 4;
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
            Controls.Add(lbBorder);
            Controls.Add(lbDelta);
            Controls.Add(lbS);
            Controls.Add(lbSize);
            Controls.Add(lbY);
            Controls.Add(lbX);
            Controls.Add(lbDepth);
            Name = "SobelUI";
            Size = new Size(476, 234);
            ((System.ComponentModel.ISupportInitialize)kSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDepth;
        private Label lbX;
        private Label lbY;
        private Label lbSize;
        private Label lbS;
        private Label lbDelta;
        private Label lbBorder;
        private ComboBox cbDepth;
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtScale;
        private TextBox txtDelta;
        private NumericUpDown kSize;
        private ComboBox cbBorder;
    }
}
