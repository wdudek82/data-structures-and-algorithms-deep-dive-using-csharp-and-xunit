using Xunit;

namespace DataStructuresAndAlgorithmsDeepDive.Tests.Unit
{
    public class QuickSortTest
    {
        [Fact]
        public void when_array_is_empty_then_return_empty_array()
        {
            var array = new int[] { };

            var sortedArray = QuickSort.Sort(array);

            Assert.Equal(new int[] { }, sortedArray);
        }

        [Fact]
        public void when_array_has_one_element_output_equals_input()
        {
            var array = new[] {1};

            var sortedArray = QuickSort.Sort(array);

            Assert.Equal(new[] {1}, sortedArray);
        }

        [Fact]
        public void when_unsorted_array_of_different_integers_provided_then_array_of_asc_sorted_integers_is_returned()
        {
            var array = new[] {20, 35, -15, 7};

            var sortedArray = QuickSort.Sort(array);

            Assert.Equal(new[] {-15, 7, 20, 35}, sortedArray);
        }

        [Fact]
        public void when_sorted_array_of_different_integers_provided_then_input_same_as_output()
        {
            var array = new[] {-15, 7, 20, 35};

            var sortedArray = QuickSort.Sort(array);

            Assert.Equal(new[] {-15, 7, 20, 35}, sortedArray);
        }

        [Fact]
        public void when_array_of_same_integers_provided_then_input_same_as_output()
        {
            var array = new[] {1, 1, 1, 1, 1};

            var sortedArray = QuickSort.Sort(array);

            Assert.Equal(new[] {1, 1, 1, 1, 1}, sortedArray);
        }

        [Fact]
        public void when_array_is_empty_then_return_empty_array__recursive()
        {
            var array = new int[] { };

            QuickSort.SortAlt(array, 0, array.Length);

            Assert.Equal(new int[] { }, array);
        }

        [Fact]
        public void when_array_has_one_element_output_equals_input__recursive()
        {
            var array = new[] {1};

            QuickSort.SortAlt(array, 0, array.Length);

            Assert.Equal(new[] {1}, array);
        }

        [Fact]
        public void when_unsorted_array_of_different_integers_provided_then_array_of_asc_sorted_integers_is_returned__recursive()
        {
            var array = new[] {20, 35, -15, 7};

            QuickSort.SortAlt(array, 0, array.Length);

            Assert.Equal(new[] {-15, 7, 20, 35}, array);
        }

        [Fact]
        public void when_sorted_array_of_different_integers_provided_then_input_same_as_output__recursive()
        {
            var array = new[] {-15, 7, 20, 35};

            QuickSort.SortAlt(array, 0, array.Length);

            Assert.Equal(new[] {-15, 7, 20, 35}, array);
        }

        [Fact]
        public void when_array_of_same_integers_provided_then_input_same_as_output__recursive()
        {
            var array = new[] {1, 1, 1, 1, 1};

            QuickSort.SortAlt(array, 0, array.Length);

            Assert.Equal(new[] {1, 1, 1, 1, 1}, array);
        }
    }
}
