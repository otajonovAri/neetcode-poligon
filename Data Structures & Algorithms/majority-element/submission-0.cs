public class Solution {
       public int MajorityElement(int[] nums)
    {
        var len = nums.Length - 1;
        var max = new List<int>();
        foreach(var item in GetDict(nums))
            if (item.Value >= len / 2)
                max.Add(item.Key);

        return (int)max.OrderByDescending(x => x).ToList()[0];
    }
    private static Dictionary<int,int> GetDict(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;
        return dict;
    }
}