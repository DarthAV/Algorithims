using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims_Practice
{
    public class MergeSort
    {
        public static void performMergeSort(int[] mergeSortArray)
        {
            if (mergeSortArray != null && mergeSortArray.Length != 0)
            {
                Sort(mergeSortArray, 0, mergeSortArray.Length - 1);
            }
        }

        private static void Sort(int[] array, int startIndex, int endIndex)
        {            
            if (startIndex < endIndex)
            {
                var midIndex = startIndex + ((endIndex - startIndex) / 2);
                Sort(array, startIndex, midIndex);
                Sort(array, midIndex + 1, endIndex);
                Merge(array, startIndex, midIndex, endIndex);
            }
        }

        private static void Merge(int[] array, int startIndex, int midIndex, int endIndex)
        {
            var finalArray = new int[endIndex + 1 - startIndex];
            var firstIndex = startIndex;
            var secondIndex = midIndex + 1;
            for (int i = 0; i < finalArray.Length; i++)
            {
                if (firstIndex <= midIndex && secondIndex <= endIndex)
                {
                    if (array[firstIndex] <= array[secondIndex])
                    {
                        finalArray[i] = array[firstIndex++];
                    }
                    else
                    {
                        finalArray[i] = array[secondIndex++];
                    }
                }
                else
                {
                    if (firstIndex <= midIndex)
                    {
                        finalArray[i] = array[firstIndex++];
                    }
                    else if (secondIndex <= endIndex)
                    {
                        finalArray[i] = array[secondIndex++];
                    }
                }
            }
            for (int i = 0; i <= endIndex-startIndex; i++)
            {
                array[startIndex + i] = finalArray[i];
            }
        }
    }
}
