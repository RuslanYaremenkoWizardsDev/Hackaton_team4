using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParMath
{
    public partial class CupGridForm : Form
    {
        public CupGridForm()
        {
            InitializeComponent();
        }

        private void CupGridForm_Load(object sender, EventArgs e)
        {

        }

        private void CupGridForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);

            Point point1 = new Point(200, 45);
            Point point2 = new Point(232, 100);
            Point point3 = new Point(200, 155);
            Point point4 = new Point(200, 265);
            Point point5 = new Point(232, 318);
            Point point6 = new Point(200, 370);
            Point point7 = new Point(428, 318);
            Point point8 = new Point(460, 400);
            Point point9 = new Point(200, 480);
            Point point10 = new Point(428, 100);
            Point point11 = new Point(695, 239);
            Point point12 = new Point(657, 400);
            Point point13 = new Point(795, 239);
            Point point14 = new Point(945, 239);

            graphics.DrawLine(pen, point1, point2);
            graphics.DrawLine(pen, point3, point2);
            graphics.DrawLine(pen, point4, point5);
            graphics.DrawLine(pen, point6, point5);
            graphics.DrawLine(pen, point7, point8);
            graphics.DrawLine(pen, point9, point8);
            graphics.DrawLine(pen, point10, point11);
            graphics.DrawLine(pen, point12, point11);
            graphics.DrawLine(pen, point13, point14);
            graphics.Dispose();
        }
    }
}