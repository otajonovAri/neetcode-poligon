public class Solution {
    public int MaxProfit(int[] prices) {
         int current = 0, max = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if(prices[i] - prices[i - 1] > 0)
                current = prices[i] - prices[i - 1];
            if (max < current)
                max = current;
        }
        return max + 1;
    }
}
