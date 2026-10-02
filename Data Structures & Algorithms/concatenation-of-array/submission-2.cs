public class Solution {
    public int[] GetConcatenation(int[] nums) {
       var list = new List<int>();
        GetAddingNumbers(nums, list); // First Range
        GetAddingNumbers(nums, list); // Dublication Range
        return list.ToArray();
    }
        private static void GetAddingNumbers(int[] nums , List<int> list)
    {
        foreach (var item in nums)
            list.Add(item);
    }
}