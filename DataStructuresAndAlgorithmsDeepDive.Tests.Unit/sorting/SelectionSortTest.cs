using System;
using Xunit;

namespace DataStructuresAndAlgorithmsDeepDive.Tests.Unit
{
    public class SelectionSortTest
    {
        [Fact]
        public void when_array_is_empty_then_return_empty_array()
        {
            var array = new int[] { };

            SelectionSort.Sort(array);

            Assert.Equal(new int[] { }, array);
        }

        [Fact]
        public void when_array_has_one_element_output_equals_input()
        {
            var array = new[] {1};

            SelectionSort.Sort(array);

            Assert.Equal(new[] {1}, array);
        }

        [Theory]
        [InlineData(new[] {20, 35, -15, 7}, new[] {-15, 7, 20, 35})]
        [InlineData(new[] {20, 35, -15, 7, 55, 1, -22}, new[] {-22, -15, 1, 7, 20, 35, 55})]
        public void when_unsorted_array_of_different_integers_provided_then_array_of_asc_sorted_integers_is_returned(
            int[] array, int[] expectedArray)
        {
            SelectionSort.Sort(array);

            Assert.Equal(expectedArray, array);
        }

        [Fact]
        public void when_sorted_array_of_different_integers_provided_then_input_same_as_output()
        {
            var array = new[] {-15, 7, 20, 35};

            SelectionSort.Sort(array);

            Assert.Equal(new[] {-15, 7, 20, 35}, array);
        }

        [Fact]
        public void when_provided_array_of_different_integers_contains_duplicates_then_all_duplicates_are_preserved()
        {
            var array = new[] {7, 20, -15, 35, 1, 1, 1};

            SelectionSort.Sort(array);

            Assert.Equal(new[] {-15, 1, 1, 1, 7, 20, 35}, array);
        }

        [Fact]
        public void when_array_of_same_integers_provided_then_input_is_the_same_as_the_output()
        {
            var array = new[] {1, 1, 1, 1, 1};

            SelectionSort.Sort(array);

            Assert.Equal(new[] {1, 1, 1, 1, 1}, array);
        }

        [Fact]
        public void when_first_element_is_larger_then_the_second_then_swap_elements_in_place()
        {
            var array = new[] {4, 1, 7, 2};
            const int ind1 = 0;
            const int ind2 = 1;

            SelectionSort.Swap(array, ind1, ind2);

            Assert.Equal(new[] {1, 4, 7, 2}, array);
        }

        [Theory]
        [InlineData(0, 4)]
        [InlineData(0, -1)]
        public void when_provided_ind1_or_ind2_is_out_of_range_then_swap_will_throw_the_exception(int ind1,
            int ind2)
        {
            var array = new[] {1, 4, 7, 2};

            Assert.Throws<IndexOutOfRangeException>(() => SelectionSort.Swap(array, ind1, ind2));
        }
    }
}
