using System;
using System.Diagnostics;

namespace DataStructuresAndAlgorithmsDeepDive
{
    public static class ArraysExample
    {
        public static void Demo()
        {
            var intArray = new int[7];

            intArray[0] = 20;
            intArray[1] = 35;
            intArray[2] = -15;
            intArray[3] = 7;
            intArray[4] = 55;
            intArray[5] = 1;
            intArray[6] = -22;

            var sortedArray = BubbleSort(intArray);
            PrintArray(sortedArray);
        }

        private static int[] BubbleSort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var a = 0; a < array.Length - 1; a++)
                {
                    var first = array[a];
                    var second = array[a + 1];
                    var tmp = first;

                    if (first <= second) continue;

                    array[a] = second;
                    array[a + 1] = first;
                }
            }

            return array;
        }

        public static int[] SelectionSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static int[] InsertionSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static int[] ShellSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static int[] MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static int[] QuickSort(int[] array)
        {
            throw new NotImplementedException();
        }

        private static void PrintArray(Array array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} -> {array.GetValue(i)}");
            }
        }
    }
}
