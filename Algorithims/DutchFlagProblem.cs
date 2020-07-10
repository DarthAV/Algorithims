

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
                        continue;
                    }
                    if (array[backPointer] != firstNum)
                    {
                        backPointer--;
                        continue;
                    }
                    swap(array, frontPointer, backPointer);
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
                int firstNum = array.Min(); //? 
                int lastNum = array.Max(); //?
                int middleNum = 0;
                foreach (var item in array) //?
                {
                    if (item != firstNum && item != lastNum)
                    {
                        middleNum = item;
                        break;
                    }
                }

                while (middlePointer <= backPointer)
                {
                    if (array[frontPointer] == firstNum)
                    {
                        frontPointer++;
                        continue;
                    }
                    if (array[backPointer] == lastNum)
                    {
                        backPointer--;
                        continue;
                    }
                    if (middlePointer == -1)
                    {
                        middlePointer = frontPointer;
                    }

                    if (array[middlePointer] == middleNum)
                    {
                        middlePointer++;
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