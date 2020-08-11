
namespace Algorithims_Practice
{
    public class ReverseSinglyLinkedList
    {
        public static void ReverseLinkedList(LinkedList<int> list)
        {
            if (list != null)
            {
                LinkedListNode<int> previous = null;
                LinkedListNode<int> current = list.Head;
                while (current != null)
                {
                    LinkedListNode<int> next = current.Next;
                    current.Next = previous;
                    previous = current;
                    current = next;
                }
                list.Head = previous;
            }
        }
    }
}