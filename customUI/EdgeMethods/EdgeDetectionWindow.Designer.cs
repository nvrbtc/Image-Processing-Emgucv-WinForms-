namespace APO_Tsarehradskiy.customUI
{
    partial class EdgeDetectionWindow
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
            grpMethod = new GroupBox();
            btnRun = new Button();
            label1 = new Label();
            cbMethod = new ComboBox();
            grpParams = new GroupBox();
            grpMethod.SuspendLayout();
            SuspendLayout();
            // 
            // grpMethod
            // 
            grpMethod.Controls.Add(btnRun);
            grpMethod.Controls.Add(label1);
            grpMethod.Controls.Add(cbMethod);
            grpMethod.Dock = DockStyle.Top;
            grpMethod.Location = new Point(0, 0);
            grpMethod.Name = "grpMethod";
            grpMethod.Size = new Size(800, 71);
            grpMethod.TabIndex = 0;
            grpMethod.TabStop = false;
            grpMethod.Text = "Method&Edges";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(694, 19);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 5;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = "Edge method :";
            // 
            // cbMethod
            // 
            cbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMethod.FormattingEnabled = true;
            cbMethod.Location = new Point(133, 20);
            cbMethod.Name = "cbMethod";
            cbMethod.Size = new Size(151, 28);
            cbMethod.TabIndex = 0;
            // 
            // grpParams
            // 
            grpParams.Dock = DockStyle.Fill;
            grpParams.Location = new Point(0, 71);
            grpParams.Name = "grpParams";
            grpParams.Size = new Size(800, 379);
            grpParams.TabIndex = 1;
            grpParams.TabStop = false;
            grpParams.Text = "Parameters";
            // 
            // EdgeDetectionWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(grpParams);
            Controls.Add(grpMethod);
            Name = "EdgeDetectionWindow";
            Text = "EdgeDetectionWindow";
            grpMethod.ResumeLayout(false);
            grpMethod.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMethod;
        private ComboBox cbMethod;
        private Label label1;
        private GroupBox grpParams;
        private Button btnRun;
    }
}