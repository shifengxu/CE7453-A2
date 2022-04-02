using CurveLib;
using System.Globalization;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer;

namespace ParametricCurve
{
    public partial class Form1 : Form
    {
        private string loadTargetPointsFilePath = "C:\\";
        private string saveSamplePointsPath = "C:\\";
        private string saveCubicPolynomialPath = "C:\\";

        // configs, like loadTargetPointsFilePath value
        private readonly string initCfgFilePath = ".\\config.cfg";

        private string saveEquationsFilePath = ".\\equations.txt";

        // when draw curve, how many segments to draw.
        private readonly int _panel1SegCount = 1000;

        // Scaling (zoom in/out) related
        private bool _scaleXFlag = false;
        private bool _scaleYFlag = false;
        private int _scaleXMouseDownValue = 0;
        private int _scaleYMouseDownValue = 0;

        private bool _moveGraphFlag = false;
        private int _moveGraphMouseDownValueX = 0;
        private int _moveGraphMouseDownValueY = 0;

        private string _expressionX = "";  // expression of X-axis
        private string _expressionY = "";

        private readonly Brush _brush4SamplePoint = new SolidBrush(Color.Green);
        private readonly Pen[] _pen4CurveArr = new Pen[]
        {
            new Pen(Color.Red, 2), new Pen(Color.Blue, 2), new Pen(Color.Green, 2),
        };

        private Graphics _g;
        private readonly CurveCanvas _cc;

        // about sample points
        private List<CurveCanvasPoint>? _curvePoints;
        private List<double> _sampledU = new List<double>();
        private List<double> _sampledFu = new List<double>();
        private double[]? _sampledCubic = null;

        private readonly Timer panel1ResizeTimer = new Timer();
        private readonly Timer panel1InitTimer = new Timer();

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

            comboBoxX.Items.Add("x(u)");
            comboBoxX.Items.Add("y(u)");
            comboBoxX.Items.Add("u");
            comboBoxX.SelectedIndex = 0;
            _expressionX = "x(u)";
            comboBoxY.Items.Add("x(u)");
            comboBoxY.Items.Add("y(u)");
            comboBoxY.Items.Add("u");
            comboBoxY.SelectedIndex = 1;
            _expressionY = "y(u)";

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
                    case "loadTargetPointsFilePath":
                        this.loadTargetPointsFilePath = val;
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
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            _g.Dispose();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendFormat("{0} = {1}", "loadTargetPointsFilePath", this.loadTargetPointsFilePath);
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
            string x2Str = x2.ToString("N", CultureInfo.InvariantCulture);
            string y2Str = y2.ToString("N", CultureInfo.InvariantCulture);
            this.toolStripStatusLabel1.Text = $"{x2Str} {y2Str}";

            if (panel1.Cursor == Cursors.Cross)
            {
                if (_panel1CurveCount > 0)
                {
                    textBoxU.Text = $"{x2,5:N3}";
                    textBoxU_TextChanged(sender, e);
                }
                else
                {
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
                buttonAddPoint_Click(sender, e);
            }
        }

        private void panel1ResizeTimerTick(object? sender, EventArgs e)
        {
            // after resize, re-render the graph
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
            listBoxPoints.Items.Clear();
            _sampledU.Clear();
            _sampledFu.Clear();
            _sampledCubic = null;
            textBoxCubicX.Text = String.Empty;
            textBoxSE.Text = String.Empty;

            ResetPanel1OtherButtons();
            _curvePoints = _cc.CalcCurveByType(_expressionX, _expressionY, _panel1SegCount);

            if (_panel1CurveCount == 0)
            {
                _cc.UpdateSizeMarginRatioMinMax(panel1.Width, panel1.Height);
                _g.Clear(Color.White);
                DrawCoordinateLines();
            }
            _panel1CurveCount++;
            DrawCurve();
        }

        private void buttonClearGraph_Click(object sender, EventArgs e)
        {
            _g.Clear(Color.White);
            _panel1CurveCount = 0;
            DrawCoordinateLines();
        }

        private void comboBoxX_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = comboBoxX.SelectedIndex;
            _expressionX = (string)comboBoxX.Items[idx];
            if(idx == 0)
            {
                panelExprX.Visible = true;
                panelExprX.BackgroundImage = Properties.Resources.CurveX;
                textBoxExprCubicX.Visible = false;
            }
            else if(idx == 1)
            {
                panelExprX.Visible = true;
                panelExprX.BackgroundImage = Properties.Resources.CurveY;
                textBoxExprCubicX.Visible = false;
            }
            else if (idx == 2)
            {
                panelExprX.Visible = false;
            }
            else if (idx == 3 || idx == 4)
            {
                panelExprX.Visible = true;
                panelExprX.BackgroundImage = null;
                textBoxExprCubicX.Visible = true;
                if (comboBoxX.SelectedItem.ToString() == "cubicX(u)")
                {
                    textBoxExprCubicX.Text = Utils.GenCubicExpr(_cc.ExpressionCubicX);
                }
                else
                {
                    textBoxExprCubicX.Text = Utils.GenCubicExpr(_cc.ExpressionCubicY);
                }
            }
        }

        private void comboBoxY_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = comboBoxY.SelectedIndex;
            _expressionY = (string)comboBoxY.Items[idx];
            if (idx == 0)
            {
                panelExprY.Visible = true;
                panelExprY.BackgroundImage = Properties.Resources.CurveX;
                textBoxExprCubicY.Visible = false;
            }
            else if (idx == 1)
            {
                panelExprY.Visible = true;
                panelExprY.BackgroundImage = Properties.Resources.CurveY;
                textBoxExprCubicY.Visible = false;
            }
            else if (idx == 2)
            {
                panelExprY.Visible = false;
            }
            else if (idx == 3 || idx == 4)
            {
                panelExprY.Visible = true;
                panelExprY.BackgroundImage = null;
                textBoxExprCubicY.Visible = true;

                if (comboBoxY.SelectedItem.ToString() == "cubicX(u)")
                {
                    textBoxExprCubicY.Text = Utils.GenCubicExpr(_cc.ExpressionCubicX);
                }
                else
                {
                    textBoxExprCubicY.Text = Utils.GenCubicExpr(_cc.ExpressionCubicY);
                }
            }
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
                    double fu = _cc.CalcValueByType(_expressionY, x);
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
                MessageBox.Show($"Invalid u value: {strU}");
                return;
            }
            if (!double.TryParse(strFu, out fu))
            {
                MessageBox.Show($"Invalid f(u) value: {strFu}");
                return;
            }
            _sampledU.Add(u);
            _sampledFu.Add(fu);
            DrawSamplePoint(u, fu);
            listBoxPoints.Items.Add($"{strU}:  {strFu}");
            _sampledCubic = null; // sample points changed, so cubic polynomial obsolete.
            textBoxCubicX.Text = String.Empty;
            textBoxSE.Text = String.Empty;
        }

        private void buttonDeletePoint_Click(object sender, EventArgs e)
        {
            int sel = listBoxPoints.SelectedIndex;
            if (sel < 0)
            {
                MessageBox.Show("Please select point from point list.");
                return;
            }

            listBoxPoints.Items.RemoveAt(sel);
            _sampledU.RemoveAt(sel);
            _sampledFu.RemoveAt(sel);
            _sampledCubic = null; // sample points changed, so cubic polynomial obsolete.
            textBoxCubicX.Text = String.Empty;
            textBoxSE.Text = String.Empty;

            DrawAll();
        }

        private void listBoxPoints_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonDeletePoint_Click(sender, e);
        }

        private void buttonDrawCubic_Click(object sender, EventArgs e)
        {
            if (_sampledU == null || _sampledU.Count < 4)
            {
                MessageBox.Show("We need 4 or more points for such operation.");
                return;
            }
            var lsq = new LeastSquaresByLU();
            double rmse;
            _sampledCubic = lsq.GetCubicPolynomial(_sampledU, _sampledFu, out rmse);
            textBoxCubicX.Text = Utils.GenCubicExpr(_sampledCubic);
            textBoxSE.Text = Utils.RemoveTrailingZeros($"{rmse:N3}");

            DrawCubicPolynomial();
        }

        private void buttonSetCubic_Click(object sender, EventArgs e)
        {
            if (_sampledCubic == null || _sampledCubic.Length < 4)
            {
                MessageBox.Show("Please draw cubic polynomial curve first.");
                return;
            }
            int hIdx = comboBoxY.SelectedIndex;
            if (hIdx == 0)
            {
                _cc.ExpressionCubicX = _sampledCubic;
                var res = AddExpression("cubicX(u)");
                string verb = res > 0 ? "Added" : "Updated";
                string expr = Utils.GenCubicExpr(_cc.ExpressionCubicX);
                MessageBox.Show($"{verb} cubicX(u) in expression combobox: \r\n\r\n{expr}");
            }
            else if (hIdx == 1)
            {
                _cc.ExpressionCubicY = _sampledCubic;
                var res = AddExpression("cubicY(u)");
                string verb = res > 0 ? "Added" : "Updated";
                string expr = Utils.GenCubicExpr(_cc.ExpressionCubicY);
                MessageBox.Show($"{verb} cubicY(u) in expression combobox: \r\n\r\n{expr}");
            }
            else
            {
                MessageBox.Show("H (horizontal) expression should be x(u) or y(u).");
            }
        }
        #endregion

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
            string str1, str2;
            using (StreamWriter sw = new StreamWriter(this.saveSamplePointsPath))
            {
                for (int i = 0; i < _sampledU.Count; i++)
                {
                    str1 = $"{_sampledU[i],5:N3}";
                    str2 = $"{_sampledFu[i],5:N3}";
                    if (str1.EndsWith(".00")) str1 = str1.Replace(".00", "   ");
                    if (str2.EndsWith(".00")) str2 = str2.Replace(".00", "   ");
                    sw.WriteLine($"{str1}  {str2}");
                }
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
            using (StreamWriter sw = new StreamWriter(this.saveCubicPolynomialPath))
            {
                sw.Write("cubicX(u):");
                if (_cc.ExpressionCubicX != null)
                {
                    foreach (var x in _cc.ExpressionCubicX)
                    {
                        sw.Write($" {x:N3}");
                    }
                    sw.WriteLine();
                }
                sw.Write("cubicY(u):");
                if (_cc.ExpressionCubicY != null)
                {
                    foreach (var x in _cc.ExpressionCubicY)
                    {
                        sw.Write($" {x:N3}");
                    }
                    sw.WriteLine();
                }
            } // using
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
            string[] lines = File.ReadAllLines(this.saveCubicPolynomialPath);
            foreach (string line in lines)
            {
                string str = line.Trim();
                if (str.Length == 0 || str.StartsWith("#"))
                    continue;
                if (str.StartsWith("cubicX(u):"))
                {
                    AddExpression("cubicX(u)");
                    string[] strArr = str.Split(":")[1].Trim().Split();
                    _cc.ExpressionCubicX = Array.ConvertAll(strArr, Double.Parse);
                }
                if (str.StartsWith("cubicY(u):"))
                {
                    AddExpression("cubicY(u)");
                    string[] strArr = str.Split(":")[1].Trim().Split();
                    _cc.ExpressionCubicY = Array.ConvertAll(strArr, Double.Parse);
                }
            }
        }
    }
}