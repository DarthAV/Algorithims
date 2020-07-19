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
            var distance = getDistanceFromCenter(circle, point);
            if (circle.Radius >= distance)
            {
                return true;
            }
            return false;
        }

        private static double getDistanceFromCenter(Circle circle, Point point)
        {
            var diffX = circle.Center.X - point.X;
            var diffY = circle.Center.Y - point.Y;
            var dist = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            return dist;
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
