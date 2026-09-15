public class Solution {
    public int ClimbStairs(int n) {     
        if(n == 2)
            return  2;
        if(n == 1)
            return 1;
        if(n == 0)
            return 0;
        return (n - 1) + (n - 2);
    }
}
