public class Solution {

    public string Encode(IList<string> strs) {
        string encode = "";
        foreach (string ch in strs)
        {
            encode += ch;
        }

        return encode;
    }

    public List<string> Decode(string s) {
        List<string> decodeList = new List<string>();
        int j = 0;
        for(int i = 1; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                decodeList.Add(s.Substring(j, i - j));
                j = i;
            }
        }
        decodeList.Add(s.Substring(j, s.Length - j));

        return decodeList;
   }
}
