using System;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BinaryTree tree = new BinaryTree();
            tree.DefaultPopulate();
            tree.InorderTraversal();
            tree.PreorderTraversal();
            tree.PostorderTraversal();
        }
    }
}
