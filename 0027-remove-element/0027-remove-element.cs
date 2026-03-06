public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // 快慢指針，也叫讀寫指針
        // 思路：當快指針不等於 val 時，寫入 array
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