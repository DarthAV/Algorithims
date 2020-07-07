using System;
using System.Collections.Generic;

namespace Algorithims_Practice
{


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
        public List<int> InorderTraversal()
        {
            List<int> output = new List<int>();
            InorderTraversalRecursive(head, output);
            return output;
        }

        private void InorderTraversalRecursive(Node currentNode, List<int> output)
        {
            if (currentNode != null)
            {
                InorderTraversalRecursive(currentNode.ChildLeft, output);
                output.Add(currentNode.Value);
                InorderTraversalRecursive(currentNode.ChildRight, output);

            }
        }

        public List<int> PreorderTraversal()
        {
            List<int> output = new List<int>();
            PreorderTraversalRecursive(head, output);
            return output;
        }

        private void PreorderTraversalRecursive(Node currentNode, List<int> output)
        {
            if (currentNode != null)
            {
                output.Add(currentNode.Value);
                PreorderTraversalRecursive(currentNode.ChildLeft, output);
                PreorderTraversalRecursive(currentNode.ChildRight, output);
            }
        }

        public List<int> PostorderTraversal()
        {
            List<int> output = new List<int>();
            PostorderTraversalRecursive(head, output);
            return output;
        }

        private void PostorderTraversalRecursive(Node currentNode, List<int> output)
        {
            if (currentNode != null)
            {
                PostorderTraversalRecursive(currentNode.ChildLeft, output);
                PostorderTraversalRecursive(currentNode.ChildRight, output);
                output.Add(currentNode.Value);
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
