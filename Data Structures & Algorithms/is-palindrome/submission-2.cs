public class Solution
{
    public bool IsPalindrome(string s)
    {
        var res = GetStringNew(s);
        int start = 0, end = res.Length - 1;

        if (res.Length == 1) return true;

        while (start < end)
        {
            if (res[start] != res[end])
                return false;
            start++;
            end--;
        }
        return true;
    }

    private string GetStringNew(string s)
    {
        var res = "";

        foreach (var item in s)
            if (!char.IsDigit(item) && item != ' ' && char.IsAsciiLetter(item))
                res += item.ToString().ToLower();
        return res;
    }
}