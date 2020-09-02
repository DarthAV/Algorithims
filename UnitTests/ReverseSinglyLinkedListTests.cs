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
            var linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            var expected = new LinkedList<int>();
            expected.Add(new Node<int>(1));
            LinkedList<int>.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void TwoNodes()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            linkedList.Add(new Node<int>(2));
            var expected = new LinkedList<int>();
            expected.Add(new Node<int>(2));
            expected.Add(new Node<int>(1));
            LinkedList<int>.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void ThreeNodes()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            linkedList.Add(new Node<int>(2));
            linkedList.Add(new Node<int>(3));
            var expected = new LinkedList<int>();
            expected.Add(new Node<int>(3));
            expected.Add(new Node<int>(2));
            expected.Add(new Node<int>(1));
            LinkedList<int>.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void FourNodes()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            linkedList.Add(new Node<int>(2));
            linkedList.Add(new Node<int>(3));
            linkedList.Add(new Node<int>(4));
            var expected = new LinkedList<int>();
            expected.Add(new Node<int>(4));
            expected.Add(new Node<int>(3));
            expected.Add(new Node<int>(2));
            expected.Add(new Node<int>(1));
            LinkedList<int>.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void FiveNodes()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(new Node<int>(1));
            linkedList.Add(new Node<int>(2));
            linkedList.Add(new Node<int>(3));
            linkedList.Add(new Node<int>(4));
            linkedList.Add(new Node<int>(5));
            var expected = new LinkedList<int>();
            expected.Add(new Node<int>(5));
            expected.Add(new Node<int>(4));
            expected.Add(new Node<int>(3));
            expected.Add(new Node<int>(2));
            expected.Add(new Node<int>(1));
            LinkedList<int>.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void NullNodes()
        {
            var linkedList = new LinkedList<int>();
            var expected = new LinkedList<int>();
            LinkedList<int>.ReverseLinkedList(linkedList);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }

        [TestMethod]
        public void NullList()
        {
            var linkedList = new LinkedList<int>();
            var expected = new LinkedList<int>();
            LinkedList<int>.ReverseLinkedList(null);
            TestUtility.AssertLinkedListsAreEqual(expected, linkedList);
        }
    }
}
