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

        [Fact]
        public void when_unsorted_array_of_different_integers_provided_then_array_of_asc_sorted_integers_is_returned()
        {
            var array = new[] {20, 35, -15, 7};

            SelectionSort.Sort(array);

            Assert.Equal(new[] {-15, 7, 20, 35}, array);
        }

        [Fact]
        public void when_sorted_array_of_different_integers_provided_then_input_same_as_output()
        {
            var array = new[] {-15, 7, 20, 35};

            SelectionSort.Sort(array);

            Assert.Equal(new[] {-15, 7, 20, 35}, array);
        }

        [Fact]
        public void when_array_of_same_integers_provided_then_input_is_the_same_as_the_output()
        {
            var array = new[] {1, 1, 1, 1, 1};

            SelectionSort.Sort(array);

            Assert.Equal(new[] {1, 1, 1, 1, 1}, array);
        }

        [Fact]
        public void when_first_element_of_array_is_larger_then_the_second_then_swap_elements_in_place()
        {
            var array = new[] {4, 1, 7, 2};
            const int ind = 0;

            SelectionSort.Swap(array, ind);

            Assert.Equal(new[] {1, 4, 7, 2}, array);
        }

        [Fact]
        public void when_first_element_of_array_is_smaller_then_the_second_then_the_array_stays_unchanged()
        {
            var array = new[] {1, 4, 7, 2};
            const int ind = 0;

            SelectionSort.Swap(array, ind);

            Assert.Equal(new[] {1, 4, 7, 2}, array);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(-1)]
        public void when_provided_index_is_last_or_out_of_range_then_swap_will_throw_the_exception(int index)
        {
            var array = new[] {1, 4, 7, 2};

            Assert.Throws<IndexOutOfRangeException>(() => SelectionSort.Swap(array, index));
        }
    }
}
