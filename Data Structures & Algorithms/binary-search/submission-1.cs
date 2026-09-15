public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0 , right = nums.Length - 1 , midd = 0;

        while(left <= right)
        {
            midd = (left + right) / 2;
            if(nums[midd] == target) return midd;

            if(nums[midd] < right) left = midd + 1;
            else right = midd - 1;
        }

        return -1;
    }
}
