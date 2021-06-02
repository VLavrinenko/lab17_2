using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_2
{
    public partial class Form1 : Form
    {
        private Point location = new Point(50, 50);
        private int R = 50;
        Boolean DropStarted = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.DrawEllipse(new Pen(Color.Red, 5), location.X - R, location.Y - R, R, R);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int curX = e.X, curY = e.Y;
            Boolean InX = (curX >= location.X - R && curX <= location.X + R);
            Boolean InY = (curY >= location.Y - R && curY <= location.Y + R);
            if (InX && InY)
                DropStarted = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (DropStarted)
            {
                location.X = e.X + R / 2;
                location.Y = e.Y + R / 2;
                Invalidate();
            }
        }
    }
}
