public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        // 滑動窗口法，用一個迴圈控制兩個指標
        // 思路：當 sum < target 時，增加範圍
        //       直到 sum > target 時，減小範圍
        int left = 0, right = 0, sum = 0, length = nums.Length + 1;
        for (right = 0; right < nums.Length; right++) // 第一個迴圈控制終點
        {
            sum += nums[right];
            while(sum >= target)
            {
                if (right - left + 1 < length) length = right - left + 1; // 縮小範圍
                sum -= nums[left++];
                if (sum < target) break;
            }
        }
        if (length == nums.Length + 1) return 0;
        return length;
    }
}