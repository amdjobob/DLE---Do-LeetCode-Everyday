public class Solution {
    public bool IsHappy(int n) {
        // 怕進入迴圈，所以建一個HashSet來檢查
        HashSet<int> exist = new HashSet<int>();
        int m = n;
        while(!exist.Contains(m)){
            exist.Add(m);
            int sum = 0;
            while(m != 0){ // 計算每位數的平方和
                sum += (m % 10)*(m % 10);
                m /= 10;
            }
            m = sum;
            if (m==1){
                return true;
            }
        }
        return false;
    }
}