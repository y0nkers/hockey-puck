using System;

namespace hockey_puck
{
    public class HockeyPuck
    {
        public double mass, radius, friction, velocity, angleDegree, angleRadians, x, y;
        public DIRECTION direction = DIRECTION.NONE;
        public bool firstBounce = false;
        public HockeyPuck(double mass, double radius, double friction, double velocity, double throwAngle, double x, double y)
        {
            this.mass = mass;
            this.radius = radius;
            this.friction = friction;
            this.velocity = velocity;
            angleDegree = throwAngle;
            angleRadians = ToRad(throwAngle);
            this.x = x;
            this.y = y;
            SetDirection();
        }

        /// <returns>Angle in radians</returns>
        /// <param name="angle">Angle in degrees</param>
        private double ToRad(double angle) { return angle * Math.PI / 180.0; }

        /// <summary>
        /// Setting movement direction of puck
        /// </summary>
        private void SetDirection()
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

        /// <returns>Wall rebound angle</returns>
        /// <param name="wallAngle">Wall angle(in degrees)</param>
        public void BounceWall(double wallAngle) 
        {
            if (!firstBounce) firstBounce = true;
            angleDegree = (2 * wallAngle - angleDegree) % 360;
            angleRadians = angleDegree * Math.PI / 180.0;
            SetDirection();
        }
    }
}
