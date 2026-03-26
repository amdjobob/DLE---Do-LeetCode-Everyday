public class Solution {
    public IList<string> CommonChars(string[] words) {
        int[] count = new int[26];
        foreach(char c in words[0]) { count[c - 'a'] += 1; }
        for (int i = 1; i < words.Length; i++)
        {
            int[] count2 = new int[26];
            foreach(char c in words[i]) { count2[c - 'a'] += 1; }
            for(int j = 0; j < 26; j++)
            {
                count[j] = count[j] > count2[j] ? count2[j] : count[j];
            }
        }
        int num = 0;
        foreach(int i in count) if (i != 0) num += i;
        string[] result = new string[num];
        for(int j = 0; j < 26; j++)
        {
            for (int i=0; i<count[j]; i++) result[--num] = ((char)(j + 'a')).ToString();
        }
        return result;
    }
}