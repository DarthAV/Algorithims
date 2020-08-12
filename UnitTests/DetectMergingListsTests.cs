using System;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DetectMergingListsTests
    {
        [TestMethod]
        public void MatchFirstNode()
        {
            var targetNode = new LinkedListNode<int>(1);
            var list1 = new LinkedList<int>(targetNode);
            list1.AddBack(new LinkedListNode<int>(2));
            list1.AddBack(new LinkedListNode<int>(3));
            list1.AddBack(new LinkedListNode<int>(4));
            var list2 = new LinkedList<int>(targetNode);
            int indexOfMerge = LinkedList<int>.CheckIfMerges(list1, list2);
            int expectedIndex = 0;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }

        [TestMethod]
        public void MatchLastNode()
        {
            var targetNode = new LinkedListNode<int>(4);
            var list1 = new LinkedList<int>(new LinkedListNode<int>(1));
            list1.AddBack(new LinkedListNode<int>(2));
            list1.AddBack(new LinkedListNode<int>(3));
            list1.AddBack(targetNode); 
            var list2 = new LinkedList<int>(new LinkedListNode<int>(1));
            list2.AddBack(new LinkedListNode<int>(2));
            list2.AddBack(new LinkedListNode<int>(3));
            list2.AddBack(targetNode);
            int indexOfMerge = LinkedList<int>.CheckIfMerges(list1, list2);
            int expectedIndex = 3;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }


        [TestMethod]
        public void MatchShort()
        {
            var targetNode = new LinkedListNode<int>(2);
            var list1 = new LinkedList<int>(new LinkedListNode<int>(1));
            list1.AddBack(targetNode);
            list1.AddBack(new LinkedListNode<int>(3));
            list1.AddBack(new LinkedListNode<int>(4));
            var list2 = new LinkedList<int>(new LinkedListNode<int>(1));
            list2.AddBack(targetNode);
            list2.AddBack(new LinkedListNode<int>(3));
            list2.AddBack(new LinkedListNode<int>(4));
            int indexOfMerge = LinkedList<int>.CheckIfMerges(list1, list2);
            int expectedIndex = 1;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }

        [TestMethod]
        public void MatchLong()
        {
            var targetNode = new LinkedListNode<int>(5);
            var list1 = new LinkedList<int>(new LinkedListNode<int>(1));
            list1.AddBack(new LinkedListNode<int>(2));
            list1.AddBack(new LinkedListNode<int>(3));
            list1.AddBack(new LinkedListNode<int>(4));
            list1.AddBack(targetNode);
            list1.AddBack(new LinkedListNode<int>(6));
            list1.AddBack(new LinkedListNode<int>(7));
            list1.AddBack(new LinkedListNode<int>(8));
            var list2 = new LinkedList<int>(new LinkedListNode<int>(1));
            list2.AddBack(new LinkedListNode<int>(2));
            list2.AddBack(new LinkedListNode<int>(3));
            list2.AddBack(new LinkedListNode<int>(4));
            list2.AddBack(targetNode);
            list2.AddBack(new LinkedListNode<int>(6));
            list2.AddBack(new LinkedListNode<int>(7));
            list2.AddBack(new LinkedListNode<int>(8));
            int indexOfMerge = LinkedList<int>.CheckIfMerges(list1, list2);
            int expectedIndex = 4;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }

        [TestMethod]
        public void NoMatchShort()
        {
            var list1 = new LinkedList<int>(new LinkedListNode<int>(1));
            list1.AddBack(new LinkedListNode<int>(2));
            list1.AddBack(new LinkedListNode<int>(3));
            list1.AddBack(new LinkedListNode<int>(4));
            var list2 = new LinkedList<int>(new LinkedListNode<int>(1));
            list2.AddBack(new LinkedListNode<int>(2));
            list2.AddBack(new LinkedListNode<int>(3));
            list2.AddBack(new LinkedListNode<int>(4));
            int indexOfMerge = LinkedList<int>.CheckIfMerges(list1, list2);
            int expectedIndex = -1;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }

        [TestMethod]
        public void NullList()
        {
            int indexOfMerge = LinkedList<int>.CheckIfMerges(null, null);
            int expectedIndex = -1;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }
        [TestMethod]
        public void OneNullList()
        {
            var list1 = new LinkedList<int>(null);
            int indexOfMerge = LinkedList<int>.CheckIfMerges(list1, null);
            int expectedIndex = -1;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }

        [TestMethod]
        public void EmptyList()
        {
            var list1 = new LinkedList<int>(null);
            var list2 = new LinkedList<int>(null);
            int indexOfMerge = LinkedList<int>.CheckIfMerges(list1, list2);
            int expectedIndex = -1;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }

        [TestMethod]
        public void OneEmptyList()
        {
            var list1 = new LinkedList<int>(null);
            var list2 = new LinkedList<int>(new LinkedListNode<int>(1));
            list2.AddBack(new LinkedListNode<int>(2));
            int indexOfMerge = LinkedList<int>.CheckIfMerges(list1, list2);
            int expectedIndex = -1;
            Assert.AreEqual(expectedIndex, indexOfMerge);
        }

    }
}
