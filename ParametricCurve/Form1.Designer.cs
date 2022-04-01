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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.buttonYScale = new System.Windows.Forms.Button();
            this.buttonXScale = new System.Windows.Forms.Button();
            this.textBoxYScale = new System.Windows.Forms.TextBox();
            this.textBoxXScale = new System.Windows.Forms.TextBox();
            this.labelYScale = new System.Windows.Forms.Label();
            this.labelXScale = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonPlotCurve = new System.Windows.Forms.Button();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.panelExprX = new System.Windows.Forms.Panel();
            this.panelExprY = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1249, 26);
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
            this.menuStrip1.Size = new System.Drawing.Size(1249, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
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
            this.panel1.Size = new System.Drawing.Size(824, 647);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // panelLegend
            // 
            this.panelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLegend.Controls.Add(this.buttonYScale);
            this.panelLegend.Controls.Add(this.buttonXScale);
            this.panelLegend.Controls.Add(this.textBoxYScale);
            this.panelLegend.Controls.Add(this.textBoxXScale);
            this.panelLegend.Controls.Add(this.labelYScale);
            this.panelLegend.Controls.Add(this.labelXScale);
            this.panelLegend.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelLegend.Location = new System.Drawing.Point(563, -1);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(257, 44);
            this.panelLegend.TabIndex = 0;
            // 
            // buttonYScale
            // 
            this.buttonYScale.BackgroundImage = global::ParametricCurve.Properties.Resources.ResizeY;
            this.buttonYScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonYScale.Location = new System.Drawing.Point(44, 6);
            this.buttonYScale.Name = "buttonYScale";
            this.buttonYScale.Size = new System.Drawing.Size(30, 30);
            this.buttonYScale.TabIndex = 16;
            this.toolTip1.SetToolTip(this.buttonYScale, "Zoom on Y-Axis");
            this.buttonYScale.UseVisualStyleBackColor = true;
            this.buttonYScale.Click += new System.EventHandler(this.buttonYScale_Click);
            // 
            // buttonXScale
            // 
            this.buttonXScale.BackgroundImage = global::ParametricCurve.Properties.Resources.ResizeX;
            this.buttonXScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonXScale.Location = new System.Drawing.Point(8, 6);
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
            this.textBoxYScale.Location = new System.Drawing.Point(189, 8);
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
            this.textBoxXScale.Location = new System.Drawing.Point(106, 8);
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
            this.labelYScale.Location = new System.Drawing.Point(166, 11);
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
            this.labelXScale.Location = new System.Drawing.Point(86, 11);
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
            this.labelX.Location = new System.Drawing.Point(842, 53);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 20);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "X:";
            this.toolTip1.SetToolTip(this.labelX, "X-Axis expression");
            // 
            // labelY
            // 
            this.labelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(842, 97);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 20);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "Y:";
            this.toolTip1.SetToolTip(this.labelY, "Y-Axis expression");
            // 
            // buttonPlotCurve
            // 
            this.buttonPlotCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlotCurve.Location = new System.Drawing.Point(1106, 154);
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
            this.comboBoxX.Location = new System.Drawing.Point(867, 50);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(69, 28);
            this.comboBoxX.TabIndex = 6;
            this.comboBoxX.SelectedIndexChanged += new System.EventHandler(this.comboBoxX_SelectedIndexChanged);
            // 
            // comboBoxY
            // 
            this.comboBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Location = new System.Drawing.Point(867, 94);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(69, 28);
            this.comboBoxY.TabIndex = 8;
            this.comboBoxY.SelectedIndexChanged += new System.EventHandler(this.comboBoxY_SelectedIndexChanged);
            // 
            // panelExprX
            // 
            this.panelExprX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExprX.BackgroundImage = global::ParametricCurve.Properties.Resources.CurveX;
            this.panelExprX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelExprX.Location = new System.Drawing.Point(941, 50);
            this.panelExprX.Name = "panelExprX";
            this.panelExprX.Size = new System.Drawing.Size(288, 35);
            this.panelExprX.TabIndex = 10;
            // 
            // panelExprY
            // 
            this.panelExprY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExprY.BackgroundImage = global::ParametricCurve.Properties.Resources.CurveY;
            this.panelExprY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelExprY.Location = new System.Drawing.Point(941, 91);
            this.panelExprY.Name = "panelExprY";
            this.panelExprY.Size = new System.Drawing.Size(288, 35);
            this.panelExprY.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1249, 720);
            this.Controls.Add(this.panelExprY);
            this.Controls.Add(this.panelExprX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.comboBoxX);
            this.Controls.Add(this.buttonPlotCurve);
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
    }
}