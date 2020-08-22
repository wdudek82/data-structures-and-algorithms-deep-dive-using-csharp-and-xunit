using System.Linq;

namespace DataStructuresAndAlgorithmsDeepDive.searching
{
    public class BinarySearch
    {
        public int Search(int[] array, int num)
        {
            if (array.Length == 1)
            {
                var found = array[0] == num;
                return found ? 0 : -1;
            }

            var midInd = array.Length / 2;
            var mid = array[midInd];
            if (num < mid)
            {
                return Search(array.Take(midInd).ToArray(), num);
            }

            return num > mid ? Search(array.Skip(midInd + 1).ToArray(), num) : midInd;
        }

        public int SearchIter(int[] array, int num)
        {
            var startInd = 0;
            var endInd = array.Length;

            while (startInd < endInd)
            {
                var midInd = (startInd + endInd) / 2;
                var midNum = array[midInd];

                if (num < midNum)
                {
                    endInd = midInd;
                }
                else if (num > midNum)
                {
                    startInd = midInd + 1;
                }
                else if (num == midNum)
                {
                    return midInd;
                }
            }

            return -1;
        }
    }
}
