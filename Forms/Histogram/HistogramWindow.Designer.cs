using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Apo.customUI
{
    partial class HistogramWindow
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
            histSeries = new Series("Histogram")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Black,
            };
            distSeries = new Series("Distribution")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Red
            };
            distSeries.YAxisType = AxisType.Secondary;
            histArea = new ChartArea("Histogram");
            histPn = new Panel();
            tabMain = new TabControl();
            tabHist = new TabPage();
            chartImg = new Chart();
            tabTable = new TabPage();
            dataGrid = new DataGridView();
            value = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            histPn.SuspendLayout();
            tabMain.SuspendLayout();
            tabHist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartImg).BeginInit();
            tabTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // histPn
            // 
            histPn.BackColor = SystemColors.ActiveCaption;
            histPn.Controls.Add(tabMain);
            histPn.Dock = DockStyle.Fill;
            histPn.Location = new Point(0, 0);
            histPn.Name = "histPn";
            histPn.Size = new Size(838, 576);
            histPn.TabIndex = 0;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabHist);
            tabMain.Controls.Add(tabTable);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(838, 576);
            tabMain.TabIndex = 1;
            // 
            // tabHist
            // 
            tabHist.Controls.Add(chartImg);
            tabHist.Location = new Point(4, 29);
            tabHist.Name = "tabHist";
            tabHist.Padding = new Padding(3);
            tabHist.Size = new Size(830, 543);
            tabHist.TabIndex = 0;
            tabHist.Text = "Histogram";
            tabHist.UseVisualStyleBackColor = true;
            // 
            // chartImg
            // ;
            chartImg.Dock = DockStyle.Fill;
            chartImg.Location = new Point(3, 3);
            chartImg.Name = "chartImg";
            chartImg.Size = new Size(824, 537);
            chartImg.TabIndex = 0;
            chartImg.Text = "Img";
            chartImg.ChartAreas.Add(histArea);
            
            histArea.AxisX.Minimum = 0;
            histArea.AxisX.Maximum = 255;
            histArea.AxisY2.Enabled = AxisEnabled.True;
            chartImg.Series.Add(distSeries);
            chartImg.Series.Add(histSeries);
            // 
            // tabTable
            // 
            tabTable.Controls.Add(dataGrid);
            tabTable.Location = new Point(4, 29);
            tabTable.Name = "tabTable";
            tabTable.Padding = new Padding(3);
            tabTable.Size = new Size(830, 543);
            tabTable.TabIndex = 1;
            tabTable.Text = "Table";
            tabTable.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dataGrid.Columns.AddRange(new DataGridViewColumn[] { value, Count });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(3, 3);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(824, 537);
            dataGrid.TabIndex = 0;
            
            dataGrid.Columns.Add("Value", "Value");
            dataGrid.Columns.Add("Count", "Count");
            // 
            // value
            // 
            value.HeaderText = "Value";
            value.MinimumWidth = 6;
            value.Name = "value";
            value.ReadOnly = true;
            // 
            // Count
            // 
            Count.HeaderText = "Count";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.ReadOnly = true;
            // 
            // ImageHist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(838, 576);
            Controls.Add(histPn);
            Name = "ImageHist";
            Text = "ImageHist";
            histPn.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabHist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartImg).EndInit();
            tabTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel histPn;
        private Chart chartImg;
        private TabControl tabMain;
        private TabPage tabHist;
        private TabPage tabTable;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn value;
        private DataGridViewTextBoxColumn Count;
        private Series distSeries;
        private Series histSeries;
        private ChartArea histArea;
    }
}