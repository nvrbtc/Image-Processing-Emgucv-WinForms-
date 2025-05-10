namespace Apo
{
    partial class MainUI
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            thresholdToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectionToolStripMenuItem = new ToolStripMenuItem();
            negationToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem1 = new ToolStripMenuItem();
            testingToolStripMenuItem = new ToolStripMenuItem();
            analyzeToolStripMenuItem = new ToolStripMenuItem();
            profileLineToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            equalizationToolStripMenuItem = new ToolStripMenuItem();
            linearToolStripMenuItem = new ToolStripMenuItem();
            blurToolStripMenuItem1 = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            medianFilterToolStripMenuItem1 = new ToolStripMenuItem();
            universalFilterToolStripMenuItem1 = new ToolStripMenuItem();
            morphologyToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            skeletonizationToolStripMenuItem = new ToolStripMenuItem();
            houghMethodsToolStripMenuItem = new ToolStripMenuItem();
            tabControl = new TabControl();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            appMenu.SuspendLayout();
            SuspendLayout();
            // 
            // appMenu
            // 
            appMenu.ImageScalingSize = new Size(20, 20);
            appMenu.Items.AddRange(new ToolStripItem[] { File, imageToolStripMenuItem, analyzeToolStripMenuItem, blurToolStripMenuItem1, filterToolStripMenuItem, morphologyToolStripMenuItem, houghMethodsToolStripMenuItem });
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
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { duplicateToolStripMenuItem, typeToolStripMenuItem, thresholdToolStripMenuItem, edgeDetectionToolStripMenuItem, negationToolStripMenuItem, testToolStripMenuItem1, testingToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(65, 24);
            imageToolStripMenuItem.Text = "Image";
            // 
            // duplicateToolStripMenuItem
            // 
            duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            duplicateToolStripMenuItem.Size = new Size(193, 26);
            duplicateToolStripMenuItem.Text = "Duplicate";
            duplicateToolStripMenuItem.Click += DuplicateImageTab;
            // 
            // typeToolStripMenuItem
            // 
            typeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayToolStripMenuItem, colorToolStripMenuItem, hSVToolStripMenuItem, lABToolStripMenuItem });
            typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            typeToolStripMenuItem.Size = new Size(193, 26);
            typeToolStripMenuItem.Text = "Update Type";
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
            colorToolStripMenuItem.Click += FromTypeToRgb;
            // 
            // hSVToolStripMenuItem
            // 
            hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            hSVToolStripMenuItem.Size = new Size(122, 26);
            hSVToolStripMenuItem.Text = "HSV";
            hSVToolStripMenuItem.Click += FromTypeToHsv;
            // 
            // lABToolStripMenuItem
            // 
            lABToolStripMenuItem.Name = "lABToolStripMenuItem";
            lABToolStripMenuItem.Size = new Size(122, 26);
            lABToolStripMenuItem.Text = "Lab";
            lABToolStripMenuItem.Click += FromTypeToLab;
            // 
            // thresholdToolStripMenuItem
            // 
            thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            thresholdToolStripMenuItem.Size = new Size(193, 26);
            thresholdToolStripMenuItem.Text = "Posterization";
            thresholdToolStripMenuItem.Click += OpenPosterizationWindow;
            // 
            // edgeDetectionToolStripMenuItem
            // 
            edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            edgeDetectionToolStripMenuItem.Size = new Size(193, 26);
            edgeDetectionToolStripMenuItem.Text = "Edge detection";
            edgeDetectionToolStripMenuItem.Click += OpenEdgeDetectionWindow;
            // 
            // negationToolStripMenuItem
            // 
            negationToolStripMenuItem.Name = "negationToolStripMenuItem";
            negationToolStripMenuItem.Size = new Size(193, 26);
            negationToolStripMenuItem.Text = "Negation";
            negationToolStripMenuItem.Click += ApplyNegation;
            // 
            // testToolStripMenuItem1
            // 
            testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            testToolStripMenuItem1.Size = new Size(193, 26);
            testToolStripMenuItem1.Text = "Treshold";
            testToolStripMenuItem1.Click += ApplyTemp;
            // 
            // testingToolStripMenuItem
            // 
            testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            testingToolStripMenuItem.Size = new Size(193, 26);
            testingToolStripMenuItem.Text = "Testing";
            testingToolStripMenuItem.Click += TestNew;
            // 
            // analyzeToolStripMenuItem
            // 
            analyzeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profileLineToolStripMenuItem, histogramToolStripMenuItem });
            analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            analyzeToolStripMenuItem.Size = new Size(75, 24);
            analyzeToolStripMenuItem.Text = "Analyze";
            // 
            // profileLineToolStripMenuItem
            // 
            profileLineToolStripMenuItem.Name = "profileLineToolStripMenuItem";
            profileLineToolStripMenuItem.Size = new Size(166, 26);
            profileLineToolStripMenuItem.Text = "Profile Line";
            profileLineToolStripMenuItem.Click += OpenProfileLineWindow;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { equalizationToolStripMenuItem, linearToolStripMenuItem });
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(166, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += OpenHistogramWindow;
            // 
            // equalizationToolStripMenuItem
            // 
            equalizationToolStripMenuItem.Name = "equalizationToolStripMenuItem";
            equalizationToolStripMenuItem.Size = new Size(277, 26);
            equalizationToolStripMenuItem.Text = "Equalization";
            equalizationToolStripMenuItem.Click += ApplyEqualizationAsync;
            // 
            // linearToolStripMenuItem
            // 
            linearToolStripMenuItem.Name = "linearToolStripMenuItem";
            linearToolStripMenuItem.Size = new Size(277, 26);
            linearToolStripMenuItem.Text = "Linear Histogram Stretching";
            linearToolStripMenuItem.Click += ApplyLinearStretching;
            // 
            // blurToolStripMenuItem1
            // 
            blurToolStripMenuItem1.Name = "blurToolStripMenuItem1";
            blurToolStripMenuItem1.Size = new Size(49, 24);
            blurToolStripMenuItem1.Text = "Blur";
            blurToolStripMenuItem1.Click += OpenBlurWindow;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medianFilterToolStripMenuItem1, universalFilterToolStripMenuItem1 });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(56, 24);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // medianFilterToolStripMenuItem1
            // 
            medianFilterToolStripMenuItem1.Name = "medianFilterToolStripMenuItem1";
            medianFilterToolStripMenuItem1.Size = new Size(189, 26);
            medianFilterToolStripMenuItem1.Text = "Median Filter";
            medianFilterToolStripMenuItem1.Click += OpenMedianFilterWindow;
            // 
            // universalFilterToolStripMenuItem1
            // 
            universalFilterToolStripMenuItem1.Name = "universalFilterToolStripMenuItem1";
            universalFilterToolStripMenuItem1.Size = new Size(189, 26);
            universalFilterToolStripMenuItem1.Text = "Universal Filter";
            universalFilterToolStripMenuItem1.Click += OpenUniversalFilterWindow;
            // 
            // morphologyToolStripMenuItem
            // 
            morphologyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { operationsToolStripMenuItem, skeletonizationToolStripMenuItem });
            morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            morphologyToolStripMenuItem.Size = new Size(105, 24);
            morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(194, 26);
            operationsToolStripMenuItem.Text = "Operations";
            operationsToolStripMenuItem.Click += OpenMorphologyWindow;
            // 
            // skeletonizationToolStripMenuItem
            // 
            skeletonizationToolStripMenuItem.Name = "skeletonizationToolStripMenuItem";
            skeletonizationToolStripMenuItem.Size = new Size(194, 26);
            skeletonizationToolStripMenuItem.Text = "Skeletonization";
            skeletonizationToolStripMenuItem.Click += ApplySkeletonization;
            // 
            // houghMethodsToolStripMenuItem
            // 
            houghMethodsToolStripMenuItem.Name = "houghMethodsToolStripMenuItem";
            houghMethodsToolStripMenuItem.Size = new Size(130, 24);
            houghMethodsToolStripMenuItem.Text = "Hough Methods";
            houghMethodsToolStripMenuItem.Click += houghMethodsToolStripMenuItem_Click;
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(32, 19);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(32, 19);
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Controls.Add(appMenu);
            MainMenuStrip = appMenu;
            Name = "MainUI";
            Text = "Tsarehradskiy";
            appMenu.ResumeLayout(false);
            appMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        #endregion

        private MenuStrip appMenu;
        private ToolStripMenuItem File;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TabControl tabControl;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem typeToolStripMenuItem;
        private ToolStripMenuItem grayToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizationToolStripMenuItem;
        private ToolStripMenuItem thresholdToolStripMenuItem;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private ToolStripMenuItem negationToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem1;
        private ToolStripMenuItem grayToolStripMenuItem1;
        private ToolStripMenuItem bGRToolStripMenuItem;
        private ToolStripMenuItem hSVToolStripMenuItem;
        private ToolStripMenuItem lABToolStripMenuItem;
        private ToolStripMenuItem testingToolStripMenuItem;
        private ToolStripMenuItem blurToolStripMenuItem1;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem medianFilterToolStripMenuItem1;
        private ToolStripMenuItem universalFilterToolStripMenuItem1;
        private ToolStripMenuItem morphologyToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem skeletonizationToolStripMenuItem;
        private ToolStripMenuItem houghMethodsToolStripMenuItem;
        private ToolStripMenuItem profileLineToolStripMenuItem;
    }
}
