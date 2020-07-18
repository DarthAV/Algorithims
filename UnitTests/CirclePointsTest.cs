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
            var circle = new Circle(0, 0, 5);
            var pointX = 3;
            var pointY = 2;
            var expected = true;
            var actual = CirclePoints.checkPointInside(circle, pointX, pointY);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointOutsideCircle()
        {
            var circle = new Circle(0, 0, 5);
            var pointX = 5;
            var pointY = 7;
            var expected = false;
            var actual = CirclePoints.checkPointInside(circle, pointX, pointY);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointOnCircle()
        {
            var circle = new Circle(0, 0, 5);
            var pointX = 5;
            var pointY = 0;
            var expected = true;
            var actual = CirclePoints.checkPointInside(circle, pointX, pointY);
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void PointInsideCircleQuadrant2()
        {
            var circle = new Circle(0, 0, 5);
            var pointX = -4;
            var pointY = -1;
            var expected = true;
            var actual = CirclePoints.checkPointInside(circle, pointX, pointY);
            Assert.IsTrue(expected == actual);
        }
        [TestMethod]
        public void PointOutsideCircleQuadrant2()
        {
            var circle = new Circle(0, 0, 5);
            var pointX = -5;
            var pointY = -2;
            var expected = false;
            var actual = CirclePoints.checkPointInside(circle, pointX, pointY);
            Assert.IsTrue(expected == actual);
        }
    }
}
