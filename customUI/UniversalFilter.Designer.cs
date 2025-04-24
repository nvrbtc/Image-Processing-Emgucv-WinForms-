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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnArguments = new Panel();
            tbDelta = new TextBox();
            lbDelta = new Label();
            btRun = new Button();
            cbBorder = new ComboBox();
            lbBorder = new Label();
            pnGrid = new Panel();
            gridMatrix = new DataGridView();
            a1 = new DataGridViewTextBoxColumn();
            a2 = new DataGridViewTextBoxColumn();
            a3 = new DataGridViewTextBoxColumn();
            pnArguments.SuspendLayout();
            pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMatrix).BeginInit();
            SuspendLayout();
            // 
            // pnArguments
            // 
            pnArguments.Controls.Add(tbDelta);
            pnArguments.Controls.Add(lbDelta);
            pnArguments.Controls.Add(btRun);
            pnArguments.Controls.Add(cbBorder);
            pnArguments.Controls.Add(lbBorder);
            pnArguments.Dock = DockStyle.Top;
            pnArguments.Location = new Point(0, 0);
            pnArguments.Name = "pnArguments";
            pnArguments.Size = new Size(800, 77);
            pnArguments.TabIndex = 0;
            // 
            // tbDelta
            // 
            tbDelta.Location = new Point(327, 18);
            tbDelta.Name = "tbDelta";
            tbDelta.Size = new Size(125, 27);
            tbDelta.TabIndex = 4;
            // 
            // lbDelta
            // 
            lbDelta.AutoSize = true;
            lbDelta.Location = new Point(269, 20);
            lbDelta.Name = "lbDelta";
            lbDelta.Size = new Size(52, 20);
            lbDelta.TabIndex = 3;
            lbDelta.Text = "Delta :";
            // 
            // btRun
            // 
            btRun.Location = new Point(694, 20);
            btRun.Name = "btRun";
            btRun.Size = new Size(94, 29);
            btRun.TabIndex = 2;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            // 
            // cbBorder
            // 
            cbBorder.FormattingEnabled = true;
            cbBorder.Location = new Point(112, 17);
            cbBorder.Name = "cbBorder";
            cbBorder.Size = new Size(151, 28);
            cbBorder.TabIndex = 1;
            // 
            // lbBorder
            // 
            lbBorder.AutoSize = true;
            lbBorder.Location = new Point(12, 20);
            lbBorder.Name = "lbBorder";
            lbBorder.Size = new Size(94, 20);
            lbBorder.TabIndex = 0;
            lbBorder.Text = "Border type :";
            // 
            // pnGrid
            // 
            pnGrid.Controls.Add(gridMatrix);
            pnGrid.Dock = DockStyle.Fill;
            pnGrid.Location = new Point(0, 77);
            pnGrid.Name = "pnGrid";
            pnGrid.Size = new Size(800, 373);
            pnGrid.TabIndex = 1;
            // 
            // gridMatrix
            // 
            gridMatrix.AllowUserToAddRows = false;
            gridMatrix.AllowUserToDeleteRows = false;
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
            gridMatrix.Location = new Point(0, 0);
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
            gridMatrix.Size = new Size(800, 373);
            gridMatrix.TabIndex = 0;
            gridMatrix.CellValidating += gridMatrix_CellValidating;
            gridMatrix.EditingControlShowing += gridMatrix_EditingControlShowing;
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
            // UniversalFilterWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnGrid);
            Controls.Add(pnArguments);
            Name = "UniversalFilterWindow";
            Text = "UniversalFilter";
            pnArguments.ResumeLayout(false);
            pnArguments.PerformLayout();
            pnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnArguments;
        private Label lbBorder;
        private Panel pnGrid;
        private DataGridView gridMatrix;
        private DataGridViewTextBoxColumn a1;
        private DataGridViewTextBoxColumn a2;
        private DataGridViewTextBoxColumn a3;
        private Button btRun;
        private ComboBox cbBorder;
        private TextBox tbDelta;
        private Label lbDelta;
    }
}