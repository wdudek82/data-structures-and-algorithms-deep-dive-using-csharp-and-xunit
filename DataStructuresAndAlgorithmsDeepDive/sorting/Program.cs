using DataStructuresAndAlgorithmsDeepDive.searching;

namespace DataStructuresAndAlgorithmsDeepDive.sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArraysExample.Demo();
            // var array = new[] {20, 35, -15, 7};
            var array = new[] {1, 2, 3, 4, 5, 6};
            var binarySearch = new BinarySearch();
            var result = binarySearch.Search(array, 4);
        }
    }
}
