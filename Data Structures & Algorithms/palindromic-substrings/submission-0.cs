public class Solution
{
    public int CountSubstrings(string s)
    {
        if (s.Length == 0) return 0;
        int counter = s.Length;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (Checking(s[i].ToString() + s[j].ToString()))
                    counter++;
            }
        }
        return counter;
    }

    private bool Checking(string str)
    {
        var chars = str.ToCharArray();
        Array.Reverse(chars);

        return new string(chars) == str;
    }
}