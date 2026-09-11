public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        return ToDict(nums).OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
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
