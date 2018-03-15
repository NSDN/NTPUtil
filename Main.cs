using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NTPUtil
{
    public partial class Main : Form
    {
        Graphics g;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            g = Graphics.FromHwnd(BoxGraph.Handle);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            BoxV.Clear(); BoxP.Clear(); BoxR.Clear();
            BoxLim.Clear(); BoxDist.Clear();
        }

        private bool Parse(TextBox box, out double value)
        {
            if (!double.TryParse(box.Text, out value))
            {
                box.SelectAll(); return false;
            }
            return true;
        }

        private bool Parse(TextBox box, out int value)
        {
            if (!int.TryParse(box.Text, out value))
            {
                box.SelectAll(); return false;
            }
            return true;
        }

        delegate bool State();
        const double MAX = 16777215;

        private double Max(List<double> list)
        {
            double max = 0;
            foreach (double d in list)
                if (max < d) max = d;
            return max;
        }

        private void Calc(State state, TrainPacket packet, double lim, bool high)
        {
            new Task(() =>
            {
                double dist = 0;
                List<double> vels = new List<double>();

                BtnCalc.Invoke(new Action(() => BtnCalc.Enabled = false));
                BtnClear.Invoke(new Action(() => BtnClear.Enabled = false));
                while (state.Invoke())
                {
                    if (high) TrainController.DoMotionWithAirHigh(packet);
                    else TrainController.DoMotionWithAir(packet);
                    dist += packet.Velocity; vels.Add(packet.Velocity);
                    if (dist > MAX)
                    {
                        BoxDist.Invoke(new Action(() => BoxDist.Text = "NULL"));
                        BtnCalc.Invoke(new Action(() => BtnCalc.Enabled = true));
                        BtnClear.Invoke(new Action(() => BtnClear.Enabled = true));
                        return;
                    }
                }
                BtnCalc.Invoke(new Action(() => BtnCalc.Enabled = true));
                BtnClear.Invoke(new Action(() => BtnClear.Enabled = true));

                BoxDist.Invoke(new Action(() => BoxDist.Text = dist.ToString("#.#")));

                double max = Max(vels);
                double step = (double)BoxGraph.Width / (double)vels.Count;
                double scale = (double)BoxGraph.Height / max;
                
                for (int i = 0; i < vels.Count - 1; i++)
                {
                    g.DrawLine(
                        Pens.Black,
                        (float)(i * step), (float)((double)BoxGraph.Height - vels[i] * scale),
                        (float)((i + 1) * step), (float)((double)BoxGraph.Height - vels[i + 1] * scale)
                    );
                }

                vels.Clear();
            }).Start();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            g.Clear(BoxGraph.BackColor);

            if (!Parse(BoxV, out double v)) return;
            if (!Parse(BoxP, out int p)) return;
            if (!Parse(BoxR, out int r)) return;
            if (!Parse(BoxLim, out double lim)) return;
            bool high = BoxHigh.Checked;

            r = 10 - r; r = r < 1 ? 1 : (r > 10 ? 10 : r);

            TrainPacket packet = new TrainPacket(p, r, 1);
            packet.SetVelocity(v);
            
            if (v < lim)
            {
                if (p == 0 || r == 1) return;
                Calc(() => packet.Velocity < lim, packet, lim, high);
            }
            else if (v > lim)
            {
                if (r == 10) packet.R = 1;
                Calc(() => packet.Velocity > lim, packet, lim, high);
            }

        }
    }
}
