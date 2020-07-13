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
        public void InPlaceArrayMergeTestWithZero()
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
