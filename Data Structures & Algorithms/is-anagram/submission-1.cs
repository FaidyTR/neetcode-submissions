public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        Dictionary<char,int> map = new();
        for (int i = 0; i < s.Length; i++)
        {
            if(!map.TryAdd(s[i], 1)) map[s[i]]++;
            if(!map.TryAdd(t[i], -1)) map[t[i]] --;
        }
        foreach(var pair in map)
        {
            if(pair.Value != 0) return false;
        }
        return true;

        

    }
}
