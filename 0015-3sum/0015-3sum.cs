public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        int[] numsSorted = new int[nums.Length];
        nums.CopyTo(numsSorted);
        numsSorted.Sort();
        int count = 0;
        for(int i = 0; i<nums.Length-2; i++){
            int left = i+1, right = nums.Length-1;
            if(i!=0 && numsSorted[i] == numsSorted[i-1]) continue;
            while(left < right){
                int sum = numsSorted[i] + numsSorted[left] + numsSorted[right];
                if (sum < 0){
                    left++;
                }
                else if (sum > 0){
                    right--;
                }
                else{
                    result.Add([numsSorted[i], numsSorted[left], numsSorted[right]]);
                    left++;
                    while(numsSorted[left] == numsSorted[left-1] && left!=nums.Length-1) left++;
                }
            }
        }
        return result;
    }
}