using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims_Practice
{
    public class ReverseSinglyLinkedList
    {
        public static void ReverseLinkedList(LinkedList<int> list)
        {
            if (list != null)
            {
                for (int i = 0; i < list.GetLength() / 2; i++)
                {
                    swap(list, i, list.GetLength() - i);
                }
            }
        }

        private static void swap(LinkedList<int> list, int index1, int index2)
        {
                }
            }
        }

        }
    }

    public class LinkedList<T>
    {
        internal LinkedListNode<int> Head { get; set; }
        internal LinkedListNode<int> Tail { get; set; }

        public LinkedList(LinkedListNode<int> headNode)
        {
            this.Head = headNode;
            this.Tail = headNode;
        }

        public LinkedListNode<int> Get(int index)
        {
            LinkedListNode<int> currentNode = this.Head != null ? this.Head : null;

            for (int i = 0; i < index; i++)
            {
                if (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                else
                {
                    break;
                }
            }

            return currentNode;
        }

        public void AddFront(LinkedListNode<int> newNode)
        {
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddBack(LinkedListNode<int> newNode)
        {
            Tail.Next = newNode;
            Tail = newNode;
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

    public class LinkedListNode<T>
    {
        internal LinkedListNode<int> Next { get; set; }
        public int Value { get; }

        public LinkedListNode(int value)
        {
            this.Value = value;
        }
    }
}
