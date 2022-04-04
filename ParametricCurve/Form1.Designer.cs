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
            this.saveSamplePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCubicPolynomialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCubicPolynomialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.listBoxPoints = new System.Windows.Forms.ListBox();
            this.textBoxCubicX = new System.Windows.Forms.TextBox();
            this.buttonDrawCubic = new System.Windows.Forms.Button();
            this.textBoxSE = new System.Windows.Forms.TextBox();
            this.buttonSetCubic = new System.Windows.Forms.Button();
            this.labelSE = new System.Windows.Forms.Label();
            this.labelCubic = new System.Windows.Forms.Label();
            this.textBoxExprCubicX = new System.Windows.Forms.TextBox();
            this.textBoxExprCubicY = new System.Windows.Forms.TextBox();
            this.listBoxBsPoints = new System.Windows.Forms.ListBox();
            this.buttonSelectBs = new System.Windows.Forms.Button();
            this.buttonSaveBs = new System.Windows.Forms.Button();
            this.buttonDrawBs = new System.Windows.Forms.Button();
            this.buttonPlotCurve = new System.Windows.Forms.Button();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.panelExprX = new System.Windows.Forms.Panel();
            this.panelExprY = new System.Windows.Forms.Panel();
            this.groupBoxPoints = new System.Windows.Forms.GroupBox();
            this.buttonDeletePoint = new System.Windows.Forms.Button();
            this.buttonAddPoint = new System.Windows.Forms.Button();
            this.labelFu = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.buttonClearGraph = new System.Windows.Forms.Button();
            this.groupBoxExpr = new System.Windows.Forms.GroupBox();
            this.groupBoxBspline = new System.Windows.Forms.GroupBox();
            this.buttonDeleteBsPoint = new System.Windows.Forms.Button();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1271, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1271, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSamplePointsToolStripMenuItem,
            this.saveCubicPolynomialsToolStripMenuItem,
            this.loadCubicPolynomialsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveSamplePointsToolStripMenuItem
            // 
            this.saveSamplePointsToolStripMenuItem.Name = "saveSamplePointsToolStripMenuItem";
            this.saveSamplePointsToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.saveSamplePointsToolStripMenuItem.Text = "Save Sample Points";
            this.saveSamplePointsToolStripMenuItem.Click += new System.EventHandler(this.saveSamplePointsToolStripMenuItem_Click);
            // 
            // saveCubicPolynomialsToolStripMenuItem
            // 
            this.saveCubicPolynomialsToolStripMenuItem.Name = "saveCubicPolynomialsToolStripMenuItem";
            this.saveCubicPolynomialsToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.saveCubicPolynomialsToolStripMenuItem.Text = "Save Cubic Polynomials";
            this.saveCubicPolynomialsToolStripMenuItem.Click += new System.EventHandler(this.saveCubicPolynomialsToolStripMenuItem_Click);
            // 
            // loadCubicPolynomialsToolStripMenuItem
            // 
            this.loadCubicPolynomialsToolStripMenuItem.Name = "loadCubicPolynomialsToolStripMenuItem";
            this.loadCubicPolynomialsToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.loadCubicPolynomialsToolStripMenuItem.Text = "Load Cubic Polynomials";
            this.loadCubicPolynomialsToolStripMenuItem.Click += new System.EventHandler(this.loadCubicPolynomialsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
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
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 647);
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
            this.panelLegend.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelLegend.Location = new System.Drawing.Point(533, -1);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(293, 44);
            this.panelLegend.TabIndex = 0;
            // 
            // buttonMoveGraph
            // 
            this.buttonMoveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveGraph.BackgroundImage = global::ParametricCurve.Properties.Resources.Hand;
            this.buttonMoveGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMoveGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMoveGraph.Location = new System.Drawing.Point(8, 6);
            this.buttonMoveGraph.Name = "buttonMoveGraph";
            this.buttonMoveGraph.Size = new System.Drawing.Size(30, 30);
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
            this.buttonYScale.Location = new System.Drawing.Point(80, 6);
            this.buttonYScale.Name = "buttonYScale";
            this.buttonYScale.Size = new System.Drawing.Size(30, 30);
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
            this.buttonXScale.Location = new System.Drawing.Point(44, 6);
            this.buttonXScale.Name = "buttonXScale";
            this.buttonXScale.Size = new System.Drawing.Size(30, 30);
            this.buttonXScale.TabIndex = 15;
            this.toolTip1.SetToolTip(this.buttonXScale, "Zoom on X-Axis");
            this.buttonXScale.UseVisualStyleBackColor = true;
            this.buttonXScale.Click += new System.EventHandler(this.buttonXScale_Click);
            // 
            // textBoxYScale
            // 
            this.textBoxYScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxYScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYScale.Location = new System.Drawing.Point(225, 8);
            this.textBoxYScale.Name = "textBoxYScale";
            this.textBoxYScale.Size = new System.Drawing.Size(51, 27);
            this.textBoxYScale.TabIndex = 14;
            this.textBoxYScale.Text = "1";
            this.toolTip1.SetToolTip(this.textBoxYScale, "Y-Axis length 1 cover pixels");
            // 
            // textBoxXScale
            // 
            this.textBoxXScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxXScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxXScale.Location = new System.Drawing.Point(142, 8);
            this.textBoxXScale.Name = "textBoxXScale";
            this.textBoxXScale.Size = new System.Drawing.Size(51, 27);
            this.textBoxXScale.TabIndex = 13;
            this.textBoxXScale.Text = "1";
            this.toolTip1.SetToolTip(this.textBoxXScale, "X-Axis length 1 cover pixels");
            // 
            // labelYScale
            // 
            this.labelYScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYScale.AutoSize = true;
            this.labelYScale.Location = new System.Drawing.Point(202, 11);
            this.labelYScale.Name = "labelYScale";
            this.labelYScale.Size = new System.Drawing.Size(20, 20);
            this.labelYScale.TabIndex = 12;
            this.labelYScale.Text = "Y:";
            this.toolTip1.SetToolTip(this.labelYScale, "Y-Axis Scale");
            // 
            // labelXScale
            // 
            this.labelXScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelXScale.AutoSize = true;
            this.labelXScale.Location = new System.Drawing.Point(122, 11);
            this.labelXScale.Name = "labelXScale";
            this.labelXScale.Size = new System.Drawing.Size(21, 20);
            this.labelXScale.TabIndex = 12;
            this.labelXScale.Text = "X:";
            this.toolTip1.SetToolTip(this.labelXScale, "X-Axis Scale");
            // 
            // labelX
            // 
            this.labelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(4, 29);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(23, 20);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "H:";
            this.toolTip1.SetToolTip(this.labelX, "Horizontal-Axis expression");
            // 
            // labelY
            // 
            this.labelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(4, 73);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(21, 20);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "V:";
            this.toolTip1.SetToolTip(this.labelY, "Vertical-Axis expression");
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(59, 32);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(55, 27);
            this.textBoxU.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxU, "Value of u");
            this.textBoxU.TextChanged += new System.EventHandler(this.textBoxU_TextChanged);
            // 
            // textBoxFu
            // 
            this.textBoxFu.Location = new System.Drawing.Point(59, 67);
            this.textBoxFu.Name = "textBoxFu";
            this.textBoxFu.Size = new System.Drawing.Size(55, 27);
            this.textBoxFu.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxFu, "Value of u");
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.ItemHeight = 20;
            this.listBoxPoints.Location = new System.Drawing.Point(287, 26);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(125, 184);
            this.listBoxPoints.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listBoxPoints, "Double click to delete");
            this.listBoxPoints.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPoints_MouseDoubleClick);
            // 
            // textBoxCubicX
            // 
            this.textBoxCubicX.Location = new System.Drawing.Point(59, 104);
            this.textBoxCubicX.Name = "textBoxCubicX";
            this.textBoxCubicX.ReadOnly = true;
            this.textBoxCubicX.Size = new System.Drawing.Size(214, 27);
            this.textBoxCubicX.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxCubicX, "c0 + c1*u + c2*u^2, c3*u^3");
            // 
            // buttonDrawCubic
            // 
            this.buttonDrawCubic.Location = new System.Drawing.Point(184, 143);
            this.buttonDrawCubic.Name = "buttonDrawCubic";
            this.buttonDrawCubic.Size = new System.Drawing.Size(93, 28);
            this.buttonDrawCubic.TabIndex = 8;
            this.buttonDrawCubic.Text = "Draw Cubic";
            this.toolTip1.SetToolTip(this.buttonDrawCubic, "Fit a parametric cubic polynomial");
            this.buttonDrawCubic.UseVisualStyleBackColor = true;
            this.buttonDrawCubic.Click += new System.EventHandler(this.buttonDrawCubic_Click);
            // 
            // textBoxSE
            // 
            this.textBoxSE.Location = new System.Drawing.Point(59, 140);
            this.textBoxSE.Name = "textBoxSE";
            this.textBoxSE.ReadOnly = true;
            this.textBoxSE.Size = new System.Drawing.Size(55, 27);
            this.textBoxSE.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxSE, "Root Mean Squred Error");
            // 
            // buttonSetCubic
            // 
            this.buttonSetCubic.Location = new System.Drawing.Point(104, 182);
            this.buttonSetCubic.Name = "buttonSetCubic";
            this.buttonSetCubic.Size = new System.Drawing.Size(173, 28);
            this.buttonSetCubic.TabIndex = 13;
            this.buttonSetCubic.Text = "Set Cubic as Expression";
            this.toolTip1.SetToolTip(this.buttonSetCubic, "Add parametric cubic polynomial as expression");
            this.buttonSetCubic.UseVisualStyleBackColor = true;
            this.buttonSetCubic.Click += new System.EventHandler(this.buttonSetCubic_Click);
            // 
            // labelSE
            // 
            this.labelSE.AutoSize = true;
            this.labelSE.Location = new System.Drawing.Point(6, 143);
            this.labelSE.Name = "labelSE";
            this.labelSE.Size = new System.Drawing.Size(50, 20);
            this.labelSE.TabIndex = 12;
            this.labelSE.Text = "RMSE:";
            this.toolTip1.SetToolTip(this.labelSE, "Root Mean Squred Error");
            // 
            // labelCubic
            // 
            this.labelCubic.AutoSize = true;
            this.labelCubic.Location = new System.Drawing.Point(6, 107);
            this.labelCubic.Name = "labelCubic";
            this.labelCubic.Size = new System.Drawing.Size(49, 20);
            this.labelCubic.TabIndex = 11;
            this.labelCubic.Text = "Cubic:";
            this.toolTip1.SetToolTip(this.labelCubic, "Cubic Polynomial");
            // 
            // textBoxExprCubicX
            // 
            this.textBoxExprCubicX.Location = new System.Drawing.Point(0, 0);
            this.textBoxExprCubicX.Name = "textBoxExprCubicX";
            this.textBoxExprCubicX.ReadOnly = true;
            this.textBoxExprCubicX.Size = new System.Drawing.Size(285, 27);
            this.textBoxExprCubicX.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBoxExprCubicX, "c0 + c1*u + c2*u^2, c3*u^3");
            // 
            // textBoxExprCubicY
            // 
            this.textBoxExprCubicY.Location = new System.Drawing.Point(0, 3);
            this.textBoxExprCubicY.Name = "textBoxExprCubicY";
            this.textBoxExprCubicY.ReadOnly = true;
            this.textBoxExprCubicY.Size = new System.Drawing.Size(285, 27);
            this.textBoxExprCubicY.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxExprCubicY, "c0 + c1*u + c2*u^2, c3*u^3");
            // 
            // listBoxBsPoints
            // 
            this.listBoxBsPoints.FormattingEnabled = true;
            this.listBoxBsPoints.ItemHeight = 20;
            this.listBoxBsPoints.Location = new System.Drawing.Point(288, 24);
            this.listBoxBsPoints.Name = "listBoxBsPoints";
            this.listBoxBsPoints.Size = new System.Drawing.Size(125, 184);
            this.listBoxBsPoints.TabIndex = 18;
            this.toolTip1.SetToolTip(this.listBoxBsPoints, "Double click to delete");
            this.listBoxBsPoints.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxBsPoints_MouseDoubleClick);
            // 
            // buttonSelectBs
            // 
            this.buttonSelectBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectBs.BackgroundImage = global::ParametricCurve.Properties.Resources.Pointer;
            this.buttonSelectBs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSelectBs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSelectBs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectBs.Location = new System.Drawing.Point(22, 26);
            this.buttonSelectBs.Name = "buttonSelectBs";
            this.buttonSelectBs.Size = new System.Drawing.Size(88, 30);
            this.buttonSelectBs.TabIndex = 23;
            this.buttonSelectBs.Text = "Select";
            this.buttonSelectBs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelectBs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonSelectBs, "Select target points for B-Spline");
            this.buttonSelectBs.UseVisualStyleBackColor = true;
            this.buttonSelectBs.Click += new System.EventHandler(this.buttonSelectBs_Click);
            // 
            // buttonSaveBs
            // 
            this.buttonSaveBs.Location = new System.Drawing.Point(171, 146);
            this.buttonSaveBs.Name = "buttonSaveBs";
            this.buttonSaveBs.Size = new System.Drawing.Size(107, 28);
            this.buttonSaveBs.TabIndex = 22;
            this.buttonSaveBs.Text = "Save BSpline";
            this.buttonSaveBs.UseVisualStyleBackColor = true;
            // 
            // buttonDrawBs
            // 
            this.buttonDrawBs.Location = new System.Drawing.Point(171, 69);
            this.buttonDrawBs.Name = "buttonDrawBs";
            this.buttonDrawBs.Size = new System.Drawing.Size(106, 28);
            this.buttonDrawBs.TabIndex = 20;
            this.buttonDrawBs.Text = "Draw BSpline";
            this.buttonDrawBs.UseVisualStyleBackColor = true;
            this.buttonDrawBs.Click += new System.EventHandler(this.buttonDrawBs_Click);
            // 
            // buttonPlotCurve
            // 
            this.buttonPlotCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlotCurve.Location = new System.Drawing.Point(152, 113);
            this.buttonPlotCurve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPlotCurve.Name = "buttonPlotCurve";
            this.buttonPlotCurve.Size = new System.Drawing.Size(121, 41);
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
            this.comboBoxX.Location = new System.Drawing.Point(26, 26);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(98, 28);
            this.comboBoxX.TabIndex = 6;
            this.comboBoxX.SelectedIndexChanged += new System.EventHandler(this.comboBoxX_SelectedIndexChanged);
            // 
            // comboBoxY
            // 
            this.comboBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Location = new System.Drawing.Point(26, 70);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(98, 28);
            this.comboBoxY.TabIndex = 8;
            this.comboBoxY.SelectedIndexChanged += new System.EventHandler(this.comboBoxY_SelectedIndexChanged);
            // 
            // panelExprX
            // 
            this.panelExprX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExprX.BackgroundImage = global::ParametricCurve.Properties.Resources.CurveX;
            this.panelExprX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelExprX.Controls.Add(this.textBoxExprCubicX);
            this.panelExprX.Location = new System.Drawing.Point(127, 26);
            this.panelExprX.Name = "panelExprX";
            this.panelExprX.Size = new System.Drawing.Size(288, 35);
            this.panelExprX.TabIndex = 10;
            // 
            // panelExprY
            // 
            this.panelExprY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExprY.BackgroundImage = global::ParametricCurve.Properties.Resources.CurveY;
            this.panelExprY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelExprY.Controls.Add(this.textBoxExprCubicY);
            this.panelExprY.Location = new System.Drawing.Point(127, 67);
            this.panelExprY.Name = "panelExprY";
            this.panelExprY.Size = new System.Drawing.Size(288, 35);
            this.panelExprY.TabIndex = 11;
            // 
            // groupBoxPoints
            // 
            this.groupBoxPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPoints.Controls.Add(this.buttonSetCubic);
            this.groupBoxPoints.Controls.Add(this.labelSE);
            this.groupBoxPoints.Controls.Add(this.labelCubic);
            this.groupBoxPoints.Controls.Add(this.textBoxSE);
            this.groupBoxPoints.Controls.Add(this.buttonDeletePoint);
            this.groupBoxPoints.Controls.Add(this.buttonDrawCubic);
            this.groupBoxPoints.Controls.Add(this.textBoxCubicX);
            this.groupBoxPoints.Controls.Add(this.buttonAddPoint);
            this.groupBoxPoints.Controls.Add(this.listBoxPoints);
            this.groupBoxPoints.Controls.Add(this.textBoxFu);
            this.groupBoxPoints.Controls.Add(this.labelFu);
            this.groupBoxPoints.Controls.Add(this.textBoxU);
            this.groupBoxPoints.Controls.Add(this.labelU);
            this.groupBoxPoints.Location = new System.Drawing.Point(836, 206);
            this.groupBoxPoints.Name = "groupBoxPoints";
            this.groupBoxPoints.Size = new System.Drawing.Size(423, 226);
            this.groupBoxPoints.TabIndex = 12;
            this.groupBoxPoints.TabStop = false;
            this.groupBoxPoints.Text = "Sampled Points";
            // 
            // buttonDeletePoint
            // 
            this.buttonDeletePoint.Location = new System.Drawing.Point(178, 66);
            this.buttonDeletePoint.Name = "buttonDeletePoint";
            this.buttonDeletePoint.Size = new System.Drawing.Size(99, 28);
            this.buttonDeletePoint.TabIndex = 9;
            this.buttonDeletePoint.Text = "Delete Point";
            this.buttonDeletePoint.UseVisualStyleBackColor = true;
            this.buttonDeletePoint.Click += new System.EventHandler(this.buttonDeletePoint_Click);
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Location = new System.Drawing.Point(178, 26);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(99, 28);
            this.buttonAddPoint.TabIndex = 5;
            this.buttonAddPoint.Text = "Add Point";
            this.buttonAddPoint.UseVisualStyleBackColor = true;
            this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // labelFu
            // 
            this.labelFu.AutoSize = true;
            this.labelFu.Location = new System.Drawing.Point(6, 73);
            this.labelFu.Name = "labelFu";
            this.labelFu.Size = new System.Drawing.Size(35, 20);
            this.labelFu.TabIndex = 2;
            this.labelFu.Text = "f(u):";
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Location = new System.Drawing.Point(6, 35);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(20, 20);
            this.labelU.TabIndex = 0;
            this.labelU.Text = "u:";
            // 
            // buttonClearGraph
            // 
            this.buttonClearGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearGraph.Location = new System.Drawing.Point(294, 113);
            this.buttonClearGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClearGraph.Name = "buttonClearGraph";
            this.buttonClearGraph.Size = new System.Drawing.Size(121, 41);
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
            this.groupBoxExpr.Location = new System.Drawing.Point(836, 29);
            this.groupBoxExpr.Name = "groupBoxExpr";
            this.groupBoxExpr.Size = new System.Drawing.Size(423, 166);
            this.groupBoxExpr.TabIndex = 14;
            this.groupBoxExpr.TabStop = false;
            this.groupBoxExpr.Text = "Expression";
            // 
            // groupBoxBspline
            // 
            this.groupBoxBspline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBspline.Controls.Add(this.buttonSelectBs);
            this.groupBoxBspline.Controls.Add(this.buttonSaveBs);
            this.groupBoxBspline.Controls.Add(this.buttonDeleteBsPoint);
            this.groupBoxBspline.Controls.Add(this.buttonDrawBs);
            this.groupBoxBspline.Controls.Add(this.listBoxBsPoints);
            this.groupBoxBspline.Location = new System.Drawing.Point(840, 438);
            this.groupBoxBspline.Name = "groupBoxBspline";
            this.groupBoxBspline.Size = new System.Drawing.Size(419, 217);
            this.groupBoxBspline.TabIndex = 15;
            this.groupBoxBspline.TabStop = false;
            this.groupBoxBspline.Text = "B-Spline";
            // 
            // buttonDeleteBsPoint
            // 
            this.buttonDeleteBsPoint.Location = new System.Drawing.Point(171, 24);
            this.buttonDeleteBsPoint.Name = "buttonDeleteBsPoint";
            this.buttonDeleteBsPoint.Size = new System.Drawing.Size(107, 28);
            this.buttonDeleteBsPoint.TabIndex = 21;
            this.buttonDeleteBsPoint.Text = "Delete Point";
            this.buttonDeleteBsPoint.UseVisualStyleBackColor = true;
            this.buttonDeleteBsPoint.Click += new System.EventHandler(this.buttonDeleteBsPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1271, 720);
            this.Controls.Add(this.groupBoxBspline);
            this.Controls.Add(this.groupBoxExpr);
            this.Controls.Add(this.groupBoxPoints);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
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
        private ListBox listBoxPoints;
        private Button buttonAddPoint;
        private ToolStripMenuItem saveSamplePointsToolStripMenuItem;
        private TextBox textBoxCubicX;
        private Button buttonDrawCubic;
        private Button buttonDeletePoint;
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
        private Button buttonSaveBs;
        private Button buttonDeleteBsPoint;
        private Button buttonDrawBs;
        private ListBox listBoxBsPoints;
        private Button buttonSelectBs;
    }
}