public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        if(nums.Length == 0) return 0;
        var set = new HashSet<int>();
        foreach(var item in nums)
        {
            if(nums.Contains(item + 1))
                set.Add(item);
        }


        return set.Count + 1;
    }
}
