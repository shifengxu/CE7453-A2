using CurveLib;
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

        private Graphics _g;
        private CurveCanvas _cc;

        private Timer panel1ResizeTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            _g = this.panel1.CreateGraphics();
            _g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            _cc = new CurveCanvas(panel1.Width, panel1.Height);

            panel1ResizeTimer.Interval = 1000;
            panel1ResizeTimer.Tick += new EventHandler(panel1ResizeTimerTick);
            panel1ResizeTimer.Enabled = false;
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        // ******************************************************************** panel1 resize
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

        private void panel1ResizeTimerTick(object sender, EventArgs e)
        {
            // todo: after resize, re-render the graph
            panel1ResizeTimer.Enabled = false;
            panel1ResizeTimer.Stop();
        }

        private void buttonPlotCurve_Click(object sender, EventArgs e)
        {
            var points = _cc.CalcCurve(1000);

            // draw curve by points
            _g.Clear(Color.White);
            Pen pen4Curve = new Pen(Color.Red, 2);
            int pht = _cc.CanvasHeight;
            int prevCanvasX = points[0].canvasX;
            int prevCanvasY = points[0].canvasY;
            int currCanvasX;
            int currCanvasY;
            for (int i = 1; i < points.Count; i++)
            {
                var p = points[i];
                currCanvasX = p.canvasX;
                currCanvasY = p.canvasY;
                _g.DrawLine(pen4Curve, prevCanvasX, pht - prevCanvasY, currCanvasX, pht - currCanvasY);
                prevCanvasX = currCanvasX;
                prevCanvasY = currCanvasY;
            }

        }
    }
}