public class Solution {
    public bool hasDuplicate(int[] nums) {
        var len = nums.Length;
        return nums.Distinct().Count() != len;
    }
}