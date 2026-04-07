public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int[] result = new int[2];
        for (int i = 0; i<nums.Length; i++){
            if (map.ContainsKey(target - nums[i])){
                return [i, map[target - nums[i]]];
            }
            else{
                map[nums[i]] = i;
            }
        }
        return [];
    }
}