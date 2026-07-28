public class Solution {

    public string Encode(IList<string> strs) {
        string encode = "";
        string ch;
        foreach (string s in strs)
        {
            ch = s + "#";
            encode += ch;
        }
        return encode;
    }

    public List<string> Decode(string s) {
        List<string> decodeList = new List<string>();
        int j = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == '#')
            {
                decodeList.Add(s.Substring(j, i - j));
                j = i + 1;
            }
        }

        return decodeList;
   }
}
