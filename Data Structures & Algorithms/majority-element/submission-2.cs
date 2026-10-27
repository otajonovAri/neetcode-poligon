public class Solution {
     public int MajorityElement(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        GetCounterDict(nums,dict);
        var len = (nums.Length - 1) / 2;
        
        foreach(var item in dict)
            if(item.Value >= len)
                return item.Key;

        return -1;
    }

    private static void GetCounterDict(int[] nums, Dictionary<int, int> dict)
    {
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;
    }
}