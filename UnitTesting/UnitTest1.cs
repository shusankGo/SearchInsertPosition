using LeetCode;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 0, 3, 7, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 2 }, 2, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6, 5)]
        [InlineData(new int[] { 2, 4, 6, 8, 10 }, 6, 2)]
        [InlineData(new int[] { 10, 15, 22, 33 }, 9, 0)]
        public void SearchInsertPositionTest(int[] nums, int target, int expected)
        {
            var actual = SearchInsertPosition.PositionSearch(nums, target);

            Assert.Equal(expected, actual);
        }
    }
}

