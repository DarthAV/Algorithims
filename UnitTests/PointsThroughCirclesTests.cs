using System;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class PointsThroughCirclesTests
    {
        [TestMethod]
        public void BothOutsideCircle()
        {
            var circles = new Circle[] { new Circle(new Point(0, 0), 2) };
            Point startPoint = new Point(3, 8);
            Point endPoint = new Point(3, 5);
            var expectedHops = 0;
            var actualHops = PointsThroughCircles.checkNumberHops(circles, startPoint, endPoint);
            Assert.IsTrue(expectedHops == actualHops);
        }

        [TestMethod]
        public void BothOutsideAroundCircle()
        {
            var circles = new Circle[] { new Circle(new Point(0, 0), 4) };
            Point startPoint = new Point(0, 5);
            Point endPoint = new Point(0, -5);
            var expectedHops = 0;
            var actualHops = PointsThroughCircles.checkNumberHops(circles, startPoint, endPoint);
            Assert.IsTrue(expectedHops == actualHops);
        }

        [TestMethod]
        public void BothInsideCircle()
        {
            var circles = new Circle[] { new Circle(new Point(0, 0), 4) };
            Point startPoint = new Point(-1, 2);
            Point endPoint = new Point(1, -1);
            var expectedHops = 0;
            var actualHops = PointsThroughCircles.checkNumberHops(circles, startPoint, endPoint);
            Assert.IsTrue(expectedHops == actualHops);
        }

        [TestMethod]
        public void OneInsideCircle()
        {
            var circles = new Circle[] { new Circle(new Point(0, 0), 4) };
            Point startPoint = new Point(2, 1);
            Point endPoint = new Point(5, 7);
            var expectedHops = 1;
            var actualHops = PointsThroughCircles.checkNumberHops(circles, startPoint, endPoint);
            Assert.IsTrue(expectedHops == actualHops);
        }


        [TestMethod]
        public void OneOutsideTwoCircles()
        {
            var circles = new Circle[] { new Circle(new Point(0, 0), 8) , new Circle(new Point(0, 0), 6) };
            Point startPoint = new Point(3, 2);
            Point endPoint = new Point(10, 7);
            var expectedHops = 2;
            var actualHops = PointsThroughCircles.checkNumberHops(circles, startPoint, endPoint);
            Assert.IsTrue(expectedHops == actualHops);
        }

        [TestMethod]
        public void OneInsideTwoCirclesOtherInsideOneCircle()
        {
            var circles = new Circle[] { new Circle(new Point(0, 0), 8), new Circle(new Point(0, 0), 3) };
            Point startPoint = new Point(0, 2);
            Point endPoint = new Point(1, 4);
            var expectedHops = 1;
            var actualHops = PointsThroughCircles.checkNumberHops(circles, startPoint, endPoint);
            Assert.IsTrue(expectedHops == actualHops);
        }
    }
}
