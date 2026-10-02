public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(k == 0) return false;
        return CounterDictionary(GetDict(nums)) != k;
    }
     private static int CounterDictionary(Dictionary<int,int> dict)
 {
     var counter = 0;
     foreach (var item in dict)
         if (item.Value == 1)
             counter++;
     return counter;
 }

 private static Dictionary<int,int> GetDict(int[] nums)
 {
     var dict = new Dictionary<int, int>();
     foreach (var item in nums)
         dict[item] = dict.GetValueOrDefault(item, 0) + 1;

     return dict;
 }
}