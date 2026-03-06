public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int slow = 0;
        for (int fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != val)
            {
                nums[slow] = nums[fast];
                slow = slow + 1;
            }
        }
        return slow;
    }
}