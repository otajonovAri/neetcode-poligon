public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        if(nums.Length <= k) return nums;
     var list = new List<int>();
     foreach(var item in GetDict(nums))
         if(item.Value >= k)
             list.Add(item.Key);

     return list.ToArray();
    }

 private Dictionary<int, int> GetDict(int[] nums)
 {
     var dict = new Dictionary<int, int>();
     foreach (var item in nums)
         dict[item] = dict.GetValueOrDefault(item, 0) + 1;
     return dict;
 }
}
