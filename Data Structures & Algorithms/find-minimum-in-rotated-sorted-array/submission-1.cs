public class Solution {
    public int FindMin(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        if (nums.Length == 2)
            return nums[0] < nums[1] ? nums[0] : nums[1];

        int start = 0, end = nums.Length - 1, minNum = int.MaxValue;


        while (start <= end)
        {
            if (nums[start] < minNum) minNum = nums[start];
            if (nums[end] < minNum) minNum = nums[end];

            start++;
            end--;
        }

        return minNum;
    }
}
