namespace DataStructuresAndAlgorithmsDeepDive
{
    public static class SelectionSort
    {
        public static void Sort(int[] array)
        {
            for (var lastUnsortedInd = array.Length - 1; lastUnsortedInd > 1; lastUnsortedInd--)
            {
                var largestNumInd = 0;
                for (var i = 0; i <= lastUnsortedInd; i++)
                {
                    if (array[i] > array[largestNumInd])
                    {
                        largestNumInd = i;
                    }
                }

                Swap(array, lastUnsortedInd, largestNumInd);
            }
        }

        public static void Swap(int[] array, int ind1, int ind2)
        {
            var tmp = array[ind1];
            array[ind1] = array[ind2];
            array[ind2] = tmp;
        }
    }
}