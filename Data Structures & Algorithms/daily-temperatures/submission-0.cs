public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        List<int> result = new List<int>();
        Stack<int> dayNb = new Stack<int>();

        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            dayNb.Push(temperatures[i]);

            for (int j = i + 1; j < temperatures.Length; j++)
            {
                if (temperatures[i] > temperatures[j])
                {
                    dayNb.Push(temperatures[j]);
                }
                else if (temperatures[i] < temperatures[j])
                {
                    break;
                }

                if (j == temperatures.Length - 1)
                {
                    dayNb.Clear();
                }
            }

            result.Add(dayNb.Count);
            dayNb.Clear();
        }

        result.Add(0);

        return result.ToArray();
    }
}