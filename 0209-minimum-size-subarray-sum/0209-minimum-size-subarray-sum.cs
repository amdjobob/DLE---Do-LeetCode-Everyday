public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, right = 0, sum = 0, length = nums.Length + 1;
        for (right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            while(sum >= target)
            {
                if (right - left + 1 < length) length = right - left + 1;
                sum -= nums[left++];
                if (sum < target) break;
            }
        }
        if (length == nums.Length + 1) return 0;
        return length;
    }
}