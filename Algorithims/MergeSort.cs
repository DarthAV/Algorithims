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
                Seperate(mergeSortArray, 0, mergeSortArray.Length);
            }
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
