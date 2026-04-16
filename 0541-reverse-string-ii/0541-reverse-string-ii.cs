public class Solution {
    public string ReverseStr(string s, int k) {
        StringBuilder SB = new StringBuilder(s);
        for(int i = 0; i<s.Length; i=i+k*2){
            if(i+k<s.Length){
                for(int j = 0; j<k/2; j++){
                // i最左邊     i+k-1最右邊
                // i+j左到右   i+k-1-j右到左
                    (SB[i+j], SB[i+k-1-j]) = (SB[i+k-1-j], SB[i+j]);
                }
            }
            else{ // 剩餘元素不足K個
                for(int j = 0; j<(s.Length-i)/2; j++){
                    (SB[i+j], SB[s.Length-1-j]) = (SB[s.Length-1-j], SB[i+j]);
                }
            }
        }
        return SB.ToString();
    }
}