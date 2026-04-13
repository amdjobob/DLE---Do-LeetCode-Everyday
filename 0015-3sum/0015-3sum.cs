public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        // 解題思路：將nums排列後，用雙指針法
        List<IList<int>> result = new List<IList<int>>();
        nums.Sort();
        for(int i = 0; i<nums.Length-2; i++){
            int left = i+1, right = nums.Length-1;
            if(i!=0 && nums[i] == nums[i-1]) continue; // 避免i重複
            while(left < right){
                int sum = nums[i] + nums[left] + nums[right];
                if (sum < 0){
                    left++;
                }
                else if (sum > 0){
                    right--;
                }
                else{
                    result.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    while(left < right && nums[left] == nums[left-1]) left++; // 避免left重複
                }
            }
        }
        return result;
    }
}