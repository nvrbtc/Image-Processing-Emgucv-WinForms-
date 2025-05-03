namespace APO_Tsarehradskiy.customUI
{
    partial class SharpWindow
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
            pnInput = new Panel();
            cbBorder = new ComboBox();
            lbBorder = new Label();
            btRun = new Button();
            cbOptions = new ComboBox();
            lbOption = new Label();
            pnData = new Panel();
            gridMatrix = new DataGridView();
            a1 = new DataGridViewTextBoxColumn();
            a2 = new DataGridViewTextBoxColumn();
            a3 = new DataGridViewTextBoxColumn();
            pnInput.SuspendLayout();
            pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMatrix).BeginInit();
            SuspendLayout();
            // 
            // pnInput
            // 
            pnInput.Controls.Add(cbBorder);
            pnInput.Controls.Add(lbBorder);
            pnInput.Controls.Add(btRun);
            pnInput.Controls.Add(cbOptions);
            pnInput.Controls.Add(lbOption);
            pnInput.Dock = DockStyle.Top;
            pnInput.Location = new Point(0, 0);
            pnInput.Name = "pnInput";
            pnInput.Size = new Size(682, 72);
            pnInput.TabIndex = 0;
            // 
            // cbBorder
            // 
            cbBorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBorder.FormattingEnabled = true;
            cbBorder.Location = new Point(337, 24);
            cbBorder.Name = "cbBorder";
            cbBorder.Size = new Size(151, 28);
            cbBorder.TabIndex = 4;
            // 
            // lbBorder
            // 
            lbBorder.AutoSize = true;
            lbBorder.Location = new Point(237, 27);
            lbBorder.Name = "lbBorder";
            lbBorder.Size = new Size(94, 20);
            lbBorder.TabIndex = 3;
            lbBorder.Text = "Border type :";
            // 
            // btRun
            // 
            btRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btRun.Location = new Point(576, 22);
            btRun.Name = "btRun";
            btRun.Size = new Size(94, 29);
            btRun.TabIndex = 2;
            btRun.Text = "Run";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += RunStrategy;
            // 
            // cbOptions
            // 
            cbOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOptions.FormattingEnabled = true;
            cbOptions.Location = new Point(80, 23);
            cbOptions.Name = "cbOptions";
            cbOptions.Size = new Size(151, 28);
            cbOptions.TabIndex = 1;
            // 
            // lbOption
            // 
            lbOption.AutoSize = true;
            lbOption.Location = new Point(12, 27);
            lbOption.Name = "lbOption";
            lbOption.Size = new Size(62, 20);
            lbOption.TabIndex = 0;
            lbOption.Text = "Option :";
            // 
            // pnData
            // 
            pnData.AutoSize = true;
            pnData.Controls.Add(gridMatrix);
            pnData.Dock = DockStyle.Fill;
            pnData.Location = new Point(0, 72);
            pnData.Name = "pnData";
            pnData.Size = new Size(682, 141);
            pnData.TabIndex = 1;
            // 
            // gridMatrix
            // 
            gridMatrix.AllowUserToAddRows = false;
            gridMatrix.AllowUserToDeleteRows = false;
            gridMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMatrix.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            gridMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMatrix.Columns.AddRange(new DataGridViewColumn[] { a1, a2, a3 });
            gridMatrix.Dock = DockStyle.Fill;
            gridMatrix.Location = new Point(0, 0);
            gridMatrix.Name = "gridMatrix";
            gridMatrix.ReadOnly = true;
            gridMatrix.RowHeadersWidth = 51;
            gridMatrix.Size = new Size(682, 141);
            gridMatrix.TabIndex = 0;
            // 
            // a1
            // 
            a1.HeaderText = "a1";
            a1.MinimumWidth = 6;
            a1.Name = "a1";
            a1.ReadOnly = true;
            // 
            // a2
            // 
            a2.HeaderText = "a2";
            a2.MinimumWidth = 6;
            a2.Name = "a2";
            a2.ReadOnly = true;
            // 
            // a3
            // 
            a3.HeaderText = "3";
            a3.MinimumWidth = 6;
            a3.Name = "a3";
            a3.ReadOnly = true;
            // 
            // SharpWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(682, 213);
            Controls.Add(pnData);
            Controls.Add(pnInput);
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(385, 260);
            Name = "SharpWindow";
            Text = "SharpWindow";
            pnInput.ResumeLayout(false);
            pnInput.PerformLayout();
            pnData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnInput;
        private Button btRun;
        private ComboBox cbOptions;
        private Label lbOption;
        private Panel pnData;
        private DataGridView gridMatrix;
        private DataGridViewTextBoxColumn a1;
        private DataGridViewTextBoxColumn a2;
        private DataGridViewTextBoxColumn a3;
        private ComboBox cbBorder;
        private Label lbBorder;
    }
}