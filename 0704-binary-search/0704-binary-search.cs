public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1, m;
        while(l <= r){ // 因為 = 是有意義的，所以用 <=
            m = (l + r)/2;
            if (target < nums[m]) r = m - 1; // target在左區間且不是middle，目標範圍在 left ~ m - 1
            else if (target > nums[m]) l = m + 1;
            else return m;
        }
        return -1;
    }
}