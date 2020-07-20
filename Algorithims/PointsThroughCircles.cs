using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims_Practice
{
    public class PointsThroughCircles
    {
        public static int checkNumberHops(Circle[] circles, Point startPoint, Point endPoint)
        {
            int hops = 0;
            for (var i = 0; i < circles.Length; i++)
            {
                if(CirclePoints.checkPointInside(circles[i], startPoint) ^ CirclePoints.checkPointInside(circles[i], endPoint))
                {
                    hops++;
                }
            }
            return hops;
        }

    }
}
