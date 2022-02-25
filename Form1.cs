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
    public double angleDegree; 
    public double angleRadians; 
    
    public Walls(int x, int y, double angle)
    {
        this.x = x;
        this.y = y;
        angleDegree = angle;
        angleRadians = angle * Math.PI / 180.0;
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

        int plot_width = 0, plot_height = 0;
        Graphics graphics;

        /// <returns>Угол в радианах</returns>
        /// <param name="angle">Угол в градусах</param>
        public static double ToRad(double angle) { return angle * Math.PI / 180.0; }

        /// <summary>
        /// Check if point (x, y) lies on a circle with center (h, k) and radius r
        /// </summary>
        /// <param name="x">X coordinate of point</param>
        /// <param name="y">Y coordinate of point</param>
        /// <param name="h">X-center of circle</param>
        /// <param name="k">Y-center of circle</param>
        /// <param name="r">Radius of circle</param>
        /// <returns></returns>
        public static bool IsPointOnCircle(double x, double y, double h, double k, double r) { return (x - h) * (x - h) + (y - k) * (y - k) == r * r; }

        HockeyPuck hockeyPuck;
        Walls leftDown, rightDown, leftUp, rightUp, down;

        public Form1()
        {
            InitializeComponent();
            plot_width = pictureBox1.Width - 1;
            plot_height = pictureBox1.Height - 1;
            graphics = pictureBox1.CreateGraphics();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            hockeyPuck = new HockeyPuck((double)Mass.Value, (double)Radius.Value, (double)Friction.Value, (double)Velocity.Value, (double)ThrowAngle.Value, (double)puckX.Value, (double)puckY.Value);
            leftDown = new Walls(0, (int)TunnelHeight.Value, 90.0); // wall from (0, 0) to (0, height)
            rightDown = new Walls((int)TunnelWidth.Value, (int)TunnelHeight.Value, 90.0); // wall from (width, 0) to (width, height)
            leftUp = new Walls(0, (int)TunnelHeight.Value, (double)TunnelAngle.Value); // tilted wall from (0, height)
            rightUp = new Walls((int)TunnelWidth.Value, (int)TunnelHeight.Value, (double)TunnelAngle.Value); // tilted wall from (width, height)

            double acceleration = -hockeyPuck.friction * g; // a = -µg
            hockeyPuck.SetDirection();

            drawGraph();

            // TODO:
            // 1. Get y range [hockeyPuck.y - hockeyPuck.r; hockeyPuck.y + hockeyPuck.r]
            // 2. With some step check for every y find x:  y = tg(angleWall)*x + tunnelHeight;
            // 3. Check if this point (x, y) if lies on hockeyPuck. WITH SOME EPSILON !!!
            // 4. True => BounceWall & stop checking, False => Keep checking points
            // 5. If all points are checked and no bounce then just let it fly away lol

            while (hockeyPuck.velocity > 0)
            {
                dx = dy = hockeyPuck.velocity * step - acceleration * step * step / 2; // Перемещение шайбы за 1 единицу времени
                distance += Math.Sqrt(dx * dx + dy * dy);
                hockeyPuck.velocity += acceleration / step_reverse; // += because acceleration is negative
                hockeyPuck.x += dx * Math.Cos(hockeyPuck.angleRadians);
                hockeyPuck.y += dy * Math.Sin(hockeyPuck.angleRadians);

                graphics.FillRectangle(new SolidBrush(Color.Red), (float)hockeyPuck.x, (float)(plot_height - hockeyPuck.y), 1, 1);

                // If hockey puck is still in the straight tunnel
                if (hockeyPuck.y + hockeyPuck.radius <= leftDown.y)
                {
                    switch (hockeyPuck.direction)
                    {
                        case DIRECTION.LEFT:
                            if (hockeyPuck.x - hockeyPuck.radius <= leftDown.x) hockeyPuck.BounceWall(leftDown.angleDegree);
                            break;
                        case DIRECTION.RIGHT:
                            if (hockeyPuck.x + hockeyPuck.radius >= rightDown.x) hockeyPuck.BounceWall(rightDown.angleDegree);
                            break;
                        case DIRECTION.UP:
                            break;
                        case DIRECTION.DOWN:
                            break;
                    }
                }

                // else puck in tilted tunnel
            }


            /*if (dx - prevDx < 0 || hockeyPuck.velocity <= 0) { prevDx = 0; distance += dx; }
            prevDx = dx;*/
        }

        private void drawGraph()
        {
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black);

            graphics.DrawLine(pen, new Point(leftDown.x, plot_height), new Point(leftDown.x, plot_height - leftDown.y)); // left straight wall
            graphics.DrawLine(pen, new Point(rightDown.x, plot_height), new Point(rightDown.x, plot_height - rightDown.y)); // right straight wall

            // Left tilted wall
            double tilted_x = leftDown.x + Math.Cos(leftUp.angleRadians) * (plot_width - leftDown.x);
            double tilted_y = leftDown.y - Math.Sin(leftUp.angleRadians) * (plot_height - leftDown.y);
            Point tilted = new Point((int)tilted_x, (int)tilted_y);
            graphics.DrawLine(pen, new Point(leftDown.x, plot_height - leftDown.y), tilted);

            // Right tilted wall
            tilted = new Point((int)(tilted_x + (rightDown.x - leftDown.x)), (int)tilted_y);
            graphics.DrawLine(pen, new Point(rightDown.x, plot_height - rightDown.y), tilted);
        }
    }
}
