public class Solution 
{
    public bool hasDuplicate(int[] nums) 
    {
             return nums.Distinct().ToArray().Length != nums.Length;
    }
}
