namespace Apo.customUI
{
    partial class LaplacianUI
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
            lblDepth = new Label();
            label2 = new Label();
            cbDepth = new ComboBox();
            cbBorder = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numSize = new NumericUpDown();
            tbScale = new TextBox();
            tbDelta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            SuspendLayout();
            // 
            // lblDepth
            // 
            lblDepth.AutoSize = true;
            lblDepth.Location = new Point(3, 9);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(57, 20);
            lblDepth.TabIndex = 0;
            lblDepth.Text = "Depth :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 65);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Border :";
            // 
            // cbDepth
            // 
            cbDepth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepth.FormattingEnabled = true;
            cbDepth.Location = new Point(59, 3);
            cbDepth.Name = "cbDepth";
            cbDepth.Size = new Size(123, 28);
            cbDepth.TabIndex = 1;
            // 
            // cbBorder
            // 
            cbBorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBorder.FormattingEnabled = true;
            cbBorder.Location = new Point(59, 62);
            cbBorder.Name = "cbBorder";
            cbBorder.Size = new Size(123, 28);
            cbBorder.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 9);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 0;
            label3.Text = "k Size :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 65);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 0;
            label4.Text = "Scale :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 0;
            label5.Text = "Delta :";
            // 
            // numSize
            // 
            numSize.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numSize.Location = new Point(304, 4);
            numSize.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.ReadOnly = true;
            numSize.Size = new Size(129, 27);
            numSize.TabIndex = 3;
            numSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // tbScale
            // 
            tbScale.Location = new Point(304, 62);
            tbScale.Name = "tbScale";
            tbScale.Size = new Size(129, 27);
            tbScale.TabIndex = 4;
            // 
            // tbDelta
            // 
            tbDelta.Location = new Point(59, 129);
            tbDelta.Name = "tbDelta";
            tbDelta.Size = new Size(123, 27);
            tbDelta.TabIndex = 5;
            // 
            // LaplacianUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tbDelta);
            Controls.Add(tbScale);
            Controls.Add(numSize);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbBorder);
            Controls.Add(cbDepth);
            Controls.Add(label2);
            Controls.Add(lblDepth);
            Name = "LaplacianUI";
            Size = new Size(436, 159);
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TbDelta_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblDepth;
        private Label label2;
        private ComboBox cbDepth;
        private ComboBox cbBorder;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numSize;
        private TextBox tbScale;
        private TextBox tbDelta;
    }
}
