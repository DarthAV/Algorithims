using System;
using System.Collections.Generic;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TreeTraversalTests
    {
        [TestMethod]
        public void InOrderTest()
        {
            var tree = new BinaryTree();
            tree.DefaultPopulate();
            var inOrder = tree.InorderTraversal();
            var expected = new List<int> { 1, 3, 4, 6, 7, 8, 10, 13, 14 };
            TestUtility.AssertListsAreEqual(expected, inOrder);
        }

        [TestMethod]
        public void PreOrderTest()
        {
            var tree = new BinaryTree();
            tree.DefaultPopulate();
            var preOrder = tree.PreorderTraversal();
            var expected = new List<int> { 8, 3, 1, 6, 4, 7, 10, 14, 13 };
            TestUtility.AssertListsAreEqual(expected, preOrder);
        }

        [TestMethod]
        public void PostOrderTest()
        {
            var tree = new BinaryTree();
            tree.DefaultPopulate();
            var postOrder = tree.PostorderTraversal();
            var expected = new List<int> { 1, 4, 7, 6, 3, 13, 14, 10, 8 };
            TestUtility.AssertListsAreEqual(expected, postOrder);
        }

    }
}
