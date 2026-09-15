public class Solution {
    public int[] ProductExceptSelf(int[] nums)
 {
     var res = new int[nums.Length];
     for (int i = 0; i < nums.Length; i++)
         res[i] = MultiplyNumber(nums, nums[i]);
     return res;
 }

 private int MultiplyNumber(int[] nums , int val)
 {
     int multply = 1;
     foreach(var item in nums)
         if(item != val)
             multply *= item;
     return multply;
 }
}
