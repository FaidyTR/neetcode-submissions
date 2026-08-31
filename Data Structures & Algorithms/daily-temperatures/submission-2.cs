public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        int nbDays = 0;
        for (int i = 0; i < temperatures.Length - 1; i++ )
        {
            for (int j = i + 1; j < temperatures.Length; j++)
            {
                nbDays ++;
                if ( temperatures[i] < temperatures[j]){ break;}
                if (j == temperatures.Length - 1) { nbDays = 0; }
            }
            result[i] = nbDays;
            nbDays = 0;
        }
        result[temperatures.Length - 1] = 0;
        return result;
    }
}
