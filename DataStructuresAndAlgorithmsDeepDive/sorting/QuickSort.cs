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
    }
}
