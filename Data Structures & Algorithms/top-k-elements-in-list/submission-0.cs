public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        List<int> numsList = nums.ToList();
        int[] result = new int[k];

        foreach (int num in numsList)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map.Add(num, 1);
            }
        }

        for (int i = 0; i < k; i++)
        {
            result[i] = map.First().Key;

            foreach (var pair in map)
            {
                if (pair.Value > map[result[i]])
                {
                    result[i] = pair.Key;
                }
            }

            map.Remove(result[i]);
        }

        return result;
    }
}