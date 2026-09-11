public class Solution {
    public int SingleNumber(int[] nums) {
        var dict = new Dictionary<int, int>();

        foreach(var item in nums)
            dict[item] = dict.GetValueOrDefault(item , 0) + 1;

        foreach(var item in dict)
            if(item.Value == 1)
                return item.Key;

        return -1;
    }
}
