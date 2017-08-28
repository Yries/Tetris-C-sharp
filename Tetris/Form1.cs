using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {

        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 3);
        PointF Srodek = new PointF(200, 200);
        PointF P1 = new PointF(0, 0);
        PointF P2 = new PointF(0, 0);
        private int[][] TablicaMiejsc;
        private Timer T0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
