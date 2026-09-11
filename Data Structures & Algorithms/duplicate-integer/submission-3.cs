public class Solution
{
    public bool hasDuplicate(int[] nums)
    => new HashSet<int>(nums).Count != nums.Length;
}