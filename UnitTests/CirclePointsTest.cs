using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims_Practice;

namespace UnitTests
{
    [TestClass]
    public class CirclePointsTest
    {
        [TestMethod]
        public void PointInsideCircle()
        {
            var circle = new Circle(new Point(0,0), 5);
            Point point = new Point(3, 2);
            var expected = true;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointOutsideCircle()
        {
            var circle = new Circle(new Point(0, 0), 5);
            Point point = new Point(5, 7);
            var expected = false;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointOnCircle()
        {
            var circle = new Circle(new Point(0, 0), 5);
            Point point = new Point(5, 0);
            var expected = true;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointInsideCircleQuadrant2()
        {
            var circle = new Circle(new Point(0, 0), 5);
            Point point = new Point(-4, -1);
            var expected = true;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointOutsideCircleQuadrant2()
        {
            var circle = new Circle(new Point(0, 0), 5);
            Point point = new Point(-5, -2);
            var expected = false;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointInCircleMaxRadius()
        {
            var circle = new Circle(new Point(0, 0), Int32.MaxValue); ;
            Point point = new Point(Int32.MaxValue, 0);
            var expected = true;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }
        [TestMethod]
        public void PointInCircleMaxPoint()
        {
            var circle = new Circle(new Point(0, 0), 5); ;
            Point point = new Point(Int32.MaxValue, Int32.MaxValue);
            var expected = false;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointOutsideCircle0()
        {
            var circle = new Circle(new Point(0, 0), 0); ;
            Point point = new Point(2, 0);
            var expected = false;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointInCircle0()
        {
            var circle = new Circle(new Point(0, 0), 0); ;
            Point point = new Point(0, 0);
            var expected = true;
            var actual = CirclePoints.checkPointInside(circle, point);
            Assert.IsTrue(expected == actual);
        }
    }
}
