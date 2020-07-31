using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithims_Practice;
namespace UnitTests
{
    [TestClass]
    public class ReverseSinglyLinkedListTests
    {
        [TestMethod]
        public void OneNode()
        {
            var linkedList = new LinkedList<int>(new LinkedListNode<int>(1));
            var expected = new LinkedList<int>(new LinkedListNode<int>(1));
            ReverseSinglyLinkedList.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void ThreeNodes()
        {
            var linkedList = new LinkedList<int>(new LinkedListNode<int>(1));
            linkedList.AddBack(new LinkedListNode<int>(2));
            linkedList.AddBack(new LinkedListNode<int>(3));
            var expected = new LinkedList<int>(new LinkedListNode<int>(1));
            expected.AddFront(new LinkedListNode<int>(2));
            expected.AddFront(new LinkedListNode<int>(3));
            ReverseSinglyLinkedList.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void FourNodes()
        {
            var linkedList = new LinkedList<int>(new LinkedListNode<int>(1));
            linkedList.AddBack(new LinkedListNode<int>(2));
            linkedList.AddBack(new LinkedListNode<int>(3));
            linkedList.AddBack(new LinkedListNode<int>(4));
            var expected = new LinkedList<int>(new LinkedListNode<int>(1));
            expected.AddFront(new LinkedListNode<int>(2));
            expected.AddFront(new LinkedListNode<int>(3));
            expected.AddFront(new LinkedListNode<int>(4));
            ReverseSinglyLinkedList.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void FiveNodes()
        {
            var linkedList = new LinkedList<int>(new LinkedListNode<int>(1));
            linkedList.AddBack(new LinkedListNode<int>(2));
            linkedList.AddBack(new LinkedListNode<int>(3));
            linkedList.AddBack(new LinkedListNode<int>(4));
            linkedList.AddBack(new LinkedListNode<int>(5));
            var expected = new LinkedList<int>(new LinkedListNode<int>(1));
            expected.AddFront(new LinkedListNode<int>(2));
            expected.AddFront(new LinkedListNode<int>(3));
            expected.AddFront(new LinkedListNode<int>(4));
            linkedList.AddBack(new LinkedListNode<int>(5));
            ReverseSinglyLinkedList.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void NullNodes()
        {
            var linkedList = new LinkedList<int>(null);
            var expected = new LinkedList<int>(null);
            ReverseSinglyLinkedList.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }
    }
}
