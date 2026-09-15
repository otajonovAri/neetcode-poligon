public class Solution {
   public int[] TopKFrequent(int[] nums, int k)
    {
        var list = new List<int>();
        foreach(var item in ToDict(nums))
            if(item.Value >= k)
                list.Add(item.Key);

        return list.ToArray();
    }

    static Dictionary<int, int> ToDict(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            dict.TryGetValue(num, out int count);
            dict[num] = count + 1;
        }
        
        return dict;
    }
}
