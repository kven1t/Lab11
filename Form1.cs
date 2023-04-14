using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Lavender);
            g.DrawEllipse(Pens.Black, 10, 10, 10, 10);
            g.DrawRectangle(Pens.Black, 20, 20, 20, 20);
            g.DrawLine(Pens.Black, 30, 30, 30, 30);

            g.FillRectangle(Brushes.Purple, 40, 40, 40, 40);
            g.FillEllipse(Brushes.Black, 50, 50, 50, 50);

            Brush blueBrush = new SolidBrush(Color.Pink);

            Point points1 = new Point(60, 60);
            Point points2 = new Point(70, 70);
            Point points3 = new Point(80, 80);
            Point points4 = new Point(90, 90);
            Point points5 = new Point(100, 100);
            Point points6 = new Point(110, 110);
            Point points7 = new Point(120, 120);
            Point[] curvePoints = {
                points1,
                points2,
                points3,
                points4,
                points5,
                points6,
                points7
            };

            e.Graphics.FillPolygon(blueBrush, curvePoints);

            Point point1 = new Point(130, 130);
            Point point2 = new Point(140, 140);
            Point point3 = new Point(150, 160);
            Point point4 = new Point(170, 170);
            Point point5 = new Point(180, 180);
            Point point6 = new Point(190, 190);
            Point point7 = new Point(200, 200);
            Point[] points =
            {
                point1,
                point2,
                point3,
                point4,
                point5,
                point6,
                point7

            };
            Pen pen = new Pen(Color.Blue, 5);
            g.DrawPolygon(pen, points);

            Pen pen1 = new Pen(Color.Black, 2);
            pen1.DashStyle = DashStyle.Dash;
            g.DrawLine(pen1, 210, 210, 210, 210);
            pen1.DashStyle = DashStyle.DashDotDot;
            g.DrawEllipse(pen1, 220, 220, 220, 220);
            pen1.DashStyle = DashStyle.Dot;
            g.DrawPie(pen1, 300, 300, 300, 300, 300, 300);
            g.DrawPolygon(pen, new Point[]
            {
                point1,
                point2,
                point3,
                point4,
                point5,
                point6,
                point7
            });
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            g = CreateGraphics();
            switch (e.KeyCode)
            {
                case Keys.A:
                    g.DrawEllipse(Pens.Yellow, 400, 200, 300, 100);
                    break;
                case Keys.B:
                    g.DrawRectangle(Pens.Yellow, 400, 200, 300, 200);
                    break;
                case Keys.Delete:
                    g.Clear(Color.Chartreuse);
                    break;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
