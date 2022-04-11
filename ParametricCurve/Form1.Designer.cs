namespace ParametricCurve
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samplePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSamplePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSamplePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCubicPolynomialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCubicPolynomialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.useAllPointsAsSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTargetPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTargetPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveBSplineDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.buttonMoveGraph = new System.Windows.Forms.Button();
            this.buttonYScale = new System.Windows.Forms.Button();
            this.buttonXScale = new System.Windows.Forms.Button();
            this.textBoxYScale = new System.Windows.Forms.TextBox();
            this.textBoxXScale = new System.Windows.Forms.TextBox();
            this.labelYScale = new System.Windows.Forms.Label();
            this.labelXScale = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxU = new System.Windows.Forms.TextBox();
            this.textBoxFu = new System.Windows.Forms.TextBox();
            this.listBoxPoints = new ParametricCurve.ListBoxRich();
            this.textBoxCubicX = new System.Windows.Forms.TextBox();
            this.buttonDrawCubic = new System.Windows.Forms.Button();
            this.textBoxSE = new System.Windows.Forms.TextBox();
            this.buttonSetCubic = new System.Windows.Forms.Button();
            this.labelSE = new System.Windows.Forms.Label();
            this.labelCubic = new System.Windows.Forms.Label();
            this.textBoxExprCubicX = new System.Windows.Forms.TextBox();
            this.textBoxExprCubicY = new System.Windows.Forms.TextBox();
            this.buttonSelectBs = new System.Windows.Forms.Button();
            this.labelSE2 = new System.Windows.Forms.Label();
            this.textBoxSE2 = new System.Windows.Forms.TextBox();
            this.buttonDrawBs = new System.Windows.Forms.Button();
            this.buttonPlotCurve = new System.Windows.Forms.Button();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.panelExprX = new System.Windows.Forms.Panel();
            this.panelExprY = new System.Windows.Forms.Panel();
            this.groupBoxPoints = new System.Windows.Forms.GroupBox();
            this.buttonAddPoint = new System.Windows.Forms.Button();
            this.labelFu = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.buttonClearGraph = new System.Windows.Forms.Button();
            this.groupBoxExpr = new System.Windows.Forms.GroupBox();
            this.groupBoxBspline = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.panelExprX.SuspendLayout();
            this.panelExprY.SuspendLayout();
            this.groupBoxPoints.SuspendLayout();
            this.groupBoxExpr.SuspendLayout();
            this.groupBoxBspline.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1112, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.samplePointsToolStripMenuItem,
            this.bSplineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // samplePointsToolStripMenuItem
            // 
            this.samplePointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSamplePointsToolStripMenuItem,
            this.loadSamplePointsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveCubicPolynomialsToolStripMenuItem,
            this.loadCubicPolynomialsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.useAllPointsAsSampleToolStripMenuItem});
            this.samplePointsToolStripMenuItem.Name = "samplePointsToolStripMenuItem";
            this.samplePointsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.samplePointsToolStripMenuItem.Text = "Sample Points";
            // 
            // saveSamplePointsToolStripMenuItem
            // 
            this.saveSamplePointsToolStripMenuItem.Name = "saveSamplePointsToolStripMenuItem";
            this.saveSamplePointsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveSamplePointsToolStripMenuItem.Text = "Save Sample Points";
            this.saveSamplePointsToolStripMenuItem.Click += new System.EventHandler(this.saveSamplePointsToolStripMenuItem_Click);
            // 
            // loadSamplePointsToolStripMenuItem
            // 
            this.loadSamplePointsToolStripMenuItem.Name = "loadSamplePointsToolStripMenuItem";
            this.loadSamplePointsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.loadSamplePointsToolStripMenuItem.Text = "Load Sample Points";
            this.loadSamplePointsToolStripMenuItem.Click += new System.EventHandler(this.loadSamplePointsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // saveCubicPolynomialsToolStripMenuItem
            // 
            this.saveCubicPolynomialsToolStripMenuItem.Name = "saveCubicPolynomialsToolStripMenuItem";
            this.saveCubicPolynomialsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveCubicPolynomialsToolStripMenuItem.Text = "Save Cubic Polynomials";
            this.saveCubicPolynomialsToolStripMenuItem.Click += new System.EventHandler(this.saveCubicPolynomialsToolStripMenuItem_Click);
            // 
            // loadCubicPolynomialsToolStripMenuItem
            // 
            this.loadCubicPolynomialsToolStripMenuItem.Name = "loadCubicPolynomialsToolStripMenuItem";
            this.loadCubicPolynomialsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.loadCubicPolynomialsToolStripMenuItem.Text = "Load Cubic Polynomials";
            this.loadCubicPolynomialsToolStripMenuItem.Click += new System.EventHandler(this.loadCubicPolynomialsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // useAllPointsAsSampleToolStripMenuItem
            // 
            this.useAllPointsAsSampleToolStripMenuItem.Name = "useAllPointsAsSampleToolStripMenuItem";
            this.useAllPointsAsSampleToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.useAllPointsAsSampleToolStripMenuItem.Text = "Use All Points as Sample";
            this.useAllPointsAsSampleToolStripMenuItem.Click += new System.EventHandler(this.useAllPointsAsSampleToolStripMenuItem_Click);
            // 
            // bSplineToolStripMenuItem
            // 
            this.bSplineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTargetPointsToolStripMenuItem,
            this.loadTargetPointsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveBSplineDataToolStripMenuItem});
            this.bSplineToolStripMenuItem.Name = "bSplineToolStripMenuItem";
            this.bSplineToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bSplineToolStripMenuItem.Text = "B-Spline";
            // 
            // saveTargetPointsToolStripMenuItem
            // 
            this.saveTargetPointsToolStripMenuItem.Name = "saveTargetPointsToolStripMenuItem";
            this.saveTargetPointsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveTargetPointsToolStripMenuItem.Text = "Save Target Points";
            this.saveTargetPointsToolStripMenuItem.Click += new System.EventHandler(this.saveTargetPointsToolStripMenuItem_Click);
            // 
            // loadTargetPointsToolStripMenuItem
            // 
            this.loadTargetPointsToolStripMenuItem.Name = "loadTargetPointsToolStripMenuItem";
            this.loadTargetPointsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadTargetPointsToolStripMenuItem.Text = "Load Target Points";
            this.loadTargetPointsToolStripMenuItem.Click += new System.EventHandler(this.loadTargetPointsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(169, 6);
            // 
            // saveBSplineDataToolStripMenuItem
            // 
            this.saveBSplineDataToolStripMenuItem.Name = "saveBSplineDataToolStripMenuItem";
            this.saveBSplineDataToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveBSplineDataToolStripMenuItem.Text = "Save B-Spline Data";
            this.saveBSplineDataToolStripMenuItem.Click += new System.EventHandler(this.saveBSplineDataToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panelLegend);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 486);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // panelLegend
            // 
            this.panelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLegend.Controls.Add(this.buttonMoveGraph);
            this.panelLegend.Controls.Add(this.buttonYScale);
            this.panelLegend.Controls.Add(this.buttonXScale);
            this.panelLegend.Controls.Add(this.textBoxYScale);
            this.panelLegend.Controls.Add(this.textBoxXScale);
            this.panelLegend.Controls.Add(this.labelYScale);
            this.panelLegend.Controls.Add(this.labelXScale);
            this.panelLegend.Location = new System.Drawing.Point(466, -1);
            this.panelLegend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(257, 34);
            this.panelLegend.TabIndex = 0;
            // 
            // buttonMoveGraph
            // 
            this.buttonMoveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveGraph.BackgroundImage = global::ParametricCurve.Properties.Resources.Hand;
            this.buttonMoveGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMoveGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMoveGraph.Location = new System.Drawing.Point(7, 4);
            this.buttonMoveGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMoveGraph.Name = "buttonMoveGraph";
            this.buttonMoveGraph.Size = new System.Drawing.Size(26, 22);
            this.buttonMoveGraph.TabIndex = 17;
            this.toolTip1.SetToolTip(this.buttonMoveGraph, "Move graph");
            this.buttonMoveGraph.UseVisualStyleBackColor = true;
            this.buttonMoveGraph.Click += new System.EventHandler(this.buttonMoveGraph_Click);
            // 
            // buttonYScale
            // 
            this.buttonYScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonYScale.BackgroundImage = global::ParametricCurve.Properties.Resources.ResizeY;
            this.buttonYScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonYScale.Location = new System.Drawing.Point(70, 4);
            this.buttonYScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonYScale.Name = "buttonYScale";
            this.buttonYScale.Size = new System.Drawing.Size(26, 22);
            this.buttonYScale.TabIndex = 16;
            this.toolTip1.SetToolTip(this.buttonYScale, "Zoom on Y-Axis");
            this.buttonYScale.UseVisualStyleBackColor = true;
            this.buttonYScale.Click += new System.EventHandler(this.buttonYScale_Click);
            // 
            // buttonXScale
            // 
            this.buttonXScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXScale.BackgroundImage = global::ParametricCurve.Properties.Resources.ResizeX;
            this.buttonXScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonXScale.Location = new System.Drawing.Point(38, 4);
            this.buttonXScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXScale.Name = "buttonXScale";
            this.buttonXScale.Size = new System.Drawing.Size(26, 22);
            this.buttonXScale.TabIndex = 15;
            this.toolTip1.SetToolTip(this.buttonXScale, "Zoom on X-Axis");
            this.buttonXScale.UseVisualStyleBackColor = true;
            this.buttonXScale.Click += new System.EventHandler(this.buttonXScale_Click);
            // 
            // textBoxYScale
            // 
            this.textBoxYScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxYScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYScale.Location = new System.Drawing.Point(197, 6);
            this.textBoxYScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYScale.Name = "textBoxYScale";
            this.textBoxYScale.Size = new System.Drawing.Size(45, 23);
            this.textBoxYScale.TabIndex = 14;
            this.textBoxYScale.Text = "1";
            this.toolTip1.SetToolTip(this.textBoxYScale, "Y-Axis length 1 cover pixels");
            // 
            // textBoxXScale
            // 
            this.textBoxXScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxXScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxXScale.Location = new System.Drawing.Point(124, 6);
            this.textBoxXScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxXScale.Name = "textBoxXScale";
            this.textBoxXScale.Size = new System.Drawing.Size(45, 23);
            this.textBoxXScale.TabIndex = 13;
            this.textBoxXScale.Text = "1";
            this.toolTip1.SetToolTip(this.textBoxXScale, "X-Axis length 1 cover pixels");
            // 
            // labelYScale
            // 
            this.labelYScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYScale.AutoSize = true;
            this.labelYScale.Location = new System.Drawing.Point(177, 8);
            this.labelYScale.Name = "labelYScale";
            this.labelYScale.Size = new System.Drawing.Size(17, 15);
            this.labelYScale.TabIndex = 12;
            this.labelYScale.Text = "Y:";
            this.toolTip1.SetToolTip(this.labelYScale, "Y-Axis Scale");
            // 
            // labelXScale
            // 
            this.labelXScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelXScale.AutoSize = true;
            this.labelXScale.Location = new System.Drawing.Point(107, 8);
            this.labelXScale.Name = "labelXScale";
            this.labelXScale.Size = new System.Drawing.Size(17, 15);
            this.labelXScale.TabIndex = 12;
            this.labelXScale.Text = "X:";
            this.toolTip1.SetToolTip(this.labelXScale, "X-Axis Scale");
            // 
            // labelX
            // 
            this.labelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(4, 22);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(19, 15);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "H:";
            this.toolTip1.SetToolTip(this.labelX, "Horizontal-Axis expression");
            // 
            // labelY
            // 
            this.labelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(4, 55);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 15);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "V:";
            this.toolTip1.SetToolTip(this.labelY, "Vertical-Axis expression");
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(19, 21);
            this.textBoxU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(45, 23);
            this.textBoxU.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxU, "Value of u");
            this.textBoxU.TextChanged += new System.EventHandler(this.textBoxU_TextChanged);
            // 
            // textBoxFu
            // 
            this.textBoxFu.Location = new System.Drawing.Point(100, 20);
            this.textBoxFu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFu.Name = "textBoxFu";
            this.textBoxFu.Size = new System.Drawing.Size(45, 23);
            this.textBoxFu.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxFu, "Value of u");
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.ItemHeight = 15;
            this.listBoxPoints.Location = new System.Drawing.Point(990, 161);
            this.listBoxPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(110, 229);
            this.listBoxPoints.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listBoxPoints, "Double click to delete");
            this.listBoxPoints.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPoints_MouseDoubleClick);
            // 
            // textBoxCubicX
            // 
            this.textBoxCubicX.Location = new System.Drawing.Point(63, 51);
            this.textBoxCubicX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCubicX.Name = "textBoxCubicX";
            this.textBoxCubicX.ReadOnly = true;
            this.textBoxCubicX.Size = new System.Drawing.Size(180, 23);
            this.textBoxCubicX.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxCubicX, "c0 + c1*u + c2*u^2, c3*u^3");
            // 
            // buttonDrawCubic
            // 
            this.buttonDrawCubic.Location = new System.Drawing.Point(156, 81);
            this.buttonDrawCubic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawCubic.Name = "buttonDrawCubic";
            this.buttonDrawCubic.Size = new System.Drawing.Size(87, 21);
            this.buttonDrawCubic.TabIndex = 8;
            this.buttonDrawCubic.Text = "Draw Cubic";
            this.toolTip1.SetToolTip(this.buttonDrawCubic, "Fit a parametric cubic polynomial");
            this.buttonDrawCubic.UseVisualStyleBackColor = true;
            this.buttonDrawCubic.Click += new System.EventHandler(this.buttonDrawCubic_Click);
            // 
            // textBoxSE
            // 
            this.textBoxSE.Location = new System.Drawing.Point(63, 80);
            this.textBoxSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSE.Name = "textBoxSE";
            this.textBoxSE.ReadOnly = true;
            this.textBoxSE.Size = new System.Drawing.Size(52, 23);
            this.textBoxSE.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxSE, "Root Mean Squred Error of Sample Points");
            // 
            // buttonSetCubic
            // 
            this.buttonSetCubic.Location = new System.Drawing.Point(156, 108);
            this.buttonSetCubic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetCubic.Name = "buttonSetCubic";
            this.buttonSetCubic.Size = new System.Drawing.Size(87, 21);
            this.buttonSetCubic.TabIndex = 13;
            this.buttonSetCubic.Text = "Expr Cubic";
            this.toolTip1.SetToolTip(this.buttonSetCubic, "Add parametric cubic polynomial as expression");
            this.buttonSetCubic.UseVisualStyleBackColor = true;
            this.buttonSetCubic.Click += new System.EventHandler(this.buttonSetCubic_Click);
            // 
            // labelSE
            // 
            this.labelSE.AutoSize = true;
            this.labelSE.Location = new System.Drawing.Point(5, 82);
            this.labelSE.Name = "labelSE";
            this.labelSE.Size = new System.Drawing.Size(49, 15);
            this.labelSE.TabIndex = 12;
            this.labelSE.Text = "RMSE 1:";
            this.toolTip1.SetToolTip(this.labelSE, "Root Mean Squred Error of Sample points");
            // 
            // labelCubic
            // 
            this.labelCubic.AutoSize = true;
            this.labelCubic.Location = new System.Drawing.Point(5, 53);
            this.labelCubic.Name = "labelCubic";
            this.labelCubic.Size = new System.Drawing.Size(41, 15);
            this.labelCubic.TabIndex = 11;
            this.labelCubic.Text = "Cubic:";
            this.toolTip1.SetToolTip(this.labelCubic, "Cubic Polynomial");
            // 
            // textBoxExprCubicX
            // 
            this.textBoxExprCubicX.Location = new System.Drawing.Point(0, 0);
            this.textBoxExprCubicX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExprCubicX.Name = "textBoxExprCubicX";
            this.textBoxExprCubicX.ReadOnly = true;
            this.textBoxExprCubicX.Size = new System.Drawing.Size(250, 23);
            this.textBoxExprCubicX.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBoxExprCubicX, "c0 + c1*u + c2*u^2, c3*u^3");
            // 
            // textBoxExprCubicY
            // 
            this.textBoxExprCubicY.Location = new System.Drawing.Point(0, 2);
            this.textBoxExprCubicY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExprCubicY.Name = "textBoxExprCubicY";
            this.textBoxExprCubicY.ReadOnly = true;
            this.textBoxExprCubicY.Size = new System.Drawing.Size(250, 23);
            this.textBoxExprCubicY.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxExprCubicY, "c0 + c1*u + c2*u^2, c3*u^3");
            // 
            // buttonSelectBs
            // 
            this.buttonSelectBs.BackgroundImage = global::ParametricCurve.Properties.Resources.Pointer;
            this.buttonSelectBs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSelectBs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSelectBs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectBs.Location = new System.Drawing.Point(17, 20);
            this.buttonSelectBs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectBs.Name = "buttonSelectBs";
            this.buttonSelectBs.Size = new System.Drawing.Size(77, 22);
            this.buttonSelectBs.TabIndex = 23;
            this.buttonSelectBs.Text = "Select";
            this.buttonSelectBs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelectBs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonSelectBs, "Select target points for B-Spline");
            this.buttonSelectBs.UseVisualStyleBackColor = true;
            this.buttonSelectBs.Click += new System.EventHandler(this.buttonSelectBs_Click);
            // 
            // labelSE2
            // 
            this.labelSE2.AutoSize = true;
            this.labelSE2.Location = new System.Drawing.Point(5, 110);
            this.labelSE2.Name = "labelSE2";
            this.labelSE2.Size = new System.Drawing.Size(49, 15);
            this.labelSE2.TabIndex = 15;
            this.labelSE2.Text = "RMSE 2:";
            this.toolTip1.SetToolTip(this.labelSE2, "Root Mean Squred Error of All Points");
            // 
            // textBoxSE2
            // 
            this.textBoxSE2.Location = new System.Drawing.Point(63, 108);
            this.textBoxSE2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSE2.Name = "textBoxSE2";
            this.textBoxSE2.ReadOnly = true;
            this.textBoxSE2.Size = new System.Drawing.Size(52, 23);
            this.textBoxSE2.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBoxSE2, "Root Mean Squred Error of All Points");
            // 
            // buttonDrawBs
            // 
            this.buttonDrawBs.Location = new System.Drawing.Point(147, 21);
            this.buttonDrawBs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawBs.Name = "buttonDrawBs";
            this.buttonDrawBs.Size = new System.Drawing.Size(93, 21);
            this.buttonDrawBs.TabIndex = 20;
            this.buttonDrawBs.Text = "Draw BSpline";
            this.buttonDrawBs.UseVisualStyleBackColor = true;
            this.buttonDrawBs.Click += new System.EventHandler(this.buttonDrawBs_Click);
            // 
            // buttonPlotCurve
            // 
            this.buttonPlotCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlotCurve.Location = new System.Drawing.Point(133, 85);
            this.buttonPlotCurve.Name = "buttonPlotCurve";
            this.buttonPlotCurve.Size = new System.Drawing.Size(106, 31);
            this.buttonPlotCurve.TabIndex = 5;
            this.buttonPlotCurve.Text = "Plot Curve";
            this.buttonPlotCurve.UseVisualStyleBackColor = true;
            this.buttonPlotCurve.Click += new System.EventHandler(this.buttonPlotCurve_Click);
            // 
            // comboBoxX
            // 
            this.comboBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Location = new System.Drawing.Point(23, 20);
            this.comboBoxX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(86, 23);
            this.comboBoxX.TabIndex = 6;
            this.comboBoxX.SelectedIndexChanged += new System.EventHandler(this.comboBoxX_SelectedIndexChanged);
            // 
            // comboBoxY
            // 
            this.comboBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Location = new System.Drawing.Point(23, 52);
            this.comboBoxY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(86, 23);
            this.comboBoxY.TabIndex = 8;
            this.comboBoxY.SelectedIndexChanged += new System.EventHandler(this.comboBoxY_SelectedIndexChanged);
            // 
            // panelExprX
            // 
            this.panelExprX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExprX.BackgroundImage = global::ParametricCurve.Properties.Resources.CurveX;
            this.panelExprX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelExprX.Controls.Add(this.textBoxExprCubicX);
            this.panelExprX.Location = new System.Drawing.Point(111, 20);
            this.panelExprX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExprX.Name = "panelExprX";
            this.panelExprX.Size = new System.Drawing.Size(252, 26);
            this.panelExprX.TabIndex = 10;
            // 
            // panelExprY
            // 
            this.panelExprY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExprY.BackgroundImage = global::ParametricCurve.Properties.Resources.CurveY;
            this.panelExprY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelExprY.Controls.Add(this.textBoxExprCubicY);
            this.panelExprY.Location = new System.Drawing.Point(111, 50);
            this.panelExprY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExprY.Name = "panelExprY";
            this.panelExprY.Size = new System.Drawing.Size(252, 26);
            this.panelExprY.TabIndex = 11;
            // 
            // groupBoxPoints
            // 
            this.groupBoxPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPoints.Controls.Add(this.labelSE2);
            this.groupBoxPoints.Controls.Add(this.textBoxSE2);
            this.groupBoxPoints.Controls.Add(this.buttonSetCubic);
            this.groupBoxPoints.Controls.Add(this.labelSE);
            this.groupBoxPoints.Controls.Add(this.labelCubic);
            this.groupBoxPoints.Controls.Add(this.textBoxSE);
            this.groupBoxPoints.Controls.Add(this.buttonDrawCubic);
            this.groupBoxPoints.Controls.Add(this.textBoxCubicX);
            this.groupBoxPoints.Controls.Add(this.buttonAddPoint);
            this.groupBoxPoints.Controls.Add(this.textBoxFu);
            this.groupBoxPoints.Controls.Add(this.labelFu);
            this.groupBoxPoints.Controls.Add(this.textBoxU);
            this.groupBoxPoints.Controls.Add(this.labelU);
            this.groupBoxPoints.Location = new System.Drawing.Point(732, 154);
            this.groupBoxPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPoints.Name = "groupBoxPoints";
            this.groupBoxPoints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPoints.Size = new System.Drawing.Size(251, 138);
            this.groupBoxPoints.TabIndex = 12;
            this.groupBoxPoints.TabStop = false;
            this.groupBoxPoints.Text = "Sampled Points";
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Location = new System.Drawing.Point(156, 20);
            this.buttonAddPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(87, 21);
            this.buttonAddPoint.TabIndex = 5;
            this.buttonAddPoint.Text = "Add Point";
            this.buttonAddPoint.UseVisualStyleBackColor = true;
            this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // labelFu
            // 
            this.labelFu.AutoSize = true;
            this.labelFu.Location = new System.Drawing.Point(75, 24);
            this.labelFu.Name = "labelFu";
            this.labelFu.Size = new System.Drawing.Size(29, 15);
            this.labelFu.TabIndex = 2;
            this.labelFu.Text = "f(u):";
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Location = new System.Drawing.Point(4, 23);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(17, 15);
            this.labelU.TabIndex = 0;
            this.labelU.Text = "u:";
            // 
            // buttonClearGraph
            // 
            this.buttonClearGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearGraph.Location = new System.Drawing.Point(257, 85);
            this.buttonClearGraph.Name = "buttonClearGraph";
            this.buttonClearGraph.Size = new System.Drawing.Size(106, 31);
            this.buttonClearGraph.TabIndex = 13;
            this.buttonClearGraph.Text = "Clear Graph";
            this.buttonClearGraph.UseVisualStyleBackColor = true;
            this.buttonClearGraph.Click += new System.EventHandler(this.buttonClearGraph_Click);
            // 
            // groupBoxExpr
            // 
            this.groupBoxExpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExpr.Controls.Add(this.buttonPlotCurve);
            this.groupBoxExpr.Controls.Add(this.buttonClearGraph);
            this.groupBoxExpr.Controls.Add(this.comboBoxX);
            this.groupBoxExpr.Controls.Add(this.labelX);
            this.groupBoxExpr.Controls.Add(this.panelExprY);
            this.groupBoxExpr.Controls.Add(this.comboBoxY);
            this.groupBoxExpr.Controls.Add(this.panelExprX);
            this.groupBoxExpr.Controls.Add(this.labelY);
            this.groupBoxExpr.Location = new System.Drawing.Point(732, 22);
            this.groupBoxExpr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxExpr.Name = "groupBoxExpr";
            this.groupBoxExpr.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxExpr.Size = new System.Drawing.Size(370, 124);
            this.groupBoxExpr.TabIndex = 14;
            this.groupBoxExpr.TabStop = false;
            this.groupBoxExpr.Text = "Expression";
            // 
            // groupBoxBspline
            // 
            this.groupBoxBspline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBspline.Controls.Add(this.buttonSelectBs);
            this.groupBoxBspline.Controls.Add(this.buttonDrawBs);
            this.groupBoxBspline.Location = new System.Drawing.Point(735, 301);
            this.groupBoxBspline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBspline.Name = "groupBoxBspline";
            this.groupBoxBspline.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBspline.Size = new System.Drawing.Size(248, 52);
            this.groupBoxBspline.TabIndex = 15;
            this.groupBoxBspline.TabStop = false;
            this.groupBoxBspline.Text = "B-Spline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1112, 540);
            this.Controls.Add(this.groupBoxBspline);
            this.Controls.Add(this.groupBoxExpr);
            this.Controls.Add(this.groupBoxPoints);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBoxPoints);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "AE7453 A2 (Xu Shifeng G2104007A)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelLegend.ResumeLayout(false);
            this.panelLegend.PerformLayout();
            this.panelExprX.ResumeLayout(false);
            this.panelExprX.PerformLayout();
            this.panelExprY.ResumeLayout(false);
            this.panelExprY.PerformLayout();
            this.groupBoxPoints.ResumeLayout(false);
            this.groupBoxPoints.PerformLayout();
            this.groupBoxExpr.ResumeLayout(false);
            this.groupBoxExpr.PerformLayout();
            this.groupBoxBspline.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel1;
        private ToolTip toolTip1;
        private Button buttonPlotCurve;
        private ComboBox comboBoxX;
        private Label labelX;
        private Label labelY;
        private ComboBox comboBoxY;
        private Panel panelExprX;
        private Panel panelExprY;
        private Panel panelLegend;
        private Label labelXScale;
        private Label labelYScale;
        private TextBox textBoxYScale;
        private TextBox textBoxXScale;
        private Button buttonXScale;
        private Button buttonYScale;
        private Button buttonMoveGraph;
        private GroupBox groupBoxPoints;
        private Label labelU;
        private TextBox textBoxU;
        private TextBox textBoxFu;
        private Label labelFu;
        private ListBoxRich listBoxPoints;
        private Button buttonAddPoint;
        private ToolStripMenuItem saveSamplePointsToolStripMenuItem;
        private TextBox textBoxCubicX;
        private Button buttonDrawCubic;
        private Label labelSE;
        private Label labelCubic;
        private TextBox textBoxSE;
        private Button buttonClearGraph;
        private GroupBox groupBoxExpr;
        private Button buttonSetCubic;
        private TextBox textBoxExprCubicX;
        private TextBox textBoxExprCubicY;
        private ToolStripMenuItem saveCubicPolynomialsToolStripMenuItem;
        private ToolStripMenuItem loadCubicPolynomialsToolStripMenuItem;
        private GroupBox groupBoxBspline;
        private Button buttonDrawBs;
        private Button buttonSelectBs;
        private ToolStripMenuItem samplePointsToolStripMenuItem;
        private ToolStripMenuItem useAllPointsAsSampleToolStripMenuItem;
        private Label labelSE2;
        private TextBox textBoxSE2;
        private ToolStripMenuItem loadSamplePointsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem bSplineToolStripMenuItem;
        private ToolStripMenuItem saveTargetPointsToolStripMenuItem;
        private ToolStripMenuItem loadTargetPointsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem saveBSplineDataToolStripMenuItem;
    }
}