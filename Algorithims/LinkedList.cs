using System;

namespace Algorithims_Practice
{
    public class LinkedList<T> where T : IComparable
    {
        private Node<T> Head { get; set; }

        public Node<T> Get(int index)
        {
            Node<T> currentNode = this.Head;
            int count = 0;
            while (currentNode != null)
            {
                if (count == index)
                    return currentNode;
                count++;
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public Node<T> GetTail()
        {
            Node<T> currentNode = this.Head;
            while (currentNode != null && currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public void Add(Node<T> newNode)
        {
            if (this.Head == null)
            {
                this.Head = newNode;
                return;
            }
            GetTail().Next = newNode;
        }

        public static void Delete(LinkedList<T> list, Node<T> nodeToDelete)
        {
            if (list != null && nodeToDelete != null && list.Head != null)
            {
                Node<T> prevNode = null;
                var curNode = list.Head;
                while (curNode.Value.CompareTo(nodeToDelete.Value) != 0)
                {
                    prevNode = curNode;
                    curNode = curNode.Next;
                }
                if (prevNode == null)
                {
                    list.Head = curNode.Next;
                }
                prevNode.Next = curNode.Next;
            }
        }

        public static void Delete(Node<int> nodeToDelete)
        {
            if (nodeToDelete != null)
            {
                if (nodeToDelete.Next == null)
                {
                    nodeToDelete = null;
                    return;
                }
                nodeToDelete.Value = nodeToDelete.Next.Value;
                DeleteNextNode(nodeToDelete);
            }

        }
        public static void DeleteNextNode(Node<int> node)
        {
            if (node != null && node.Next != null)
            {
                node.Next = node.Next.Next;
            }
        }
        public static int CheckIfMerges(LinkedList<int> list1, LinkedList<int> list2)
        {
            if (list1 == null || list2 == null || list1.Head == null || list2.Head == null)
            {
                return -1;
            }

            if (list1.GetTail() == list2.GetTail())
            {
                int length1 = list1.GetLength();
                int length2 = list2.GetLength();
                int startingIndex = Math.Abs(length1 - length2);
                var NodeOfLongList = list1.Get(startingIndex);
                var NodeOfShortList = list2.Get(0);
                if (length1 < length2)
                {
                    NodeOfLongList = list2.Get(startingIndex);
                    NodeOfShortList = list1.Get(0);
                }
                var counter = 0;
                while (NodeOfLongList.Next != null)
                {
                    if (NodeOfLongList == NodeOfShortList)
                    {
                        break;
                    }
                    counter++;
                    NodeOfLongList = NodeOfLongList.Next;
                    NodeOfShortList = NodeOfShortList.Next;
                }
                return counter + startingIndex;
            }
            return -1;
        }

        public static void ReverseLinkedList(LinkedList<int> list)
        {
            if (list != null)
            {
                Node<int> prevNode = null;
                Node<int> currNode = list.Head;
                while (currNode != null)
                {
                    Node<int> next = currNode.Next;
                    currNode.Next = prevNode;
                    prevNode = currNode;
                    currNode = next;
                }
                list.Head = prevNode;
            }
        }

        public int GetLength()
        {
            var counter = 0;
            if (Head != null)
            {
                counter++;
                var currentNode = Head;
                while (currentNode.Next != null)
                {
                    counter++;
                    currentNode = currentNode.Next;
                }
            }
            return counter;
        }

    }

    public class Node<T>
    {
        internal Node<T> Next { get; set; }
        public T Value { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }
}
