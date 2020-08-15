using System;

namespace DataStructuresAndAlgorithmsDeepDive
{
    public static class BubbleSort
    {
        public static void Sort(int[] array)
        {
            for (var lastUnsortedIndex = array.Length - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
            {
                for (var i = 0; i < lastUnsortedIndex; i++)
                {
                    Swap(array, i);
                }
            }
        }

        public static void Swap(int[] array, int ind)
        {
            var first = array[ind];
            var second = array[ind + 1];

            if (first <= second) return;
            array[ind] = second;
            array[ind + 1] = first;
        }
    }
}
