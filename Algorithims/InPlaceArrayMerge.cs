using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims_Practice
{
    public class InPlaceArrayMerge
    {
        public static void InPlaceMerge(int[] smallArray, int[] bigArray)
        {
            if (smallArray == null || smallArray.Length != 0 || bigArray == null || bigArray.Length != 0)
            {
                merge(smallArray, bigArray);
            }
        }

        private static void merge(int[] smallArray, int[] bigArray)
        {
            int smallArrayPointer = smallArray.Length - 1;
            int bigArrayPointer = bigArray.Length - smallArray.Length - 1;
            int constuctionPointer = bigArray.Length - 1;

            for (int i = bigArray.Length - 1; i >= 0; i--)
            {
                if (smallArrayPointer >= 0 && bigArrayPointer >= 0)
                {
                    if (bigArray[bigArrayPointer] >= smallArray[smallArrayPointer])
                    {
                        bigArray[i] = bigArray[bigArrayPointer--];
                    }
                    else
                    {
                        bigArray[i] = smallArray[smallArrayPointer--];
                    }
                }
                else
                {
                    if (smallArrayPointer >= 0)
                    {
                        bigArray[i] = smallArray[smallArrayPointer--];
                    }
                }
            }
        }
    }
}
