public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        // 解題思路：把4個array變成2個array
        //          找AB的和 + CD的和 = 0 出現的次數
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach(int i in nums1){
            foreach(int j in nums2){
                int sum = i+j;
                if(map.ContainsKey(sum)){
                    map[sum] += 1;
                }
                else{
                    map[sum] = 1;
                }
            }
        }
        int result = 0;
        foreach(int i in nums3){
            foreach(int j in nums4){
                int sum = i+j;
                if(map.ContainsKey(-sum)){
                    result += map[-sum];
                }
            }
        }
        return result;
    }
}