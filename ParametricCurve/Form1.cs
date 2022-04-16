using CurveLib;
using System.Globalization;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer;

namespace ParametricCurve
{
    public partial class Form1 : Form
    {
        private string saveBsTargetPointsPath = "C:\\";
        private string saveSamplePointsPath = "C:\\";
        private string saveCubicPolynomialPath = "C:\\";

        // configs, like saveBsTargetPointsPath value
        private readonly string initCfgFilePath = ".\\config.cfg";

        private string saveEquationsFilePath = ".\\equations.txt";

        // when draw curve, how many segments to draw.
        private readonly int _panel1SegCount = 1000;

        // Scaling (zoom in/out) related
        private bool _scaleXFlag = false; // if true, means scaling button is clicked and mouse is down.
        private bool _scaleYFlag = false;
        private int _scaleXMouseDownValue = 0;
        private int _scaleYMouseDownValue = 0;

        private bool _moveGraphFlag = false; // if true, means moving button is clicked and mouse is down.
        private int _moveGraphMouseDownValueX = 0;
        private int _moveGraphMouseDownValueY = 0;

        // B-Spline
        private bool _bsplineSelectFlag = false;
        private BsplineAdapter _bspline = new BsplineAdapter();

        // Fourier
        private FourierEngine _fourierEngine = new FourierEngine("Temp");

        // Integration
        private IntegrationEngine _intgrEngine = new IntegrationEngine();

        private readonly SolidBrush _brush4SamplePoint = new SolidBrush(Color.Green);
        private readonly Pen[] _pen4CurveArr = new Pen[]
        {
            new Pen(Color.Red, 2), new Pen(Color.Blue, 2), new Pen(Color.Green, 2),
        };

        private Graphics _g;
        private readonly CurveCanvas _cc;

        private List<(double X, double Y)> _curvePoints = new List<(double X, double Y)>();

        // about sample points
        private CubicPolynomial _tempCP = new CubicPolynomial("Temp");

        private readonly Timer panel1ResizeTimer = new Timer();
        private readonly Timer panel1InitTimer = new Timer();
        private readonly Timer statusLabelTimer = new Timer();

        private int _panel1CurveCount = 0; // it is 0 before click "plot curve" button.

        public Form1()
        {
            InitializeComponent();
            _g = this.panel1.CreateGraphics();
            _g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            _cc = new CurveCanvas(panel1.Width, panel1.Height);

            panel1ResizeTimer.Interval = 1000;
            panel1ResizeTimer.Tick += new EventHandler(panel1ResizeTimerTick);
            panel1ResizeTimer.Enabled = false;

            statusLabelTimer.Interval = 3000;
            statusLabelTimer.Tick += new EventHandler((o, e) => toolStripStatusLabel1.BackColor = Color.White);
            statusLabelTimer.Enabled = false;

            comboBoxX.Items.Add("x(u)");
            comboBoxX.Items.Add("y(u)");
            comboBoxX.Items.Add("u");
            comboBoxX.SelectedIndex = 0;
            comboBoxY.Items.Add("x(u)");
            comboBoxY.Items.Add("y(u)");
            comboBoxY.Items.Add("u");
            comboBoxY.SelectedIndex = 1;

            comboBoxIntgrMethod.SelectedIndex = 1;
            comboBoxIntgrGrid.SelectedIndex = 3;

            listBoxPoints.OnListChanged += PointListChanged;

            // Dynamic evaluation by string expression, for X and Y coordinate.
            // But it is too slow. So we have to abandon it here.
            //var xExpr = @"double res;
            //            res = 1.5 * System.Math.Sin(6.2 * u - 0.027 * 46);
            //            res = System.Math.Exp(res) + 0.1;
            //            res = 1.5 * res * System.Math.Cos(12.2 * u);
            //            return res;";
            //var yExpr = @"double res;
            //            res = System.Math.Sin(6.2 * u - 0.027 * 46);
            //            res = System.Math.Exp(res) + 0.1;
            //            res = res * System.Math.Sin(12.2 * u);
            //            return res;";
            //textBoxX.Text = Regex.Replace(xExpr, @"\r\n\s+", "\r\n");
            //textBoxY.Text = Regex.Replace(yExpr, @"\r\n\s+", "\r\n");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(this.initCfgFilePath) == false)
                return;
            string[] lines = File.ReadAllLines(this.initCfgFilePath);
            int configCount = 0;
            foreach(string line in lines)
            {
                string l = line.Trim();
                if (l.Length == 0 || l.StartsWith("#"))
                    continue;
                string[] parts = l.Split(new char[] { '=' }, StringSplitOptions.TrimEntries);
                string key = parts[0];
                string val = parts[1];
                switch (key)
                {
                    case "saveBsTargetPointsPath":
                        this.saveBsTargetPointsPath = val;
                        break;
                    case "saveEquationsFilePath":
                        this.saveEquationsFilePath = val;
                        break;
                    case "saveCubicPolynomialPath":
                        this.saveCubicPolynomialPath = val;
                        break;
                    case "saveSamplePointsPath":
                        this.saveSamplePointsPath = val;
                        break;
                    default:
                        this.toolStripStatusLabel1.Text = $"Unknown key {key} from config file {this.initCfgFilePath}";
                        return;
                }
                configCount++;
            }
            this.toolStripStatusLabel1.Text = $"Initilized {configCount} item(s) from config file {this.initCfgFilePath}";

            panel1InitTimer.Interval = 1000;
            panel1InitTimer.Tick += new EventHandler(panel1InitTimerTick);
            panel1InitTimer.Enabled = true;

            buttonSelectBs.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSelectBs.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSelectBs.TextAlign = ContentAlignment.MiddleRight;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            _g.Dispose();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendFormat("{0} = {1}", "saveBsTargetPointsPath", this.saveBsTargetPointsPath);
            sb.AppendLine();
            sb.AppendFormat("{0} = {1}", "saveSamplePointsPath", this.saveSamplePointsPath);
            sb.AppendLine();
            sb.AppendFormat("{0} = {1}", "saveEquationsFilePath", this.saveEquationsFilePath);
            sb.AppendLine();
            sb.AppendFormat("{0} = {1}", "saveCubicPolynomialPath", this.saveCubicPolynomialPath);
            sb.AppendLine();
            
            File.WriteAllText(this.initCfgFilePath, sb.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ******************************************************************** panel1
        #region panel1
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            double x2 = _cc.CanvasX2RealX(e.X);
            double y2 = _cc.CanvasY2RealY(_cc.CanvasHeight - e.Y);
            string x2Str = x2.ToString("N3", CultureInfo.InvariantCulture);
            string y2Str = y2.ToString("N3", CultureInfo.InvariantCulture);
            textBoxPanel1XY.Text = $"{x2Str} {y2Str}";

            if (panel1.Cursor == Cursors.Cross)
            {
                if (_panel1CurveCount > 0)
                {
                    // if have plotted curve, just update the "u" textbox.
                    // f(u) will be calculated in textboxU "change" event.
                    textBoxU.Text = $"{x2,5:N3}";
                    textBoxU_TextChanged(sender, e);
                }
                else
                {
                    // if not platted curve, this means canvas is empty.
                    // update both u and f(u) textboxes.
                    textBoxU.Text = $"{x2,5:N3}";
                    textBoxFu.Text = $"{y2,5:N3}";
                }
            }

            ScaleWhenMouseMove(e.X, e.Y);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (_g == null) // when init form, it may call this before init _g.
                return;

            _g.Clear(Color.White);
            _g.Dispose();
            _g = panel1.CreateGraphics();

            /* can not run the following direct. Because it may not render well.
             * Especially when make panel bigger.
             */
            //canvas.RefreshPointCoordinate();
            //this.drawTargetPoints(canvas.targetPoints);
            //this.drawControlPoints(canvas.controlPoints);

            /* Put the rendering task into a timer, and render points after 1 second.
             * The reason is, when panel resizing, the graphics may not render well.
             * And after 1 second, the resize is done. Then we render the points.
             */
            if (panel1ResizeTimer.Enabled)
            {
                panel1ResizeTimer.Enabled = false;
                panel1ResizeTimer.Stop();
            }
            panel1ResizeTimer.Enabled = true;
            panel1ResizeTimer.Start();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_scaleXFlag)
            {
                _scaleXMouseDownValue = e.X;
            }
            if (_scaleYFlag)
            {
                _scaleYMouseDownValue = e.Y;
            }
            if (_moveGraphFlag)
            {
                _moveGraphMouseDownValueX = e.X;
                _moveGraphMouseDownValueY = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            bool needRedraw = false;
            if (_scaleXFlag && _scaleXMouseDownValue != 0)
            {
                var newX = e.X;
                double change = (double)newX / _scaleXMouseDownValue;
                _cc.TargetRatioX *= change;
                _scaleXMouseDownValue = 0;
                needRedraw = true;
            }
            if (_scaleYFlag && _scaleYMouseDownValue != 0)
            {
                var newY = panel1.Height - e.Y;
                var oldY = panel1.Height - _scaleYMouseDownValue;
                double change = (double)newY / oldY;
                _cc.TargetRatioY *= change;
                _scaleYMouseDownValue = 0;
                needRedraw = true;
            }
            if (_moveGraphFlag && _moveGraphMouseDownValueX != 0)
            {
                var newX = e.X;
                int change = newX - _moveGraphMouseDownValueX;
                _cc.CanvasMarginX += change;
                _moveGraphMouseDownValueX = 0;

                var newY = panel1.Height - e.Y;
                var oldY = panel1.Height - _moveGraphMouseDownValueY;
                change = newY - oldY;
                _cc.CanvasMarginY += change;
                _moveGraphMouseDownValueY = 0;
                needRedraw = true;
            }
            if (needRedraw)
                DrawAll();
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (panel1.Cursor == Cursors.Cross)
            {
                if (_bsplineSelectFlag)
                {
                    AddDrawBsplineTargetPoint(sender, e);
                }
                else
                {
                    buttonAddPoint_Click(sender, e);
                }
            }
        }

        private void panel1ResizeTimerTick(object? sender, EventArgs e)
        {
            // after resize, re-render the graph
            _cc.UpdateSizeMarginRatio(panel1.Width, panel1.Height);
            DrawAll();

            panel1ResizeTimer.Enabled = false;
            panel1ResizeTimer.Stop();
        }

        private void panel1InitTimerTick(object? sender, EventArgs e)
        {
            DrawCoordinateLines();
            panel1InitTimer.Enabled = false;
            panel1InitTimer.Stop();
        }
        #endregion

        // ******************************************************************** select X Y expression and draw curve
        #region select X Y expression and draw curve
        private void buttonPlotCurve_Click(object sender, EventArgs e)
        {
            ResetPanel1OtherButtons();
            string ex = (string)comboBoxX.SelectedItem;
            string ey = (string)comboBoxY.SelectedItem;
            _curvePoints = _cc.CalcCurveByType(ex, ey, _panel1SegCount);

            if (_panel1CurveCount == 0)
            {
                _cc.UpdateSizeMarginRatio(panel1.Width, panel1.Height);
                _g.Clear(Color.White);
                DrawCoordinateLines();
            }
            _panel1CurveCount++;
            DrawCurve();
        }

        private void buttonClearGraph_Click(object sender, EventArgs e)
        {
            ClearAll();
            ResetPanel1OtherButtons();

            _g.Clear(Color.White);
            _panel1CurveCount = 0;
            DrawCoordinateLines();
        }

        private void UpdateExpression(string expr, Panel panel, TextBox textbox)
        {
            if (expr == "x(u)")
            {
                panel.BackgroundImage = Properties.Resources.CurveX;
                textbox.Visible = false;
            }
            else if (expr == "y(u)")
            {
                panel.BackgroundImage = Properties.Resources.CurveY;
                textbox.Visible = false;
            }
            else if (expr == "u")
            {
                panel.BackgroundImage = null;
                textBoxExprCubicX.Visible = true;
                textBoxExprCubicX.Text = "u";
            }
            else if (expr == "cubicX(u)")
            {
                panel.BackgroundImage = null;
                textbox.Visible = true;
                textbox.Text = Utils.GenCubicExpr(_cc.ExpressionCubicX.Coefficients.ToArray());
            }
            else if (expr == "cubicY(u)")
            {
                panel.BackgroundImage = null;
                textbox.Visible = true;
                textbox.Text = Utils.GenCubicExpr(_cc.ExpressionCubicY.Coefficients.ToArray());
            }
            else if (expr == "fourierX(u)")
            {
                panel.BackgroundImage = null;
                textbox.Visible = true;
                textbox.Text = _cc.ExpressionFourierX.GetStringOfAB();
            }
            else if (expr == "fourierY(u)")
            {
                panel.BackgroundImage = null;
                textbox.Visible = true;
                textbox.Text = _cc.ExpressionFourierY.GetStringOfAB();
            }
        }

        private void comboBoxX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string expr = (string)comboBoxX.SelectedItem;
            UpdateExpression(expr, panelExprX, textBoxExprCubicX);
        }

        private void comboBoxY_SelectedIndexChanged(object sender, EventArgs e)
        {
            string expr = (string)comboBoxY.SelectedItem;
            UpdateExpression(expr, panelExprY, textBoxExprCubicY);
        }
        #endregion

        // ******************************************************************** panel1 buttons
        #region panel1 buttons
        private void buttonXScale_Click(object sender, EventArgs e)
        {
            ResetPanel1OtherButtons("scale");

            if (_scaleXFlag == false)
            {
                _scaleXFlag = true;
                buttonXScale.BackgroundImage = Properties.Resources.ResizeX2;
            }
            else
            {
                _scaleXFlag = false;
                buttonXScale.BackgroundImage = Properties.Resources.ResizeX;
            }
            UpdatePanel1Cursor();
        }

        private void buttonYScale_Click(object sender, EventArgs e)
        {
            ResetPanel1OtherButtons("scale");

            if (_scaleYFlag == false)
            {
                _scaleYFlag = true;
                buttonYScale.BackgroundImage = Properties.Resources.ResizeY2;
            }
            else
            {
                _scaleYFlag = false;
                buttonYScale.BackgroundImage = Properties.Resources.ResizeY;
            }
            UpdatePanel1Cursor();
        }

        private void buttonMoveGraph_Click(object sender, EventArgs e)
        {
            ResetPanel1OtherButtons("move");

            if (_moveGraphFlag == true)
            {
                _moveGraphFlag = false;
                buttonMoveGraph.BackgroundImage = Properties.Resources.Hand;
                panel1.Cursor = Cursors.Cross;
            }
            else
            {
                _moveGraphFlag = true;
                buttonMoveGraph.BackgroundImage = Properties.Resources.Hand2;
                panel1.Cursor = Cursors.Hand;
            }
        }

        private void ResetPanel1OtherButtons(string keep = "")
        {
            if (!keep.Contains("move"))
            {
                _moveGraphFlag = false;
                buttonMoveGraph.BackgroundImage = Properties.Resources.Hand;
                panel1.Cursor = Cursors.Cross;
            }
            if (!keep.Contains("scale"))
            {
                buttonXScale.BackgroundImage = Properties.Resources.ResizeX;
                buttonYScale.BackgroundImage = Properties.Resources.ResizeY;
                _scaleXFlag = false;
                _scaleYFlag = false;
                _scaleXMouseDownValue = 0;
                _scaleYMouseDownValue = 0;
                panel1.Cursor = Cursors.Cross;
            }
        }

        private void UpdatePanel1Cursor()
        {
            if (_scaleXFlag == false && _scaleYFlag == false)
            {
                panel1.Cursor = Cursors.Cross;
            }
            else if (_scaleXFlag == true && _scaleYFlag == false)
            {
                panel1.Cursor = Cursors.SizeWE;
            }
            else if (_scaleXFlag == false && _scaleYFlag == true)
            {
                panel1.Cursor = Cursors.SizeNS;
            }
            else
            {
                panel1.Cursor = Cursors.SizeAll;
            }
        }
        #endregion

        // ******************************************************************** Sample points
        #region Sample points
        private void textBoxU_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(textBoxU.Text, out x))
            {
                if (_panel1CurveCount > 0)
                {
                    // If we have plotted curve, we use the Y expression.
                    // Else, do nothing
                    var ey = (string)comboBoxY.SelectedItem;
                    double fu = _cc.CalcValueByType(ey, x);
                    textBoxFu.Text = $"{fu,5:N3}";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = $"Can not parse '{textBoxU.Text}' as double for u value.";
            }
        }

        private void buttonAddPoint_Click(object sender, EventArgs e)
        {
            string strU = textBoxU.Text;
            string strFu = textBoxFu.Text;
            double u, fu;
            if (!double.TryParse(strU, out u))
            {
                MessageBox.Show($"Invalid u value: {strU}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!double.TryParse(strFu, out fu))
            {
                MessageBox.Show($"Invalid f(u) value: {strFu}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //if (_curvePoints == null || _curvePoints.Count == 0)
            //{
            //    MessageBox.Show("Please plot curve first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            //if ((string)comboBoxX.SelectedItem != "u")
            //{
            //    var msg = "The Horizontal axis expression is not \"u\". The point may not plot in the curve." +
            //        "\r\n\r\n Do you continue?";
            //    var res = MessageBox.Show(msg, "Please confirm", MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //    if (res == DialogResult.No)
            //        return;
            //}
            DrawPoint(u, fu);
            listBoxPoints.Add((u, fu));
        }

        private void listBoxPoints_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int sel = listBoxPoints.SelectedIndex;
            if (sel < 0)
            {
                MessageBox.Show("Please select point from point list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            listBoxPoints.RemoveAt(sel);
            DrawAll();
        }

        private void PointListChanged()
        {
            _tempCP.Reset(); // sample points changed, so cubic polynomial obsolete.
            textBoxCubicX.Text = String.Empty;
            textBoxSE.Text = String.Empty;
            textBoxSE2.Text = String.Empty;
        }

        private void buttonDrawCubic_Click(object sender, EventArgs e)
        {
            if (listBoxPoints.Items.Count < 4)
            {
                MessageBox.Show("We need 4 or more points for such operation.",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            var lsq = new LeastSquaresByLU();
            double rmse;
            var res = lsq.GetCubicPolynomial(listBoxPoints.Points, out rmse);
            _tempCP.Coefficients = res.ToList();
            _tempCP.SamplePoints.Clear();
            _tempCP.SamplePoints.AddRange(listBoxPoints.Points);
            _tempCP.RMSE1 = rmse;
            _tempCP.RMSE2 = _tempCP.CalcRmse(_curvePoints);
            textBoxCubicX.Text = Utils.GenCubicExpr(res);
            textBoxSE.Text = Utils.RemoveTrailingZeros($"{_tempCP.RMSE1:N3}");
            textBoxSE2.Text = Utils.RemoveTrailingZeros($"{_tempCP.RMSE2:N3}");

            _g.Clear(Color.White);
            DrawAll();
        }

        private void buttonSetCubic_Click(object sender, EventArgs e)
        {
            if (_tempCP.SamplePoints == null || _tempCP.SamplePoints.Count < 4)
            {
                MessageBox.Show("Please draw cubic polynomial curve first.",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            int hIdx = comboBoxY.SelectedIndex;
            if (hIdx == 0)
            {
                _cc.ExpressionCubicX.CopyFrom(_tempCP);
                var res = AddExpression("cubicX(u)");
                string verb = res > 0 ? "Added" : "Updated";
                string expr = Utils.GenCubicExpr(_cc.ExpressionCubicX.Coefficients.ToArray());
                MessageBox.Show($"{verb} cubicX(u) in expression combobox: \r\n\r\n{expr}",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (hIdx == 1)
            {
                _cc.ExpressionCubicY.CopyFrom(_tempCP);
                var res = AddExpression("cubicY(u)");
                string verb = res > 0 ? "Added" : "Updated";
                string expr = Utils.GenCubicExpr(_cc.ExpressionCubicY.Coefficients.ToArray());
                MessageBox.Show($"{verb} cubicY(u) in expression combobox: \r\n\r\n{expr}",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("V (Vertical) expression should be x(u) or y(u).",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        // ******************************************************************** menu
        #region menu
        private void saveSamplePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = this.saveSamplePointsPath;
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                this.saveSamplePointsPath = sfd.FileName;
            }
            _tempCP.Save(this.saveSamplePointsPath);
        }

        private void loadSamplePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = this.saveSamplePointsPath;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                //Get the path of specified file
                this.saveSamplePointsPath = openFileDialog.FileName;
            }
            _tempCP.Load(this.saveSamplePointsPath);
            textBoxSE.Text = Utils.RemoveTrailingZeros(_tempCP.RMSE1);
            textBoxSE2.Text = Utils.RemoveTrailingZeros(_tempCP.RMSE2);
            textBoxCubicX.Text = Utils.GenCubicExpr(_tempCP.Coefficients);
            listBoxPoints.Clear();
            foreach (var p in _tempCP.SamplePoints)
            {
                listBoxPoints.Add(p);
            }
        }

        private void saveCubicPolynomialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = this.saveCubicPolynomialPath;
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;
                sfd.FileName = "cubic-polynomials.txt";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                this.saveCubicPolynomialPath = sfd.FileName;
            }
            if (_cc.ExpressionCubicX.Coefficients.Count == 0 && _cc.ExpressionCubicY.Coefficients.Count == 0)
            {
                var msg = $"There is no valid data to save. Please add cubic polynomial to expression list." +
                    $" \r\n\r\nHint: press button \"{buttonSetCubic.Text}\"";
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _cc.ExpressionCubicX.Save(saveCubicPolynomialPath, false);
            _cc.ExpressionCubicY.Save(saveCubicPolynomialPath, true);
        }

        private void loadCubicPolynomialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = this.saveCubicPolynomialPath;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                //Get the path of specified file
                this.saveCubicPolynomialPath = openFileDialog.FileName;
            }
            int cnt = 0;
            string detail = "";
            if (_cc.ExpressionCubicX.Load(saveCubicPolynomialPath))
            {
                cnt++;
                detail += $"\r\n\r\n{_cc.ExpressionCubicX.TargetExpression}";
                detail += $"\r\nSample points count: {_cc.ExpressionCubicX.SamplePoints.Count}";
                detail += $"\r\nCoefficients: {Utils.GenCubicExpr(_cc.ExpressionCubicX.Coefficients.ToArray())}";
                AddExpression(_cc.ExpressionCubicX.TargetExpression);
            }
            if (_cc.ExpressionCubicY.Load(saveCubicPolynomialPath))
            {
                cnt++;
                detail += $"\r\n\r\n{_cc.ExpressionCubicY.TargetExpression}";
                detail += $"\r\nSample points count: {_cc.ExpressionCubicY.SamplePoints.Count}";
                detail += $"\r\nCoefficients: {Utils.GenCubicExpr(_cc.ExpressionCubicY.Coefficients.ToArray())}";
                AddExpression(_cc.ExpressionCubicY.TargetExpression);
            }
            MessageBox.Show($"Loaded {cnt} expression(s).{detail}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void useAllPointsAsSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxPoints.Clear();
            string ey = (string)comboBoxY.SelectedItem;
            for (int i = 0; i <= _panel1SegCount; i++)
            {
                double u = (double)i / _panel1SegCount;
                double fu = _cc.CalcValueByType(ey, u);
                listBoxPoints.Add((u, fu));
            }
        }
        #endregion

        // ******************************************************************** B-Spline
        #region B-Spline
        private void buttonSelectBs_Click(object sender, EventArgs e)
        {
            if (_bsplineSelectFlag == false)
            {
                _bsplineSelectFlag = true;
                buttonSelectBs.BackgroundImage = Properties.Resources.Pointer2;
                buttonSelectBs.ForeColor = Color.FromArgb(128, 128, 255);
                buttonSelectBs.Font = new Font(this.Font, FontStyle.Bold);
            }
            else
            {
                _bsplineSelectFlag = false;
                buttonSelectBs.BackgroundImage = Properties.Resources.Pointer;
                buttonSelectBs.ForeColor = Color.Black;
                buttonSelectBs.Font = new Font(this.Font, FontStyle.Regular);
            }
        }

        private void buttonDrawBs_Click(object sender, EventArgs e)
        {
            int minCnt = 10;
            if (listBoxPoints.Items.Count < minCnt)
            {
                var msg = $"BSpline:Better to use {minCnt} target points or more.\r\n\r\nContinue?";
                DialogResult res = MessageBox.Show(msg,
                    "Information",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (res == DialogResult.No)
                {
                    return;
                }
            }
            _bspline.TargetPoints.Clear();
            _bspline.TargetPoints.AddRange(listBoxPoints.Points);
            _bspline.ExpressionIndexX = comboBoxX.SelectedIndex;
            _bspline.ExpressionIndexY = comboBoxY.SelectedIndex;
            _bspline.Run();
            DrawBspline();
        }

        private void saveTargetPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = this.saveBsTargetPointsPath;
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;
                sfd.FileName = "bspline-target-points.txt";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                this.saveBsTargetPointsPath = sfd.FileName;
            }
            _bspline.SaveTargetPoints(this.saveBsTargetPointsPath);
        }

        private void loadTargetPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = this.saveBsTargetPointsPath;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                //Get the path of specified file
                this.saveBsTargetPointsPath = openFileDialog.FileName;
            }
            buttonClearGraph_Click(sender, e);
            _bspline.LoadTargetPoints(this.saveBsTargetPointsPath);
            comboBoxX.SelectedIndex = _bspline.ExpressionIndexX;
            comboBoxY.SelectedIndex = _bspline.ExpressionIndexY;
            listBoxPoints.Clear();
            foreach (var p in _bspline.TargetPoints)
            {
                listBoxPoints.Add(p);
            }
            buttonPlotCurve_Click(sender, e);
            DrawAndLinkPoints(_bspline.TargetPoints);
        }

        private void saveBSplineDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_bspline.TargetPoints.Count == 0 || _bspline.KnotValues.Count == 0)
            {
                MessageBox.Show("B-Spline curve not generated. Please draw it first.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = this.saveBsTargetPointsPath;
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;
                sfd.FileName = "bspline-data.txt";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                this.saveBsTargetPointsPath = sfd.FileName;
            }
            _bspline.Save(this.saveBsTargetPointsPath);
        }

        #endregion

        // ******************************************************************** Fourier
        #region Fourier
        private void buttonDrawFourier_Click(object sender, EventArgs e)
        {
            if (listBoxPoints.Items.Count < 4)
            {
                MessageBox.Show("We need 4 or more points for such operation.",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            _fourierEngine.SetPoints(listBoxPoints.Points);
            _fourierEngine.CalcCoefficients();
            DrawFourier();
        }

        private void AddUniformPoints2SampleList(int n)
        {
            if ((string)comboBoxX.SelectedItem != "u")
            {
                var msg = "The Horizontal axis expression is not \"u\". The point may not plot in the curve.";
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            listBoxPoints.Clear();
            var ey = (string)comboBoxY.SelectedItem;
            for (int i = 0; i < n; i++)
            {
                double u = (double)i / n;
                double fu = _cc.CalcValueByType(ey, u);
                listBoxPoints.Add(u, fu);
            }
            DrawAll();
        }

        private void uniform4PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUniformPoints2SampleList(4);
        }

        private void uniform6PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUniformPoints2SampleList(6);
        }

        private void uniform8PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUniformPoints2SampleList(8);
        }

        private void uniform12PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUniformPoints2SampleList(12);
        }

        private void uniform16PointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUniformPoints2SampleList(16);
        }

        private void buttonExprFourier_Click(object sender, EventArgs e)
        {
            if (_fourierEngine.a == null || _fourierEngine.a.Count < 3)
            {
                MessageBox.Show("Please draw Fourier Trigonometric Interpolation curve first.",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            int hIdx = comboBoxY.SelectedIndex;
            if (hIdx == 0)
            {
                _cc.ExpressionFourierX.CopyFrom(_fourierEngine);
                var res = AddExpression("fourierX(u)");
                string verb = res > 0 ? "Added" : "Updated";
                string expr = _cc.ExpressionFourierX.GetStringOfA();
                expr += "\r\n" + _cc.ExpressionFourierX.GetStringOfB();
                MessageBox.Show($"{verb} fourierX(u) in expression combobox: \r\n\r\n{expr}",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (hIdx == 1)
            {
                _cc.ExpressionFourierY.CopyFrom(_fourierEngine);
                var res = AddExpression("fourierY(u)");
                string verb = res > 0 ? "Added" : "Updated";
                string expr = _cc.ExpressionFourierY.GetStringOfA();
                expr += "\r\n" + _cc.ExpressionFourierY.GetStringOfB();
                MessageBox.Show($"{verb} fourierY(u) in expression combobox: \r\n\r\n{expr}",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("V (Vertical) expression should be x(u) or y(u).",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

        }

        private void saveCoefficientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_cc.ExpressionFourierX.a.Count == 0 && _cc.ExpressionFourierY.b.Count == 0)
            {
                MessageBox.Show("Fourier curve not generated. Please draw it first.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = this.saveBsTargetPointsPath;
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;
                sfd.FileName = "fourier-data.txt";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                this.saveBsTargetPointsPath = sfd.FileName;
            }
            _cc.ExpressionFourierX.Save(this.saveBsTargetPointsPath, false);
            _cc.ExpressionFourierY.Save(this.saveBsTargetPointsPath, true);
        }
        #endregion

        // ******************************************************************** Integration
        #region Ingetration
        private void buttonIntgr_Click(object sender, EventArgs e)
        {
            string msg = String.Empty;
            if (_panel1CurveCount <= 0 || _curvePoints.Count == 0)
            {
                msg = "Please plot curve first.";
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((string)comboBoxX.SelectedItem != "u")
            {
                msg = "The Horizontal axis expression is not \"u\". The integration may not match the curve.";
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int gridCnt;
            string gridStr = comboBoxIntgrGrid.Text;
            if (int.TryParse(gridStr, out gridCnt) == false)
            {
                MessageBox.Show($"Invalid grid value: {comboBoxIntgrGrid.Text}",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (comboBoxIntgrMethod.SelectedIndex == 1 && gridCnt % 2 != 0)
            {
                MessageBox.Show($"grid count should be even number for Simpson's Rule.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            double oriIntgr = IntegrationEngine.ForceIntegration(_curvePoints);
            if (comboBoxIntgrMethod.SelectedIndex == 1) // Composite Simpson
            {
                List<(double X, double Y)> gridPoints = CompositeGridPoints(gridCnt);
                double smpIntgr = _intgrEngine.ByCompositeSimpson(gridPoints);
                msg = $"Origin integration: {oriIntgr:N6};  " +
                    $"Simpson's integration: {smpIntgr:N6};  " +
                    $"Error: {smpIntgr - oriIntgr:N6}";

                DrawIntgrCompositeSimpson(gridPoints);
            }
            else if (comboBoxIntgrMethod.SelectedIndex == 0) // Composite Trapezoidal
            {
                List<(double X, double Y)> gridPoints = CompositeGridPoints(gridCnt);
                double trpIntgr = _intgrEngine.ByCompositeTrapezoid(gridPoints);
                msg = $"Origin integration: {oriIntgr:N6};  " +
                    $"Trapezoid integration: {trpIntgr:N6};  " +
                    $"Error: {trpIntgr - oriIntgr:N6}";

                DrawIntgrCompositeTrapezoid(gridPoints);
            }
            else if (comboBoxIntgrMethod.SelectedIndex == 2) // Gaussian Quadrature
            {
                GaussianQuadratureCoef gqCoef;
                try
                {
                    gqCoef = GaussianQuadratureCoef.Get(gridCnt);
                }catch (ArgumentException ae)
                {
                    MessageBox.Show($"{ae.Message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string exprY = (string)comboBoxY.SelectedItem;
                IntegrationEngine.CalcValue cvd = u => _cc.CalcValueByType(exprY, u);
                List<(double x, double y, double weight)> weightList;
                double minX = 0, maxX = 1;
                double gqIntgr = _intgrEngine.ByGaussianQuadrature(gqCoef, cvd, out weightList, minX, maxX);
                msg = $"Origin integration: {oriIntgr:N6};  " +
                   $"Gaussian Quadrature integration: {gqIntgr:N6};  " +
                   $"Error: {gqIntgr - oriIntgr:N6}";

                DrawIntgrGaussianQuadrature(weightList, minX, maxX);
            }
            UpdateStatusText(msg);
        }

        private void saveAllGridForAllRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((string)comboBoxX.SelectedItem != "u")
            {
                var msg = "The Horizontal axis expression is not \"u\". The integration may not match the curve.";
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = this.saveBsTargetPointsPath;
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;
                sfd.FileName = "integration-of-all-grids-all-rules.txt";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                this.saveBsTargetPointsPath = sfd.FileName;
            }

            double oriIntgr = IntegrationEngine.ForceIntegration(_curvePoints);
            var res = new List<(int gc, double trp, double smp, double gsq)>();
            string exprY = (string)comboBoxY.SelectedItem;
            IntegrationEngine.CalcValue cvd = u => _cc.CalcValueByType(exprY, u);
            List<(double x, double y, double weight)> weightList;
            foreach (var gridItem in comboBoxIntgrGrid.Items)
            {
                string gridStr = (string)gridItem;
                int gridCnt;
                if (int.TryParse(gridStr, out gridCnt) == false)
                    continue;
                string msg = $"Integrating for grid {gridStr}...";
                toolStripStatusLabel1.Text = msg;

                List<(double X, double Y)> gridPoints = CompositeGridPoints(gridCnt);
                var intgrTrp = _intgrEngine.ByCompositeTrapezoid(gridPoints);

                var intgrSmp = _intgrEngine.ByCompositeSimpson(gridPoints);

                double intgrGsq;
                try
                {
                    var gqCoef = GaussianQuadratureCoef.Get(gridCnt);
                    intgrGsq = _intgrEngine.ByGaussianQuadrature(gqCoef, cvd, out weightList, 0, 1);
                }
                catch (ArgumentException)
                {
                    intgrGsq =  -10000; // -10000 means error
                }
                res.Add((gridCnt, intgrTrp, intgrSmp, intgrGsq));
                toolStripStatusLabel1.Text = msg + " Done";
            }//foreach

            using (StreamWriter sw = new StreamWriter(this.saveBsTargetPointsPath))
            {
                sw.WriteLine($"Grid.List.Count: {res.Count}");
                sw.WriteLine();
                sw.WriteLine($"# Force integration on all the {_panel1SegCount} points");
                sw.WriteLine($"oriIntgr: {oriIntgr:N6}");
                sw.WriteLine();
                sw.WriteLine($"exprY: {exprY}");
                sw.WriteLine();
                sw.WriteLine("# Grid | Trapezoidal | Simpson | Gaussian Quadrature");
                sw.WriteLine("Integration.Start");
                foreach (var r in res)
                {
                    sw.WriteLine($"{r.gc,2} | {r.trp,9:N6} | {r.smp,9:N6} | {r.gsq,9:N6}");
                }
                sw.WriteLine("Integration.Ended");

                sw.WriteLine();
                sw.WriteLine("# error of each integrations. It is: interpolated - force");
                sw.WriteLine("# Grid | Trapezoidal | Simpson | Gaussian Quadrature");
                sw.WriteLine("Integration.Error.Start");
                foreach (var r in res)
                {
                    sw.WriteLine($"{r.gc,2} | {r.trp - oriIntgr,9:N6} | {r.smp - oriIntgr,9:N6} | {r.gsq - oriIntgr,9:N6}");
                }
                sw.WriteLine("Integration.Error.Ended");

                sw.WriteLine();
                sw.WriteLine("# absolute error of each integrations. It is: abs(error)");
                sw.WriteLine("# Grid | Trapezoidal | Simpson | Gaussian Quadrature");
                sw.WriteLine("Integration.AbsError.Start");
                foreach (var r in res)
                {
                    var absTrp = Math.Abs(r.trp - oriIntgr);
                    var absSmp = Math.Abs(r.smp - oriIntgr);
                    var absGsq = Math.Abs(r.gsq - oriIntgr);
                    sw.WriteLine($"{r.gc,2} | {absTrp,9:N6} | {absSmp,9:N6} | {absGsq,9:N6}");
                }
                sw.WriteLine("Integration.AbsError.Ended");
            }
            UpdateStatusText($"Saved: {saveBsTargetPointsPath}");
        }
        #endregion

        private void toolStripTextBoxIdxH_TextChanged(object sender, EventArgs e)
        {
            string hStr = toolStripTextBoxIdxH.Text;
            int hInt;
            if (int.TryParse(hStr, out hInt) == false)
            {
                MessageBox.Show($"Invalid h value: '{hStr}'.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (_cc.h == hInt)
            {
                UpdateStatusText($"Index number h not changed, still {hInt}.");
            }
            else
            {
                var oldVal = _cc.h;
                _cc.h = hInt;
                UpdateStatusText($"Index number h has changed from {oldVal} to: {hInt}. " +
                    $"It will take effect when draw graph again.");
            }
        }

    }//class
}