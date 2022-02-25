using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum DIRECTION
{
    LEFT,
    RIGHT,
    UP,
    DOWN,
    NONE
}

public struct Walls
{
    public int x, y;
    public double angle;
    
    public Walls(int x, int y, double angle)
    {
        this.x = x;
        this.y = y;
        this.angle = angle;
    }
}

namespace hockey_puck
{
    public partial class Form1 : Form
    {
        const double g = 9.80665;
        static double step = 0.01;
        static double step_reverse = 1 / step;
        double dx = 0, dy = 0, prevDx = 0, distance = 0;

        /// <returns>Угол в радианах</returns>
        /// <param name="angle">Угол в градусах</param>
        public static double ToRad(double angle) { return angle * Math.PI / 180.0; }

        

        HockeyPuck hockeyPuck;
        Walls leftDown, rightDown, leftUp, rightUp, down;

        private void Button1_Click(object sender, EventArgs e)
        {
            drawGraph();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            label1.Text = Friction.Value.ToString();
            hockeyPuck = new HockeyPuck((double)Mass.Value, (double)Radius.Value, (double)Friction.Value, (double)Velocity.Value, (double)ThrowAngle.Value, 0, 0);
            leftDown = new Walls(0, (int)TunnelHeight.Value, 90); // wall from (0, 0) to (0, height)
            rightDown = new Walls((int)TunnelWidth.Value, (int)TunnelHeight.Value, 90); // wall from (width, 0) to (width, height)
            leftUp = new Walls(0, (int)TunnelHeight.Value, (int)TunnelAngle.Value); // tilted wall from (0, height)
            rightUp = new Walls((int)TunnelWidth.Value, (int)TunnelHeight.Value, (double)TunnelAngle.Value); // tilted wall from (width, height)

            double acceleration = -hockeyPuck.friction * g; // a = -µg
            hockeyPuck.SetDirection();

            int width = pictureBox1.Width - 1;
            int height = pictureBox1.Height - 1;

            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black);

            graphics.DrawLine(pen, new Point(0, height), new Point(0, height - leftDown.y));
            graphics.DrawLine(pen, new Point(rightDown.x, height), new Point(rightDown.x, height - rightDown.y));


            while (hockeyPuck.velocity > 0)
            {
                dx = dy = hockeyPuck.velocity * step - acceleration * step * step / 2; // Перемещение шайбы за 1 единицу времени
                distance = Math.Sqrt(dx * dx + dy * dy);
                hockeyPuck.velocity += acceleration / step_reverse; // += because acceleration is negative
                hockeyPuck.x += dx * Math.Cos(hockeyPuck.angleRadians);
                hockeyPuck.y += dy * Math.Sin(hockeyPuck.angleRadians);

                graphics.FillRectangle(new SolidBrush(Color.Red), (float)hockeyPuck.x, (float)(height - hockeyPuck.y), 1, 1);

                switch (hockeyPuck.direction)
                {
                    case DIRECTION.LEFT:
                        if (hockeyPuck.x - hockeyPuck.radius <= leftDown.x) hockeyPuck.BounceWall(leftDown.angle);
                        break;
                    case DIRECTION.RIGHT:
                        if (hockeyPuck.x + hockeyPuck.radius >= rightDown.x) hockeyPuck.BounceWall(rightDown.angle);
                        break;
                    case DIRECTION.UP:
                        break;
                    case DIRECTION.DOWN:
                        break;
                }

                hockeyPuck.SetDirection();
            }


            /*if (dx - prevDx < 0 || hockeyPuck.velocity <= 0) { prevDx = 0; distance += dx; }
            prevDx = dx;*/
        }

        private void drawGraph()
        {
            int width = pictureBox1.Width - 1;
            int height = pictureBox1.Height - 1;

            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black);

            graphics.DrawLine(pen, new Point(0, height), new Point(0, height - leftDown.y));
            graphics.DrawLine(pen, new Point(rightDown.x, height), new Point(rightDown.x, height - rightDown.y));
        }
    }
}
