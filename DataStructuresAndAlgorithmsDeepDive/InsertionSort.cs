using System;
using System.Numerics;

namespace DataStructuresAndAlgorithmsDeepDive
{
    public static class InsertionSort
    {
        public static void Sort(int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }

            for (var i = 1; i < array.Length; i++)
            {
                var lastUnsortedNum = array[i];
                for (var j = i - 1; j >= 0; j--)
                {
                    var prevNum = array[j];

                    if (prevNum < lastUnsortedNum)
                    {
                        array[j + 1] = lastUnsortedNum;
                        break;
                    }

                    array[j + 1] = prevNum;
                    if (j < 1)
                    {
                        array[j] = lastUnsortedNum;
                    }
                }
            }
        }
    }
}
