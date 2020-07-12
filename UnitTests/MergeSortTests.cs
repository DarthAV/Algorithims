using System;
using System.Collections.Generic;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims_Practice;

namespace UnitTests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void MergeSortTest()
        {
            var mergeSortArray = new int[] { 1, 9, 10, 6, 5, 2, 5, 3, 8 };
            var mergeExpected = new int[] { 1, 2, 3, 5, 5, 6, 8, 9, 10 };
            MergeSort.performMergeSort(mergeSortArray);
            TestUtility.AssertArraysAreEqual(mergeExpected, mergeSortArray);
        }



        [TestMethod]
        public void MergeSortTestEmpty()
        {
            var mergeSortArray = new int[] { };
            var mergeExpected = new int[] { };
            MergeSort.performMergeSort(mergeSortArray);
            TestUtility.AssertArraysAreEqual(mergeExpected, mergeSortArray);
        }
    }
}
