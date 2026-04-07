public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> setNums1 = new HashSet<int>(); // 創建兩 HashSet，HashSet有唯一性
        HashSet<int> setNums2 = new HashSet<int>();

        foreach(int i in nums1) setNums1.Add(i);
        foreach(int i in nums2) setNums2.Add(i);
        setNums1.IntersectWith(setNums2);  // 交集

        int[] result = new int[setNums1.Count];
        int count = 0;
        foreach(var i in setNums1){  // 直接用 foreach 就能抓
            result[count++] = i;
        }
        return result;
    }
}