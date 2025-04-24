namespace APO_Tsarehradskiy.customUI.EdgeMethods
{
    partial class CannyUI
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
            lbTr1 = new Label();
            lbTr2 = new Label();
            lbSize = new Label();
            lbGradient = new Label();
            numSz = new NumericUpDown();
            boxGradient = new CheckBox();
            numTr2 = new NumericUpDown();
            numTr1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numSz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTr2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTr1).BeginInit();
            SuspendLayout();
            // 
            // lbTr1
            // 
            lbTr1.AutoSize = true;
            lbTr1.Location = new Point(3, 19);
            lbTr1.Name = "lbTr1";
            lbTr1.Size = new Size(80, 20);
            lbTr1.TabIndex = 0;
            lbTr1.Text = "Treshold1 :";
            // 
            // lbTr2
            // 
            lbTr2.AutoSize = true;
            lbTr2.Location = new Point(3, 141);
            lbTr2.Name = "lbTr2";
            lbTr2.Size = new Size(80, 20);
            lbTr2.TabIndex = 0;
            lbTr2.Text = "Treshold2 :";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Location = new Point(290, 19);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(103, 20);
            lbSize.TabIndex = 0;
            lbSize.Text = "Aperture size :";
            // 
            // lbGradient
            // 
            lbGradient.AutoSize = true;
            lbGradient.Location = new Point(290, 141);
            lbGradient.Name = "lbGradient";
            lbGradient.Size = new Size(77, 20);
            lbGradient.TabIndex = 0;
            lbGradient.Text = "Gradiend :";
            // 
            // numSz
            // 
            numSz.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numSz.InterceptArrowKeys = false;
            numSz.Location = new Point(399, 17);
            numSz.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSz.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numSz.Name = "numSz";
            numSz.ReadOnly = true;
            numSz.Size = new Size(92, 27);
            numSz.TabIndex = 3;
            numSz.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // boxGradient
            // 
            boxGradient.AutoSize = true;
            boxGradient.Location = new Point(399, 140);
            boxGradient.Name = "boxGradient";
            boxGradient.Size = new Size(76, 24);
            boxGradient.TabIndex = 4;
            boxGradient.Text = "Enable";
            boxGradient.UseVisualStyleBackColor = true;
            // 
            // numTr2
            // 
            numTr2.InterceptArrowKeys = false;
            numTr2.Location = new Point(89, 139);
            numTr2.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numTr2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTr2.Name = "numTr2";
            numTr2.ReadOnly = true;
            numTr2.Size = new Size(92, 27);
            numTr2.TabIndex = 2;
            numTr2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numTr1
            // 
            numTr1.InterceptArrowKeys = false;
            numTr1.Location = new Point(89, 17);
            numTr1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numTr1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTr1.Name = "numTr1";
            numTr1.ReadOnly = true;
            numTr1.Size = new Size(92, 27);
            numTr1.TabIndex = 1;
            numTr1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CannyUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numTr1);
            Controls.Add(numTr2);
            Controls.Add(boxGradient);
            Controls.Add(numSz);
            Controls.Add(lbGradient);
            Controls.Add(lbSize);
            Controls.Add(lbTr2);
            Controls.Add(lbTr1);
            Name = "CannyUI";
            Size = new Size(533, 346);
            ((System.ComponentModel.ISupportInitialize)numSz).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTr2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTr1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTr1;
        private Label lbTr2;
        private Label lbSize;
        private Label lbGradient;
        private NumericUpDown numSz;
        private CheckBox boxGradient;
        private NumericUpDown numTr2;
        private NumericUpDown numTr1;
    }
}
