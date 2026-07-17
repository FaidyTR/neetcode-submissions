
public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        List<List<string>> listResult = new List<List<string>>();
        List<string> lStrs = new List<string>();

        List<string> words = strs.ToList();

        while (words.Count > 0)
        {
            lStrs.Add(words[0]);
            words.RemoveAt(0);

            for (int i = 0; i < words.Count; i++)
            {
                if (AreAnagram(lStrs[0], words[i]))
                {
                    lStrs.Add(words[i]);
                    words.RemoveAt(i);
                    i--;
                }
            }

            listResult.Add(new List<string>(lStrs));
            lStrs.Clear();
        }

        return listResult;
    }

    private bool AreAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < str1.Length; i++)
        {
            if (map.ContainsKey(str1[i]))
                map[str1[i]]++;
            else
                map.Add(str1[i], 1);

            if (map.ContainsKey(str2[i]))
                map[str2[i]]--;
            else
                map.Add(str2[i], -1);
        }

        foreach (var pair in map)
        {
            if (pair.Value != 0)
                return false;
        }

        return true;
    }
}

