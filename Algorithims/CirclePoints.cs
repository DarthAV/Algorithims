using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims_Practice
{
    public class CirclePoints
    {

        public static bool checkPointInside(Circle circle, Point point)
        {
            var distance = getDistanceFromCenter(circle, point);\
            long radius = circle.Radius;
            radius *= radius;
            if (radius >= distance)
            {
                return true;
            }
            return false;
        }

        private static long getDistanceFromCenter(Circle circle, Point point)
        {
            var diffX = circle.Center.X - point.X;
            var diffY = circle.Center.Y - point.Y;
            long distX = diffX;
            distX *= distX;
            long distY = diffY;
            distY *= distY;
            long totalDist = distX + distY;
            return totalDist;
        }
    }

    public class Point
    {
        internal int X { get; }
        internal int Y { get; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public class Circle
    {
        internal Point Center { get; set; }
        internal int Radius { get; set; }

        public Circle(Point center, int radius)
        {
            this.Center = center;
            this.Radius = radius;

        }


    }

}
