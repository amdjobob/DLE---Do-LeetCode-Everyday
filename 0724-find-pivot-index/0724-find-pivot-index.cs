public class Solution {
    public int PivotIndex(int[] nums) {
        // 解題思路：因為要使用到連續數字的和，所以使用前綴和來解題。
        int[] prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for(int i = 1; i<nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + nums[i];
        }

        if(prefixSum[nums.Length - 1] - prefixSum[0] == 0) return 0; // 處理例外：在index = 0時 leftSum == rightSum
        for(int i = 1; i<nums.Length-1; i++)
        {
            if (prefixSum[i - 1] == prefixSum[nums.Length - 1] - prefixSum[i]) return i;
        }
        if(prefixSum[nums.Length - 2] == 0) return nums.Length-1; // 處理例外：在index = 最大時 leftSum == rightSum
        return -1;
    }
}