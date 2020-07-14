using System;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InPlaceArrayMergeTests
    {
        [TestMethod]
        public void InPlaceArrayMergeTest()
        {
            var smallArray = new int[] { 1, 9, 10, 15 };
            var bigArray = new int[] { 2, 5, 11, 17, 0, 0, 0, 0 };
            var expected = new int[] { 1, 2, 5, 9, 10, 11, 15, 17 };
            InPlaceArrayMerge.InPlaceMerge(smallArray, bigArray);
            TestUtility.AssertArraysAreEqual(expected, bigArray);
        }

        [TestMethod]
        public void InPlaceArrayMergeTestFirstComplex()
        {
            var smallArray = new int[] { 0, 7, 9, 10, 15 };
            var bigArray = new int[] { 5, 6, 11, 17, 18, 20, 0, 0, 0, 0, 0 };
            var expected = new int[] { 0, 5, 6, 7, 9, 10, 11, 15, 17, 18, 20 };
            InPlaceArrayMerge.InPlaceMerge(smallArray, bigArray);
            TestUtility.AssertArraysAreEqual(expected, bigArray);
        }

        [TestMethod]
        public void InPlaceArrayMergeTestFirstSmaller()
        {
            var smallArray = new int[] { 14 };
            var bigArray = new int[] { 0, 5, 11, 17, 0};
            var expected = new int[] { 0, 5, 11, 14, 17 };
            InPlaceArrayMerge.InPlaceMerge(smallArray, bigArray);
            TestUtility.AssertArraysAreEqual(expected, bigArray);
        }

        [TestMethod]
        public void InPlaceArrayMergeTestSecondSmaller()
        {
            var smallArray = new int[] { 7, 9, 11, 15 };
            var bigArray = new int[] { 19, 0, 0, 0, 0 };
            var expected = new int[] { 7, 9, 11, 15, 19 };
            InPlaceArrayMerge.InPlaceMerge(smallArray, bigArray);
            TestUtility.AssertArraysAreEqual(expected, bigArray);
        }

        [TestMethod]
        public void InPlaceArrayMergeTestWithZeros()
        {
            var smallArray = new int[] { 0, 9, 10, 15 };
            var bigArray = new int[] { 0, 5, 11, 17, 0, 0, 0, 0 };
            var expected = new int[] { 0, 0, 5, 9, 10, 11, 15, 17 };
            InPlaceArrayMerge.InPlaceMerge(smallArray, bigArray);
            TestUtility.AssertArraysAreEqual(expected, bigArray);
        }

        [TestMethod]
        public void InPlaceArrayMergeTestEmpty()
        {
            var smallArray = new int[] { };
            var bigArray = new int[] { };
            var expected = new int[] { };
            InPlaceArrayMerge.InPlaceMerge(smallArray, bigArray);
            TestUtility.AssertArraysAreEqual(expected, bigArray);
        }
    }
}
