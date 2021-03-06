using DataStructuresAndAlgorithmsDeepDive.searching;
using Xunit;

namespace DataStructuresAndAlgorithmsDeepDive.Tests.Unit.searching
{
    public class BinarySearchTest
    {
        [Fact]
        [InlineData(new[] {1}, 10, -1)]
        [InlineData(new[]{1, 2, 3, 4, 5, 6}, 8, -1)]
        [InlineData(new[] {2, 4, 6, 8, 10, 12, 14, 16}, 3, -1)]
        public void when_searching_for_non_existing_value_return_index_minus_one_and_0_steps()
        {
            var binarySearch = new BinarySearch();

            var result = binarySearch.SearchIter(new[] {1}, 10);

            Assert.Equal(-1, result);
        }

        [Theory]
        [InlineData(new[]{1}, 1, 0)]
        [InlineData(new[]{1, 2, 3, 4, 5, 6}, 4, 3)]
        [InlineData(new[]{1, 2, 3, 4, 5, 6}, 6, 5)]
        [InlineData(new[] {2, 4, 6, 8, 10, 12, 14, 16}, 8, 3)]
        public void when_searching_for_existing_value_return_index_and_number_of_steps(int[] array, int num, int expected)
        {
            var binarySearch = new BinarySearch();

            var result = binarySearch.SearchIter(array, num);

            Assert.Equal(expected, result);
        }
    }
}
