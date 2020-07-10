

using System.Linq;

namespace Algorithims_Practice
{
    public class DutchFlagProblem
    {

        private static void swap(int[] array, int index1, int index2)
        {
            int temp = array[index2];
            array[index2] = array[index1];
            array[index1] = temp;
        }

        public static void TwoNumberSort(int[] array)
        {
            if (array != null)
            {
                int frontPointer = 0;
                int backPointer = array.Length - 1;
                int firstNum = array.Min();

                while (frontPointer < backPointer)
                {
                    if (array[frontPointer] == firstNum)
                    {
                        frontPointer++;
                    }
                    if (array[backPointer] != firstNum)
                    {
                        backPointer--;
                    }

                    if (array[backPointer] == firstNum && array[frontPointer] != firstNum)
                    {
                        swap(array, frontPointer, backPointer);
                    }

                }
            }

        }

        public static void ThreeNumberSort(int[] array)
        {
            if (array != null)
            {
                int frontPointer = 0;
                int backPointer = array.Length - 1;
                int middlePointer = -1;
                int firstNum = array.Min();
                int lastNum = array.Max();
                int middleNum = 0;
                foreach (var item in array)
                {
                    if (item != firstNum && item != lastNum)
                    {
                        middleNum = item;
                        break;
                    }
                }
                while (frontPointer < backPointer && middlePointer <= backPointer && (middlePointer >= frontPointer || middlePointer == -1))
                {
                    if (array[frontPointer] == firstNum)
                    {
                        frontPointer++;
                    }
                    if (array[backPointer] == lastNum)
                    {
                        backPointer--;
                    }

                    if (array[frontPointer] != firstNum && middlePointer == -1)
                    {
                        middlePointer = frontPointer;
                    }
                    while (array[backPointer] != lastNum && array[frontPointer] != firstNum)
                    {

                        if (array[middlePointer] == middleNum)
                        {
                            middlePointer++;
                        }
                        if (middlePointer > backPointer || middlePointer < frontPointer)
                        {
                            break;
                        }
                        else if (array[middlePointer] == lastNum)
                        {
                            swap(array, middlePointer, backPointer);
                        }
                        else if (array[middlePointer] == firstNum)
                        {
                            swap(array, middlePointer, frontPointer);
                        }
                    }


                }
            }
        }


        public static void MergeSort(int[] mergeSortArray)
        {
            Seperate(mergeSortArray, 0, mergeSortArray.Length);
        }

        private static void Seperate(int[] array, int start, int end)
        {
            int mid = 0;
            if (start < end)
            {
                mid = start + ((end - start) / 2);
            }
        }

        private static void Merge(int[] array, int start, int mid, int end)
        {

        }


    }
}