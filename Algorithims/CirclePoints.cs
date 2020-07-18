using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims_Practice
{
    public class CirclePoints
    {

        public static bool checkPointInside(Circle circle, int x, int y)
        {
            var distance = getDistanceFromCenter(circle, x, y);
            if (circle.radius >= distance)
            {
                return true;
            }
            return false;
        }

        private static double getDistanceFromCenter(Circle circle, int x, int y)
        {
            var difX = Math.Abs(circle.centerX - x);
            var difY = Math.Abs(circle.centerY - y);
            var dist = Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2));
            return dist;
        }
    }
    public class Circle
    {
        internal int centerX { get; set; }
        internal int centerY { get; set; }
        internal int radius { get; set; }

        public Circle(int centerX, int centerY, int radius)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;

        }


    }

}
