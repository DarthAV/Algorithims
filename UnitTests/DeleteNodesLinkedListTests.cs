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
            var linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            var targetNode = new Node<int>(2);
            linkedList.Add(targetNode);
            linkedList.Add(new Node<int>(3));
            linkedList.Add(new Node<int>(4));
            var expected = new LinkedList<int>();
            expected.Add(new Node<int>(1));
            expected.Add(new Node<int>(2));
            expected.Add(new Node<int>(4));
            LinkedList<int>.DeleteNextNode(targetNode);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void DeleteNodeInList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            linkedList.Add(new Node<int>(2));
            var targetNode = new Node<int>(3);
            linkedList.Add(targetNode);
            linkedList.Add(new Node<int>(4));
            var expected = new LinkedList<int>();
            expected.Add(new Node<int>(1));
            expected.Add(new Node<int>(2));
            expected.Add(new Node<int>(4));
            LinkedList<int>.Delete(linkedList, targetNode);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void DeleteNodeWithoutList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            linkedList.Add(new Node<int>(2));
            var targetNode = new Node<int>(3);
            linkedList.Add(targetNode);
            linkedList.Add(new Node<int>(4));
            var expected = new LinkedList<int>();
            expected.Add(new Node<int>(1));
            expected.Add(new Node<int>(2));
            expected.Add(new Node<int>(4));
            LinkedList<int>.Delete(targetNode);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void DeleteNullNextNodes()
        {
            var linkedList = new LinkedList<int>();
            var expected = new LinkedList<int>();
            LinkedList<int>.DeleteNextNode(new Node<int>(2));
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void DeleteNullNodeInList()
        {
            var linkedList = new LinkedList<int>();
            var expected = new LinkedList<int>();
            LinkedList<int>.Delete(linkedList, new Node<int>(2));
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }
        [TestMethod]
        public void DeleteNullNodeWithoutList()
        {
            var linkedList = new LinkedList<int>();
            var expected = new LinkedList<int>();
            LinkedList<int>.Delete(new Node<int>(2));
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }
    }
}
