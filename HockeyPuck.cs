using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hockey_puck
{
    public class HockeyPuck
    {
        public double mass, radius, friction, velocity, angleDegree, angleRadians, x, y;
        public DIRECTION direction = DIRECTION.NONE;
        public HockeyPuck(double mass, double radius, double friction, double velocity, double throwAngle, double x, double y)
        {
            this.mass = mass;
            this.radius = radius;
            this.friction = friction;
            this.velocity = velocity;
            angleDegree = throwAngle;
            angleRadians = throwAngle * Math.PI / 180.0;
            this.x = x;
            this.y = y;
        }

        public void SetDirection()
        {
            switch (this.angleDegree)
            {
                case double n when (n < 90.0):
                    this.direction = DIRECTION.RIGHT;
                    break;
                case double n when (n == 90.0):
                    this.direction = DIRECTION.UP;
                    break;
                case double n when (n > 90.0):
                    this.direction = DIRECTION.LEFT;
                    break;
            }
        }

        /// <returns>Угол отскока шайбы от стены</returns>
        /// <param name="wallsAngle">Угол поворота стен (в градусах)</param>
        public void BounceWall(double wallsAngle) 
        { 
            angleDegree = 2 * wallsAngle - angleDegree;
            angleRadians = angleDegree * Math.PI / 180.0;
            SetDirection();
        }
    }
}
