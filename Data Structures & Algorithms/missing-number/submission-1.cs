public class Solution {
    public int MissingNumber(int[] nums) {
        int[] ans = new int[nums.Length + 1];
        
        for (int i = 0; i <= nums.Length; i++)
            ans[i] = i;
    
        foreach(var item in ans)
            if (!nums.Contains(item))
                return item;

        return -1;
    }
}
