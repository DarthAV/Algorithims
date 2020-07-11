using System;
using System.Collections.Generic;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void BinaryTreeTraversalTest()
        {
            var tree = new BinaryTree();

            tree.DefaultPopulate();
            var inOrder = tree.InorderTraversal();
            var expected = new List<int> { 1, 3, 4, 6, 7, 8, 10, 13, 14 };
            TestUtility.AssertListsAreEqual(expected, inOrder);
            var preOrder = tree.PreorderTraversal();
            expected = new List<int> { 8, 3, 1, 6, 4, 7, 10, 14, 13 };
            TestUtility.AssertListsAreEqual(expected, preOrder);
            var postOrder = tree.PostorderTraversal();
            expected = new List<int> { 1, 4, 7, 6, 3, 13, 14, 10, 8 };
            TestUtility.AssertListsAreEqual(expected, postOrder);

        }

        [TestMethod]
        public void SortingTwoNumbersPositive()
        {
            var simpleArray = new int[] { 0, 1, 0, 1, 1, 1, 0, 0 };
            var simpleExpected = new int[] { 0, 0, 0, 0, 1, 1, 1, 1 };
            DutchFlagProblem.TwoNumberSort(simpleArray);
            TestUtility.AssertArraysAreEqual(simpleExpected, simpleArray);
        }

        [TestMethod]
        public void SortingTwoNumbersPositive2()
        {
            var simpleArray = new int[] { 0, 0, 1, 0, 1, 1, 1, 0, 0 };
            var simpleExpected = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1 };
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
        public void SortingThreeNumbers()
        {
            var complexArray = new int[] { 0, 1, 2, 0, 1, 2, 2, 0, 0, 0 };
            var complexExpected = new int[] { 0, 0, 0, 0, 0, 1, 1, 2, 2, 2 };
            DutchFlagProblem.ThreeNumberSort(complexArray);
            TestUtility.AssertArraysAreEqual(complexExpected, complexArray);
        }

        [TestMethod]
        public void SortingThreeNumbers2()
        {
            var complexArray = new int[] { };
            var complexExpected = new int[] { };
            DutchFlagProblem.ThreeNumberSort(complexArray);
            TestUtility.AssertArraysAreEqual(complexExpected, complexArray);
        }

        [TestMethod]
        public void SortingThreeNumbers3()
        {
            var complexArray = new int[] { 0, 1, 2, 0, 1, 2, 2, 0, 0, 0, 1, 2, 0, 0, 1, 2 };
            var complexExpected = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2 };
            DutchFlagProblem.ThreeNumberSort(complexArray);
            TestUtility.AssertArraysAreEqual(complexExpected, complexArray);
        }

        //[TestMethod]
        //public void MergeSortTest()
        //{

        //    var mergeSortArray = new int[] { 1, 9, 10, 6, 5, 2, 5, 3, 8 };
        //    var mergeExpected = new int[] { 1, 2, 3, 5, 5, 6, 8, 9, 10 };
        //    DutchFlagProblem.MergeSort(mergeSortArray);
        //    TestUtility.AssertArraysAreEqual(mergeExpected, mergeSortArray);
        //}


    }
}
