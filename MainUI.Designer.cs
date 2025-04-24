namespace APO_Tsarehradskiy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            appMenu = new MenuStrip();
            File = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            grayToolStripMenuItem1 = new ToolStripMenuItem();
            bGRToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            duplicateToolStripMenuItem = new ToolStripMenuItem();
            typeToolStripMenuItem = new ToolStripMenuItem();
            grayToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            hSVToolStripMenuItem = new ToolStripMenuItem();
            lABToolStripMenuItem = new ToolStripMenuItem();
            tresholdToolStripMenuItem = new ToolStripMenuItem();
            blurToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectionToolStripMenuItem = new ToolStripMenuItem();
            negationToolStripMenuItem = new ToolStripMenuItem();
            tresholdToolStripMenuItem1 = new ToolStripMenuItem();
            medianFilterToolStripMenuItem = new ToolStripMenuItem();
            testingToolStripMenuItem = new ToolStripMenuItem();
            analyzeToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            linierToolStripMenuItem = new ToolStripMenuItem();
            equalizationToolStripMenuItem = new ToolStripMenuItem();
            tabControl = new TabControl();
            universalFilterToolStripMenuItem = new ToolStripMenuItem();
            appMenu.SuspendLayout();
            SuspendLayout();
            // 
            // appMenu
            // 
            appMenu.ImageScalingSize = new Size(20, 20);
            appMenu.Items.AddRange(new ToolStripItem[] { File, imageToolStripMenuItem, analyzeToolStripMenuItem });
            appMenu.Location = new Point(0, 0);
            appMenu.Name = "appMenu";
            appMenu.RenderMode = ToolStripRenderMode.System;
            appMenu.Size = new Size(800, 28);
            appMenu.TabIndex = 0;
            appMenu.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            File.Name = "File";
            File.Size = new Size(46, 24);
            File.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayToolStripMenuItem1, bGRToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // grayToolStripMenuItem1
            // 
            grayToolStripMenuItem1.Name = "grayToolStripMenuItem1";
            grayToolStripMenuItem1.Size = new Size(122, 26);
            grayToolStripMenuItem1.Text = "Gray";
            grayToolStripMenuItem1.Click += OpenGrayscaleImage;
            // 
            // bGRToolStripMenuItem
            // 
            bGRToolStripMenuItem.Name = "bGRToolStripMenuItem";
            bGRToolStripMenuItem.Size = new Size(122, 26);
            bGRToolStripMenuItem.Text = "RGB";
            bGRToolStripMenuItem.Click += OpenRgbImage;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveImage;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { duplicateToolStripMenuItem, typeToolStripMenuItem, tresholdToolStripMenuItem, blurToolStripMenuItem, edgeDetectionToolStripMenuItem, negationToolStripMenuItem, tresholdToolStripMenuItem1, medianFilterToolStripMenuItem, testingToolStripMenuItem, universalFilterToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(65, 24);
            imageToolStripMenuItem.Text = "Image";
            // 
            // duplicateToolStripMenuItem
            // 
            duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            duplicateToolStripMenuItem.Size = new Size(224, 26);
            duplicateToolStripMenuItem.Text = "Duplicate";
            duplicateToolStripMenuItem.Click += DuplicateImageTab;
            // 
            // typeToolStripMenuItem
            // 
            typeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayToolStripMenuItem, colorToolStripMenuItem, hSVToolStripMenuItem, lABToolStripMenuItem });
            typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            typeToolStripMenuItem.Size = new Size(224, 26);
            typeToolStripMenuItem.Text = "Type";
            // 
            // grayToolStripMenuItem
            // 
            grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            grayToolStripMenuItem.Size = new Size(122, 26);
            grayToolStripMenuItem.Text = "Gray";
            grayToolStripMenuItem.Click += FromTypeToGrayscale;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(122, 26);
            colorToolStripMenuItem.Text = "RGB";
            colorToolStripMenuItem.Click += FromTypeToRGB;
            // 
            // hSVToolStripMenuItem
            // 
            hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            hSVToolStripMenuItem.Size = new Size(122, 26);
            hSVToolStripMenuItem.Text = "HSV";
            hSVToolStripMenuItem.Click += FromTypeToHSV;
            // 
            // lABToolStripMenuItem
            // 
            lABToolStripMenuItem.Name = "lABToolStripMenuItem";
            lABToolStripMenuItem.Size = new Size(122, 26);
            lABToolStripMenuItem.Text = "Lab";
            lABToolStripMenuItem.Click += FromTypeToLab;
            // 
            // tresholdToolStripMenuItem
            // 
            tresholdToolStripMenuItem.Name = "tresholdToolStripMenuItem";
            tresholdToolStripMenuItem.Size = new Size(224, 26);
            tresholdToolStripMenuItem.Text = "Posterization";
            tresholdToolStripMenuItem.Click += OpenPosterizationWindow;
            // 
            // blurToolStripMenuItem
            // 
            blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            blurToolStripMenuItem.Size = new Size(224, 26);
            blurToolStripMenuItem.Text = "Blur";
            blurToolStripMenuItem.Click += OpenBlurWindow;
            // 
            // edgeDetectionToolStripMenuItem
            // 
            edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            edgeDetectionToolStripMenuItem.Size = new Size(224, 26);
            edgeDetectionToolStripMenuItem.Text = "Edge detection";
            edgeDetectionToolStripMenuItem.Click += OpenEdgeDetectionWindow;
            // 
            // negationToolStripMenuItem
            // 
            negationToolStripMenuItem.Name = "negationToolStripMenuItem";
            negationToolStripMenuItem.Size = new Size(224, 26);
            negationToolStripMenuItem.Text = "Negation";
            negationToolStripMenuItem.Click += ApplyNegation;
            // 
            // tresholdToolStripMenuItem1
            // 
            tresholdToolStripMenuItem1.Name = "tresholdToolStripMenuItem1";
            tresholdToolStripMenuItem1.Size = new Size(224, 26);
            tresholdToolStripMenuItem1.Text = "Treshold";
            tresholdToolStripMenuItem1.Click += ApplyTemp;
            // 
            // medianFilterToolStripMenuItem
            // 
            medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            medianFilterToolStripMenuItem.Size = new Size(224, 26);
            medianFilterToolStripMenuItem.Text = "Median Filter";
            medianFilterToolStripMenuItem.Click += medianFilterToolStripMenuItem_Click;
            // 
            // testingToolStripMenuItem
            // 
            testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            testingToolStripMenuItem.Size = new Size(224, 26);
            testingToolStripMenuItem.Text = "Testing";
            testingToolStripMenuItem.Click += TestNew;
            // 
            // analyzeToolStripMenuItem
            // 
            analyzeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { histogramToolStripMenuItem });
            analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            analyzeToolStripMenuItem.Size = new Size(75, 24);
            analyzeToolStripMenuItem.Text = "Analyze";
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { linierToolStripMenuItem, equalizationToolStripMenuItem });
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(162, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += OpenHistogramWindow;
            // 
            // linierToolStripMenuItem
            // 
            linierToolStripMenuItem.Name = "linierToolStripMenuItem";
            linierToolStripMenuItem.Size = new Size(277, 26);
            linierToolStripMenuItem.Text = "Linear Histogram Stretching";
            linierToolStripMenuItem.Click += ApplyLinearStretching;
            // 
            // equalizationToolStripMenuItem
            // 
            equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            equalizationToolStripMenuItem.Size = new Size(277, 26);
            equalizationToolStripMenuItem.Text = "Equalization";
            equalizationToolStripMenuItem.Click += ApplyEqualization;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.Buttons;
            tabControl.Cursor = Cursors.Hand;
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 28);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 422);
            tabControl.TabIndex = 1;
            // 
            // universalFilterToolStripMenuItem
            // 
            universalFilterToolStripMenuItem.Name = "universalFilterToolStripMenuItem";
            universalFilterToolStripMenuItem.Size = new Size(224, 26);
            universalFilterToolStripMenuItem.Text = "Universal Filter";
            universalFilterToolStripMenuItem.Click += universalFilterToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Controls.Add(appMenu);
            MainMenuStrip = appMenu;
            Name = "MainForm";
            Text = "Tsarehradskiy";
            appMenu.ResumeLayout(false);
            appMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip appMenu;
        private ToolStripMenuItem File;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TabControl tabControl;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem analyzeToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem typeToolStripMenuItem;
        private ToolStripMenuItem grayToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem linierToolStripMenuItem;
        private ToolStripMenuItem equalizationToolStripMenuItem;
        private ToolStripMenuItem tresholdToolStripMenuItem;
        private ToolStripMenuItem blurToolStripMenuItem;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private ToolStripMenuItem negationToolStripMenuItem;
        private ToolStripMenuItem tresholdToolStripMenuItem1;
        private ToolStripMenuItem medianFilterToolStripMenuItem;
        private ToolStripMenuItem grayToolStripMenuItem1;
        private ToolStripMenuItem bGRToolStripMenuItem;
        private ToolStripMenuItem hSVToolStripMenuItem;
        private ToolStripMenuItem lABToolStripMenuItem;
        private ToolStripMenuItem testingToolStripMenuItem;
        private ToolStripMenuItem universalFilterToolStripMenuItem;
    }
}
