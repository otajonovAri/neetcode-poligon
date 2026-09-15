public class Solution {
   public int[] ProductExceptSelf(int[] nums)
    {
        int[] ans = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
            ans[i] = GetNumbers(nums, nums[i]);

        return ans;
    }

    static int GetNumbers(int[] nums, int i)
    {
        int sum = 1;
        foreach(var item in nums)
            if (item != i)
                sum *= item;

        return sum;
    }
}
