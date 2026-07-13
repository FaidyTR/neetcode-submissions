public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        if (set.Count == nums.Length){return false;}
        return true;
        
    }
}