public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int comp = target - nums[i];

            if (map.TryGetValue(comp, out int index))
            {
                return new int[] {index, i};
            }
            
            map.Add(nums[i],i);
        }
        return null;
    }
}
