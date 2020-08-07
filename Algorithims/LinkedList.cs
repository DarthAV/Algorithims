
namespace Algorithims_Practice
{
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

        public static void Delete(LinkedList<int> list, LinkedListNode<int> nodeToDelete)
        {
            if (list != null && nodeToDelete != null && list.Head != null)
            {
                LinkedListNode<int> prevNode = null;
                var curNode = list.Head;
                while (curNode.Value != nodeToDelete.Value)
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

        public static void Delete(LinkedListNode<int> nodeToDelete)
        {
            if (nodeToDelete != null)
            {
                if (nodeToDelete.Next == null)
                {
                    //not done, needs to set itself to nothing
                    return;
                }
                //not done, needs to set itself to the next one

            }
        }
        public static void DeleteNextNode(LinkedListNode<int> node)
        {
            if (node != null && node.Next != null)
            {
                node.Next = node.Next.Next;
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
