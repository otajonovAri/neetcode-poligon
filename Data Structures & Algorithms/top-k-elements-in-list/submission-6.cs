public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
        => GetDict(nums)
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(x => x.Key)
        .ToArray();

 private Dictionary<int, int> GetDict(int[] nums)
 {
     var dict = new Dictionary<int, int>();
     foreach (var item in nums)
         dict[item] = dict.GetValueOrDefault(item, 0) + 1;
     return dict;
 }
}
