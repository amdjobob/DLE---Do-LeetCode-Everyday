public class NumArray {
    // 前綴和：newArray[n] = array[0] + ... + array[n]
    // 計算 a 到 b，只需一次減法，不需要作加法 n 次
    // 好處：計算 m 次時，時間複雜度為 O(m)
    //       若使用暴力法，時間複雜度為 O(m*n)
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
        if (left == 0) return prefixSum[right]; // 例外情況：從0到n，只須回傳right
        return prefixSum[right] - prefixSum[left-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */