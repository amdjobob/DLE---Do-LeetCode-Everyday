public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> hash = new HashSet<int>();
        int[] result = new int[2];
        for (int i = 0; i<nums.Length; i++){
            if (hash.Contains(target - nums[i])){
                return [i, nums.IndexOf(target - nums[i])];
            }
            else{
                hash.Add(nums[i]);
            }
        }
        return [];
    }
}