public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, right = 0, sum = 0, length = nums.Length + 1;
        for (right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            while(sum >= target)
            {
                if (right - left + 1 < length) length = right - left + 1;
                sum -= nums[left++];
                if (sum < target) break;
            }
        }
        if (length == nums.Length + 1) return 0;
        return length;
        // 暴力法，會造成 Time Limit Exceeded
        // int subsum = 0, subnum = 0, result = nums.Length, find = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     subsum = 0;
        //     subnum = 0;
        //     for (int j = i; j < nums.Length; j++)
        //     {
        //         subsum += nums[j];
        //         subnum += 1;
        //         if (subsum >= target) 
        //         {
        //             if (subnum <= result)
        //             {
        //                 result = subnum;
        //             }
        //             find = 1;
        //             break;
        //         }
        //     }
        // }
        // if (find == 0) return 0;
        // return result;
    }
}