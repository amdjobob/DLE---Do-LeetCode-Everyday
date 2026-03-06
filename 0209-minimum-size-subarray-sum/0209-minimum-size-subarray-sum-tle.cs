public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        // 暴力法，會造成 Time Limit Exceeded
        int subsum = 0, subnum = 0, result = nums.Length, find = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            subsum = 0;
            subnum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                subsum += nums[j];
                subnum += 1;
                if (subsum >= target) 
                {
                    if (subnum <= result)
                    {
                        result = subnum;
                    }
                    find = 1;
                    break;
                }
            }
        }
        if (find == 0) return 0;
        return result;
    }
}
