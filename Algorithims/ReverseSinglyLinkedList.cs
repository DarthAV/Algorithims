
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
            if (index1 == index2)
            {
                return;
            }

            var x = list.Get(index1);
            var y = list.Get(index2);


            var xNext = x.Next;
            var yNext = y.Next;
            LinkedListNode<int> xPrev = null;
            LinkedListNode<int> yPrev = null;

            var isXHead = list.Head == x;
            var isYHead = list.Head == y;
            var isXTail = list.Tail == x;
            var isYTail = list.Tail == y;

            if (!isXHead)
            {
                xPrev = list.Get(index1 - 1);
                xPrev.Next = y;
            }
            if (!isYHead)
            {
                yPrev = list.Get(index2 - 1);
                yPrev.Next = x;
            }


            if (isXHead)
            {
                list.Head = y;
                y.Next = xNext;
            }
            else if (isYHead)
            {
                list.Head = x;
                x.Next = yNext;
            }
            if (isXTail)
            {
                list.Tail = y;
                y.Next = xNext;
            }
            else if (isYTail)
            {
                list.Tail = x;
                x.Next = yNext;
            }

        }
    }

}