using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims_Practice;

namespace UnitTests
{
    [TestClass]
    public class DutchFlagSortTests
    {

        [TestMethod]
        public void SortingTwoNumbersPositive()
        {
            var simpleArray = new int[] { 0, 1, 0, 1, 1, 1, 0, 0 };
            var simpleExpected = new int[] { 0, 0, 0, 0, 1, 1, 1, 1 };
            DutchFlagProblem.TwoNumberSort(simpleArray);
            TestUtility.AssertArraysAreEqual(simpleExpected, simpleArray);
        }

        [TestMethod]
        public void SortingTwoNumbersNegative()
        {
            var simpleArray = new int[] { 0, -5, 0, -5, -5, -5, 0, 0 };
            var simpleExpected = new int[] { -5, -5, -5, -5, 0, 0, 0, 0 };
            DutchFlagProblem.TwoNumberSort(simpleArray);
            TestUtility.AssertArraysAreEqual(simpleExpected, simpleArray);
        }

        [TestMethod]
        public void SortingThreeNumbersSimple()
        {
            var complexArray = new int[] { 0, 1, 2, 0, 1, 2, 2, 0, 0, 0 };
            var complexExpected = new int[] { 0, 0, 0, 0, 0, 1, 1, 2, 2, 2 };
            DutchFlagProblem.ThreeNumberSort(complexArray);
            TestUtility.AssertArraysAreEqual(complexExpected, complexArray);
        }

        [TestMethod]
        public void SortingThreeNumbersComplex()
        {
            var complexArray = new int[] { 0, 1, 2, 0, 1, 2, 2, 0, 0, 0, 1, 2, 0, 0, 1, 2 };
            var complexExpected = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2 };
            DutchFlagProblem.ThreeNumberSort(complexArray);
            TestUtility.AssertArraysAreEqual(complexExpected, complexArray);
        }

        [TestMethod]
        public void SortingThreeNumbersEmpty()
        {
            var complexArray = new int[] { };
            var complexExpected = new int[] { };
            DutchFlagProblem.ThreeNumberSort(complexArray);
            TestUtility.AssertArraysAreEqual(complexExpected, complexArray);
        }

    }
}
