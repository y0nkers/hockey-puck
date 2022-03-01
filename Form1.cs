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
        double time = 0;
        float rainbow_color = 0;
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
        /// <param name="eps">Accuracy</param>
        /// <returns></returns>
        public static bool IsPointOnCircle(double x, double y, double h, double k, double r, double eps)
        {
            double  x1 = x - eps, 
                    x2 = x + eps;
            bool    expr1 = (x1 - h) * (x1 - h) + (y - k) * (y - k) <= r * r,
                    expr2 = (x2 - h) * (x2 - h) + (y - k) * (y - k) >= r * r;
            return expr1 && expr2; 
        }

        HockeyPuck hockeyPuck;

        private void button1_Click(object sender, EventArgs e)
        {
            Radius.Value = 1;
            Mass.Value = 1;
            Friction.Value = (decimal)0.1;
            Velocity.Value = 30;
            ThrowAngle.Value = 40;
            TunnelWidth.Value = 100;
            TunnelHeight.Value = 100;
            TunnelAngle.Value = 45;
        }

        Walls leftDown, rightDown, leftUp, rightUp, down;

        public Form1()
        {
            InitializeComponent();

            plot_width = pictureBox1.Width - 1;
            plot_height = pictureBox1.Height - 1;
            TunnelWidth.Maximum = plot_width;
            TunnelHeight.Maximum = plot_height;
            graphics = pictureBox1.CreateGraphics();
        }

        public static Color Rainbow(float progress)
        {
            float div = (Math.Abs(progress % 1) * 6);
            int ascending = (int)((div % 1) * 255);
            int descending = 255 - ascending;

            switch ((int)div)
            {
                case 0:
                    return Color.FromArgb(255, 255, ascending, 0);
                case 1:
                    return Color.FromArgb(255, descending, 255, 0);
                case 2:
                    return Color.FromArgb(255, 0, 255, ascending);
                case 3:
                    return Color.FromArgb(255, 0, descending, 255);
                case 4:
                    return Color.FromArgb(255, ascending, 0, 255);
                default: // case 5:
                    return Color.FromArgb(255, 255, 0, descending);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            labelDistance.Text = "";
            textBoxTrace.Text = "";
            hockeyPuck = new HockeyPuck((double)Mass.Value, (double)Radius.Value, (double)Friction.Value, (double)Velocity.Value, (double)ThrowAngle.Value, (double)puckX.Value, (double)puckY.Value);
            leftDown = new Walls(0, (int)TunnelHeight.Value, 90.0); // wall from (0, 0) to (0, height)
            rightDown = new Walls((int)TunnelWidth.Value, (int)TunnelHeight.Value, 90.0); // wall from (width, 0) to (width, height)
            leftUp = new Walls(0, (int)TunnelHeight.Value, (double)TunnelAngle.Value); // tilted wall from (0, height)
            rightUp = new Walls((int)TunnelWidth.Value, (int)TunnelHeight.Value, (double)TunnelAngle.Value); // tilted wall from (width, height)

            double acceleration = -hockeyPuck.friction * g; // a = -µg
            hockeyPuck.SetDirection();

            drawGraph();

            while (hockeyPuck.velocity > 0)
            {
                string trace = $"x = {hockeyPuck.x}, y = {hockeyPuck.y}, t = {time} \r\n";
                textBoxTrace.AppendText(trace + "\n");
                time += step;
                dx = dy = hockeyPuck.velocity * step - acceleration * step * step / 2; // Перемещение шайбы за 1 единицу времени
                distance += Math.Sqrt(dx * dx + dy * dy);
                hockeyPuck.velocity += acceleration / step_reverse; // += because acceleration is negative
                hockeyPuck.x += dx * Math.Cos(hockeyPuck.angleRadians);
                hockeyPuck.y += dy * Math.Sin(hockeyPuck.angleRadians);

                graphics.FillRectangle(new SolidBrush(Rainbow(rainbow_color += 0.0005f)), (float)hockeyPuck.x, (float)(plot_height - hockeyPuck.y), 1.5f, 1.5f);


                // If hockey puck is still in the straight tunnel
                if (hockeyPuck.y + hockeyPuck.radius <= leftDown.y)
                {
                    if ((hockeyPuck.y - hockeyPuck.radius <= 0) && (hockeyPuck.firstBounce)) 
                        hockeyPuck.BounceWall(180.0);
                    else
                        switch (hockeyPuck.direction)
                        {
                            case DIRECTION.LEFT:
                                if (hockeyPuck.x - hockeyPuck.radius <= leftDown.x) 
                                    hockeyPuck.BounceWall(leftDown.angleDegree);
                                break;
                            case DIRECTION.RIGHT:
                                if (hockeyPuck.x + hockeyPuck.radius >= rightDown.x) 
                                    hockeyPuck.BounceWall(rightDown.angleDegree);
                                break;
                            case DIRECTION.UP:
                                break;
                            case DIRECTION.DOWN:
                                break;
                        }
                }

                // 1. Get y range [hockeyPuck.y - hockeyPuck.r; hockeyPuck.y + hockeyPuck.r]
                // 2. With some step check for every y find x:  y = tg(angleWall)*x + tunnelHeight  =>  x = (y - tunnelHeight) / tg(angleWall)
                // 3. Check if this point (x, y) if lies on hockeyPuck. WITH SOME EPSILON !!!
                // 4. True => BounceWall & stop checking, False => Keep checking points
                // 5. If all points are checked and no bounce then just let it fly away lol

                else
                {
                    bool onCircle = false;
                    double y_min = hockeyPuck.y - hockeyPuck.radius;
                    double y_max = hockeyPuck.y + hockeyPuck.radius;

                    for (var temp_y = y_min; (temp_y + step <= y_max) && (!onCircle); temp_y += step)
                    {
                        double x = (temp_y - leftDown.y) / Math.Tan(leftUp.angleRadians); // doesnt matter left wall or right
                        onCircle = IsPointOnCircle(x, temp_y, hockeyPuck.x, hockeyPuck.y, hockeyPuck.radius, 0.01);
                    }

                    if (onCircle)
                    {
                        switch (hockeyPuck.direction)
                        {
                            case DIRECTION.LEFT:
                                hockeyPuck.BounceWall(leftUp.angleDegree);
                                break;
                            case DIRECTION.RIGHT:
                                hockeyPuck.BounceWall(rightUp.angleDegree);
                                break;
                            case DIRECTION.UP:
                                break;
                            case DIRECTION.DOWN:
                                break;
                        }
                    }
                }

            }

            labelDistance.Text += distance;

            /*if (dx - prevDx < 0 || hockeyPuck.velocity <= 0) { prevDx = 0; distance += dx; }
            prevDx = dx;*/
        }

        private void drawGraph()
        {
            graphics.Clear(Color.DarkSlateGray);
            Pen pen = new Pen(Color.White, 2.0f);

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
