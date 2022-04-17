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
            this.expressionXuOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxExprOffsetX = new System.Windows.Forms.ToolStripTextBox();
            this.expressionYuOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxExprOffsetY = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.samplePointsToolStripMenuItem,
            this.cubicPolynomialToolStripMenuItem,
            this.bSplineToolStripMenuItem,
            this.fourierToolStripMenuItem,
            this.integrationToolStripMenuItem});
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
            this.toolStripMenuItem5,
            this.toolStripSeparator1,
            this.expressionXuOffsetToolStripMenuItem,
            this.expressionYuOffsetToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxIdxH});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(288, 26);
            this.toolStripMenuItem5.Text = "Assignment 2 Index number h";
            // 
            // toolStripTextBoxIdxH
            // 
            this.toolStripTextBoxIdxH.Name = "toolStripTextBoxIdxH";
            this.toolStripTextBoxIdxH.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxIdxH.Text = "46";
            this.toolStripTextBoxIdxH.TextChanged += new System.EventHandler(this.toolStripTextBoxIdxH_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // expressionXuOffsetToolStripMenuItem
            // 
            this.expressionXuOffsetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxExprOffsetX});
            this.expressionXuOffsetToolStripMenuItem.Name = "expressionXuOffsetToolStripMenuItem";
            this.expressionXuOffsetToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.expressionXuOffsetToolStripMenuItem.Text = "Expression x(u) Offset";
            // 
            // toolStripTextBoxExprOffsetX
            // 
            this.toolStripTextBoxExprOffsetX.Name = "toolStripTextBoxExprOffsetX";
            this.toolStripTextBoxExprOffsetX.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxExprOffsetX.Text = "0.0";
            this.toolStripTextBoxExprOffsetX.TextChanged += new System.EventHandler(this.toolStripTextBoxExprOffsetX_TextChanged);
            // 
            // expressionYuOffsetToolStripMenuItem
            // 
            this.expressionYuOffsetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxExprOffsetY});
            this.expressionYuOffsetToolStripMenuItem.Name = "expressionYuOffsetToolStripMenuItem";
            this.expressionYuOffsetToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.expressionYuOffsetToolStripMenuItem.Text = "Expression y(u) Offset";
            // 
            // toolStripTextBoxExprOffsetY
            // 
            this.toolStripTextBoxExprOffsetY.Name = "toolStripTextBoxExprOffsetY";
            this.toolStripTextBoxExprOffsetY.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxExprOffsetY.Text = "0.0";
            this.toolStripTextBoxExprOffsetY.TextChanged += new System.EventHandler(this.toolStripTextBoxExprOffsetY_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(285, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
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
            this.samplePointsToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.samplePointsToolStripMenuItem.Text = "Sample Points";
            // 
            // saveSamplePointsToolStripMenuItem
            // 
            this.saveSamplePointsToolStripMenuItem.Name = "saveSamplePointsToolStripMenuItem";
            this.saveSamplePointsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.saveSamplePointsToolStripMenuItem.Text = "Save Sample Points";
            this.saveSamplePointsToolStripMenuItem.Click += new System.EventHandler(this.saveSamplePointsToolStripMenuItem_Click);
            // 
            // loadSamplePointsToolStripMenuItem
            // 
            this.loadSamplePointsToolStripMenuItem.Name = "loadSamplePointsToolStripMenuItem";
            this.loadSamplePointsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.loadSamplePointsToolStripMenuItem.Text = "Load Sample Points";
            this.loadSamplePointsToolStripMenuItem.Click += new System.EventHandler(this.loadSamplePointsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // useAllPointsAsSampleToolStripMenuItem
            // 
            this.useAllPointsAsSampleToolStripMenuItem.Name = "useAllPointsAsSampleToolStripMenuItem";
            this.useAllPointsAsSampleToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.useAllPointsAsSampleToolStripMenuItem.Text = "Use All Points as Sample";
            this.useAllPointsAsSampleToolStripMenuItem.Click += new System.EventHandler(this.useAllPointsAsSampleToolStripMenuItem_Click);
            // 
            // cubicPolynomialToolStripMenuItem
            // 
            this.cubicPolynomialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCubicPolynomialsToolStripMenuItem,
            this.loadCubicPolynomialsToolStripMenuItem});
            this.cubicPolynomialToolStripMenuItem.Name = "cubicPolynomialToolStripMenuItem";
            this.cubicPolynomialToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.cubicPolynomialToolStripMenuItem.Text = "Cubic Polynomial";
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
            // bSplineToolStripMenuItem
            // 
            this.bSplineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTargetPointsToolStripMenuItem,
            this.loadTargetPointsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveBSplineDataToolStripMenuItem});
            this.bSplineToolStripMenuItem.Name = "bSplineToolStripMenuItem";
            this.bSplineToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.bSplineToolStripMenuItem.Text = "B-Spline";
            // 
            // saveTargetPointsToolStripMenuItem
            // 
            this.saveTargetPointsToolStripMenuItem.Name = "saveTargetPointsToolStripMenuItem";
            this.saveTargetPointsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.saveTargetPointsToolStripMenuItem.Text = "Save Target Points";
            this.saveTargetPointsToolStripMenuItem.Click += new System.EventHandler(this.saveTargetPointsToolStripMenuItem_Click);
            // 
            // loadTargetPointsToolStripMenuItem
            // 
            this.loadTargetPointsToolStripMenuItem.Name = "loadTargetPointsToolStripMenuItem";
            this.loadTargetPointsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.loadTargetPointsToolStripMenuItem.Text = "Load Target Points";
            this.loadTargetPointsToolStripMenuItem.Click += new System.EventHandler(this.loadTargetPointsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(216, 6);
            // 
            // saveBSplineDataToolStripMenuItem
            // 
            this.saveBSplineDataToolStripMenuItem.Name = "saveBSplineDataToolStripMenuItem";
            this.saveBSplineDataToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
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
            this.fourierToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.fourierToolStripMenuItem.Text = "Fourier";
            // 
            // uniform4PointsToolStripMenuItem
            // 
            this.uniform4PointsToolStripMenuItem.Name = "uniform4PointsToolStripMenuItem";
            this.uniform4PointsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.uniform4PointsToolStripMenuItem.Text = "Uniform 4 Points";
            this.uniform4PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform4PointsToolStripMenuItem_Click);
            // 
            // uniform6PointsToolStripMenuItem
            // 
            this.uniform6PointsToolStripMenuItem.Name = "uniform6PointsToolStripMenuItem";
            this.uniform6PointsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.uniform6PointsToolStripMenuItem.Text = "Uniform 6 Points";
            this.uniform6PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform6PointsToolStripMenuItem_Click);
            // 
            // uniform8PointsToolStripMenuItem
            // 
            this.uniform8PointsToolStripMenuItem.Name = "uniform8PointsToolStripMenuItem";
            this.uniform8PointsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.uniform8PointsToolStripMenuItem.Text = "Uniform 8 Points";
            this.uniform8PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform8PointsToolStripMenuItem_Click);
            // 
            // uniform12PointsToolStripMenuItem
            // 
            this.uniform12PointsToolStripMenuItem.Name = "uniform12PointsToolStripMenuItem";
            this.uniform12PointsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.uniform12PointsToolStripMenuItem.Text = "Uniform 12 Points";
            this.uniform12PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform12PointsToolStripMenuItem_Click);
            // 
            // uniform16PointsToolStripMenuItem
            // 
            this.uniform16PointsToolStripMenuItem.Name = "uniform16PointsToolStripMenuItem";
            this.uniform16PointsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.uniform16PointsToolStripMenuItem.Text = "Uniform 16 Points";
            this.uniform16PointsToolStripMenuItem.Click += new System.EventHandler(this.uniform16PointsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(206, 6);
            // 
            // saveCoefficientsToolStripMenuItem
            // 
            this.saveCoefficientsToolStripMenuItem.Name = "saveCoefficientsToolStripMenuItem";
            this.saveCoefficientsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
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
            this.integrationToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.integrationToolStripMenuItem.Text = "Integration";
            // 
            // saveIntegrationResultsToolStripMenuItem
            // 
            this.saveIntegrationResultsToolStripMenuItem.Name = "saveIntegrationResultsToolStripMenuItem";
            this.saveIntegrationResultsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.saveIntegrationResultsToolStripMenuItem.Text = "Save Integration Results";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(258, 6);
            // 
            // saveAllGridForAllRulesToolStripMenuItem
            // 
            this.saveAllGridForAllRulesToolStripMenuItem.Name = "saveAllGridForAllRulesToolStripMenuItem";
            this.saveAllGridForAllRulesToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
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
            // textBoxPanel1XY
            // 
            this.textBoxPanel1XY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPanel1XY.BackColor = System.Drawing.Color.White;
            this.textBoxPanel1XY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPanel1XY.Location = new System.Drawing.Point(615, 3);
            this.textBoxPanel1XY.Name = "textBoxPanel1XY";
            this.textBoxPanel1XY.ReadOnly = true;
            this.textBoxPanel1XY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPanel1XY.Size = new System.Drawing.Size(88, 20);
            this.textBoxPanel1XY.TabIndex = 0;
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
            this.panelLegend.Location = new System.Drawing.Point(707, -1);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(119, 45);
            this.panelLegend.TabIndex = 1;
            // 
            // buttonMoveGraph
            // 
            this.buttonMoveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveGraph.BackgroundImage = global::ParametricCurve.Properties.Resources.Hand;
            this.buttonMoveGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMoveGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMoveGraph.Location = new System.Drawing.Point(8, 5);
            this.buttonMoveGraph.Name = "buttonMoveGraph";
            this.buttonMoveGraph.Size = new System.Drawing.Size(30, 29);
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
            this.buttonYScale.Location = new System.Drawing.Point(80, 5);
            this.buttonYScale.Name = "buttonYScale";
            this.buttonYScale.Size = new System.Drawing.Size(30, 29);
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
            this.buttonXScale.Location = new System.Drawing.Point(43, 5);
            this.buttonXScale.Name = "buttonXScale";
            this.buttonXScale.Size = new System.Drawing.Size(30, 29);
            this.buttonXScale.TabIndex = 18;
            this.toolTip1.SetToolTip(this.buttonXScale, "Zoom on X-Axis");
            this.buttonXScale.UseVisualStyleBackColor = true;
            this.buttonXScale.Click += new System.EventHandler(this.buttonXScale_Click);
            // 
            // labelX
            // 
            this.labelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(5, 29);
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
            this.labelY.Location = new System.Drawing.Point(5, 73);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(21, 20);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "V:";
            this.toolTip1.SetToolTip(this.labelY, "Vertical-Axis expression");
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(22, 28);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(51, 27);
            this.textBoxU.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxU, "Value of u");
            this.textBoxU.TextChanged += new System.EventHandler(this.textBoxU_TextChanged);
            // 
            // textBoxFu
            // 
            this.textBoxFu.Location = new System.Drawing.Point(114, 27);
            this.textBoxFu.Name = "textBoxFu";
            this.textBoxFu.Size = new System.Drawing.Size(51, 27);
            this.textBoxFu.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxFu, "Value of u");
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.ItemHeight = 20;
            this.listBoxPoints.Location = new System.Drawing.Point(1131, 241);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(125, 324);
            this.listBoxPoints.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listBoxPoints, "Double click to delete");
            this.listBoxPoints.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPoints_MouseDoubleClick);
            // 
            // textBoxCubicX
            // 
            this.textBoxCubicX.Location = new System.Drawing.Point(72, 27);
            this.textBoxCubicX.Name = "textBoxCubicX";
            this.textBoxCubicX.ReadOnly = true;
            this.textBoxCubicX.Size = new System.Drawing.Size(205, 27);
            this.textBoxCubicX.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxCubicX, "c0 + c1*u + c2*u^2, c3*u^3");
            // 
            // buttonDrawCubic
            // 
            this.buttonDrawCubic.Location = new System.Drawing.Point(6, 92);
            this.buttonDrawCubic.Name = "buttonDrawCubic";
            this.buttonDrawCubic.Size = new System.Drawing.Size(125, 28);
            this.buttonDrawCubic.TabIndex = 8;
            this.buttonDrawCubic.Text = "Draw Cubic";
            this.toolTip1.SetToolTip(this.buttonDrawCubic, "Fit a parametric cubic polynomial");
            this.buttonDrawCubic.UseVisualStyleBackColor = true;
            this.buttonDrawCubic.Click += new System.EventHandler(this.buttonDrawCubic_Click);
            // 
            // textBoxSE
            // 
            this.textBoxSE.Location = new System.Drawing.Point(72, 59);
            this.textBoxSE.Name = "textBoxSE";
            this.textBoxSE.ReadOnly = true;
            this.textBoxSE.Size = new System.Drawing.Size(59, 27);
            this.textBoxSE.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxSE, "Root Mean Squred Error of Sample Points");
            // 
            // buttonSetCubic
            // 
            this.buttonSetCubic.Location = new System.Drawing.Point(152, 92);
            this.buttonSetCubic.Name = "buttonSetCubic";
            this.buttonSetCubic.Size = new System.Drawing.Size(125, 28);
            this.buttonSetCubic.TabIndex = 9;
            this.buttonSetCubic.Text = "Expr Cubic";
            this.toolTip1.SetToolTip(this.buttonSetCubic, "Add parametric cubic polynomial as expression");
            this.buttonSetCubic.UseVisualStyleBackColor = true;
            this.buttonSetCubic.Click += new System.EventHandler(this.buttonSetCubic_Click);
            // 
            // labelSE
            // 
            this.labelSE.AutoSize = true;
            this.labelSE.Location = new System.Drawing.Point(6, 61);
            this.labelSE.Name = "labelSE";
            this.labelSE.Size = new System.Drawing.Size(62, 20);
            this.labelSE.TabIndex = 12;
            this.labelSE.Text = "RMSE 1:";
            this.toolTip1.SetToolTip(this.labelSE, "Root Mean Squred Error of Sample points");
            // 
            // labelCubic
            // 
            this.labelCubic.AutoSize = true;
            this.labelCubic.Location = new System.Drawing.Point(6, 29);
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
            // buttonSelectBs
            // 
            this.buttonSelectBs.BackgroundImage = global::ParametricCurve.Properties.Resources.Pointer;
            this.buttonSelectBs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSelectBs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSelectBs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectBs.Location = new System.Drawing.Point(19, 21);
            this.buttonSelectBs.Name = "buttonSelectBs";
            this.buttonSelectBs.Size = new System.Drawing.Size(112, 29);
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
            this.labelSE2.Location = new System.Drawing.Point(152, 61);
            this.labelSE2.Name = "labelSE2";
            this.labelSE2.Size = new System.Drawing.Size(62, 20);
            this.labelSE2.TabIndex = 15;
            this.labelSE2.Text = "RMSE 2:";
            this.toolTip1.SetToolTip(this.labelSE2, "Root Mean Squred Error of All Points");
            // 
            // textBoxSE2
            // 
            this.textBoxSE2.Location = new System.Drawing.Point(218, 59);
            this.textBoxSE2.Name = "textBoxSE2";
            this.textBoxSE2.ReadOnly = true;
            this.textBoxSE2.Size = new System.Drawing.Size(59, 27);
            this.textBoxSE2.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBoxSE2, "Root Mean Squred Error of All Points");
            // 
            // buttonDrawBs
            // 
            this.buttonDrawBs.Location = new System.Drawing.Point(152, 23);
            this.buttonDrawBs.Name = "buttonDrawBs";
            this.buttonDrawBs.Size = new System.Drawing.Size(122, 28);
            this.buttonDrawBs.TabIndex = 13;
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
            this.comboBoxX.Location = new System.Drawing.Point(26, 27);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(98, 28);
            this.comboBoxX.TabIndex = 1;
            this.comboBoxX.SelectedIndexChanged += new System.EventHandler(this.comboBoxX_SelectedIndexChanged);
            // 
            // comboBoxY
            // 
            this.comboBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Location = new System.Drawing.Point(26, 69);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(98, 28);
            this.comboBoxY.TabIndex = 2;
            this.comboBoxY.SelectedIndexChanged += new System.EventHandler(this.comboBoxY_SelectedIndexChanged);
            // 
            // panelExprX
            // 
            this.panelExprX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExprX.BackgroundImage = global::ParametricCurve.Properties.Resources.CurveX;
            this.panelExprX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelExprX.Controls.Add(this.textBoxExprCubicX);
            this.panelExprX.Location = new System.Drawing.Point(127, 27);
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
            this.groupBoxPoints.Controls.Add(this.buttonAddPoint);
            this.groupBoxPoints.Controls.Add(this.textBoxFu);
            this.groupBoxPoints.Controls.Add(this.labelFu);
            this.groupBoxPoints.Controls.Add(this.textBoxU);
            this.groupBoxPoints.Controls.Add(this.labelU);
            this.groupBoxPoints.Location = new System.Drawing.Point(837, 205);
            this.groupBoxPoints.Name = "groupBoxPoints";
            this.groupBoxPoints.Size = new System.Drawing.Size(283, 69);
            this.groupBoxPoints.TabIndex = 12;
            this.groupBoxPoints.TabStop = false;
            this.groupBoxPoints.Text = "Sampled Points";
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Location = new System.Drawing.Point(178, 27);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(99, 28);
            this.buttonAddPoint.TabIndex = 7;
            this.buttonAddPoint.Text = "Add Point";
            this.buttonAddPoint.UseVisualStyleBackColor = true;
            this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // labelFu
            // 
            this.labelFu.AutoSize = true;
            this.labelFu.Location = new System.Drawing.Point(86, 32);
            this.labelFu.Name = "labelFu";
            this.labelFu.Size = new System.Drawing.Size(35, 20);
            this.labelFu.TabIndex = 2;
            this.labelFu.Text = "f(u):";
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Location = new System.Drawing.Point(5, 31);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(20, 20);
            this.labelU.TabIndex = 8;
            this.labelU.Text = "u:";
            // 
            // buttonClearGraph
            // 
            this.buttonClearGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearGraph.Location = new System.Drawing.Point(294, 113);
            this.buttonClearGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClearGraph.Name = "buttonClearGraph";
            this.buttonClearGraph.Size = new System.Drawing.Size(121, 41);
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
            this.groupBoxExpr.Location = new System.Drawing.Point(837, 29);
            this.groupBoxExpr.Name = "groupBoxExpr";
            this.groupBoxExpr.Size = new System.Drawing.Size(423, 165);
            this.groupBoxExpr.TabIndex = 14;
            this.groupBoxExpr.TabStop = false;
            this.groupBoxExpr.Text = "Expression";
            // 
            // groupBoxBspline
            // 
            this.groupBoxBspline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBspline.Controls.Add(this.buttonSelectBs);
            this.groupBoxBspline.Controls.Add(this.buttonDrawBs);
            this.groupBoxBspline.Location = new System.Drawing.Point(837, 503);
            this.groupBoxBspline.Name = "groupBoxBspline";
            this.groupBoxBspline.Size = new System.Drawing.Size(283, 63);
            this.groupBoxBspline.TabIndex = 15;
            this.groupBoxBspline.TabStop = false;
            this.groupBoxBspline.Text = "B-Spline";
            // 
            // buttonDrawFourier
            // 
            this.buttonDrawFourier.Location = new System.Drawing.Point(6, 27);
            this.buttonDrawFourier.Name = "buttonDrawFourier";
            this.buttonDrawFourier.Size = new System.Drawing.Size(125, 28);
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
            this.groupBoxFourier.Location = new System.Drawing.Point(837, 429);
            this.groupBoxFourier.Name = "groupBoxFourier";
            this.groupBoxFourier.Size = new System.Drawing.Size(283, 65);
            this.groupBoxFourier.TabIndex = 16;
            this.groupBoxFourier.TabStop = false;
            this.groupBoxFourier.Text = "Fourier";
            // 
            // buttonExprFourier
            // 
            this.buttonExprFourier.Location = new System.Drawing.Point(152, 27);
            this.buttonExprFourier.Name = "buttonExprFourier";
            this.buttonExprFourier.Size = new System.Drawing.Size(125, 28);
            this.buttonExprFourier.TabIndex = 11;
            this.buttonExprFourier.Text = "Expr Fourier";
            this.buttonExprFourier.UseVisualStyleBackColor = true;
            this.buttonExprFourier.Click += new System.EventHandler(this.buttonExprFourier_Click);
            // 
            // labelSamplePoints
            // 
            this.labelSamplePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSamplePoints.AutoSize = true;
            this.labelSamplePoints.Location = new System.Drawing.Point(1131, 215);
            this.labelSamplePoints.Name = "labelSamplePoints";
            this.labelSamplePoints.Size = new System.Drawing.Size(102, 20);
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
            this.groupBoxCubic.Location = new System.Drawing.Point(837, 289);
            this.groupBoxCubic.Name = "groupBoxCubic";
            this.groupBoxCubic.Size = new System.Drawing.Size(283, 133);
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
            this.groupBoxIntegration.Location = new System.Drawing.Point(837, 571);
            this.groupBoxIntegration.Name = "groupBoxIntegration";
            this.groupBoxIntegration.Size = new System.Drawing.Size(283, 104);
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
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.comboBoxIntgrGrid.Location = new System.Drawing.Point(47, 67);
            this.comboBoxIntgrGrid.Name = "comboBoxIntgrGrid";
            this.comboBoxIntgrGrid.Size = new System.Drawing.Size(84, 28);
            this.comboBoxIntgrGrid.TabIndex = 15;
            // 
            // labelIntgrGrid
            // 
            this.labelIntgrGrid.AutoSize = true;
            this.labelIntgrGrid.Location = new System.Drawing.Point(6, 69);
            this.labelIntgrGrid.Name = "labelIntgrGrid";
            this.labelIntgrGrid.Size = new System.Drawing.Size(40, 20);
            this.labelIntgrGrid.TabIndex = 22;
            this.labelIntgrGrid.Text = "Grid:";
            // 
            // buttonIntgr
            // 
            this.buttonIntgr.Location = new System.Drawing.Point(152, 67);
            this.buttonIntgr.Name = "buttonIntgr";
            this.buttonIntgr.Size = new System.Drawing.Size(121, 28);
            this.buttonIntgr.TabIndex = 16;
            this.buttonIntgr.Text = "Integrate";
            this.buttonIntgr.UseVisualStyleBackColor = true;
            this.buttonIntgr.Click += new System.EventHandler(this.buttonIntgr_Click);
            // 
            // labelIntgrRule
            // 
            this.labelIntgrRule.AutoSize = true;
            this.labelIntgrRule.Location = new System.Drawing.Point(6, 29);
            this.labelIntgrRule.Name = "labelIntgrRule";
            this.labelIntgrRule.Size = new System.Drawing.Size(41, 20);
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
            this.comboBoxIntgrMethod.Location = new System.Drawing.Point(47, 27);
            this.comboBoxIntgrMethod.Name = "comboBoxIntgrMethod";
            this.comboBoxIntgrMethod.Size = new System.Drawing.Size(226, 28);
            this.comboBoxIntgrMethod.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1271, 720);
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
        private ToolStripMenuItem expressionXuOffsetToolStripMenuItem;
        private ToolStripTextBox toolStripTextBoxExprOffsetX;
        private ToolStripMenuItem expressionYuOffsetToolStripMenuItem;
        private ToolStripTextBox toolStripTextBoxExprOffsetY;
        private ToolStripSeparator toolStripSeparator2;
    }
}