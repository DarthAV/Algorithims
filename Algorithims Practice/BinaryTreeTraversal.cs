using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims_Practice
{
    class BinaryTreeTraversal
    {
        public static void Main()
        {
            BinaryTree tree = new BinaryTree();

            tree.DefaultPopulate();

            tree.InorderTraversal();
            tree.PreorderTraversal();
            tree.PostorderTraversal();

            Console.ReadLine();
        }


        public class BinaryTree
        {
            private Node head;

            public void DefaultPopulate()
            {
                Insert(8);
                Insert(3);
                Insert(10);
                Insert(1);
                Insert(6);
                Insert(4);
                Insert(7);
                Insert(14);
                Insert(13);
            }

            private void Insert(int value)
            {
                head = InsertRecursive(head, value);
            }
            private Node InsertRecursive(Node currentNode, int value)
            {
                if (currentNode == null)
                {
                    return new Node(value);
                }
                else
                {
                    if (value < currentNode.Value)
                    {
                        currentNode.ChildLeft = InsertRecursive(currentNode.ChildLeft, value);
                    }
                    else
                    {
                        currentNode.ChildRight = InsertRecursive(currentNode.ChildRight, value);
                    }
                }
                return currentNode;

            }
            public void InorderTraversal()
            {
                InorderTraversalRecursive(head);
                Console.WriteLine(" ");
            }

            private void InorderTraversalRecursive(Node currentNode)
            {
                if (currentNode != null)
                {
                    InorderTraversalRecursive(currentNode.ChildLeft);
                    Console.Write(" " + currentNode.Value);
                    InorderTraversalRecursive(currentNode.ChildRight);

                }
            }

            public void PreorderTraversal()
            {
                PreorderTraversalRecursive(head);
                Console.WriteLine(" ");
            }

            private void PreorderTraversalRecursive(Node currentNode)
            {
                if (currentNode != null)
                {
                    Console.Write(" " + currentNode.Value);
                    PreorderTraversalRecursive(currentNode.ChildLeft);
                    PreorderTraversalRecursive(currentNode.ChildRight);
                }
            }

            public void PostorderTraversal()
            {
                PostorderTraversalRecursive(head);
                Console.WriteLine(" ");
            }

            private void PostorderTraversalRecursive(Node currentNode)
            {
                if (currentNode != null)
                {
                    PostorderTraversalRecursive(currentNode.ChildLeft);
                    PostorderTraversalRecursive(currentNode.ChildRight);
                    Console.Write(" " + currentNode.Value);
                }
            }

            private class Node
            {
                internal Node ChildLeft { get; set; }
                internal Node ChildRight { get; set; }
                public int Value { get; set; }

                public Node(int value)
                {
                    this.Value = value;
                }
            }

        }
    }
}
