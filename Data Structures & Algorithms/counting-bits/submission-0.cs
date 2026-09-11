public class Solution
{
    public int[] CountBits(int n)
    {
        int[] result = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            result[i] = CountSetBits(i);
        }
        return result;
    }

    private int CountSetBits(int i)
    {
        string str = Convert.ToString(i, 2);
        int count = 0;
        foreach (var c in str)
        {
            if(c == '1')
                count++;
        }
        return count;
    }
}
