using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(
            object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int xc = ClientSize.Width / 2;
            int yc = ClientSize.Height / 2;

            int r = Math.Min(
                ClientSize.Height,
                ClientSize.Width) / 2 - 10;
            int w = 2 * r;
            int h = w;
            int x = xc - r;
            int y = yc - r;
            g.DrawEllipse(Pens.Black, x, y, w, h);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
