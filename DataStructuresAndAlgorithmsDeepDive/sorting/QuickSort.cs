using System.Linq;

namespace DataStructuresAndAlgorithmsDeepDive
{
    public static class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            if (array.Length < 2)
            {
                return array;
            }

            var pivotInd = array.Length / 2;
            var pivot = array[pivotInd];
            var min = array.Where((x, ind) => x <= pivot && ind != pivotInd).ToArray();
            var max = array.Where(x => x > pivot).ToArray();

            var minSorted = Sort(min);
            var maxSorted = Sort(max);

            var result = new int[min.Length + 1 + max.Length];
            minSorted.CopyTo(result, 0);
            result[min.Length] = pivot;
            maxSorted.CopyTo(result, min.Length + 1);

            return result;
        }

        public static void SortAlt(int[] input, int start, int end)
        {
            if (end - start < 2)
            {
                return;
            }

            var pivotIndex = Partition(input, start, end);
            SortAlt(input, start, pivotIndex);
            SortAlt(input, pivotIndex + 1, end);
        }

        private static int Partition(int[] input, in int start, in int end)
        {
            var pivot = input[start];
            var i = start;
            var j = end;

            while (i < j)
            {
                // Empty loop
                while (i < j && input[--j] >= pivot)
                {
                }

                if (i < j)
                {
                    input[i] = input[j];
                }

                // Empty loop
                while (i < j && input[++i] <= pivot)
                {
                }

                if (i < j) // TODO: ?
                {
                    input[j] = input[i];
                }
            }

            input[j] = pivot;
            return j;
        }
    }
}
