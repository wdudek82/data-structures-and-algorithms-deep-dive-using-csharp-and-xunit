using System;
using System.IO.Compression;
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
            var midInd = -1;
            var endInd = array.Length - 1;
            while (true)
            {
                midInd = (startInd + endInd) / 2;
                var mid = array[midInd];
                if (mid == num)
                {
                    break;
                } else if (mid < num)
                {

                }
            }
            return 
        }
    }
}
