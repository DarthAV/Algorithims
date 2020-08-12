
namespace Algorithims_Practice
{
    public class ReverseSinglyLinkedList
    {
        public static void ReverseLinkedList(LinkedList<int> list)
        {
            if (list != null)
            {
                LinkedListNode<int> prevNode = null;
                LinkedListNode<int> currNode = list.Head;
                while (currNode != null)
                {
                    LinkedListNode<int> nextNode = currNode.Next;
                    currNode.Next = prevNode;
                    prevNode = currNode;
                    currNode = nextNode;
                }
                list.Head = prevNode;
            }
        }
    }
}