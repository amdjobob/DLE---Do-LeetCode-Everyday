public class Solution {
    public int PivotIndex(int[] nums) {
        int[] prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for(int i = 1; i<nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + nums[i];
        }
        if(prefixSum[nums.Length - 1] - prefixSum[0] == 0) return 0;
        for(int i = 1; i<nums.Length-1; i++)
        {
            if (prefixSum[i - 1] == prefixSum[nums.Length - 1] - prefixSum[i]) return i;
        }
        if(prefixSum[nums.Length - 2] == 0) return nums.Length-1;
        return -1;
    }
}