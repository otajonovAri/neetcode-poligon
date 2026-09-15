public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        var sortNums = nums
            .DistinctBy(x => x)
            .OrderBy(x => x)
            .ToArray();

        int count = 1;
        
        for(int i = 1; i < sortNums.Length; i++)
            if (sortNums[i] - sortNums[i - 1] == 1)
                count++;

        return count;
    }
}
