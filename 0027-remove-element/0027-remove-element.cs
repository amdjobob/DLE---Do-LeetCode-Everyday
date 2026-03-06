public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int result = nums.Length;
        for (int i = 0; i < result; i++)
        {
            if (val == nums[i])
            {
                for (int j = i; j < nums.Length-1; j++)
                {
                    nums[j] = nums[j+1];
                }
                result = result - 1;
                i = i-1;
            }
        }
        return result;
    }
}