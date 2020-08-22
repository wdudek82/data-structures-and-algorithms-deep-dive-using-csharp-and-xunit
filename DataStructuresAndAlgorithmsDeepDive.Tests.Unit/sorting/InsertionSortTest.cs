using DataStructuresAndAlgorithmsDeepDive.sorting;
using Xunit;

namespace DataStructuresAndAlgorithmsDeepDive.Tests.Unit
{
    public class InsertionSortTest
    {
        [Fact]
        public void when_array_is_empty_then_return_empty_array()
        {
            var array = new int[] { };

            InsertionSort.Sort(array);

            Assert.Equal(new int[] { }, array);
        }

        [Fact]
        public void when_array_has_one_element_output_equals_input()
        {
            var array = new[] {1};

            InsertionSort.Sort(array);

            Assert.Equal(new[] {1}, array);
        }

        [Theory]
        [InlineData(new[] {20, 35, -15, 55, 7}, new[] {-15, 7, 20, 35, 55})]
        [InlineData(new[] {20, 35, -15, 7, 55, 1, -22}, new[] {-22, -15, 1, 7, 20, 35, 55})]
        public void when_unsorted_array_of_different_integers_provided_then_array_of_asc_sorted_integers_is_returned(
            int[] array, int[] expectedArray)
        {
            InsertionSort.Sort(array);

            Assert.Equal(expectedArray, array);
        }

        [Fact]
        public void when_sorted_array_of_different_integers_provided_then_input_same_as_output()
        {
            var array = new[] {-15, 7, 20, 35};

            InsertionSort.Sort(array);

            Assert.Equal(new[] {-15, 7, 20, 35}, array);
        }

        [Fact]
        public void when_provided_array_of_different_integers_contains_duplicates_then_all_duplicates_are_preserved()
        {
            var array = new[] {7, 20, -15, 35, 1, 1, 1};

            InsertionSort.Sort(array);

            Assert.Equal(new[] {-15, 1, 1, 1, 7, 20, 35}, array);
        }

        [Fact]
        public void when_array_of_same_integers_provided_then_input_is_the_same_as_the_output()
        {
            var array = new[] {1, 1, 1, 1, 1};

            InsertionSort.Sort(array);

            Assert.Equal(new[] {1, 1, 1, 1, 1}, array);
        }
    }
}
