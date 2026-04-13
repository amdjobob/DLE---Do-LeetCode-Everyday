public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        // 解題思路：將nums排列後，用雙指針法
        List<IList<int>> result = new List<IList<int>>();
        nums.Sort();
        for(int i = 0; i<nums.Length-2; i++){
            int tempJ = -500;
            if(i != 0 && nums[i] == nums[i-1]) continue; // 避免i重複
            for(int j = i+1; j<nums.Length-2; j++){
                int left = j+1, right = nums.Length-1;
                if(nums[j] == tempJ) continue; // 避免j重複
                while(left < right){
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    if (sum < target){
                        left++;
                    }
                    else if (sum > target){
                        right--;
                    }
                    else{
                        result.Add([nums[i], nums[j], nums[left], nums[right]]);
                        left++;
                        while(left < right && nums[left] == nums[left-1]) left++; // 避免left重複
                    }
                }
                tempJ = nums[j];
            }
        }
        return result;
    }
}