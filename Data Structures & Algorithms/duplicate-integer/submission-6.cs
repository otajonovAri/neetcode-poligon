public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>(nums);
        return nums.Length != set.Count();
    }
}