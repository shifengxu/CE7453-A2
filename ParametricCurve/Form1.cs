using CurveLib;
using System.Globalization;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer;

namespace ParametricCurve
{
    public partial class Form1 : Form
    {
        private string loadTargetPointsFilePath = "C:\\";
        private string saveTargetPointsFilePath = "C:\\";
        private string saveCtrPointsFilePath = "C:\\";

        // configs, like loadTargetPointsFilePath value
        private readonly string initCfgFilePath = ".\\config.cfg";

        private string saveEquationsFilePath = ".\\equations.txt";

        // Scaling (zoom in/out) related
        private bool _scaleXFlag = false;
        private bool _scaleYFlag = false;
        private int _scaleXMouseDownValue = 0;
        private int _scaleYMouseDownValue = 0;

        private bool _selectPointFlag = false;

        private string _expressionX = "";  // expression of X-axis
        private string _expressionY = "";
        private string[] _expressionList = new string[] { "x(u)", "y(u)", "u" };

        private readonly Brush _brush4SamplePoint = new SolidBrush(Color.Green);

        private Graphics _g;
        private readonly CurveCanvas _cc;
        private List<CurveCanvasPoint>? _curvePoints;
        private List<double> _sampledU = new List<double>();
        private List<double> _sampledFu = new List<double>();

        private readonly Timer panel1ResizeTimer = new Timer();

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
                    case "saveCtrPointsFilePath":
                        this.saveCtrPointsFilePath = val;
                        break;
                    case "saveTargetPointsFilePath":
                        this.saveTargetPointsFilePath = val;
                        break;
                    default:
                        this.toolStripStatusLabel1.Text = $"Unknown key {key} from config file {this.initCfgFilePath}";
                        return;
                }
                configCount++;
            }
            this.toolStripStatusLabel1.Text = $"Initilized {configCount} item(s) from config file {this.initCfgFilePath}";
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            _g.Dispose();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendFormat("{0} = {1}", "loadTargetPointsFilePath", this.loadTargetPointsFilePath);
            sb.AppendLine();
            sb.AppendFormat("{0} = {1}", "saveTargetPointsFilePath", this.saveTargetPointsFilePath);
            sb.AppendLine();
            sb.AppendFormat("{0} = {1}", "saveEquationsFilePath", this.saveEquationsFilePath);
            sb.AppendLine();
            sb.AppendFormat("{0} = {1}", "saveCtrPointsFilePath", this.saveCtrPointsFilePath);
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

            if (_selectPointFlag)
            {
                textBoxU.Text = $"{x2,5:N3}";
                textBoxU_TextChanged(sender, e);
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
            if (needRedraw)
                DrawCurve();
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_selectPointFlag)
            {
                buttonAddPoint_Click(sender, e);
            }
        }

        private void panel1ResizeTimerTick(object? sender, EventArgs e)
        {
            // after resize, re-render the graph
            UpdateCanvasAndDrawCurve();

            panel1ResizeTimer.Enabled = false;
            panel1ResizeTimer.Stop();
        }
        #endregion

        #region select X Y expression and draw curve
        private void buttonPlotCurve_Click(object sender, EventArgs e)
        {
            ResetPanel1Buttons();
            _curvePoints = _cc.CalcCurveByType(_expressionX, _expressionY, 1000);
            UpdateCanvasAndDrawCurve();
        }

        private void comboBoxX_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = comboBoxX.SelectedIndex;
            _expressionX = _expressionList[idx];
            if(idx == 0)
            {
                panelExprX.Visible = true;
                panelExprX.BackgroundImage = Properties.Resources.CurveX;
            }
            else if(idx == 1)
            {
                panelExprX.Visible = true;
                panelExprX.BackgroundImage = Properties.Resources.CurveY;
            }
            else
            {
                panelExprX.Visible = false;
            }
        }

        private void comboBoxY_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = comboBoxY.SelectedIndex;
            _expressionY = _expressionList[idx];
            if (idx == 0)
            {
                panelExprY.Visible = true;
                panelExprY.BackgroundImage = Properties.Resources.CurveX;
            }
            else if (idx == 1)
            {
                panelExprY.Visible = true;
                panelExprY.BackgroundImage = Properties.Resources.CurveY;
            }
            else
            {
                panelExprY.Visible = false;
            }
        }
        #endregion

        #region panel1 buttons
        private void buttonXScale_Click(object sender, EventArgs e)
        {
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

        private void buttonSelectPoint_Click(object sender, EventArgs e)
        {
            if (_selectPointFlag == true)
            {
                _selectPointFlag = false;
                buttonSelectPoint.BackgroundImage = Properties.Resources.Hand;
                panel1.Cursor = Cursors.Cross;
            }
            else
            {
                _selectPointFlag = true;
                buttonSelectPoint.BackgroundImage = Properties.Resources.Hand2;
                panel1.Cursor = Cursors.Hand;
            }
        }

        private void ResetPanel1Buttons()
        {
            _selectPointFlag = false;
            buttonSelectPoint.BackgroundImage = Properties.Resources.Hand;
            panel1.Cursor = Cursors.Cross;

            buttonXScale.BackgroundImage = Properties.Resources.ResizeX;
            buttonYScale.BackgroundImage = Properties.Resources.ResizeY;
            _scaleXFlag = false;
            _scaleYFlag = false;
            _scaleXMouseDownValue = 0;
            _scaleYMouseDownValue = 0;

            UpdatePanel1Cursor();
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

        private void textBoxU_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(textBoxU.Text, out x))
            {
                double fu = _cc.CalcValueByType(_expressionY, x);
                textBoxFu.Text = $"{fu,5:N3}";
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
        }

        private void listBoxPoints_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int sel = listBoxPoints.SelectedIndex;
            listBoxPoints.Items.RemoveAt(sel);
            _sampledU.RemoveAt(sel);
            _sampledFu.RemoveAt(sel);

            _g.Clear(Color.White);
            DrawCurve();
            for(int i = 0; i < _sampledU.Count; i++)
            {
                DrawSamplePoint(_sampledU[i], _sampledFu[i]);
            }
        }
    }
}