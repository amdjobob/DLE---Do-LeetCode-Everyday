public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] table = new int[26];
        foreach(char c in magazine){
            table[c-'a'] += 1;
        }
        foreach(char c in ransomNote){
            if(--table[c-'a'] < 0) return false;
        }
        return true;
    }
}