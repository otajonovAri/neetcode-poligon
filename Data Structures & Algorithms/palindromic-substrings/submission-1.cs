public class Solution
{
    public int CountSubstrings(string s)
    {
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            string temp = "";

            for (int j = i; j < s.Length; j++)
            {
                temp += s[j]; 
                if (IsPalindrome(temp))
                    count++;
            }
        }

        return count;
    }

    private bool IsPalindrome(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars) == str;
    }
}
