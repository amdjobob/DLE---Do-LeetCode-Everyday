public class Solution {
    public int[] SortedSquares(int[] nums) {
        // 因為 array 有排序過，最大最小值一定出現在頭或尾，所以使用雙指針
        int left = 0, right = nums.Length-1, index = nums.Length-1;
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[left] * nums[left] > nums[right] * nums[right])
            {
                result[index--] = nums[left] * nums[left];
                left += 1;
            }
            else 
            {
                result[index--] = nums[right] * nums[right];
                right -= 1;
            }
        }
        return result;
    }
}