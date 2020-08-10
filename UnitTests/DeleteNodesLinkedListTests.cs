using System;
using Algorithims_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DeleteNodesLinkedListTests
    {

        [TestMethod]
        public void DeleteNextNode()
        {
            var linkedList = new LinkedList<int>(new LinkedListNode<int>(1));
            var targetNode = new LinkedListNode<int>(2);
            linkedList.AddBack(targetNode);
            linkedList.AddBack(new LinkedListNode<int>(3));
            linkedList.AddBack(new LinkedListNode<int>(4));
            var expected = new LinkedList<int>(new LinkedListNode<int>(1));
            expected.AddBack(new LinkedListNode<int>(2));
            expected.AddBack(new LinkedListNode<int>(4));
            LinkedList<int>.DeleteNextNode(targetNode);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void DeleteNodeInList()
        {
            var linkedList = new LinkedList<int>(new LinkedListNode<int>(1));
            linkedList.AddBack(new LinkedListNode<int>(2));
            var targetNode = new LinkedListNode<int>(3);
            linkedList.AddBack(targetNode);
            linkedList.AddBack(new LinkedListNode<int>(4));
            var expected = new LinkedList<int>(new LinkedListNode<int>(1));
            expected.AddBack(new LinkedListNode<int>(2));
            expected.AddBack(new LinkedListNode<int>(4));
            LinkedList<int>.Delete(linkedList, targetNode);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void DeleteNodeWithoutList()
        {
            var linkedList = new LinkedList<int>(new LinkedListNode<int>(1));
            linkedList.AddBack(new LinkedListNode<int>(2));
            var targetNode = new LinkedListNode<int>(3);
            linkedList.AddBack(targetNode);
            linkedList.AddBack(new LinkedListNode<int>(4));
            var expected = new LinkedList<int>(new LinkedListNode<int>(1));
            expected.AddBack(new LinkedListNode<int>(2));
            expected.AddBack(new LinkedListNode<int>(4));
            LinkedList<int>.Delete(targetNode);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void DeleteNullNextNodes()
        {
            var linkedList = new LinkedList<int>(null);
            var expected = new LinkedList<int>(null);
            LinkedList<int>.DeleteNextNode(new LinkedListNode<int>(2));
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void DeleteNullNodeInList()
        {
            var linkedList = new LinkedList<int>(null);
            var expected = new LinkedList<int>(null);
            LinkedList<int>.Delete(linkedList, new LinkedListNode<int>(2));
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }
        [TestMethod]
        public void DeleteNullNodeWithoutList()
        {
            var linkedList = new LinkedList<int>(null);
            var expected = new LinkedList<int>(null);
            LinkedList<int>.Delete(new LinkedListNode<int>(2));
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }
    }
}
