public class Solution {
    public IList<string> CommonChars(string[] words) {
        string[] allShow = new string[words[0].Length];
        int count = 0;
        for (int i = 0; i < words[0].Length; i++) allShow[i] = words[0][i].ToString();
        for (int i = 0; i < allShow.Length; i++)
        {
            int showed = 1;
            for (int j = 1; j < words.Length; j++)
            {
                for (int k = 0; k < words[j].Length; k++)
                {
                    if (words[j][k].ToString() == allShow[i])
                    {
                        words[j] = words[j].Remove(k,1);
                        showed++;
                        break;
                    }
                }
            }
            if (showed != words.Length) allShow[i] = "";
            else count++;
        }
        string[] result = new string[count];
        foreach(string s in allShow)
        {
            if (s != "") result[--count] = s;
        }
        return result;
    }
}
