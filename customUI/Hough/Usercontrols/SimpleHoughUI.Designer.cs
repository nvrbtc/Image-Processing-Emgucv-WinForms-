namespace APO_Tsarehradskiy.customUI
{
    partial class SimpleHoughUI
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
            layoutInput = new TableLayoutPanel();
            gpInptArgs = new GroupBox();
            tbThrsh = new TextBox();
            tbTheta = new TextBox();
            tbStn = new TextBox();
            tbSrn = new TextBox();
            tbRho = new TextBox();
            lbStn = new Label();
            lbSrn = new Label();
            lbTr = new Label();
            lbTheta = new Label();
            lbRho = new Label();
            groupBox2 = new GroupBox();
            cbLine = new ComboBox();
            tbThic = new TextBox();
            lbLineType = new Label();
            lbThcns = new Label();
            layoutInput.SuspendLayout();
            gpInptArgs.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // layoutInput
            // 
            layoutInput.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutInput.ColumnCount = 1;
            layoutInput.ColumnStyles.Add(new ColumnStyle());
            layoutInput.Controls.Add(gpInptArgs, 0, 0);
            layoutInput.Controls.Add(groupBox2, 0, 1);
            layoutInput.Dock = DockStyle.Fill;
            layoutInput.Location = new Point(0, 0);
            layoutInput.Name = "layoutInput";
            layoutInput.RowCount = 2;
            layoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            layoutInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            layoutInput.Size = new Size(593, 300);
            layoutInput.TabIndex = 0;
            // 
            // gpInptArgs
            // 
            gpInptArgs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpInptArgs.Controls.Add(tbThrsh);
            gpInptArgs.Controls.Add(tbTheta);
            gpInptArgs.Controls.Add(tbStn);
            gpInptArgs.Controls.Add(tbSrn);
            gpInptArgs.Controls.Add(tbRho);
            gpInptArgs.Controls.Add(lbStn);
            gpInptArgs.Controls.Add(lbSrn);
            gpInptArgs.Controls.Add(lbTr);
            gpInptArgs.Controls.Add(lbTheta);
            gpInptArgs.Controls.Add(lbRho);
            gpInptArgs.Dock = DockStyle.Fill;
            gpInptArgs.Location = new Point(3, 3);
            gpInptArgs.Name = "gpInptArgs";
            gpInptArgs.Size = new Size(587, 194);
            gpInptArgs.TabIndex = 0;
            gpInptArgs.TabStop = false;
            gpInptArgs.Text = "Input arguments";
            // 
            // tbThrsh
            // 
            tbThrsh.Location = new Point(102, 75);
            tbThrsh.MaxLength = 3;
            tbThrsh.Name = "tbThrsh";
            tbThrsh.Size = new Size(125, 27);
            tbThrsh.TabIndex = 2;
            // 
            // tbTheta
            // 
            tbTheta.Location = new Point(102, 128);
            tbTheta.MaxLength = 3;
            tbTheta.Name = "tbTheta";
            tbTheta.Size = new Size(125, 27);
            tbTheta.TabIndex = 3;
            // 
            // tbStn
            // 
            tbStn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbStn.Location = new Point(456, 75);
            tbStn.MaxLength = 4;
            tbStn.MinimumSize = new Size(120, 25);
            tbStn.Name = "tbStn";
            tbStn.Size = new Size(125, 27);
            tbStn.TabIndex = 5;
            // 
            // tbSrn
            // 
            tbSrn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSrn.Location = new Point(456, 30);
            tbSrn.MaxLength = 4;
            tbSrn.Name = "tbSrn";
            tbSrn.Size = new Size(125, 27);
            tbSrn.TabIndex = 4;
            // 
            // tbRho
            // 
            tbRho.Location = new Point(102, 29);
            tbRho.MaxLength = 3;
            tbRho.Name = "tbRho";
            tbRho.Size = new Size(125, 27);
            tbRho.TabIndex = 1;
            // 
            // lbStn
            // 
            lbStn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbStn.Location = new Point(334, 78);
            lbStn.Name = "lbStn";
            lbStn.Size = new Size(116, 20);
            lbStn.TabIndex = 0;
            lbStn.Text = "Srn :";
            lbStn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbSrn
            // 
            lbSrn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbSrn.Location = new Point(334, 33);
            lbSrn.Name = "lbSrn";
            lbSrn.Size = new Size(116, 20);
            lbSrn.TabIndex = 0;
            lbSrn.Text = "Stn :";
            lbSrn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTr
            // 
            lbTr.Location = new Point(6, 131);
            lbTr.Name = "lbTr";
            lbTr.Size = new Size(90, 20);
            lbTr.TabIndex = 0;
            lbTr.Text = "Threshold :";
            lbTr.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTheta
            // 
            lbTheta.Location = new Point(6, 78);
            lbTheta.Name = "lbTheta";
            lbTheta.Size = new Size(90, 20);
            lbTheta.TabIndex = 0;
            lbTheta.Text = "Theta (Pi/x):";
            lbTheta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbRho
            // 
            lbRho.Location = new Point(6, 33);
            lbRho.Name = "lbRho";
            lbRho.Size = new Size(90, 20);
            lbRho.TabIndex = 0;
            lbRho.Text = "Rho (px ) : ";
            lbRho.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(cbLine);
            groupBox2.Controls.Add(tbThic);
            groupBox2.Controls.Add(lbLineType);
            groupBox2.Controls.Add(lbThcns);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(587, 94);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output line arguments";
            // 
            // cbLine
            // 
            cbLine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbLine.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLine.FormattingEnabled = true;
            cbLine.Location = new Point(456, 36);
            cbLine.Name = "cbLine";
            cbLine.Size = new Size(125, 28);
            cbLine.TabIndex = 7;
            // 
            // tbThic
            // 
            tbThic.Location = new Point(121, 36);
            tbThic.Name = "tbThic";
            tbThic.Size = new Size(125, 27);
            tbThic.TabIndex = 6;
            // 
            // lbLineType
            // 
            lbLineType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbLineType.AutoSize = true;
            lbLineType.Location = new Point(374, 39);
            lbLineType.Name = "lbLineType";
            lbLineType.Size = new Size(76, 20);
            lbLineType.TabIndex = 0;
            lbLineType.Text = "Line type :";
            // 
            // lbThcns
            // 
            lbThcns.AutoSize = true;
            lbThcns.Location = new Point(6, 39);
            lbThcns.Name = "lbThcns";
            lbThcns.Size = new Size(109, 20);
            lbThcns.TabIndex = 0;
            lbThcns.Text = "Line Thickness :";
            lbThcns.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SimpleHoughUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(layoutInput);
            Name = "SimpleHoughUI";
            Size = new Size(593, 300);
            layoutInput.ResumeLayout(false);
            gpInptArgs.ResumeLayout(false);
            gpInptArgs.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutInput;
        private GroupBox gpInptArgs;
        private GroupBox groupBox2;
        private TextBox tbThrsh;
        private TextBox tbTheta;
        private TextBox tbStn;
        private TextBox tbSrn;
        private TextBox tbRho;
        private Label lbStn;
        private Label lbSrn;
        private Label lbTr;
        private Label lbTheta;
        private Label lbRho;
        private ComboBox cbLine;
        private TextBox tbThic;
        private Label lbLineType;
        private Label lbThcns;
    }
}
