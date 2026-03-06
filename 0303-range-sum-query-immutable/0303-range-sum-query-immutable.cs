public class NumArray {
    // 使用前綴和，在m次搜尋時，時間複雜度是 O(m)
    // 
    private int[] prefixSum;

    public NumArray(int[] nums) {
        prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i-1] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        if (left == 0) return prefixSum[right];
        return prefixSum[right] - prefixSum[left-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */