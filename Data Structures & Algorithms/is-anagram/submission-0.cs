public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        List<char> l1 = new List<char>();
        List<char> l2 = new List<char>();

        FillList(l1, s);
        FillList(l2, t);

        for (int i = 0; i < s.Length; i++)
        {
            if (l2.Contains(l1[i]))
            {
                l2.Remove(l1[i]);
            }
            else
            {
                return false;
            }
        }

        return l2.Count == 0;
    }

    public void FillList(List<char> l, string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            l.Add(s[i]);
        }
    }
}