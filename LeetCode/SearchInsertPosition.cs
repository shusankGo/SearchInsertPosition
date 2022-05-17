namespace LeetCode
{
    public class SearchInsertPosition
    {
        public static int PositionSearch(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                    return i;
            }
            return nums.Length;
        }
    }
}