public class Solution {
    public void ReverseString(char[] s) {
        int L = s.Length;
        for(int i = 0; i<L/2; i++){
            char tmp = s[i];
            s[i] = s[L-i-1];
            s[L-i-1] = tmp;
        }
    }
}