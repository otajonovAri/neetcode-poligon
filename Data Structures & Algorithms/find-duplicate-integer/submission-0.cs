public class Solution {
    public int FindDuplicate(int[] nums) {
        var dict = new Dictionary<int,int>();
        foreach(var item in nums)
            dict[item] = dict.GetValueOrDefault(item , 0) + 1;
            
        var maxValue = dict.Values.Max();

        foreach(var item in dict)
            if(item.Value == maxValue) return item.Key;

        return -1;    
    }
}
