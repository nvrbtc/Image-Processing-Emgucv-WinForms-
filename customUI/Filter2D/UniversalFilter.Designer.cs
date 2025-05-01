namespace APO_Tsarehradskiy.customUI
{
    partial class UniversalFilterWindow
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            error = new ErrorProvider(components);
            lbBorder = new Label();
            cbBorder = new ComboBox();
            gridMatrix = new DataGridView();
            a1 = new DataGridViewTextBoxColumn();
            a2 = new DataGridViewTextBoxColumn();
            a3 = new DataGridViewTextBoxColumn();
            tbDelta = new TextBox();
            lbDelta = new Label();
            tableLayout = new TableLayoutPanel();
            pnInput = new Panel();
            btRun = new Button();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridMatrix).BeginInit();
            tableLayout.SuspendLayout();
            pnInput.SuspendLayout();
            SuspendLayout();
            // 
            // error
            // 
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            error.ContainerControl = this;
            // 
            // lbBorder
            // 
            lbBorder.AutoSize = true;
            lbBorder.Location = new Point(9, 23);
            lbBorder.Name = "lbBorder";
            lbBorder.Size = new Size(94, 20);
            lbBorder.TabIndex = 0;
            lbBorder.Text = "Border type :";
            // 
            // cbBorder
            // 
            cbBorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBorder.FormattingEnabled = true;
            cbBorder.Location = new Point(109, 20);
            cbBorder.Name = "cbBorder";
            cbBorder.Size = new Size(151, 28);
            cbBorder.TabIndex = 1;
            // 
            // gridMatrix
            // 
            gridMatrix.AllowUserToAddRows = false;
            gridMatrix.AllowUserToDeleteRows = false;
            gridMatrix.AllowUserToResizeColumns = false;
            gridMatrix.AllowUserToResizeRows = false;
            gridMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMatrix.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            gridMatrix.BackgroundColor = SystemColors.ButtonHighlight;
            gridMatrix.BorderStyle = BorderStyle.Fixed3D;
            gridMatrix.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            gridMatrix.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            gridMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMatrix.Columns.AddRange(new DataGridViewColumn[] { a1, a2, a3 });
            gridMatrix.Cursor = Cursors.IBeam;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridMatrix.DefaultCellStyle = dataGridViewCellStyle1;
            gridMatrix.Dock = DockStyle.Fill;
            gridMatrix.GridColor = SystemColors.MenuBar;
            gridMatrix.Location = new Point(3, 73);
            gridMatrix.Name = "gridMatrix";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridMatrix.RowHeadersWidth = 51;
            gridMatrix.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridMatrix.ShowEditingIcon = false;
            gridMatrix.Size = new Size(611, 112);
            gridMatrix.TabIndex = 3;
            gridMatrix.EditingControlShowing += cellInputHandle;
            // 
            // a1
            // 
            a1.HeaderText = "C1";
            a1.MinimumWidth = 6;
            a1.Name = "a1";
            // 
            // a2
            // 
            a2.HeaderText = "C2";
            a2.MinimumWidth = 6;
            a2.Name = "a2";
            // 
            // a3
            // 
            a3.HeaderText = "C3";
            a3.MinimumWidth = 6;
            a3.Name = "a3";
            // 
            // tbDelta
            // 
            tbDelta.Location = new Point(324, 20);
            tbDelta.Name = "tbDelta";
            tbDelta.Size = new Size(125, 27);
            tbDelta.TabIndex = 2;
            // 
            // lbDelta
            // 
            lbDelta.AutoSize = true;
            lbDelta.Location = new Point(266, 23);
            lbDelta.Name = "lbDelta";
            lbDelta.Size = new Size(52, 20);
            lbDelta.TabIndex = 0;
            lbDelta.Text = "Delta :";
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 1;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.Controls.Add(pnInput, 0, 0);
            tableLayout.Controls.Add(gridMatrix, 0, 1);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 2;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.Size = new Size(617, 188);
            tableLayout.TabIndex = 5;
            // 
            // pnInput
            // 
            pnInput.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnInput.Controls.Add(btRun);
            pnInput.Controls.Add(lbBorder);
            pnInput.Controls.Add(tbDelta);
            pnInput.Controls.Add(cbBorder);
            pnInput.Controls.Add(lbDelta);
            pnInput.Dock = DockStyle.Fill;
            pnInput.Location = new Point(3, 3);
            pnInput.Name = "pnInput";
            pnInput.Size = new Size(611, 64);
            pnInput.TabIndex = 4;
            // 
            // btRun
            // 
            btRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btRun.Location = new Point(508, 19);
            btRun.Name = "btRun";
            btRun.Size = new Size(94, 29);
            btRun.TabIndex = 4;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += RunButton;
            // 
            // UniversalFilterWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(617, 188);
            Controls.Add(tableLayout);
            MaximumSize = new Size(800, 235);
            MinimumSize = new Size(635, 235);
            Name = "UniversalFilterWindow";
            Text = "UniversalFilter";
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridMatrix).EndInit();
            tableLayout.ResumeLayout(false);
            pnInput.ResumeLayout(false);
            pnInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnArguments;
        private Label lbBorder;
        private DataGridView gridMatrix;
        private DataGridViewTextBoxColumn a1;
        private DataGridViewTextBoxColumn a2;
        private DataGridViewTextBoxColumn a3;
        private ComboBox cbBorder;
        private TextBox tbDelta;
        private Label lbDelta;
        private ErrorProvider error;
        private TableLayoutPanel tableLayout;
        private Panel pnInput;
        private Button btRun;
    }
}