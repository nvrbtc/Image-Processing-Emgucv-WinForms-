namespace APO_Tsarehradskiy.customUI
{
    partial class ProbHoughUI
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
            helpTheta = new HelpProvider();
            helpGap = new HelpProvider();
            helpWidth = new HelpProvider();
            layoutUsrctrl = new TableLayoutPanel();
            gpInpPrms = new GroupBox();
            tbThrsh = new TextBox();
            tbTheta = new TextBox();
            tbGap = new TextBox();
            tbLength = new TextBox();
            tbRho = new TextBox();
            lbMaxGap = new Label();
            lbLineW = new Label();
            lbThet = new Label();
            lbThrsh = new Label();
            lbRho = new Label();
            gpOutPrms = new GroupBox();
            cbLine = new ComboBox();
            tbThickness = new TextBox();
            lbLineType = new Label();
            lbThcns = new Label();
            layoutUsrctrl.SuspendLayout();
            gpInpPrms.SuspendLayout();
            gpOutPrms.SuspendLayout();
            SuspendLayout();
            // 
            // layoutUsrctrl
            // 
            layoutUsrctrl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutUsrctrl.ColumnCount = 1;
            layoutUsrctrl.ColumnStyles.Add(new ColumnStyle());
            layoutUsrctrl.Controls.Add(gpInpPrms, 0, 0);
            layoutUsrctrl.Controls.Add(gpOutPrms, 0, 1);
            layoutUsrctrl.Dock = DockStyle.Fill;
            layoutUsrctrl.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutUsrctrl.Location = new Point(0, 0);
            layoutUsrctrl.Name = "layoutUsrctrl";
            layoutUsrctrl.RowCount = 2;
            layoutUsrctrl.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            layoutUsrctrl.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            layoutUsrctrl.Size = new Size(585, 294);
            layoutUsrctrl.TabIndex = 0;
            // 
            // gpInpPrms
            // 
            gpInpPrms.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpInpPrms.Controls.Add(tbThrsh);
            gpInpPrms.Controls.Add(tbTheta);
            gpInpPrms.Controls.Add(tbGap);
            gpInpPrms.Controls.Add(tbLength);
            gpInpPrms.Controls.Add(tbRho);
            gpInpPrms.Controls.Add(lbMaxGap);
            gpInpPrms.Controls.Add(lbLineW);
            gpInpPrms.Controls.Add(lbThet);
            gpInpPrms.Controls.Add(lbThrsh);
            gpInpPrms.Controls.Add(lbRho);
            gpInpPrms.Dock = DockStyle.Fill;
            gpInpPrms.Location = new Point(3, 3);
            gpInpPrms.Name = "gpInpPrms";
            gpInpPrms.Size = new Size(579, 194);
            gpInpPrms.TabIndex = 0;
            gpInpPrms.TabStop = false;
            gpInpPrms.Text = "Input arguments";
            // 
            // tbThrsh
            // 
            tbThrsh.Location = new Point(102, 124);
            tbThrsh.MaxLength = 3;
            tbThrsh.Name = "tbThrsh";
            tbThrsh.Size = new Size(125, 27);
            tbThrsh.TabIndex = 3;
            // 
            // tbTheta
            // 
            tbTheta.Location = new Point(102, 74);
            tbTheta.MaxLength = 3;
            tbTheta.Name = "tbTheta";
            tbTheta.Size = new Size(125, 27);
            tbTheta.TabIndex = 2;
            // 
            // tbGap
            // 
            tbGap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbGap.Location = new Point(448, 74);
            tbGap.MaxLength = 4;
            tbGap.MinimumSize = new Size(120, 25);
            tbGap.Name = "tbGap";
            tbGap.Size = new Size(125, 27);
            tbGap.TabIndex = 5;
            // 
            // tbLength
            // 
            tbLength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbLength.Location = new Point(448, 28);
            tbLength.MaxLength = 4;
            tbLength.Name = "tbLength";
            tbLength.Size = new Size(125, 27);
            tbLength.TabIndex = 4;
            // 
            // tbRho
            // 
            tbRho.Location = new Point(102, 28);
            tbRho.MaxLength = 3;
            tbRho.Name = "tbRho";
            tbRho.Size = new Size(125, 27);
            tbRho.TabIndex = 1;
            // 
            // lbMaxGap
            // 
            lbMaxGap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbMaxGap.Location = new Point(326, 77);
            lbMaxGap.Name = "lbMaxGap";
            lbMaxGap.Size = new Size(116, 20);
            lbMaxGap.TabIndex = 0;
            lbMaxGap.Text = "Max Line Gap :";
            lbMaxGap.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbLineW
            // 
            lbLineW.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbLineW.Location = new Point(326, 32);
            lbLineW.Name = "lbLineW";
            lbLineW.Size = new Size(116, 20);
            lbLineW.TabIndex = 0;
            lbLineW.Text = "Min Line Length :";
            lbLineW.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbThet
            // 
            lbThet.Location = new Point(6, 77);
            lbThet.Name = "lbThet";
            lbThet.Size = new Size(90, 20);
            lbThet.TabIndex = 0;
            lbThet.Text = "Theta (Pi/X) :";
            lbThet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbThrsh
            // 
            lbThrsh.Location = new Point(6, 127);
            lbThrsh.Name = "lbThrsh";
            lbThrsh.Size = new Size(90, 20);
            lbThrsh.TabIndex = 0;
            lbThrsh.Text = "Threshold :";
            lbThrsh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbRho
            // 
            lbRho.Location = new Point(6, 32);
            lbRho.Name = "lbRho";
            lbRho.Size = new Size(90, 20);
            lbRho.TabIndex = 0;
            lbRho.Text = "Rho (px ) : ";
            lbRho.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gpOutPrms
            // 
            gpOutPrms.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpOutPrms.Controls.Add(cbLine);
            gpOutPrms.Controls.Add(tbThickness);
            gpOutPrms.Controls.Add(lbLineType);
            gpOutPrms.Controls.Add(lbThcns);
            gpOutPrms.Dock = DockStyle.Fill;
            gpOutPrms.Location = new Point(3, 203);
            gpOutPrms.Name = "gpOutPrms";
            gpOutPrms.Size = new Size(579, 88);
            gpOutPrms.TabIndex = 1;
            gpOutPrms.TabStop = false;
            gpOutPrms.Text = "Output line parameters";
            // 
            // cbLine
            // 
            cbLine.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLine.FormattingEnabled = true;
            cbLine.Location = new Point(448, 39);
            cbLine.Name = "cbLine";
            cbLine.Size = new Size(125, 28);
            cbLine.TabIndex = 7;
            // 
            // tbThickness
            // 
            tbThickness.Location = new Point(121, 39);
            tbThickness.Name = "tbThickness";
            tbThickness.Size = new Size(125, 27);
            tbThickness.TabIndex = 6;
            // 
            // lbLineType
            // 
            lbLineType.AutoSize = true;
            lbLineType.Location = new Point(366, 42);
            lbLineType.Name = "lbLineType";
            lbLineType.Size = new Size(76, 20);
            lbLineType.TabIndex = 0;
            lbLineType.Text = "Line type :";
            // 
            // lbThcns
            // 
            lbThcns.AutoSize = true;
            lbThcns.Location = new Point(6, 42);
            lbThcns.Name = "lbThcns";
            lbThcns.Size = new Size(109, 20);
            lbThcns.TabIndex = 0;
            lbThcns.Text = "Line Thickness :";
            lbThcns.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProbHoughUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(layoutUsrctrl);
            Name = "ProbHoughUI";
            Size = new Size(585, 294);
            layoutUsrctrl.ResumeLayout(false);
            gpInpPrms.ResumeLayout(false);
            gpInpPrms.PerformLayout();
            gpOutPrms.ResumeLayout(false);
            gpOutPrms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        
        private NumericUpDown numThreshold;
        private HelpProvider helpTheta;
        private HelpProvider helpGap;
        private HelpProvider helpWidth;
        private TableLayoutPanel layoutUsrctrl;
        private GroupBox gpInpPrms;
        private TextBox tbThrsh;
        private TextBox tbTheta;
        private TextBox tbGap;
        private TextBox tbLength;
        private TextBox tbRho;
        private Label lbMaxGap;
        private Label lbLineW;
        private Label lbThet;
        private Label lbThrsh;
        private Label lbRho;
        private GroupBox gpOutPrms;
        private Label lbLineType;
        private Label lbThcns;
        private ComboBox cbLine;
        private TextBox tbThickness;
    }
}
