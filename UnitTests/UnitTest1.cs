using System;
using System.Collections.Generic;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinaryTreeTraversalTest()
        {
            var tree = new BinaryTree();

            tree.DefaultPopulate();
            var inOrder = tree.InorderTraversal();
            var expected = new List<int> { 1, 3, 4, 6, 5, 8, 10, 13, 14 };
            TestUtility.AssertListsAreEqual(expected, inOrder);
            var preOrder = tree.PreorderTraversal();
            TestUtility.AssertListsAreEqual(expected, preOrder);
            var postOrder = tree.PostorderTraversal();
            TestUtility.AssertListsAreEqual(expected, postOrder);
        }
    }
}
