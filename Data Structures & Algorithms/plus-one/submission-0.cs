public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int num = Convert.ToInt32(GetString(digits)) + 1;
        var list = new List<int>();

        while (num != 0)
        {
            list.Add(num % 10);
            num /= 10;
        }

        list.Reverse();
        return list.ToArray();
    }

    private string GetString(int[] arr)
    {
        string res = "";
        foreach (var item in arr)
            res += item.ToString();
        return res;
    }
}