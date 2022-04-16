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
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxIdxH = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samplePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSamplePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSamplePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.useAllPointsAsSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubicPolynomialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCubicPolynomialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCubicPolynomialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTargetPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTargetPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveBSplineDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniform4PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniform6PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniform8PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniform12PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniform16PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCoefficientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIntegrationResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAllGridForAllRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPanel1XY = new System.Windows.Forms.TextBox();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.buttonMoveGraph = new System.Windows.Forms.Button();
            this.buttonYScale = new System.Windows.Forms.Button();
            this.buttonXScale = new System.Windows.Forms.Button();
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
            this.buttonDrawFourier = new System.Windows.Forms.Button();
            this.groupBoxFourier = new System.Windows.Forms.GroupBox();
            this.buttonExprFourier = new System.Windows.Forms.Button();
            this.labelSamplePoints = new System.Windows.Forms.Label();
            this.groupBoxCubic = new System.Windows.Forms.GroupBox();
            this.groupBoxIntegration = new System.Windows.Forms.GroupBox();
            this.comboBoxIntgrGrid = new System.Windows.Forms.ComboBox();
            this.labelIntgrGrid = new System.Windows.Forms.Label();
            this.buttonIntgr = new System.Windows.Forms.Button();
            this.labelIntgrRule = new System.Windows.Forms.Label();
            this.comboBoxIntgrMethod = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.panelExprX.SuspendLayout();
            this.panelExprY.SuspendLayout();
            this.groupBoxPoints.SuspendLayout();
            this.groupBoxExpr.SuspendLayout();
            this.groupBoxBspline.SuspendLayout();
            this.groupBoxFourier.SuspendLayout();
            this.groupBoxCubic.SuspendLayout();
            this.groupBoxIntegration.SuspendLayout();
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
            this.cubicPolynomialToolStripMenuItem,
            this.bSplineToolStripMenuItem,
            this.fourierToolStripMenuItem,
            this.integrationToolStripMenuItem});
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
            this.toolStripMenuItem5,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxIdxH});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem5.Text = "Assignment 2 Index number h";
            // 
            // toolStripTextBoxIdxH
            // 
            this.toolStripTextBoxIdxH.Name = "toolStripTextBoxIdxH";
            this.toolStripTextBoxIdxH.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxIdxH.Text = "46";
            this.toolStripTextBoxIdxH.TextChanged += new System.EventHandler(this.toolStripTextBoxIdxH_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // samplePointsToolStripMenuItem
            // 
            this.samplePointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSamplePointsToolStripMenuItem,
            this.loadSamplePointsToolStripMenuItem,
            this.toolStripMenuItem1,
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
            // useAllPointsAsSampleToolStripMenuItem
            // 
            this.useAllPointsAsSampleToolStripMenuItem.Name = "useAllPointsAsSampleToolStripMenuItem";
            this.useAllPointsAsSampleToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.useAllPointsAsSampleToolStripMenuItem.Text = "Use All Points as Sample";
            this.useAllPointsAsSampleToolStripMenuItem.Click += new System.EventHandler(this.useAllPointsAsSampleToolStripMenuItem_Click);
            // 
            // cubicPolynomialToolStripMenuItem
            // 
            this.cubicPolynomialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCubicPolynomialsToolStripMenuItem,
            this.loadCubicPolynomialsToolStripMenuItem});
            this.cubicPolynomialToolStripMenuItem.Name = "cubicPolynomialToolStripMenuItem";
            this.cubicPolynomialToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.cubicPolynomialToolStripMenuItem.Text = "Cubic Polynomial";
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
            // fourierToolStripMenuItem
            // 
            this.fourierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uniform4PointsToolStripMenuItem,
            this.uniform6PointsToolStripMenuItem,
            this.uniform8PointsToolStripMenuItem,
            this.uniform12PointsToolStripMenuItem,
            this.uniform16PointsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveCoefficientsToolStripMenuItem});
            this.fourierToolStripMenuItem.Name = "fourierToolStripMenuItem";
            this.fourierToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fourierToolStripMenuItem.Text = "Fourier";
            // 
            // uniform4PointsToolStripMenuItem
            // 
            this.uniform4PointsToolStripMenuItem.Name = "uniform4PointsToolStripMenuItem";
            this.uniform4PointsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.uniform4PointsToolStripMenuItem.Text = "Uniform 4 Points";
            this.uniform4PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform4PointsToolStripMenuItem_Click);
            // 
            // uniform6PointsToolStripMenuItem
            // 
            this.uniform6PointsToolStripMenuItem.Name = "uniform6PointsToolStripMenuItem";
            this.uniform6PointsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.uniform6PointsToolStripMenuItem.Text = "Uniform 6 Points";
            this.uniform6PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform6PointsToolStripMenuItem_Click);
            // 
            // uniform8PointsToolStripMenuItem
            // 
            this.uniform8PointsToolStripMenuItem.Name = "uniform8PointsToolStripMenuItem";
            this.uniform8PointsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.uniform8PointsToolStripMenuItem.Text = "Uniform 8 Points";
            this.uniform8PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform8PointsToolStripMenuItem_Click);
            // 
            // uniform12PointsToolStripMenuItem
            // 
            this.uniform12PointsToolStripMenuItem.Name = "uniform12PointsToolStripMenuItem";
            this.uniform12PointsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.uniform12PointsToolStripMenuItem.Text = "Uniform 12 Points";
            this.uniform12PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform12PointsToolStripMenuItem_Click);
            // 
            // uniform16PointsToolStripMenuItem
            // 
            this.uniform16PointsToolStripMenuItem.Name = "uniform16PointsToolStripMenuItem";
            this.uniform16PointsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.uniform16PointsToolStripMenuItem.Text = "Uniform 16 Points";
            this.uniform16PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform16PointsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 6);
            // 
            // saveCoefficientsToolStripMenuItem
            // 
            this.saveCoefficientsToolStripMenuItem.Name = "saveCoefficientsToolStripMenuItem";
            this.saveCoefficientsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveCoefficientsToolStripMenuItem.Text = "Save Coefficients";
            this.saveCoefficientsToolStripMenuItem.Click += new System.EventHandler(this.saveCoefficientsToolStripMenuItem_Click);
            // 
            // integrationToolStripMenuItem
            // 
            this.integrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveIntegrationResultsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.saveAllGridForAllRulesToolStripMenuItem});
            this.integrationToolStripMenuItem.Name = "integrationToolStripMenuItem";
            this.integrationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.integrationToolStripMenuItem.Text = "Integration";
            // 
            // saveIntegrationResultsToolStripMenuItem
            // 
            this.saveIntegrationResultsToolStripMenuItem.Name = "saveIntegrationResultsToolStripMenuItem";
            this.saveIntegrationResultsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.saveIntegrationResultsToolStripMenuItem.Text = "Save Integration Results";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(203, 6);
            // 
            // saveAllGridForAllRulesToolStripMenuItem
            // 
            this.saveAllGridForAllRulesToolStripMenuItem.Name = "saveAllGridForAllRulesToolStripMenuItem";
            this.saveAllGridForAllRulesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.saveAllGridForAllRulesToolStripMenuItem.Text = "Save All Grid for All Rules";
            this.saveAllGridForAllRulesToolStripMenuItem.Click += new System.EventHandler(this.saveAllGridForAllRulesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxPanel1XY);
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
            // textBoxPanel1XY
            // 
            this.textBoxPanel1XY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPanel1XY.BackColor = System.Drawing.Color.White;
            this.textBoxPanel1XY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPanel1XY.Location = new System.Drawing.Point(644, 466);
            this.textBoxPanel1XY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPanel1XY.Name = "textBoxPanel1XY";
            this.textBoxPanel1XY.ReadOnly = true;
            this.textBoxPanel1XY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPanel1XY.Size = new System.Drawing.Size(77, 16);
            this.textBoxPanel1XY.TabStop = false;
            this.textBoxPanel1XY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.textBoxPanel1XY, "X and Y coordinates");
            // 
            // panelLegend
            // 
            this.panelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLegend.Controls.Add(this.buttonMoveGraph);
            this.panelLegend.Controls.Add(this.buttonYScale);
            this.panelLegend.Controls.Add(this.buttonXScale);
            this.panelLegend.Location = new System.Drawing.Point(619, -1);
            this.panelLegend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(104, 34);
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
            this.buttonYScale.TabIndex = 19;
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
            this.buttonXScale.TabIndex = 18;
            this.toolTip1.SetToolTip(this.buttonXScale, "Zoom on X-Axis");
            this.buttonXScale.UseVisualStyleBackColor = true;
            this.buttonXScale.Click += new System.EventHandler(this.buttonXScale_Click);
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
            this.textBoxU.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxU, "Value of u");
            this.textBoxU.TextChanged += new System.EventHandler(this.textBoxU_TextChanged);
            // 
            // textBoxFu
            // 
            this.textBoxFu.Location = new System.Drawing.Point(100, 20);
            this.textBoxFu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFu.Name = "textBoxFu";
            this.textBoxFu.Size = new System.Drawing.Size(45, 23);
            this.textBoxFu.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxFu, "Value of u");
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.ItemHeight = 15;
            this.listBoxPoints.Location = new System.Drawing.Point(990, 181);
            this.listBoxPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(110, 244);
            this.listBoxPoints.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listBoxPoints, "Double click to delete");
            this.listBoxPoints.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPoints_MouseDoubleClick);
            // 
            // textBoxCubicX
            // 
            this.textBoxCubicX.Location = new System.Drawing.Point(63, 20);
            this.textBoxCubicX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCubicX.Name = "textBoxCubicX";
            this.textBoxCubicX.ReadOnly = true;
            this.textBoxCubicX.Size = new System.Drawing.Size(180, 23);
            this.textBoxCubicX.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxCubicX, "c0 + c1*u + c2*u^2, c3*u^3");
            // 
            // buttonDrawCubic
            // 
            this.buttonDrawCubic.Location = new System.Drawing.Point(5, 69);
            this.buttonDrawCubic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawCubic.Name = "buttonDrawCubic";
            this.buttonDrawCubic.Size = new System.Drawing.Size(109, 21);
            this.buttonDrawCubic.TabIndex = 8;
            this.buttonDrawCubic.Text = "Draw Cubic";
            this.toolTip1.SetToolTip(this.buttonDrawCubic, "Fit a parametric cubic polynomial");
            this.buttonDrawCubic.UseVisualStyleBackColor = true;
            this.buttonDrawCubic.Click += new System.EventHandler(this.buttonDrawCubic_Click);
            // 
            // textBoxSE
            // 
            this.textBoxSE.Location = new System.Drawing.Point(63, 44);
            this.textBoxSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSE.Name = "textBoxSE";
            this.textBoxSE.ReadOnly = true;
            this.textBoxSE.Size = new System.Drawing.Size(52, 23);
            this.textBoxSE.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxSE, "Root Mean Squred Error of Sample Points");
            // 
            // buttonSetCubic
            // 
            this.buttonSetCubic.Location = new System.Drawing.Point(133, 69);
            this.buttonSetCubic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetCubic.Name = "buttonSetCubic";
            this.buttonSetCubic.Size = new System.Drawing.Size(109, 21);
            this.buttonSetCubic.TabIndex = 9;
            this.buttonSetCubic.Text = "Expr Cubic";
            this.toolTip1.SetToolTip(this.buttonSetCubic, "Add parametric cubic polynomial as expression");
            this.buttonSetCubic.UseVisualStyleBackColor = true;
            this.buttonSetCubic.Click += new System.EventHandler(this.buttonSetCubic_Click);
            // 
            // labelSE
            // 
            this.labelSE.AutoSize = true;
            this.labelSE.Location = new System.Drawing.Point(5, 46);
            this.labelSE.Name = "labelSE";
            this.labelSE.Size = new System.Drawing.Size(49, 15);
            this.labelSE.TabIndex = 12;
            this.labelSE.Text = "RMSE 1:";
            this.toolTip1.SetToolTip(this.labelSE, "Root Mean Squred Error of Sample points");
            // 
            // labelCubic
            // 
            this.labelCubic.AutoSize = true;
            this.labelCubic.Location = new System.Drawing.Point(5, 22);
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
            this.buttonSelectBs.Location = new System.Drawing.Point(17, 16);
            this.buttonSelectBs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectBs.Name = "buttonSelectBs";
            this.buttonSelectBs.Size = new System.Drawing.Size(98, 22);
            this.buttonSelectBs.TabIndex = 12;
            this.buttonSelectBs.Text = "Select    ";
            this.buttonSelectBs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelectBs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonSelectBs, "Select target points for B-Spline");
            this.buttonSelectBs.UseVisualStyleBackColor = true;
            this.buttonSelectBs.Click += new System.EventHandler(this.buttonSelectBs_Click);
            // 
            // labelSE2
            // 
            this.labelSE2.AutoSize = true;
            this.labelSE2.Location = new System.Drawing.Point(133, 46);
            this.labelSE2.Name = "labelSE2";
            this.labelSE2.Size = new System.Drawing.Size(49, 15);
            this.labelSE2.TabIndex = 15;
            this.labelSE2.Text = "RMSE 2:";
            this.toolTip1.SetToolTip(this.labelSE2, "Root Mean Squred Error of All Points");
            // 
            // textBoxSE2
            // 
            this.textBoxSE2.Location = new System.Drawing.Point(191, 44);
            this.textBoxSE2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSE2.Name = "textBoxSE2";
            this.textBoxSE2.ReadOnly = true;
            this.textBoxSE2.Size = new System.Drawing.Size(52, 23);
            this.textBoxSE2.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBoxSE2, "Root Mean Squred Error of All Points");
            // 
            // buttonDrawBs
            // 
            this.buttonDrawBs.Location = new System.Drawing.Point(133, 17);
            this.buttonDrawBs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawBs.Name = "buttonDrawBs";
            this.buttonDrawBs.Size = new System.Drawing.Size(107, 21);
            this.buttonDrawBs.TabIndex = 13;
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
            this.buttonPlotCurve.TabIndex = 3;
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
            this.comboBoxX.TabIndex = 1;
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
            this.comboBoxY.TabIndex = 2;
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
            this.groupBoxPoints.Controls.Add(this.buttonAddPoint);
            this.groupBoxPoints.Controls.Add(this.textBoxFu);
            this.groupBoxPoints.Controls.Add(this.labelFu);
            this.groupBoxPoints.Controls.Add(this.textBoxU);
            this.groupBoxPoints.Controls.Add(this.labelU);
            this.groupBoxPoints.Location = new System.Drawing.Point(732, 154);
            this.groupBoxPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPoints.Name = "groupBoxPoints";
            this.groupBoxPoints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPoints.Size = new System.Drawing.Size(248, 52);
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
            this.buttonAddPoint.TabIndex = 7;
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
            this.labelU.Text = "u:";
            // 
            // buttonClearGraph
            // 
            this.buttonClearGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearGraph.Location = new System.Drawing.Point(257, 85);
            this.buttonClearGraph.Name = "buttonClearGraph";
            this.buttonClearGraph.Size = new System.Drawing.Size(106, 31);
            this.buttonClearGraph.TabIndex = 4;
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
            this.groupBoxBspline.Location = new System.Drawing.Point(732, 377);
            this.groupBoxBspline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBspline.Name = "groupBoxBspline";
            this.groupBoxBspline.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBspline.Size = new System.Drawing.Size(248, 47);
            this.groupBoxBspline.TabIndex = 15;
            this.groupBoxBspline.TabStop = false;
            this.groupBoxBspline.Text = "B-Spline";
            // 
            // buttonDrawFourier
            // 
            this.buttonDrawFourier.Location = new System.Drawing.Point(5, 20);
            this.buttonDrawFourier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawFourier.Name = "buttonDrawFourier";
            this.buttonDrawFourier.Size = new System.Drawing.Size(109, 21);
            this.buttonDrawFourier.TabIndex = 10;
            this.buttonDrawFourier.Text = "Draw Fourier";
            this.buttonDrawFourier.UseVisualStyleBackColor = true;
            this.buttonDrawFourier.Click += new System.EventHandler(this.buttonDrawFourier_Click);
            // 
            // groupBoxFourier
            // 
            this.groupBoxFourier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFourier.Controls.Add(this.buttonExprFourier);
            this.groupBoxFourier.Controls.Add(this.buttonDrawFourier);
            this.groupBoxFourier.Location = new System.Drawing.Point(732, 322);
            this.groupBoxFourier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFourier.Name = "groupBoxFourier";
            this.groupBoxFourier.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFourier.Size = new System.Drawing.Size(248, 49);
            this.groupBoxFourier.TabIndex = 16;
            this.groupBoxFourier.TabStop = false;
            this.groupBoxFourier.Text = "Fourier";
            // 
            // buttonExprFourier
            // 
            this.buttonExprFourier.Location = new System.Drawing.Point(133, 20);
            this.buttonExprFourier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExprFourier.Name = "buttonExprFourier";
            this.buttonExprFourier.Size = new System.Drawing.Size(109, 21);
            this.buttonExprFourier.TabIndex = 11;
            this.buttonExprFourier.Text = "Expr Fourier";
            this.buttonExprFourier.UseVisualStyleBackColor = true;
            this.buttonExprFourier.Click += new System.EventHandler(this.buttonExprFourier_Click);
            // 
            // labelSamplePoints
            // 
            this.labelSamplePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSamplePoints.AutoSize = true;
            this.labelSamplePoints.Location = new System.Drawing.Point(990, 161);
            this.labelSamplePoints.Name = "labelSamplePoints";
            this.labelSamplePoints.Size = new System.Drawing.Size(82, 15);
            this.labelSamplePoints.TabIndex = 17;
            this.labelSamplePoints.Text = "Sample Points";
            // 
            // groupBoxCubic
            // 
            this.groupBoxCubic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCubic.Controls.Add(this.buttonSetCubic);
            this.groupBoxCubic.Controls.Add(this.labelSE2);
            this.groupBoxCubic.Controls.Add(this.buttonDrawCubic);
            this.groupBoxCubic.Controls.Add(this.textBoxCubicX);
            this.groupBoxCubic.Controls.Add(this.textBoxSE2);
            this.groupBoxCubic.Controls.Add(this.labelCubic);
            this.groupBoxCubic.Controls.Add(this.textBoxSE);
            this.groupBoxCubic.Controls.Add(this.labelSE);
            this.groupBoxCubic.Location = new System.Drawing.Point(732, 217);
            this.groupBoxCubic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCubic.Name = "groupBoxCubic";
            this.groupBoxCubic.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCubic.Size = new System.Drawing.Size(248, 100);
            this.groupBoxCubic.TabIndex = 18;
            this.groupBoxCubic.TabStop = false;
            this.groupBoxCubic.Text = "Cubic Polynomial";
            // 
            // groupBoxIntegration
            // 
            this.groupBoxIntegration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIntegration.Controls.Add(this.comboBoxIntgrGrid);
            this.groupBoxIntegration.Controls.Add(this.labelIntgrGrid);
            this.groupBoxIntegration.Controls.Add(this.buttonIntgr);
            this.groupBoxIntegration.Controls.Add(this.labelIntgrRule);
            this.groupBoxIntegration.Controls.Add(this.comboBoxIntgrMethod);
            this.groupBoxIntegration.Location = new System.Drawing.Point(732, 428);
            this.groupBoxIntegration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIntegration.Name = "groupBoxIntegration";
            this.groupBoxIntegration.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIntegration.Size = new System.Drawing.Size(248, 78);
            this.groupBoxIntegration.TabIndex = 19;
            this.groupBoxIntegration.TabStop = false;
            this.groupBoxIntegration.Text = "Integration";
            // 
            // comboBoxIntgrGrid
            // 
            this.comboBoxIntgrGrid.FormattingEnabled = true;
            this.comboBoxIntgrGrid.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "16",
            "20"});
            this.comboBoxIntgrGrid.Location = new System.Drawing.Point(41, 50);
            this.comboBoxIntgrGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIntgrGrid.Name = "comboBoxIntgrGrid";
            this.comboBoxIntgrGrid.Size = new System.Drawing.Size(74, 23);
            this.comboBoxIntgrGrid.TabIndex = 15;
            // 
            // labelIntgrGrid
            // 
            this.labelIntgrGrid.AutoSize = true;
            this.labelIntgrGrid.Location = new System.Drawing.Point(5, 52);
            this.labelIntgrGrid.Name = "labelIntgrGrid";
            this.labelIntgrGrid.Size = new System.Drawing.Size(32, 15);
            this.labelIntgrGrid.TabIndex = 22;
            this.labelIntgrGrid.Text = "Grid:";
            // 
            // buttonIntgr
            // 
            this.buttonIntgr.Location = new System.Drawing.Point(133, 50);
            this.buttonIntgr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIntgr.Name = "buttonIntgr";
            this.buttonIntgr.Size = new System.Drawing.Size(106, 21);
            this.buttonIntgr.TabIndex = 16;
            this.buttonIntgr.Text = "Integrate";
            this.buttonIntgr.UseVisualStyleBackColor = true;
            this.buttonIntgr.Click += new System.EventHandler(this.buttonIntgr_Click);
            // 
            // labelIntgrRule
            // 
            this.labelIntgrRule.AutoSize = true;
            this.labelIntgrRule.Location = new System.Drawing.Point(5, 22);
            this.labelIntgrRule.Name = "labelIntgrRule";
            this.labelIntgrRule.Size = new System.Drawing.Size(33, 15);
            this.labelIntgrRule.TabIndex = 1;
            this.labelIntgrRule.Text = "Rule:";
            // 
            // comboBoxIntgrMethod
            // 
            this.comboBoxIntgrMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIntgrMethod.FormattingEnabled = true;
            this.comboBoxIntgrMethod.Items.AddRange(new object[] {
            "CompositeTrapezoidal",
            "Composite Simpson",
            "Gaussian Quadrature"});
            this.comboBoxIntgrMethod.Location = new System.Drawing.Point(41, 20);
            this.comboBoxIntgrMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIntgrMethod.Name = "comboBoxIntgrMethod";
            this.comboBoxIntgrMethod.Size = new System.Drawing.Size(198, 23);
            this.comboBoxIntgrMethod.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1112, 540);
            this.Controls.Add(this.groupBoxIntegration);
            this.Controls.Add(this.groupBoxCubic);
            this.Controls.Add(this.labelSamplePoints);
            this.Controls.Add(this.groupBoxFourier);
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
            this.panel1.PerformLayout();
            this.panelLegend.ResumeLayout(false);
            this.panelExprX.ResumeLayout(false);
            this.panelExprX.PerformLayout();
            this.panelExprY.ResumeLayout(false);
            this.panelExprY.PerformLayout();
            this.groupBoxPoints.ResumeLayout(false);
            this.groupBoxPoints.PerformLayout();
            this.groupBoxExpr.ResumeLayout(false);
            this.groupBoxExpr.PerformLayout();
            this.groupBoxBspline.ResumeLayout(false);
            this.groupBoxFourier.ResumeLayout(false);
            this.groupBoxCubic.ResumeLayout(false);
            this.groupBoxCubic.PerformLayout();
            this.groupBoxIntegration.ResumeLayout(false);
            this.groupBoxIntegration.PerformLayout();
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
        private ToolStripMenuItem bSplineToolStripMenuItem;
        private ToolStripMenuItem saveTargetPointsToolStripMenuItem;
        private ToolStripMenuItem loadTargetPointsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem saveBSplineDataToolStripMenuItem;
        private Button buttonDrawFourier;
        private GroupBox groupBoxFourier;
        private Label labelSamplePoints;
        private GroupBox groupBoxCubic;
        private Button buttonExprFourier;
        private ToolStripMenuItem cubicPolynomialToolStripMenuItem;
        private ToolStripMenuItem fourierToolStripMenuItem;
        private ToolStripMenuItem uniform4PointsToolStripMenuItem;
        private ToolStripMenuItem uniform8PointsToolStripMenuItem;
        private ToolStripMenuItem uniform16PointsToolStripMenuItem;
        private ToolStripMenuItem uniform12PointsToolStripMenuItem;
        private ToolStripMenuItem uniform6PointsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem saveCoefficientsToolStripMenuItem;
        private GroupBox groupBoxIntegration;
        private ComboBox comboBoxIntgrMethod;
        private Label labelIntgrRule;
        private Button buttonIntgr;
        private ComboBox comboBoxIntgrGrid;
        private Label labelIntgrGrid;
        private TextBox textBoxPanel1XY;
        private ToolStripMenuItem integrationToolStripMenuItem;
        private ToolStripMenuItem saveIntegrationResultsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem saveAllGridForAllRulesToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripTextBox toolStripTextBoxIdxH;
        private ToolStripSeparator toolStripSeparator1;
    }
}